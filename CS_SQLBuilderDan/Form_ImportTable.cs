using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.Common;

namespace CS_SQLBuilderDan
{
    public partial class FrmImportTable : Form
    {
        CS_SQLBuilderDAL DAL2 = new CS_SQLBuilderDAL();
        public FrmImportTable()
        {
            InitializeComponent();
            
        }

        private void FrmImportTable_Load(object sender, EventArgs e)
        {
            //LOAD EVENT: set this form to MDI parent

            //ths.statusStrip1.StsLabel1.Text = "Please Wait ... Setting up Lists";
            pnlGrid.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            dgvExcludeFields.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            Program.MainForm.statusMSG1 = "Please Wait ... Getting Server List";
            ListServers(SqlClientFactory.Instance);
        }

        public void ListServers(DbProviderFactory factory)
        {
            string myServer = Environment.MachineName;
            //DataTable servers = DbDataSourceEnumerator
            if (factory.CanCreateDataSourceEnumerator)
            {
                DbDataSourceEnumerator Instances = factory.CreateDataSourceEnumerator();
                //DataTable dt = Instances.GetDataSources();
                DataTable dt = DAL2.GetSQLServers();
                string ServerName = string.Empty;
                string Instance = string.Empty;
                //Look for Server name and return the server instance name.

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ServerName = dt.Rows[i]["ServerName"].ToString();
                    Instance = dt.Rows[i]["InstanceName"].ToString();
                    if (Instance != string.Empty)
                    {
                        lstServers.Items.Add(ServerName + "\\" + Instance);
                    }
                    else
                    {
                        lstServers.Items.Add(ServerName);
                    }
                }
            }
            else
            {
                Program.MainForm.statusMSG1 = "Cannot Create Server List.";
            }
            Program.MainForm.statusMSG1 = "Ready>";
        }

