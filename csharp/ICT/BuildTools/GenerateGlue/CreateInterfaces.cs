//
// DO NOT REMOVE COPYRIGHT NOTICES OR THIS FILE HEADER.
//
// @Authors:
//       timop
//
// Copyright 2004-2012 by OM International
//
// This file is part of OpenPetra.org.
//
// OpenPetra.org is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// OpenPetra.org is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with OpenPetra.org.  If not, see <http://www.gnu.org/licenses/>.
//
using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using System.Text;
using ICSharpCode.NRefactory.Ast;
using ICSharpCode.NRefactory;
using NamespaceHierarchy;
using Ict.Common;
using Ict.Common.IO;
using Ict.Tools.CodeGeneration;

namespace GenerateSharedCode
{
/// <summary>
/// create the interfaces for the shared code
/// </summary>
public class CreateInterfaces
{
    private string FTemplateDir = string.Empty;

    /// <summary>
    /// this will return a SortedList, the key is the interface name,
    /// and the value is the class with the full namespace that implements that interface
    /// </summary>
    /// <param name="ACSFiles"></param>
    /// <returns></returns>
    private SortedList GetInterfaceNamesFromImplementation(List <CSParser>ACSFiles)
    {
        SortedList Result = new SortedList();

        foreach (CSParser CSFile in ACSFiles)
        {
            foreach (TypeDeclaration t in CSFile.GetClasses())
            {
                string FullClassNameWithNamespace = CSFile.GetFullClassNameWithNamespace(t);

                if (FullClassNameWithNamespace.Contains("Connector"))
                {
                    foreach (ICSharpCode.NRefactory.Ast.TypeReference ti in t.BaseTypes)
                    {
                        if (ti.Type.StartsWith("I"))
                        {
                            Result.Add(ti.Type, CSFile.GetFullClassNameWithNamespace(t));
                        }
                    }
                }
            }
        }

        return Result;
    }

    /// <summary>
    /// return all classes in a given namespace that implement the interface
    /// </summary>
    /// <param name="ACSFiles"></param>
    /// <param name="AInterfaceName"></param>
    /// <param name="ANamespace">namespace name on the server</param>
    /// <returns></returns>
    private List <TypeDeclaration>GetClassesThatImplementInterface(
        List <CSParser>ACSFiles, String AInterfaceName, String ANamespace)
    {
        List <TypeDeclaration>ClassList = new List <TypeDeclaration>();

        // find all classes in that server namespace, eg. Ict.Petra.Server.MPartner.Extracts.UIConnectors
        List <TypeDeclaration>ConnectorClasses = CSParser.GetClassesInNamespace(ACSFiles, ANamespace);

        foreach (TypeDeclaration t in ConnectorClasses)
        {
            if ((t.BaseTypes.Count == 0) && ANamespace.EndsWith("WebConnectors"))
            {
                ClassList.Add(t);
                continue;
            }

            foreach (ICSharpCode.NRefactory.Ast.TypeReference ti in t.BaseTypes)
            {
                if (ti.Type == AInterfaceName)
                {
                    ClassList.Add(t);
                    break;
                }
            }
        }

        return ClassList;
    }

