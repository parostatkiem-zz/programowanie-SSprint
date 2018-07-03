﻿namespace programowanie_SSprint
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
     

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("S (dostępne: 530) 20zł");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("M (dostępne: 13) 25zł");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("L (dostępne: 51) 27zł");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Męski", new System.Windows.Forms.TreeNode[] {
            treeNode64,
            treeNode65,
            treeNode66});
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("S (dostępne: 10) 18zł");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("M (dostępne: 64) 21zł");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Damski", new System.Windows.Forms.TreeNode[] {
            treeNode68,
            treeNode69});
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("L (dostępne: 11) 20zł");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("XXL (dostepne: 3) 35zł");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Unisex", new System.Windows.Forms.TreeNode[] {
            treeNode71,
            treeNode72});
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("Model A", new System.Windows.Forms.TreeNode[] {
            treeNode67,
            treeNode70,
            treeNode73});
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("Męski");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("T-shirt", new System.Windows.Forms.TreeNode[] {
            treeNode75});
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("Unisex");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("Koszulka Polo", new System.Windows.Forms.TreeNode[] {
            treeNode77});
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("Firma A", new System.Windows.Forms.TreeNode[] {
            treeNode74,
            treeNode76,
            treeNode78});
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Model A");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("Bluza");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Firma B", new System.Windows.Forms.TreeNode[] {
            treeNode80,
            treeNode81});
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("Model C");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Firma C", new System.Windows.Forms.TreeNode[] {
            treeNode83});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerHorizLeft = new System.Windows.Forms.SplitContainer();
            this.panelProductSelector = new System.Windows.Forms.Panel();
            this.numericAddingProductAmount = new System.Windows.Forms.NumericUpDown();
            this.btnAddProductToOrder = new System.Windows.Forms.Button();
            this.treeViewProductBrowser = new System.Windows.Forms.TreeView();
            this.lvOrderedProducts = new System.Windows.Forms.ListView();
            this.columnCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStyle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnReserved = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnActions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddNew = new System.Windows.Forms.Button();
            this.gbSelectedOrderParams = new System.Windows.Forms.GroupBox();
            this.numClientPrice = new System.Windows.Forms.NumericUpDown();
            this.btnCurrentOrderCancel = new System.Windows.Forms.Button();
            this.btnSelectedOrderSave = new System.Windows.Forms.Button();
            this.lClientPrice = new System.Windows.Forms.Label();
            this.comboBoxSelectedOrderStatus = new System.Windows.Forms.ComboBox();
            this.lSelectedOrderStatus = new System.Windows.Forms.Label();
            this.lSelectedOrderStartDate = new System.Windows.Forms.Label();
            this.lSelectedOrderEndDate = new System.Windows.Forms.Label();
            this.btnSelectedOrderBrowseImage = new System.Windows.Forms.Button();
            this.lSelectedOrderImage = new System.Windows.Forms.Label();
            this.pictureBoxSelectedOrderImage = new System.Windows.Forms.PictureBox();
            this.gbSelectedOrderData = new System.Windows.Forms.GroupBox();
            this.tbSelectedOrderPhone = new System.Windows.Forms.TextBox();
            this.tbSelectedOrderName = new System.Windows.Forms.TextBox();
            this.tbSelectedOrderEmail = new System.Windows.Forms.TextBox();
            this.lSelectedOrderName = new System.Windows.Forms.Label();
            this.lSelectedOrderEmail = new System.Windows.Forms.Label();
            this.lSelectedOrderPhone = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lvAllOrders = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTypes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProfit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lCopyright = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tshirtsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stylesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHorizLeft)).BeginInit();
            this.splitContainerHorizLeft.Panel1.SuspendLayout();
            this.splitContainerHorizLeft.Panel2.SuspendLayout();
            this.splitContainerHorizLeft.SuspendLayout();
            this.panelProductSelector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAddingProductAmount)).BeginInit();
            this.gbSelectedOrderParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numClientPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedOrderImage)).BeginInit();
            this.gbSelectedOrderData.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 26);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainerHorizLeft);
            this.splitContainerMain.Panel1MinSize = 420;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.btnAddNew);
            this.splitContainerMain.Panel2.Controls.Add(this.gbSelectedOrderParams);
            this.splitContainerMain.Panel2.Controls.Add(this.btnDelete);
            this.splitContainerMain.Panel2.Controls.Add(this.lvAllOrders);
            this.splitContainerMain.Panel2MinSize = 420;
            this.splitContainerMain.Size = new System.Drawing.Size(1077, 558);
            this.splitContainerMain.SplitterDistance = 544;
            this.splitContainerMain.TabIndex = 0;
            // 
            // splitContainerHorizLeft
            // 
            this.splitContainerHorizLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerHorizLeft.Location = new System.Drawing.Point(0, 0);
            this.splitContainerHorizLeft.Name = "splitContainerHorizLeft";
            this.splitContainerHorizLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerHorizLeft.Panel1
            // 
            this.splitContainerHorizLeft.Panel1.Controls.Add(this.panelProductSelector);
            this.splitContainerHorizLeft.Panel1.Controls.Add(this.treeViewProductBrowser);
            // 
            // splitContainerHorizLeft.Panel2
            // 
            this.splitContainerHorizLeft.Panel2.Controls.Add(this.lvOrderedProducts);
            this.splitContainerHorizLeft.Size = new System.Drawing.Size(542, 556);
            this.splitContainerHorizLeft.SplitterDistance = 311;
            this.splitContainerHorizLeft.TabIndex = 1;
            // 
            // panelProductSelector
            // 
            this.panelProductSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProductSelector.Controls.Add(this.numericAddingProductAmount);
            this.panelProductSelector.Controls.Add(this.btnAddProductToOrder);
            this.panelProductSelector.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelProductSelector.Location = new System.Drawing.Point(0, 279);
            this.panelProductSelector.Name = "panelProductSelector";
            this.panelProductSelector.Size = new System.Drawing.Size(542, 32);
            this.panelProductSelector.TabIndex = 1;
            // 
            // numericAddingProductAmount
            // 
            this.numericAddingProductAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericAddingProductAmount.BackColor = System.Drawing.Color.Cornsilk;
            this.numericAddingProductAmount.Location = new System.Drawing.Point(152, 5);
            this.numericAddingProductAmount.Name = "numericAddingProductAmount";
            this.numericAddingProductAmount.Size = new System.Drawing.Size(51, 20);
            this.numericAddingProductAmount.TabIndex = 0;
            // 
            // btnAddProductToOrder
            // 
            this.btnAddProductToOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddProductToOrder.BackColor = System.Drawing.Color.Cornsilk;
            this.btnAddProductToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProductToOrder.Location = new System.Drawing.Point(3, 3);
            this.btnAddProductToOrder.Name = "btnAddProductToOrder";
            this.btnAddProductToOrder.Size = new System.Drawing.Size(142, 23);
            this.btnAddProductToOrder.TabIndex = 1;
            this.btnAddProductToOrder.Text = "Dodaj do puli zamówienia";
            this.btnAddProductToOrder.UseVisualStyleBackColor = false;
            // 
            // treeViewProductBrowser
            // 
            this.treeViewProductBrowser.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeViewProductBrowser.Location = new System.Drawing.Point(0, 0);
            this.treeViewProductBrowser.Name = "treeViewProductBrowser";
            treeNode64.Name = "Node15";
            treeNode64.Text = "S (dostępne: 530) 20zł";
            treeNode65.Name = "Node16";
            treeNode65.Text = "M (dostępne: 13) 25zł";
            treeNode66.Name = "Node17";
            treeNode66.Text = "L (dostępne: 51) 27zł";
            treeNode67.Name = "Node10";
            treeNode67.Text = "Męski";
            treeNode68.Name = "Node18";
            treeNode68.Text = "S (dostępne: 10) 18zł";
            treeNode69.Name = "Node19";
            treeNode69.Text = "M (dostępne: 64) 21zł";
            treeNode70.Name = "Node13";
            treeNode70.Text = "Damski";
            treeNode71.Name = "Node20";
            treeNode71.Text = "L (dostępne: 11) 20zł";
            treeNode72.Name = "Node21";
            treeNode72.Text = "XXL (dostepne: 3) 35zł";
            treeNode73.Name = "Node14";
            treeNode73.Text = "Unisex";
            treeNode74.Name = "Node3";
            treeNode74.Text = "Model A";
            treeNode75.Name = "Node11";
            treeNode75.Text = "Męski";
            treeNode76.Name = "Node5";
            treeNode76.Text = "T-shirt";
            treeNode77.Name = "Node12";
            treeNode77.Text = "Unisex";
            treeNode78.Name = "Node6";
            treeNode78.Text = "Koszulka Polo";
            treeNode79.Name = "Node0";
            treeNode79.Text = "Firma A";
            treeNode80.Name = "Node7";
            treeNode80.Text = "Model A";
            treeNode81.Name = "Node8";
            treeNode81.Text = "Bluza";
            treeNode82.Name = "Node1";
            treeNode82.Text = "Firma B";
            treeNode83.Name = "Node9";
            treeNode83.Text = "Model C";
            treeNode84.Name = "Node2";
            treeNode84.Text = "Firma C";
            this.treeViewProductBrowser.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode79,
            treeNode82,
            treeNode84});
            this.treeViewProductBrowser.Size = new System.Drawing.Size(542, 315);
            this.treeViewProductBrowser.TabIndex = 0;
            // 
            // lvOrderedProducts
            // 
            this.lvOrderedProducts.BackColor = System.Drawing.Color.Cornsilk;
            this.lvOrderedProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCompany,
            this.columnStyle,
            this.columnSex,
            this.columnColor,
            this.columnAmount,
            this.columnReserved,
            this.columnActions});
            this.lvOrderedProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvOrderedProducts.FullRowSelect = true;
            this.lvOrderedProducts.GridLines = true;
            this.lvOrderedProducts.Location = new System.Drawing.Point(0, 0);
            this.lvOrderedProducts.Name = "lvOrderedProducts";
            this.lvOrderedProducts.Size = new System.Drawing.Size(542, 241);
            this.lvOrderedProducts.TabIndex = 0;
            this.lvOrderedProducts.UseCompatibleStateImageBehavior = false;
            this.lvOrderedProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnCompany
            // 
            this.columnCompany.Text = "Firma";
            // 
            // columnStyle
            // 
            this.columnStyle.Text = "Styl";
            // 
            // columnSex
            // 
            this.columnSex.Text = "Płeć";
            // 
            // columnColor
            // 
            this.columnColor.Text = "Kolor";
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Ilość";
            // 
            // columnReserved
            // 
            this.columnReserved.DisplayIndex = 6;
            this.columnReserved.Text = "Rezerwacja";
            // 
            // columnActions
            // 
            this.columnActions.DisplayIndex = 5;
            this.columnActions.Text = "Akcje";
            this.columnActions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnActions.Width = 121;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddNew.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Location = new System.Drawing.Point(3, 530);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(133, 23);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Dodaj zamówienie";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // gbSelectedOrderParams
            // 
            this.gbSelectedOrderParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSelectedOrderParams.BackColor = System.Drawing.Color.Transparent;
            this.gbSelectedOrderParams.Controls.Add(this.dateTimeEnd);
            this.gbSelectedOrderParams.Controls.Add(this.dateTimeBegin);
            this.gbSelectedOrderParams.Controls.Add(this.numClientPrice);
            this.gbSelectedOrderParams.Controls.Add(this.btnCurrentOrderCancel);
            this.gbSelectedOrderParams.Controls.Add(this.btnSelectedOrderSave);
            this.gbSelectedOrderParams.Controls.Add(this.lClientPrice);
            this.gbSelectedOrderParams.Controls.Add(this.comboBoxSelectedOrderStatus);
            this.gbSelectedOrderParams.Controls.Add(this.lSelectedOrderStatus);
            this.gbSelectedOrderParams.Controls.Add(this.lSelectedOrderStartDate);
            this.gbSelectedOrderParams.Controls.Add(this.lSelectedOrderEndDate);
            this.gbSelectedOrderParams.Controls.Add(this.btnSelectedOrderBrowseImage);
            this.gbSelectedOrderParams.Controls.Add(this.lSelectedOrderImage);
            this.gbSelectedOrderParams.Controls.Add(this.pictureBoxSelectedOrderImage);
            this.gbSelectedOrderParams.Controls.Add(this.gbSelectedOrderData);
            this.gbSelectedOrderParams.Location = new System.Drawing.Point(3, 265);
            this.gbSelectedOrderParams.Name = "gbSelectedOrderParams";
            this.gbSelectedOrderParams.Size = new System.Drawing.Size(521, 259);
            this.gbSelectedOrderParams.TabIndex = 7;
            this.gbSelectedOrderParams.TabStop = false;
            this.gbSelectedOrderParams.Text = "Parametry zamówienia";
            // 
            // numClientPrice
            // 
            this.numClientPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numClientPrice.Location = new System.Drawing.Point(397, 186);
            this.numClientPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numClientPrice.Name = "numClientPrice";
            this.numClientPrice.Size = new System.Drawing.Size(120, 20);
            this.numClientPrice.TabIndex = 455;
            // 
            // btnCurrentOrderCancel
            // 
            this.btnCurrentOrderCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCurrentOrderCancel.BackColor = System.Drawing.Color.Salmon;
            this.btnCurrentOrderCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentOrderCancel.Location = new System.Drawing.Point(40, 227);
            this.btnCurrentOrderCancel.Name = "btnCurrentOrderCancel";
            this.btnCurrentOrderCancel.Size = new System.Drawing.Size(181, 23);
            this.btnCurrentOrderCancel.TabIndex = 1;
            this.btnCurrentOrderCancel.Text = "Anuluj / Wyczyść ";
            this.btnCurrentOrderCancel.UseVisualStyleBackColor = false;
            this.btnCurrentOrderCancel.Click += new System.EventHandler(this.btnCurrentOrderCancel_Click);
            // 
            // btnSelectedOrderSave
            // 
            this.btnSelectedOrderSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectedOrderSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSelectedOrderSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectedOrderSave.Location = new System.Drawing.Point(296, 227);
            this.btnSelectedOrderSave.Name = "btnSelectedOrderSave";
            this.btnSelectedOrderSave.Size = new System.Drawing.Size(172, 23);
            this.btnSelectedOrderSave.TabIndex = 0;
            this.btnSelectedOrderSave.Text = "Zapisz zmiany";
            this.btnSelectedOrderSave.UseVisualStyleBackColor = false;
            this.btnSelectedOrderSave.Click += new System.EventHandler(this.btnSelectedOrderSave_Click);
            // 
            // lClientPrice
            // 
            this.lClientPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lClientPrice.AutoSize = true;
            this.lClientPrice.Location = new System.Drawing.Point(242, 188);
            this.lClientPrice.Name = "lClientPrice";
            this.lClientPrice.Size = new System.Drawing.Size(149, 13);
            this.lClientPrice.TabIndex = 454;
            this.lClientPrice.Text = "Cena, którą zapłaci klient (zł):";
            // 
            // comboBoxSelectedOrderStatus
            // 
            this.comboBoxSelectedOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectedOrderStatus.FormattingEnabled = true;
            this.comboBoxSelectedOrderStatus.Items.AddRange(new object[] {
            "Własnie zamówione",
            "W trakcie realizacji",
            "Zakończone"});
            this.comboBoxSelectedOrderStatus.Location = new System.Drawing.Point(52, 185);
            this.comboBoxSelectedOrderStatus.Name = "comboBoxSelectedOrderStatus";
            this.comboBoxSelectedOrderStatus.Size = new System.Drawing.Size(130, 21);
            this.comboBoxSelectedOrderStatus.TabIndex = 1;
            // 
            // lSelectedOrderStatus
            // 
            this.lSelectedOrderStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lSelectedOrderStatus.AutoSize = true;
            this.lSelectedOrderStatus.Location = new System.Drawing.Point(6, 188);
            this.lSelectedOrderStatus.Name = "lSelectedOrderStatus";
            this.lSelectedOrderStatus.Size = new System.Drawing.Size(40, 13);
            this.lSelectedOrderStatus.TabIndex = 9;
            this.lSelectedOrderStatus.Text = "Status:";
            // 
            // lSelectedOrderStartDate
            // 
            this.lSelectedOrderStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lSelectedOrderStartDate.AutoSize = true;
            this.lSelectedOrderStartDate.Location = new System.Drawing.Point(6, 138);
            this.lSelectedOrderStartDate.Name = "lSelectedOrderStartDate";
            this.lSelectedOrderStartDate.Size = new System.Drawing.Size(93, 13);
            this.lSelectedOrderStartDate.TabIndex = 7;
            this.lSelectedOrderStartDate.Text = "Data rozpoczęcia:";
            // 
            // lSelectedOrderEndDate
            // 
            this.lSelectedOrderEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lSelectedOrderEndDate.AutoSize = true;
            this.lSelectedOrderEndDate.Location = new System.Drawing.Point(6, 163);
            this.lSelectedOrderEndDate.Name = "lSelectedOrderEndDate";
            this.lSelectedOrderEndDate.Size = new System.Drawing.Size(80, 13);
            this.lSelectedOrderEndDate.TabIndex = 5;
            this.lSelectedOrderEndDate.Text = "Data końcowa:";
            // 
            // btnSelectedOrderBrowseImage
            // 
            this.btnSelectedOrderBrowseImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectedOrderBrowseImage.Location = new System.Drawing.Point(407, 11);
            this.btnSelectedOrderBrowseImage.Name = "btnSelectedOrderBrowseImage";
            this.btnSelectedOrderBrowseImage.Size = new System.Drawing.Size(110, 23);
            this.btnSelectedOrderBrowseImage.TabIndex = 2;
            this.btnSelectedOrderBrowseImage.Text = "Wybierz z listy";
            this.btnSelectedOrderBrowseImage.UseVisualStyleBackColor = true;
            // 
            // lSelectedOrderImage
            // 
            this.lSelectedOrderImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lSelectedOrderImage.AutoSize = true;
            this.lSelectedOrderImage.Location = new System.Drawing.Point(356, 16);
            this.lSelectedOrderImage.Name = "lSelectedOrderImage";
            this.lSelectedOrderImage.Size = new System.Drawing.Size(45, 13);
            this.lSelectedOrderImage.TabIndex = 2;
            this.lSelectedOrderImage.Text = "Nadruk:";
            // 
            // pictureBoxSelectedOrderImage
            // 
            this.pictureBoxSelectedOrderImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSelectedOrderImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSelectedOrderImage.Image")));
            this.pictureBoxSelectedOrderImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSelectedOrderImage.InitialImage")));
            this.pictureBoxSelectedOrderImage.Location = new System.Drawing.Point(356, 39);
            this.pictureBoxSelectedOrderImage.Name = "pictureBoxSelectedOrderImage";
            this.pictureBoxSelectedOrderImage.Size = new System.Drawing.Size(161, 141);
            this.pictureBoxSelectedOrderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSelectedOrderImage.TabIndex = 1;
            this.pictureBoxSelectedOrderImage.TabStop = false;
            // 
            // gbSelectedOrderData
            // 
            this.gbSelectedOrderData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSelectedOrderData.Controls.Add(this.tbSelectedOrderPhone);
            this.gbSelectedOrderData.Controls.Add(this.tbSelectedOrderName);
            this.gbSelectedOrderData.Controls.Add(this.tbSelectedOrderEmail);
            this.gbSelectedOrderData.Controls.Add(this.lSelectedOrderName);
            this.gbSelectedOrderData.Controls.Add(this.lSelectedOrderEmail);
            this.gbSelectedOrderData.Controls.Add(this.lSelectedOrderPhone);
            this.gbSelectedOrderData.Location = new System.Drawing.Point(6, 19);
            this.gbSelectedOrderData.Name = "gbSelectedOrderData";
            this.gbSelectedOrderData.Size = new System.Drawing.Size(344, 113);
            this.gbSelectedOrderData.TabIndex = 7;
            this.gbSelectedOrderData.TabStop = false;
            this.gbSelectedOrderData.Text = "Dane zamawiającego";
            // 
            // tbSelectedOrderPhone
            // 
            this.tbSelectedOrderPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSelectedOrderPhone.Location = new System.Drawing.Point(96, 83);
            this.tbSelectedOrderPhone.Name = "tbSelectedOrderPhone";
            this.tbSelectedOrderPhone.Size = new System.Drawing.Size(242, 20);
            this.tbSelectedOrderPhone.TabIndex = 2;
            // 
            // tbSelectedOrderName
            // 
            this.tbSelectedOrderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSelectedOrderName.Location = new System.Drawing.Point(96, 23);
            this.tbSelectedOrderName.Name = "tbSelectedOrderName";
            this.tbSelectedOrderName.Size = new System.Drawing.Size(242, 20);
            this.tbSelectedOrderName.TabIndex = 0;
            // 
            // tbSelectedOrderEmail
            // 
            this.tbSelectedOrderEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSelectedOrderEmail.Location = new System.Drawing.Point(96, 52);
            this.tbSelectedOrderEmail.Name = "tbSelectedOrderEmail";
            this.tbSelectedOrderEmail.Size = new System.Drawing.Size(242, 20);
            this.tbSelectedOrderEmail.TabIndex = 1;
            // 
            // lSelectedOrderName
            // 
            this.lSelectedOrderName.AutoSize = true;
            this.lSelectedOrderName.Location = new System.Drawing.Point(6, 26);
            this.lSelectedOrderName.Name = "lSelectedOrderName";
            this.lSelectedOrderName.Size = new System.Drawing.Size(83, 13);
            this.lSelectedOrderName.TabIndex = 6;
            this.lSelectedOrderName.Text = "Nazwa / osoba:";
            // 
            // lSelectedOrderEmail
            // 
            this.lSelectedOrderEmail.AutoSize = true;
            this.lSelectedOrderEmail.Location = new System.Drawing.Point(6, 55);
            this.lSelectedOrderEmail.Name = "lSelectedOrderEmail";
            this.lSelectedOrderEmail.Size = new System.Drawing.Size(38, 13);
            this.lSelectedOrderEmail.TabIndex = 7;
            this.lSelectedOrderEmail.Text = "E-mail:";
            // 
            // lSelectedOrderPhone
            // 
            this.lSelectedOrderPhone.AutoSize = true;
            this.lSelectedOrderPhone.Location = new System.Drawing.Point(6, 86);
            this.lSelectedOrderPhone.Name = "lSelectedOrderPhone";
            this.lSelectedOrderPhone.Size = new System.Drawing.Size(46, 13);
            this.lSelectedOrderPhone.TabIndex = 8;
            this.lSelectedOrderPhone.Text = "Telefon:";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(409, 530);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Usuń zamówienie";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnSelectedOrderDelete_Click);
            // 
            // lvAllOrders
            // 
            this.lvAllOrders.BackColor = System.Drawing.SystemColors.Window;
            this.lvAllOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderTypes,
            this.columnHeaderAmount,
            this.columnHeaderEndDate,
            this.columnHeaderCompany,
            this.columnHeaderPrice,
            this.columnHeaderCost,
            this.columnHeaderProfit});
            this.lvAllOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvAllOrders.FullRowSelect = true;
            this.lvAllOrders.GridLines = true;
            this.lvAllOrders.Location = new System.Drawing.Point(0, 0);
            this.lvAllOrders.Name = "lvAllOrders";
            this.lvAllOrders.Size = new System.Drawing.Size(527, 259);
            this.lvAllOrders.TabIndex = 6;
            this.lvAllOrders.UseCompatibleStateImageBehavior = false;
            this.lvAllOrders.View = System.Windows.Forms.View.Details;
            this.lvAllOrders.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvAllOrders_ItemSelectionChanged);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 26;
            // 
            // columnHeaderTypes
            // 
            this.columnHeaderTypes.Text = "Rodzaje produktów";
            this.columnHeaderTypes.Width = 103;
            // 
            // columnHeaderAmount
            // 
            this.columnHeaderAmount.Text = "Ilośc produktów";
            this.columnHeaderAmount.Width = 105;
            // 
            // columnHeaderEndDate
            // 
            this.columnHeaderEndDate.Text = "Termin";
            this.columnHeaderEndDate.Width = 58;
            // 
            // columnHeaderCompany
            // 
            this.columnHeaderCompany.Text = "Zamawiający";
            this.columnHeaderCompany.Width = 84;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Cena";
            this.columnHeaderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderPrice.Width = 49;
            // 
            // columnHeaderCost
            // 
            this.columnHeaderCost.Text = "Koszt";
            this.columnHeaderCost.Width = 50;
            // 
            // columnHeaderProfit
            // 
            this.columnHeaderProfit.Text = "Zysk";
            this.columnHeaderProfit.Width = 47;
            // 
            // lCopyright
            // 
            this.lCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lCopyright.AutoSize = true;
            this.lCopyright.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lCopyright.Location = new System.Drawing.Point(922, 9);
            this.lCopyright.Name = "lCopyright";
            this.lCopyright.Size = new System.Drawing.Size(155, 13);
            this.lCopyright.TabIndex = 1;
            this.lCopyright.Text = "© 2018 Jan Sudczak, Filip Strózik";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.resourcesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1077, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getDataToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // getDataToolStripMenuItem
            // 
            this.getDataToolStripMenuItem.Name = "getDataToolStripMenuItem";
            this.getDataToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.getDataToolStripMenuItem.Text = "Pobierz Dane";
            this.getDataToolStripMenuItem.Click += new System.EventHandler(this.getDataToolStripMenuItem_Click);
            // 
            // resourcesToolStripMenuItem
            // 
            this.resourcesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tshirtsToolStripMenuItem,
            this.companiesToolStripMenuItem,
            this.colorsToolStripMenuItem,
            this.stylesToolStripMenuItem});
            this.resourcesToolStripMenuItem.Name = "resourcesToolStripMenuItem";
            this.resourcesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.resourcesToolStripMenuItem.Text = "Zasoby";
            // 
            // tshirtsToolStripMenuItem
            // 
            this.tshirtsToolStripMenuItem.Name = "tshirtsToolStripMenuItem";
            this.tshirtsToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.tshirtsToolStripMenuItem.Text = "Koszulki";
            this.tshirtsToolStripMenuItem.Click += new System.EventHandler(this.tshirtsToolStripMenuItem_Click);
            // 
            // companiesToolStripMenuItem
            // 
            this.companiesToolStripMenuItem.Name = "companiesToolStripMenuItem";
            this.companiesToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.companiesToolStripMenuItem.Text = "Firmy";
            this.companiesToolStripMenuItem.Click += new System.EventHandler(this.companiesToolStripMenuItem_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.colorsToolStripMenuItem.Text = "Kolory";
            this.colorsToolStripMenuItem.Click += new System.EventHandler(this.colorsToolStripMenuItem_Click);
            // 
            // stylesToolStripMenuItem
            // 
            this.stylesToolStripMenuItem.Name = "stylesToolStripMenuItem";
            this.stylesToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.stylesToolStripMenuItem.Text = "Style";
            this.stylesToolStripMenuItem.Click += new System.EventHandler(this.stylesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.helpToolStripMenuItem.Text = "Pomoc";
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeBegin.Enabled = false;
            this.dateTimeBegin.Location = new System.Drawing.Point(105, 138);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(239, 20);
            this.dateTimeBegin.TabIndex = 456;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeEnd.Location = new System.Drawing.Point(92, 160);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(252, 20);
            this.dateTimeEnd.TabIndex = 457;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 584);
            this.Controls.Add(this.lCopyright);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "MainWindow";
            this.Text = "SSprint";
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerHorizLeft.Panel1.ResumeLayout(false);
            this.splitContainerHorizLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHorizLeft)).EndInit();
            this.splitContainerHorizLeft.ResumeLayout(false);
            this.panelProductSelector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericAddingProductAmount)).EndInit();
            this.gbSelectedOrderParams.ResumeLayout(false);
            this.gbSelectedOrderParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numClientPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedOrderImage)).EndInit();
            this.gbSelectedOrderData.ResumeLayout(false);
            this.gbSelectedOrderData.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.ListView lvOrderedProducts;
        private System.Windows.Forms.ColumnHeader columnCompany;
        private System.Windows.Forms.ColumnHeader columnStyle;
        private System.Windows.Forms.ColumnHeader columnSex;
        private System.Windows.Forms.ColumnHeader columnColor;
        private System.Windows.Forms.ColumnHeader columnAmount;
        private System.Windows.Forms.ColumnHeader columnActions;
        private System.Windows.Forms.SplitContainer splitContainerHorizLeft;
        private System.Windows.Forms.TreeView treeViewProductBrowser;
        private System.Windows.Forms.Panel panelProductSelector;
        private System.Windows.Forms.NumericUpDown numericAddingProductAmount;
        private System.Windows.Forms.Button btnAddProductToOrder;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnCurrentOrderCancel;
        private System.Windows.Forms.ColumnHeader columnReserved;
        private System.Windows.Forms.ListView lvAllOrders;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderTypes;
        private System.Windows.Forms.ColumnHeader columnHeaderAmount;
        private System.Windows.Forms.ColumnHeader columnHeaderEndDate;
        private System.Windows.Forms.ColumnHeader columnHeaderCompany;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderCost;
        private System.Windows.Forms.ColumnHeader columnHeaderProfit;
        private System.Windows.Forms.Button btnSelectedOrderSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbSelectedOrderParams;
        private System.Windows.Forms.ComboBox comboBoxSelectedOrderStatus;
        private System.Windows.Forms.Label lSelectedOrderStatus;
        private System.Windows.Forms.Label lSelectedOrderStartDate;
        private System.Windows.Forms.Label lSelectedOrderEndDate;
        private System.Windows.Forms.Button btnSelectedOrderBrowseImage;
        private System.Windows.Forms.Label lSelectedOrderImage;
        private System.Windows.Forms.PictureBox pictureBoxSelectedOrderImage;
        private System.Windows.Forms.GroupBox gbSelectedOrderData;
        private System.Windows.Forms.TextBox tbSelectedOrderPhone;
        private System.Windows.Forms.TextBox tbSelectedOrderName;
        private System.Windows.Forms.TextBox tbSelectedOrderEmail;
        private System.Windows.Forms.Label lSelectedOrderName;
        private System.Windows.Forms.Label lSelectedOrderEmail;
        private System.Windows.Forms.Label lSelectedOrderPhone;
        private System.Windows.Forms.Label lCopyright;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tshirtsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stylesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numClientPrice;
        private System.Windows.Forms.Label lClientPrice;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeBegin;
    }
}