        public void ListDatabases(string ServerName)
        {
            //var DBsLOC = new Microsoft.SqlServer.Management.Smo.Server("localhost").Databases.Cast<Microsoft.SqlServer.Management.Smo.Database>().Where(bs => !bs.IsSystemObject && bs.ID > 6).ToList();
            //Microsoft.SqlServer.
            //Form_MAIN.statusStrip1.StsLabel1.Text = "";
            Program.MainForm.statusMSG1 = "Getting List of Databases ...";
            string SqlStatement = string.Empty;
            DataTable tempTable = null;
            DataTable dt = null;
            string DatabaseName = string.Empty;
            string ID = string.Empty;

            lstDatabases.Items.Clear();
            //Program.CurrentServer = ServerName;
            SqlStatement = "Use " + ServerName;
            tempTable = DAL2.GetData(SqlStatement);
            SqlStatement = "SELECT name,database_id,Create_date FROM sys.databases";
            dt = DAL2.GetData(SqlStatement);
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DatabaseName = dt.Rows[i]["name"].ToString();
                    ID = dt.Rows[i]["database_id"].ToString();
                    if (DatabaseName != string.Empty)
                    {
                        lstDatabases.Items.Add(DatabaseName);
                    }
                }
                Program.MainForm.statusMSG1 = "Ready>";
            }
            else
            {
                Program.MainForm.statusMSG1 = "Cannot get list of databases.";
            }
            
        }

        public void ListTables(string DatabaseName)
        {
            //var DBsLOC = new Microsoft.SqlServer.Management.Smo.Server("localhost").Databases.Cast<Microsoft.SqlServer.Management.Smo.Database>().Where(bs => !bs.IsSystemObject && bs.ID > 6).ToList();
            //Microsoft.SqlServer.
            Program.MainForm.statusMSG1 = "Getting Tables ...";
            Program.CurrentDBName = DatabaseName;
            string SqlStatement = string.Empty;
            DataTable tempTable = null;
            DataTable dt = null;
            string Tablename = string.Empty;
            string ID = string.Empty;
            //var DAL = new CS_SQLBuilderDAL();

            lstTables.Items.Clear();

            SqlStatement = "Use " + DatabaseName;
            tempTable = DAL2.GetData(SqlStatement);
            
            SqlStatement = "SELECT * FROM sys.tables";
            dt = DAL2.GetData(SqlStatement);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Tablename = dt.Rows[i]["name"].ToString();
                ID = dt.Rows[i]["object_id"].ToString();
                if (Tablename != string.Empty)
                {
                    lstTables.Items.Add(Tablename);
                }
            }
            Program.MainForm.statusMSG1 = "Ready>";
        }

        public void ListFields(string TableName)
        {
            Program.MainForm.statusMSG1 = "Getting Fields ...";
            string SqlStatement = string.Empty;
            string ColumnName = string.Empty;
            string TypeName = string.Empty;
            string TableOwner = string.Empty;
            string strColumnSize = string.Empty;
            string strBufferLength = string.Empty;
            string strDataType = string.Empty;
            string strDecimals = string.Empty;
            String strIsIdentity = string.Empty;
            int ColumnSize = 0;
            int BufferLength = 0;
            int intDataType = 0;
            int Decimals = 0;
            bool IsPrimary = false;

            DataTable tempTable = null;
            DataTable dt = null;

            dgvExcludeFields.Rows.Clear();
            dt = DAL2.GetColumns(TableName);
            dgvExcludeFields.DataSource = dt;
            string Owner = dt.Rows[0]["TABLE_SCHEM"].ToString();

            txtOwnerLibrary.Text = Owner;

            Program.MainForm.statusMSG1 = "Ready>";
        }

        public void UpdateTables()
        {
            HeaderList Header = new HeaderList();
            TableDetail Detail = new TableDetail();
            string sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string HeaderID = string.Empty;
            DateTime CreateDate = DateTime.Now;
            DateTime ChangeDate = DateTime.Now;

            if (txtID.Text == string.Empty)
            {
                HeaderID = "0";
            }
            else
            {
                HeaderID = txtID.Text;
            }
            Header.DBType = Program.DBType;
            Header.DatasetID = Int32.Parse(HeaderID);
            Header.DatasetName = txtDatasetName.Text;
            Header.DatasetHeaderText = txtDatasetDesc.Text;
            Header.Description = txtDatasetDesc.Text;
            Header.DatabaseName = txtDatabase.Text;
            Header.TableName = txtTable.Text;
            Header.LibraryName = txtOwnerLibrary.Text;
            Header.DatasetType = txtType.Text;
            Header.AuthorityFlag = Int32.Parse(txtAuthority.Text);
            Header.DatasetLevel = "1";
            Header.FileLocation = "c:\\";
            Header.ImportedBy = Program.CurrentUser;
            
            Header.ImportDate = CreateDate;
            Header.ServerName = txtServer.Text;
            Header.ServerInstance = txtServerInstance.Text;
            Header.ComputerName = Program.ComputerName;
            Header.IPAddr4 = "127.0.0.1";
            Header.ChangedBy = Program.CurrentUser;
            Header.ChangeDate = ChangeDate;
            Header.TotalRecords = 0;
            Header.Status = 1;
            Header.Port = txtPort.Text;
              
            DAL2.Update_Header_With_Parameters(Header);
            DataTable dtSchema = DAL2.GetColumns(Program.SystemDetailTable);
            Detail.ColumnID = 0;
            Detail.ImportedBy = Program.CurrentUser;
            Detail.ChangedBy = Program.CurrentUser;
            Detail.ServerName = txtServer.Text;
            Detail.ServerInstance = txtServerInstance.Text;
            Detail.LibraryName = txtOwnerLibrary.Text;
            Detail.DatabaseName = txtDatabase.Text;
            Detail.TableName = txtTable.Text;
            Detail.IPAddr4 = "127.0.0.1";
            Detail.Port = txtPort.Text;

            // Cycle through rows in grid - only capture those that are not ticked:
            foreach (DataGridViewRow row in dgvExcludeFields.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    //Excluded rows - ignore

                }
                else //Each row in grid represents 1 field in specified user table ?
                {
                    Detail.ColumnName = row.Cells["COLUMN_NAME"].Value.ToString();
                    Detail.ColumnText = row.Cells["COLUMN_NAME"].Value.ToString();
                    Detail.ColumnAlias = row.Cells["COLUMN_NAME"].Value.ToString();
                    Detail.ColumnType = row.Cells["TYPE_NAME"].Value.ToString();
                    Detail.LibraryName = row.Cells["TABLE_SCHEM"].Value.ToString();
                    Detail.ColumnLength = 0;
                    if (Int32.TryParse(row.Cells["COLUMN_SIZE"].Value.ToString(), out int ColLen))
                    {
                        Detail.ColumnLength = ColLen;
                    }
                    //strBufferLength = dt.Rows[i]["BUFFER_LENGTH"].ToString();
                    //strDataType = dt.Rows[i]["DATA_TYPE"].ToString(); //numeric result
                    Detail.ColumnDecimals = 0;
                    if (Int32.TryParse(row.Cells["DECIMAL_DIGITS"].Value.ToString(), out int ColDecimals))
                    {
                        Detail.ColumnDecimals = ColDecimals;
                    }
                    
                    string strIsIdentity = row.Cells["SS_IS_IDENTITY"].Value.ToString();
                    Detail.IsPrimaryKey = false;
                    if (strIsIdentity == "1")
                    {
                        Detail.IsPrimaryKey = true;
                    }
                    DAL2.Update_Detail_With_Parameters(Detail);
                }
            }
            Program.MainForm.statusMSG1 = "OK UPDATED "+DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update Table / View:
            UpdateTables();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close:
            Close();
        }

        private void lstDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTables.Items.Clear();
            txtTable.Text = "";
            if (lstDatabases.SelectedIndex != -1)
            {
                string DatabaseName = lstDatabases.Items[lstDatabases.SelectedIndex].ToString();
                try
                {
                    txtDatabase.Text = DatabaseName;
                    Program.CurrentDBName = DatabaseName;
                    ListTables(DatabaseName);
                }
                catch (Exception ex)
                {
                    string exception = ex.Message;
                    Program.MainForm.statusMSG1 = "Exception Error: " + exception;
                }
            }
        }

        private void lstTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Tablename = lstTables.Items[lstTables.SelectedIndex].ToString();
            txtTable.Text = Tablename;
            Program.CurrentTableName = Tablename;
            ListFields(Tablename);
        }

        private void rbTable_CheckedChanged(object sender, EventArgs e)
        {
            txtType.Text = "TABLE";
        }

        private void rbView_CheckedChanged(object sender, EventArgs e)
        {
            txtType.Text = "VIEW";
        }

        private void lstServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FullServerName = string.Empty;
            string ServerName = string.Empty;
            string ServerInstance = string.Empty;
            int InstanceLength = 0;
            int ForwardSlashPos = 0;

            if (lstServers.SelectedIndex > -1)
            {
                FullServerName = lstServers.Items[lstServers.SelectedIndex].ToString();
                ForwardSlashPos = FullServerName.IndexOf("\\");
                InstanceLength = (FullServerName.Length - ForwardSlashPos) - 1;
                ServerName = FullServerName.Substring(0, ForwardSlashPos);
                ServerInstance = FullServerName.Substring(ForwardSlashPos+1,InstanceLength);
                txtServer.Text = ServerName;
                txtServerInstance.Text = ServerInstance;
                Program.CurrentServer = ServerName;
                Program.CurrentServerInstance = ServerInstance;
                ListDatabases(FullServerName);
            }
        }
    }
}
