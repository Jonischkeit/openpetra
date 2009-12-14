﻿/*************************************************************************
 *
 * DO NOT REMOVE COPYRIGHT NOTICES OR THIS FILE HEADER.
 *
 * @Authors:
 *       timop
 *
 * Copyright 2004-2009 by OM International
 *
 * This file is part of OpenPetra.org.
 *
 * OpenPetra.org is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * OpenPetra.org is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with OpenPetra.org.  If not, see <http://www.gnu.org/licenses/>.
 *
 ************************************************************************/
using System;
using System.Collections.Specialized;
using System.Data;
using System.Data.Odbc;
using System.Xml;
using System.IO;
using Ict.Common;
using Ict.Common.IO;
using Ict.Common.DB;
using Ict.Common.Verification;
using Ict.Petra.Shared.MPartner;
using Ict.Petra.Shared.MPartner.Partner.Data;
using Ict.Petra.Server.MPartner.Partner.Data.Access;
using Ict.Petra.Server.MPartner.Common;

namespace Ict.Petra.Server.MPartner.ImportExport.WebConnectors
{
    /// <summary>
    /// import and export partner data
    /// </summary>
    public class TImportExportWebConnector
    {
        private static void ParsePartners(ref PartnerEditTDS AMainDS, XmlNode ACurNode)
        {
            XmlNode LocalNode = ACurNode;

            while (LocalNode != null)
            {
                if (LocalNode.Name.StartsWith("PartnerGroup"))
                {
                    ParsePartners(ref AMainDS, LocalNode.FirstChild);
                }
                else if (LocalNode.Name.StartsWith("Partner"))
                {
                    PPartnerRow newPartner = AMainDS.PPartner.NewRowTyped();

                    // get a new partner key
                    Int64 SiteKey = Convert.ToInt64(TYml2Xml.GetAttributeRecursive(LocalNode, "SiteKey"));
                    Int64 newPartnerKey = -1;

                    do
                    {
                        newPartnerKey = TNewPartnerKey.GetNewPartnerKey(SiteKey);
                        TNewPartnerKey.SubmitNewPartnerKey(SiteKey, newPartnerKey, ref newPartnerKey);
                        newPartner.PartnerKey = newPartnerKey;
                    } while (newPartnerKey == -1);

                    if (TYml2Xml.GetAttributeRecursive(LocalNode, "class") == MPartnerConstants.PARTNERCLASS_FAMILY)
                    {
                        PFamilyRow newFamily = AMainDS.PFamily.NewRowTyped();
                        newFamily.PartnerKey = newPartner.PartnerKey;
                        newFamily.FamilyName = TYml2Xml.GetAttributeRecursive(LocalNode, "LastName");
                        newFamily.FirstName = TYml2Xml.GetAttribute(LocalNode, "FirstName");
                        newFamily.Title = TYml2Xml.GetAttribute(LocalNode, "Title");
                        AMainDS.PFamily.Rows.Add(newFamily);

                        newPartner.PartnerClass = MPartnerConstants.PARTNERCLASS_FAMILY;
                        newPartner.AddresseeTypeCode = MPartnerConstants.PARTNERCLASS_FAMILY;

                        newPartner.PartnerShortName =
                            Calculations.DeterminePartnerShortName(newFamily.FamilyName, newFamily.Title, newFamily.FirstName);
                    }

                    if (TYml2Xml.GetAttributeRecursive(LocalNode, "class") == MPartnerConstants.PARTNERCLASS_PERSON)
                    {
                        // TODO
                    }
                    else if (TYml2Xml.GetAttributeRecursive(LocalNode, "class") == MPartnerConstants.PARTNERCLASS_ORGANISATION)
                    {
                        // TODO
                    }
                    else
                    {
                        // TODO AVerificationResult add failing problem: unknown partner class
                    }

                    newPartner.StatusCode = TYml2Xml.GetAttributeRecursive(LocalNode, "status");
                    AMainDS.PPartner.Rows.Add(newPartner);

                    XmlNode addressNode = TYml2Xml.GetChild(LocalNode, "Address");

                    if (addressNode == null)
                    {
                        // add the empty location
                        PPartnerLocationRow partnerlocation = AMainDS.PPartnerLocation.NewRowTyped(true);
                        partnerlocation.SiteKey = 0;
                        partnerlocation.PartnerKey = newPartner.PartnerKey;
                        partnerlocation.DateEffective = DateTime.Now;
                        partnerlocation.LocationType = "HOME";
                        AMainDS.PPartnerLocation.Rows.Add(partnerlocation);
                    }
                    else
                    {
                        // TODO: avoid duplicate addresses, reuse existing locations
                        PLocationRow location = AMainDS.PLocation.NewRowTyped(true);
                        location.LocationKey = (AMainDS.PLocation.Rows.Count + 1) * -1;
                        location.SiteKey = 0;
                        location.CountryCode = TYml2Xml.GetAttributeRecursive(addressNode, "Country");
                        location.StreetName = TYml2Xml.GetAttributeRecursive(addressNode, "Street");
                        location.City = TYml2Xml.GetAttributeRecursive(addressNode, "City");
                        location.PostalCode = TYml2Xml.GetAttributeRecursive(addressNode, "PostCode");
                        AMainDS.PLocation.Rows.Add(location);

                        PPartnerLocationRow partnerlocation = AMainDS.PPartnerLocation.NewRowTyped(true);
                        partnerlocation.SiteKey = 0;
                        partnerlocation.LocationKey = location.LocationKey;
                        partnerlocation.PartnerKey = newPartner.PartnerKey;
                        partnerlocation.SendMail = true;
                        partnerlocation.DateEffective = DateTime.Now;
                        partnerlocation.LocationType = "HOME";
                        partnerlocation.EmailAddress = TYml2Xml.GetAttributeRecursive(addressNode, "Email");
                        AMainDS.PPartnerLocation.Rows.Add(partnerlocation);
                    }
                }

                LocalNode = LocalNode.NextSibling;
            }
        }

