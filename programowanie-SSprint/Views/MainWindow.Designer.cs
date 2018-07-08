namespace programowanie_SSprint
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
            this.components = new System.ComponentModel.Container();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerHorizLeft = new System.Windows.Forms.SplitContainer();
            this.panelProductSelector = new System.Windows.Forms.Panel();
            this.lSelectedTshirtName = new System.Windows.Forms.Label();
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
            this.btnAddNew = new System.Windows.Forms.Button();
            this.gbSelectedOrderParams = new System.Windows.Forms.GroupBox();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.notificationPanel1 = new programowanie_SSprint.Views.HelperViews.NotificationPanel();
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.splitContainerMain.Panel2.Controls.Add(this.notificationPanel1);
            this.splitContainerMain.Panel2.Controls.Add(this.btnAddNew);
            this.splitContainerMain.Panel2.Controls.Add(this.gbSelectedOrderParams);
            this.splitContainerMain.Panel2.Controls.Add(this.btnDelete);
            this.splitContainerMain.Panel2.Controls.Add(this.lvAllOrders);
            this.splitContainerMain.Panel2MinSize = 450;
            this.splitContainerMain.Size = new System.Drawing.Size(1077, 558);
            this.splitContainerMain.SplitterDistance = 531;
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
            this.splitContainerHorizLeft.Size = new System.Drawing.Size(529, 556);
            this.splitContainerHorizLeft.SplitterDistance = 311;
            this.splitContainerHorizLeft.TabIndex = 1;
            // 
            // panelProductSelector
            // 
            this.panelProductSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProductSelector.Controls.Add(this.lSelectedTshirtName);
            this.panelProductSelector.Controls.Add(this.numericAddingProductAmount);
            this.panelProductSelector.Controls.Add(this.btnAddProductToOrder);
            this.panelProductSelector.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelProductSelector.Location = new System.Drawing.Point(0, 279);
            this.panelProductSelector.Name = "panelProductSelector";
            this.panelProductSelector.Size = new System.Drawing.Size(529, 32);
            this.panelProductSelector.TabIndex = 1;
            // 
            // lSelectedTshirtName
            // 
            this.lSelectedTshirtName.AutoSize = true;
            this.lSelectedTshirtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lSelectedTshirtName.Location = new System.Drawing.Point(209, 8);
            this.lSelectedTshirtName.Name = "lSelectedTshirtName";
            this.lSelectedTshirtName.Size = new System.Drawing.Size(52, 17);
            this.lSelectedTshirtName.TabIndex = 2;
            this.lSelectedTshirtName.Text = "label1";
            // 
            // numericAddingProductAmount
            // 
            this.numericAddingProductAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericAddingProductAmount.BackColor = System.Drawing.Color.Cornsilk;
            this.numericAddingProductAmount.Location = new System.Drawing.Point(152, 5);
            this.numericAddingProductAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAddingProductAmount.Name = "numericAddingProductAmount";
            this.numericAddingProductAmount.Size = new System.Drawing.Size(51, 20);
            this.numericAddingProductAmount.TabIndex = 0;
            this.numericAddingProductAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.btnAddProductToOrder.Click += new System.EventHandler(this.btnAddProductToOrder_Click);
            // 
            // treeViewProductBrowser
            // 
            this.treeViewProductBrowser.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeViewProductBrowser.Location = new System.Drawing.Point(0, 0);
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
            this.treeViewProductBrowser.Size = new System.Drawing.Size(529, 315);
            this.treeViewProductBrowser.TabIndex = 0;
            this.treeViewProductBrowser.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewProductBrowser_AfterSelect);
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
            this.columnReserved});
            this.lvOrderedProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvOrderedProducts.FullRowSelect = true;
            this.lvOrderedProducts.GridLines = true;
            this.lvOrderedProducts.Location = new System.Drawing.Point(0, 0);
            this.lvOrderedProducts.Name = "lvOrderedProducts";
            this.lvOrderedProducts.Size = new System.Drawing.Size(529, 241);
            this.lvOrderedProducts.TabIndex = 0;
            this.lvOrderedProducts.UseCompatibleStateImageBehavior = false;
            this.lvOrderedProducts.View = System.Windows.Forms.View.Details;
            this.lvOrderedProducts.DoubleClick += new System.EventHandler(this.lvOrderedProducts_DoubleClick);
            // 
            // columnCompany
            // 
            this.columnCompany.Text = "Firma";
            this.columnCompany.Width = 88;
            // 
            // columnStyle
            // 
            this.columnStyle.Text = "Styl";
            this.columnStyle.Width = 129;
            // 
            // columnSex
            // 
            this.columnSex.Text = "Płeć";
            // 
            // columnColor
            // 
            this.columnColor.Text = "Kolor";
            this.columnColor.Width = 69;
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Ilość";
            // 
            // columnReserved
            // 
            this.columnReserved.Text = "Rezerwacja";
            this.columnReserved.Width = 89;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddNew.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Location = new System.Drawing.Point(3, 530);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(133, 23);
            this.btnAddNew.TabIndex = 1;
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
            this.gbSelectedOrderParams.Size = new System.Drawing.Size(534, 259);
            this.gbSelectedOrderParams.TabIndex = 1;
            this.gbSelectedOrderParams.TabStop = false;
            this.gbSelectedOrderParams.Text = "Parametry zamówienia";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeEnd.Location = new System.Drawing.Point(92, 160);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(265, 20);
            this.dateTimeEnd.TabIndex = 1;
            this.dateTimeEnd.ValueChanged += new System.EventHandler(this.dateTimeEnd_ValueChanged);
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeBegin.Enabled = false;
            this.dateTimeBegin.Location = new System.Drawing.Point(105, 138);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(252, 20);
            this.dateTimeBegin.TabIndex = 0;
            // 
            // numClientPrice
            // 
            this.numClientPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numClientPrice.Location = new System.Drawing.Point(410, 186);
            this.numClientPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numClientPrice.Name = "numClientPrice";
            this.numClientPrice.Size = new System.Drawing.Size(120, 20);
            this.numClientPrice.TabIndex = 3;
            this.numClientPrice.ValueChanged += new System.EventHandler(this.numClientPrice_ValueChanged);
            // 
            // btnCurrentOrderCancel
            // 
            this.btnCurrentOrderCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCurrentOrderCancel.BackColor = System.Drawing.Color.Salmon;
            this.btnCurrentOrderCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentOrderCancel.Location = new System.Drawing.Point(53, 227);
            this.btnCurrentOrderCancel.Name = "btnCurrentOrderCancel";
            this.btnCurrentOrderCancel.Size = new System.Drawing.Size(181, 23);
            this.btnCurrentOrderCancel.TabIndex = 5;
            this.btnCurrentOrderCancel.Text = "Anuluj / Wyczyść ";
            this.btnCurrentOrderCancel.UseVisualStyleBackColor = false;
            this.btnCurrentOrderCancel.Click += new System.EventHandler(this.btnCurrentOrderCancel_Click);
            // 
            // btnSelectedOrderSave
            // 
            this.btnSelectedOrderSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectedOrderSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSelectedOrderSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectedOrderSave.Location = new System.Drawing.Point(309, 227);
            this.btnSelectedOrderSave.Name = "btnSelectedOrderSave";
            this.btnSelectedOrderSave.Size = new System.Drawing.Size(172, 23);
            this.btnSelectedOrderSave.TabIndex = 4;
            this.btnSelectedOrderSave.Text = "Zapisz zmiany";
            this.btnSelectedOrderSave.UseVisualStyleBackColor = false;
            this.btnSelectedOrderSave.Click += new System.EventHandler(this.btnSelectedOrderSave_Click);
            // 
            // lClientPrice
            // 
            this.lClientPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lClientPrice.AutoSize = true;
            this.lClientPrice.Location = new System.Drawing.Point(255, 188);
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
            this.comboBoxSelectedOrderStatus.TabIndex = 2;
            this.comboBoxSelectedOrderStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectedOrderStatus_SelectedIndexChanged);
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
            this.btnSelectedOrderBrowseImage.Location = new System.Drawing.Point(420, 11);
            this.btnSelectedOrderBrowseImage.Name = "btnSelectedOrderBrowseImage";
            this.btnSelectedOrderBrowseImage.Size = new System.Drawing.Size(110, 23);
            this.btnSelectedOrderBrowseImage.TabIndex = 2;
            this.btnSelectedOrderBrowseImage.Text = "Wybierz z listy";
            this.btnSelectedOrderBrowseImage.UseVisualStyleBackColor = true;
            this.btnSelectedOrderBrowseImage.Click += new System.EventHandler(this.btnSelectedOrderBrowseImage_Click);
            // 
            // lSelectedOrderImage
            // 
            this.lSelectedOrderImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lSelectedOrderImage.AutoSize = true;
            this.lSelectedOrderImage.Location = new System.Drawing.Point(369, 16);
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
            this.pictureBoxSelectedOrderImage.Location = new System.Drawing.Point(369, 39);
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
            this.gbSelectedOrderData.Size = new System.Drawing.Size(357, 113);
            this.gbSelectedOrderData.TabIndex = 0;
            this.gbSelectedOrderData.TabStop = false;
            this.gbSelectedOrderData.Text = "Dane zamawiającego";
            // 
            // tbSelectedOrderPhone
            // 
            this.tbSelectedOrderPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSelectedOrderPhone.Location = new System.Drawing.Point(96, 83);
            this.tbSelectedOrderPhone.Name = "tbSelectedOrderPhone";
            this.tbSelectedOrderPhone.Size = new System.Drawing.Size(255, 20);
            this.tbSelectedOrderPhone.TabIndex = 2;
            this.tbSelectedOrderPhone.TextChanged += new System.EventHandler(this.tbSelectedOrderPhone_TextChanged);
            // 
            // tbSelectedOrderName
            // 
            this.tbSelectedOrderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSelectedOrderName.Location = new System.Drawing.Point(96, 23);
            this.tbSelectedOrderName.Name = "tbSelectedOrderName";
            this.tbSelectedOrderName.Size = new System.Drawing.Size(255, 20);
            this.tbSelectedOrderName.TabIndex = 0;
            this.tbSelectedOrderName.TextChanged += new System.EventHandler(this.tbSelectedOrderName_TextChanged);
            // 
            // tbSelectedOrderEmail
            // 
            this.tbSelectedOrderEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSelectedOrderEmail.Location = new System.Drawing.Point(96, 52);
            this.tbSelectedOrderEmail.Name = "tbSelectedOrderEmail";
            this.tbSelectedOrderEmail.Size = new System.Drawing.Size(255, 20);
            this.tbSelectedOrderEmail.TabIndex = 1;
            this.tbSelectedOrderEmail.TextChanged += new System.EventHandler(this.tbSelectedOrderEmail_TextChanged);
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
            this.btnDelete.Location = new System.Drawing.Point(422, 530);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 23);
            this.btnDelete.TabIndex = 2;
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
            this.lvAllOrders.Size = new System.Drawing.Size(540, 259);
            this.lvAllOrders.TabIndex = 4;
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
            this.columnHeaderTypes.Width = 106;
            // 
            // columnHeaderAmount
            // 
            this.columnHeaderAmount.Text = "Ilośc produktów";
            this.columnHeaderAmount.Width = 90;
            // 
            // columnHeaderEndDate
            // 
            this.columnHeaderEndDate.Text = "Termin";
            this.columnHeaderEndDate.Width = 58;
            // 
            // columnHeaderCompany
            // 
            this.columnHeaderCompany.Text = "Zamawiający";
            this.columnHeaderCompany.Width = 79;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Cena";
            this.columnHeaderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderPrice.Width = 44;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // notificationPanel1
            // 
            this.notificationPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notificationPanel1.BackColor = System.Drawing.Color.White;
            this.notificationPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.notificationPanel1.Location = new System.Drawing.Point(156, 530);
            this.notificationPanel1.MinimumSize = new System.Drawing.Size(245, 20);
            this.notificationPanel1.Name = "notificationPanel1";
            this.notificationPanel1.NotificationTime = 7000;
            this.notificationPanel1.Size = new System.Drawing.Size(251, 23);
            this.notificationPanel1.TabIndex = 8;
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
            this.MinimumSize = new System.Drawing.Size(1000, 550);
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
            this.panelProductSelector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAddingProductAmount)).EndInit();
            this.gbSelectedOrderParams.ResumeLayout(false);
            this.gbSelectedOrderParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numClientPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedOrderImage)).EndInit();
            this.gbSelectedOrderData.ResumeLayout(false);
            this.gbSelectedOrderData.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Label lSelectedTshirtName;
        private Views.HelperViews.NotificationPanel notificationPanel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