    /// <summary>
    /// write the interfaces for the methods that need to be reflected
    /// check connector files
    /// </summary>
    /// <param name="ATemplate"></param>
    /// <param name="AMethodsAlreadyWritten">write methods only once</param>
    /// <param name="AConnectorClasses">the classes that are implementing the methods</param>
    /// <param name="AInterfaceName">the interface that is written at the moment</param>
    /// <param name="AInterfaceNamespace">only needed to shorten the type names to improve readability</param>
    /// <param name="AServerNamespace">for the comment in the autogenerated code</param>
    /// <returns></returns>
    private bool WriteConnectorMethods(
        ProcessTemplate ATemplate,
        ref StringCollection AMethodsAlreadyWritten,
        List <TypeDeclaration>AConnectorClasses, String AInterfaceName, String AInterfaceNamespace, String AServerNamespace)
    {
        foreach (TypeDeclaration t in AConnectorClasses)
        {
            string ConnectorClassName = t.Name;

            foreach (PropertyDeclaration p in CSParser.GetProperties(t))
            {
                if (TCollectConnectorInterfaces.IgnoreMethod(p.Attributes, p.Modifier))
                {
                    continue;
                }

                if (!p.GetRegion.Block.ToString().Contains("TCreateRemotableObject"))
                {
                    TLogging.Log("Warning: properties in UIConnectors must use the class TCreateRemotableObject: " +
                        AServerNamespace + "." + t.Name + "." + p.Name);
                }

                // don't write namespace hierarchy here
                if (p.TypeReference.Type.IndexOf("Namespace") == -1)
                {
                    String returnType = AutoGenerationTools.TypeToString(p.TypeReference, AInterfaceNamespace);

                    // this interface got implemented somewhere on the server
                    ProcessTemplate snippet = ATemplate.GetSnippet("CONNECTORPROPERTY");
                    snippet.SetCodelet("CONNECTORCLASSNAME", ConnectorClassName);
                    snippet.SetCodelet("SERVERNAMESPACE", AServerNamespace);
                    snippet.SetCodelet("TYPE", returnType);
                    snippet.SetCodelet("NAME", p.Name);

                    if (p.HasGetRegion)
                    {
                        snippet.SetCodelet("GETTER", "true");
                    }

                    if (p.HasSetRegion)
                    {
                        snippet.SetCodelet("SETTER", "true");
                    }

                    ATemplate.InsertSnippet("CONTENT", snippet);
                }
            }

            foreach (MethodDeclaration m in CSParser.GetMethods(t))
            {
                string MethodName = m.Name;

                if (TCollectConnectorInterfaces.IgnoreMethod(m.Attributes, m.Modifier))
                {
                    continue;
                }

                String formattedMethod = "";
                String returnType = AutoGenerationTools.TypeToString(m.TypeReference, AInterfaceNamespace);

                int align = (returnType + " " + m.Name).Length + 1;

                // this interface got implemented somewhere on the server
                formattedMethod = "/// <summary> auto generated from Connector method(" + AServerNamespace + "." + ConnectorClassName +
                                  ")</summary>" + Environment.NewLine;
                formattedMethod += returnType + " " + m.Name + "(";

                bool firstParameter = true;

                foreach (ParameterDeclarationExpression p in m.Parameters)
                {
                    if (!firstParameter)
                    {
                        ATemplate.AddToCodelet("CONTENT", formattedMethod + "," + Environment.NewLine);
                        formattedMethod = new String(' ', align);
                    }

                    firstParameter = false;
                    String parameterType = AutoGenerationTools.TypeToString(p.TypeReference, "");

                    if ((p.ParamModifier & ParameterModifiers.Ref) != 0)
                    {
                        formattedMethod += "ref ";
                    }
                    else if ((p.ParamModifier & ParameterModifiers.Out) != 0)
                    {
                        formattedMethod += "out ";
                    }

                    formattedMethod += parameterType + " " + p.ParameterName;
                }

                formattedMethod += ");";
                AMethodsAlreadyWritten.Add(MethodName);
                ATemplate.AddToCodelet("CONTENT", formattedMethod + Environment.NewLine);
            }
        }

        return true;
    }

