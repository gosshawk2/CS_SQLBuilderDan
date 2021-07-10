
namespace CS_SQLBuilderDan
{
    partial class FrmImportTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlDatabases = new System.Windows.Forms.Panel();
            this.lstTables = new System.Windows.Forms.ListBox();
            this.lstDatabases = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtServerInstance = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rbView = new System.Windows.Forms.RadioButton();
            this.rbTable = new System.Windows.Forms.RadioButton();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAuthority = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOwnerLibrary = new System.Windows.Forms.TextBox();
            this.lblTableOwnerLibrary = new System.Windows.Forms.Label();
            this.txtDatasetDesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDatasetName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlServers = new System.Windows.Forms.Panel();
            this.lstServers = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvExcludeFields = new System.Windows.Forms.DataGridView();
            this.Excluded = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlDatabases.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlServers.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcludeFields)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatabases
            // 
            this.pnlDatabases.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatabases.Controls.Add(this.lstTables);
            this.pnlDatabases.Controls.Add(this.lstDatabases);
            this.pnlDatabases.Controls.Add(this.label2);
            this.pnlDatabases.Controls.Add(this.label1);
            this.pnlDatabases.Location = new System.Drawing.Point(1, 105);
            this.pnlDatabases.Name = "pnlDatabases";
            this.pnlDatabases.Size = new System.Drawing.Size(725, 100);
            this.pnlDatabases.TabIndex = 0;
            // 
            // lstTables
            // 
            this.lstTables.FormattingEnabled = true;
            this.lstTables.Location = new System.Drawing.Point(390, 4);
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(249, 82);
            this.lstTables.TabIndex = 5;
            this.lstTables.SelectedIndexChanged += new System.EventHandler(this.lstTables_SelectedIndexChanged);
            // 
            // lstDatabases
            // 
            this.lstDatabases.FormattingEnabled = true;
            this.lstDatabases.Location = new System.Drawing.Point(94, 4);
            this.lstDatabases.Name = "lstDatabases";
            this.lstDatabases.Size = new System.Drawing.Size(223, 82);
            this.lstDatabases.TabIndex = 4;
            this.lstDatabases.SelectedIndexChanged += new System.EventHandler(this.lstDatabases_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Table:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Database:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(30, 74);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(28, 20);
            this.txtID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID:";
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.txtServerInstance);
            this.pnlMain.Controls.Add(this.label15);
            this.pnlMain.Controls.Add(this.txtPort);
            this.pnlMain.Controls.Add(this.label14);
            this.pnlMain.Controls.Add(this.rbView);
            this.pnlMain.Controls.Add(this.rbTable);
            this.pnlMain.Controls.Add(this.txtServer);
            this.pnlMain.Controls.Add(this.label12);
            this.pnlMain.Controls.Add(this.txtTable);
            this.pnlMain.Controls.Add(this.label11);
            this.pnlMain.Controls.Add(this.txtDatabase);
            this.pnlMain.Controls.Add(this.label10);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Controls.Add(this.btnUpdate);
            this.pnlMain.Controls.Add(this.txtStatus);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.txtAuthority);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.txtType);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.txtOwnerLibrary);
            this.pnlMain.Controls.Add(this.lblTableOwnerLibrary);
            this.pnlMain.Controls.Add(this.txtDatasetDesc);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.txtDatasetName);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Location = new System.Drawing.Point(1, 353);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(725, 267);
            this.pnlMain.TabIndex = 1;
            // 
            // txtServerInstance
            // 
            this.txtServerInstance.Location = new System.Drawing.Point(567, 18);
            this.txtServerInstance.Name = "txtServerInstance";
            this.txtServerInstance.Size = new System.Drawing.Size(120, 20);
            this.txtServerInstance.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(518, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Instance:";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(388, 94);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(80, 21);
            this.txtPort.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(357, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 15);
            this.label14.TabIndex = 22;
            this.label14.Text = "Port:";
            // 
            // rbView
            // 
            this.rbView.AutoSize = true;
            this.rbView.Location = new System.Drawing.Point(278, 162);
            this.rbView.Name = "rbView";
            this.rbView.Size = new System.Drawing.Size(48, 17);
            this.rbView.TabIndex = 25;
            this.rbView.TabStop = true;
            this.rbView.Text = "View";
            this.rbView.UseVisualStyleBackColor = true;
            this.rbView.CheckedChanged += new System.EventHandler(this.rbView_CheckedChanged);
            // 
            // rbTable
            // 
            this.rbTable.AutoSize = true;
            this.rbTable.Location = new System.Drawing.Point(223, 162);
            this.rbTable.Name = "rbTable";
            this.rbTable.Size = new System.Drawing.Size(52, 17);
            this.rbTable.TabIndex = 24;
            this.rbTable.TabStop = true;
            this.rbTable.Text = "Table";
            this.rbTable.UseVisualStyleBackColor = true;
            this.rbTable.CheckedChanged += new System.EventHandler(this.rbTable_CheckedChanged);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(94, 18);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(414, 20);
            this.txtServer.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Server:";
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(388, 59);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(120, 20);
            this.txtTable.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(352, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Table:";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(94, 59);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(223, 20);
            this.txtDatabase.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Database:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(388, 236);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(223, 20);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(94, 236);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(223, 20);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(388, 196);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(55, 20);
            this.txtStatus.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(349, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Status:";
            // 
            // txtAuthority
            // 
            this.txtAuthority.Location = new System.Drawing.Point(94, 196);
            this.txtAuthority.Name = "txtAuthority";
            this.txtAuthority.Size = new System.Drawing.Size(55, 20);
            this.txtAuthority.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Authority:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(94, 161);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(120, 20);
            this.txtType.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Type:";
            // 
            // txtOwnerLibrary
            // 
            this.txtOwnerLibrary.Location = new System.Drawing.Point(388, 128);
            this.txtOwnerLibrary.Name = "txtOwnerLibrary";
            this.txtOwnerLibrary.Size = new System.Drawing.Size(120, 20);
            this.txtOwnerLibrary.TabIndex = 7;
            // 
            // lblTableOwnerLibrary
            // 
            this.lblTableOwnerLibrary.AutoSize = true;
            this.lblTableOwnerLibrary.Location = new System.Drawing.Point(348, 133);
            this.lblTableOwnerLibrary.Name = "lblTableOwnerLibrary";
            this.lblTableOwnerLibrary.Size = new System.Drawing.Size(41, 13);
            this.lblTableOwnerLibrary.TabIndex = 6;
            this.lblTableOwnerLibrary.Text = "Owner:";
            // 
            // txtDatasetDesc
            // 
            this.txtDatasetDesc.Location = new System.Drawing.Point(94, 128);
            this.txtDatasetDesc.Name = "txtDatasetDesc";
            this.txtDatasetDesc.Size = new System.Drawing.Size(223, 20);
            this.txtDatasetDesc.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dataset Desc:";
            // 
            // txtDatasetName
            // 
            this.txtDatasetName.Location = new System.Drawing.Point(94, 94);
            this.txtDatasetName.Name = "txtDatasetName";
            this.txtDatasetName.Size = new System.Drawing.Size(223, 20);
            this.txtDatasetName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dataset Name:";
            // 
            // pnlServers
            // 
            this.pnlServers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlServers.Controls.Add(this.txtID);
            this.pnlServers.Controls.Add(this.label4);
            this.pnlServers.Controls.Add(this.lstServers);
            this.pnlServers.Controls.Add(this.label13);
            this.pnlServers.Location = new System.Drawing.Point(1, 4);
            this.pnlServers.Name = "pnlServers";
            this.pnlServers.Size = new System.Drawing.Size(725, 100);
            this.pnlServers.TabIndex = 2;
            // 
            // lstServers
            // 
            this.lstServers.FormattingEnabled = true;
            this.lstServers.Location = new System.Drawing.Point(94, 12);
            this.lstServers.Name = "lstServers";
            this.lstServers.Size = new System.Drawing.Size(610, 82);
            this.lstServers.TabIndex = 5;
            this.lstServers.SelectedIndexChanged += new System.EventHandler(this.lstServers_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Select Server:";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.label7);
            this.pnlGrid.Controls.Add(this.dgvExcludeFields);
            this.pnlGrid.Location = new System.Drawing.Point(1, 207);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(725, 140);
            this.pnlGrid.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(23, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 32);
            this.label7.TabIndex = 9;
            this.label7.Text = "Exclude Fields:";
            // 
            // dgvExcludeFields
            // 
            this.dgvExcludeFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcludeFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excluded});
            this.dgvExcludeFields.Location = new System.Drawing.Point(94, 7);
            this.dgvExcludeFields.Name = "dgvExcludeFields";
            this.dgvExcludeFields.Size = new System.Drawing.Size(610, 122);
            this.dgvExcludeFields.TabIndex = 8;
            // 
            // Excluded
            // 
            this.Excluded.HeaderText = "Excluded";
            this.Excluded.Name = "Excluded";
            // 
            // FrmImportTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 627);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlServers);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlDatabases);
            this.Name = "FrmImportTable";
            this.Text = "Import Table";
            this.Load += new System.EventHandler(this.FrmImportTable_Load);
            this.pnlDatabases.ResumeLayout(false);
            this.pnlDatabases.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlServers.ResumeLayout(false);
            this.pnlServers.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcludeFields)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatabases;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtDatasetName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstTables;
        private System.Windows.Forms.ListBox lstDatabases;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOwnerLibrary;
        private System.Windows.Forms.Label lblTableOwnerLibrary;
        private System.Windows.Forms.TextBox txtDatasetDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAuthority;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlServers;
        private System.Windows.Forms.ListBox lstServers;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton rbView;
        private System.Windows.Forms.RadioButton rbTable;
        private System.Windows.Forms.TextBox txtServerInstance;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvExcludeFields;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Excluded;
    }
}