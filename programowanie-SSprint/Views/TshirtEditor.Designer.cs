namespace programowanie_SSprint.Views
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
            this.btnApply = new System.Windows.Forms.Button();
            this.lCompany = new System.Windows.Forms.Label();
            this.lSex = new System.Windows.Forms.Label();
            this.lModel = new System.Windows.Forms.Label();
            this.lColor = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.lInStock = new System.Windows.Forms.Label();
            this.lReserved = new System.Windows.Forms.Label();
            this.numInStock = new System.Windows.Forms.NumericUpDown();
            this.numReserved = new System.Windows.Forms.NumericUpDown();
            this.numAvailable = new System.Windows.Forms.NumericUpDown();
            this.lAvailable = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbTshirtProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReserved)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
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
            this.treeViewProductBrowser.Size = new System.Drawing.Size(525, 294);
            this.treeViewProductBrowser.TabIndex = 1;
            // 
            // gbTshirtProperties
            // 
            this.gbTshirtProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTshirtProperties.Controls.Add(this.numId);
            this.gbTshirtProperties.Controls.Add(this.lId);
            this.gbTshirtProperties.Controls.Add(this.numAvailable);
            this.gbTshirtProperties.Controls.Add(this.lAvailable);
            this.gbTshirtProperties.Controls.Add(this.numReserved);
            this.gbTshirtProperties.Controls.Add(this.numInStock);
            this.gbTshirtProperties.Controls.Add(this.lReserved);
            this.gbTshirtProperties.Controls.Add(this.lInStock);
            this.gbTshirtProperties.Controls.Add(this.comboBoxCompany);
            this.gbTshirtProperties.Controls.Add(this.comboBoxSex);
            this.gbTshirtProperties.Controls.Add(this.comboBoxColor);
            this.gbTshirtProperties.Controls.Add(this.tbModel);
            this.gbTshirtProperties.Controls.Add(this.lColor);
            this.gbTshirtProperties.Controls.Add(this.lModel);
            this.gbTshirtProperties.Controls.Add(this.lSex);
            this.gbTshirtProperties.Controls.Add(this.lCompany);
            this.gbTshirtProperties.Location = new System.Drawing.Point(543, 12);
            this.gbTshirtProperties.Name = "gbTshirtProperties";
            this.gbTshirtProperties.Size = new System.Drawing.Size(229, 266);
            this.gbTshirtProperties.TabIndex = 2;
            this.gbTshirtProperties.TabStop = false;
            this.gbTshirtProperties.Text = "Właściwości koszulki";
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(697, 284);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Dodaj nową";
            this.btnApply.UseVisualStyleBackColor = true;
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
            // lSex
            // 
            this.lSex.AutoSize = true;
            this.lSex.Location = new System.Drawing.Point(7, 48);
            this.lSex.Name = "lSex";
            this.lSex.Size = new System.Drawing.Size(30, 13);
            this.lSex.TabIndex = 1;
            this.lSex.Text = "Płeć";
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
            // lColor
            // 
            this.lColor.AutoSize = true;
            this.lColor.Location = new System.Drawing.Point(7, 104);
            this.lColor.Name = "lColor";
            this.lColor.Size = new System.Drawing.Size(31, 13);
            this.lColor.TabIndex = 3;
            this.lColor.Text = "Kolor";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(49, 72);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(167, 20);
            this.tbModel.TabIndex = 4;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(49, 101);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(167, 21);
            this.comboBoxColor.TabIndex = 5;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Location = new System.Drawing.Point(49, 45);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(167, 21);
            this.comboBoxSex.TabIndex = 6;
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(49, 17);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(167, 21);
            this.comboBoxCompany.TabIndex = 7;
            // 
            // lInStock
            // 
            this.lInStock.AutoSize = true;
            this.lInStock.Location = new System.Drawing.Point(7, 136);
            this.lInStock.Name = "lInStock";
            this.lInStock.Size = new System.Drawing.Size(71, 13);
            this.lInStock.TabIndex = 8;
            this.lInStock.Text = "W magazynie";
            // 
            // lReserved
            // 
            this.lReserved.AutoSize = true;
            this.lReserved.Location = new System.Drawing.Point(7, 164);
            this.lReserved.Name = "lReserved";
            this.lReserved.Size = new System.Drawing.Size(83, 13);
            this.lReserved.TabIndex = 9;
            this.lReserved.Text = "Zarezerwowane";
            // 
            // numInStock
            // 
            this.numInStock.Location = new System.Drawing.Point(96, 134);
            this.numInStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numInStock.Name = "numInStock";
            this.numInStock.Size = new System.Drawing.Size(120, 20);
            this.numInStock.TabIndex = 10;
            // 
            // numReserved
            // 
            this.numReserved.Location = new System.Drawing.Point(96, 162);
            this.numReserved.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numReserved.Name = "numReserved";
            this.numReserved.ReadOnly = true;
            this.numReserved.Size = new System.Drawing.Size(120, 20);
            this.numReserved.TabIndex = 11;
            // 
            // numAvailable
            // 
            this.numAvailable.Location = new System.Drawing.Point(96, 192);
            this.numAvailable.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numAvailable.Name = "numAvailable";
            this.numAvailable.ReadOnly = true;
            this.numAvailable.Size = new System.Drawing.Size(120, 20);
            this.numAvailable.TabIndex = 13;
            // 
            // lAvailable
            // 
            this.lAvailable.AutoSize = true;
            this.lAvailable.Location = new System.Drawing.Point(7, 194);
            this.lAvailable.Name = "lAvailable";
            this.lAvailable.Size = new System.Drawing.Size(53, 13);
            this.lAvailable.TabIndex = 12;
            this.lAvailable.Text = "Dostępne";
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(7, 227);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(52, 13);
            this.lId.TabIndex = 14;
            this.lId.Text = "Numer ID";
            // 
            // numId
            // 
            this.numId.Location = new System.Drawing.Point(96, 225);
            this.numId.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numId.Name = "numId";
            this.numId.ReadOnly = true;
            this.numId.Size = new System.Drawing.Size(120, 20);
            this.numId.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(543, 284);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // TshirtEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 313);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.gbTshirtProperties);
            this.Controls.Add(this.treeViewProductBrowser);
            this.MinimumSize = new System.Drawing.Size(450, 352);
            this.Name = "TshirtEditor";
            this.Text = "Edytor koszulek w magazynie";
            this.gbTshirtProperties.ResumeLayout(false);
            this.gbTshirtProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReserved)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
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
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label lColor;
        private System.Windows.Forms.NumericUpDown numAvailable;
        private System.Windows.Forms.Label lAvailable;
        private System.Windows.Forms.NumericUpDown numReserved;
        private System.Windows.Forms.NumericUpDown numInStock;
        private System.Windows.Forms.Label lReserved;
        private System.Windows.Forms.Label lInStock;
        private System.Windows.Forms.NumericUpDown numId;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Button btnDelete;
    }
}