    /// <summary>
    /// write the interfaces for the Connectors
    /// parses the connector files
    /// </summary>
    /// <param name="ATemplate">template that the code should be added to</param>
    /// <param name="AMethodsAlreadyWritten">a string list of method names that have been written</param>
    /// <param name="AConnectorClasses">all connector classes that implement the interface</param>
    /// <param name="AInterfaceName">the name of the interface we are writing to; it ends with ConnectorsNamespace</param>
    /// <param name="AInterfaceNamespace"></param>
    /// <param name="AServerNamespace">for the comment in the autogenerated code</param>
    /// <returns></returns>
    private bool WriteConnectorConstructors(
        ProcessTemplate ATemplate,
        ref StringCollection AMethodsAlreadyWritten,
        List <TypeDeclaration>AConnectorClasses, String AInterfaceName, String AInterfaceNamespace, String AServerNamespace)
    {
        string ServerNamespace = AInterfaceNamespace.Replace("Ict.Petra.Shared.Interfaces", "Ict.Petra.Server");

        foreach (TypeDeclaration t in AConnectorClasses)
        {
            string ConnectorClassName = t.Name;

            // cacheable will not work yet; careful: when building MethodName, connectorName does not have a plural s
            // but that cacheable constructor is not needed anyways???

            if (ConnectorClassName.StartsWith("T")
                && (ConnectorClassName.EndsWith("UIConnector")
                    || ConnectorClassName.EndsWith("LogicConnector")
                    || ConnectorClassName.EndsWith("Lookup")
                    || ConnectorClassName.EndsWith("Reader")))
            {
                // create a method for the interface, that returns the interface that the connector class is derived from,
                // and takes the parameters from the constructor of the connector class
                // it is named: remove first character T and trailing UIConnector/LogicConnector from the name of the connector class

                // get the connector name from the namespace
                StringCollection namespaceList = StringHelper.StrSplit(ServerNamespace, ".");

                // connectorName eg. UIConnectors, LogicConnectors, ServerLookups, Cacheable
                string connectorName = namespaceList[namespaceList.Count - 1];
                string MethodName = ConnectorClassName.Substring(1,
                    ConnectorClassName.Length - 1 - (connectorName.Length - 1));
                string MethodType = "";

                foreach (TypeReference ti in t.BaseTypes)
                {
                    // problem, eg. in MCommon, TOfficeSpecificDataLabelsUIConnector implements 2 interfaces
                    if ((ti.Type != "TConfigurableMBRObject")
                        && (ti.Type == AInterfaceName))
                    {
                        MethodType = ti.Type;
                    }
                }

                if (MethodType.Length == 0)
                {
                    // no valid interface has been derived; eg. Hospitality not finished yet
                    continue;
                }

                List <ConstructorDeclaration>constructors = CSParser.GetConstructors(t);

                if (constructors.Count == 0)
                {
                    // will cause compile error if the constructor is missing, because it is not implementing the interface completely
                    throw new Exception("missing a connector constructor in " + ServerNamespace + "." + ConnectorClassName);

//                    WriteLine("/// <summary>auto generated - there was no Connector constructor (" + ServerNamespace + "." + ConnectorClassName + ")</summary>");
//                    AMethodsAlreadyWritten.Add(MethodName);
//                    string MethodDeclaration = MethodType + " " + MethodName + "();";
//                    WriteLine(MethodDeclaration);
                }
                else
                {
                    // find constructor and copy the parameters
                    foreach (ConstructorDeclaration m in constructors)
                    {
                        ATemplate.AddToCodelet(
                            "CONTENT",
                            "/// <summary>auto generated from Connector constructor (" + ServerNamespace + "." + ConnectorClassName + ")</summary>" +
                            Environment.NewLine);
                        AMethodsAlreadyWritten.Add(MethodName);
                        string MethodDeclaration = MethodType + " " + MethodName + "(";
                        int align = MethodDeclaration.Length;
                        bool firstParameter = true;

                        foreach (ParameterDeclarationExpression p in m.Parameters)
                        {
                            AutoGenerationTools.AddParameter(ref MethodDeclaration,
                                ref firstParameter,
                                align,
                                p.ParameterName,
                                p.ParamModifier,
                                p.TypeReference.Type);
                        }

                        MethodDeclaration += ");";
                        ATemplate.AddToCodelet("CONTENT", MethodDeclaration + Environment.NewLine);
                    }
                }
            }
        }

        return true;
    }

