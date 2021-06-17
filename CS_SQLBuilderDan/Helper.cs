using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace CS_SQLBuilderDan
{
    public static class Helper
    {
        public static string conn(string Name)
        {
            // string SQLOLECon = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SQLBuilderDG;Data Source=DESKTOP-F63E7OI";
            string SQLOLECon = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SQLBuilderDG;Data Source=DESKTOP-FLF11K6";
            string SQLODBCCon = "DRIVER={ODBC Driver 17 for SQL Server}; Server=desktop-flf11k6\\mssqlserverdev; Database=SQLBuilderDG;Trusted_Connection=yes;";
            string ConString2 = "user id = username; password=password;server=serverurl;Trusted_Connection=yes;database=database;connection timeout=30";
            string MySQLCon = "";
            if (Name == "SQLOLE")
            {
                return SQLOLECon;
            }
            else if (Name == "SQLODBC")
            {
                return SQLODBCCon;
            }
            else if (Name == "MySQL")
            {
                return MySQLCon;
            }
            return null;
        }

    }
}
