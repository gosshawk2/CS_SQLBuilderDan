
namespace CS_SQLBuilderDan
{
    partial class Form_SQLBuilder
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtDatasetName = new System.Windows.Forms.TextBox();
            this.txtTablename = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTablename = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvColumnList = new System.Windows.Forms.DataGridView();
            this.gbFilterRecords = new System.Windows.Forms.GroupBox();
            this.dgvConditions = new System.Windows.Forms.DataGridView();
            this.txtEditCondition = new System.Windows.Forms.TextBox();
            this.btnEditCondition = new System.Windows.Forms.Button();
            this.txtINvalues = new System.Windows.Forms.TextBox();
            this.rbOR = new System.Windows.Forms.RadioButton();
            this.cbIgnoreCase = new System.Windows.Forms.CheckBox();
            this.rbAND = new System.Windows.Forms.RadioButton();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.lblFilterRecords = new System.Windows.Forms.Label();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.btnAddCondition = new System.Windows.Forms.Button();
            this.btnRemoveCondition = new System.Windows.Forms.Button();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.cboWhereFields = new System.Windows.Forms.ComboBox();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.cboOperators = new System.Windows.Forms.ComboBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblColumn = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.gbSaveOptions = new System.Windows.Forms.GroupBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaveQuery = new System.Windows.Forms.Button();
            this.btnEditQuery = new System.Windows.Forms.Button();
            this.btnLoadQuery = new System.Windows.Forms.Button();
            this.gbSortResults = new System.Windows.Forms.GroupBox();
            this.dgvSortFields = new System.Windows.Forms.DataGridView();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnMoveOrderByFieldsUp = new System.Windows.Forms.Button();
            this.btnMoveOrderByFieldsDown = new System.Windows.Forms.Button();
            this.btnAddSortFields = new System.Windows.Forms.Button();
            this.btnRemoveSortFields = new System.Windows.Forms.Button();
            this.gbExecutionOptions = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstRows = new System.Windows.Forms.TextBox();
            this.lblReturnFirst = new System.Windows.Forms.Label();
            this.btnRunQuery = new System.Windows.Forms.Button();
            this.btnShowSQL = new System.Windows.Forms.Button();
            this.btnGenerateSQL = new System.Windows.Forms.Button();
            this.gbDisplayElements = new System.Windows.Forms.GroupBox();
            this.lblDataElementsLabel = new System.Windows.Forms.Label();
            this.btnMoveSelectedFieldsDown = new System.Windows.Forms.Button();
            this.dgvListFields = new System.Windows.Forms.DataGridView();
            this.btnIncludeCount = new System.Windows.Forms.Button();
            this.btnRemoveSelectedFields = new System.Windows.Forms.Button();
            this.btnAddSelectedFields = new System.Windows.Forms.Button();
            this.btnMoveSelectedFieldsUP = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumnList)).BeginInit();
            this.gbFilterRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConditions)).BeginInit();
            this.gbSaveOptions.SuspendLayout();
            this.gbSortResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSortFields)).BeginInit();
            this.gbExecutionOptions.SuspendLayout();
            this.gbDisplayElements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFields)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnClear);
            this.pnlTop.Controls.Add(this.btnRefresh);
            this.pnlTop.Controls.Add(this.txtDatabase);
            this.pnlTop.Controls.Add(this.txtDatasetName);
            this.pnlTop.Controls.Add(this.txtTablename);
            this.pnlTop.Controls.Add(this.txtServer);
            this.pnlTop.Controls.Add(this.lblServer);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.lblTablename);
            this.pnlTop.Controls.Add(this.lblDatabase);
            this.pnlTop.Location = new System.Drawing.Point(12, 12);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1185, 66);
            this.pnlTop.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(640, 38);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(104, 38);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(13, 38);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(513, 13);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(202, 20);
            this.txtDatabase.TabIndex = 6;
            // 
            // txtDatasetName
            // 
            this.txtDatasetName.Location = new System.Drawing.Point(87, 13);
            this.txtDatasetName.Name = "txtDatasetName";
            this.txtDatasetName.Size = new System.Drawing.Size(108, 20);
            this.txtDatasetName.TabIndex = 2;
            // 
            // txtTablename
            // 
            this.txtTablename.Location = new System.Drawing.Point(930, 13);
            this.txtTablename.Name = "txtTablename";
            this.txtTablename.Size = new System.Drawing.Size(113, 20);
            this.txtTablename.TabIndex = 0;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(246, 13);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(202, 20);
            this.txtServer.TabIndex = 4;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(206, 16);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(41, 13);
            this.lblServer.TabIndex = 5;
            this.lblServer.Text = "Server:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dataset Name:";
            // 
            // lblTablename
            // 
            this.lblTablename.AutoSize = true;
            this.lblTablename.Location = new System.Drawing.Point(894, 16);
            this.lblTablename.Name = "lblTablename";
            this.lblTablename.Size = new System.Drawing.Size(37, 13);
            this.lblTablename.TabIndex = 1;
            this.lblTablename.Text = "Table:";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(458, 16);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(56, 13);
            this.lblDatabase.TabIndex = 7;
            this.lblDatabase.Text = "Database:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.splitContainer1.Location = new System.Drawing.Point(12, 84);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvColumnList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbFilterRecords);
            this.splitContainer1.Panel2.Controls.Add(this.gbSaveOptions);
            this.splitContainer1.Panel2.Controls.Add(this.gbSortResults);
            this.splitContainer1.Panel2.Controls.Add(this.gbExecutionOptions);
            this.splitContainer1.Panel2.Controls.Add(this.gbDisplayElements);
            this.splitContainer1.Size = new System.Drawing.Size(1185, 662);
            this.splitContainer1.SplitterDistance = 399;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvColumnList
            // 
            this.dgvColumnList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColumnList.Location = new System.Drawing.Point(10, 12);
            this.dgvColumnList.Name = "dgvColumnList";
            this.dgvColumnList.Size = new System.Drawing.Size(374, 625);
            this.dgvColumnList.TabIndex = 0;
            // 
            // gbFilterRecords
            // 
            this.gbFilterRecords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFilterRecords.Controls.Add(this.txtEditCondition);
            this.gbFilterRecords.Controls.Add(this.btnEditCondition);
            this.gbFilterRecords.Controls.Add(this.txtINvalues);
            this.gbFilterRecords.Controls.Add(this.rbOR);
            this.gbFilterRecords.Controls.Add(this.cbIgnoreCase);
            this.gbFilterRecords.Controls.Add(this.rbAND);
            this.gbFilterRecords.Controls.Add(this.dtp2);
            this.gbFilterRecords.Controls.Add(this.lblFilterRecords);
            this.gbFilterRecords.Controls.Add(this.lblValue2);
            this.gbFilterRecords.Controls.Add(this.btnAddCondition);
            this.gbFilterRecords.Controls.Add(this.btnRemoveCondition);
            this.gbFilterRecords.Controls.Add(this.dtp1);
            this.gbFilterRecords.Controls.Add(this.cboWhereFields);
            this.gbFilterRecords.Controls.Add(this.txtOperator);
            this.gbFilterRecords.Controls.Add(this.txtValue2);
            this.gbFilterRecords.Controls.Add(this.cboOperators);
            this.gbFilterRecords.Controls.Add(this.lblOperator);
            this.gbFilterRecords.Controls.Add(this.lblColumn);
            this.gbFilterRecords.Controls.Add(this.txtValue);
            this.gbFilterRecords.Controls.Add(this.label5);
            this.gbFilterRecords.Controls.Add(this.dgvConditions);
            this.gbFilterRecords.Location = new System.Drawing.Point(4, 420);
            this.gbFilterRecords.Name = "gbFilterRecords";
            this.gbFilterRecords.Size = new System.Drawing.Size(753, 235);
            this.gbFilterRecords.TabIndex = 27;
            this.gbFilterRecords.TabStop = false;
            // 
            // dgvConditions
            // 
            this.dgvConditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConditions.Location = new System.Drawing.Point(324, 102);
            this.dgvConditions.Name = "dgvConditions";
            this.dgvConditions.Size = new System.Drawing.Size(419, 89);
            this.dgvConditions.TabIndex = 29;
            // 
            // txtEditCondition
            // 
            this.txtEditCondition.Location = new System.Drawing.Point(324, 197);
            this.txtEditCondition.Name = "txtEditCondition";
            this.txtEditCondition.Size = new System.Drawing.Size(419, 20);
            this.txtEditCondition.TabIndex = 28;
            this.txtEditCondition.Visible = false;
            // 
            // btnEditCondition
            // 
            this.btnEditCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCondition.Location = new System.Drawing.Point(473, 56);
            this.btnEditCondition.Name = "btnEditCondition";
            this.btnEditCondition.Size = new System.Drawing.Size(120, 24);
            this.btnEditCondition.TabIndex = 27;
            this.btnEditCondition.Text = "Edit Condition";
            this.btnEditCondition.UseVisualStyleBackColor = true;
            this.btnEditCondition.Click += new System.EventHandler(this.btnEditCondition_Click);
            // 
            // txtINvalues
            // 
            this.txtINvalues.Location = new System.Drawing.Point(14, 147);
            this.txtINvalues.Multiline = true;
            this.txtINvalues.Name = "txtINvalues";
            this.txtINvalues.Size = new System.Drawing.Size(300, 70);
            this.txtINvalues.TabIndex = 25;
            this.txtINvalues.Visible = false;
            // 
            // rbOR
            // 
            this.rbOR.AutoSize = true;
            this.rbOR.Location = new System.Drawing.Point(380, 19);
            this.rbOR.Name = "rbOR";
            this.rbOR.Size = new System.Drawing.Size(41, 17);
            this.rbOR.TabIndex = 18;
            this.rbOR.Text = "OR";
            this.rbOR.UseVisualStyleBackColor = true;
            // 
            // cbIgnoreCase
            // 
            this.cbIgnoreCase.AutoSize = true;
            this.cbIgnoreCase.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbIgnoreCase.Checked = true;
            this.cbIgnoreCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIgnoreCase.Location = new System.Drawing.Point(476, 17);
            this.cbIgnoreCase.Name = "cbIgnoreCase";
            this.cbIgnoreCase.Size = new System.Drawing.Size(86, 17);
            this.cbIgnoreCase.TabIndex = 25;
            this.cbIgnoreCase.Text = "Ignore Case:";
            this.cbIgnoreCase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // rbAND
            // 
            this.rbAND.AutoSize = true;
            this.rbAND.Checked = true;
            this.rbAND.Location = new System.Drawing.Point(326, 19);
            this.rbAND.Name = "rbAND";
            this.rbAND.Size = new System.Drawing.Size(48, 17);
            this.rbAND.TabIndex = 17;
            this.rbAND.TabStop = true;
            this.rbAND.Text = "AND";
            this.rbAND.UseVisualStyleBackColor = true;
            // 
            // dtp2
            // 
            this.dtp2.CustomFormat = "yyyy-MM-dd";
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp2.Location = new System.Drawing.Point(174, 121);
            this.dtp2.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(95, 20);
            this.dtp2.TabIndex = 22;
            this.dtp2.Visible = false;
            // 
            // lblFilterRecords
            // 
            this.lblFilterRecords.AutoSize = true;
            this.lblFilterRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterRecords.Location = new System.Drawing.Point(2, 12);
            this.lblFilterRecords.Name = "lblFilterRecords";
            this.lblFilterRecords.Size = new System.Drawing.Size(244, 13);
            this.lblFilterRecords.TabIndex = 20;
            this.lblFilterRecords.Text = "Filter Records using Following Conditions:";
            // 
            // lblValue2
            // 
            this.lblValue2.AutoSize = true;
            this.lblValue2.Location = new System.Drawing.Point(15, 86);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(70, 13);
            this.lblValue2.TabIndex = 8;
            this.lblValue2.Text = "Enter Values:";
            this.lblValue2.Visible = false;
            // 
            // btnAddCondition
            // 
            this.btnAddCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCondition.Location = new System.Drawing.Point(324, 56);
            this.btnAddCondition.Name = "btnAddCondition";
            this.btnAddCondition.Size = new System.Drawing.Size(120, 24);
            this.btnAddCondition.TabIndex = 22;
            this.btnAddCondition.Text = "Add Condition";
            this.btnAddCondition.UseVisualStyleBackColor = true;
            this.btnAddCondition.Click += new System.EventHandler(this.btnAddCondition_Click);
            // 
            // btnRemoveCondition
            // 
            this.btnRemoveCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCondition.Location = new System.Drawing.Point(623, 56);
            this.btnRemoveCondition.Name = "btnRemoveCondition";
            this.btnRemoveCondition.Size = new System.Drawing.Size(120, 24);
            this.btnRemoveCondition.TabIndex = 23;
            this.btnRemoveCondition.Text = "Remove Condition";
            this.btnRemoveCondition.UseVisualStyleBackColor = true;
            this.btnRemoveCondition.Click += new System.EventHandler(this.btnRemoveCondition_Click);
            // 
            // dtp1
            // 
            this.dtp1.CustomFormat = "yyyy-MM-dd";
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp1.Location = new System.Drawing.Point(14, 121);
            this.dtp1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(95, 20);
            this.dtp1.TabIndex = 21;
            this.dtp1.Value = new System.DateTime(2020, 4, 7, 0, 0, 0, 0);
            this.dtp1.Visible = false;
            // 
            // cboWhereFields
            // 
            this.cboWhereFields.FormattingEnabled = true;
            this.cboWhereFields.Location = new System.Drawing.Point(14, 56);
            this.cboWhereFields.Name = "cboWhereFields";
            this.cboWhereFields.Size = new System.Drawing.Size(147, 21);
            this.cboWhereFields.TabIndex = 16;
            // 
            // txtOperator
            // 
            this.txtOperator.Location = new System.Drawing.Point(285, 57);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(29, 20);
            this.txtOperator.TabIndex = 18;
            this.txtOperator.Text = "=";
            this.txtOperator.Visible = false;
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(174, 102);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(140, 20);
            this.txtValue2.TabIndex = 21;
            // 
            // cboOperators
            // 
            this.cboOperators.FormattingEnabled = true;
            this.cboOperators.Location = new System.Drawing.Point(174, 56);
            this.cboOperators.Name = "cboOperators";
            this.cboOperators.Size = new System.Drawing.Size(105, 21);
            this.cboOperators.TabIndex = 19;
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(171, 35);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(48, 13);
            this.lblOperator.TabIndex = 4;
            this.lblOperator.Text = "Operator";
            // 
            // lblColumn
            // 
            this.lblColumn.AutoSize = true;
            this.lblColumn.Location = new System.Drawing.Point(14, 35);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(29, 13);
            this.lblColumn.TabIndex = 1;
            this.lblColumn.Text = "Field";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(14, 102);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(147, 20);
            this.txtValue.TabIndex = 20;
            // 
            // gbSaveOptions
            // 
            this.gbSaveOptions.Controls.Add(this.txtFilePath);
            this.gbSaveOptions.Controls.Add(this.label3);
            this.gbSaveOptions.Controls.Add(this.txtFilename);
            this.gbSaveOptions.Controls.Add(this.label6);
            this.gbSaveOptions.Controls.Add(this.btnSaveQuery);
            this.gbSaveOptions.Controls.Add(this.btnEditQuery);
            this.gbSaveOptions.Controls.Add(this.btnLoadQuery);
            this.gbSaveOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSaveOptions.Location = new System.Drawing.Point(514, 219);
            this.gbSaveOptions.Name = "gbSaveOptions";
            this.gbSaveOptions.Size = new System.Drawing.Size(249, 195);
            this.gbSaveOptions.TabIndex = 13;
            this.gbSaveOptions.TabStop = false;
            this.gbSaveOptions.Text = "Save Options";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(45, 165);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(198, 20);
            this.txtFilePath.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Path:";
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(45, 139);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(198, 20);
            this.txtFilename.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "File:";
            // 
            // btnSaveQuery
            // 
            this.btnSaveQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveQuery.Location = new System.Drawing.Point(58, 99);
            this.btnSaveQuery.MinimumSize = new System.Drawing.Size(140, 0);
            this.btnSaveQuery.Name = "btnSaveQuery";
            this.btnSaveQuery.Size = new System.Drawing.Size(140, 23);
            this.btnSaveQuery.TabIndex = 9;
            this.btnSaveQuery.Text = "Save Query";
            this.btnSaveQuery.UseVisualStyleBackColor = true;
            this.btnSaveQuery.Click += new System.EventHandler(this.btnSaveQuery_Click);
            // 
            // btnEditQuery
            // 
            this.btnEditQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditQuery.Location = new System.Drawing.Point(58, 60);
            this.btnEditQuery.MinimumSize = new System.Drawing.Size(140, 0);
            this.btnEditQuery.Name = "btnEditQuery";
            this.btnEditQuery.Size = new System.Drawing.Size(140, 23);
            this.btnEditQuery.TabIndex = 8;
            this.btnEditQuery.Text = "Edit Query";
            this.btnEditQuery.UseVisualStyleBackColor = true;
            this.btnEditQuery.Click += new System.EventHandler(this.btnEditQuery_Click);
            // 
            // btnLoadQuery
            // 
            this.btnLoadQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadQuery.Location = new System.Drawing.Point(58, 25);
            this.btnLoadQuery.MinimumSize = new System.Drawing.Size(140, 0);
            this.btnLoadQuery.Name = "btnLoadQuery";
            this.btnLoadQuery.Size = new System.Drawing.Size(140, 23);
            this.btnLoadQuery.TabIndex = 7;
            this.btnLoadQuery.Text = "Load Query";
            this.btnLoadQuery.UseVisualStyleBackColor = true;
            this.btnLoadQuery.Click += new System.EventHandler(this.btnLoadQuery_Click);
            // 
            // gbSortResults
            // 
            this.gbSortResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSortResults.Controls.Add(this.dgvSortFields);
            this.gbSortResults.Controls.Add(this.Label4);
            this.gbSortResults.Controls.Add(this.btnMoveOrderByFieldsUp);
            this.gbSortResults.Controls.Add(this.btnMoveOrderByFieldsDown);
            this.gbSortResults.Controls.Add(this.btnAddSortFields);
            this.gbSortResults.Controls.Add(this.btnRemoveSortFields);
            this.gbSortResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSortResults.Location = new System.Drawing.Point(4, 218);
            this.gbSortResults.Name = "gbSortResults";
            this.gbSortResults.Size = new System.Drawing.Size(489, 196);
            this.gbSortResults.TabIndex = 26;
            this.gbSortResults.TabStop = false;
            this.gbSortResults.Text = "Sort the Results into the Following Sequence:";
            // 
            // dgvSortFields
            // 
            this.dgvSortFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSortFields.Location = new System.Drawing.Point(152, 34);
            this.dgvSortFields.Name = "dgvSortFields";
            this.dgvSortFields.Size = new System.Drawing.Size(247, 151);
            this.dgvSortFields.TabIndex = 13;
            // 
            // Label4
            // 
            this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(407, 123);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(78, 65);
            this.Label4.TabIndex = 28;
            this.Label4.Text = "Tick Item in list to indicate reversed sort.";
            // 
            // btnMoveOrderByFieldsUp
            // 
            this.btnMoveOrderByFieldsUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveOrderByFieldsUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveOrderByFieldsUp.Location = new System.Drawing.Point(417, 34);
            this.btnMoveOrderByFieldsUp.MinimumSize = new System.Drawing.Size(40, 40);
            this.btnMoveOrderByFieldsUp.Name = "btnMoveOrderByFieldsUp";
            this.btnMoveOrderByFieldsUp.Size = new System.Drawing.Size(40, 40);
            this.btnMoveOrderByFieldsUp.TabIndex = 14;
            this.btnMoveOrderByFieldsUp.Text = "▲";
            this.btnMoveOrderByFieldsUp.UseVisualStyleBackColor = true;
            this.btnMoveOrderByFieldsUp.Click += new System.EventHandler(this.btnMoveOrderByFieldsUp_Click);
            // 
            // btnMoveOrderByFieldsDown
            // 
            this.btnMoveOrderByFieldsDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveOrderByFieldsDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveOrderByFieldsDown.Location = new System.Drawing.Point(417, 78);
            this.btnMoveOrderByFieldsDown.MinimumSize = new System.Drawing.Size(40, 40);
            this.btnMoveOrderByFieldsDown.Name = "btnMoveOrderByFieldsDown";
            this.btnMoveOrderByFieldsDown.Size = new System.Drawing.Size(40, 40);
            this.btnMoveOrderByFieldsDown.TabIndex = 15;
            this.btnMoveOrderByFieldsDown.Text = "▼";
            this.btnMoveOrderByFieldsDown.UseVisualStyleBackColor = true;
            this.btnMoveOrderByFieldsDown.Click += new System.EventHandler(this.btnMoveOrderByFieldsDown_Click);
            // 
            // btnAddSortFields
            // 
            this.btnAddSortFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSortFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSortFields.Location = new System.Drawing.Point(8, 34);
            this.btnAddSortFields.MinimumSize = new System.Drawing.Size(140, 0);
            this.btnAddSortFields.Name = "btnAddSortFields";
            this.btnAddSortFields.Size = new System.Drawing.Size(140, 23);
            this.btnAddSortFields.TabIndex = 11;
            this.btnAddSortFields.Text = "Add Sort Fields ↓";
            this.btnAddSortFields.UseVisualStyleBackColor = true;
            this.btnAddSortFields.Click += new System.EventHandler(this.btnAddSortFields_Click);
            // 
            // btnRemoveSortFields
            // 
            this.btnRemoveSortFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveSortFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSortFields.Location = new System.Drawing.Point(8, 63);
            this.btnRemoveSortFields.MinimumSize = new System.Drawing.Size(140, 0);
            this.btnRemoveSortFields.Name = "btnRemoveSortFields";
            this.btnRemoveSortFields.Size = new System.Drawing.Size(140, 23);
            this.btnRemoveSortFields.TabIndex = 12;
            this.btnRemoveSortFields.Text = "<- Remove ";
            this.btnRemoveSortFields.UseVisualStyleBackColor = true;
            this.btnRemoveSortFields.Click += new System.EventHandler(this.btnRemoveSortFields_Click);
            // 
            // gbExecutionOptions
            // 
            this.gbExecutionOptions.Controls.Add(this.label2);
            this.gbExecutionOptions.Controls.Add(this.txtFirstRows);
            this.gbExecutionOptions.Controls.Add(this.lblReturnFirst);
            this.gbExecutionOptions.Controls.Add(this.btnRunQuery);
            this.gbExecutionOptions.Controls.Add(this.btnShowSQL);
            this.gbExecutionOptions.Controls.Add(this.btnGenerateSQL);
            this.gbExecutionOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbExecutionOptions.Location = new System.Drawing.Point(514, 12);
            this.gbExecutionOptions.Name = "gbExecutionOptions";
            this.gbExecutionOptions.Size = new System.Drawing.Size(249, 200);
            this.gbExecutionOptions.TabIndex = 1;
            this.gbExecutionOptions.TabStop = false;
            this.gbExecutionOptions.Text = "Execution Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Rows";
            // 
            // txtFirstRows
            // 
            this.txtFirstRows.Location = new System.Drawing.Point(85, 139);
            this.txtFirstRows.Name = "txtFirstRows";
            this.txtFirstRows.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFirstRows.Size = new System.Drawing.Size(74, 20);
            this.txtFirstRows.TabIndex = 10;
            this.txtFirstRows.Text = "0";
            // 
            // lblReturnFirst
            // 
            this.lblReturnFirst.AutoSize = true;
            this.lblReturnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnFirst.Location = new System.Drawing.Point(8, 142);
            this.lblReturnFirst.Name = "lblReturnFirst";
            this.lblReturnFirst.Size = new System.Drawing.Size(77, 13);
            this.lblReturnFirst.TabIndex = 11;
            this.lblReturnFirst.Text = "Return First:";
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunQuery.Location = new System.Drawing.Point(58, 99);
            this.btnRunQuery.MinimumSize = new System.Drawing.Size(140, 0);
            this.btnRunQuery.Name = "btnRunQuery";
            this.btnRunQuery.Size = new System.Drawing.Size(140, 23);
            this.btnRunQuery.TabIndex = 9;
            this.btnRunQuery.Text = "Run Query";
            this.btnRunQuery.UseVisualStyleBackColor = true;
            this.btnRunQuery.Click += new System.EventHandler(this.btnRunQuery_Click);
            // 
            // btnShowSQL
            // 
            this.btnShowSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowSQL.Location = new System.Drawing.Point(58, 60);
            this.btnShowSQL.MinimumSize = new System.Drawing.Size(140, 0);
            this.btnShowSQL.Name = "btnShowSQL";
            this.btnShowSQL.Size = new System.Drawing.Size(140, 23);
            this.btnShowSQL.TabIndex = 8;
            this.btnShowSQL.Text = "Show SQL";
            this.btnShowSQL.UseVisualStyleBackColor = true;
            this.btnShowSQL.Click += new System.EventHandler(this.btnShowSQL_Click);
            // 
            // btnGenerateSQL
            // 
            this.btnGenerateSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateSQL.Location = new System.Drawing.Point(58, 25);
            this.btnGenerateSQL.MinimumSize = new System.Drawing.Size(140, 0);
            this.btnGenerateSQL.Name = "btnGenerateSQL";
            this.btnGenerateSQL.Size = new System.Drawing.Size(140, 23);
            this.btnGenerateSQL.TabIndex = 7;
            this.btnGenerateSQL.Text = "Generate SQL";
            this.btnGenerateSQL.UseVisualStyleBackColor = true;
            this.btnGenerateSQL.Click += new System.EventHandler(this.btnGenerateSQL_Click);
            // 
            // gbDisplayElements
            // 
            this.gbDisplayElements.Controls.Add(this.lblDataElementsLabel);
            this.gbDisplayElements.Controls.Add(this.btnMoveSelectedFieldsDown);
            this.gbDisplayElements.Controls.Add(this.dgvListFields);
            this.gbDisplayElements.Controls.Add(this.btnIncludeCount);
            this.gbDisplayElements.Controls.Add(this.btnRemoveSelectedFields);
            this.gbDisplayElements.Controls.Add(this.btnAddSelectedFields);
            this.gbDisplayElements.Controls.Add(this.btnMoveSelectedFieldsUP);
            this.gbDisplayElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDisplayElements.Location = new System.Drawing.Point(10, 12);
            this.gbDisplayElements.Name = "gbDisplayElements";
            this.gbDisplayElements.Size = new System.Drawing.Size(489, 200);
            this.gbDisplayElements.TabIndex = 0;
            this.gbDisplayElements.TabStop = false;
            this.gbDisplayElements.Text = "Data Elements to be Displayed:";
            // 
            // lblDataElementsLabel
            // 
            this.lblDataElementsLabel.Location = new System.Drawing.Point(405, 117);
            this.lblDataElementsLabel.Name = "lblDataElementsLabel";
            this.lblDataElementsLabel.Size = new System.Drawing.Size(78, 65);
            this.lblDataElementsLabel.TabIndex = 12;
            this.lblDataElementsLabel.Text = "Highlight item in list to move up or down with arrows.";
            // 
            // btnMoveSelectedFieldsDown
            // 
            this.btnMoveSelectedFieldsDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveSelectedFieldsDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveSelectedFieldsDown.Location = new System.Drawing.Point(417, 64);
            this.btnMoveSelectedFieldsDown.MinimumSize = new System.Drawing.Size(40, 40);
            this.btnMoveSelectedFieldsDown.Name = "btnMoveSelectedFieldsDown";
            this.btnMoveSelectedFieldsDown.Size = new System.Drawing.Size(40, 40);
            this.btnMoveSelectedFieldsDown.TabIndex = 11;
            this.btnMoveSelectedFieldsDown.Text = "▼";
            this.btnMoveSelectedFieldsDown.UseVisualStyleBackColor = true;
            this.btnMoveSelectedFieldsDown.Click += new System.EventHandler(this.btnMoveSelectedFieldsDown_Click);
            // 
            // dgvListFields
            // 
            this.dgvListFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListFields.Location = new System.Drawing.Point(152, 19);
            this.dgvListFields.Name = "dgvListFields";
            this.dgvListFields.Size = new System.Drawing.Size(247, 163);
            this.dgvListFields.TabIndex = 9;
            // 
            // btnIncludeCount
            // 
            this.btnIncludeCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncludeCount.Location = new System.Drawing.Point(8, 159);
            this.btnIncludeCount.MinimumSize = new System.Drawing.Size(140, 0);
            this.btnIncludeCount.Name = "btnIncludeCount";
            this.btnIncludeCount.Size = new System.Drawing.Size(140, 23);
            this.btnIncludeCount.TabIndex = 8;
            this.btnIncludeCount.Text = "Include Count(*) ->";
            this.btnIncludeCount.UseVisualStyleBackColor = true;
            this.btnIncludeCount.Click += new System.EventHandler(this.btnIncludeCount_Click);
            // 
            // btnRemoveSelectedFields
            // 
            this.btnRemoveSelectedFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveSelectedFields.Location = new System.Drawing.Point(8, 48);
            this.btnRemoveSelectedFields.MinimumSize = new System.Drawing.Size(140, 0);
            this.btnRemoveSelectedFields.Name = "btnRemoveSelectedFields";
            this.btnRemoveSelectedFields.Size = new System.Drawing.Size(140, 23);
            this.btnRemoveSelectedFields.TabIndex = 7;
            this.btnRemoveSelectedFields.Text = "<- Remove";
            this.btnRemoveSelectedFields.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedFields.Click += new System.EventHandler(this.btnRemoveSelectedFields_Click);
            // 
            // btnAddSelectedFields
            // 
            this.btnAddSelectedFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSelectedFields.Location = new System.Drawing.Point(8, 19);
            this.btnAddSelectedFields.MinimumSize = new System.Drawing.Size(140, 0);
            this.btnAddSelectedFields.Name = "btnAddSelectedFields";
            this.btnAddSelectedFields.Size = new System.Drawing.Size(140, 23);
            this.btnAddSelectedFields.TabIndex = 6;
            this.btnAddSelectedFields.Text = "Add Display Fields ->";
            this.btnAddSelectedFields.UseVisualStyleBackColor = true;
            this.btnAddSelectedFields.Click += new System.EventHandler(this.btnAddSelectedFields_Click);
            // 
            // btnMoveSelectedFieldsUP
            // 
            this.btnMoveSelectedFieldsUP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveSelectedFieldsUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveSelectedFieldsUP.Location = new System.Drawing.Point(417, 19);
            this.btnMoveSelectedFieldsUP.MinimumSize = new System.Drawing.Size(40, 40);
            this.btnMoveSelectedFieldsUP.Name = "btnMoveSelectedFieldsUP";
            this.btnMoveSelectedFieldsUP.Size = new System.Drawing.Size(40, 40);
            this.btnMoveSelectedFieldsUP.TabIndex = 10;
            this.btnMoveSelectedFieldsUP.Text = "▲";
            this.btnMoveSelectedFieldsUP.UseVisualStyleBackColor = true;
            this.btnMoveSelectedFieldsUP.Click += new System.EventHandler(this.btnMoveSelectedFieldsUP_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Conditions:";
            this.label5.Visible = false;
            // 
            // Form_SQLBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 758);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlTop);
            this.Name = "Form_SQLBuilder";
            this.Text = "Form_SQLBuilder";
            this.Load += new System.EventHandler(this.Form_SQLBuilder_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumnList)).EndInit();
            this.gbFilterRecords.ResumeLayout(false);
            this.gbFilterRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConditions)).EndInit();
            this.gbSaveOptions.ResumeLayout(false);
            this.gbSaveOptions.PerformLayout();
            this.gbSortResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSortFields)).EndInit();
            this.gbExecutionOptions.ResumeLayout(false);
            this.gbExecutionOptions.PerformLayout();
            this.gbDisplayElements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFields)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtDatasetName;
        private System.Windows.Forms.TextBox txtTablename;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTablename;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvColumnList;
        private System.Windows.Forms.GroupBox gbDisplayElements;
        internal System.Windows.Forms.Button btnMoveSelectedFieldsDown;
        internal System.Windows.Forms.Button btnMoveSelectedFieldsUP;
        private System.Windows.Forms.DataGridView dgvListFields;
        internal System.Windows.Forms.Button btnIncludeCount;
        internal System.Windows.Forms.Button btnRemoveSelectedFields;
        internal System.Windows.Forms.Button btnAddSelectedFields;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbExecutionOptions;
        private System.Windows.Forms.Label lblDataElementsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstRows;
        private System.Windows.Forms.Label lblReturnFirst;
        internal System.Windows.Forms.Button btnRunQuery;
        internal System.Windows.Forms.Button btnShowSQL;
        internal System.Windows.Forms.Button btnGenerateSQL;
        private System.Windows.Forms.GroupBox gbSaveOptions;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Button btnSaveQuery;
        internal System.Windows.Forms.Button btnEditQuery;
        internal System.Windows.Forms.Button btnLoadQuery;
        internal System.Windows.Forms.GroupBox gbSortResults;
        private System.Windows.Forms.DataGridView dgvSortFields;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnMoveOrderByFieldsUp;
        internal System.Windows.Forms.Button btnMoveOrderByFieldsDown;
        internal System.Windows.Forms.Button btnAddSortFields;
        internal System.Windows.Forms.Button btnRemoveSortFields;
        internal System.Windows.Forms.GroupBox gbFilterRecords;
        private System.Windows.Forms.DataGridView dgvConditions;
        internal System.Windows.Forms.TextBox txtEditCondition;
        internal System.Windows.Forms.Button btnEditCondition;
        internal System.Windows.Forms.TextBox txtINvalues;
        internal System.Windows.Forms.RadioButton rbOR;
        internal System.Windows.Forms.CheckBox cbIgnoreCase;
        internal System.Windows.Forms.RadioButton rbAND;
        internal System.Windows.Forms.DateTimePicker dtp2;
        internal System.Windows.Forms.Label lblFilterRecords;
        internal System.Windows.Forms.Label lblValue2;
        internal System.Windows.Forms.Button btnAddCondition;
        internal System.Windows.Forms.Button btnRemoveCondition;
        internal System.Windows.Forms.DateTimePicker dtp1;
        internal System.Windows.Forms.ComboBox cboWhereFields;
        internal System.Windows.Forms.TextBox txtOperator;
        internal System.Windows.Forms.TextBox txtValue2;
        internal System.Windows.Forms.ComboBox cboOperators;
        internal System.Windows.Forms.Label lblOperator;
        internal System.Windows.Forms.Label lblColumn;
        internal System.Windows.Forms.TextBox txtValue;
        internal System.Windows.Forms.Label label5;
    }
}