    /// <summary>
    /// write the interfaces for the Connectors
    /// parses the instantiator files
    /// Although the instantiators are generated from the interfaces, they might contain ManualCode regions with specific functions
    /// </summary>
    /// <param name="ATemplate"></param>
    /// <param name="AMethodsAlreadyWritten"></param>
    /// <param name="AInstantiatorClasses">all instantiator classes that implement the interface</param>
    /// <param name="AInterfaceName"></param>
    /// <param name="AInterfaceNamespace"></param>
    /// <param name="AServerNamespace">for the comment in the autogenerated code</param>
    /// <returns></returns>
    private bool WriteInstantiatorMethods(
        ProcessTemplate ATemplate,
        StringCollection AMethodsAlreadyWritten,
        List <TypeDeclaration>AInstantiatorClasses, String AInterfaceName, String AInterfaceNamespace, String AServerNamespace)
    {
        foreach (TypeDeclaration t in AInstantiatorClasses)
        {
            // there should only be one class, eg. TSubscriptionsCacheableNamespace
            foreach (MethodDeclaration m in CSParser.GetMethods(t))
            {
                // copy all public methods that are not constructor, destructor, or InitializeLifetimeService
                // and that are not created yet
                if ((m.Name != "InitializeLifetimeService")
                    && ((m.Modifier & Modifiers.Public) != 0)
                    && !AMethodsAlreadyWritten.Contains(m.Name))
                {
                    ATemplate.AddToCodelet("CONTENT",
                        "/// <summary>auto generated from Instantiator (" + AServerNamespace + "." + t.Type + ")</summary>" + Environment.NewLine);
                    string MethodDeclaration = AutoGenerationTools.TypeToString(m.TypeReference, "") + " " + m.Name + "(";
                    int align = MethodDeclaration.Length;

                    bool firstParameter = true;

                    foreach (ParameterDeclarationExpression p in m.Parameters)
                    {
                        AutoGenerationTools.AddParameter(ref MethodDeclaration, ref firstParameter, align, p.ParameterName, p.ParamModifier,
                            AutoGenerationTools.TypeToString(p.TypeReference, ""));
                    }

                    MethodDeclaration += ");";
                    ATemplate.AddToCodelet("CONTENT", MethodDeclaration + Environment.NewLine);
                }
            }
        }

        return true;
    }

    void WriteInterface(
        ProcessTemplate AMainTemplate,
        String ParentNamespace,
        String ParentInterfaceName,
        string AInterfaceName,
        TNamespace tn,
        TNamespace sn,
        SortedList <string, TNamespace>children,
        SortedList InterfaceNames,
        List <CSParser>ACSFiles)
    {
        ProcessTemplate snippet = AMainTemplate.GetSnippet("INTERFACE");

        snippet.SetCodelet("INTERFACENAME", AInterfaceName);
        snippet.SetCodelet("CONTENT", string.Empty);
        snippet.SetCodelet("SUBNAMESPACES", string.Empty);

        foreach (TNamespace child in children.Values)
        {
            ProcessTemplate snippetSubNamespace = AMainTemplate.GetSnippet("SUBNAMESPACE");
            snippetSubNamespace.SetCodelet("SUBNAMESPACENAME", ParentInterfaceName + child.Name);
            snippetSubNamespace.SetCodelet("SUBNAMESPACEOBJECT", child.Name);
            snippet.InsertSnippet("SUBNAMESPACES", snippetSubNamespace);
        }

        //this should return the Connector classes; the instantiator classes are in a different namespace
        string ServerConnectorNamespace = ParentNamespace.Replace("Ict.Petra.Shared.Interfaces", "Ict.Petra.Server");

        // don't write methods twice, once from Connector, and then again from Instantiator
        StringCollection MethodsAlreadyWritten = new StringCollection();

        StringCollection InterfacesInNamespace = GetInterfacesInNamespace(ParentNamespace, InterfaceNames);

        foreach (string ChildInterface in InterfacesInNamespace)
        {
            List <TypeDeclaration>ConnectorClasses = GetClassesThatImplementInterface(
                ACSFiles,
                ChildInterface,
                ServerConnectorNamespace);

            if (AInterfaceName.EndsWith("Namespace"))
            {
                WriteConnectorConstructors(
                    snippet,
                    ref MethodsAlreadyWritten,
                    ConnectorClasses,
                    ChildInterface,
                    ParentNamespace,
                    ServerConnectorNamespace);
            }
        }

        List <TypeDeclaration>ConnectorClasses2 = GetClassesThatImplementInterface(
            ACSFiles,
            AInterfaceName,
            ServerConnectorNamespace);

        WriteConnectorMethods(
            snippet,
            ref MethodsAlreadyWritten,
            ConnectorClasses2,
            AInterfaceName,
            ParentNamespace,
            ServerConnectorNamespace);

        if (!ParentNamespace.Contains("WebConnector"))
        {
            // this is for the instantiator classes
            StringCollection NamespaceSplit = StringHelper.StrSplit(ParentNamespace, ".");

            // eg convert Ict.Petra.Shared.Interfaces.MPartner.Extracts.UIConnectors to Ict.Petra.Server.MPartner.Instantiator.Extracts.UIConnectors
            NamespaceSplit[2] = "Server";
            NamespaceSplit[3] = NamespaceSplit[4];
            NamespaceSplit[4] = "Instantiator";
            string ServerInstantiatorNamespace = StringHelper.StrMerge(NamespaceSplit, '.');
            List <TypeDeclaration>InstantiatorClasses = GetClassesThatImplementInterface(
                ACSFiles,
                AInterfaceName,
                ServerInstantiatorNamespace);

            WriteInstantiatorMethods(
                snippet,
                MethodsAlreadyWritten,
                InstantiatorClasses,
                AInterfaceName,
                ParentNamespace,
                ServerInstantiatorNamespace);
        }

        AMainTemplate.InsertSnippet("INTERFACES", snippet);
    }

