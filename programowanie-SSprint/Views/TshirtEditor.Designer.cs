namespace programowanie_SSprint
{
    partial class TshirtEditor
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("S (dostępne: 530) 20zł");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("M (dostępne: 13) 25zł");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("L (dostępne: 51) 27zł");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Męski", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("S (dostępne: 10) 18zł");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("M (dostępne: 64) 21zł");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Damski", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("L (dostępne: 11) 20zł");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("XXL (dostepne: 3) 35zł");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Unisex", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Model A", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Męski");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("T-shirt", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Unisex");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Koszulka Polo", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Firma A", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode13,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Model A");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Bluza");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Firma B", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Model C");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Firma C", new System.Windows.Forms.TreeNode[] {
            treeNode20});
            this.treeViewProductBrowser = new System.Windows.Forms.TreeView();
            this.gbTshirtProperties = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ldefaultLoss2 = new System.Windows.Forms.Label();
            this.btnApplyChanges = new System.Windows.Forms.Button();
            this.numericDefaultLoss = new System.Windows.Forms.NumericUpDown();
            this.ldefaultLoss1 = new System.Windows.Forms.Label();
            this.lSize = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbAvailable = new System.Windows.Forms.TextBox();
            this.tbReserved = new System.Windows.Forms.TextBox();
            this.lId = new System.Windows.Forms.Label();
            this.lAvailable = new System.Windows.Forms.Label();
            this.numInStock = new System.Windows.Forms.NumericUpDown();
            this.lReserved = new System.Windows.Forms.Label();
            this.lInStock = new System.Windows.Forms.Label();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.lColor = new System.Windows.Forms.Label();
            this.lModel = new System.Windows.Forms.Label();
            this.lSex = new System.Windows.Forms.Label();
            this.lCompany = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.gbTshirtProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDefaultLoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInStock)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewProductBrowser
            // 
            this.treeViewProductBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewProductBrowser.Location = new System.Drawing.Point(12, 12);
            this.treeViewProductBrowser.Name = "treeViewProductBrowser";
            treeNode1.Name = "Node15";
            treeNode1.Text = "S (dostępne: 530) 20zł";
            treeNode2.Name = "Node16";
            treeNode2.Text = "M (dostępne: 13) 25zł";
            treeNode3.Name = "Node17";
            treeNode3.Text = "L (dostępne: 51) 27zł";
            treeNode4.Name = "Node10";
            treeNode4.Text = "Męski";
            treeNode5.Name = "Node18";
            treeNode5.Text = "S (dostępne: 10) 18zł";
            treeNode6.Name = "Node19";
            treeNode6.Text = "M (dostępne: 64) 21zł";
            treeNode7.Name = "Node13";
            treeNode7.Text = "Damski";
            treeNode8.Name = "Node20";
            treeNode8.Text = "L (dostępne: 11) 20zł";
            treeNode9.Name = "Node21";
            treeNode9.Text = "XXL (dostepne: 3) 35zł";
            treeNode10.Name = "Node14";
            treeNode10.Text = "Unisex";
            treeNode11.Name = "Node3";
            treeNode11.Text = "Model A";
            treeNode12.Name = "Node11";
            treeNode12.Text = "Męski";
            treeNode13.Name = "Node5";
            treeNode13.Text = "T-shirt";
            treeNode14.Name = "Node12";
            treeNode14.Text = "Unisex";
            treeNode15.Name = "Node6";
            treeNode15.Text = "Koszulka Polo";
            treeNode16.Name = "Node0";
            treeNode16.Text = "Firma A";
            treeNode17.Name = "Node7";
            treeNode17.Text = "Model A";
            treeNode18.Name = "Node8";
            treeNode18.Text = "Bluza";
            treeNode19.Name = "Node1";
            treeNode19.Text = "Firma B";
            treeNode20.Name = "Node9";
            treeNode20.Text = "Model C";
            treeNode21.Name = "Node2";
            treeNode21.Text = "Firma C";
            this.treeViewProductBrowser.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode19,
            treeNode21});
            this.treeViewProductBrowser.Size = new System.Drawing.Size(325, 430);
            this.treeViewProductBrowser.TabIndex = 1;
            this.treeViewProductBrowser.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewProductBrowser_AfterSelect);
            // 
            // gbTshirtProperties
            // 
            this.gbTshirtProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTshirtProperties.Controls.Add(this.comboBoxModel);
            this.gbTshirtProperties.Controls.Add(this.btnCancel);
            this.gbTshirtProperties.Controls.Add(this.ldefaultLoss2);
            this.gbTshirtProperties.Controls.Add(this.btnApplyChanges);
            this.gbTshirtProperties.Controls.Add(this.numericDefaultLoss);
            this.gbTshirtProperties.Controls.Add(this.ldefaultLoss1);
            this.gbTshirtProperties.Controls.Add(this.comboBoxSize);
            this.gbTshirtProperties.Controls.Add(this.lSize);
            this.gbTshirtProperties.Controls.Add(this.tbId);
            this.gbTshirtProperties.Controls.Add(this.tbAvailable);
            this.gbTshirtProperties.Controls.Add(this.tbReserved);
            this.gbTshirtProperties.Controls.Add(this.lId);
            this.gbTshirtProperties.Controls.Add(this.lAvailable);
            this.gbTshirtProperties.Controls.Add(this.numInStock);
            this.gbTshirtProperties.Controls.Add(this.lReserved);
            this.gbTshirtProperties.Controls.Add(this.lInStock);
            this.gbTshirtProperties.Controls.Add(this.comboBoxCompany);
            this.gbTshirtProperties.Controls.Add(this.comboBoxSex);
            this.gbTshirtProperties.Controls.Add(this.comboBoxColor);
            this.gbTshirtProperties.Controls.Add(this.lColor);
            this.gbTshirtProperties.Controls.Add(this.lModel);
            this.gbTshirtProperties.Controls.Add(this.lSex);
            this.gbTshirtProperties.Controls.Add(this.lCompany);
            this.gbTshirtProperties.Location = new System.Drawing.Point(343, 12);
            this.gbTshirtProperties.Name = "gbTshirtProperties";
            this.gbTshirtProperties.Size = new System.Drawing.Size(229, 386);
            this.gbTshirtProperties.TabIndex = 2;
            this.gbTshirtProperties.TabStop = false;
            this.gbTshirtProperties.Text = "Właściwości koszulki";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(10, 325);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(213, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // ldefaultLoss2
            // 
            this.ldefaultLoss2.AutoSize = true;
            this.ldefaultLoss2.Location = new System.Drawing.Point(7, 177);
            this.ldefaultLoss2.Name = "ldefaultLoss2";
            this.ldefaultLoss2.Size = new System.Drawing.Size(62, 13);
            this.ldefaultLoss2.TabIndex = 22;
            this.ldefaultLoss2.Text = "nieudanych";
            // 
            // btnApplyChanges
            // 
            this.btnApplyChanges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyChanges.BackColor = System.Drawing.Color.LightGreen;
            this.btnApplyChanges.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApplyChanges.Location = new System.Drawing.Point(10, 354);
            this.btnApplyChanges.Name = "btnApplyChanges";
            this.btnApplyChanges.Size = new System.Drawing.Size(213, 23);
            this.btnApplyChanges.TabIndex = 10;
            this.btnApplyChanges.Text = "Zapisz zmiany";
            this.btnApplyChanges.UseVisualStyleBackColor = false;
            // 
            // numericDefaultLoss
            // 
            this.numericDefaultLoss.Location = new System.Drawing.Point(96, 175);
            this.numericDefaultLoss.Name = "numericDefaultLoss";
            this.numericDefaultLoss.Size = new System.Drawing.Size(120, 20);
            this.numericDefaultLoss.TabIndex = 21;
            // 
            // ldefaultLoss1
            // 
            this.ldefaultLoss1.AutoSize = true;
            this.ldefaultLoss1.Location = new System.Drawing.Point(6, 164);
            this.ldefaultLoss1.Name = "ldefaultLoss1";
            this.ldefaultLoss1.Size = new System.Drawing.Size(63, 13);
            this.ldefaultLoss1.TabIndex = 20;
            this.ldefaultLoss1.Text = "Domyślny %";
            // 
            // lSize
            // 
            this.lSize.AutoSize = true;
            this.lSize.Location = new System.Drawing.Point(6, 131);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(45, 13);
            this.lSize.TabIndex = 18;
            this.lSize.Text = "Rozmiar";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(96, 291);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(120, 20);
            this.tbId.TabIndex = 17;
            // 
            // tbAvailable
            // 
            this.tbAvailable.Location = new System.Drawing.Point(96, 258);
            this.tbAvailable.Name = "tbAvailable";
            this.tbAvailable.ReadOnly = true;
            this.tbAvailable.Size = new System.Drawing.Size(120, 20);
            this.tbAvailable.TabIndex = 16;
            // 
            // tbReserved
            // 
            this.tbReserved.Location = new System.Drawing.Point(96, 228);
            this.tbReserved.Name = "tbReserved";
            this.tbReserved.ReadOnly = true;
            this.tbReserved.Size = new System.Drawing.Size(120, 20);
            this.tbReserved.TabIndex = 15;
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(7, 294);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(52, 13);
            this.lId.TabIndex = 14;
            this.lId.Text = "Numer ID";
            // 
            // lAvailable
            // 
            this.lAvailable.AutoSize = true;
            this.lAvailable.Location = new System.Drawing.Point(7, 261);
            this.lAvailable.Name = "lAvailable";
            this.lAvailable.Size = new System.Drawing.Size(53, 13);
            this.lAvailable.TabIndex = 12;
            this.lAvailable.Text = "Dostępne";
            // 
            // numInStock
            // 
            this.numInStock.Location = new System.Drawing.Point(96, 201);
            this.numInStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numInStock.Name = "numInStock";
            this.numInStock.Size = new System.Drawing.Size(120, 20);
            this.numInStock.TabIndex = 10;
            // 
            // lReserved
            // 
            this.lReserved.AutoSize = true;
            this.lReserved.Location = new System.Drawing.Point(7, 231);
            this.lReserved.Name = "lReserved";
            this.lReserved.Size = new System.Drawing.Size(83, 13);
            this.lReserved.TabIndex = 9;
            this.lReserved.Text = "Zarezerwowane";
            // 
            // lInStock
            // 
            this.lInStock.AutoSize = true;
            this.lInStock.Location = new System.Drawing.Point(7, 203);
            this.lInStock.Name = "lInStock";
            this.lInStock.Size = new System.Drawing.Size(71, 13);
            this.lInStock.TabIndex = 8;
            this.lInStock.Text = "W magazynie";
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(49, 17);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(167, 21);
            this.comboBoxCompany.TabIndex = 7;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Męska",
            "Żeńska",
            "Unisex"});
            this.comboBoxSex.Location = new System.Drawing.Point(49, 45);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(167, 21);
            this.comboBoxSex.TabIndex = 6;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(49, 101);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(167, 21);
            this.comboBoxColor.TabIndex = 5;
            // 
            // lColor
            // 
            this.lColor.AutoSize = true;
            this.lColor.Location = new System.Drawing.Point(7, 104);
            this.lColor.Name = "lColor";
            this.lColor.Size = new System.Drawing.Size(31, 13);
            this.lColor.TabIndex = 3;
            this.lColor.Text = "Kolor";
            // 
            // lModel
            // 
            this.lModel.AutoSize = true;
            this.lModel.Location = new System.Drawing.Point(7, 75);
            this.lModel.Name = "lModel";
            this.lModel.Size = new System.Drawing.Size(36, 13);
            this.lModel.TabIndex = 2;
            this.lModel.Text = "Model";
            // 
            // lSex
            // 
            this.lSex.AutoSize = true;
            this.lSex.Location = new System.Drawing.Point(7, 48);
            this.lSex.Name = "lSex";
            this.lSex.Size = new System.Drawing.Size(30, 13);
            this.lSex.TabIndex = 1;
            this.lSex.Text = "Płeć";
            // 
            // lCompany
            // 
            this.lCompany.AutoSize = true;
            this.lCompany.Location = new System.Drawing.Point(7, 20);
            this.lCompany.Name = "lCompany";
            this.lCompany.Size = new System.Drawing.Size(32, 13);
            this.lCompany.TabIndex = 0;
            this.lCompany.Text = "Firma";
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.BackColor = System.Drawing.Color.SkyBlue;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApply.Location = new System.Drawing.Point(497, 420);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Dodaj nową";
            this.btnApply.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(343, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.comboBoxSize.Location = new System.Drawing.Point(49, 128);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(167, 21);
            this.comboBoxSize.TabIndex = 19;
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Items.AddRange(new object[] {
            "Męska",
            "Żeńska",
            "Unisex"});
            this.comboBoxModel.Location = new System.Drawing.Point(49, 74);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(167, 21);
            this.comboBoxModel.TabIndex = 23;
            // 
            // TshirtEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 449);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.gbTshirtProperties);
            this.Controls.Add(this.treeViewProductBrowser);
            this.MinimumSize = new System.Drawing.Size(450, 352);
            this.Name = "TshirtEditor";
            this.Text = "Edytor koszulek w magazynie";
            this.Load += new System.EventHandler(this.TshirtEditor_Load);
            this.gbTshirtProperties.ResumeLayout(false);
            this.gbTshirtProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDefaultLoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewProductBrowser;
        private System.Windows.Forms.GroupBox gbTshirtProperties;
        private System.Windows.Forms.Label lModel;
        private System.Windows.Forms.Label lSex;
        private System.Windows.Forms.Label lCompany;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label lColor;
        private System.Windows.Forms.Label lAvailable;
        private System.Windows.Forms.NumericUpDown numInStock;
        private System.Windows.Forms.Label lReserved;
        private System.Windows.Forms.Label lInStock;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbAvailable;
        private System.Windows.Forms.TextBox tbReserved;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.Label ldefaultLoss2;
        private System.Windows.Forms.NumericUpDown numericDefaultLoss;
        private System.Windows.Forms.Label ldefaultLoss1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApplyChanges;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.ComboBox comboBoxModel;
    }
}