        /// <summary>
        /// for all negative location numbers, get the new location number;
        /// this assumes that the order of locations is still the same
        /// </summary>
        /// <returns></returns>
        private static bool ApplyNewLocationNumbers(ref PartnerEditTDS AMainDS)
        {
            foreach (PartnerEditTDSPPartnerLocationRow partnerlocationRow in AMainDS.PPartnerLocation.Rows)
            {
                if (partnerlocationRow.LocationKey < 0)
                {
                    partnerlocationRow.LocationKey = AMainDS.PLocation[(partnerlocationRow.LocationKey * -1) - 1].LocationKey;
                }
            }

            return true;
        }

        /// <summary>
        /// imports partner data from file
        /// </summary>
        /// <returns></returns>
        public static bool ImportPartners(string AXmlPartnerData, out TVerificationResultCollection AVerificationResult)
        {
            PartnerEditTDS MainDS = new PartnerEditTDS();

            XmlDocument doc = new XmlDocument();

            doc.LoadXml(AXmlPartnerData);

            XmlNode root = doc.FirstChild.NextSibling.FirstChild;

            // import partner groups
            // advantage: can inherit some common attributes, eg. partner class, etc

            ParsePartners(ref MainDS, root);

            PartnerEditTDS InspectDS = MainDS.GetChangesTyped(true);

            TDBTransaction SubmitChangesTransaction;
            TSubmitChangesResult SubmissionResult = TSubmitChangesResult.scrError;

            AVerificationResult = null;

            if (InspectDS != null)
            {
                AVerificationResult = new TVerificationResultCollection();
                SubmitChangesTransaction = DBAccess.GDBAccessObj.BeginTransaction(IsolationLevel.Serializable);
                try
                {
                    if ((InspectDS.PPartner != null) && !PPartnerAccess.SubmitChanges(InspectDS.PPartner, SubmitChangesTransaction,
                            out AVerificationResult))
                    {
                        SubmissionResult = TSubmitChangesResult.scrError;
                    }
                    else if ((InspectDS.PFamily != null) && !PFamilyAccess.SubmitChanges(InspectDS.PFamily, SubmitChangesTransaction,
                                 out AVerificationResult))
                    {
                        SubmissionResult = TSubmitChangesResult.scrError;
                    }
                    else if ((InspectDS.PPerson != null) && !PPersonAccess.SubmitChanges(InspectDS.PPerson, SubmitChangesTransaction,
                                 out AVerificationResult))
                    {
                        SubmissionResult = TSubmitChangesResult.scrError;
                    }
                    else if ((InspectDS.PLocation != null)
                             && !PLocationAccess.SubmitChanges(InspectDS.PLocation, SubmitChangesTransaction, out AVerificationResult))
                    {
                        SubmissionResult = TSubmitChangesResult.scrError;
                    }
                    else
                    {
                        ApplyNewLocationNumbers(ref InspectDS);
                        SubmissionResult = TSubmitChangesResult.scrOK;
                    }

                    if ((SubmissionResult == TSubmitChangesResult.scrOK)
                        && (InspectDS.PPartnerLocation != null)
                        && !PPartnerLocationAccess.SubmitChanges(InspectDS.PPartnerLocation, SubmitChangesTransaction,
                            out AVerificationResult))
                    {
                        SubmissionResult = TSubmitChangesResult.scrError;
                    }
                    else
                    {
                        SubmissionResult = TSubmitChangesResult.scrOK;
                    }

                    if (SubmissionResult == TSubmitChangesResult.scrOK)
                    {
                        DBAccess.GDBAccessObj.CommitTransaction();
                    }
                    else
                    {
                        DBAccess.GDBAccessObj.RollbackTransaction();
                    }
                }
                catch (Exception e)
                {
                    TLogging.Log("after submitchanges: exception " + e.Message);

                    DBAccess.GDBAccessObj.RollbackTransaction();

                    throw new Exception(e.ToString() + " " + e.Message);
                }
            }

            return SubmissionResult == TSubmitChangesResult.scrOK;
        }
    }
}