    private StringCollection GetInterfacesInNamespace(string ANamespace, SortedList AInterfaceNames)
    {
        // get all the interfaces in the current namespace
        StringCollection InterfacesInNamespace = new StringCollection();

        foreach (String InterfaceName in AInterfaceNames.GetKeyList())
        {
            // see if the class that is implementing the interface is in the current namespace (considering the difference of Shared and Server)
            if ((AInterfaceNames[InterfaceName].ToString().Substring(0,
                     AInterfaceNames[InterfaceName].ToString().LastIndexOf(".")).Replace("Instantiator.", "")
                 == ANamespace.Replace("Ict.Petra.Shared.Interfaces", "Ict.Petra.Server"))

                /*&& (InterfaceName != "I" + ANamespace + "Namespace")*/)
            {
                InterfacesInNamespace.Add(InterfaceName);
            }
        }

        return InterfacesInNamespace;
    }

    /// <summary>
    /// write the namespace for an interface
    /// this includes all the interfaces in this namespace
    /// it calls itself recursively for sub namespaces
    /// </summary>
    private void WriteNamespace(
        ProcessTemplate AMainTemplate,
        String ParentNamespace,
        String ParentInterfaceName,
        TNamespace tn,
        TNamespace sn,
        SortedList <string, TNamespace>children,
        SortedList InterfaceNames,
        List <CSParser>ACSFiles)
    {
        WriteInterface(
            AMainTemplate,
            ParentNamespace,
            ParentInterfaceName,
            "I" + ParentInterfaceName + "Namespace",
            tn, sn, children, InterfaceNames, ACSFiles);

        StringCollection InterfacesInNamespace = GetInterfacesInNamespace(ParentNamespace, InterfaceNames);

        // has been written already; we want to keep the order of the interfaces this way
        InterfacesInNamespace.Remove("I" + ParentInterfaceName + "Namespace");

        foreach (String InterfaceName in InterfacesInNamespace)
        {
            WriteInterface(
                AMainTemplate,
                ParentNamespace,
                ParentInterfaceName,
                InterfaceName,
                tn, sn, children, InterfaceNames, ACSFiles);
        }

        foreach (TNamespace child in children.Values)
        {
            WriteNamespace(
                AMainTemplate,
                ParentNamespace + "." + child.Name,
                ParentInterfaceName + child.Name,
                tn,
                child,
                child.Children,
                InterfaceNames,
                ACSFiles);
        }
    }

