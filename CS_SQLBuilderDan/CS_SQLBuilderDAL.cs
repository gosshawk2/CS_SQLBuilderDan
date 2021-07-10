using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.Common;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CS_SQLBuilderDan
{
    class CS_SQLBuilderDAL
    {
        Dictionary<string, object> dicValues = new Dictionary<string, object>();
        Dictionary<string, bool> dicExcludeFields = new Dictionary<string, bool>();
        string fieldname = string.Empty;

        public void AddValues(bool ClearDic, string fieldname, object fieldvalue)
        {
            if (ClearDic == true)
            {
                dicValues.Clear();
            }
            dicValues.Add(fieldname, fieldvalue);
            //return dicValues;
        }

        public int AddExcludedFields(bool ClearDic, string fieldname, bool Excluded)
        {
            if (ClearDic == true)
            {
                dicExcludeFields.Clear();
            }
            dicExcludeFields.Add(fieldname, Excluded);
            return dicExcludeFields.Count;
        }


        public DataTable GetSQLServers()
        {
            DataTable dt = null;
            DbProviderFactory factory;
            factory = SqlClientFactory.Instance;
            if (factory.CanCreateDataSourceEnumerator)
            {
                DbDataSourceEnumerator Instances = factory.CreateDataSourceEnumerator();
                dt = Instances.GetDataSources();
            }
            return dt;
        }

        public string GetSQLInstances(string FindServerName)
        {
            string ServerInstance = string.Empty;
            string ServerName = string.Empty;
            string InstanceName = string.Empty;

            DbProviderFactory factory;
            factory = SqlClientFactory.Instance;
            if (factory.CanCreateDataSourceEnumerator)
            {
                DbDataSourceEnumerator Instances = factory.CreateDataSourceEnumerator();
                DataTable dt = Instances.GetDataSources();
                if (dt.Rows.Count > 0 )
                {
                    if (FindServerName != string.Empty)
                    {
                        // Perform Servername Search to retrieve the instance:
                        for (int i=0; i<dt.Rows.Count; i++)
                        {
                            ServerName = dt.Rows[i]["ServerName"].ToString();
                            InstanceName = dt.Rows[i]["InstanceName"].ToString();
                            if (ServerName == FindServerName)
                            {
                                ServerInstance = InstanceName;
                            }
                        }
                    }
                    else
                    {
                        //empty parameter passed - return first instance:
                        ServerInstance = dt.Rows[0]["InstanceName"].ToString();
                    }
                }
            }
            return ServerInstance;
        }

        public DataTable GetColumns(string Tablename)
        {
            string Conn = string.Empty;
            DataTable dt = null;

            if (Program.DBType.ToUpper() == "MSSQL_ODBC")
            {
                Conn = Helper.conn("SQLODBC", Program.CurrentServer, Program.CurrentServerInstance, Program.CurrentDBName);
                //Assume return tblHeaderlist here:
                dt = MSSQL_GetODBCData(true,Program.CurrentDBName,Tablename, Conn, "");
            }
            else if (Program.DBType.ToUpper() == "MSSQL_OLEDB")
            {
                Conn = Helper.conn("SQLOLE", Program.CurrentServer, Program.CurrentServerInstance, Program.CurrentDBName);
                dt = MSSQL_GetOLEData(true,"",Tablename, Conn, "");
            }
            /* using (SqlConnection conn = new SqlConnection(Conn))
            {
                string[] restrictions = new string[4] { null, null, "<TableName>", null };
                conn.Open();
                var columnList = conn.GetSchema("Columns", restrictions).AsEnumerable().Select(s => s.Field<String>("Column_Name")).ToList();
                return columnList;
            } */
            return dt;
        }

        public DataTable MSSQL_GetODBCData(bool ReturnSchema,string SchemaDB, string SchemaTable, string ConString,string sqlStatement)
        {
            OdbcConnection cn = new OdbcConnection(ConString);
            string MSDatabaseName = SchemaDB;
            string MSTableName = SchemaTable;
            DataTable tempTable = null;
            try
            {
                
                if (SchemaDB == string.Empty)
                {
                    MSDatabaseName = Program.SystemDatabase;
                }
                //string[] restrictions = new string[4] { null, null, "<TableName>", null };
                //var columnList = cn.GetSchema("Columns", restrictions).AsEnumerable().Select(s => s.Field<String>("Column_Name")).ToList();
                //return columnList;
                cn.Open();
                
                if (ReturnSchema == true)
                {
                    DataTable dt2 = cn.GetSchema("Columns", new[] { MSDatabaseName, null, MSTableName });
                    return dt2;
                }
                else
                {
                    OdbcCommand cm = cn.CreateCommand();
                    cm.CommandTimeout = 0;
                    cm.CommandType = CommandType.Text;
                    cm.CommandText = sqlStatement;
                    OdbcDataAdapter da = new OdbcDataAdapter(cm);
                    DataSet ds = new DataSet();

                    da.Fill(ds);
                    tempTable = ds.Tables[0];
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return tempTable;
        }

        public DataTable MSSQL_GetOLEData(bool ReturnSchema, string SchemaDB, string SchemaTable, string ConString, string sqlStatement)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(ConString);
                cn.Open();
                DataTable dt2 = cn.GetSchema("Columns");
                
                if (ReturnSchema == true)
                {
                    return dt2;
                }
                else
                {
                    OleDbCommand cm = cn.CreateCommand();
                    cm.CommandTimeout = 0;
                    cm.CommandType = CommandType.Text;
                    cm.CommandText = sqlStatement;
                    OleDbDataAdapter da = new OleDbDataAdapter(cm);
                    DataSet ds = new DataSet();
                    DataTable tempTable = null;

                    da.Fill(ds);
                    tempTable = ds.Tables[0];
                    return tempTable;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public DataTable GetData(string SqlStatement)
        {
            DataTable tempTable = null;

            try
            {
                if (Program.DBType.ToUpper() == "MSSQL_ODBC")
                {
                    tempTable = MSSQL_GetODBCData(false,null,null,Helper.conn("SQLODBC",Program.CurrentServer,Program.CurrentServerInstance,Program.CurrentDBName), SqlStatement);
                }
                else if (Program.DBType.ToUpper() == "MSSQL_OLEDB")
                {
                    tempTable = MSSQL_GetOLEData(false,null,null,Helper.conn("SQLOLE", Program.CurrentServer, Program.CurrentServerInstance, Program.CurrentDBName), SqlStatement);
                }
                else if (Program.DBType.ToUpper() == "MYSQL")
                {
                    //tempTable = MySQL_GetData(Helper.conn("MYSQL",Program.CurrentPort,Program.CurrentDBName), SqlStatement);
                }
                else if (Program.DBType.ToUpper() == "IBM")
                {
                    //tempTable = IBM_GetOLEData(Helper.conn("IBM",Program.CurrentServer,Program.CurrentDBName), SqlStatement);
                }
                return tempTable;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }

        public DataTable GetHeaderList(HeaderList Header)
        {
            string sqlWhere = string.Empty;
            string sqlStatement = string.Empty;
            DataTable tempTable = null;
            DataColumn firstColumn = new DataColumn();

            Program.CurrentServer = "";
            firstColumn.DataType = System.Type.GetType("System.Decimal");
            firstColumn.AllowDBNull = false;
            firstColumn.Caption = "Price";
            firstColumn.ColumnName = "Price";
            firstColumn.DefaultValue = 25;

            
            if (Header.TableName != "")
            {
                sqlWhere = " WHERE upper(Tablename) like '%" + Header.TableName.ToUpper() + "%' ";
            }

            if (Header.LibraryName!= "")
            {
                if (sqlWhere == "")
                {
                    sqlWhere = "WHERE ";
                }
                else
                {
                    sqlWhere += "And ";
                }
                sqlWhere += " upper(LibraryName) like '%" + Header.LibraryName.ToUpper() + "%' ";
               
            }

            if (Header.DatabaseName != "")
            {
                if (sqlWhere == "")
                {
                    sqlWhere = "WHERE ";
                }
                else
                {
                    sqlWhere += "And ";
                }
                sqlWhere += " upper(DatabaseName) like '%" + Header.DatabaseName.ToUpper() + "%' ";

            }

            if (Header.ServerName != "")
            {
                if (sqlWhere == "")
                {
                    sqlWhere = "WHERE ";
                }
                else
                {
                    sqlWhere += "And ";
                }
                //Exception thrown here : ServerName is null ???
                sqlWhere += " upper(ServerName) like '%" + Header.ServerName.ToUpper() + "%' ";

            }

            if (Header.ServerInstance != "")
            {
                if (sqlWhere == "")
                {
                    sqlWhere = "WHERE ";
                }
                else
                {
                    sqlWhere += " And ";
                }
                //Exception thrown here : ServerName is null ???
                sqlWhere += " upper(ServerInstance) like '%" + Header.ServerInstance.ToUpper() + "%' ";

            }

            if (Header.ComputerName != "")
            {
                if (sqlWhere == "")
                {
                    sqlWhere = "WHERE ";
                }
                else
                {
                    sqlWhere += "And ";
                }
                sqlWhere += " upper(ComputerName) like '%" + Header.ComputerName.ToUpper() + "%' ";

            }

            if (Header.DatasetName != "")
            {
                if (sqlWhere == "")
                {
                    sqlWhere = "WHERE ";
                }
                else
                {
                    sqlWhere += "And ";
                }
                sqlWhere += " upper(DataSetName) like '%" + Header.DatasetName.ToUpper() + "%' ";
            }

            if (Header.Description != "")
            {
                if (sqlWhere == "")
                {
                    sqlWhere = "WHERE ";
                }
                else
                {
                    sqlWhere += "And ";
                }
                sqlWhere += " upper(DataSetHeaderText) like '%" + Header.Description.ToUpper() + "%' ";
            }

            if (!Header.Tables)
            {
                if (sqlWhere == "")
                {
                    sqlWhere = "WHERE ";
                }
                else
                {
                    sqlWhere += "And ";
                }
                sqlWhere += " DataSetType != 'Table' ";
            }

            if (!Header.Views)
            {
                if (sqlWhere == "")
                {
                    sqlWhere = "WHERE ";
                }
                else
                {
                    sqlWhere += "And ";
                }
                sqlWhere += " DataSetType != 'View' ";
            }

            /* sqlStatement = "SELECT ";
            sqlStatement += "DatasetID,";
            sqlStatement += "trim(DatasetName) as " + $"{(char)34}"+ "DataSet Name" + $"{(char)34}" + ", ";
            sqlStatement += "trim(DataSetHeaderText) as " + $"{(char)34}" + "DataSet Header Text" + $"{(char)34}" + ", ";
            sqlStatement += "trim(DatabaseName) as " + $"{(char)34}" + "Database Name" + $"{(char)34}" + ", ";
            sqlStatement += "trim(Tablename) as " + $"{(char)34}" + "Tablename" + $"{(char)34}" + ", ";
            sqlStatement += "trim(LibraryName) as " + $"{(char)34}" + "Library" + $"{(char)34}" + ", ";
            sqlStatement += "trim(DataSetType) as " + $"{(char)34}" + "Type" + $"{(char)34}" + ", ";
            sqlStatement += "trim(AuthorityFlag) as " + $"{(char)34}" + "Authority Flag" + $"{(char)34}" + ", ";
            sqlStatement += "trim(DataSetLevel) as " + $"{(char)34}" + "Level" + $"{(char)34}" + ", ";
            sqlStatement += "trim(FileLocation) as " + $"{(char)34}" + "File Location" + $"{(char)34}" + ", ";
            sqlStatement += "trim(ImportedBy) as " + $"{(char)34}" + "Created By" + $"{(char)34}";
            sqlStatement += " FROM [dbo].[tblHeaderlist] " + sqlWhere;
            */
            sqlStatement = "SELECT * ";
            sqlStatement += " FROM [dbo].[tblHeaderlist] " + sqlWhere;

            if (Header.SortField.Length >0)
            {
                sqlStatement += " ORDER BY " + Header.SortField;
            }
            else
            {
                sqlStatement += " ORDER BY DatasetName";
            }

            try
            {
                if (Program.DBType.ToUpper() == "MSSQL_ODBC")
                {
                    tempTable = MSSQL_GetODBCData(false,null,null,Helper.conn("SQLODBC",Program.CurrentServer,Program.CurrentServerInstance,Program.CurrentDBName), sqlStatement);
                }
                else if (Program.DBType.ToUpper() == "MSSQL_OLEDB")
                {
                    tempTable = MSSQL_GetOLEData(false, null, null, Helper.conn("SQLOLE", Program.CurrentServer, Program.CurrentServerInstance, Program.CurrentDBName), sqlStatement);
                }
                else if (Program.DBType.ToUpper() == "MYSQL")
                {
                    //tempTable = MSSQL_GetOLEData(Helper.conn("MYSQL"), sqlStatement);
                }
                else if (Program.DBType.ToUpper() == "IBM")
                {
                    //tempTable = MSSQL_GetOLEData(Helper.conn("IBM"), sqlStatement);
                }
                return tempTable;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }

        public DataTable GetTableList(TableDetail Detail)
        {
            string sqlWhere = string.Empty;
            string sqlStatement = string.Empty;
            DataTable tempTable = null;

            if (Detail.TableName != "")
            {
                sqlWhere = " WHERE upper(Tablename) like '%" + Detail.TableName.ToUpper() + "%' ";
            }

            if (Detail.LibraryName != "")
            {
                if (sqlWhere == "")
                {
                    sqlWhere = "WHERE ";
                }
                else
                {
                    sqlWhere += "And ";
                }
                sqlWhere += " upper(LibraryName) like '%" + Detail.LibraryName.ToUpper() + "%' ";

            }

            if (Detail.DatabaseName != "")
            {
                if (sqlWhere == "")
                {
                    sqlWhere = "WHERE ";
                }
                else
                {
                    sqlWhere += "And ";
                }
                sqlWhere += " upper(DatabaseName) like '%" + Detail.DatabaseName.ToUpper() + "%' ";

            }

            if (Detail.ServerName != "")
            {
                if (sqlWhere == "")
                {
                    sqlWhere = "WHERE ";
                }
                else
                {
                    sqlWhere += "And ";
                }
                sqlWhere += " upper(ServerName) like '%" + Detail.ServerName.ToUpper() + "%' ";

            }

            if (Detail.ComputerName != "")
            {
                if (sqlWhere == "")
                {
                    sqlWhere = "WHERE ";
                }
                else
                {
                    sqlWhere += "And ";
                }
                sqlWhere += " upper(ComputerName) like '%" + Detail.ComputerName.ToUpper() + "%' ";

            }

            if (Detail.HeaderID > 0)
            {
                if (sqlWhere == "")
                {
                    sqlWhere = "WHERE ";
                }
                else
                {
                    sqlWhere += "And ";
                }
                sqlWhere += " HeaderID = " + Detail.HeaderID;

            }

            if (Detail.ColumnID > 0)
            {
                if (sqlWhere == "")
                {
                    sqlWhere = "WHERE ";
                }
                else
                {
                    sqlWhere += "And ";
                }
                sqlWhere += " ColumnID = " + Detail.ColumnID;

            }

            if (Detail.ColumnName != "")
            {
                if (sqlWhere == "")
                {
                    sqlWhere = "WHERE ";
                }
                else
                {
                    sqlWhere += "And ";
                }
                sqlWhere += " upper(ColumnName) like '%" + Detail.ColumnName.ToUpper() + "%' ";

            }

            if (Detail.ColumnText != "")
            {
                if (sqlWhere == "")
                {
                    sqlWhere = "WHERE ";
                }
                else
                {
                    sqlWhere += "And ";
                }
                sqlWhere += " upper(ColumnText) like '%" + Detail.ColumnText.ToUpper() + "%' ";

            }

            sqlStatement = "SELECT ";
            sqlStatement += "ColumnID, ";
            sqlStatement += "trim(ColumnName) as " + $"{(char)34}" + "Column Name" + $"{(char)34}" + ", ";
            sqlStatement += "trim(ColumnText) as " + $"{(char)34}" + "Column Text" + $"{(char)34}" + ", ";
            sqlStatement += "trim(ServerName) as " + $"{(char)34}" + "Server Name" + $"{(char)34}" + ", ";
            sqlStatement += "trim(ComputerName) as " + $"{(char)34}" + "Computer Name" + $"{(char)34}" + ", ";
            sqlStatement += "trim(IPAddr4) as " + $"{(char)34}" + "IP Address" + $"{(char)34}" + ", ";
            sqlStatement += "trim(DatabaseName) as " + $"{(char)34}" + "Database Name" + $"{(char)34}" + ", ";
            sqlStatement += "trim(Tablename) as " + $"{(char)34}" + "Tablename" + $"{(char)34}" + ", ";
            sqlStatement += "Sequence,";
            sqlStatement += "trim(Libraryname) as " + $"{(char)34}" + "Library" + $"{(char)34}" + ", ";
            sqlStatement += "trim(ColumnType) as " + $"{(char)34}" + "Column Type" + $"{(char)34}" + ", ";
            sqlStatement += "trim(ColumnTypeInternal) as " + $"{(char)34}" + "Column Type Internal" + $"{(char)34}" + ", ";
            sqlStatement += "trim(AuthorityFlag) as " + $"{(char)34}" + "Authority Flag" + $"{(char)34}" + ", ";
            sqlStatement += "ColumnLength,";
            sqlStatement += "ColumnDecimals,";
            sqlStatement += "ColumnDecimalsDB,";
            sqlStatement += "trim(ColumnAlias) as " + $"{(char)34}" + "Alias" + $"{(char)34}" + ", ";
            sqlStatement += "trim(ColumnHeading) as " + $"{(char)34}" + "Heading" + $"{(char)34}" + ", ";
            sqlStatement += "trim(ImportedBy) as " + $"{(char)34}" + "Created By" + $"{(char)34}";
            sqlStatement += "trim(ChangedBy) as " + $"{(char)34}" + "Changed By" + $"{(char)34}" + ", ";
            sqlStatement += "HeaderID";
            sqlStatement += " FROM [dbo].["+Program.SystemDetailTable+"] " + sqlWhere;

            if (Detail.SortField.Length > 0)
            {
                sqlStatement += " ORDER BY " + Detail.SortField;
            }
            else
            {
                sqlStatement += " ORDER BY ColumnText";
            }

            try
            {
                if (Program.DBType.ToUpper() == "MSSQL_ODBC")
                {
                    tempTable = MSSQL_GetODBCData(false, null, null, Helper.conn("SQLODBC", Program.CurrentServer, Program.CurrentServerInstance, Program.CurrentDBName), sqlStatement);
                }
                else if (Program.DBType.ToUpper() == "MSSQL_OLEDB")
                {
                    tempTable = MSSQL_GetOLEData(false, null, null, Helper.conn("SQLOLE", Program.CurrentServer, Program.CurrentServerInstance, Program.CurrentDBName), sqlStatement);
                }
                else if (Program.DBType.ToUpper() == "MYSQL")
                {
                    //tempTable = MSSQL_GetOLEData(Helper.conn("MYSQL"), sqlStatement);
                }
                else if (Program.DBType.ToUpper() == "IBM")
                {
                    //tempTable = MSSQL_GetOLEData(Helper.conn("IBM"), sqlStatement);
                }
                return tempTable;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }

        public string GetIdentColumn(string ServerName, string ServerInstance, string DBName, string TableName)
        {
            string ID_Field = string.Empty;
            DataTable dtSchema = null;

            try
            {
                if (Program.DBType.ToUpper() == "MSSQL_ODBC")
                {
                    dtSchema = MSSQL_GetODBCData(true, DBName, TableName, Helper.conn("SQLODBC", ServerName, ServerInstance, DBName), "");
                }
                else if (Program.DBType.ToUpper() == "MSSQL_OLEDB")
                {
                    dtSchema = MSSQL_GetOLEData(true, DBName, TableName, Helper.conn("SQLODBC", ServerName, ServerInstance, DBName), "");
                }
                else if (Program.DBType.ToUpper() == "MYSQL")
                {
                    //tempTable = MSSQL_GetOLEData(Helper.conn("MYSQL"), sqlStatement);
                }
                else if (Program.DBType.ToUpper() == "IBM")
                {
                    //tempTable = MSSQL_GetOLEData(Helper.conn("IBM"), sqlStatement);
                }
                for (int i = 0; i < dtSchema.Rows.Count; i++)
                {
                    string ColumnName = dtSchema.Rows[i]["COLUMN_NAME"].ToString();
                    if (dtSchema.Rows[i]["SS_IS_IDENTITY"].ToString() == "1")
                    {
                        ID_Field = ColumnName;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return ID_Field;
        }

        public int GetIDValue(bool LatestID, string ServerName, string ServerInstance, string DBName, string TableName, string ID_Field, string ConditionField, object ConditionValue)
        {
            int DatasetID = 0;
            string sqlStatement = string.Empty;
            string ColumnName = string.Empty;
            int ID_Value = 0;
            DataTable dtSchema = null;
            DataTable tempTable = null;
            DataTable dtIDENT = null;

            sqlStatement = "SELECT " + ID_Field + " FROM " + TableName;
            sqlStatement += " WHERE " + ConditionField + "= " + ConditionValue;
            try
            {
                if (Program.DBType.ToUpper() == "MSSQL_ODBC")
                {
                    //dtSchema = MSSQL_GetODBCData(true, null, null, Helper.conn("SQLODBC", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), sqlStatement);
                    dtIDENT = MSSQL_GetODBCData(false, null, null, Helper.conn("SQLODBC", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), "SELECT IDENT_CURRENT('" + TableName + "') AS IDENT");
                    tempTable = MSSQL_GetODBCData(false, null, null, Helper.conn("SQLODBC", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), sqlStatement);
                    
                }
                else if (Program.DBType.ToUpper() == "MSSQL_OLEDB")
                {
                    //dtSchema = MSSQL_GetOLEData(true, null, null, Helper.conn("SQLODBC", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), sqlStatement);
                    dtIDENT = MSSQL_GetOLEData(false, null, null, Helper.conn("SQLOLE", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), "SELECT IDENT_CURRENT('" + TableName + "') AS IDENT");
                    tempTable = MSSQL_GetOLEData(false, null, null, Helper.conn("SQLOLE", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), sqlStatement);
                }
                else if (Program.DBType.ToUpper() == "MYSQL")
                {
                    //tempTable = MSSQL_GetOLEData(Helper.conn("MYSQL"), sqlStatement);
                }
                else if (Program.DBType.ToUpper() == "IBM")
                {
                    //tempTable = MSSQL_GetOLEData(Helper.conn("IBM"), sqlStatement);
                }
                if (LatestID == false)
                {
                    ID_Value = Int32.Parse(tempTable.Rows[0][ID_Field].ToString());
                }
                else
                {
                    ID_Value = Int32.Parse(dtIDENT.Rows[0]["IDENT"].ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return ID_Value;
        }

        public int MSSQL_SaveODBCSystemData(string conn, string SqlStatement, string Tablename)
        {
            OdbcConnection cn = new OdbcConnection(conn);
            cn.Open();
            DataTable dtSchema = cn.GetSchema("Columns", new[] {Program.SystemDatabase ,null,Tablename });
            OdbcCommand cmd = new OdbcCommand(SqlStatement, cn);
            OdbcDataAdapter da = new OdbcDataAdapter();
            //DataTable dt2 = da.FillSchema(dtSchema, SchemaType.Mapped);
            //dt = MSSQL_GetODBCData(true, conn, "");
            //string[] fields = new string[dt.Rows.Count];
            //var fields = new List<string>();
            //Loop to add each parameter to cmd.Parameters.AddWithValue("@"+Fields[i],Values[i]);
            for (int i=1; i< dtSchema.Rows.Count-1; i++)
            {
                if (dtSchema.Rows[i]["TABLE_NAME"].ToString() == Tablename)
                {
                    fieldname = dtSchema.Rows[i]["COLUMN_NAME"].ToString();
                    if (dtSchema.Rows[i]["DATA_TYPE"].ToString() == "-9")
                    {
                        cmd.Parameters.Add("@" + fieldname, OdbcType.NVarChar).Value = dicValues[fieldname];
                    }
                    else if (dtSchema.Rows[i]["DATA_TYPE"].ToString() == "4")
                    {
                        cmd.Parameters.Add("@" + fieldname, OdbcType.Int).Value = dicValues[fieldname];
                    }
                    else if (dtSchema.Rows[i]["DATA_TYPE"].ToString() == "93")
                    {
                        cmd.Parameters.Add("@" + fieldname, OdbcType.DateTime).Value = dicValues[fieldname];
                    }
                    else if (dtSchema.Rows[i]["DATA_TYPE"].ToString() == "-8")
                    {
                        cmd.Parameters.Add("@" + fieldname, OdbcType.NChar).Value = dicValues[fieldname];
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@" + fieldname, dicValues[fieldname]);
                    }
                    
                    //fields.Add(fieldname);
                }
            } 

            int recs = cmd.ExecuteNonQuery();
            cn.Close();

            return recs;
        }

        public int MSSQL_SaveOLESystemData(string conn, string SqlStatement, string Tablename)
        {
            OleDbConnection cn = new OleDbConnection(conn);
            cn.Open();
            DataTable dtSchema = cn.GetSchema("Columns", new[] { Program.SystemDatabase, null, Tablename });
            OleDbCommand cmd = new OleDbCommand(SqlStatement, cn);
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataTable dt2 = da.FillSchema(dtSchema, SchemaType.Mapped);
            //var fields = new List<string>();
            //Loop to add each parameter to cmd.Parameters.AddWithValue("@"+Fields[i],Values[i]);
            for (int i = 1; i < dtSchema.Rows.Count; i++)
            {
                if (dtSchema.Rows[i]["TABLE_NAME"].ToString() == Tablename)
                {
                    fieldname = dtSchema.Rows[i]["COLUMN_NAME"].ToString();
                    if (dtSchema.Rows[i]["DATA_TYPE"].ToString() == "-9")
                    {
                        cmd.Parameters.Add("@" + fieldname, OleDbType.VarWChar).Value = dicValues[fieldname];
                    }
                    else if (dtSchema.Rows[i]["DATA_TYPE"].ToString() == "4")
                    {
                        cmd.Parameters.Add("@" + fieldname, OleDbType.Integer).Value = dicValues[fieldname];
                    }
                    else if (dtSchema.Rows[i]["DATA_TYPE"].ToString() == "93")
                    {
                        cmd.Parameters.Add("@" + fieldname, OleDbType.DBDate).Value = dicValues[fieldname];
                    }
                    else if (dtSchema.Rows[i]["DATA_TYPE"].ToString() == "-8")
                    {
                        cmd.Parameters.Add("@" + fieldname, OleDbType.VarWChar).Value = dicValues[fieldname];
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@" + fieldname, dicValues[fieldname]);
                    }

                    //fields.Add(fieldname);
                }
            }

            int recs = cmd.ExecuteNonQuery();
            cn.Close();

            return recs;
        }

        public string Prepare_Params_For_Insert(bool byName,DataTable dtSchema)
        {
            string SqlStatement = string.Empty;
            string ColumnName = string.Empty;
            string TableName = string.Empty;
            string Owner = string.Empty;
            string Symbol = "?";

            TableName = dtSchema.Rows[0]["TABLE_NAME"].ToString();
            Owner = dtSchema.Rows[0]["TABLE_SCHEM"].ToString();
            SqlStatement = "Insert into ["+Owner+"].["+TableName+"] (";
            for (int i=1; i< dtSchema.Rows.Count; i++ )
            {
                ColumnName = dtSchema.Rows[i]["COLUMN_NAME"].ToString();
                if (i== dtSchema.Rows.Count-1)
                {
                    SqlStatement += ColumnName + ") ";
                }
                else
                {
                    SqlStatement += ColumnName + ",";
                }
                
            }
            SqlStatement += " VALUES(";
            for (int i = 1; i < dtSchema.Rows.Count; i++)
            {
                ColumnName = dtSchema.Rows[i]["COLUMN_NAME"].ToString();
                if (byName == true)
                {
                    Symbol = "@"+ColumnName;
                }
                if (i == dtSchema.Rows.Count-1)
                {
                    SqlStatement += Symbol+")";
                }
                else
                {
                    SqlStatement += Symbol+",";
                }
            }
            return SqlStatement;
        }

        public string Prepare_Params_For_Update(bool byName, DataTable dtSchema, int IDValue)
        {
            string SqlStatement = string.Empty;
            string ColumnName = string.Empty;
            string TableName = string.Empty;
            string Owner = string.Empty;
            string Symbol = "?";
            bool IsIdentity = false;
            string IDColumn = string.Empty;

            TableName = dtSchema.Rows[0]["TABLE_NAME"].ToString();
            Owner = dtSchema.Rows[0]["TABLE_SCHEM"].ToString();
            SqlStatement = "UPDATE [" + Owner + "].[" + TableName + "] SET ";
            
            for (int i = 0; i < dtSchema.Rows.Count; i++)
            {
                ColumnName = dtSchema.Rows[i]["COLUMN_NAME"].ToString();
                IsIdentity = bool.Parse(dtSchema.Rows[i]["SS_IS_IDENTITY"].ToString());
                if (IsIdentity == false)
                {
                    IDColumn = ColumnName;
                }
                else
                {
                    if (dicExcludeFields[ColumnName] == false)
                    {
                        if (i == dtSchema.Rows.Count - 1)
                        {
                            SqlStatement += ColumnName + "= " + Symbol;
                        }
                        else
                        {
                            SqlStatement += ColumnName + "= " + Symbol + ",";
                        }
                    }
                    
                }
            }
            SqlStatement += " WHERE " + IDColumn + "=" +IDValue;
            return SqlStatement;
        }

        public string Prepare_Header_With_Parameters(int IDValue)
        {
            string SqlStatement = string.Empty;
            //get fieldnames using SELECT * FROM tablename or SCHEMA:
            try
            {
                if (Program.DBType.ToUpper() == "MSSQL_ODBC")
                {
                    //int recs = MSSQL_GetODBCData(Helper.conn("SQLODBC", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), sqlStatement, "tblHeaderlist");
                    //dt = MSSQL_GetODBCData(false, Helper.conn("SQLODBC", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), "SELECT IDENT_CURRENT(" + Header.TableName + ")");
                    //Get TABLE SCHEMA into a datatable:
                    DataTable dtODBCSchema = MSSQL_GetODBCData(true, Program.SystemDatabase,Program.SystemHeaderTable,Helper.conn("SQLODBC", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), "");
                    if (IDValue == 0)
                    {
                        SqlStatement = Prepare_Params_For_Insert(false, dtODBCSchema);
                    }
                    else
                    {
                        SqlStatement = Prepare_Params_For_Update(false, dtODBCSchema, IDValue);
                    }
                    
                }
                else if (Program.DBType.ToUpper() == "MSSQL_OLEDB")
                {
                    //tempTable = MSSQL_GetOLEData(false, Helper.conn("SQLOLE", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), sqlStatement);
                    //"SELECT IDENT_CURRENT(" + Header.TableName + ")"
                    DataTable dtOLESchema = MSSQL_GetOLEData(true, Program.SystemDatabase,Program.SystemHeaderTable,Helper.conn("SQLOLE", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), "");
                    if (IDValue == 0)
                    {
                        SqlStatement = Prepare_Params_For_Insert(false, dtOLESchema);
                    }
                    else
                    {
                        SqlStatement = Prepare_Params_For_Update(false, dtOLESchema,IDValue);
                    }
                }
                else if (Program.DBType.ToUpper() == "MYSQL")
                {
                    //Get MySQL SCHEMA:
                    //tempTable = MSSQL_GetOLEData(Helper.conn("MYSQL"), sqlStatement);
                }
                else if (Program.DBType.ToUpper() == "IBM")
                {
                    //Get IBM TABLE SCHEMA:
                    //tempTable = MSSQL_GetOLEData(Helper.conn("IBM"), sqlStatement);
                }
                // Return the new DatasetID after successful insertion:
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return SqlStatement;
        }

        public string Prepare_Detail_With_Parameters(int IDValue)
        {
            string SqlStatement = string.Empty;
            //get fieldnames using SELECT * FROM tablename or SCHEMA:
            try
            {
                if (Program.DBType.ToUpper() == "MSSQL_ODBC")
                {
                    //int recs = MSSQL_GetODBCData(Helper.conn("SQLODBC", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), sqlStatement, "tblHeaderlist");
                    //dt = MSSQL_GetODBCData(false, Helper.conn("SQLODBC", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), "SELECT IDENT_CURRENT(" + Header.TableName + ")");
                    //Get TABLE SCHEMA into a datatable:
                    DataTable dtODBCSchema = MSSQL_GetODBCData(true, Program.SystemDatabase, Program.SystemDetailTable, Helper.conn("SQLODBC", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), "");
                    if (IDValue == 0)
                    {
                        SqlStatement = Prepare_Params_For_Insert(false, dtODBCSchema);
                    }
                    else
                    {
                        SqlStatement = Prepare_Params_For_Update(false, dtODBCSchema, IDValue);
                    }

                }
                else if (Program.DBType.ToUpper() == "MSSQL_OLEDB")
                {
                    //tempTable = MSSQL_GetOLEData(false, Helper.conn("SQLOLE", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), sqlStatement);
                    //"SELECT IDENT_CURRENT(" + Header.TableName + ")"
                    DataTable dtOLESchema = MSSQL_GetOLEData(true, Program.SystemDatabase, Program.SystemHeaderTable, Helper.conn("SQLOLE", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), "");
                    if (IDValue == 0)
                    {
                        SqlStatement = Prepare_Params_For_Insert(false, dtOLESchema);
                    }
                    else
                    {
                        SqlStatement = Prepare_Params_For_Update(false, dtOLESchema, IDValue);
                    }
                }
                else if (Program.DBType.ToUpper() == "MYSQL")
                {
                    //Get MySQL SCHEMA:
                    //tempTable = MSSQL_GetOLEData(Helper.conn("MYSQL"), sqlStatement);
                }
                else if (Program.DBType.ToUpper() == "IBM")
                {
                    //Get IBM TABLE SCHEMA:
                    //tempTable = MSSQL_GetOLEData(Helper.conn("IBM"), sqlStatement);
                }
                // Return the new DatasetID after successful insertion:
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return SqlStatement;
        }

        public int Update_Header_With_Parameters(HeaderList Header)
        {
            string sqlStatement = string.Empty;
            DataTable tempTable = null;
            DataTable dt = null;
            int DatasetIDValue = Header.DatasetID;
            int recs = 0;
            int LastID = 0;

            AddValues(true, "DatasetID", Header.DatasetID);
            AddValues(false, "DatasetName", Header.DatasetName);
            AddValues(false, "DatasetHeaderText", Header.DatasetHeaderText);
            AddValues(false, "DatabaseName", Header.DatabaseName);
            AddValues(false, "Tablename", Header.TableName);
            AddValues(false, "LibraryName", Header.LibraryName);
            AddValues(false, "DatasetType", Header.DatasetType);
            AddValues(false, "AuthorityFlag", Header.AuthorityFlag);
            AddValues(false, "DatasetLevel", Header.DatasetLevel);
            AddValues(false, "FileLocation", Header.FileLocation);
            AddValues(false, "ImportedBy", Header.ImportedBy);
            string sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            AddValues(false, "ImportDate", Header.ImportDate.ToString("yyyy-MM-dd HH:mm:ss"));
            AddValues(false, "ServerName", Header.ServerName);
            AddValues(false, "ServerInstance", Header.ServerInstance);
            AddValues(false, "ComputerName", Header.ComputerName);
            AddValues(false, "IPAddr4", Header.IPAddr4);
            AddValues(false, "ChangedBy", Header.ChangedBy);
            AddValues(false, "ChangeDate", Header.ChangeDate.ToString("yyyy-MM-dd HH:mm:ss"));
            AddValues(false, "TotalRecords", Header.TotalRecords);
            AddValues(false, "Status", Header.Status);
            AddValues(false, "Port", Header.Port);

            sqlStatement = Prepare_Header_With_Parameters(DatasetIDValue);
            // Return the new DatasetID after successful insertion:
            try
            {
                if (Program.DBType.ToUpper() == "MSSQL_ODBC")
                {
                    recs = MSSQL_SaveODBCSystemData(Helper.conn("SQLODBC", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), sqlStatement,Program.SystemHeaderTable);
                    if (recs == 1)
                    {
                        dt = MSSQL_GetODBCData(false, null,null,Helper.conn("SQLODBC", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), "SELECT IDENT_CURRENT('" + Header.TableName + "') AS IDENT");
                        LastID = Int32.Parse(dt.Rows[0]["IDENT"].ToString());
                    }
                }
                else if (Program.DBType.ToUpper() == "MSSQL_OLEDB")
                {
                    recs = MSSQL_SaveOLESystemData(Helper.conn("SQLODBC", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), sqlStatement, Program.SystemHeaderTable);
                    if (recs == 1)
                    {
                        dt = MSSQL_GetOLEData(false, null, null, Helper.conn("SQLODBC", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), "SELECT IDENT_CURRENT('" + Header.TableName + "') AS IDENT");
                        LastID = Int32.Parse(dt.Rows[0]["IDENT"].ToString());
                    }
                    //dt = MSSQL_GetOLEData(false, null, null, Helper.conn("SQLOLE", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), "SELECT IDENT_CURRENT('" + Header.TableName + "') AS IDENT");
                }
                else if (Program.DBType.ToUpper() == "MYSQL")
                {
                    //tempTable = MSSQL_GetOLEData(Helper.conn("MYSQL"), sqlStatement);
                }
                else if (Program.DBType.ToUpper() == "IBM")
                {
                    //tempTable = MSSQL_GetOLEData(Helper.conn("IBM"), sqlStatement);
                }
                // Return the new DatasetID after successful insertion:
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return LastID;
        }

        public int Update_Detail_With_Parameters(TableDetail Detail)
        {
            //SAVES 1 record containing 1 Field and attributes in user selected table to SYSTEM TABLE:
            string sqlStatement = string.Empty;
            DataTable tempTable = null;
            DataTable dt = null;
            int recs = 0;
            int LastID = 0;
            string sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            AddValues(true, "ColumnID", Detail.ColumnID);
            AddValues(false, "ColumnName", Detail.ColumnName);
            AddValues(false, "ColumnText", Detail.ColumnText);
            AddValues(false, "ServerName", Detail.ServerName);
            AddValues(false, "ServerInstance", Detail.ServerInstance);
            AddValues(false, "ComputerName", Detail.ComputerName);
            AddValues(false, "IPAddr4", Detail.IPAddr4);
            AddValues(false, "DatabaseName", Detail.DatabaseName);
            AddValues(false, "TableName", Detail.TableName);
            AddValues(false, "Sequence", Detail.Sequence);
            AddValues(false, "LibraryName", Detail.LibraryName);
            AddValues(false, "ColumnType", Detail.ColumnName);
            AddValues(false, "ColumnTypeInternal", Detail.ColumnTypeInternal);
            AddValues(false, "AuthorityFlag", Detail.AuthorityFlag);
            AddValues(false, "ColumnLength", Detail.ColumnLength);
            AddValues(false, "ColumnDecimals", Detail.ColumnDecimals);
            AddValues(false, "ColumnDecimalsDB", Detail.ColumnDecimalsDB);
            AddValues(false, "ColumnAlias", Detail.ColumnAlias);
            AddValues(false, "ColumnHeading", Detail.ColumnHeading);
            AddValues(false, "ImportedBy", Detail.ImportedBy);
            AddValues(false, "ChangedBy", Detail.ChangedBy);
            AddValues(false, "ChangeDate", Detail.ChangeDate.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            AddValues(false, "CreateDate", Detail.CreateDate.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            AddValues(false, "Status", Detail.Status);
            //AddValues(false, "HeaderID", Detail.HeaderID);
            AddValues(false, "Port", Detail.Port);
            // So field values have now been inserted into the DAL.DicValues Dictionary
            // Return the new DatasetID after successful insertion:
            try
            {
                if (Program.DBType.ToUpper() == "MSSQL_ODBC")
                {
                    dt = MSSQL_GetODBCData(false,null,null,Helper.conn("SQLODBC", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), "SELECT IDENT_CURRENT('" +Program.SystemHeaderTable+ "') AS IDENT;");
                    Detail.HeaderID = Int32.Parse(dt.Rows[0]["IDENT"].ToString());
                    AddValues(false, "HeaderID", Detail.HeaderID);
                    sqlStatement = Prepare_Detail_With_Parameters(Detail.ColumnID);
                    recs = MSSQL_SaveODBCSystemData(Helper.conn("SQLODBC", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), sqlStatement, Program.SystemDetailTable);
                    if (recs == 1)
                    {
                        dt = MSSQL_GetODBCData(false, null, null, Helper.conn("SQLODBC", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), "SELECT IDENT_CURRENT('" + Program.SystemDetailTable + "') AS IDENT;");
                        LastID = Int32.Parse(dt.Rows[0]["IDENT"].ToString());
                    }
                }
                else if (Program.DBType.ToUpper() == "MSSQL_OLEDB")
                {
                    dt = MSSQL_GetOLEData(false, null, null, Helper.conn("SQLOLE", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), "SELECT IDENT_CURRENT('" + Program.SystemHeaderTable + "') AS IDENT;");
                    Detail.HeaderID = Int32.Parse(dt.Rows[0]["IDENT"].ToString());
                    AddValues(false, "HeaderID", Detail.HeaderID);
                    sqlStatement = Prepare_Detail_With_Parameters(Detail.ColumnID);
                    recs = MSSQL_SaveOLESystemData(Helper.conn("SQLODBC", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), sqlStatement, Program.SystemDetailTable);
                    if (recs == 1)
                    {
                        dt = MSSQL_GetOLEData(false, null, null, Helper.conn("SQLODBC", Program.SystemServer, Program.SystemServerInstance, Program.SystemDatabase), "SELECT IDENT_CURRENT('" + Program.SystemDetailTable + "') AS IDENT;");
                        LastID = Int32.Parse(dt.Rows[0]["IDENT"].ToString());
                    }
                }
                else if (Program.DBType.ToUpper() == "MYSQL")
                {
                    //tempTable = MSSQL_GetOLEData(Helper.conn("MYSQL"), sqlStatement);
                }
                else if (Program.DBType.ToUpper() == "IBM")
                {
                    //tempTable = MSSQL_GetOLEData(Helper.conn("IBM"), sqlStatement);
                }
                // Return the new DatasetID after successful insertion:
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return LastID;
        }
    }
}
