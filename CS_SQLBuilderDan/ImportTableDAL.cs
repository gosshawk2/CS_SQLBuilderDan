using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;

namespace SQLBuilderDG
{
    class ImportTableDAL
    {
        public DataTable GetHeaderList(
             String ConnectString,
             String Tablename  ,
              int DatasetID  ,
             String UserID  ,
             String DataSet  ,
             String DatasetHeaderText ,
             String LibraryName ,
             String ApplicationCode ,
             Boolean Tables  ,
             Boolean Views)
        {
            string ConString = "user id = username; " + 
                                       "password=password;server=serverurl;" +
                                       "Trusted_Connection=yes;" +
                                       "database=database; " +
                                       "connection timeout=30";
            DataTable dt;
            String cn = New ODBCConnection(ConnectString);
            String SQLStatement;
            String SQLWhere;

            using (SqlConnection connection = new SqlConnection(
               connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }

            Tablename = Tablename.Trim();
            if (Tablename != "")
            {
                SQLWhere = " WHERE upper(Tablename) like '" + Tablename.ToUpper() + "%' ";
            }

            If LibraryName<> "" Then
               If SQLWhere = "" Then
                   SQLWhere = "where "
                Else
                    SQLWhere += "And "
                End If
                SQLWhere += " upper(LibraryName) like'" & LibraryName.ToUpper & "%' "
            End If

        If UserID<> "" Then
           If SQLWhere = "" Then
               SQLWhere = "where "
            Else
                SQLWhere += "And "
            End If
            SQLWhere += " upper(CrtUserID) ='" & UserID.ToUpper & "' "
        End If
        If DataSet<> "" Then
           If SQLWhere = "" Then
               SQLWhere = "where "
            Else
                SQLWhere += "And "
            End If
            SQLWhere += " upper(DataSetName) like '" & DataSet.ToUpper & "%' "
        End If
        If DatasetHeaderText<> "" Then
           If SQLWhere = "" Then
               SQLWhere = "where "
            Else
                SQLWhere += "And "
            End If
            SQLWhere += " upper(DataSetHeaderText) like '%" & DatasetHeaderText.ToUpper & "%' "
        End If
        If ApplicationCode<> "" Then
           If SQLWhere = "" Then
               SQLWhere = "where "
            Else
                SQLWhere += "And "
            End If
            SQLWhere += " upper(S21ApplicationCode) like '" & ApplicationCode.ToUpper & "%' "
        End If
        If Not Tables Then
            If SQLWhere = "" Then
                SQLWhere = "where "
            Else
                SQLWhere += "And "
            End If
            SQLWhere += " DataSetType <> 'Table' "
        End If
        If Not Views Then
            If SQLWhere = "" Then
                SQLWhere = "where "
            Else
                SQLWhere += "And "
            End If
            SQLWhere += " DataSetType <> 'View' "
        End If

        GetHeaderList = Nothing
        DatasetID = 0

        '  "CRTTIMESTAMP as ""CRT Timestamp"", " &
        '  "UPDUserID as ""UPD UserID"", " &
        '  "UPDTimestamp as ""UPD Timestamp"", " &

        SQLStatement = "SELECT " &
            "trim(DatasetName) as ""DataSet Name"", " &
            "trim(DataSetHeaderText) as ""DataSet Header Text"", " &
            "trim(Tablename) as ""Tablename"", " &
            "trim(Libraryname) as ""Library"", " &
            "trim(S21ApplicationCode) as ""App"", " &
            "trim(DataSetType) as ""Type"", " &
            "trim(AuthorityFlag) as ""Authority Flag"", " &
            "trim(DataSetLevel) as ""Level"", " &
            "trim(Status) as ""Status"", " &
            "cast(ChangeDate as char(10)) concat ' ' concat cast(ChangeTime as char(8)) as ""Data Changed"", " &
            "mlnrcd as ""Records"", " &
            "trim(CRTuserID) as ""Created By"", " &
            "DatasetID " &
            "FROM ebi7020t " &
            "left join xobj50 on odobnm=tablename and odlbnm=LibraryName and odobtp='*FILE' " &
            "left join xmbl on mlfile=tablename and mllib=LibraryName " &
        SQLWhere

        SQLStatement = "SELECT " &
            "trim(DatasetName) as ""DataSet Name"", " &
            "trim(DataSetHeaderText) as ""DataSet Header Text"", " &
            "trim(Tablename) as ""Tablename"", " &
            "trim(Libraryname) as ""Library"", " &
            "trim(S21ApplicationCode) as ""App"", " &
            "trim(DataSetType) as ""Type"", " &
            "trim(AuthorityFlag) as ""Authority Flag"", " &
            "trim(DataSetLevel) as ""Level"", " &
            "trim(Status) as ""Status"", " &
            "trim(CRTuserID) as ""Created By"", " &
            "DatasetID " &
            "FROM ebi7020t " &
        SQLWhere

        SQLStatement += "ORDER BY DatasetName"
        Try
            cn.Open()
            Dim cm As OdbcCommand = cn.CreateCommand 'Create a command object via the connection
            cm.CommandTimeout = 0
            cm.CommandType = CommandType.Text
            cm.CommandText = SQLStatement
            Dim da As New OdbcDataAdapter(cm)
            Dim ds As New DataSet
            da.Fill(ds)
            dt = ds.Tables(0)
            If IsNothing(dt) Then
                Exit Function
            End If
            If dt.Rows.Count = 0 Then
                Exit Function
            End If
            If Not IsDBNull(dt.Rows(0)("DatasetID")) Then
                DatasetID = dt.Rows(0)("DatasetID")
            Else
                DatasetID = 0
            End If
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox("DB ERROR: " & ex.Message)
        End Try
        }

        public GetSQLConnection()
        {
                //> SQL 2012 to get last rows:
                //SELECT *,   
                //Lag(NewRequest, 1) OVER(.  
                //ORDER BY NewRequest ASC) AS PrevRequest
                //FROM @TableName;
            try
            {

            }

            Try
            cn.Open()
            Dim cm As OdbcCommand = cn.CreateCommand 'Create a command object via the connection
            cm.CommandTimeout = 0
            cm.CommandType = CommandType.Text
            cm.CommandText = SQLStatement
            Dim da As New OdbcDataAdapter(cm)
            Dim ds As New DataSet
            da.Fill(ds)
            dt = ds.Tables(0)
            If IsNothing(dt) Then
                Exit Function
            End If
            If dt.Rows.Count = 0 Then
                Exit Function
            End If
            If Not IsDBNull(dt.Rows(0)("DatasetID")) Then
                DatasetID = dt.Rows(0)("DatasetID")
            Else
                DatasetID = 0
            End If
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox("DB ERROR: " & ex.Message)
        End Try


        }

    }
}
