/* Auto generated with nant generateORM
 * Do not modify this file manually!
 */
{#GPLFILEHEADER}
namespace {#NAMESPACE}
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
    {#USINGNAMESPACES}

    {#TABLEACCESSLOOP}
}

{##TABLEACCESS}

{#TABLE_DESCRIPTION}
public class {#TABLENAME}Access : TTypedDataAccess
{

    /// CamelCase version of table name
    public const string DATATABLENAME = "{#TABLENAME}";

    /// original table name in database
    public const string DBTABLENAME = "{#SQLTABLENAME}";

    /// this method is called by all overloads
    public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
    {
        DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, {#TABLENAME}Table.TableId) + " FROM PUB_{#SQLTABLENAME}") +
                        GenerateOrderByClause(AOrderBy)), TTypedDataTable.GetTableName({#TABLENAME}Table.TableId), ATransaction, AStartRecord, AMaxRecords);
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
    public static void LoadAll(out {#TABLENAME}Table AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
    {
        AData = new {#TABLENAME}Table();
        DBAccess.GDBAccessObj.SelectDT(AData, GenerateSelectClause(AFieldList, {#TABLENAME}Table.TableId) + " FROM PUB_{#SQLTABLENAME}" + GenerateOrderByClause(AOrderBy), ATransaction, null, AStartRecord, AMaxRecords);
    }
    
    /// auto generated
    public static void LoadAll(out {#TABLENAME}Table AData, TDBTransaction ATransaction)
    {
        LoadAll(out AData, null, ATransaction, null, 0, 0);
    }
    
    /// auto generated
    public static void LoadAll(out {#TABLENAME}Table AData, StringCollection AFieldList, TDBTransaction ATransaction)
    {
        LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
    }
{#IFDEF FORMALPARAMETERSPRIMARYKEY}

    /// this method is called by all overloads
    public static void LoadByPrimaryKey(DataSet ADataSet, {#FORMALPARAMETERSPRIMARYKEY}, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
    {
        LoadByPrimaryKey({#TABLENAME}Table.TableId, ADataSet, new System.Object[{#PRIMARYKEYNUMBERCOLUMNS}]{{#ACTUALPARAMETERSPRIMARYKEY}}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
    }

    /// auto generated
    public static void LoadByPrimaryKey(DataSet AData, {#FORMALPARAMETERSPRIMARYKEY}, TDBTransaction ATransaction)
    {
        LoadByPrimaryKey(AData, {#ACTUALPARAMETERSPRIMARYKEY}, null, ATransaction, null, 0, 0);
    }
    
    /// auto generated
    public static void LoadByPrimaryKey(DataSet AData, {#FORMALPARAMETERSPRIMARYKEY}, StringCollection AFieldList, TDBTransaction ATransaction)
    {
        LoadByPrimaryKey(AData, {#ACTUALPARAMETERSPRIMARYKEY}, AFieldList, ATransaction, null, 0, 0);
    }

    /// auto generated
    public static void LoadByPrimaryKey(out {#TABLENAME}Table AData, {#FORMALPARAMETERSPRIMARYKEY}, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
    {
        AData = new {#TABLENAME}Table();
        LoadByPrimaryKey({#TABLENAME}Table.TableId, AData, new System.Object[{#PRIMARYKEYNUMBERCOLUMNS}]{{#ACTUALPARAMETERSPRIMARYKEY}}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
    }
    
    /// auto generated
    public static void LoadByPrimaryKey(out {#TABLENAME}Table AData, {#FORMALPARAMETERSPRIMARYKEY}, TDBTransaction ATransaction)
    {
        LoadByPrimaryKey(out AData, {#ACTUALPARAMETERSPRIMARYKEY}, null, ATransaction, null, 0, 0);
    }
    
    /// auto generated
    public static void LoadByPrimaryKey(out {#TABLENAME}Table AData, {#FORMALPARAMETERSPRIMARYKEY}, StringCollection AFieldList, TDBTransaction ATransaction)
    {
        LoadByPrimaryKey(out AData, {#ACTUALPARAMETERSPRIMARYKEY}, AFieldList, ATransaction, null, 0, 0);
    }
{#ENDIF FORMALPARAMETERSPRIMARYKEY}

    /// this method is called by all overloads
    public static void LoadUsingTemplate(DataSet ADataSet, {#TABLENAME}Row ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
    {
        LoadUsingTemplate({#TABLENAME}Table.TableId, ADataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
    }
    
    /// auto generated
    public static void LoadUsingTemplate(DataSet AData, {#TABLENAME}Row ATemplateRow, TDBTransaction ATransaction)
    {
        LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
    }
    
    /// auto generated
    public static void LoadUsingTemplate(DataSet AData, {#TABLENAME}Row ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
    {
        LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
    }
    
    /// auto generated
    public static void LoadUsingTemplate(out {#TABLENAME}Table AData, {#TABLENAME}Row ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
    {
        AData = new {#TABLENAME}Table();
        LoadUsingTemplate({#TABLENAME}Table.TableId, AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
    }
    
    /// auto generated
    public static void LoadUsingTemplate(out {#TABLENAME}Table AData, {#TABLENAME}Row ATemplateRow, TDBTransaction ATransaction)
    {
        LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
    }
    
    /// auto generated
    public static void LoadUsingTemplate(out {#TABLENAME}Table AData, {#TABLENAME}Row ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
    {
        LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
    }
    
    /// auto generated
    public static void LoadUsingTemplate(out {#TABLENAME}Table AData, {#TABLENAME}Row ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
    {
        LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
    }

    /// this method is called by all overloads
    public static void LoadUsingTemplate(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
    {
        LoadUsingTemplate({#TABLENAME}Table.TableId, ADataSet, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
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
    public static void LoadUsingTemplate(out {#TABLENAME}Table AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
    {
        AData = new {#TABLENAME}Table();
        LoadUsingTemplate({#TABLENAME}Table.TableId, AData, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
    }
    
    /// auto generated
    public static void LoadUsingTemplate(out {#TABLENAME}Table AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
    {
        LoadUsingTemplate(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
    }

    /// auto generated
    public static void LoadUsingTemplate(out {#TABLENAME}Table AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
    {
        LoadUsingTemplate(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
    }

    /// this method is called by all overloads
    public static int CountAll(TDBTransaction ATransaction)
    {
        return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_{#SQLTABLENAME}", ATransaction, false));
    }
{#IFDEF FORMALPARAMETERSPRIMARYKEY}

    /// check if a row exists by using the primary key
    public static bool Exists({#FORMALPARAMETERSPRIMARYKEY}, TDBTransaction ATransaction)
    {
        return Exists({#TABLENAME}Table.TableId, new System.Object[{#PRIMARYKEYNUMBERCOLUMNS}]{{#ACTUALPARAMETERSPRIMARYKEY}}, ATransaction);
    }
{#ENDIF FORMALPARAMETERSPRIMARYKEY}

    /// this method is called by all overloads
    public static int CountUsingTemplate({#TABLENAME}Row ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
    {
        return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_{#SQLTABLENAME}" + GenerateWhereClause(TTypedDataTable.GetColumnStringList({#TABLENAME}Table.TableId), ATemplateRow, ATemplateOperators)), ATransaction, false, 
               GetParametersForWhereClause({#TABLENAME}Table.TableId, ATemplateRow)));
    }

    /// this method is called by all overloads
    public static int CountUsingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
    {
        return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_{#SQLTABLENAME}" + GenerateWhereClause(TTypedDataTable.GetColumnStringList({#TABLENAME}Table.TableId), ASearchCriteria)), ATransaction, false, 
        GetParametersForWhereClause({#TABLENAME}Table.TableId, ASearchCriteria)));
    }
    {#VIAOTHERTABLE}
    {#VIALINKTABLE}

{#IFDEF FORMALPARAMETERSPRIMARYKEY}

    /// auto generated
    public static void DeleteByPrimaryKey({#FORMALPARAMETERSPRIMARYKEY}, TDBTransaction ATransaction)
    {
        DeleteByPrimaryKey({#TABLENAME}Table.TableId, new System.Object[{#PRIMARYKEYNUMBERCOLUMNS}]{{#ACTUALPARAMETERSPRIMARYKEY}}, ATransaction);
    }
{#ENDIF FORMALPARAMETERSPRIMARYKEY}
    
    /// auto generated
    public static void DeleteUsingTemplate({#TABLENAME}Row ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
    {
        DeleteUsingTemplate({#TABLENAME}Table.TableId, ATemplateRow, ATemplateOperators, ATransaction);
    }

    /// auto generated
    public static void DeleteUsingTemplate(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
    {
        DeleteUsingTemplate({#TABLENAME}Table.TableId, ASearchCriteria, ATransaction);
    }
    
    /// auto generated
    public static bool SubmitChanges({#TABLENAME}Table ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
    {
        return SubmitChanges({#TABLENAME}Table.TableId, ATable, ATransaction, out AVerificationResult, UserInfo.GUserInfo.UserID{#SEQUENCENAMEANDFIELD});
    }
}

{##VIAOTHERTABLE}

/// auto generated
public static void Load{#VIAPROCEDURENAME}(DataSet ADataSet, {#FORMALPARAMETERSOTHERPRIMARYKEY}, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
{
    LoadViaForeignKey({#TABLENAME}Table.TableId, {#OTHERTABLENAME}Table.TableId, ADataSet, new string[{#NUMBERFIELDS}]{{#THISTABLEFIELDS}},
        new System.Object[{#NUMBERFIELDS}]{{#ACTUALPARAMETERSOTHERPRIMARYKEY}}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}(DataSet AData, {#FORMALPARAMETERSOTHERPRIMARYKEY}, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}(AData, {#ACTUALPARAMETERSOTHERPRIMARYKEY}, null, ATransaction, null, 0, 0);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}(DataSet AData, {#FORMALPARAMETERSOTHERPRIMARYKEY}, StringCollection AFieldList, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}(AData, {#ACTUALPARAMETERSOTHERPRIMARYKEY}, AFieldList, ATransaction, null, 0, 0);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}(out {#TABLENAME}Table AData, {#FORMALPARAMETERSOTHERPRIMARYKEY}, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
{
    AData = new {#TABLENAME}Table();
    LoadViaForeignKey({#TABLENAME}Table.TableId, {#OTHERTABLENAME}Table.TableId, AData, new string[{#NUMBERFIELDS}]{{#THISTABLEFIELDS}},
        new System.Object[{#NUMBERFIELDS}]{{#ACTUALPARAMETERSOTHERPRIMARYKEY}}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}(out {#TABLENAME}Table AData, {#FORMALPARAMETERSOTHERPRIMARYKEY}, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}(out AData, {#ACTUALPARAMETERSOTHERPRIMARYKEY}, null, ATransaction, null, 0, 0);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}(out {#TABLENAME}Table AData, {#FORMALPARAMETERSOTHERPRIMARYKEY}, StringCollection AFieldList, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}(out AData, {#ACTUALPARAMETERSOTHERPRIMARYKEY}, AFieldList, ATransaction, null, 0, 0);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(DataSet ADataSet, {#OTHERTABLENAME}Row ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
{
    LoadViaForeignKey({#TABLENAME}Table.TableId, {#OTHERTABLENAME}Table.TableId, ADataSet, new string[{#NUMBERFIELDS}]{{#THISTABLEFIELDS}},
        ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(DataSet AData, {#OTHERTABLENAME}Row ATemplateRow, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}Template(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(DataSet AData, {#OTHERTABLENAME}Row ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}Template(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(out {#TABLENAME}Table AData, {#OTHERTABLENAME}Row ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
{
    AData = new {#TABLENAME}Table();
    LoadViaForeignKey({#TABLENAME}Table.TableId, {#OTHERTABLENAME}Table.TableId, AData, new string[{#NUMBERFIELDS}]{{#THISTABLEFIELDS}},
        ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(out {#TABLENAME}Table AData, {#OTHERTABLENAME}Row ATemplateRow, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}Template(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(out {#TABLENAME}Table AData, {#OTHERTABLENAME}Row ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}Template(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(out {#TABLENAME}Table AData, {#OTHERTABLENAME}Row ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}Template(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
{
    LoadViaForeignKey({#TABLENAME}Table.TableId, {#OTHERTABLENAME}Table.TableId, ADataSet, new string[{#NUMBERFIELDS}]{{#THISTABLEFIELDS}},
        ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}Template(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}Template(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(out {#TABLENAME}Table AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
{
    AData = new {#TABLENAME}Table();
    LoadViaForeignKey({#TABLENAME}Table.TableId, {#OTHERTABLENAME}Table.TableId, AData, new string[{#NUMBERFIELDS}]{{#THISTABLEFIELDS}},
        ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(out {#TABLENAME}Table AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}Template(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(out {#TABLENAME}Table AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}Template(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
}

/// auto generated
public static int Count{#VIAPROCEDURENAME}({#FORMALPARAMETERSOTHERPRIMARYKEY}, TDBTransaction ATransaction)
{
    return CountViaForeignKey({#TABLENAME}Table.TableId, {#OTHERTABLENAME}Table.TableId, new string[{#NUMBERFIELDS}]{{#THISTABLEFIELDS}}, 
        new System.Object[{#NUMBERFIELDS}]{{#ACTUALPARAMETERSOTHERPRIMARYKEY}}, ATransaction);
}

/// auto generated
public static int Count{#VIAPROCEDURENAME}Template({#OTHERTABLENAME}Row ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
{
    return CountViaForeignKey({#TABLENAME}Table.TableId, {#OTHERTABLENAME}Table.TableId, new string[{#NUMBERFIELDS}]{{#THISTABLEFIELDS}}, 
        ATemplateRow, ATemplateOperators, ATransaction);
}

/// auto generated
public static int Count{#VIAPROCEDURENAME}Template(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
{
    return CountViaForeignKey({#TABLENAME}Table.TableId, {#OTHERTABLENAME}Table.TableId, new string[{#NUMBERFIELDS}]{{#THISTABLEFIELDS}}, 
        ASearchCriteria, ATransaction);
}

{##VIALINKTABLE}

/// auto generated LoadViaLinkTable
public static void Load{#VIAPROCEDURENAME}(DataSet ADataSet, {#FORMALPARAMETERSOTHERPRIMARYKEY}, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
{
    {#ODBCPARAMETERSFOREIGNKEY}
    DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClauseLong("PUB_{#SQLTABLENAME}", AFieldList, {#TABLENAME}Table.TableId) + 
                    " FROM PUB_{#SQLTABLENAME}, PUB_{#SQLLINKTABLENAME} WHERE " + 
                    "{#WHERECLAUSEVIALINKTABLE}") +
                    GenerateOrderByClause(AOrderBy)), TTypedDataTable.GetTableName({#TABLENAME}Table.TableId), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}(DataSet AData, {#FORMALPARAMETERSOTHERPRIMARYKEY}, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}(AData, {#ACTUALPARAMETERSOTHERPRIMARYKEY}, null, ATransaction, null, 0, 0);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}(DataSet AData, {#FORMALPARAMETERSOTHERPRIMARYKEY}, StringCollection AFieldList, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}(AData, {#ACTUALPARAMETERSOTHERPRIMARYKEY}, AFieldList, ATransaction, null, 0, 0);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}(out {#TABLENAME}Table AData, {#FORMALPARAMETERSOTHERPRIMARYKEY}, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
{
    DataSet FillDataSet = new DataSet();
    AData = new {#TABLENAME}Table();
    FillDataSet.Tables.Add(AData);
    Load{#VIAPROCEDURENAME}(FillDataSet, {#ACTUALPARAMETERSOTHERPRIMARYKEY}, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
    FillDataSet.Tables.Remove(AData);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}(out {#TABLENAME}Table AData, {#FORMALPARAMETERSOTHERPRIMARYKEY}, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}(out AData, {#ACTUALPARAMETERSOTHERPRIMARYKEY}, null, ATransaction, null, 0, 0);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}(out {#TABLENAME}Table AData, {#FORMALPARAMETERSOTHERPRIMARYKEY}, StringCollection AFieldList, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}(out AData, {#ACTUALPARAMETERSOTHERPRIMARYKEY}, AFieldList, ATransaction, null, 0, 0);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(DataSet ADataSet, {#OTHERTABLENAME}Row ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
{
    DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_{#SQLTABLENAME}", AFieldList, {#TABLENAME}Table.TableId) + 
                    " FROM PUB_{#SQLTABLENAME}, PUB_{#SQLLINKTABLENAME}, PUB_{#SQLOTHERTABLENAME} WHERE " +
                    "{#WHERECLAUSEALLVIATABLES}") +
                    GenerateWhereClauseLong("PUB_{#SQLOTHERTABLENAME}", {#OTHERTABLENAME}Table.TableId, ATemplateRow, ATemplateOperators)) +
                    GenerateOrderByClause(AOrderBy)), TTypedDataTable.GetTableName({#TABLENAME}Table.TableId), ATransaction, 
                    GetParametersForWhereClause({#OTHERTABLENAME}Table.TableId, ATemplateRow), AStartRecord, AMaxRecords);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(DataSet AData, {#OTHERTABLENAME}Row ATemplateRow, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}Template(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(DataSet AData, {#OTHERTABLENAME}Row ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}Template(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(out {#TABLENAME}Table AData, {#OTHERTABLENAME}Row ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
{
    DataSet FillDataSet = new DataSet();
    AData = new {#TABLENAME}Table();
    FillDataSet.Tables.Add(AData);
    Load{#VIAPROCEDURENAME}Template(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
    FillDataSet.Tables.Remove(AData);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(out {#TABLENAME}Table AData, {#OTHERTABLENAME}Row ATemplateRow, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}Template(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(out {#TABLENAME}Table AData, {#OTHERTABLENAME}Row ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}Template(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(out {#TABLENAME}Table AData, {#OTHERTABLENAME}Row ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}Template(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(DataSet ADataSet, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
{
    DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_{#SQLTABLENAME}", AFieldList, {#TABLENAME}Table.TableId) + 
                    " FROM PUB_{#SQLTABLENAME}, PUB_{#SQLLINKTABLENAME}, PUB_{#SQLOTHERTABLENAME} WHERE " +
                    "{#WHERECLAUSEALLVIATABLES}") +
                    GenerateWhereClauseLong("PUB_{#SQLOTHERTABLENAME}", ASearchCriteria)) +
                    GenerateOrderByClause(AOrderBy)), TTypedDataTable.GetTableName({#TABLENAME}Table.TableId), ATransaction, 
                    GetParametersForWhereClause({#TABLENAME}Table.TableId, ASearchCriteria), AStartRecord, AMaxRecords);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(DataSet AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}Template(AData, ASearchCriteria, null, ATransaction, null, 0, 0);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(DataSet AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}Template(AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(out {#TABLENAME}Table AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
{
    DataSet FillDataSet = new DataSet();
    AData = new {#TABLENAME}Table();
    FillDataSet.Tables.Add(AData);
    Load{#VIAPROCEDURENAME}Template(FillDataSet, ASearchCriteria, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
    FillDataSet.Tables.Remove(AData);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(out {#TABLENAME}Table AData, TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}Template(out AData, ASearchCriteria, null, ATransaction, null, 0, 0);
}

/// auto generated
public static void Load{#VIAPROCEDURENAME}Template(out {#TABLENAME}Table AData, TSearchCriteria[] ASearchCriteria, StringCollection AFieldList, TDBTransaction ATransaction)
{
    Load{#VIAPROCEDURENAME}Template(out AData, ASearchCriteria, AFieldList, ATransaction, null, 0, 0);
}

/// auto generated CountViaLinkTable
public static int Count{#VIAPROCEDURENAME}({#FORMALPARAMETERSOTHERPRIMARYKEY}, TDBTransaction ATransaction)
{
    {#ODBCPARAMETERSFOREIGNKEY}
    return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_{#SQLTABLENAME}, PUB_{#SQLLINKTABLENAME} WHERE " +
                "{#WHERECLAUSEVIALINKTABLE}",
                ATransaction, false, ParametersArray));
}

/// auto generated
public static int Count{#VIAPROCEDURENAME}Template({#OTHERTABLENAME}Row ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
{
    return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_{#SQLTABLENAME}, PUB_{#SQLLINKTABLENAME}, PUB_{#SQLOTHERTABLENAME} WHERE " +
                "{#WHERECLAUSEALLVIATABLES}" +
                GenerateWhereClauseLong("PUB_{#SQLLINKTABLENAME}", {#TABLENAME}Table.TableId, ATemplateRow, ATemplateOperators)), ATransaction, false, 
                GetParametersForWhereClauseWithPrimaryKey({#OTHERTABLENAME}Table.TableId, ATemplateRow)));
}

/// auto generated
public static int Count{#VIAPROCEDURENAME}Template(TSearchCriteria[] ASearchCriteria, TDBTransaction ATransaction)
{
    return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_{#SQLTABLENAME}, PUB_{#SQLLINKTABLENAME}, PUB_{#SQLOTHERTABLENAME} WHERE " +
                "{#WHERECLAUSEALLVIATABLES}" +
                GenerateWhereClauseLong("PUB_{#SQLLINKTABLENAME}", ASearchCriteria)), ATransaction, false, 
                GetParametersForWhereClause({#TABLENAME}Table.TableId, ASearchCriteria)));
}