    //other interfaces, e.g. IPartnerUIConnectorsPartnerEdit
    // we don't know the interfaces that are implemented, so need to look for the base classes
    // we need to know all the source files that are part of the UIConnector dll
    private void WriteNamespaces(ProcessTemplate AMainTemplate,
        TNamespace tn, SortedList AInterfaceNames, List <CSParser>ACSFiles)
    {
        AMainTemplate.SetCodelet("MODULE", tn.Name);

        foreach (TNamespace sn in tn.Children.Values)
        {
            ProcessTemplate snippet = AMainTemplate.GetSnippet("SUBNAMESPACE");
            snippet.SetCodelet("SUBNAMESPACENAME", sn.Name);
            snippet.SetCodelet("SUBNAMESPACEOBJECT", sn.Name);
            AMainTemplate.InsertSnippet("SUBNAMESPACES", snippet);
        }

        // parse Instantiator source code
        foreach (TNamespace sn in tn.Children.Values)
        {
            WriteNamespace(AMainTemplate,
                "Ict.Petra.Shared.Interfaces.M" + tn.Name + "." + sn.Name,
                sn.Name, tn, sn, sn.Children, AInterfaceNames, ACSFiles);
        }
    }

    /// <summary>
    /// add using namespaces, defined in the yml file in the interface directory
    /// </summary>
    public static string AddNamespacesFromYmlFile(String AOutputPath, string AModuleName)
    {
        TYml2Xml reader = new TYml2Xml(AOutputPath + Path.DirectorySeparatorChar + "InterfacesUsingNamespaces.yml");
        XmlDocument doc = reader.ParseYML2XML();

        XmlNode RootNode = doc.DocumentElement.FirstChild;

        StringCollection usingNamespaces = TYml2Xml.GetElements(RootNode, AModuleName);

        string result = string.Empty;

        foreach (string s in usingNamespaces)
        {
            result += "using " + s.Trim() + ";" + Environment.NewLine;
        }

        return result;
    }

    /// <summary>
    /// use CSParser to parse the Server files
    /// </summary>
    /// <param name="tn"></param>
    /// <param name="AOutputPath"></param>
    private void WriteInterfaces(TNamespace tn, String AOutputPath)
    {
        String OutputFile = AOutputPath + Path.DirectorySeparatorChar + tn.Name + ".Interfaces-generated.cs";

        // open file
        Console.WriteLine("working on file " + OutputFile);

        ProcessTemplate Template = new ProcessTemplate(FTemplateDir + Path.DirectorySeparatorChar +
            "ClientServerGlue" + Path.DirectorySeparatorChar +
            "Interface.cs");

        // load default header with license and copyright
        Template.SetCodelet("GPLFILEHEADER", ProcessTemplate.LoadEmptyFileComment(FTemplateDir));

        Template.AddToCodelet("USINGNAMESPACES", AddNamespacesFromYmlFile(AOutputPath, tn.Name));

        // get all csharp files that might hold implementations of remotable classes
        List <CSParser>CSFiles = null;

        if (Directory.Exists(CSParser.ICTPath + "/Petra/Server/lib/M" + tn.Name))
        {
            // any class in the module can contain a webconnector
            CSFiles = CSParser.GetCSFilesForDirectory(CSParser.ICTPath + "/Petra/Server/lib/M" + tn.Name,
                SearchOption.AllDirectories);
        }
        else
        {
            CSFiles = new List <CSParser>();
        }

        SortedList InterfaceNames = GetInterfaceNamesFromImplementation(CSFiles);

        WriteNamespaces(Template, tn, InterfaceNames, CSFiles);

        Template.FinishWriting(OutputFile, ".cs", true);
    }

    /// <summary>
    /// main function to create the interface files
    /// </summary>
    public void CreateFiles(TNamespace ANamespaces, String AOutputPath, String ATemplateDir)
    {
        FTemplateDir = ATemplateDir;

        foreach (TNamespace tn in ANamespaces.Children.Values)
        {
            string module = TAppSettingsManager.GetValue("module", "all");

            if ((module == "all") || (tn.Name == module))
            {
                WriteInterfaces(tn, AOutputPath);
            }
        }
    }
}
}