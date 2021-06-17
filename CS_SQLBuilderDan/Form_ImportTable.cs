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
        public FrmImportTable()
        {
            InitializeComponent();
        }

        private void FrmImportTable_Load(object sender, EventArgs e)
        {
            //LOAD EVENT: set this form to MDI parent
            ListServers(SqlClientFactory.Instance);
        }

        public void ListServers(DbProviderFactory factory)
        {
            string myServer = Environment.MachineName;
            //DataTable servers = DbDataSourceEnumerator
            if (factory.CanCreateDataSourceEnumerator)
            {
                DbDataSourceEnumerator Instances = factory.CreateDataSourceEnumerator();
                DataTable dt = Instances.GetDataSources();
                string ServerName = string.Empty;
                string Instance = string.Empty;
                
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
        }

        public void ListDatabases(string ServerName)
        {
            //var DBsLOC = new Microsoft.SqlServer.Management.Smo.Server("localhost").Databases.Cast<Microsoft.SqlServer.Management.Smo.Database>().Where(bs => !bs.IsSystemObject && bs.ID > 6).ToList();
            //Microsoft.SqlServer.
            string SqlStatement = string.Empty;
            DataTable tempTable = null;
            DataTable dt = null;
            string DatabaseName = string.Empty;
            string ID = string.Empty;
            var DAL = new CS_SQLBuilderDAL();

            SqlStatement = "Use " + ServerName;
            tempTable = DAL.GetData(SqlStatement);
            SqlStatement = "SELECT name,database_id,Create_date FROM sys.databases";
            dt = DAL.GetData(SqlStatement);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DatabaseName = dt.Rows[i]["name"].ToString(); 
                ID = dt.Rows[i]["database_id"].ToString();
                if (DatabaseName != string.Empty)
                {
                    lstDatabases.Items.Add(DatabaseName);
                }
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update Table / View:

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close:
            Close();
        }

        private void lstDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTables.Items.Clear();
            if (lstDatabases.SelectedIndex != -1)
            {
                string DatabaseName = lstDatabases.Items[lstDatabases.SelectedIndex].ToString();
                try
                {
                    //foreach (string Table in lstDatabases)
                    //{
                        //lstTables.Items.Add(Table.Name);
                    //}
                }
                catch (Exception ex)
                {
                    string exception = ex.Message;
                }
            }
        }

        private void lstTables_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            string ServerName = string.Empty;

            if (lstServers.SelectedIndex > -1)
            {
                ServerName = lstServers.Items[lstServers.SelectedIndex].ToString();
                txtServer.Text = ServerName;
                ListDatabases(ServerName);
            }
        }
    }
}
