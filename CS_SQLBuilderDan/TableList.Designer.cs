
namespace CS_SQLBuilderDan
{
    partial class frmTableList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLibrary = new System.Windows.Forms.TextBox();
            this.lblLibrary = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoadQuery = new System.Windows.Forms.Button();
            this.cboViews = new System.Windows.Forms.CheckBox();
            this.cboTables = new System.Windows.Forms.CheckBox();
            this.txtDatasetName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StsLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StsLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StsLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvTableList = new System.Windows.Forms.DataGridView();
            this.btnImport = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.Controls.Add(this.btnImport);
            this.pnlTop.Controls.Add(this.txtDescription);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.txtDatabase);
            this.pnlTop.Controls.Add(this.lblDatabase);
            this.pnlTop.Controls.Add(this.txtTableName);
            this.pnlTop.Controls.Add(this.label5);
            this.pnlTop.Controls.Add(this.txtLibrary);
            this.pnlTop.Controls.Add(this.lblLibrary);
            this.pnlTop.Controls.Add(this.txtUser);
            this.pnlTop.Controls.Add(this.label4);
            this.pnlTop.Controls.Add(this.btnLoadQuery);
            this.pnlTop.Controls.Add(this.cboViews);
            this.pnlTop.Controls.Add(this.cboTables);
            this.pnlTop.Controls.Add(this.txtDatasetName);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.btnRefresh);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnClearFilters);
            this.pnlTop.Location = new System.Drawing.Point(3, 10);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(951, 62);
            this.pnlTop.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(275, 7);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(159, 20);
            this.txtDescription.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Desc:";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(475, 37);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(155, 20);
            this.txtDatabase.TabIndex = 16;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(451, 40);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(25, 13);
            this.lblDatabase.TabIndex = 17;
            this.lblDatabase.Text = "DB:";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(475, 7);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(155, 20);
            this.txtTableName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Table:";
            // 
            // txtLibrary
            // 
            this.txtLibrary.Location = new System.Drawing.Point(678, 7);
            this.txtLibrary.Name = "txtLibrary";
            this.txtLibrary.Size = new System.Drawing.Size(157, 20);
            this.txtLibrary.TabIndex = 14;
            // 
            // lblLibrary
            // 
            this.lblLibrary.AutoSize = true;
            this.lblLibrary.Location = new System.Drawing.Point(638, 10);
            this.lblLibrary.Name = "lblLibrary";
            this.lblLibrary.Size = new System.Drawing.Size(41, 13);
            this.lblLibrary.TabIndex = 13;
            this.lblLibrary.Text = "Owner:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(363, 36);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 20);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Location = new System.Drawing.Point(285, 36);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(70, 20);
            this.btnClearFilters.TabIndex = 11;
            this.btnClearFilters.Text = "Clear Filters";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(678, 37);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(157, 20);
            this.txtUser.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(647, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "User:";
            // 
            // btnLoadQuery
            // 
            this.btnLoadQuery.Location = new System.Drawing.Point(206, 36);
            this.btnLoadQuery.Name = "btnLoadQuery";
            this.btnLoadQuery.Size = new System.Drawing.Size(70, 20);
            this.btnLoadQuery.TabIndex = 8;
            this.btnLoadQuery.Text = "Load Query";
            this.btnLoadQuery.UseVisualStyleBackColor = true;
            this.btnLoadQuery.Click += new System.EventHandler(this.btnLoadQuery_Click);
            // 
            // cboViews
            // 
            this.cboViews.AutoSize = true;
            this.cboViews.Checked = true;
            this.cboViews.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboViews.Location = new System.Drawing.Point(883, 37);
            this.cboViews.Name = "cboViews";
            this.cboViews.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboViews.Size = new System.Drawing.Size(57, 17);
            this.cboViews.TabIndex = 7;
            this.cboViews.Text = ":Views";
            this.cboViews.UseVisualStyleBackColor = true;
            // 
            // cboTables
            // 
            this.cboTables.AutoSize = true;
            this.cboTables.Checked = true;
            this.cboTables.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboTables.Location = new System.Drawing.Point(879, 9);
            this.cboTables.Name = "cboTables";
            this.cboTables.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboTables.Size = new System.Drawing.Size(61, 17);
            this.cboTables.TabIndex = 6;
            this.cboTables.Text = ":Tables";
            this.cboTables.UseVisualStyleBackColor = true;
            // 
            // txtDatasetName
            // 
            this.txtDatasetName.Location = new System.Drawing.Point(80, 7);
            this.txtDatasetName.Name = "txtDatasetName";
            this.txtDatasetName.Size = new System.Drawing.Size(159, 20);
            this.txtDatasetName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dataset Name:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(127, 36);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(70, 20);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrid.Controls.Add(this.statusStrip1);
            this.pnlGrid.Controls.Add(this.dgvTableList);
            this.pnlGrid.Location = new System.Drawing.Point(3, 78);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(951, 300);
            this.pnlGrid.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StsLabel1,
            this.StsLabel2,
            this.StsLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 278);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(951, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StsLabel1
            // 
            this.StsLabel1.Name = "StsLabel1";
            this.StsLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // StsLabel2
            // 
            this.StsLabel2.Name = "StsLabel2";
            this.StsLabel2.Size = new System.Drawing.Size(936, 17);
            this.StsLabel2.Spring = true;
            // 
            // StsLabel3
            // 
            this.StsLabel3.Name = "StsLabel3";
            this.StsLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // dgvTableList
            // 
            this.dgvTableList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTableList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableList.Location = new System.Drawing.Point(8, 9);
            this.dgvTableList.Name = "dgvTableList";
            this.dgvTableList.RowTemplate.Height = 25;
            this.dgvTableList.Size = new System.Drawing.Size(933, 266);
            this.dgvTableList.TabIndex = 0;
            this.dgvTableList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvTableList_MouseDown);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(51, 31);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(70, 26);
            this.btnImport.TabIndex = 20;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // frmTableList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 390);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmTableList";
            this.Text = "Table List";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.TextBox txtDatasetName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTableList;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Button btnLoadQuery;
        private System.Windows.Forms.CheckBox cboViews;
        private System.Windows.Forms.CheckBox cboTables;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.TextBox txtLibrary;
        private System.Windows.Forms.Label lblLibrary;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StsLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StsLabel2;
        private System.Windows.Forms.ToolStripStatusLabel StsLabel3;
        private System.Windows.Forms.Button btnImport;
    }
}

