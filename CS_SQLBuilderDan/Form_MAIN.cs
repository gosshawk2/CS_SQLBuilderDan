using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace CS_SQLBuilderDan
{
    public partial class Form_MAIN : Form
    {
        public Form_MAIN()
        {
            System.Security.Principal.WindowsPrincipal P;

            InitializeComponent();
        }

        private void tableListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTableListForm();
        }

        private void Form_MAIN_Load(object sender, EventArgs e)
        {
            //var UserID = (System.Security.Principal.WindowsPrincipal)System.Threading.Thread.CurrentPrincipal;
            //System.Security.Principal.WindowsPrincipal P = (System.Security.Principal.WindowsPrincipal)System.Threading.Thread.CurrentPrincipal;

            string FullUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            //AUser = P.Identity.Name;
            int SlashPos = FullUser.IndexOf("\\");
            if (SlashPos > 0)
            {
                Program.CurrentUser = FullUser.Substring(SlashPos + 1);
            }
            Program.CurrentServer = FullUser.Substring(0, 15);
            Program.CurrentMode = "Live";
            StsLabel2.Spring = true;
            StsLabel1.ForeColor = Color.AliceBlue;
            StsLabel2.ForeColor = Color.AliceBlue;
            StsLabel3.ForeColor = Color.AliceBlue;
            StsLabel4.ForeColor = Color.AliceBlue;
            StsLabel5.ForeColor = Color.AliceBlue;
            StsLabel6.ForeColor = Color.AliceBlue;
            StsLabel3.Text = "    User: " + Program.CurrentUser + "   ";
            StsLabel4.Text = "    Server: " + Program.CurrentServer + "   ";
            StsLabel5.Text = "    Environment: " + Program.CurrentMode + "   ";
            StsLabel6.Text = String.Format("    Version {0}", Assembly.GetExecutingAssembly().GetName().Version) + "   ";

            Program.ParentHandle = this.Handle;
            Program.ParentForm = this;
            Program.DBType = "MSSQL_ODBC";
            Program.Theme = "DARK";

            /*For Each c As Control In Controls
                AddHandler c.MouseClick, AddressOf ClickHandler
            Next */


        }

        public void ClickHandler(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.BringToFront();
            }
        }

        private void OpenTableListForm()
        {
            //Open child form to show tables imported in grid-like control:
            var App = new frmTableList();

            Cursor = Cursors.Default;
            StsLabel1.Text = "Loading List......";
            Cursor = Cursors.WaitCursor;
            //Refresh()
            App.Visible = false;
            //App.GetParms(GlobalSession, GlobalParms)
            //App.PopulateForm()
            App.MdiParent = this;
            App.StartPosition = FormStartPosition.CenterParent;
            App.Show();
            StsLabel1.Text = "";
            Cursor = Cursors.Default;
        }

        private void OpenImportTables()
        {
            //Open child form to show tables imported in grid-like control:
            var App = new FrmImportTable();

            Cursor = Cursors.Default;
            StsLabel1.Text = "Open Form: Import Table......";
            Cursor = Cursors.WaitCursor;
            //Refresh()
            App.Visible = false;
            //App.GetParms(GlobalSession, GlobalParms)
            //App.PopulateForm()
            App.MdiParent = this;
            App.Show();
            StsLabel1.Text = "";
            Cursor = Cursors.Default;
        }

        private void OpenWebBrowser2()
        {
            //Open child form to show tables imported in grid-like control:
            var App = new Form_WebView2_Browser();

            Cursor = Cursors.Default;
            StsLabel1.Text = "Open Form: Web Browser v2......";
            Cursor = Cursors.WaitCursor;
            //Refresh()
            //App.Visible = false;
            //App.GetParms(GlobalSession, GlobalParms)
            //App.PopulateForm()
            App.MdiParent = this;
            App.Show();
            StsLabel1.Text = "";
            Cursor = Cursors.Default;
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set Dark Theme:
            Program.Theme = "DARK";
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set Normal Theme:
            Program.Theme = "NORMAL";
        }

        private void mSSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set MSSQL database:

        }

        private void mySQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set MYSQL database:
            Program.DBType = "MYSQL";
        }

        private void iBMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set IBM database:
            Program.DBType = "IBM_ODBC";
        }

        private void oDBCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.DBType = "MSSQL_ODBC";
        }

        private void oLEDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.DBType = "MSSQL_OLEDB";
        }

        private void importTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenImportTables();
        }

        private void webView2BrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
