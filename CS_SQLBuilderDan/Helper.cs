using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace CS_SQLBuilderDan
{
    public static class Helper
    {
        public static string conn(string ConnName, string ServerName, string ServerInstance, string DBName)
        {
            string ODBCDriver = "{ODBC Driver 17 for SQL Server}";
            string FullServerName = ServerName;
            if (ServerInstance != string.Empty)
            {
                FullServerName = ServerName + "\\" + ServerInstance;
            }
            // string SQLOLECon = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SQLBuilderDG;Data Source=DESKTOP-F63E7OI";
            //string SQLOLECon = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SQLBuilderDG;Data Source=DESKTOP-FLF11K6";
            string SQLOLECon = $"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog={DBName};Data Source={FullServerName}";
            //string SQLODBCCon = "DRIVER={ODBC Driver 17 for SQL Server}; Server=desktop-flf11k6\\mssqlserverdev; Database=SQLBuilderDG;Trusted_Connection=yes;";
            string SQLODBCCon = $"Driver={ODBCDriver}; Server={FullServerName}; Database={DBName};Trusted_Connection=yes;";
            string ConString2 = "user id = username; password=password;server=serverurl;Trusted_Connection=yes;database=database;connection timeout=30";
            
            string MySQLCon = "";
            if (ConnName == "SQLOLE")
            {
                return SQLOLECon;
            }
            else if (ConnName == "SQLODBC")
            {
                return SQLODBCCon;
            }
            else if (ConnName == "MySQL")
            {
                return MySQLCon;
            }
            return null;
        }

    }
}
