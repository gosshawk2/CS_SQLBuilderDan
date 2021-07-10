using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_SQLBuilderDan
{

    public partial class frmTableList : Form
    {
        HeaderList Header = new HeaderList();

        public frmTableList()
        {

            InitializeComponent();
        }

        private void PrepareHeader()
        {
            Header.DatasetID = 0;
            Header.DatasetName = string.Empty;
            Header.DatasetHeaderText = string.Empty;
            Header.DatabaseName = string.Empty;
            Header.TableName = string.Empty;
            Header.LibraryName = string.Empty;
            Header.DatasetType = string.Empty;
            Header.AuthorityFlag = 0;
            Header.DatasetLevel = string.Empty;
            Header.FileLocation = string.Empty;
            Header.ImportedBy = string.Empty;
            Header.ImportDate = DateTime.Today;
            Header.ServerName = string.Empty;
            Header.ServerInstance = string.Empty;
            Header.ComputerName = string.Empty;
            Header.IPAddr4 = string.Empty;
            Header.Port = string.Empty;
            Header.Status = 0;
            Header.ChangedBy = string.Empty;
            Header.ChangeDate = DateTime.Today;
            Header.TotalRecords = 0;
            Header.Tables = cboTables.Checked;
            Header.Views = cboViews.Checked;
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            //Load Event in MyWinformsDemo namespace
            this.KeyPreview = true;
            if (Program.DBType == "IBM_ODBC")
            {
                lblLibrary.Text = "Lib:";
            }
            PrepareHeader();
            txtDatasetName.Text = "";
            txtTableName.Text = "";
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            Program.MainForm.statusMSG1 = "Getting Tables ...";
            DataTable dt = null;
            string ConnString = string.Empty;
            string DBTable = string.Empty;
            string DatasetHeaderText = string.Empty;
            
            var DAL = new CS_SQLBuilderDAL();
            //Populate Header class with any search text entered by user before populating from database:
            Header.ConString = string.Empty;
            Header.DatasetID = 0;
            Header.DatasetName = txtDatasetName.Text;
            Header.DatabaseName = txtDatabase.Text;
            Header.TableName = txtTableName.Text;
            Header.LibraryName = txtLibrary.Text;
            Header.DatasetType = string.Empty;
            Header.DatasetLevel = string.Empty;
            Header.ImportedBy = txtUser.Text;
            Header.Description = txtDescription.Text;
            Header.DatasetHeaderText = txtDescription.Text;
            Header.ServerName = string.Empty;
            Header.ServerInstance = string.Empty;
            Header.SortField = string.Empty;
            Header.ComputerName = string.Empty;
            Header.IPAddr4 = string.Empty;
            Header.Port = string.Empty;
            Header.Tables = cboTables.Checked;
            Header.Views = cboViews.Checked;

            dt = DAL.GetHeaderList(Header);
            dgvTableList.DataSource = dt;
            Program.MainForm.statusMSG1 = "Ready>";
        }



        private void btnTest_Click(object sender, EventArgs e)
        {
            //DataTable dataTable = SmoApplication.EnumAvailableSqlServers(true);
            //listBox1.ValueMember = "Name";
            //listBox1.DataSource = dataTable;


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Call PopulateGrid()
            PopulateGrid();
        }

        private void btnLoadQuery_Click(object sender, EventArgs e)
        {
            //Call LoadQuery()

        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            //Call ClearFilters()
            txtDatabase.Text = "";
            txtDatasetName.Text = "";
            txtDescription.Text = "";
            txtLibrary.Text = "";
            txtTableName.Text = "";
            txtUser.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTableList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Call popup menu:
                
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Program.MainForm.OpenImportTables();
        }
    }
}
