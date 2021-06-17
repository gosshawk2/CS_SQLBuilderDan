using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.OleDb;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CS_SQLBuilderDan
{
    class CS_SQLBuilderDAL
    {
        public DataTable MSSQL_GetODBCData(string ConString,string sqlStatement)
        {
            try
            {
                OdbcConnection cn = new OdbcConnection(ConString);
                cn.Open();
                OdbcCommand cm = cn.CreateCommand();
                cm.CommandTimeout = 0;
                cm.CommandType = CommandType.Text;
                cm.CommandText = sqlStatement;
                OdbcDataAdapter da = new OdbcDataAdapter(cm);
                DataSet ds = new DataSet();
                DataTable tempTable = null;

                da.Fill(ds);
                tempTable = ds.Tables[0];
                return tempTable;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public DataTable MSSQL_GetOLEData(string ConString, string sqlStatement)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(ConString);
                cn.Open();
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
                    tempTable = MSSQL_GetODBCData(Helper.conn("SQLODBC"), SqlStatement);
                }
                else if (Program.DBType.ToUpper() == "MSSQL_OLEDB")
                {
                    tempTable = MSSQL_GetOLEData(Helper.conn("SQLOLE"), SqlStatement);
                }
                else if (Program.DBType.ToUpper() == "MYSQL")
                {
                    //tempTable = MSSQL_GetOLEData(Helper.conn("MYSQL"), SqlStatement);
                }
                else if (Program.DBType.ToUpper() == "IBM")
                {
                    //tempTable = MSSQL_GetOLEData(Helper.conn("IBM"), SqlStatement);
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
            firstColumn.DataType = System.Type.GetType("System.Decimal");
            firstColumn.AllowDBNull = false;
            firstColumn.Caption = "Price";
            firstColumn.ColumnName = "Price";
            firstColumn.DefaultValue = 25;

            
            if (Header.TableName != "")
            {
                sqlWhere = " WHERE upper(Tablename) like '%" + Header.TableName.ToUpper() + "%' ";
            }

            if (Header.LibrayName!= "")
            {
                if (sqlWhere == "")
                {
                    sqlWhere = "WHERE ";
                }
                else
                {
                    sqlWhere += "And ";
                }
                sqlWhere += " upper(LibraryName) like '%" + Header.LibrayName.ToUpper() + "%' ";
               
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
                    tempTable = MSSQL_GetODBCData(Helper.conn("SQLODBC"), sqlStatement);
                }
                else if (Program.DBType.ToUpper() == "MSSQL_OLEDB")
                {
                    tempTable = MSSQL_GetOLEData(Helper.conn("SQLOLE"), sqlStatement);
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

            if (Detail.LibrayName != "")
            {
                if (sqlWhere == "")
                {
                    sqlWhere = "WHERE ";
                }
                else
                {
                    sqlWhere += "And ";
                }
                sqlWhere += " upper(LibraryName) like '%" + Detail.LibrayName.ToUpper() + "%' ";

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
            sqlStatement += " FROM [dbo].[tblTableDetails] " + sqlWhere;

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
                    tempTable = MSSQL_GetODBCData(Helper.conn("SQLODBC"), sqlStatement);
                }
                else if (Program.DBType.ToUpper() == "MSSQL_OLEDB")
                {
                    tempTable = MSSQL_GetOLEData(Helper.conn("SQLOLE"), sqlStatement);
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

        public string PrepareInsert_Header(HeaderList Header)
        {
            string sqlStatement = string.Empty;

            sqlStatement = "Insert into [dbo].[tblHeaderlist] (";
            sqlStatement += "DatasetName,";
            sqlStatement += "DatasetHeaderText,";
            sqlStatement += "DatabaseName,";
            sqlStatement += "TableName,";
            sqlStatement += "LibraryName,";
            sqlStatement += "DataSetType,";
            sqlStatement += "AuthorityFlag,";
            sqlStatement += "DataSetLevel,";
            sqlStatement += "Filelocation,";
            sqlStatement += "ImportedBy,";
            sqlStatement += "ImportDate,";
            sqlStatement += "ServerName,";
            sqlStatement += "ServerInstance,";
            sqlStatement += "ComputerName,";
            sqlStatement += "IPAddr4,";
            sqlStatement += "ChangedBy,";
            sqlStatement += "ChangeDate,";
            sqlStatement += "TotalRecords,";
            sqlStatement += "Status) ";
            sqlStatement += "Values (";
            sqlStatement += "'" + Header.DatasetName.ToUpper() + "',";
            sqlStatement += "'" + Header.DatasetHeaderText + "',";
            sqlStatement += "'" + Header.DatabaseName + "',";
            sqlStatement += "'" + Header.TableName + "',";
            sqlStatement += "'" + Header.LibrayName + "',";
            sqlStatement += "'" + Header.DatasetType.ToUpper() + "',";
            sqlStatement += "'" + Header.AuthorityFlag + "',";
            sqlStatement += "'" + Header.DatasetLevel + "',";
            sqlStatement += "'" + Header.FileLocation + "',";
            sqlStatement += "'" + Header.ImportedBy + "',";
            sqlStatement += "'" + Header.ImportDate + "',";
            sqlStatement += "'" + Header.ServerName + "',";
            sqlStatement += "'" + Header.ServerInstance + "',";
            sqlStatement += "'" + Header.ComputerName + "',";
            sqlStatement += "'" + Header.IPAddr4 + "',";
            sqlStatement += "'" + Header.ChangedBy + "',";
            sqlStatement += "'" + Header.ChangeDate + "',";
            sqlStatement += "'" + Header.TotalRecords + "',";
            sqlStatement += "'" + Header.Status + "')";

            return sqlStatement;
        }

        public string PrepareInsert_Detail(TableDetail Detail)
        {
            string sqlStatement = string.Empty;

            sqlStatement = "Insert into [dbo].[tblTableDetails] (";
            sqlStatement += "ColumnName,";
            sqlStatement += "ColumnText,";
            sqlStatement += "ServerName,";
            sqlStatement += "ServerInstance,";
            sqlStatement += "ComputerName,";
            sqlStatement += "IPAddr4,";
            sqlStatement += "DatabaseName,";
            sqlStatement += "TableName,";
            sqlStatement += "Sequence,";
            sqlStatement += "LibraryName,";
            sqlStatement += "ColumnType,";
            sqlStatement += "ColumnTypeInternal,";
            sqlStatement += "AuthorityFlag,";
            sqlStatement += "ColumnLength,";
            sqlStatement += "ColumnDecimals,";
            sqlStatement += "ColumnDecimalsDB,";
            sqlStatement += "ColumnAlias,";
            sqlStatement += "ColumnHeading,";
            sqlStatement += "ImportedBy,";
            sqlStatement += "ChangedBy,";
            sqlStatement += "ChangeDate,";
            sqlStatement += "CreateDate,";
            sqlStatement += "Status,";
            sqlStatement += "HeaderID) ";
            sqlStatement += "Values (";
            sqlStatement += "'" + Detail.ColumnName.ToUpper() + "',";
            sqlStatement += "'" + Detail.ColumnText + "',";
            sqlStatement += "'" + Detail.ServerName + "',";
            sqlStatement += "'" + Detail.ServerInstance + "',";
            sqlStatement += "'" + Detail.ComputerName + "',";
            sqlStatement += "'" + Detail.IPAddr4 + "',";
            sqlStatement += "'" + Detail.DatabaseName + "',";
            sqlStatement += "'" + Detail.TableName + "',";
            sqlStatement += "'" + Detail.Sequence + "',";
            sqlStatement += "'" + Detail.LibrayName + "',";
            sqlStatement += "'" + Detail.ColumnType + "',";
            sqlStatement += "'" + Detail.ColumnTypeInternal + "',";
            sqlStatement += "'" + Detail.AuthorityFlag + "',";
            sqlStatement += "'" + Detail.ColumnLength + "',";
            sqlStatement += "'" + Detail.ColumnDecimals + "',";
            sqlStatement += "'" + Detail.ColumnDecimalsDB + "',";
            sqlStatement += "'" + Detail.ColumnAlias + "',";
            sqlStatement += "'" + Detail.ColumnHeading + "',";
            sqlStatement += "'" + Detail.ImportedBy + "',";
            sqlStatement += "'" + Detail.ChangedBy + "',";
            sqlStatement += "'" + Detail.ChangeDate + "',";
            sqlStatement += "'" + Detail.CreateDate + "',";
            sqlStatement += "'" + Detail.Status + "',";
            sqlStatement += "'" + Detail.HeaderID + "')";

            return sqlStatement;
        }

        public string PrepareUpdate_Header(HeaderList Header)
        {
            string sqlStatement = string.Empty;

            sqlStatement = "Update [dbo].[tblHeaderlist] SET ";
            sqlStatement += "DatasetName='" + Header.DatasetName + "',";
            sqlStatement += "DatasetHeaderText='" + Header.DatasetHeaderText + "',";
            sqlStatement += "DatabaseName='" + Header.DatabaseName + "',";
            sqlStatement += "TableName='" + Header.TableName + "',";
            sqlStatement += "LibraryName='" + Header.LibrayName + "',";
            sqlStatement += "DataSetType='" + Header.DatasetType + "',";
            sqlStatement += "AuthorityFlag='" + Header.AuthorityFlag + "',";
            sqlStatement += "DataSetLevel='" + Header.DatasetLevel + "',";
            sqlStatement += "Filelocation='" + Header.FileLocation + "',";
            sqlStatement += "ImportedBy='" + Header.ImportedBy + "'";
            sqlStatement += "ImportDate='" + Header.ImportDate + "'";
            sqlStatement += "ServerName='" + Header.ServerName + "',";
            sqlStatement += "ServerInstance='" + Header.ServerInstance + "',";
            sqlStatement += "ComputerName='" + Header.ComputerName + "',";
            sqlStatement += "IPAddr4='" + Header.IPAddr4 + "',";
            sqlStatement += "ChangedBy='" + Header.ChangedBy + "',";
            sqlStatement += "ChangeDate='" + Header.ChangeDate + "',";
            sqlStatement += "TotalRecords='" + Header.TotalRecords + "',";
            sqlStatement += "Status='" + Header.Status + "',";
            sqlStatement += " WHERE DatasetID=" + Header.DatasetID;

            return sqlStatement;
        }

        public string PrepareUpdate_Detail(TableDetail Detail)
        {
            string sqlStatement = string.Empty;

            sqlStatement = "Update [dbo].[tblTableDetails] SET ";
            sqlStatement += "ColumnName='" + Detail.ColumnName + "',";
            sqlStatement += "ColumnText='" + Detail.ColumnText + "',";
            sqlStatement += "ServerName='" + Detail.ServerName + "',";
            sqlStatement += "ServerInstance='" + Detail.ServerName + "',";
            sqlStatement += "ComputerName='" + Detail.ComputerName + "',";
            sqlStatement += "IPAddr4='" + Detail.IPAddr4 + "',";
            sqlStatement += "DatabaseName='" + Detail.DatabaseName + "',";
            sqlStatement += "TableName='" + Detail.TableName + "',";
            sqlStatement += "Sequence='" + Detail.Sequence + "',";
            sqlStatement += "LibraryName='" + Detail.LibrayName + "',";
            sqlStatement += "ColumnType='" + Detail.ColumnType + "',";
            sqlStatement += "ColumnTypeInternal='" + Detail.ColumnTypeInternal + "',";
            sqlStatement += "AuthorityFlag='" + Detail.AuthorityFlag + "',";
            sqlStatement += "ColumnLength='" + Detail.ColumnLength + "',";
            sqlStatement += "ColumnDecimals='" + Detail.ColumnDecimals + "',";
            sqlStatement += "ColumnDecimalsDB='" + Detail.ColumnDecimalsDB + "',";
            sqlStatement += "ColumnAlias='" + Detail.ColumnAlias + "',";
            sqlStatement += "ColumnHeading='" + Detail.ColumnHeading + "',";
            sqlStatement += "ImportedBy='" + Detail.ImportedBy + "',";
            sqlStatement += "ChangedBy='" + Detail.ChangedBy + "',";
            sqlStatement += "ChangeDate='" + Detail.ChangedBy + "',";
            sqlStatement += "CreateDate='" + Detail.ChangedBy + "',";
            sqlStatement += "Status='" + Detail.Status + "',";
            sqlStatement += "HeaderID='" + Detail.HeaderID + "'";
            sqlStatement += " WHERE ColumnID=" + Detail.ColumnID;

            return sqlStatement;
        }

        public int UpdateHeader(HeaderList Header)
        {
            string sqlStatement = string.Empty;
            DataTable tempTable = null;

            if (Header.DatasetID > 0)
            {
                sqlStatement = PrepareUpdate_Header(Header);
            }
            else
            {
                sqlStatement = PrepareInsert_Header(Header);
            }
            
            try
            {
                if (Program.DBType.ToUpper() == "MSSQL_ODBC")
                {
                    tempTable = MSSQL_GetODBCData(Helper.conn("SQLODBC"), sqlStatement);
                }
                else if (Program.DBType.ToUpper() == "MSSQL_OLEDB")
                {
                    tempTable = MSSQL_GetOLEData(Helper.conn("SQLOLE"), sqlStatement);
                }
                else if (Program.DBType.ToUpper() == "MYSQL")
                {
                    //tempTable = MSSQL_GetOLEData(Helper.conn("MYSQL"), sqlStatement);
                }
                else if (Program.DBType.ToUpper() == "IBM")
                {
                    //tempTable = MSSQL_GetOLEData(Helper.conn("IBM"), sqlStatement);
                }
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return 0;
        }

        public int UpdateDetail(TableDetail Detail)
        {
            string sqlStatement = string.Empty;
            DataTable tempTable = null;

            if (Detail.ColumnID > 0)
            {
                sqlStatement = PrepareUpdate_Detail(Detail);
            }
            else
            {
                sqlStatement = PrepareInsert_Detail(Detail);
            }

            try
            {
                if (Program.DBType.ToUpper() == "MSSQL_ODBC")
                {
                    tempTable = MSSQL_GetODBCData(Helper.conn("SQLODBC"), sqlStatement);
                }
                else if (Program.DBType.ToUpper() == "MSSQL_OLEDB")
                {
                    tempTable = MSSQL_GetOLEData(Helper.conn("SQLOLE"), sqlStatement);
                }
                else if (Program.DBType.ToUpper() == "MYSQL")
                {
                    //tempTable = MSSQL_GetOLEData(Helper.conn("MYSQL"), sqlStatement);
                }
                else if (Program.DBType.ToUpper() == "IBM")
                {
                    //tempTable = MSSQL_GetOLEData(Helper.conn("IBM"), sqlStatement);
                }
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return 0;
        }
    }
}
