/* Auto generated with nant generateORM
 * Do not modify this file manually!
 */
/*************************************************************************
 *
 * DO NOT REMOVE COPYRIGHT NOTICES OR THIS FILE HEADER.
 *
 * @Authors:
 *       auto generated
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
namespace Ict.Petra.Shared.MFinance.Gift.Data.Access
{
    using System;
    using System.Collections.Specialized;
    using System.Data;
    using System.Data.Odbc;
    using Ict.Common;
    using Ict.Common.DB;
    using Ict.Common.Verification;
    using Ict.Common.Data;
    using Ict.Petra.Shared;
    using Ict.Petra.Shared.MFinance.Gift.Data;
    using Ict.Petra.Shared.MSysMan.Data;
    using Ict.Petra.Shared.MFinance.Account.Data;
    using Ict.Petra.Shared.MPartner.Partner.Data;
    using Ict.Petra.Shared.MCommon.Data;
    using Ict.Petra.Shared.MPartner.Mailroom.Data;

    /// Media"" types of money received.  Eg: Cash, Check Credit Card.
    public class AMethodOfPaymentAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "AMethodOfPayment";

        /// original table name in database
        public const string DBTABLENAME = "a_method_of_payment";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, AMethodOfPaymentTable.TableId) + " FROM PUB_a_method_of_payment") +
                            GenerateOrderByClause(AOrderBy)), TTypedDataTable.GetTableName(AMethodOfPaymentTable.TableId), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out AMethodOfPaymentTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMethodOfPaymentTable();
            DBAccess.GDBAccessObj.SelectDT(AData, GenerateSelectClause(AFieldList, AMethodOfPaymentTable.TableId) + " FROM PUB_a_method_of_payment" + GenerateOrderByClause(AOrderBy), ATransaction, null, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(out AMethodOfPaymentTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out AMethodOfPaymentTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, String AMethodOfPaymentCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadByPrimaryKey(AMethodOfPaymentTable.TableId, ADataSet, new System.Object[1]{AMethodOfPaymentCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String AMethodOfPaymentCode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AMethodOfPaymentCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String AMethodOfPaymentCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AMethodOfPaymentCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out AMethodOfPaymentTable AData, String AMethodOfPaymentCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMethodOfPaymentTable();
            LoadByPrimaryKey(AMethodOfPaymentTable.TableId, AData, new System.Object[1]{AMethodOfPaymentCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out AMethodOfPaymentTable AData, String AMethodOfPaymentCode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AMethodOfPaymentCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out AMethodOfPaymentTable AData, String AMethodOfPaymentCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AMethodOfPaymentCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, AMethodOfPaymentRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadUsingTemplate(AMethodOfPaymentTable.TableId, ADataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, AMethodOfPaymentRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, AMethodOfPaymentRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMethodOfPaymentTable AData, AMethodOfPaymentRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMethodOfPaymentTable();
            LoadUsingTemplate(AMethodOfPaymentTable.TableId, AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMethodOfPaymentTable AData, AMethodOfPaymentRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMethodOfPaymentTable AData, AMethodOfPaymentRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMethodOfPaymentTable AData, AMethodOfPaymentRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadUsingTemplate(AMethodOfPaymentTable.TableId, ADataSet, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMethodOfPaymentTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMethodOfPaymentTable();
            LoadUsingTemplate(AMethodOfPaymentTable.TableId, AData, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMethodOfPaymentTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMethodOfPaymentTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_a_method_of_payment", ATransaction, false));
        }

        /// check if a row exists by using the primary key
        public static bool Exists(String AMethodOfPaymentCode, TDBTransaction ATransaction)
        {
            return Exists(AMethodOfPaymentTable.TableId, new System.Object[1]{AMethodOfPaymentCode}, ATransaction);
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(AMethodOfPaymentRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_a_method_of_payment" + GenerateWhereClause(TTypedDataTable.GetColumnStringList(AMethodOfPaymentTable.TableId), ATemplateRow, ATemplateOperators)), ATransaction, false,
                   GetParametersForWhereClause(AMethodOfPaymentTable.TableId, ATemplateRow)));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_a_method_of_payment" + GenerateWhereClause(TTypedDataTable.GetColumnStringList(AMethodOfPaymentTable.TableId), ASearchCriteria)), ATransaction, false,
            GetParametersForWhereClause(AMethodOfPaymentTable.TableId, ASearchCriteria)));
        }

        /// auto generated
        public static void LoadViaSFile(DataSet ADataSet, String AFileName, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AMethodOfPaymentTable.TableId, SFileTable.TableId, ADataSet, new string[1]{"a_process_to_call_c"},
                new System.Object[1]{AFileName}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSFile(DataSet AData, String AFileName, TDBTransaction ATransaction)
        {
            LoadViaSFile(AData, AFileName, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSFile(DataSet AData, String AFileName, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSFile(AData, AFileName, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSFile(out AMethodOfPaymentTable AData, String AFileName, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMethodOfPaymentTable();
            LoadViaForeignKey(AMethodOfPaymentTable.TableId, SFileTable.TableId, AData, new string[1]{"a_process_to_call_c"},
                new System.Object[1]{AFileName}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSFile(out AMethodOfPaymentTable AData, String AFileName, TDBTransaction ATransaction)
        {
            LoadViaSFile(out AData, AFileName, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSFile(out AMethodOfPaymentTable AData, String AFileName, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSFile(out AData, AFileName, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSFileTemplate(DataSet ADataSet, SFileRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AMethodOfPaymentTable.TableId, SFileTable.TableId, ADataSet, new string[1]{"a_process_to_call_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSFileTemplate(DataSet AData, SFileRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaSFileTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSFileTemplate(DataSet AData, SFileRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSFileTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSFileTemplate(out AMethodOfPaymentTable AData, SFileRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMethodOfPaymentTable();
            LoadViaForeignKey(AMethodOfPaymentTable.TableId, SFileTable.TableId, AData, new string[1]{"a_process_to_call_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSFileTemplate(out AMethodOfPaymentTable AData, SFileRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaSFileTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSFileTemplate(out AMethodOfPaymentTable AData, SFileRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSFileTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSFileTemplate(out AMethodOfPaymentTable AData, SFileRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSFileTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSFileTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AMethodOfPaymentTable.TableId, SFileTable.TableId, ADataSet, new string[1]{"a_process_to_call_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSFileTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaSFileTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSFileTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSFileTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSFileTemplate(out AMethodOfPaymentTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMethodOfPaymentTable();
            LoadViaForeignKey(AMethodOfPaymentTable.TableId, SFileTable.TableId, AData, new string[1]{"a_process_to_call_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSFileTemplate(out AMethodOfPaymentTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaSFileTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSFileTemplate(out AMethodOfPaymentTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSFileTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaSFile(String AFileName, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AMethodOfPaymentTable.TableId, SFileTable.TableId, new string[1]{"a_process_to_call_c"},
                new System.Object[1]{AFileName}, ATransaction);
        }

        /// auto generated
        public static int CountViaSFileTemplate(SFileRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AMethodOfPaymentTable.TableId, SFileTable.TableId, new string[1]{"a_process_to_call_c"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaSFileTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AMethodOfPaymentTable.TableId, SFileTable.TableId, new string[1]{"a_process_to_call_c"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void DeleteByPrimaryKey(String AMethodOfPaymentCode, TDBTransaction ATransaction)
        {
            DeleteByPrimaryKey(AMethodOfPaymentTable.TableId, new System.Object[1]{AMethodOfPaymentCode}, ATransaction);
        }

        /// auto generated
        public static void DeleteUsingTemplate(AMethodOfPaymentRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DeleteUsingTemplate(AMethodOfPaymentTable.TableId, ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static void DeleteUsingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            DeleteUsingTemplate(AMethodOfPaymentTable.TableId, ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static bool SubmitChanges(AMethodOfPaymentTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            return SubmitChanges(AMethodOfPaymentTable.TableId, ATable, ATransaction, out AVerificationResult, UserInfo.GUserInfo.UserID);
        }
    }

    /// This is used to track a partner's reason for contacting the organisation/sending money. Divided into Motivation Detail codes.
    public class AMotivationGroupAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "AMotivationGroup";

        /// original table name in database
        public const string DBTABLENAME = "a_motivation_group";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, AMotivationGroupTable.TableId) + " FROM PUB_a_motivation_group") +
                            GenerateOrderByClause(AOrderBy)), TTypedDataTable.GetTableName(AMotivationGroupTable.TableId), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out AMotivationGroupTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationGroupTable();
            DBAccess.GDBAccessObj.SelectDT(AData, GenerateSelectClause(AFieldList, AMotivationGroupTable.TableId) + " FROM PUB_a_motivation_group" + GenerateOrderByClause(AOrderBy), ATransaction, null, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(out AMotivationGroupTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out AMotivationGroupTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, Int32 ALedgerNumber, String AMotivationGroupCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadByPrimaryKey(AMotivationGroupTable.TableId, ADataSet, new System.Object[2]{ALedgerNumber, AMotivationGroupCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 ALedgerNumber, String AMotivationGroupCode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ALedgerNumber, AMotivationGroupCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 ALedgerNumber, String AMotivationGroupCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ALedgerNumber, AMotivationGroupCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out AMotivationGroupTable AData, Int32 ALedgerNumber, String AMotivationGroupCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationGroupTable();
            LoadByPrimaryKey(AMotivationGroupTable.TableId, AData, new System.Object[2]{ALedgerNumber, AMotivationGroupCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out AMotivationGroupTable AData, Int32 ALedgerNumber, String AMotivationGroupCode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ALedgerNumber, AMotivationGroupCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out AMotivationGroupTable AData, Int32 ALedgerNumber, String AMotivationGroupCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ALedgerNumber, AMotivationGroupCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, AMotivationGroupRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadUsingTemplate(AMotivationGroupTable.TableId, ADataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, AMotivationGroupRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, AMotivationGroupRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMotivationGroupTable AData, AMotivationGroupRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationGroupTable();
            LoadUsingTemplate(AMotivationGroupTable.TableId, AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMotivationGroupTable AData, AMotivationGroupRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMotivationGroupTable AData, AMotivationGroupRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMotivationGroupTable AData, AMotivationGroupRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadUsingTemplate(AMotivationGroupTable.TableId, ADataSet, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMotivationGroupTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationGroupTable();
            LoadUsingTemplate(AMotivationGroupTable.TableId, AData, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMotivationGroupTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMotivationGroupTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_a_motivation_group", ATransaction, false));
        }

        /// check if a row exists by using the primary key
        public static bool Exists(Int32 ALedgerNumber, String AMotivationGroupCode, TDBTransaction ATransaction)
        {
            return Exists(AMotivationGroupTable.TableId, new System.Object[2]{ALedgerNumber, AMotivationGroupCode}, ATransaction);
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(AMotivationGroupRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_a_motivation_group" + GenerateWhereClause(TTypedDataTable.GetColumnStringList(AMotivationGroupTable.TableId), ATemplateRow, ATemplateOperators)), ATransaction, false,
                   GetParametersForWhereClause(AMotivationGroupTable.TableId, ATemplateRow)));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_a_motivation_group" + GenerateWhereClause(TTypedDataTable.GetColumnStringList(AMotivationGroupTable.TableId), ASearchCriteria)), ATransaction, false,
            GetParametersForWhereClause(AMotivationGroupTable.TableId, ASearchCriteria)));
        }

        /// auto generated
        public static void LoadViaALedger(DataSet ADataSet, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AMotivationGroupTable.TableId, ALedgerTable.TableId, ADataSet, new string[1]{"a_ledger_number_i"},
                new System.Object[1]{ALedgerNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedger(DataSet AData, Int32 ALedgerNumber, TDBTransaction ATransaction)
        {
            LoadViaALedger(AData, ALedgerNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedger(DataSet AData, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedger(AData, ALedgerNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedger(out AMotivationGroupTable AData, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationGroupTable();
            LoadViaForeignKey(AMotivationGroupTable.TableId, ALedgerTable.TableId, AData, new string[1]{"a_ledger_number_i"},
                new System.Object[1]{ALedgerNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedger(out AMotivationGroupTable AData, Int32 ALedgerNumber, TDBTransaction ATransaction)
        {
            LoadViaALedger(out AData, ALedgerNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedger(out AMotivationGroupTable AData, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedger(out AData, ALedgerNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet ADataSet, ALedgerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AMotivationGroupTable.TableId, ALedgerTable.TableId, ADataSet, new string[1]{"a_ledger_number_i"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, ALedgerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, ALedgerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AMotivationGroupTable AData, ALedgerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationGroupTable();
            LoadViaForeignKey(AMotivationGroupTable.TableId, ALedgerTable.TableId, AData, new string[1]{"a_ledger_number_i"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AMotivationGroupTable AData, ALedgerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AMotivationGroupTable AData, ALedgerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AMotivationGroupTable AData, ALedgerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AMotivationGroupTable.TableId, ALedgerTable.TableId, ADataSet, new string[1]{"a_ledger_number_i"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AMotivationGroupTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationGroupTable();
            LoadViaForeignKey(AMotivationGroupTable.TableId, ALedgerTable.TableId, AData, new string[1]{"a_ledger_number_i"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AMotivationGroupTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AMotivationGroupTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaALedger(Int32 ALedgerNumber, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AMotivationGroupTable.TableId, ALedgerTable.TableId, new string[1]{"a_ledger_number_i"},
                new System.Object[1]{ALedgerNumber}, ATransaction);
        }

        /// auto generated
        public static int CountViaALedgerTemplate(ALedgerRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AMotivationGroupTable.TableId, ALedgerTable.TableId, new string[1]{"a_ledger_number_i"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaALedgerTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AMotivationGroupTable.TableId, ALedgerTable.TableId, new string[1]{"a_ledger_number_i"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void DeleteByPrimaryKey(Int32 ALedgerNumber, String AMotivationGroupCode, TDBTransaction ATransaction)
        {
            DeleteByPrimaryKey(AMotivationGroupTable.TableId, new System.Object[2]{ALedgerNumber, AMotivationGroupCode}, ATransaction);
        }

        /// auto generated
        public static void DeleteUsingTemplate(AMotivationGroupRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DeleteUsingTemplate(AMotivationGroupTable.TableId, ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static void DeleteUsingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            DeleteUsingTemplate(AMotivationGroupTable.TableId, ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static bool SubmitChanges(AMotivationGroupTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            return SubmitChanges(AMotivationGroupTable.TableId, ATable, ATransaction, out AVerificationResult, UserInfo.GUserInfo.UserID);
        }
    }

    /// Used as a subdvision of motivation group. Details of the reason money has been received, where it is going (cost centre and account), and fees to be charged on it.
    public class AMotivationDetailAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "AMotivationDetail";

        /// original table name in database
        public const string DBTABLENAME = "a_motivation_detail";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, AMotivationDetailTable.TableId) + " FROM PUB_a_motivation_detail") +
                            GenerateOrderByClause(AOrderBy)), TTypedDataTable.GetTableName(AMotivationDetailTable.TableId), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out AMotivationDetailTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailTable();
            DBAccess.GDBAccessObj.SelectDT(AData, GenerateSelectClause(AFieldList, AMotivationDetailTable.TableId) + " FROM PUB_a_motivation_detail" + GenerateOrderByClause(AOrderBy), ATransaction, null, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(out AMotivationDetailTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out AMotivationDetailTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadByPrimaryKey(AMotivationDetailTable.TableId, ADataSet, new System.Object[3]{ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out AMotivationDetailTable AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailTable();
            LoadByPrimaryKey(AMotivationDetailTable.TableId, AData, new System.Object[3]{ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out AMotivationDetailTable AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out AMotivationDetailTable AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, AMotivationDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadUsingTemplate(AMotivationDetailTable.TableId, ADataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, AMotivationDetailRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, AMotivationDetailRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMotivationDetailTable AData, AMotivationDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailTable();
            LoadUsingTemplate(AMotivationDetailTable.TableId, AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMotivationDetailTable AData, AMotivationDetailRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMotivationDetailTable AData, AMotivationDetailRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMotivationDetailTable AData, AMotivationDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadUsingTemplate(AMotivationDetailTable.TableId, ADataSet, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMotivationDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailTable();
            LoadUsingTemplate(AMotivationDetailTable.TableId, AData, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMotivationDetailTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMotivationDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_a_motivation_detail", ATransaction, false));
        }

        /// check if a row exists by using the primary key
        public static bool Exists(Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, TDBTransaction ATransaction)
        {
            return Exists(AMotivationDetailTable.TableId, new System.Object[3]{ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode}, ATransaction);
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(AMotivationDetailRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_a_motivation_detail" + GenerateWhereClause(TTypedDataTable.GetColumnStringList(AMotivationDetailTable.TableId), ATemplateRow, ATemplateOperators)), ATransaction, false,
                   GetParametersForWhereClause(AMotivationDetailTable.TableId, ATemplateRow)));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_a_motivation_detail" + GenerateWhereClause(TTypedDataTable.GetColumnStringList(AMotivationDetailTable.TableId), ASearchCriteria)), ATransaction, false,
            GetParametersForWhereClause(AMotivationDetailTable.TableId, ASearchCriteria)));
        }

        /// auto generated
        public static void LoadViaAMotivationGroup(DataSet ADataSet, Int32 ALedgerNumber, String AMotivationGroupCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AMotivationDetailTable.TableId, AMotivationGroupTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_motivation_group_code_c"},
                new System.Object[2]{ALedgerNumber, AMotivationGroupCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMotivationGroup(DataSet AData, Int32 ALedgerNumber, String AMotivationGroupCode, TDBTransaction ATransaction)
        {
            LoadViaAMotivationGroup(AData, ALedgerNumber, AMotivationGroupCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationGroup(DataSet AData, Int32 ALedgerNumber, String AMotivationGroupCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationGroup(AData, ALedgerNumber, AMotivationGroupCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationGroup(out AMotivationDetailTable AData, Int32 ALedgerNumber, String AMotivationGroupCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailTable();
            LoadViaForeignKey(AMotivationDetailTable.TableId, AMotivationGroupTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_motivation_group_code_c"},
                new System.Object[2]{ALedgerNumber, AMotivationGroupCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMotivationGroup(out AMotivationDetailTable AData, Int32 ALedgerNumber, String AMotivationGroupCode, TDBTransaction ATransaction)
        {
            LoadViaAMotivationGroup(out AData, ALedgerNumber, AMotivationGroupCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationGroup(out AMotivationDetailTable AData, Int32 ALedgerNumber, String AMotivationGroupCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationGroup(out AData, ALedgerNumber, AMotivationGroupCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationGroupTemplate(DataSet ADataSet, AMotivationGroupRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AMotivationDetailTable.TableId, AMotivationGroupTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_motivation_group_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMotivationGroupTemplate(DataSet AData, AMotivationGroupRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAMotivationGroupTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationGroupTemplate(DataSet AData, AMotivationGroupRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationGroupTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationGroupTemplate(out AMotivationDetailTable AData, AMotivationGroupRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailTable();
            LoadViaForeignKey(AMotivationDetailTable.TableId, AMotivationGroupTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_motivation_group_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMotivationGroupTemplate(out AMotivationDetailTable AData, AMotivationGroupRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAMotivationGroupTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationGroupTemplate(out AMotivationDetailTable AData, AMotivationGroupRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationGroupTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationGroupTemplate(out AMotivationDetailTable AData, AMotivationGroupRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationGroupTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationGroupTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AMotivationDetailTable.TableId, AMotivationGroupTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_motivation_group_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMotivationGroupTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAMotivationGroupTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationGroupTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationGroupTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationGroupTemplate(out AMotivationDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailTable();
            LoadViaForeignKey(AMotivationDetailTable.TableId, AMotivationGroupTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_motivation_group_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMotivationGroupTemplate(out AMotivationDetailTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAMotivationGroupTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationGroupTemplate(out AMotivationDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationGroupTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaAMotivationGroup(Int32 ALedgerNumber, String AMotivationGroupCode, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AMotivationDetailTable.TableId, AMotivationGroupTable.TableId, new string[2]{"a_ledger_number_i", "a_motivation_group_code_c"},
                new System.Object[2]{ALedgerNumber, AMotivationGroupCode}, ATransaction);
        }

        /// auto generated
        public static int CountViaAMotivationGroupTemplate(AMotivationGroupRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AMotivationDetailTable.TableId, AMotivationGroupTable.TableId, new string[2]{"a_ledger_number_i", "a_motivation_group_code_c"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaAMotivationGroupTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AMotivationDetailTable.TableId, AMotivationGroupTable.TableId, new string[2]{"a_ledger_number_i", "a_motivation_group_code_c"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaALedger(DataSet ADataSet, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AMotivationDetailTable.TableId, ALedgerTable.TableId, ADataSet, new string[1]{"a_ledger_number_i"},
                new System.Object[1]{ALedgerNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedger(DataSet AData, Int32 ALedgerNumber, TDBTransaction ATransaction)
        {
            LoadViaALedger(AData, ALedgerNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedger(DataSet AData, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedger(AData, ALedgerNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedger(out AMotivationDetailTable AData, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailTable();
            LoadViaForeignKey(AMotivationDetailTable.TableId, ALedgerTable.TableId, AData, new string[1]{"a_ledger_number_i"},
                new System.Object[1]{ALedgerNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedger(out AMotivationDetailTable AData, Int32 ALedgerNumber, TDBTransaction ATransaction)
        {
            LoadViaALedger(out AData, ALedgerNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedger(out AMotivationDetailTable AData, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedger(out AData, ALedgerNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet ADataSet, ALedgerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AMotivationDetailTable.TableId, ALedgerTable.TableId, ADataSet, new string[1]{"a_ledger_number_i"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, ALedgerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, ALedgerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AMotivationDetailTable AData, ALedgerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailTable();
            LoadViaForeignKey(AMotivationDetailTable.TableId, ALedgerTable.TableId, AData, new string[1]{"a_ledger_number_i"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AMotivationDetailTable AData, ALedgerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AMotivationDetailTable AData, ALedgerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AMotivationDetailTable AData, ALedgerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AMotivationDetailTable.TableId, ALedgerTable.TableId, ADataSet, new string[1]{"a_ledger_number_i"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AMotivationDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailTable();
            LoadViaForeignKey(AMotivationDetailTable.TableId, ALedgerTable.TableId, AData, new string[1]{"a_ledger_number_i"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AMotivationDetailTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AMotivationDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaALedger(Int32 ALedgerNumber, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AMotivationDetailTable.TableId, ALedgerTable.TableId, new string[1]{"a_ledger_number_i"},
                new System.Object[1]{ALedgerNumber}, ATransaction);
        }

        /// auto generated
        public static int CountViaALedgerTemplate(ALedgerRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AMotivationDetailTable.TableId, ALedgerTable.TableId, new string[1]{"a_ledger_number_i"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaALedgerTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AMotivationDetailTable.TableId, ALedgerTable.TableId, new string[1]{"a_ledger_number_i"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaAAccount(DataSet ADataSet, Int32 ALedgerNumber, String AAccountCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AMotivationDetailTable.TableId, AAccountTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_account_code_c"},
                new System.Object[2]{ALedgerNumber, AAccountCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAAccount(DataSet AData, Int32 ALedgerNumber, String AAccountCode, TDBTransaction ATransaction)
        {
            LoadViaAAccount(AData, ALedgerNumber, AAccountCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccount(DataSet AData, Int32 ALedgerNumber, String AAccountCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAAccount(AData, ALedgerNumber, AAccountCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccount(out AMotivationDetailTable AData, Int32 ALedgerNumber, String AAccountCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailTable();
            LoadViaForeignKey(AMotivationDetailTable.TableId, AAccountTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_account_code_c"},
                new System.Object[2]{ALedgerNumber, AAccountCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAAccount(out AMotivationDetailTable AData, Int32 ALedgerNumber, String AAccountCode, TDBTransaction ATransaction)
        {
            LoadViaAAccount(out AData, ALedgerNumber, AAccountCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccount(out AMotivationDetailTable AData, Int32 ALedgerNumber, String AAccountCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAAccount(out AData, ALedgerNumber, AAccountCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(DataSet ADataSet, AAccountRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AMotivationDetailTable.TableId, AAccountTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_account_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(DataSet AData, AAccountRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(DataSet AData, AAccountRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(out AMotivationDetailTable AData, AAccountRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailTable();
            LoadViaForeignKey(AMotivationDetailTable.TableId, AAccountTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_account_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(out AMotivationDetailTable AData, AAccountRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(out AMotivationDetailTable AData, AAccountRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(out AMotivationDetailTable AData, AAccountRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AMotivationDetailTable.TableId, AAccountTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_account_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(out AMotivationDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailTable();
            LoadViaForeignKey(AMotivationDetailTable.TableId, AAccountTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_account_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(out AMotivationDetailTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(out AMotivationDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaAAccount(Int32 ALedgerNumber, String AAccountCode, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AMotivationDetailTable.TableId, AAccountTable.TableId, new string[2]{"a_ledger_number_i", "a_account_code_c"},
                new System.Object[2]{ALedgerNumber, AAccountCode}, ATransaction);
        }

        /// auto generated
        public static int CountViaAAccountTemplate(AAccountRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AMotivationDetailTable.TableId, AAccountTable.TableId, new string[2]{"a_ledger_number_i", "a_account_code_c"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaAAccountTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AMotivationDetailTable.TableId, AAccountTable.TableId, new string[2]{"a_ledger_number_i", "a_account_code_c"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaACostCentre(DataSet ADataSet, Int32 ALedgerNumber, String ACostCentreCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AMotivationDetailTable.TableId, ACostCentreTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_cost_centre_code_c"},
                new System.Object[2]{ALedgerNumber, ACostCentreCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACostCentre(DataSet AData, Int32 ALedgerNumber, String ACostCentreCode, TDBTransaction ATransaction)
        {
            LoadViaACostCentre(AData, ALedgerNumber, ACostCentreCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentre(DataSet AData, Int32 ALedgerNumber, String ACostCentreCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentre(AData, ALedgerNumber, ACostCentreCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentre(out AMotivationDetailTable AData, Int32 ALedgerNumber, String ACostCentreCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailTable();
            LoadViaForeignKey(AMotivationDetailTable.TableId, ACostCentreTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_cost_centre_code_c"},
                new System.Object[2]{ALedgerNumber, ACostCentreCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACostCentre(out AMotivationDetailTable AData, Int32 ALedgerNumber, String ACostCentreCode, TDBTransaction ATransaction)
        {
            LoadViaACostCentre(out AData, ALedgerNumber, ACostCentreCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentre(out AMotivationDetailTable AData, Int32 ALedgerNumber, String ACostCentreCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentre(out AData, ALedgerNumber, ACostCentreCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(DataSet ADataSet, ACostCentreRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AMotivationDetailTable.TableId, ACostCentreTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_cost_centre_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(DataSet AData, ACostCentreRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(DataSet AData, ACostCentreRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out AMotivationDetailTable AData, ACostCentreRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailTable();
            LoadViaForeignKey(AMotivationDetailTable.TableId, ACostCentreTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_cost_centre_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out AMotivationDetailTable AData, ACostCentreRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out AMotivationDetailTable AData, ACostCentreRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out AMotivationDetailTable AData, ACostCentreRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AMotivationDetailTable.TableId, ACostCentreTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_cost_centre_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out AMotivationDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailTable();
            LoadViaForeignKey(AMotivationDetailTable.TableId, ACostCentreTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_cost_centre_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out AMotivationDetailTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out AMotivationDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaACostCentre(Int32 ALedgerNumber, String ACostCentreCode, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AMotivationDetailTable.TableId, ACostCentreTable.TableId, new string[2]{"a_ledger_number_i", "a_cost_centre_code_c"},
                new System.Object[2]{ALedgerNumber, ACostCentreCode}, ATransaction);
        }

        /// auto generated
        public static int CountViaACostCentreTemplate(ACostCentreRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AMotivationDetailTable.TableId, ACostCentreTable.TableId, new string[2]{"a_ledger_number_i", "a_cost_centre_code_c"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaACostCentreTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AMotivationDetailTable.TableId, ACostCentreTable.TableId, new string[2]{"a_ledger_number_i", "a_cost_centre_code_c"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaPPartner(DataSet ADataSet, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AMotivationDetailTable.TableId, PPartnerTable.TableId, ADataSet, new string[1]{"p_recipient_key_n"},
                new System.Object[1]{APartnerKey}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartner(DataSet AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartner(AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartner(DataSet AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartner(AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartner(out AMotivationDetailTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailTable();
            LoadViaForeignKey(AMotivationDetailTable.TableId, PPartnerTable.TableId, AData, new string[1]{"p_recipient_key_n"},
                new System.Object[1]{APartnerKey}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartner(out AMotivationDetailTable AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartner(out AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartner(out AMotivationDetailTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartner(out AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet ADataSet, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AMotivationDetailTable.TableId, PPartnerTable.TableId, ADataSet, new string[1]{"p_recipient_key_n"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out AMotivationDetailTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailTable();
            LoadViaForeignKey(AMotivationDetailTable.TableId, PPartnerTable.TableId, AData, new string[1]{"p_recipient_key_n"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out AMotivationDetailTable AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out AMotivationDetailTable AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out AMotivationDetailTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AMotivationDetailTable.TableId, PPartnerTable.TableId, ADataSet, new string[1]{"p_recipient_key_n"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out AMotivationDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailTable();
            LoadViaForeignKey(AMotivationDetailTable.TableId, PPartnerTable.TableId, AData, new string[1]{"p_recipient_key_n"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out AMotivationDetailTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out AMotivationDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPPartner(Int64 APartnerKey, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AMotivationDetailTable.TableId, PPartnerTable.TableId, new string[1]{"p_recipient_key_n"},
                new System.Object[1]{APartnerKey}, ATransaction);
        }

        /// auto generated
        public static int CountViaPPartnerTemplate(PPartnerRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AMotivationDetailTable.TableId, PPartnerTable.TableId, new string[1]{"p_recipient_key_n"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaPPartnerTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AMotivationDetailTable.TableId, PPartnerTable.TableId, new string[1]{"p_recipient_key_n"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated LoadViaLinkTable
        public static void LoadViaSGroup(DataSet ADataSet, String AGroupId, Int64 AUnitKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(AGroupId));
            ParametersArray[1] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[1].Value = ((object)(AUnitKey));
            DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClauseLong("PUB_a_motivation_detail", AFieldList, AMotivationDetailTable.TableId) +
                            " FROM PUB_a_motivation_detail, PUB_s_group_motivation WHERE " +
                            "PUB_s_group_motivation.a_ledger_number_i = PUB_a_motivation_detail.a_ledger_number_i AND PUB_s_group_motivation.a_motivation_group_code_c = PUB_a_motivation_detail.a_motivation_group_code_c AND PUB_s_group_motivation.a_motivation_detail_code_c = PUB_a_motivation_detail.a_motivation_detail_code_c AND PUB_s_group_motivation.s_group_id_c = ? AND PUB_s_group_motivation.s_group_unit_key_n = ?") +
                            GenerateOrderByClause(AOrderBy)), TTypedDataTable.GetTableName(AMotivationDetailTable.TableId), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSGroup(DataSet AData, String AGroupId, Int64 AUnitKey, TDBTransaction ATransaction)
        {
            LoadViaSGroup(AData, AGroupId, AUnitKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroup(DataSet AData, String AGroupId, Int64 AUnitKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSGroup(AData, AGroupId, AUnitKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroup(out AMotivationDetailTable AData, String AGroupId, Int64 AUnitKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new AMotivationDetailTable();
            FillDataSet.Tables.Add(AData);
            LoadViaSGroup(FillDataSet, AGroupId, AUnitKey, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaSGroup(out AMotivationDetailTable AData, String AGroupId, Int64 AUnitKey, TDBTransaction ATransaction)
        {
            LoadViaSGroup(out AData, AGroupId, AUnitKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroup(out AMotivationDetailTable AData, String AGroupId, Int64 AUnitKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSGroup(out AData, AGroupId, AUnitKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(DataSet ADataSet, SGroupRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_a_motivation_detail", AFieldList, AMotivationDetailTable.TableId) +
                            " FROM PUB_a_motivation_detail, PUB_s_group_motivation, PUB_s_group WHERE " +
                            "PUB_s_group_motivation.a_ledger_number_i = PUB_a_motivation_detail.a_ledger_number_i AND PUB_s_group_motivation.a_motivation_group_code_c = PUB_a_motivation_detail.a_motivation_group_code_c AND PUB_s_group_motivation.a_motivation_detail_code_c = PUB_a_motivation_detail.a_motivation_detail_code_c AND PUB_s_group_motivation.s_group_id_c = PUB_s_group.s_group_id_c AND PUB_s_group_motivation.s_group_unit_key_n = PUB_s_group.s_unit_key_n") +
                            GenerateWhereClauseLong("PUB_s_group", SGroupTable.TableId, ATemplateRow, ATemplateOperators)) +
                            GenerateOrderByClause(AOrderBy)), TTypedDataTable.GetTableName(AMotivationDetailTable.TableId), ATransaction,
                            GetParametersForWhereClause(SGroupTable.TableId, ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(DataSet AData, SGroupRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(DataSet AData, SGroupRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(out AMotivationDetailTable AData, SGroupRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new AMotivationDetailTable();
            FillDataSet.Tables.Add(AData);
            LoadViaSGroupTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(out AMotivationDetailTable AData, SGroupRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(out AMotivationDetailTable AData, SGroupRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(out AMotivationDetailTable AData, SGroupRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_a_motivation_detail", AFieldList, AMotivationDetailTable.TableId) +
                            " FROM PUB_a_motivation_detail, PUB_s_group_motivation, PUB_s_group WHERE " +
                            "PUB_s_group_motivation.a_ledger_number_i = PUB_a_motivation_detail.a_ledger_number_i AND PUB_s_group_motivation.a_motivation_group_code_c = PUB_a_motivation_detail.a_motivation_group_code_c AND PUB_s_group_motivation.a_motivation_detail_code_c = PUB_a_motivation_detail.a_motivation_detail_code_c AND PUB_s_group_motivation.s_group_id_c = PUB_s_group.s_group_id_c AND PUB_s_group_motivation.s_group_unit_key_n = PUB_s_group.s_unit_key_n") +
                            GenerateWhereClauseLong("PUB_s_group", ASearchCriteria)) +
                            GenerateOrderByClause(AOrderBy)), TTypedDataTable.GetTableName(AMotivationDetailTable.TableId), ATransaction,
                            GetParametersForWhereClause(AMotivationDetailTable.TableId, ASearchCriteria), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(out AMotivationDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new AMotivationDetailTable();
            FillDataSet.Tables.Add(AData);
            LoadViaSGroupTemplate(FillDataSet, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(out AMotivationDetailTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(out AMotivationDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated CountViaLinkTable
        public static int CountViaSGroup(String AGroupId, Int64 AUnitKey, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(AGroupId));
            ParametersArray[1] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[1].Value = ((object)(AUnitKey));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_a_motivation_detail, PUB_s_group_motivation WHERE " +
                        "PUB_s_group_motivation.a_ledger_number_i = PUB_a_motivation_detail.a_ledger_number_i AND PUB_s_group_motivation.a_motivation_group_code_c = PUB_a_motivation_detail.a_motivation_group_code_c AND PUB_s_group_motivation.a_motivation_detail_code_c = PUB_a_motivation_detail.a_motivation_detail_code_c AND PUB_s_group_motivation.s_group_id_c = ? AND PUB_s_group_motivation.s_group_unit_key_n = ?",
                        ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaSGroupTemplate(SGroupRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_a_motivation_detail, PUB_s_group_motivation, PUB_s_group WHERE " +
                        "PUB_s_group_motivation.a_ledger_number_i = PUB_a_motivation_detail.a_ledger_number_i AND PUB_s_group_motivation.a_motivation_group_code_c = PUB_a_motivation_detail.a_motivation_group_code_c AND PUB_s_group_motivation.a_motivation_detail_code_c = PUB_a_motivation_detail.a_motivation_detail_code_c AND PUB_s_group_motivation.s_group_id_c = PUB_s_group.s_group_id_c AND PUB_s_group_motivation.s_group_unit_key_n = PUB_s_group.s_unit_key_n" +
                        GenerateWhereClauseLong("PUB_s_group_motivation", AMotivationDetailTable.TableId, ATemplateRow, ATemplateOperators)), ATransaction, false,
                        GetParametersForWhereClauseWithPrimaryKey(SGroupTable.TableId, ATemplateRow)));
        }

        /// auto generated
        public static int CountViaSGroupTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_a_motivation_detail, PUB_s_group_motivation, PUB_s_group WHERE " +
                        "PUB_s_group_motivation.a_ledger_number_i = PUB_a_motivation_detail.a_ledger_number_i AND PUB_s_group_motivation.a_motivation_group_code_c = PUB_a_motivation_detail.a_motivation_group_code_c AND PUB_s_group_motivation.a_motivation_detail_code_c = PUB_a_motivation_detail.a_motivation_detail_code_c AND PUB_s_group_motivation.s_group_id_c = PUB_s_group.s_group_id_c AND PUB_s_group_motivation.s_group_unit_key_n = PUB_s_group.s_unit_key_n" +
                        GenerateWhereClauseLong("PUB_s_group_motivation", ASearchCriteria)), ATransaction, false,
                        GetParametersForWhereClause(AMotivationDetailTable.TableId, ASearchCriteria)));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, TDBTransaction ATransaction)
        {
            DeleteByPrimaryKey(AMotivationDetailTable.TableId, new System.Object[3]{ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode}, ATransaction);
        }

        /// auto generated
        public static void DeleteUsingTemplate(AMotivationDetailRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DeleteUsingTemplate(AMotivationDetailTable.TableId, ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static void DeleteUsingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            DeleteUsingTemplate(AMotivationDetailTable.TableId, ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static bool SubmitChanges(AMotivationDetailTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            return SubmitChanges(AMotivationDetailTable.TableId, ATable, ATransaction, out AVerificationResult, UserInfo.GUserInfo.UserID);
        }
    }

    /// motivation details can have several fees
    public class AMotivationDetailFeeAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "AMotivationDetailFee";

        /// original table name in database
        public const string DBTABLENAME = "a_motivation_detail_fee";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, AMotivationDetailFeeTable.TableId) + " FROM PUB_a_motivation_detail_fee") +
                            GenerateOrderByClause(AOrderBy)), TTypedDataTable.GetTableName(AMotivationDetailFeeTable.TableId), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out AMotivationDetailFeeTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailFeeTable();
            DBAccess.GDBAccessObj.SelectDT(AData, GenerateSelectClause(AFieldList, AMotivationDetailFeeTable.TableId) + " FROM PUB_a_motivation_detail_fee" + GenerateOrderByClause(AOrderBy), ATransaction, null, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(out AMotivationDetailFeeTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out AMotivationDetailFeeTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, String AFeeCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadByPrimaryKey(AMotivationDetailFeeTable.TableId, ADataSet, new System.Object[4]{ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode, AFeeCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, String AFeeCode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode, AFeeCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, String AFeeCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode, AFeeCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out AMotivationDetailFeeTable AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, String AFeeCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailFeeTable();
            LoadByPrimaryKey(AMotivationDetailFeeTable.TableId, AData, new System.Object[4]{ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode, AFeeCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out AMotivationDetailFeeTable AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, String AFeeCode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode, AFeeCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out AMotivationDetailFeeTable AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, String AFeeCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode, AFeeCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, AMotivationDetailFeeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadUsingTemplate(AMotivationDetailFeeTable.TableId, ADataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, AMotivationDetailFeeRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, AMotivationDetailFeeRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMotivationDetailFeeTable AData, AMotivationDetailFeeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailFeeTable();
            LoadUsingTemplate(AMotivationDetailFeeTable.TableId, AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMotivationDetailFeeTable AData, AMotivationDetailFeeRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMotivationDetailFeeTable AData, AMotivationDetailFeeRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMotivationDetailFeeTable AData, AMotivationDetailFeeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadUsingTemplate(AMotivationDetailFeeTable.TableId, ADataSet, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMotivationDetailFeeTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailFeeTable();
            LoadUsingTemplate(AMotivationDetailFeeTable.TableId, AData, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMotivationDetailFeeTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AMotivationDetailFeeTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_a_motivation_detail_fee", ATransaction, false));
        }

        /// check if a row exists by using the primary key
        public static bool Exists(Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, String AFeeCode, TDBTransaction ATransaction)
        {
            return Exists(AMotivationDetailFeeTable.TableId, new System.Object[4]{ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode, AFeeCode}, ATransaction);
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(AMotivationDetailFeeRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_a_motivation_detail_fee" + GenerateWhereClause(TTypedDataTable.GetColumnStringList(AMotivationDetailFeeTable.TableId), ATemplateRow, ATemplateOperators)), ATransaction, false,
                   GetParametersForWhereClause(AMotivationDetailFeeTable.TableId, ATemplateRow)));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_a_motivation_detail_fee" + GenerateWhereClause(TTypedDataTable.GetColumnStringList(AMotivationDetailFeeTable.TableId), ASearchCriteria)), ATransaction, false,
            GetParametersForWhereClause(AMotivationDetailFeeTable.TableId, ASearchCriteria)));
        }

        /// auto generated
        public static void LoadViaAMotivationDetail(DataSet ADataSet, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AMotivationDetailFeeTable.TableId, AMotivationDetailTable.TableId, ADataSet, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                new System.Object[3]{ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMotivationDetail(DataSet AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetail(AData, ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetail(DataSet AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetail(AData, ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetail(out AMotivationDetailFeeTable AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailFeeTable();
            LoadViaForeignKey(AMotivationDetailFeeTable.TableId, AMotivationDetailTable.TableId, AData, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                new System.Object[3]{ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMotivationDetail(out AMotivationDetailFeeTable AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetail(out AData, ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetail(out AMotivationDetailFeeTable AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetail(out AData, ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(DataSet ADataSet, AMotivationDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AMotivationDetailFeeTable.TableId, AMotivationDetailTable.TableId, ADataSet, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(DataSet AData, AMotivationDetailRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(DataSet AData, AMotivationDetailRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(out AMotivationDetailFeeTable AData, AMotivationDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailFeeTable();
            LoadViaForeignKey(AMotivationDetailFeeTable.TableId, AMotivationDetailTable.TableId, AData, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(out AMotivationDetailFeeTable AData, AMotivationDetailRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(out AMotivationDetailFeeTable AData, AMotivationDetailRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(out AMotivationDetailFeeTable AData, AMotivationDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AMotivationDetailFeeTable.TableId, AMotivationDetailTable.TableId, ADataSet, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(out AMotivationDetailFeeTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AMotivationDetailFeeTable();
            LoadViaForeignKey(AMotivationDetailFeeTable.TableId, AMotivationDetailTable.TableId, AData, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(out AMotivationDetailFeeTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(out AMotivationDetailFeeTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaAMotivationDetail(Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AMotivationDetailFeeTable.TableId, AMotivationDetailTable.TableId, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                new System.Object[3]{ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode}, ATransaction);
        }

        /// auto generated
        public static int CountViaAMotivationDetailTemplate(AMotivationDetailRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AMotivationDetailFeeTable.TableId, AMotivationDetailTable.TableId, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaAMotivationDetailTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AMotivationDetailFeeTable.TableId, AMotivationDetailTable.TableId, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void DeleteByPrimaryKey(Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, String AFeeCode, TDBTransaction ATransaction)
        {
            DeleteByPrimaryKey(AMotivationDetailFeeTable.TableId, new System.Object[4]{ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode, AFeeCode}, ATransaction);
        }

        /// auto generated
        public static void DeleteUsingTemplate(AMotivationDetailFeeRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DeleteUsingTemplate(AMotivationDetailFeeTable.TableId, ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static void DeleteUsingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            DeleteUsingTemplate(AMotivationDetailFeeTable.TableId, ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static bool SubmitChanges(AMotivationDetailFeeTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            return SubmitChanges(AMotivationDetailFeeTable.TableId, ATable, ATransaction, out AVerificationResult, UserInfo.GUserInfo.UserID);
        }
    }

    /// Templates of gift batches which can be copied into the gift system.
    public class ARecurringGiftBatchAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "ARecurringGiftBatch";

        /// original table name in database
        public const string DBTABLENAME = "a_recurring_gift_batch";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, ARecurringGiftBatchTable.TableId) + " FROM PUB_a_recurring_gift_batch") +
                            GenerateOrderByClause(AOrderBy)), TTypedDataTable.GetTableName(ARecurringGiftBatchTable.TableId), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out ARecurringGiftBatchTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftBatchTable();
            DBAccess.GDBAccessObj.SelectDT(AData, GenerateSelectClause(AFieldList, ARecurringGiftBatchTable.TableId) + " FROM PUB_a_recurring_gift_batch" + GenerateOrderByClause(AOrderBy), ATransaction, null, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(out ARecurringGiftBatchTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out ARecurringGiftBatchTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, Int32 ALedgerNumber, Int32 ABatchNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadByPrimaryKey(ARecurringGiftBatchTable.TableId, ADataSet, new System.Object[2]{ALedgerNumber, ABatchNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 ALedgerNumber, Int32 ABatchNumber, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ALedgerNumber, ABatchNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 ALedgerNumber, Int32 ABatchNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ALedgerNumber, ABatchNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out ARecurringGiftBatchTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftBatchTable();
            LoadByPrimaryKey(ARecurringGiftBatchTable.TableId, AData, new System.Object[2]{ALedgerNumber, ABatchNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out ARecurringGiftBatchTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ALedgerNumber, ABatchNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out ARecurringGiftBatchTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ALedgerNumber, ABatchNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, ARecurringGiftBatchRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadUsingTemplate(ARecurringGiftBatchTable.TableId, ADataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, ARecurringGiftBatchRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, ARecurringGiftBatchRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out ARecurringGiftBatchTable AData, ARecurringGiftBatchRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftBatchTable();
            LoadUsingTemplate(ARecurringGiftBatchTable.TableId, AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(out ARecurringGiftBatchTable AData, ARecurringGiftBatchRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out ARecurringGiftBatchTable AData, ARecurringGiftBatchRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out ARecurringGiftBatchTable AData, ARecurringGiftBatchRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadUsingTemplate(ARecurringGiftBatchTable.TableId, ADataSet, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out ARecurringGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftBatchTable();
            LoadUsingTemplate(ARecurringGiftBatchTable.TableId, AData, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(out ARecurringGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out ARecurringGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_a_recurring_gift_batch", ATransaction, false));
        }

        /// check if a row exists by using the primary key
        public static bool Exists(Int32 ALedgerNumber, Int32 ABatchNumber, TDBTransaction ATransaction)
        {
            return Exists(ARecurringGiftBatchTable.TableId, new System.Object[2]{ALedgerNumber, ABatchNumber}, ATransaction);
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(ARecurringGiftBatchRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_a_recurring_gift_batch" + GenerateWhereClause(TTypedDataTable.GetColumnStringList(ARecurringGiftBatchTable.TableId), ATemplateRow, ATemplateOperators)), ATransaction, false,
                   GetParametersForWhereClause(ARecurringGiftBatchTable.TableId, ATemplateRow)));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_a_recurring_gift_batch" + GenerateWhereClause(TTypedDataTable.GetColumnStringList(ARecurringGiftBatchTable.TableId), ASearchCriteria)), ATransaction, false,
            GetParametersForWhereClause(ARecurringGiftBatchTable.TableId, ASearchCriteria)));
        }

        /// auto generated
        public static void LoadViaALedger(DataSet ADataSet, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftBatchTable.TableId, ALedgerTable.TableId, ADataSet, new string[1]{"a_ledger_number_i"},
                new System.Object[1]{ALedgerNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedger(DataSet AData, Int32 ALedgerNumber, TDBTransaction ATransaction)
        {
            LoadViaALedger(AData, ALedgerNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedger(DataSet AData, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedger(AData, ALedgerNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedger(out ARecurringGiftBatchTable AData, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftBatchTable();
            LoadViaForeignKey(ARecurringGiftBatchTable.TableId, ALedgerTable.TableId, AData, new string[1]{"a_ledger_number_i"},
                new System.Object[1]{ALedgerNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedger(out ARecurringGiftBatchTable AData, Int32 ALedgerNumber, TDBTransaction ATransaction)
        {
            LoadViaALedger(out AData, ALedgerNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedger(out ARecurringGiftBatchTable AData, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedger(out AData, ALedgerNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet ADataSet, ALedgerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftBatchTable.TableId, ALedgerTable.TableId, ADataSet, new string[1]{"a_ledger_number_i"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, ALedgerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, ALedgerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out ARecurringGiftBatchTable AData, ALedgerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftBatchTable();
            LoadViaForeignKey(ARecurringGiftBatchTable.TableId, ALedgerTable.TableId, AData, new string[1]{"a_ledger_number_i"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out ARecurringGiftBatchTable AData, ALedgerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out ARecurringGiftBatchTable AData, ALedgerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out ARecurringGiftBatchTable AData, ALedgerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftBatchTable.TableId, ALedgerTable.TableId, ADataSet, new string[1]{"a_ledger_number_i"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out ARecurringGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftBatchTable();
            LoadViaForeignKey(ARecurringGiftBatchTable.TableId, ALedgerTable.TableId, AData, new string[1]{"a_ledger_number_i"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out ARecurringGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out ARecurringGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaALedger(Int32 ALedgerNumber, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftBatchTable.TableId, ALedgerTable.TableId, new string[1]{"a_ledger_number_i"},
                new System.Object[1]{ALedgerNumber}, ATransaction);
        }

        /// auto generated
        public static int CountViaALedgerTemplate(ALedgerRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftBatchTable.TableId, ALedgerTable.TableId, new string[1]{"a_ledger_number_i"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaALedgerTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftBatchTable.TableId, ALedgerTable.TableId, new string[1]{"a_ledger_number_i"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaAAccount(DataSet ADataSet, Int32 ALedgerNumber, String AAccountCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftBatchTable.TableId, AAccountTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_bank_account_code_c"},
                new System.Object[2]{ALedgerNumber, AAccountCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAAccount(DataSet AData, Int32 ALedgerNumber, String AAccountCode, TDBTransaction ATransaction)
        {
            LoadViaAAccount(AData, ALedgerNumber, AAccountCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccount(DataSet AData, Int32 ALedgerNumber, String AAccountCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAAccount(AData, ALedgerNumber, AAccountCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccount(out ARecurringGiftBatchTable AData, Int32 ALedgerNumber, String AAccountCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftBatchTable();
            LoadViaForeignKey(ARecurringGiftBatchTable.TableId, AAccountTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_bank_account_code_c"},
                new System.Object[2]{ALedgerNumber, AAccountCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAAccount(out ARecurringGiftBatchTable AData, Int32 ALedgerNumber, String AAccountCode, TDBTransaction ATransaction)
        {
            LoadViaAAccount(out AData, ALedgerNumber, AAccountCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccount(out ARecurringGiftBatchTable AData, Int32 ALedgerNumber, String AAccountCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAAccount(out AData, ALedgerNumber, AAccountCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(DataSet ADataSet, AAccountRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftBatchTable.TableId, AAccountTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_bank_account_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(DataSet AData, AAccountRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(DataSet AData, AAccountRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(out ARecurringGiftBatchTable AData, AAccountRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftBatchTable();
            LoadViaForeignKey(ARecurringGiftBatchTable.TableId, AAccountTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_bank_account_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(out ARecurringGiftBatchTable AData, AAccountRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(out ARecurringGiftBatchTable AData, AAccountRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(out ARecurringGiftBatchTable AData, AAccountRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftBatchTable.TableId, AAccountTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_bank_account_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(out ARecurringGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftBatchTable();
            LoadViaForeignKey(ARecurringGiftBatchTable.TableId, AAccountTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_bank_account_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(out ARecurringGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(out ARecurringGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaAAccount(Int32 ALedgerNumber, String AAccountCode, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftBatchTable.TableId, AAccountTable.TableId, new string[2]{"a_ledger_number_i", "a_bank_account_code_c"},
                new System.Object[2]{ALedgerNumber, AAccountCode}, ATransaction);
        }

        /// auto generated
        public static int CountViaAAccountTemplate(AAccountRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftBatchTable.TableId, AAccountTable.TableId, new string[2]{"a_ledger_number_i", "a_bank_account_code_c"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaAAccountTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftBatchTable.TableId, AAccountTable.TableId, new string[2]{"a_ledger_number_i", "a_bank_account_code_c"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaACostCentre(DataSet ADataSet, Int32 ALedgerNumber, String ACostCentreCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftBatchTable.TableId, ACostCentreTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_bank_cost_centre_c"},
                new System.Object[2]{ALedgerNumber, ACostCentreCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACostCentre(DataSet AData, Int32 ALedgerNumber, String ACostCentreCode, TDBTransaction ATransaction)
        {
            LoadViaACostCentre(AData, ALedgerNumber, ACostCentreCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentre(DataSet AData, Int32 ALedgerNumber, String ACostCentreCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentre(AData, ALedgerNumber, ACostCentreCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentre(out ARecurringGiftBatchTable AData, Int32 ALedgerNumber, String ACostCentreCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftBatchTable();
            LoadViaForeignKey(ARecurringGiftBatchTable.TableId, ACostCentreTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_bank_cost_centre_c"},
                new System.Object[2]{ALedgerNumber, ACostCentreCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACostCentre(out ARecurringGiftBatchTable AData, Int32 ALedgerNumber, String ACostCentreCode, TDBTransaction ATransaction)
        {
            LoadViaACostCentre(out AData, ALedgerNumber, ACostCentreCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentre(out ARecurringGiftBatchTable AData, Int32 ALedgerNumber, String ACostCentreCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentre(out AData, ALedgerNumber, ACostCentreCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(DataSet ADataSet, ACostCentreRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftBatchTable.TableId, ACostCentreTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_bank_cost_centre_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(DataSet AData, ACostCentreRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(DataSet AData, ACostCentreRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out ARecurringGiftBatchTable AData, ACostCentreRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftBatchTable();
            LoadViaForeignKey(ARecurringGiftBatchTable.TableId, ACostCentreTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_bank_cost_centre_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out ARecurringGiftBatchTable AData, ACostCentreRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out ARecurringGiftBatchTable AData, ACostCentreRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out ARecurringGiftBatchTable AData, ACostCentreRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftBatchTable.TableId, ACostCentreTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_bank_cost_centre_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out ARecurringGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftBatchTable();
            LoadViaForeignKey(ARecurringGiftBatchTable.TableId, ACostCentreTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_bank_cost_centre_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out ARecurringGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out ARecurringGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaACostCentre(Int32 ALedgerNumber, String ACostCentreCode, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftBatchTable.TableId, ACostCentreTable.TableId, new string[2]{"a_ledger_number_i", "a_bank_cost_centre_c"},
                new System.Object[2]{ALedgerNumber, ACostCentreCode}, ATransaction);
        }

        /// auto generated
        public static int CountViaACostCentreTemplate(ACostCentreRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftBatchTable.TableId, ACostCentreTable.TableId, new string[2]{"a_ledger_number_i", "a_bank_cost_centre_c"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaACostCentreTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftBatchTable.TableId, ACostCentreTable.TableId, new string[2]{"a_ledger_number_i", "a_bank_cost_centre_c"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaACurrency(DataSet ADataSet, String ACurrencyCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftBatchTable.TableId, ACurrencyTable.TableId, ADataSet, new string[1]{"a_currency_code_c"},
                new System.Object[1]{ACurrencyCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACurrency(DataSet AData, String ACurrencyCode, TDBTransaction ATransaction)
        {
            LoadViaACurrency(AData, ACurrencyCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrency(DataSet AData, String ACurrencyCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACurrency(AData, ACurrencyCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrency(out ARecurringGiftBatchTable AData, String ACurrencyCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftBatchTable();
            LoadViaForeignKey(ARecurringGiftBatchTable.TableId, ACurrencyTable.TableId, AData, new string[1]{"a_currency_code_c"},
                new System.Object[1]{ACurrencyCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACurrency(out ARecurringGiftBatchTable AData, String ACurrencyCode, TDBTransaction ATransaction)
        {
            LoadViaACurrency(out AData, ACurrencyCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrency(out ARecurringGiftBatchTable AData, String ACurrencyCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACurrency(out AData, ACurrencyCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(DataSet ADataSet, ACurrencyRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftBatchTable.TableId, ACurrencyTable.TableId, ADataSet, new string[1]{"a_currency_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(DataSet AData, ACurrencyRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaACurrencyTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(DataSet AData, ACurrencyRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACurrencyTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(out ARecurringGiftBatchTable AData, ACurrencyRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftBatchTable();
            LoadViaForeignKey(ARecurringGiftBatchTable.TableId, ACurrencyTable.TableId, AData, new string[1]{"a_currency_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(out ARecurringGiftBatchTable AData, ACurrencyRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaACurrencyTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(out ARecurringGiftBatchTable AData, ACurrencyRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACurrencyTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(out ARecurringGiftBatchTable AData, ACurrencyRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACurrencyTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftBatchTable.TableId, ACurrencyTable.TableId, ADataSet, new string[1]{"a_currency_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaACurrencyTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACurrencyTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(out ARecurringGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftBatchTable();
            LoadViaForeignKey(ARecurringGiftBatchTable.TableId, ACurrencyTable.TableId, AData, new string[1]{"a_currency_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(out ARecurringGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaACurrencyTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(out ARecurringGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACurrencyTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaACurrency(String ACurrencyCode, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftBatchTable.TableId, ACurrencyTable.TableId, new string[1]{"a_currency_code_c"},
                new System.Object[1]{ACurrencyCode}, ATransaction);
        }

        /// auto generated
        public static int CountViaACurrencyTemplate(ACurrencyRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftBatchTable.TableId, ACurrencyTable.TableId, new string[1]{"a_currency_code_c"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaACurrencyTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftBatchTable.TableId, ACurrencyTable.TableId, new string[1]{"a_currency_code_c"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void DeleteByPrimaryKey(Int32 ALedgerNumber, Int32 ABatchNumber, TDBTransaction ATransaction)
        {
            DeleteByPrimaryKey(ARecurringGiftBatchTable.TableId, new System.Object[2]{ALedgerNumber, ABatchNumber}, ATransaction);
        }

        /// auto generated
        public static void DeleteUsingTemplate(ARecurringGiftBatchRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DeleteUsingTemplate(ARecurringGiftBatchTable.TableId, ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static void DeleteUsingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            DeleteUsingTemplate(ARecurringGiftBatchTable.TableId, ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static bool SubmitChanges(ARecurringGiftBatchTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            return SubmitChanges(ARecurringGiftBatchTable.TableId, ATable, ATransaction, out AVerificationResult, UserInfo.GUserInfo.UserID);
        }
    }

    /// Templates of donor gift information which can be copied into the gift system with recurring gift batches.
    public class ARecurringGiftAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "ARecurringGift";

        /// original table name in database
        public const string DBTABLENAME = "a_recurring_gift";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, ARecurringGiftTable.TableId) + " FROM PUB_a_recurring_gift") +
                            GenerateOrderByClause(AOrderBy)), TTypedDataTable.GetTableName(ARecurringGiftTable.TableId), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out ARecurringGiftTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftTable();
            DBAccess.GDBAccessObj.SelectDT(AData, GenerateSelectClause(AFieldList, ARecurringGiftTable.TableId) + " FROM PUB_a_recurring_gift" + GenerateOrderByClause(AOrderBy), ATransaction, null, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(out ARecurringGiftTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out ARecurringGiftTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadByPrimaryKey(ARecurringGiftTable.TableId, ADataSet, new System.Object[3]{ALedgerNumber, ABatchNumber, AGiftTransactionNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ALedgerNumber, ABatchNumber, AGiftTransactionNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ALedgerNumber, ABatchNumber, AGiftTransactionNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out ARecurringGiftTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftTable();
            LoadByPrimaryKey(ARecurringGiftTable.TableId, AData, new System.Object[3]{ALedgerNumber, ABatchNumber, AGiftTransactionNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out ARecurringGiftTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ALedgerNumber, ABatchNumber, AGiftTransactionNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out ARecurringGiftTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ALedgerNumber, ABatchNumber, AGiftTransactionNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, ARecurringGiftRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadUsingTemplate(ARecurringGiftTable.TableId, ADataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, ARecurringGiftRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, ARecurringGiftRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out ARecurringGiftTable AData, ARecurringGiftRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftTable();
            LoadUsingTemplate(ARecurringGiftTable.TableId, AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(out ARecurringGiftTable AData, ARecurringGiftRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out ARecurringGiftTable AData, ARecurringGiftRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out ARecurringGiftTable AData, ARecurringGiftRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadUsingTemplate(ARecurringGiftTable.TableId, ADataSet, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out ARecurringGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftTable();
            LoadUsingTemplate(ARecurringGiftTable.TableId, AData, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(out ARecurringGiftTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out ARecurringGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_a_recurring_gift", ATransaction, false));
        }

        /// check if a row exists by using the primary key
        public static bool Exists(Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, TDBTransaction ATransaction)
        {
            return Exists(ARecurringGiftTable.TableId, new System.Object[3]{ALedgerNumber, ABatchNumber, AGiftTransactionNumber}, ATransaction);
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(ARecurringGiftRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_a_recurring_gift" + GenerateWhereClause(TTypedDataTable.GetColumnStringList(ARecurringGiftTable.TableId), ATemplateRow, ATemplateOperators)), ATransaction, false,
                   GetParametersForWhereClause(ARecurringGiftTable.TableId, ATemplateRow)));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_a_recurring_gift" + GenerateWhereClause(TTypedDataTable.GetColumnStringList(ARecurringGiftTable.TableId), ASearchCriteria)), ATransaction, false,
            GetParametersForWhereClause(ARecurringGiftTable.TableId, ASearchCriteria)));
        }

        /// auto generated
        public static void LoadViaARecurringGiftBatch(DataSet ADataSet, Int32 ALedgerNumber, Int32 ABatchNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftTable.TableId, ARecurringGiftBatchTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_batch_number_i"},
                new System.Object[2]{ALedgerNumber, ABatchNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaARecurringGiftBatch(DataSet AData, Int32 ALedgerNumber, Int32 ABatchNumber, TDBTransaction ATransaction)
        {
            LoadViaARecurringGiftBatch(AData, ALedgerNumber, ABatchNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaARecurringGiftBatch(DataSet AData, Int32 ALedgerNumber, Int32 ABatchNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaARecurringGiftBatch(AData, ALedgerNumber, ABatchNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaARecurringGiftBatch(out ARecurringGiftTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftTable();
            LoadViaForeignKey(ARecurringGiftTable.TableId, ARecurringGiftBatchTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_batch_number_i"},
                new System.Object[2]{ALedgerNumber, ABatchNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaARecurringGiftBatch(out ARecurringGiftTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, TDBTransaction ATransaction)
        {
            LoadViaARecurringGiftBatch(out AData, ALedgerNumber, ABatchNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaARecurringGiftBatch(out ARecurringGiftTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaARecurringGiftBatch(out AData, ALedgerNumber, ABatchNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaARecurringGiftBatchTemplate(DataSet ADataSet, ARecurringGiftBatchRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftTable.TableId, ARecurringGiftBatchTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_batch_number_i"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaARecurringGiftBatchTemplate(DataSet AData, ARecurringGiftBatchRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaARecurringGiftBatchTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaARecurringGiftBatchTemplate(DataSet AData, ARecurringGiftBatchRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaARecurringGiftBatchTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaARecurringGiftBatchTemplate(out ARecurringGiftTable AData, ARecurringGiftBatchRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftTable();
            LoadViaForeignKey(ARecurringGiftTable.TableId, ARecurringGiftBatchTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_batch_number_i"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaARecurringGiftBatchTemplate(out ARecurringGiftTable AData, ARecurringGiftBatchRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaARecurringGiftBatchTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaARecurringGiftBatchTemplate(out ARecurringGiftTable AData, ARecurringGiftBatchRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaARecurringGiftBatchTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaARecurringGiftBatchTemplate(out ARecurringGiftTable AData, ARecurringGiftBatchRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaARecurringGiftBatchTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaARecurringGiftBatchTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftTable.TableId, ARecurringGiftBatchTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_batch_number_i"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaARecurringGiftBatchTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaARecurringGiftBatchTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaARecurringGiftBatchTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaARecurringGiftBatchTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaARecurringGiftBatchTemplate(out ARecurringGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftTable();
            LoadViaForeignKey(ARecurringGiftTable.TableId, ARecurringGiftBatchTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_batch_number_i"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaARecurringGiftBatchTemplate(out ARecurringGiftTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaARecurringGiftBatchTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaARecurringGiftBatchTemplate(out ARecurringGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaARecurringGiftBatchTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaARecurringGiftBatch(Int32 ALedgerNumber, Int32 ABatchNumber, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftTable.TableId, ARecurringGiftBatchTable.TableId, new string[2]{"a_ledger_number_i", "a_batch_number_i"},
                new System.Object[2]{ALedgerNumber, ABatchNumber}, ATransaction);
        }

        /// auto generated
        public static int CountViaARecurringGiftBatchTemplate(ARecurringGiftBatchRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftTable.TableId, ARecurringGiftBatchTable.TableId, new string[2]{"a_ledger_number_i", "a_batch_number_i"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaARecurringGiftBatchTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftTable.TableId, ARecurringGiftBatchTable.TableId, new string[2]{"a_ledger_number_i", "a_batch_number_i"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaALedger(DataSet ADataSet, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftTable.TableId, ALedgerTable.TableId, ADataSet, new string[1]{"a_ledger_number_i"},
                new System.Object[1]{ALedgerNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedger(DataSet AData, Int32 ALedgerNumber, TDBTransaction ATransaction)
        {
            LoadViaALedger(AData, ALedgerNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedger(DataSet AData, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedger(AData, ALedgerNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedger(out ARecurringGiftTable AData, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftTable();
            LoadViaForeignKey(ARecurringGiftTable.TableId, ALedgerTable.TableId, AData, new string[1]{"a_ledger_number_i"},
                new System.Object[1]{ALedgerNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedger(out ARecurringGiftTable AData, Int32 ALedgerNumber, TDBTransaction ATransaction)
        {
            LoadViaALedger(out AData, ALedgerNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedger(out ARecurringGiftTable AData, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedger(out AData, ALedgerNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet ADataSet, ALedgerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftTable.TableId, ALedgerTable.TableId, ADataSet, new string[1]{"a_ledger_number_i"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, ALedgerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, ALedgerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out ARecurringGiftTable AData, ALedgerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftTable();
            LoadViaForeignKey(ARecurringGiftTable.TableId, ALedgerTable.TableId, AData, new string[1]{"a_ledger_number_i"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out ARecurringGiftTable AData, ALedgerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out ARecurringGiftTable AData, ALedgerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out ARecurringGiftTable AData, ALedgerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftTable.TableId, ALedgerTable.TableId, ADataSet, new string[1]{"a_ledger_number_i"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out ARecurringGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftTable();
            LoadViaForeignKey(ARecurringGiftTable.TableId, ALedgerTable.TableId, AData, new string[1]{"a_ledger_number_i"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out ARecurringGiftTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out ARecurringGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaALedger(Int32 ALedgerNumber, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftTable.TableId, ALedgerTable.TableId, new string[1]{"a_ledger_number_i"},
                new System.Object[1]{ALedgerNumber}, ATransaction);
        }

        /// auto generated
        public static int CountViaALedgerTemplate(ALedgerRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftTable.TableId, ALedgerTable.TableId, new string[1]{"a_ledger_number_i"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaALedgerTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftTable.TableId, ALedgerTable.TableId, new string[1]{"a_ledger_number_i"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaAMethodOfGiving(DataSet ADataSet, String AMethodOfGivingCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftTable.TableId, AMethodOfGivingTable.TableId, ADataSet, new string[1]{"a_method_of_giving_code_c"},
                new System.Object[1]{AMethodOfGivingCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMethodOfGiving(DataSet AData, String AMethodOfGivingCode, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGiving(AData, AMethodOfGivingCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfGiving(DataSet AData, String AMethodOfGivingCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGiving(AData, AMethodOfGivingCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfGiving(out ARecurringGiftTable AData, String AMethodOfGivingCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftTable();
            LoadViaForeignKey(ARecurringGiftTable.TableId, AMethodOfGivingTable.TableId, AData, new string[1]{"a_method_of_giving_code_c"},
                new System.Object[1]{AMethodOfGivingCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMethodOfGiving(out ARecurringGiftTable AData, String AMethodOfGivingCode, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGiving(out AData, AMethodOfGivingCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfGiving(out ARecurringGiftTable AData, String AMethodOfGivingCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGiving(out AData, AMethodOfGivingCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(DataSet ADataSet, AMethodOfGivingRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftTable.TableId, AMethodOfGivingTable.TableId, ADataSet, new string[1]{"a_method_of_giving_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(DataSet AData, AMethodOfGivingRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGivingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(DataSet AData, AMethodOfGivingRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGivingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(out ARecurringGiftTable AData, AMethodOfGivingRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftTable();
            LoadViaForeignKey(ARecurringGiftTable.TableId, AMethodOfGivingTable.TableId, AData, new string[1]{"a_method_of_giving_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(out ARecurringGiftTable AData, AMethodOfGivingRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGivingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(out ARecurringGiftTable AData, AMethodOfGivingRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGivingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(out ARecurringGiftTable AData, AMethodOfGivingRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGivingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftTable.TableId, AMethodOfGivingTable.TableId, ADataSet, new string[1]{"a_method_of_giving_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGivingTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGivingTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(out ARecurringGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftTable();
            LoadViaForeignKey(ARecurringGiftTable.TableId, AMethodOfGivingTable.TableId, AData, new string[1]{"a_method_of_giving_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(out ARecurringGiftTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGivingTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(out ARecurringGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGivingTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaAMethodOfGiving(String AMethodOfGivingCode, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftTable.TableId, AMethodOfGivingTable.TableId, new string[1]{"a_method_of_giving_code_c"},
                new System.Object[1]{AMethodOfGivingCode}, ATransaction);
        }

        /// auto generated
        public static int CountViaAMethodOfGivingTemplate(AMethodOfGivingRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftTable.TableId, AMethodOfGivingTable.TableId, new string[1]{"a_method_of_giving_code_c"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaAMethodOfGivingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftTable.TableId, AMethodOfGivingTable.TableId, new string[1]{"a_method_of_giving_code_c"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaAMethodOfPayment(DataSet ADataSet, String AMethodOfPaymentCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftTable.TableId, AMethodOfPaymentTable.TableId, ADataSet, new string[1]{"a_method_of_payment_code_c"},
                new System.Object[1]{AMethodOfPaymentCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMethodOfPayment(DataSet AData, String AMethodOfPaymentCode, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPayment(AData, AMethodOfPaymentCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfPayment(DataSet AData, String AMethodOfPaymentCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPayment(AData, AMethodOfPaymentCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfPayment(out ARecurringGiftTable AData, String AMethodOfPaymentCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftTable();
            LoadViaForeignKey(ARecurringGiftTable.TableId, AMethodOfPaymentTable.TableId, AData, new string[1]{"a_method_of_payment_code_c"},
                new System.Object[1]{AMethodOfPaymentCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMethodOfPayment(out ARecurringGiftTable AData, String AMethodOfPaymentCode, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPayment(out AData, AMethodOfPaymentCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfPayment(out ARecurringGiftTable AData, String AMethodOfPaymentCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPayment(out AData, AMethodOfPaymentCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(DataSet ADataSet, AMethodOfPaymentRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftTable.TableId, AMethodOfPaymentTable.TableId, ADataSet, new string[1]{"a_method_of_payment_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(DataSet AData, AMethodOfPaymentRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPaymentTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(DataSet AData, AMethodOfPaymentRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPaymentTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(out ARecurringGiftTable AData, AMethodOfPaymentRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftTable();
            LoadViaForeignKey(ARecurringGiftTable.TableId, AMethodOfPaymentTable.TableId, AData, new string[1]{"a_method_of_payment_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(out ARecurringGiftTable AData, AMethodOfPaymentRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPaymentTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(out ARecurringGiftTable AData, AMethodOfPaymentRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPaymentTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(out ARecurringGiftTable AData, AMethodOfPaymentRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPaymentTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftTable.TableId, AMethodOfPaymentTable.TableId, ADataSet, new string[1]{"a_method_of_payment_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPaymentTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPaymentTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(out ARecurringGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftTable();
            LoadViaForeignKey(ARecurringGiftTable.TableId, AMethodOfPaymentTable.TableId, AData, new string[1]{"a_method_of_payment_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(out ARecurringGiftTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPaymentTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(out ARecurringGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPaymentTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaAMethodOfPayment(String AMethodOfPaymentCode, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftTable.TableId, AMethodOfPaymentTable.TableId, new string[1]{"a_method_of_payment_code_c"},
                new System.Object[1]{AMethodOfPaymentCode}, ATransaction);
        }

        /// auto generated
        public static int CountViaAMethodOfPaymentTemplate(AMethodOfPaymentRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftTable.TableId, AMethodOfPaymentTable.TableId, new string[1]{"a_method_of_payment_code_c"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaAMethodOfPaymentTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftTable.TableId, AMethodOfPaymentTable.TableId, new string[1]{"a_method_of_payment_code_c"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaPPartner(DataSet ADataSet, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftTable.TableId, PPartnerTable.TableId, ADataSet, new string[1]{"p_donor_key_n"},
                new System.Object[1]{APartnerKey}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartner(DataSet AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartner(AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartner(DataSet AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartner(AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartner(out ARecurringGiftTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftTable();
            LoadViaForeignKey(ARecurringGiftTable.TableId, PPartnerTable.TableId, AData, new string[1]{"p_donor_key_n"},
                new System.Object[1]{APartnerKey}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartner(out ARecurringGiftTable AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartner(out AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartner(out ARecurringGiftTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartner(out AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet ADataSet, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftTable.TableId, PPartnerTable.TableId, ADataSet, new string[1]{"p_donor_key_n"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out ARecurringGiftTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftTable();
            LoadViaForeignKey(ARecurringGiftTable.TableId, PPartnerTable.TableId, AData, new string[1]{"p_donor_key_n"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out ARecurringGiftTable AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out ARecurringGiftTable AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out ARecurringGiftTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftTable.TableId, PPartnerTable.TableId, ADataSet, new string[1]{"p_donor_key_n"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out ARecurringGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftTable();
            LoadViaForeignKey(ARecurringGiftTable.TableId, PPartnerTable.TableId, AData, new string[1]{"p_donor_key_n"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out ARecurringGiftTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out ARecurringGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPPartner(Int64 APartnerKey, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftTable.TableId, PPartnerTable.TableId, new string[1]{"p_donor_key_n"},
                new System.Object[1]{APartnerKey}, ATransaction);
        }

        /// auto generated
        public static int CountViaPPartnerTemplate(PPartnerRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftTable.TableId, PPartnerTable.TableId, new string[1]{"p_donor_key_n"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaPPartnerTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftTable.TableId, PPartnerTable.TableId, new string[1]{"p_donor_key_n"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void DeleteByPrimaryKey(Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, TDBTransaction ATransaction)
        {
            DeleteByPrimaryKey(ARecurringGiftTable.TableId, new System.Object[3]{ALedgerNumber, ABatchNumber, AGiftTransactionNumber}, ATransaction);
        }

        /// auto generated
        public static void DeleteUsingTemplate(ARecurringGiftRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DeleteUsingTemplate(ARecurringGiftTable.TableId, ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static void DeleteUsingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            DeleteUsingTemplate(ARecurringGiftTable.TableId, ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static bool SubmitChanges(ARecurringGiftTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            return SubmitChanges(ARecurringGiftTable.TableId, ATable, ATransaction, out AVerificationResult, UserInfo.GUserInfo.UserID);
        }
    }

    /// Store recipient information for the recurring gift.
    public class ARecurringGiftDetailAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "ARecurringGiftDetail";

        /// original table name in database
        public const string DBTABLENAME = "a_recurring_gift_detail";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, ARecurringGiftDetailTable.TableId) + " FROM PUB_a_recurring_gift_detail") +
                            GenerateOrderByClause(AOrderBy)), TTypedDataTable.GetTableName(ARecurringGiftDetailTable.TableId), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out ARecurringGiftDetailTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftDetailTable();
            DBAccess.GDBAccessObj.SelectDT(AData, GenerateSelectClause(AFieldList, ARecurringGiftDetailTable.TableId) + " FROM PUB_a_recurring_gift_detail" + GenerateOrderByClause(AOrderBy), ATransaction, null, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(out ARecurringGiftDetailTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out ARecurringGiftDetailTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, Int32 ADetailNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadByPrimaryKey(ARecurringGiftDetailTable.TableId, ADataSet, new System.Object[4]{ALedgerNumber, ABatchNumber, AGiftTransactionNumber, ADetailNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, Int32 ADetailNumber, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ALedgerNumber, ABatchNumber, AGiftTransactionNumber, ADetailNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, Int32 ADetailNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ALedgerNumber, ABatchNumber, AGiftTransactionNumber, ADetailNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out ARecurringGiftDetailTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, Int32 ADetailNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftDetailTable();
            LoadByPrimaryKey(ARecurringGiftDetailTable.TableId, AData, new System.Object[4]{ALedgerNumber, ABatchNumber, AGiftTransactionNumber, ADetailNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out ARecurringGiftDetailTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, Int32 ADetailNumber, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ALedgerNumber, ABatchNumber, AGiftTransactionNumber, ADetailNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out ARecurringGiftDetailTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, Int32 ADetailNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ALedgerNumber, ABatchNumber, AGiftTransactionNumber, ADetailNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, ARecurringGiftDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadUsingTemplate(ARecurringGiftDetailTable.TableId, ADataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, ARecurringGiftDetailRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, ARecurringGiftDetailRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out ARecurringGiftDetailTable AData, ARecurringGiftDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftDetailTable();
            LoadUsingTemplate(ARecurringGiftDetailTable.TableId, AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(out ARecurringGiftDetailTable AData, ARecurringGiftDetailRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out ARecurringGiftDetailTable AData, ARecurringGiftDetailRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out ARecurringGiftDetailTable AData, ARecurringGiftDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadUsingTemplate(ARecurringGiftDetailTable.TableId, ADataSet, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out ARecurringGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftDetailTable();
            LoadUsingTemplate(ARecurringGiftDetailTable.TableId, AData, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(out ARecurringGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out ARecurringGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_a_recurring_gift_detail", ATransaction, false));
        }

        /// check if a row exists by using the primary key
        public static bool Exists(Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, Int32 ADetailNumber, TDBTransaction ATransaction)
        {
            return Exists(ARecurringGiftDetailTable.TableId, new System.Object[4]{ALedgerNumber, ABatchNumber, AGiftTransactionNumber, ADetailNumber}, ATransaction);
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(ARecurringGiftDetailRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_a_recurring_gift_detail" + GenerateWhereClause(TTypedDataTable.GetColumnStringList(ARecurringGiftDetailTable.TableId), ATemplateRow, ATemplateOperators)), ATransaction, false,
                   GetParametersForWhereClause(ARecurringGiftDetailTable.TableId, ATemplateRow)));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_a_recurring_gift_detail" + GenerateWhereClause(TTypedDataTable.GetColumnStringList(ARecurringGiftDetailTable.TableId), ASearchCriteria)), ATransaction, false,
            GetParametersForWhereClause(ARecurringGiftDetailTable.TableId, ASearchCriteria)));
        }

        /// auto generated
        public static void LoadViaARecurringGift(DataSet ADataSet, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, ARecurringGiftTable.TableId, ADataSet, new string[3]{"a_ledger_number_i", "a_batch_number_i", "a_gift_transaction_number_i"},
                new System.Object[3]{ALedgerNumber, ABatchNumber, AGiftTransactionNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaARecurringGift(DataSet AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, TDBTransaction ATransaction)
        {
            LoadViaARecurringGift(AData, ALedgerNumber, ABatchNumber, AGiftTransactionNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaARecurringGift(DataSet AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaARecurringGift(AData, ALedgerNumber, ABatchNumber, AGiftTransactionNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaARecurringGift(out ARecurringGiftDetailTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftDetailTable();
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, ARecurringGiftTable.TableId, AData, new string[3]{"a_ledger_number_i", "a_batch_number_i", "a_gift_transaction_number_i"},
                new System.Object[3]{ALedgerNumber, ABatchNumber, AGiftTransactionNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaARecurringGift(out ARecurringGiftDetailTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, TDBTransaction ATransaction)
        {
            LoadViaARecurringGift(out AData, ALedgerNumber, ABatchNumber, AGiftTransactionNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaARecurringGift(out ARecurringGiftDetailTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaARecurringGift(out AData, ALedgerNumber, ABatchNumber, AGiftTransactionNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaARecurringGiftTemplate(DataSet ADataSet, ARecurringGiftRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, ARecurringGiftTable.TableId, ADataSet, new string[3]{"a_ledger_number_i", "a_batch_number_i", "a_gift_transaction_number_i"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaARecurringGiftTemplate(DataSet AData, ARecurringGiftRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaARecurringGiftTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaARecurringGiftTemplate(DataSet AData, ARecurringGiftRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaARecurringGiftTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaARecurringGiftTemplate(out ARecurringGiftDetailTable AData, ARecurringGiftRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftDetailTable();
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, ARecurringGiftTable.TableId, AData, new string[3]{"a_ledger_number_i", "a_batch_number_i", "a_gift_transaction_number_i"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaARecurringGiftTemplate(out ARecurringGiftDetailTable AData, ARecurringGiftRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaARecurringGiftTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaARecurringGiftTemplate(out ARecurringGiftDetailTable AData, ARecurringGiftRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaARecurringGiftTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaARecurringGiftTemplate(out ARecurringGiftDetailTable AData, ARecurringGiftRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaARecurringGiftTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaARecurringGiftTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, ARecurringGiftTable.TableId, ADataSet, new string[3]{"a_ledger_number_i", "a_batch_number_i", "a_gift_transaction_number_i"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaARecurringGiftTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaARecurringGiftTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaARecurringGiftTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaARecurringGiftTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaARecurringGiftTemplate(out ARecurringGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftDetailTable();
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, ARecurringGiftTable.TableId, AData, new string[3]{"a_ledger_number_i", "a_batch_number_i", "a_gift_transaction_number_i"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaARecurringGiftTemplate(out ARecurringGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaARecurringGiftTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaARecurringGiftTemplate(out ARecurringGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaARecurringGiftTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaARecurringGift(Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftDetailTable.TableId, ARecurringGiftTable.TableId, new string[3]{"a_ledger_number_i", "a_batch_number_i", "a_gift_transaction_number_i"},
                new System.Object[3]{ALedgerNumber, ABatchNumber, AGiftTransactionNumber}, ATransaction);
        }

        /// auto generated
        public static int CountViaARecurringGiftTemplate(ARecurringGiftRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftDetailTable.TableId, ARecurringGiftTable.TableId, new string[3]{"a_ledger_number_i", "a_batch_number_i", "a_gift_transaction_number_i"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaARecurringGiftTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftDetailTable.TableId, ARecurringGiftTable.TableId, new string[3]{"a_ledger_number_i", "a_batch_number_i", "a_gift_transaction_number_i"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaAMotivationDetail(DataSet ADataSet, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, AMotivationDetailTable.TableId, ADataSet, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                new System.Object[3]{ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMotivationDetail(DataSet AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetail(AData, ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetail(DataSet AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetail(AData, ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetail(out ARecurringGiftDetailTable AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftDetailTable();
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, AMotivationDetailTable.TableId, AData, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                new System.Object[3]{ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMotivationDetail(out ARecurringGiftDetailTable AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetail(out AData, ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetail(out ARecurringGiftDetailTable AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetail(out AData, ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(DataSet ADataSet, AMotivationDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, AMotivationDetailTable.TableId, ADataSet, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(DataSet AData, AMotivationDetailRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(DataSet AData, AMotivationDetailRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(out ARecurringGiftDetailTable AData, AMotivationDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftDetailTable();
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, AMotivationDetailTable.TableId, AData, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(out ARecurringGiftDetailTable AData, AMotivationDetailRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(out ARecurringGiftDetailTable AData, AMotivationDetailRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(out ARecurringGiftDetailTable AData, AMotivationDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, AMotivationDetailTable.TableId, ADataSet, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(out ARecurringGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftDetailTable();
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, AMotivationDetailTable.TableId, AData, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(out ARecurringGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(out ARecurringGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaAMotivationDetail(Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftDetailTable.TableId, AMotivationDetailTable.TableId, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                new System.Object[3]{ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode}, ATransaction);
        }

        /// auto generated
        public static int CountViaAMotivationDetailTemplate(AMotivationDetailRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftDetailTable.TableId, AMotivationDetailTable.TableId, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaAMotivationDetailTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftDetailTable.TableId, AMotivationDetailTable.TableId, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKey(DataSet ADataSet, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, PPartnerTable.TableId, ADataSet, new string[1]{"p_recipient_key_n"},
                new System.Object[1]{APartnerKey}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKey(DataSet AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKey(AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKey(DataSet AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKey(AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKey(out ARecurringGiftDetailTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftDetailTable();
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, PPartnerTable.TableId, AData, new string[1]{"p_recipient_key_n"},
                new System.Object[1]{APartnerKey}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKey(out ARecurringGiftDetailTable AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKey(out AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKey(out ARecurringGiftDetailTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKey(out AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(DataSet ADataSet, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, PPartnerTable.TableId, ADataSet, new string[1]{"p_recipient_key_n"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(DataSet AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKeyTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(DataSet AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKeyTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(out ARecurringGiftDetailTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftDetailTable();
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, PPartnerTable.TableId, AData, new string[1]{"p_recipient_key_n"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(out ARecurringGiftDetailTable AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKeyTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(out ARecurringGiftDetailTable AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKeyTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(out ARecurringGiftDetailTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKeyTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, PPartnerTable.TableId, ADataSet, new string[1]{"p_recipient_key_n"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKeyTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKeyTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(out ARecurringGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftDetailTable();
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, PPartnerTable.TableId, AData, new string[1]{"p_recipient_key_n"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(out ARecurringGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKeyTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(out ARecurringGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKeyTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPPartnerRecipientKey(Int64 APartnerKey, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftDetailTable.TableId, PPartnerTable.TableId, new string[1]{"p_recipient_key_n"},
                new System.Object[1]{APartnerKey}, ATransaction);
        }

        /// auto generated
        public static int CountViaPPartnerRecipientKeyTemplate(PPartnerRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftDetailTable.TableId, PPartnerTable.TableId, new string[1]{"p_recipient_key_n"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaPPartnerRecipientKeyTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftDetailTable.TableId, PPartnerTable.TableId, new string[1]{"p_recipient_key_n"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaPMailing(DataSet ADataSet, String AMailingCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, PMailingTable.TableId, ADataSet, new string[1]{"p_mailing_code_c"},
                new System.Object[1]{AMailingCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPMailing(DataSet AData, String AMailingCode, TDBTransaction ATransaction)
        {
            LoadViaPMailing(AData, AMailingCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailing(DataSet AData, String AMailingCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMailing(AData, AMailingCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailing(out ARecurringGiftDetailTable AData, String AMailingCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftDetailTable();
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, PMailingTable.TableId, AData, new string[1]{"p_mailing_code_c"},
                new System.Object[1]{AMailingCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPMailing(out ARecurringGiftDetailTable AData, String AMailingCode, TDBTransaction ATransaction)
        {
            LoadViaPMailing(out AData, AMailingCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailing(out ARecurringGiftDetailTable AData, String AMailingCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMailing(out AData, AMailingCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(DataSet ADataSet, PMailingRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, PMailingTable.TableId, ADataSet, new string[1]{"p_mailing_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(DataSet AData, PMailingRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPMailingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(DataSet AData, PMailingRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMailingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(out ARecurringGiftDetailTable AData, PMailingRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftDetailTable();
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, PMailingTable.TableId, AData, new string[1]{"p_mailing_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(out ARecurringGiftDetailTable AData, PMailingRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPMailingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(out ARecurringGiftDetailTable AData, PMailingRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMailingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(out ARecurringGiftDetailTable AData, PMailingRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMailingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, PMailingTable.TableId, ADataSet, new string[1]{"p_mailing_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaPMailingTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMailingTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(out ARecurringGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftDetailTable();
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, PMailingTable.TableId, AData, new string[1]{"p_mailing_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(out ARecurringGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaPMailingTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(out ARecurringGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMailingTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPMailing(String AMailingCode, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftDetailTable.TableId, PMailingTable.TableId, new string[1]{"p_mailing_code_c"},
                new System.Object[1]{AMailingCode}, ATransaction);
        }

        /// auto generated
        public static int CountViaPMailingTemplate(PMailingRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftDetailTable.TableId, PMailingTable.TableId, new string[1]{"p_mailing_code_c"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaPMailingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftDetailTable.TableId, PMailingTable.TableId, new string[1]{"p_mailing_code_c"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumber(DataSet ADataSet, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, PPartnerTable.TableId, ADataSet, new string[1]{"a_recipient_ledger_number_n"},
                new System.Object[1]{APartnerKey}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumber(DataSet AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumber(AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumber(DataSet AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumber(AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumber(out ARecurringGiftDetailTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftDetailTable();
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, PPartnerTable.TableId, AData, new string[1]{"a_recipient_ledger_number_n"},
                new System.Object[1]{APartnerKey}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumber(out ARecurringGiftDetailTable AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumber(out AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumber(out ARecurringGiftDetailTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumber(out AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(DataSet ADataSet, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, PPartnerTable.TableId, ADataSet, new string[1]{"a_recipient_ledger_number_n"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(DataSet AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumberTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(DataSet AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumberTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(out ARecurringGiftDetailTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftDetailTable();
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, PPartnerTable.TableId, AData, new string[1]{"a_recipient_ledger_number_n"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(out ARecurringGiftDetailTable AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumberTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(out ARecurringGiftDetailTable AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumberTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(out ARecurringGiftDetailTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumberTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, PPartnerTable.TableId, ADataSet, new string[1]{"a_recipient_ledger_number_n"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumberTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumberTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(out ARecurringGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new ARecurringGiftDetailTable();
            LoadViaForeignKey(ARecurringGiftDetailTable.TableId, PPartnerTable.TableId, AData, new string[1]{"a_recipient_ledger_number_n"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(out ARecurringGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumberTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(out ARecurringGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumberTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPPartnerRecipientLedgerNumber(Int64 APartnerKey, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftDetailTable.TableId, PPartnerTable.TableId, new string[1]{"a_recipient_ledger_number_n"},
                new System.Object[1]{APartnerKey}, ATransaction);
        }

        /// auto generated
        public static int CountViaPPartnerRecipientLedgerNumberTemplate(PPartnerRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftDetailTable.TableId, PPartnerTable.TableId, new string[1]{"a_recipient_ledger_number_n"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaPPartnerRecipientLedgerNumberTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(ARecurringGiftDetailTable.TableId, PPartnerTable.TableId, new string[1]{"a_recipient_ledger_number_n"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void DeleteByPrimaryKey(Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, Int32 ADetailNumber, TDBTransaction ATransaction)
        {
            DeleteByPrimaryKey(ARecurringGiftDetailTable.TableId, new System.Object[4]{ALedgerNumber, ABatchNumber, AGiftTransactionNumber, ADetailNumber}, ATransaction);
        }

        /// auto generated
        public static void DeleteUsingTemplate(ARecurringGiftDetailRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DeleteUsingTemplate(ARecurringGiftDetailTable.TableId, ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static void DeleteUsingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            DeleteUsingTemplate(ARecurringGiftDetailTable.TableId, ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static bool SubmitChanges(ARecurringGiftDetailTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            return SubmitChanges(ARecurringGiftDetailTable.TableId, ATable, ATransaction, out AVerificationResult, UserInfo.GUserInfo.UserID);
        }
    }

    /// Information describing groups (batches) of gifts.
    public class AGiftBatchAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "AGiftBatch";

        /// original table name in database
        public const string DBTABLENAME = "a_gift_batch";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, AGiftBatchTable.TableId) + " FROM PUB_a_gift_batch") +
                            GenerateOrderByClause(AOrderBy)), TTypedDataTable.GetTableName(AGiftBatchTable.TableId), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out AGiftBatchTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftBatchTable();
            DBAccess.GDBAccessObj.SelectDT(AData, GenerateSelectClause(AFieldList, AGiftBatchTable.TableId) + " FROM PUB_a_gift_batch" + GenerateOrderByClause(AOrderBy), ATransaction, null, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(out AGiftBatchTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out AGiftBatchTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, Int32 ALedgerNumber, Int32 ABatchNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadByPrimaryKey(AGiftBatchTable.TableId, ADataSet, new System.Object[2]{ALedgerNumber, ABatchNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 ALedgerNumber, Int32 ABatchNumber, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ALedgerNumber, ABatchNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 ALedgerNumber, Int32 ABatchNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ALedgerNumber, ABatchNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out AGiftBatchTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftBatchTable();
            LoadByPrimaryKey(AGiftBatchTable.TableId, AData, new System.Object[2]{ALedgerNumber, ABatchNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out AGiftBatchTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ALedgerNumber, ABatchNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out AGiftBatchTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ALedgerNumber, ABatchNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, AGiftBatchRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadUsingTemplate(AGiftBatchTable.TableId, ADataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, AGiftBatchRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, AGiftBatchRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AGiftBatchTable AData, AGiftBatchRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftBatchTable();
            LoadUsingTemplate(AGiftBatchTable.TableId, AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AGiftBatchTable AData, AGiftBatchRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AGiftBatchTable AData, AGiftBatchRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AGiftBatchTable AData, AGiftBatchRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadUsingTemplate(AGiftBatchTable.TableId, ADataSet, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftBatchTable();
            LoadUsingTemplate(AGiftBatchTable.TableId, AData, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_a_gift_batch", ATransaction, false));
        }

        /// check if a row exists by using the primary key
        public static bool Exists(Int32 ALedgerNumber, Int32 ABatchNumber, TDBTransaction ATransaction)
        {
            return Exists(AGiftBatchTable.TableId, new System.Object[2]{ALedgerNumber, ABatchNumber}, ATransaction);
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(AGiftBatchRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_a_gift_batch" + GenerateWhereClause(TTypedDataTable.GetColumnStringList(AGiftBatchTable.TableId), ATemplateRow, ATemplateOperators)), ATransaction, false,
                   GetParametersForWhereClause(AGiftBatchTable.TableId, ATemplateRow)));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_a_gift_batch" + GenerateWhereClause(TTypedDataTable.GetColumnStringList(AGiftBatchTable.TableId), ASearchCriteria)), ATransaction, false,
            GetParametersForWhereClause(AGiftBatchTable.TableId, ASearchCriteria)));
        }

        /// auto generated
        public static void LoadViaALedger(DataSet ADataSet, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftBatchTable.TableId, ALedgerTable.TableId, ADataSet, new string[1]{"a_ledger_number_i"},
                new System.Object[1]{ALedgerNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedger(DataSet AData, Int32 ALedgerNumber, TDBTransaction ATransaction)
        {
            LoadViaALedger(AData, ALedgerNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedger(DataSet AData, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedger(AData, ALedgerNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedger(out AGiftBatchTable AData, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftBatchTable();
            LoadViaForeignKey(AGiftBatchTable.TableId, ALedgerTable.TableId, AData, new string[1]{"a_ledger_number_i"},
                new System.Object[1]{ALedgerNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedger(out AGiftBatchTable AData, Int32 ALedgerNumber, TDBTransaction ATransaction)
        {
            LoadViaALedger(out AData, ALedgerNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedger(out AGiftBatchTable AData, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedger(out AData, ALedgerNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet ADataSet, ALedgerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftBatchTable.TableId, ALedgerTable.TableId, ADataSet, new string[1]{"a_ledger_number_i"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, ALedgerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, ALedgerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AGiftBatchTable AData, ALedgerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftBatchTable();
            LoadViaForeignKey(AGiftBatchTable.TableId, ALedgerTable.TableId, AData, new string[1]{"a_ledger_number_i"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AGiftBatchTable AData, ALedgerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AGiftBatchTable AData, ALedgerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AGiftBatchTable AData, ALedgerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftBatchTable.TableId, ALedgerTable.TableId, ADataSet, new string[1]{"a_ledger_number_i"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftBatchTable();
            LoadViaForeignKey(AGiftBatchTable.TableId, ALedgerTable.TableId, AData, new string[1]{"a_ledger_number_i"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaALedger(Int32 ALedgerNumber, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftBatchTable.TableId, ALedgerTable.TableId, new string[1]{"a_ledger_number_i"},
                new System.Object[1]{ALedgerNumber}, ATransaction);
        }

        /// auto generated
        public static int CountViaALedgerTemplate(ALedgerRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftBatchTable.TableId, ALedgerTable.TableId, new string[1]{"a_ledger_number_i"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaALedgerTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftBatchTable.TableId, ALedgerTable.TableId, new string[1]{"a_ledger_number_i"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaAAccount(DataSet ADataSet, Int32 ALedgerNumber, String AAccountCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftBatchTable.TableId, AAccountTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_bank_account_code_c"},
                new System.Object[2]{ALedgerNumber, AAccountCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAAccount(DataSet AData, Int32 ALedgerNumber, String AAccountCode, TDBTransaction ATransaction)
        {
            LoadViaAAccount(AData, ALedgerNumber, AAccountCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccount(DataSet AData, Int32 ALedgerNumber, String AAccountCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAAccount(AData, ALedgerNumber, AAccountCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccount(out AGiftBatchTable AData, Int32 ALedgerNumber, String AAccountCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftBatchTable();
            LoadViaForeignKey(AGiftBatchTable.TableId, AAccountTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_bank_account_code_c"},
                new System.Object[2]{ALedgerNumber, AAccountCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAAccount(out AGiftBatchTable AData, Int32 ALedgerNumber, String AAccountCode, TDBTransaction ATransaction)
        {
            LoadViaAAccount(out AData, ALedgerNumber, AAccountCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccount(out AGiftBatchTable AData, Int32 ALedgerNumber, String AAccountCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAAccount(out AData, ALedgerNumber, AAccountCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(DataSet ADataSet, AAccountRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftBatchTable.TableId, AAccountTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_bank_account_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(DataSet AData, AAccountRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(DataSet AData, AAccountRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(out AGiftBatchTable AData, AAccountRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftBatchTable();
            LoadViaForeignKey(AGiftBatchTable.TableId, AAccountTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_bank_account_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(out AGiftBatchTable AData, AAccountRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(out AGiftBatchTable AData, AAccountRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(out AGiftBatchTable AData, AAccountRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftBatchTable.TableId, AAccountTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_bank_account_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(out AGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftBatchTable();
            LoadViaForeignKey(AGiftBatchTable.TableId, AAccountTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_bank_account_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(out AGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAAccountTemplate(out AGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAAccountTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaAAccount(Int32 ALedgerNumber, String AAccountCode, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftBatchTable.TableId, AAccountTable.TableId, new string[2]{"a_ledger_number_i", "a_bank_account_code_c"},
                new System.Object[2]{ALedgerNumber, AAccountCode}, ATransaction);
        }

        /// auto generated
        public static int CountViaAAccountTemplate(AAccountRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftBatchTable.TableId, AAccountTable.TableId, new string[2]{"a_ledger_number_i", "a_bank_account_code_c"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaAAccountTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftBatchTable.TableId, AAccountTable.TableId, new string[2]{"a_ledger_number_i", "a_bank_account_code_c"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaACostCentre(DataSet ADataSet, Int32 ALedgerNumber, String ACostCentreCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftBatchTable.TableId, ACostCentreTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_bank_cost_centre_c"},
                new System.Object[2]{ALedgerNumber, ACostCentreCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACostCentre(DataSet AData, Int32 ALedgerNumber, String ACostCentreCode, TDBTransaction ATransaction)
        {
            LoadViaACostCentre(AData, ALedgerNumber, ACostCentreCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentre(DataSet AData, Int32 ALedgerNumber, String ACostCentreCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentre(AData, ALedgerNumber, ACostCentreCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentre(out AGiftBatchTable AData, Int32 ALedgerNumber, String ACostCentreCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftBatchTable();
            LoadViaForeignKey(AGiftBatchTable.TableId, ACostCentreTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_bank_cost_centre_c"},
                new System.Object[2]{ALedgerNumber, ACostCentreCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACostCentre(out AGiftBatchTable AData, Int32 ALedgerNumber, String ACostCentreCode, TDBTransaction ATransaction)
        {
            LoadViaACostCentre(out AData, ALedgerNumber, ACostCentreCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentre(out AGiftBatchTable AData, Int32 ALedgerNumber, String ACostCentreCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentre(out AData, ALedgerNumber, ACostCentreCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(DataSet ADataSet, ACostCentreRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftBatchTable.TableId, ACostCentreTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_bank_cost_centre_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(DataSet AData, ACostCentreRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(DataSet AData, ACostCentreRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out AGiftBatchTable AData, ACostCentreRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftBatchTable();
            LoadViaForeignKey(AGiftBatchTable.TableId, ACostCentreTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_bank_cost_centre_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out AGiftBatchTable AData, ACostCentreRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out AGiftBatchTable AData, ACostCentreRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out AGiftBatchTable AData, ACostCentreRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftBatchTable.TableId, ACostCentreTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_bank_cost_centre_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out AGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftBatchTable();
            LoadViaForeignKey(AGiftBatchTable.TableId, ACostCentreTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_bank_cost_centre_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out AGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out AGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaACostCentre(Int32 ALedgerNumber, String ACostCentreCode, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftBatchTable.TableId, ACostCentreTable.TableId, new string[2]{"a_ledger_number_i", "a_bank_cost_centre_c"},
                new System.Object[2]{ALedgerNumber, ACostCentreCode}, ATransaction);
        }

        /// auto generated
        public static int CountViaACostCentreTemplate(ACostCentreRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftBatchTable.TableId, ACostCentreTable.TableId, new string[2]{"a_ledger_number_i", "a_bank_cost_centre_c"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaACostCentreTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftBatchTable.TableId, ACostCentreTable.TableId, new string[2]{"a_ledger_number_i", "a_bank_cost_centre_c"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaACurrency(DataSet ADataSet, String ACurrencyCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftBatchTable.TableId, ACurrencyTable.TableId, ADataSet, new string[1]{"a_currency_code_c"},
                new System.Object[1]{ACurrencyCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACurrency(DataSet AData, String ACurrencyCode, TDBTransaction ATransaction)
        {
            LoadViaACurrency(AData, ACurrencyCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrency(DataSet AData, String ACurrencyCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACurrency(AData, ACurrencyCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrency(out AGiftBatchTable AData, String ACurrencyCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftBatchTable();
            LoadViaForeignKey(AGiftBatchTable.TableId, ACurrencyTable.TableId, AData, new string[1]{"a_currency_code_c"},
                new System.Object[1]{ACurrencyCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACurrency(out AGiftBatchTable AData, String ACurrencyCode, TDBTransaction ATransaction)
        {
            LoadViaACurrency(out AData, ACurrencyCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrency(out AGiftBatchTable AData, String ACurrencyCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACurrency(out AData, ACurrencyCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(DataSet ADataSet, ACurrencyRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftBatchTable.TableId, ACurrencyTable.TableId, ADataSet, new string[1]{"a_currency_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(DataSet AData, ACurrencyRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaACurrencyTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(DataSet AData, ACurrencyRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACurrencyTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(out AGiftBatchTable AData, ACurrencyRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftBatchTable();
            LoadViaForeignKey(AGiftBatchTable.TableId, ACurrencyTable.TableId, AData, new string[1]{"a_currency_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(out AGiftBatchTable AData, ACurrencyRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaACurrencyTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(out AGiftBatchTable AData, ACurrencyRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACurrencyTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(out AGiftBatchTable AData, ACurrencyRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACurrencyTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftBatchTable.TableId, ACurrencyTable.TableId, ADataSet, new string[1]{"a_currency_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaACurrencyTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACurrencyTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(out AGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftBatchTable();
            LoadViaForeignKey(AGiftBatchTable.TableId, ACurrencyTable.TableId, AData, new string[1]{"a_currency_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(out AGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaACurrencyTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(out AGiftBatchTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACurrencyTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaACurrency(String ACurrencyCode, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftBatchTable.TableId, ACurrencyTable.TableId, new string[1]{"a_currency_code_c"},
                new System.Object[1]{ACurrencyCode}, ATransaction);
        }

        /// auto generated
        public static int CountViaACurrencyTemplate(ACurrencyRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftBatchTable.TableId, ACurrencyTable.TableId, new string[1]{"a_currency_code_c"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaACurrencyTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftBatchTable.TableId, ACurrencyTable.TableId, new string[1]{"a_currency_code_c"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void DeleteByPrimaryKey(Int32 ALedgerNumber, Int32 ABatchNumber, TDBTransaction ATransaction)
        {
            DeleteByPrimaryKey(AGiftBatchTable.TableId, new System.Object[2]{ALedgerNumber, ABatchNumber}, ATransaction);
        }

        /// auto generated
        public static void DeleteUsingTemplate(AGiftBatchRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DeleteUsingTemplate(AGiftBatchTable.TableId, ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static void DeleteUsingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            DeleteUsingTemplate(AGiftBatchTable.TableId, ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static bool SubmitChanges(AGiftBatchTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            return SubmitChanges(AGiftBatchTable.TableId, ATable, ATransaction, out AVerificationResult, UserInfo.GUserInfo.UserID);
        }
    }

    /// Information on the donor's giving. Points to the gift detail records.
    public class AGiftAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "AGift";

        /// original table name in database
        public const string DBTABLENAME = "a_gift";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, AGiftTable.TableId) + " FROM PUB_a_gift") +
                            GenerateOrderByClause(AOrderBy)), TTypedDataTable.GetTableName(AGiftTable.TableId), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out AGiftTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftTable();
            DBAccess.GDBAccessObj.SelectDT(AData, GenerateSelectClause(AFieldList, AGiftTable.TableId) + " FROM PUB_a_gift" + GenerateOrderByClause(AOrderBy), ATransaction, null, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(out AGiftTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out AGiftTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadByPrimaryKey(AGiftTable.TableId, ADataSet, new System.Object[3]{ALedgerNumber, ABatchNumber, AGiftTransactionNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ALedgerNumber, ABatchNumber, AGiftTransactionNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ALedgerNumber, ABatchNumber, AGiftTransactionNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out AGiftTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftTable();
            LoadByPrimaryKey(AGiftTable.TableId, AData, new System.Object[3]{ALedgerNumber, ABatchNumber, AGiftTransactionNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out AGiftTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ALedgerNumber, ABatchNumber, AGiftTransactionNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out AGiftTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ALedgerNumber, ABatchNumber, AGiftTransactionNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, AGiftRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadUsingTemplate(AGiftTable.TableId, ADataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, AGiftRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, AGiftRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AGiftTable AData, AGiftRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftTable();
            LoadUsingTemplate(AGiftTable.TableId, AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AGiftTable AData, AGiftRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AGiftTable AData, AGiftRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AGiftTable AData, AGiftRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadUsingTemplate(AGiftTable.TableId, ADataSet, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftTable();
            LoadUsingTemplate(AGiftTable.TableId, AData, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AGiftTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_a_gift", ATransaction, false));
        }

        /// check if a row exists by using the primary key
        public static bool Exists(Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, TDBTransaction ATransaction)
        {
            return Exists(AGiftTable.TableId, new System.Object[3]{ALedgerNumber, ABatchNumber, AGiftTransactionNumber}, ATransaction);
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(AGiftRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_a_gift" + GenerateWhereClause(TTypedDataTable.GetColumnStringList(AGiftTable.TableId), ATemplateRow, ATemplateOperators)), ATransaction, false,
                   GetParametersForWhereClause(AGiftTable.TableId, ATemplateRow)));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_a_gift" + GenerateWhereClause(TTypedDataTable.GetColumnStringList(AGiftTable.TableId), ASearchCriteria)), ATransaction, false,
            GetParametersForWhereClause(AGiftTable.TableId, ASearchCriteria)));
        }

        /// auto generated
        public static void LoadViaAGiftBatch(DataSet ADataSet, Int32 ALedgerNumber, Int32 ABatchNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftTable.TableId, AGiftBatchTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_batch_number_i"},
                new System.Object[2]{ALedgerNumber, ABatchNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAGiftBatch(DataSet AData, Int32 ALedgerNumber, Int32 ABatchNumber, TDBTransaction ATransaction)
        {
            LoadViaAGiftBatch(AData, ALedgerNumber, ABatchNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAGiftBatch(DataSet AData, Int32 ALedgerNumber, Int32 ABatchNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAGiftBatch(AData, ALedgerNumber, ABatchNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAGiftBatch(out AGiftTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftTable();
            LoadViaForeignKey(AGiftTable.TableId, AGiftBatchTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_batch_number_i"},
                new System.Object[2]{ALedgerNumber, ABatchNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAGiftBatch(out AGiftTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, TDBTransaction ATransaction)
        {
            LoadViaAGiftBatch(out AData, ALedgerNumber, ABatchNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAGiftBatch(out AGiftTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAGiftBatch(out AData, ALedgerNumber, ABatchNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAGiftBatchTemplate(DataSet ADataSet, AGiftBatchRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftTable.TableId, AGiftBatchTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_batch_number_i"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAGiftBatchTemplate(DataSet AData, AGiftBatchRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAGiftBatchTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAGiftBatchTemplate(DataSet AData, AGiftBatchRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAGiftBatchTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAGiftBatchTemplate(out AGiftTable AData, AGiftBatchRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftTable();
            LoadViaForeignKey(AGiftTable.TableId, AGiftBatchTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_batch_number_i"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAGiftBatchTemplate(out AGiftTable AData, AGiftBatchRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAGiftBatchTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAGiftBatchTemplate(out AGiftTable AData, AGiftBatchRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAGiftBatchTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAGiftBatchTemplate(out AGiftTable AData, AGiftBatchRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAGiftBatchTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAGiftBatchTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftTable.TableId, AGiftBatchTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_batch_number_i"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAGiftBatchTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAGiftBatchTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAGiftBatchTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAGiftBatchTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAGiftBatchTemplate(out AGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftTable();
            LoadViaForeignKey(AGiftTable.TableId, AGiftBatchTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_batch_number_i"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAGiftBatchTemplate(out AGiftTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAGiftBatchTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAGiftBatchTemplate(out AGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAGiftBatchTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaAGiftBatch(Int32 ALedgerNumber, Int32 ABatchNumber, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftTable.TableId, AGiftBatchTable.TableId, new string[2]{"a_ledger_number_i", "a_batch_number_i"},
                new System.Object[2]{ALedgerNumber, ABatchNumber}, ATransaction);
        }

        /// auto generated
        public static int CountViaAGiftBatchTemplate(AGiftBatchRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftTable.TableId, AGiftBatchTable.TableId, new string[2]{"a_ledger_number_i", "a_batch_number_i"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaAGiftBatchTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftTable.TableId, AGiftBatchTable.TableId, new string[2]{"a_ledger_number_i", "a_batch_number_i"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaALedger(DataSet ADataSet, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftTable.TableId, ALedgerTable.TableId, ADataSet, new string[1]{"a_ledger_number_i"},
                new System.Object[1]{ALedgerNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedger(DataSet AData, Int32 ALedgerNumber, TDBTransaction ATransaction)
        {
            LoadViaALedger(AData, ALedgerNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedger(DataSet AData, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedger(AData, ALedgerNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedger(out AGiftTable AData, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftTable();
            LoadViaForeignKey(AGiftTable.TableId, ALedgerTable.TableId, AData, new string[1]{"a_ledger_number_i"},
                new System.Object[1]{ALedgerNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedger(out AGiftTable AData, Int32 ALedgerNumber, TDBTransaction ATransaction)
        {
            LoadViaALedger(out AData, ALedgerNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedger(out AGiftTable AData, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedger(out AData, ALedgerNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet ADataSet, ALedgerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftTable.TableId, ALedgerTable.TableId, ADataSet, new string[1]{"a_ledger_number_i"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, ALedgerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, ALedgerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AGiftTable AData, ALedgerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftTable();
            LoadViaForeignKey(AGiftTable.TableId, ALedgerTable.TableId, AData, new string[1]{"a_ledger_number_i"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AGiftTable AData, ALedgerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AGiftTable AData, ALedgerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AGiftTable AData, ALedgerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftTable.TableId, ALedgerTable.TableId, ADataSet, new string[1]{"a_ledger_number_i"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftTable();
            LoadViaForeignKey(AGiftTable.TableId, ALedgerTable.TableId, AData, new string[1]{"a_ledger_number_i"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AGiftTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaALedger(Int32 ALedgerNumber, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftTable.TableId, ALedgerTable.TableId, new string[1]{"a_ledger_number_i"},
                new System.Object[1]{ALedgerNumber}, ATransaction);
        }

        /// auto generated
        public static int CountViaALedgerTemplate(ALedgerRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftTable.TableId, ALedgerTable.TableId, new string[1]{"a_ledger_number_i"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaALedgerTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftTable.TableId, ALedgerTable.TableId, new string[1]{"a_ledger_number_i"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaAMethodOfGiving(DataSet ADataSet, String AMethodOfGivingCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftTable.TableId, AMethodOfGivingTable.TableId, ADataSet, new string[1]{"a_method_of_giving_code_c"},
                new System.Object[1]{AMethodOfGivingCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMethodOfGiving(DataSet AData, String AMethodOfGivingCode, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGiving(AData, AMethodOfGivingCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfGiving(DataSet AData, String AMethodOfGivingCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGiving(AData, AMethodOfGivingCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfGiving(out AGiftTable AData, String AMethodOfGivingCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftTable();
            LoadViaForeignKey(AGiftTable.TableId, AMethodOfGivingTable.TableId, AData, new string[1]{"a_method_of_giving_code_c"},
                new System.Object[1]{AMethodOfGivingCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMethodOfGiving(out AGiftTable AData, String AMethodOfGivingCode, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGiving(out AData, AMethodOfGivingCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfGiving(out AGiftTable AData, String AMethodOfGivingCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGiving(out AData, AMethodOfGivingCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(DataSet ADataSet, AMethodOfGivingRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftTable.TableId, AMethodOfGivingTable.TableId, ADataSet, new string[1]{"a_method_of_giving_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(DataSet AData, AMethodOfGivingRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGivingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(DataSet AData, AMethodOfGivingRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGivingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(out AGiftTable AData, AMethodOfGivingRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftTable();
            LoadViaForeignKey(AGiftTable.TableId, AMethodOfGivingTable.TableId, AData, new string[1]{"a_method_of_giving_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(out AGiftTable AData, AMethodOfGivingRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGivingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(out AGiftTable AData, AMethodOfGivingRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGivingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(out AGiftTable AData, AMethodOfGivingRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGivingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftTable.TableId, AMethodOfGivingTable.TableId, ADataSet, new string[1]{"a_method_of_giving_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGivingTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGivingTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(out AGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftTable();
            LoadViaForeignKey(AGiftTable.TableId, AMethodOfGivingTable.TableId, AData, new string[1]{"a_method_of_giving_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(out AGiftTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGivingTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfGivingTemplate(out AGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfGivingTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaAMethodOfGiving(String AMethodOfGivingCode, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftTable.TableId, AMethodOfGivingTable.TableId, new string[1]{"a_method_of_giving_code_c"},
                new System.Object[1]{AMethodOfGivingCode}, ATransaction);
        }

        /// auto generated
        public static int CountViaAMethodOfGivingTemplate(AMethodOfGivingRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftTable.TableId, AMethodOfGivingTable.TableId, new string[1]{"a_method_of_giving_code_c"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaAMethodOfGivingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftTable.TableId, AMethodOfGivingTable.TableId, new string[1]{"a_method_of_giving_code_c"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaAMethodOfPayment(DataSet ADataSet, String AMethodOfPaymentCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftTable.TableId, AMethodOfPaymentTable.TableId, ADataSet, new string[1]{"a_method_of_payment_code_c"},
                new System.Object[1]{AMethodOfPaymentCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMethodOfPayment(DataSet AData, String AMethodOfPaymentCode, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPayment(AData, AMethodOfPaymentCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfPayment(DataSet AData, String AMethodOfPaymentCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPayment(AData, AMethodOfPaymentCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfPayment(out AGiftTable AData, String AMethodOfPaymentCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftTable();
            LoadViaForeignKey(AGiftTable.TableId, AMethodOfPaymentTable.TableId, AData, new string[1]{"a_method_of_payment_code_c"},
                new System.Object[1]{AMethodOfPaymentCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMethodOfPayment(out AGiftTable AData, String AMethodOfPaymentCode, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPayment(out AData, AMethodOfPaymentCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfPayment(out AGiftTable AData, String AMethodOfPaymentCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPayment(out AData, AMethodOfPaymentCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(DataSet ADataSet, AMethodOfPaymentRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftTable.TableId, AMethodOfPaymentTable.TableId, ADataSet, new string[1]{"a_method_of_payment_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(DataSet AData, AMethodOfPaymentRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPaymentTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(DataSet AData, AMethodOfPaymentRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPaymentTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(out AGiftTable AData, AMethodOfPaymentRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftTable();
            LoadViaForeignKey(AGiftTable.TableId, AMethodOfPaymentTable.TableId, AData, new string[1]{"a_method_of_payment_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(out AGiftTable AData, AMethodOfPaymentRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPaymentTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(out AGiftTable AData, AMethodOfPaymentRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPaymentTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(out AGiftTable AData, AMethodOfPaymentRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPaymentTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftTable.TableId, AMethodOfPaymentTable.TableId, ADataSet, new string[1]{"a_method_of_payment_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPaymentTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPaymentTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(out AGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftTable();
            LoadViaForeignKey(AGiftTable.TableId, AMethodOfPaymentTable.TableId, AData, new string[1]{"a_method_of_payment_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(out AGiftTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPaymentTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMethodOfPaymentTemplate(out AGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMethodOfPaymentTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaAMethodOfPayment(String AMethodOfPaymentCode, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftTable.TableId, AMethodOfPaymentTable.TableId, new string[1]{"a_method_of_payment_code_c"},
                new System.Object[1]{AMethodOfPaymentCode}, ATransaction);
        }

        /// auto generated
        public static int CountViaAMethodOfPaymentTemplate(AMethodOfPaymentRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftTable.TableId, AMethodOfPaymentTable.TableId, new string[1]{"a_method_of_payment_code_c"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaAMethodOfPaymentTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftTable.TableId, AMethodOfPaymentTable.TableId, new string[1]{"a_method_of_payment_code_c"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaPPartner(DataSet ADataSet, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftTable.TableId, PPartnerTable.TableId, ADataSet, new string[1]{"p_donor_key_n"},
                new System.Object[1]{APartnerKey}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartner(DataSet AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartner(AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartner(DataSet AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartner(AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartner(out AGiftTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftTable();
            LoadViaForeignKey(AGiftTable.TableId, PPartnerTable.TableId, AData, new string[1]{"p_donor_key_n"},
                new System.Object[1]{APartnerKey}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartner(out AGiftTable AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartner(out AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartner(out AGiftTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartner(out AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet ADataSet, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftTable.TableId, PPartnerTable.TableId, ADataSet, new string[1]{"p_donor_key_n"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out AGiftTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftTable();
            LoadViaForeignKey(AGiftTable.TableId, PPartnerTable.TableId, AData, new string[1]{"p_donor_key_n"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out AGiftTable AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out AGiftTable AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out AGiftTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftTable.TableId, PPartnerTable.TableId, ADataSet, new string[1]{"p_donor_key_n"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out AGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftTable();
            LoadViaForeignKey(AGiftTable.TableId, PPartnerTable.TableId, AData, new string[1]{"p_donor_key_n"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out AGiftTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out AGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPPartner(Int64 APartnerKey, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftTable.TableId, PPartnerTable.TableId, new string[1]{"p_donor_key_n"},
                new System.Object[1]{APartnerKey}, ATransaction);
        }

        /// auto generated
        public static int CountViaPPartnerTemplate(PPartnerRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftTable.TableId, PPartnerTable.TableId, new string[1]{"p_donor_key_n"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaPPartnerTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftTable.TableId, PPartnerTable.TableId, new string[1]{"p_donor_key_n"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated LoadViaLinkTable
        public static void LoadViaSGroup(DataSet ADataSet, String AGroupId, Int64 AUnitKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(AGroupId));
            ParametersArray[1] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[1].Value = ((object)(AUnitKey));
            DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClauseLong("PUB_a_gift", AFieldList, AGiftTable.TableId) +
                            " FROM PUB_a_gift, PUB_s_group_gift WHERE " +
                            "PUB_s_group_gift.a_ledger_number_i = PUB_a_gift.a_ledger_number_i AND PUB_s_group_gift.a_batch_number_i = PUB_a_gift.a_batch_number_i AND PUB_s_group_gift.a_gift_transaction_number_i = PUB_a_gift.a_gift_transaction_number_i AND PUB_s_group_gift.s_group_id_c = ? AND PUB_s_group_gift.s_group_unit_key_n = ?") +
                            GenerateOrderByClause(AOrderBy)), TTypedDataTable.GetTableName(AGiftTable.TableId), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSGroup(DataSet AData, String AGroupId, Int64 AUnitKey, TDBTransaction ATransaction)
        {
            LoadViaSGroup(AData, AGroupId, AUnitKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroup(DataSet AData, String AGroupId, Int64 AUnitKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSGroup(AData, AGroupId, AUnitKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroup(out AGiftTable AData, String AGroupId, Int64 AUnitKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new AGiftTable();
            FillDataSet.Tables.Add(AData);
            LoadViaSGroup(FillDataSet, AGroupId, AUnitKey, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaSGroup(out AGiftTable AData, String AGroupId, Int64 AUnitKey, TDBTransaction ATransaction)
        {
            LoadViaSGroup(out AData, AGroupId, AUnitKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroup(out AGiftTable AData, String AGroupId, Int64 AUnitKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSGroup(out AData, AGroupId, AUnitKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(DataSet ADataSet, SGroupRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_a_gift", AFieldList, AGiftTable.TableId) +
                            " FROM PUB_a_gift, PUB_s_group_gift, PUB_s_group WHERE " +
                            "PUB_s_group_gift.a_ledger_number_i = PUB_a_gift.a_ledger_number_i AND PUB_s_group_gift.a_batch_number_i = PUB_a_gift.a_batch_number_i AND PUB_s_group_gift.a_gift_transaction_number_i = PUB_a_gift.a_gift_transaction_number_i AND PUB_s_group_gift.s_group_id_c = PUB_s_group.s_group_id_c AND PUB_s_group_gift.s_group_unit_key_n = PUB_s_group.s_unit_key_n") +
                            GenerateWhereClauseLong("PUB_s_group", SGroupTable.TableId, ATemplateRow, ATemplateOperators)) +
                            GenerateOrderByClause(AOrderBy)), TTypedDataTable.GetTableName(AGiftTable.TableId), ATransaction,
                            GetParametersForWhereClause(SGroupTable.TableId, ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(DataSet AData, SGroupRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(DataSet AData, SGroupRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(out AGiftTable AData, SGroupRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new AGiftTable();
            FillDataSet.Tables.Add(AData);
            LoadViaSGroupTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(out AGiftTable AData, SGroupRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(out AGiftTable AData, SGroupRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(out AGiftTable AData, SGroupRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_a_gift", AFieldList, AGiftTable.TableId) +
                            " FROM PUB_a_gift, PUB_s_group_gift, PUB_s_group WHERE " +
                            "PUB_s_group_gift.a_ledger_number_i = PUB_a_gift.a_ledger_number_i AND PUB_s_group_gift.a_batch_number_i = PUB_a_gift.a_batch_number_i AND PUB_s_group_gift.a_gift_transaction_number_i = PUB_a_gift.a_gift_transaction_number_i AND PUB_s_group_gift.s_group_id_c = PUB_s_group.s_group_id_c AND PUB_s_group_gift.s_group_unit_key_n = PUB_s_group.s_unit_key_n") +
                            GenerateWhereClauseLong("PUB_s_group", ASearchCriteria)) +
                            GenerateOrderByClause(AOrderBy)), TTypedDataTable.GetTableName(AGiftTable.TableId), ATransaction,
                            GetParametersForWhereClause(AGiftTable.TableId, ASearchCriteria), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(out AGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new AGiftTable();
            FillDataSet.Tables.Add(AData);
            LoadViaSGroupTemplate(FillDataSet, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(out AGiftTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(out AGiftTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated CountViaLinkTable
        public static int CountViaSGroup(String AGroupId, Int64 AUnitKey, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(AGroupId));
            ParametersArray[1] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[1].Value = ((object)(AUnitKey));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_a_gift, PUB_s_group_gift WHERE " +
                        "PUB_s_group_gift.a_ledger_number_i = PUB_a_gift.a_ledger_number_i AND PUB_s_group_gift.a_batch_number_i = PUB_a_gift.a_batch_number_i AND PUB_s_group_gift.a_gift_transaction_number_i = PUB_a_gift.a_gift_transaction_number_i AND PUB_s_group_gift.s_group_id_c = ? AND PUB_s_group_gift.s_group_unit_key_n = ?",
                        ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaSGroupTemplate(SGroupRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_a_gift, PUB_s_group_gift, PUB_s_group WHERE " +
                        "PUB_s_group_gift.a_ledger_number_i = PUB_a_gift.a_ledger_number_i AND PUB_s_group_gift.a_batch_number_i = PUB_a_gift.a_batch_number_i AND PUB_s_group_gift.a_gift_transaction_number_i = PUB_a_gift.a_gift_transaction_number_i AND PUB_s_group_gift.s_group_id_c = PUB_s_group.s_group_id_c AND PUB_s_group_gift.s_group_unit_key_n = PUB_s_group.s_unit_key_n" +
                        GenerateWhereClauseLong("PUB_s_group_gift", AGiftTable.TableId, ATemplateRow, ATemplateOperators)), ATransaction, false,
                        GetParametersForWhereClauseWithPrimaryKey(SGroupTable.TableId, ATemplateRow)));
        }

        /// auto generated
        public static int CountViaSGroupTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_a_gift, PUB_s_group_gift, PUB_s_group WHERE " +
                        "PUB_s_group_gift.a_ledger_number_i = PUB_a_gift.a_ledger_number_i AND PUB_s_group_gift.a_batch_number_i = PUB_a_gift.a_batch_number_i AND PUB_s_group_gift.a_gift_transaction_number_i = PUB_a_gift.a_gift_transaction_number_i AND PUB_s_group_gift.s_group_id_c = PUB_s_group.s_group_id_c AND PUB_s_group_gift.s_group_unit_key_n = PUB_s_group.s_unit_key_n" +
                        GenerateWhereClauseLong("PUB_s_group_gift", ASearchCriteria)), ATransaction, false,
                        GetParametersForWhereClause(AGiftTable.TableId, ASearchCriteria)));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, TDBTransaction ATransaction)
        {
            DeleteByPrimaryKey(AGiftTable.TableId, new System.Object[3]{ALedgerNumber, ABatchNumber, AGiftTransactionNumber}, ATransaction);
        }

        /// auto generated
        public static void DeleteUsingTemplate(AGiftRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DeleteUsingTemplate(AGiftTable.TableId, ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static void DeleteUsingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            DeleteUsingTemplate(AGiftTable.TableId, ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static bool SubmitChanges(AGiftTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            return SubmitChanges(AGiftTable.TableId, ATable, ATransaction, out AVerificationResult, UserInfo.GUserInfo.UserID);
        }
    }

    /// The gift recipient information for a gift.  A single gift can be split among more than one recipient.  A gift detail record is created for each recipient.
    public class AGiftDetailAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "AGiftDetail";

        /// original table name in database
        public const string DBTABLENAME = "a_gift_detail";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, AGiftDetailTable.TableId) + " FROM PUB_a_gift_detail") +
                            GenerateOrderByClause(AOrderBy)), TTypedDataTable.GetTableName(AGiftDetailTable.TableId), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out AGiftDetailTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            DBAccess.GDBAccessObj.SelectDT(AData, GenerateSelectClause(AFieldList, AGiftDetailTable.TableId) + " FROM PUB_a_gift_detail" + GenerateOrderByClause(AOrderBy), ATransaction, null, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(out AGiftDetailTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out AGiftDetailTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, Int32 ADetailNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadByPrimaryKey(AGiftDetailTable.TableId, ADataSet, new System.Object[4]{ALedgerNumber, ABatchNumber, AGiftTransactionNumber, ADetailNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, Int32 ADetailNumber, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ALedgerNumber, ABatchNumber, AGiftTransactionNumber, ADetailNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, Int32 ADetailNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ALedgerNumber, ABatchNumber, AGiftTransactionNumber, ADetailNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out AGiftDetailTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, Int32 ADetailNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            LoadByPrimaryKey(AGiftDetailTable.TableId, AData, new System.Object[4]{ALedgerNumber, ABatchNumber, AGiftTransactionNumber, ADetailNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out AGiftDetailTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, Int32 ADetailNumber, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ALedgerNumber, ABatchNumber, AGiftTransactionNumber, ADetailNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out AGiftDetailTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, Int32 ADetailNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ALedgerNumber, ABatchNumber, AGiftTransactionNumber, ADetailNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, AGiftDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadUsingTemplate(AGiftDetailTable.TableId, ADataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, AGiftDetailRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, AGiftDetailRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AGiftDetailTable AData, AGiftDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            LoadUsingTemplate(AGiftDetailTable.TableId, AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AGiftDetailTable AData, AGiftDetailRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AGiftDetailTable AData, AGiftDetailRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AGiftDetailTable AData, AGiftDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadUsingTemplate(AGiftDetailTable.TableId, ADataSet, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            LoadUsingTemplate(AGiftDetailTable.TableId, AData, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out AGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_a_gift_detail", ATransaction, false));
        }

        /// check if a row exists by using the primary key
        public static bool Exists(Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, Int32 ADetailNumber, TDBTransaction ATransaction)
        {
            return Exists(AGiftDetailTable.TableId, new System.Object[4]{ALedgerNumber, ABatchNumber, AGiftTransactionNumber, ADetailNumber}, ATransaction);
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(AGiftDetailRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_a_gift_detail" + GenerateWhereClause(TTypedDataTable.GetColumnStringList(AGiftDetailTable.TableId), ATemplateRow, ATemplateOperators)), ATransaction, false,
                   GetParametersForWhereClause(AGiftDetailTable.TableId, ATemplateRow)));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_a_gift_detail" + GenerateWhereClause(TTypedDataTable.GetColumnStringList(AGiftDetailTable.TableId), ASearchCriteria)), ATransaction, false,
            GetParametersForWhereClause(AGiftDetailTable.TableId, ASearchCriteria)));
        }

        /// auto generated
        public static void LoadViaAGift(DataSet ADataSet, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftDetailTable.TableId, AGiftTable.TableId, ADataSet, new string[3]{"a_ledger_number_i", "a_batch_number_i", "a_gift_transaction_number_i"},
                new System.Object[3]{ALedgerNumber, ABatchNumber, AGiftTransactionNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAGift(DataSet AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, TDBTransaction ATransaction)
        {
            LoadViaAGift(AData, ALedgerNumber, ABatchNumber, AGiftTransactionNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAGift(DataSet AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAGift(AData, ALedgerNumber, ABatchNumber, AGiftTransactionNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAGift(out AGiftDetailTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            LoadViaForeignKey(AGiftDetailTable.TableId, AGiftTable.TableId, AData, new string[3]{"a_ledger_number_i", "a_batch_number_i", "a_gift_transaction_number_i"},
                new System.Object[3]{ALedgerNumber, ABatchNumber, AGiftTransactionNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAGift(out AGiftDetailTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, TDBTransaction ATransaction)
        {
            LoadViaAGift(out AData, ALedgerNumber, ABatchNumber, AGiftTransactionNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAGift(out AGiftDetailTable AData, Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAGift(out AData, ALedgerNumber, ABatchNumber, AGiftTransactionNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAGiftTemplate(DataSet ADataSet, AGiftRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftDetailTable.TableId, AGiftTable.TableId, ADataSet, new string[3]{"a_ledger_number_i", "a_batch_number_i", "a_gift_transaction_number_i"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAGiftTemplate(DataSet AData, AGiftRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAGiftTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAGiftTemplate(DataSet AData, AGiftRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAGiftTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAGiftTemplate(out AGiftDetailTable AData, AGiftRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            LoadViaForeignKey(AGiftDetailTable.TableId, AGiftTable.TableId, AData, new string[3]{"a_ledger_number_i", "a_batch_number_i", "a_gift_transaction_number_i"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAGiftTemplate(out AGiftDetailTable AData, AGiftRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAGiftTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAGiftTemplate(out AGiftDetailTable AData, AGiftRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAGiftTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAGiftTemplate(out AGiftDetailTable AData, AGiftRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAGiftTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAGiftTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftDetailTable.TableId, AGiftTable.TableId, ADataSet, new string[3]{"a_ledger_number_i", "a_batch_number_i", "a_gift_transaction_number_i"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAGiftTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAGiftTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAGiftTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAGiftTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAGiftTemplate(out AGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            LoadViaForeignKey(AGiftDetailTable.TableId, AGiftTable.TableId, AData, new string[3]{"a_ledger_number_i", "a_batch_number_i", "a_gift_transaction_number_i"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAGiftTemplate(out AGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAGiftTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAGiftTemplate(out AGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAGiftTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaAGift(Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftDetailTable.TableId, AGiftTable.TableId, new string[3]{"a_ledger_number_i", "a_batch_number_i", "a_gift_transaction_number_i"},
                new System.Object[3]{ALedgerNumber, ABatchNumber, AGiftTransactionNumber}, ATransaction);
        }

        /// auto generated
        public static int CountViaAGiftTemplate(AGiftRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftDetailTable.TableId, AGiftTable.TableId, new string[3]{"a_ledger_number_i", "a_batch_number_i", "a_gift_transaction_number_i"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaAGiftTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftDetailTable.TableId, AGiftTable.TableId, new string[3]{"a_ledger_number_i", "a_batch_number_i", "a_gift_transaction_number_i"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaAMotivationDetail(DataSet ADataSet, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftDetailTable.TableId, AMotivationDetailTable.TableId, ADataSet, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                new System.Object[3]{ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMotivationDetail(DataSet AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetail(AData, ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetail(DataSet AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetail(AData, ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetail(out AGiftDetailTable AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            LoadViaForeignKey(AGiftDetailTable.TableId, AMotivationDetailTable.TableId, AData, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                new System.Object[3]{ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMotivationDetail(out AGiftDetailTable AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetail(out AData, ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetail(out AGiftDetailTable AData, Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetail(out AData, ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(DataSet ADataSet, AMotivationDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftDetailTable.TableId, AMotivationDetailTable.TableId, ADataSet, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(DataSet AData, AMotivationDetailRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(DataSet AData, AMotivationDetailRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(out AGiftDetailTable AData, AMotivationDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            LoadViaForeignKey(AGiftDetailTable.TableId, AMotivationDetailTable.TableId, AData, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(out AGiftDetailTable AData, AMotivationDetailRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(out AGiftDetailTable AData, AMotivationDetailRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(out AGiftDetailTable AData, AMotivationDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftDetailTable.TableId, AMotivationDetailTable.TableId, ADataSet, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(out AGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            LoadViaForeignKey(AGiftDetailTable.TableId, AMotivationDetailTable.TableId, AData, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(out AGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAMotivationDetailTemplate(out AGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAMotivationDetailTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaAMotivationDetail(Int32 ALedgerNumber, String AMotivationGroupCode, String AMotivationDetailCode, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftDetailTable.TableId, AMotivationDetailTable.TableId, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                new System.Object[3]{ALedgerNumber, AMotivationGroupCode, AMotivationDetailCode}, ATransaction);
        }

        /// auto generated
        public static int CountViaAMotivationDetailTemplate(AMotivationDetailRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftDetailTable.TableId, AMotivationDetailTable.TableId, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaAMotivationDetailTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftDetailTable.TableId, AMotivationDetailTable.TableId, new string[3]{"a_ledger_number_i", "a_motivation_group_code_c", "a_motivation_detail_code_c"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKey(DataSet ADataSet, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftDetailTable.TableId, PPartnerTable.TableId, ADataSet, new string[1]{"p_recipient_key_n"},
                new System.Object[1]{APartnerKey}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKey(DataSet AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKey(AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKey(DataSet AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKey(AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKey(out AGiftDetailTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            LoadViaForeignKey(AGiftDetailTable.TableId, PPartnerTable.TableId, AData, new string[1]{"p_recipient_key_n"},
                new System.Object[1]{APartnerKey}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKey(out AGiftDetailTable AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKey(out AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKey(out AGiftDetailTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKey(out AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(DataSet ADataSet, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftDetailTable.TableId, PPartnerTable.TableId, ADataSet, new string[1]{"p_recipient_key_n"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(DataSet AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKeyTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(DataSet AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKeyTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(out AGiftDetailTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            LoadViaForeignKey(AGiftDetailTable.TableId, PPartnerTable.TableId, AData, new string[1]{"p_recipient_key_n"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(out AGiftDetailTable AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKeyTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(out AGiftDetailTable AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKeyTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(out AGiftDetailTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKeyTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftDetailTable.TableId, PPartnerTable.TableId, ADataSet, new string[1]{"p_recipient_key_n"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKeyTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKeyTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(out AGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            LoadViaForeignKey(AGiftDetailTable.TableId, PPartnerTable.TableId, AData, new string[1]{"p_recipient_key_n"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(out AGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKeyTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientKeyTemplate(out AGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientKeyTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPPartnerRecipientKey(Int64 APartnerKey, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftDetailTable.TableId, PPartnerTable.TableId, new string[1]{"p_recipient_key_n"},
                new System.Object[1]{APartnerKey}, ATransaction);
        }

        /// auto generated
        public static int CountViaPPartnerRecipientKeyTemplate(PPartnerRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftDetailTable.TableId, PPartnerTable.TableId, new string[1]{"p_recipient_key_n"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaPPartnerRecipientKeyTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftDetailTable.TableId, PPartnerTable.TableId, new string[1]{"p_recipient_key_n"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaPMailing(DataSet ADataSet, String AMailingCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftDetailTable.TableId, PMailingTable.TableId, ADataSet, new string[1]{"p_mailing_code_c"},
                new System.Object[1]{AMailingCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPMailing(DataSet AData, String AMailingCode, TDBTransaction ATransaction)
        {
            LoadViaPMailing(AData, AMailingCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailing(DataSet AData, String AMailingCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMailing(AData, AMailingCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailing(out AGiftDetailTable AData, String AMailingCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            LoadViaForeignKey(AGiftDetailTable.TableId, PMailingTable.TableId, AData, new string[1]{"p_mailing_code_c"},
                new System.Object[1]{AMailingCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPMailing(out AGiftDetailTable AData, String AMailingCode, TDBTransaction ATransaction)
        {
            LoadViaPMailing(out AData, AMailingCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailing(out AGiftDetailTable AData, String AMailingCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMailing(out AData, AMailingCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(DataSet ADataSet, PMailingRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftDetailTable.TableId, PMailingTable.TableId, ADataSet, new string[1]{"p_mailing_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(DataSet AData, PMailingRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPMailingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(DataSet AData, PMailingRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMailingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(out AGiftDetailTable AData, PMailingRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            LoadViaForeignKey(AGiftDetailTable.TableId, PMailingTable.TableId, AData, new string[1]{"p_mailing_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(out AGiftDetailTable AData, PMailingRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPMailingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(out AGiftDetailTable AData, PMailingRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMailingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(out AGiftDetailTable AData, PMailingRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMailingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftDetailTable.TableId, PMailingTable.TableId, ADataSet, new string[1]{"p_mailing_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaPMailingTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMailingTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(out AGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            LoadViaForeignKey(AGiftDetailTable.TableId, PMailingTable.TableId, AData, new string[1]{"p_mailing_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(out AGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaPMailingTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(out AGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMailingTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPMailing(String AMailingCode, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftDetailTable.TableId, PMailingTable.TableId, new string[1]{"p_mailing_code_c"},
                new System.Object[1]{AMailingCode}, ATransaction);
        }

        /// auto generated
        public static int CountViaPMailingTemplate(PMailingRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftDetailTable.TableId, PMailingTable.TableId, new string[1]{"p_mailing_code_c"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaPMailingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftDetailTable.TableId, PMailingTable.TableId, new string[1]{"p_mailing_code_c"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumber(DataSet ADataSet, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftDetailTable.TableId, PPartnerTable.TableId, ADataSet, new string[1]{"a_recipient_ledger_number_n"},
                new System.Object[1]{APartnerKey}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumber(DataSet AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumber(AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumber(DataSet AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumber(AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumber(out AGiftDetailTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            LoadViaForeignKey(AGiftDetailTable.TableId, PPartnerTable.TableId, AData, new string[1]{"a_recipient_ledger_number_n"},
                new System.Object[1]{APartnerKey}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumber(out AGiftDetailTable AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumber(out AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumber(out AGiftDetailTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumber(out AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(DataSet ADataSet, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftDetailTable.TableId, PPartnerTable.TableId, ADataSet, new string[1]{"a_recipient_ledger_number_n"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(DataSet AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumberTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(DataSet AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumberTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(out AGiftDetailTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            LoadViaForeignKey(AGiftDetailTable.TableId, PPartnerTable.TableId, AData, new string[1]{"a_recipient_ledger_number_n"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(out AGiftDetailTable AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumberTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(out AGiftDetailTable AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumberTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(out AGiftDetailTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumberTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftDetailTable.TableId, PPartnerTable.TableId, ADataSet, new string[1]{"a_recipient_ledger_number_n"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumberTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumberTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(out AGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            LoadViaForeignKey(AGiftDetailTable.TableId, PPartnerTable.TableId, AData, new string[1]{"a_recipient_ledger_number_n"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(out AGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumberTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerRecipientLedgerNumberTemplate(out AGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerRecipientLedgerNumberTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPPartnerRecipientLedgerNumber(Int64 APartnerKey, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftDetailTable.TableId, PPartnerTable.TableId, new string[1]{"a_recipient_ledger_number_n"},
                new System.Object[1]{APartnerKey}, ATransaction);
        }

        /// auto generated
        public static int CountViaPPartnerRecipientLedgerNumberTemplate(PPartnerRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftDetailTable.TableId, PPartnerTable.TableId, new string[1]{"a_recipient_ledger_number_n"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaPPartnerRecipientLedgerNumberTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftDetailTable.TableId, PPartnerTable.TableId, new string[1]{"a_recipient_ledger_number_n"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaACostCentre(DataSet ADataSet, Int32 ALedgerNumber, String ACostCentreCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftDetailTable.TableId, ACostCentreTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_cost_centre_code_c"},
                new System.Object[2]{ALedgerNumber, ACostCentreCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACostCentre(DataSet AData, Int32 ALedgerNumber, String ACostCentreCode, TDBTransaction ATransaction)
        {
            LoadViaACostCentre(AData, ALedgerNumber, ACostCentreCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentre(DataSet AData, Int32 ALedgerNumber, String ACostCentreCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentre(AData, ALedgerNumber, ACostCentreCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentre(out AGiftDetailTable AData, Int32 ALedgerNumber, String ACostCentreCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            LoadViaForeignKey(AGiftDetailTable.TableId, ACostCentreTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_cost_centre_code_c"},
                new System.Object[2]{ALedgerNumber, ACostCentreCode}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACostCentre(out AGiftDetailTable AData, Int32 ALedgerNumber, String ACostCentreCode, TDBTransaction ATransaction)
        {
            LoadViaACostCentre(out AData, ALedgerNumber, ACostCentreCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentre(out AGiftDetailTable AData, Int32 ALedgerNumber, String ACostCentreCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentre(out AData, ALedgerNumber, ACostCentreCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(DataSet ADataSet, ACostCentreRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftDetailTable.TableId, ACostCentreTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_cost_centre_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(DataSet AData, ACostCentreRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(DataSet AData, ACostCentreRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out AGiftDetailTable AData, ACostCentreRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            LoadViaForeignKey(AGiftDetailTable.TableId, ACostCentreTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_cost_centre_code_c"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out AGiftDetailTable AData, ACostCentreRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out AGiftDetailTable AData, ACostCentreRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out AGiftDetailTable AData, ACostCentreRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftDetailTable.TableId, ACostCentreTable.TableId, ADataSet, new string[2]{"a_ledger_number_i", "a_cost_centre_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out AGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            LoadViaForeignKey(AGiftDetailTable.TableId, ACostCentreTable.TableId, AData, new string[2]{"a_ledger_number_i", "a_cost_centre_code_c"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out AGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACostCentreTemplate(out AGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACostCentreTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaACostCentre(Int32 ALedgerNumber, String ACostCentreCode, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftDetailTable.TableId, ACostCentreTable.TableId, new string[2]{"a_ledger_number_i", "a_cost_centre_code_c"},
                new System.Object[2]{ALedgerNumber, ACostCentreCode}, ATransaction);
        }

        /// auto generated
        public static int CountViaACostCentreTemplate(ACostCentreRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftDetailTable.TableId, ACostCentreTable.TableId, new string[2]{"a_ledger_number_i", "a_cost_centre_code_c"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaACostCentreTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftDetailTable.TableId, ACostCentreTable.TableId, new string[2]{"a_ledger_number_i", "a_cost_centre_code_c"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void LoadViaALedger(DataSet ADataSet, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftDetailTable.TableId, ALedgerTable.TableId, ADataSet, new string[1]{"a_ledger_number_i"},
                new System.Object[1]{ALedgerNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedger(DataSet AData, Int32 ALedgerNumber, TDBTransaction ATransaction)
        {
            LoadViaALedger(AData, ALedgerNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedger(DataSet AData, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedger(AData, ALedgerNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedger(out AGiftDetailTable AData, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            LoadViaForeignKey(AGiftDetailTable.TableId, ALedgerTable.TableId, AData, new string[1]{"a_ledger_number_i"},
                new System.Object[1]{ALedgerNumber}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedger(out AGiftDetailTable AData, Int32 ALedgerNumber, TDBTransaction ATransaction)
        {
            LoadViaALedger(out AData, ALedgerNumber, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedger(out AGiftDetailTable AData, Int32 ALedgerNumber, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedger(out AData, ALedgerNumber, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet ADataSet, ALedgerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftDetailTable.TableId, ALedgerTable.TableId, ADataSet, new string[1]{"a_ledger_number_i"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, ALedgerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, ALedgerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AGiftDetailTable AData, ALedgerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            LoadViaForeignKey(AGiftDetailTable.TableId, ALedgerTable.TableId, AData, new string[1]{"a_ledger_number_i"},
                ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AGiftDetailTable AData, ALedgerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AGiftDetailTable AData, ALedgerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AGiftDetailTable AData, ALedgerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            LoadViaForeignKey(AGiftDetailTable.TableId, ALedgerTable.TableId, ADataSet, new string[1]{"a_ledger_number_i"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            AData = new AGiftDetailTable();
            LoadViaForeignKey(AGiftDetailTable.TableId, ALedgerTable.TableId, AData, new string[1]{"a_ledger_number_i"},
                ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaALedgerTemplate(out AGiftDetailTable AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaALedgerTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaALedger(Int32 ALedgerNumber, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftDetailTable.TableId, ALedgerTable.TableId, new string[1]{"a_ledger_number_i"},
                new System.Object[1]{ALedgerNumber}, ATransaction);
        }

        /// auto generated
        public static int CountViaALedgerTemplate(ALedgerRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftDetailTable.TableId, ALedgerTable.TableId, new string[1]{"a_ledger_number_i"},
                ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static int CountViaALedgerTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            return CountViaForeignKey(AGiftDetailTable.TableId, ALedgerTable.TableId, new string[1]{"a_ledger_number_i"},
                ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static void DeleteByPrimaryKey(Int32 ALedgerNumber, Int32 ABatchNumber, Int32 AGiftTransactionNumber, Int32 ADetailNumber, TDBTransaction ATransaction)
        {
            DeleteByPrimaryKey(AGiftDetailTable.TableId, new System.Object[4]{ALedgerNumber, ABatchNumber, AGiftTransactionNumber, ADetailNumber}, ATransaction);
        }

        /// auto generated
        public static void DeleteUsingTemplate(AGiftDetailRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DeleteUsingTemplate(AGiftDetailTable.TableId, ATemplateRow, ATemplateOperators, ATransaction);
        }

        /// auto generated
        public static void DeleteUsingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
        {
            DeleteUsingTemplate(AGiftDetailTable.TableId, ASearchCriteria, ATransaction);
        }

        /// auto generated
        public static bool SubmitChanges(AGiftDetailTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            return SubmitChanges(AGiftDetailTable.TableId, ATable, ATransaction, out AVerificationResult, UserInfo.GUserInfo.UserID);
        }
    }
}