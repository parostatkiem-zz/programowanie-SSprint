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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.btnCurrentOrderAdd = new System.Windows.Forms.Button();
            this.btnCurrentOrderCancel = new System.Windows.Forms.Button();
            this.gbCurrentOrderParams = new System.Windows.Forms.GroupBox();
            this.tbCurrentOrderEndDate = new System.Windows.Forms.TextBox();
            this.lCurrentOrderEndDate = new System.Windows.Forms.Label();
            this.btnCurrentOrderSetDate = new System.Windows.Forms.Button();
            this.btnCurrentOrderBrowseImage = new System.Windows.Forms.Button();
            this.lCurrentOrderPicture = new System.Windows.Forms.Label();
            this.pictureBoxCurrentOrderImage = new System.Windows.Forms.PictureBox();
            this.gbCurrentOrderData = new System.Windows.Forms.GroupBox();
            this.tbCurrentOrderPhone = new System.Windows.Forms.TextBox();
            this.tbCurrentOrderEmail = new System.Windows.Forms.TextBox();
            this.tbCurrentOrderName = new System.Windows.Forms.TextBox();
            this.lCurrentOrderPhone = new System.Windows.Forms.Label();
            this.lCurrentOrderEmail = new System.Windows.Forms.Label();
            this.lCurrentOrderName = new System.Windows.Forms.Label();
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
            this.gbSelectedOrderParams = new System.Windows.Forms.GroupBox();
            this.comboBoxSelectedOrderStatus = new System.Windows.Forms.ComboBox();
            this.lSelectedOrderStatus = new System.Windows.Forms.Label();
            this.tbSelectedOrderStartDate = new System.Windows.Forms.TextBox();
            this.lSelectedOrderStartDate = new System.Windows.Forms.Label();
            this.tbSelectedOrderEndDate = new System.Windows.Forms.TextBox();
            this.lSelectedOrderEndDate = new System.Windows.Forms.Label();
            this.btnSelectedOrderSetEndDate = new System.Windows.Forms.Button();
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
            this.btnSelectedOrderSave = new System.Windows.Forms.Button();
            this.btnSelectedOrderDelete = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.gbCurrentOrderParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentOrderImage)).BeginInit();
            this.gbCurrentOrderData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHorizLeft)).BeginInit();
            this.splitContainerHorizLeft.Panel1.SuspendLayout();
            this.splitContainerHorizLeft.Panel2.SuspendLayout();
            this.splitContainerHorizLeft.SuspendLayout();
            this.panelProductSelector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAddingProductAmount)).BeginInit();
            this.gbSelectedOrderParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedOrderImage)).BeginInit();
            this.gbSelectedOrderData.SuspendLayout();
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
            this.splitContainerMain.Panel1.Controls.Add(this.btnCurrentOrderAdd);
            this.splitContainerMain.Panel1.Controls.Add(this.btnCurrentOrderCancel);
            this.splitContainerMain.Panel1.Controls.Add(this.gbCurrentOrderParams);
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainerHorizLeft);
            this.splitContainerMain.Panel1MinSize = 420;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.gbSelectedOrderParams);
            this.splitContainerMain.Panel2.Controls.Add(this.btnSelectedOrderSave);
            this.splitContainerMain.Panel2.Controls.Add(this.btnSelectedOrderDelete);
            this.splitContainerMain.Panel2.Controls.Add(this.lvAllOrders);
            this.splitContainerMain.Panel2MinSize = 420;
            this.splitContainerMain.Size = new System.Drawing.Size(1085, 608);
            this.splitContainerMain.SplitterDistance = 518;
            this.splitContainerMain.TabIndex = 0;
            // 
            // btnCurrentOrderAdd
            // 
            this.btnCurrentOrderAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCurrentOrderAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnCurrentOrderAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentOrderAdd.Location = new System.Drawing.Point(3, 580);
            this.btnCurrentOrderAdd.Name = "btnCurrentOrderAdd";
            this.btnCurrentOrderAdd.Size = new System.Drawing.Size(133, 23);
            this.btnCurrentOrderAdd.TabIndex = 0;
            this.btnCurrentOrderAdd.Text = "Dodaj zamówienie";
            this.btnCurrentOrderAdd.UseVisualStyleBackColor = false;
            // 
            // btnCurrentOrderCancel
            // 
            this.btnCurrentOrderCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCurrentOrderCancel.BackColor = System.Drawing.Color.Salmon;
            this.btnCurrentOrderCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentOrderCancel.Location = new System.Drawing.Point(380, 580);
            this.btnCurrentOrderCancel.Name = "btnCurrentOrderCancel";
            this.btnCurrentOrderCancel.Size = new System.Drawing.Size(133, 23);
            this.btnCurrentOrderCancel.TabIndex = 1;
            this.btnCurrentOrderCancel.Text = "Anuluj / Wyczyść ";
            this.btnCurrentOrderCancel.UseVisualStyleBackColor = false;
            // 
            // gbCurrentOrderParams
            // 
            this.gbCurrentOrderParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCurrentOrderParams.BackColor = System.Drawing.Color.Transparent;
            this.gbCurrentOrderParams.Controls.Add(this.tbCurrentOrderEndDate);
            this.gbCurrentOrderParams.Controls.Add(this.lCurrentOrderEndDate);
            this.gbCurrentOrderParams.Controls.Add(this.btnCurrentOrderSetDate);
            this.gbCurrentOrderParams.Controls.Add(this.btnCurrentOrderBrowseImage);
            this.gbCurrentOrderParams.Controls.Add(this.lCurrentOrderPicture);
            this.gbCurrentOrderParams.Controls.Add(this.pictureBoxCurrentOrderImage);
            this.gbCurrentOrderParams.Controls.Add(this.gbCurrentOrderData);
            this.gbCurrentOrderParams.Location = new System.Drawing.Point(3, 434);
            this.gbCurrentOrderParams.Name = "gbCurrentOrderParams";
            this.gbCurrentOrderParams.Size = new System.Drawing.Size(510, 140);
            this.gbCurrentOrderParams.TabIndex = 2;
            this.gbCurrentOrderParams.TabStop = false;
            this.gbCurrentOrderParams.Text = "Parametry zamówienia";
            // 
            // tbCurrentOrderEndDate
            // 
            this.tbCurrentOrderEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurrentOrderEndDate.Location = new System.Drawing.Point(92, 115);
            this.tbCurrentOrderEndDate.Name = "tbCurrentOrderEndDate";
            this.tbCurrentOrderEndDate.ReadOnly = true;
            this.tbCurrentOrderEndDate.Size = new System.Drawing.Size(153, 20);
            this.tbCurrentOrderEndDate.TabIndex = 1;
            this.tbCurrentOrderEndDate.Text = "Nie ustalono";
            // 
            // lCurrentOrderEndDate
            // 
            this.lCurrentOrderEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lCurrentOrderEndDate.AutoSize = true;
            this.lCurrentOrderEndDate.Location = new System.Drawing.Point(6, 118);
            this.lCurrentOrderEndDate.Name = "lCurrentOrderEndDate";
            this.lCurrentOrderEndDate.Size = new System.Drawing.Size(80, 13);
            this.lCurrentOrderEndDate.TabIndex = 5;
            this.lCurrentOrderEndDate.Text = "Data końcowa:";
            // 
            // btnCurrentOrderSetDate
            // 
            this.btnCurrentOrderSetDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCurrentOrderSetDate.Location = new System.Drawing.Point(251, 113);
            this.btnCurrentOrderSetDate.Name = "btnCurrentOrderSetDate";
            this.btnCurrentOrderSetDate.Size = new System.Drawing.Size(75, 23);
            this.btnCurrentOrderSetDate.TabIndex = 0;
            this.btnCurrentOrderSetDate.Text = "Ustal datę";
            this.btnCurrentOrderSetDate.UseVisualStyleBackColor = true;
            // 
            // btnCurrentOrderBrowseImage
            // 
            this.btnCurrentOrderBrowseImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCurrentOrderBrowseImage.Location = new System.Drawing.Point(380, 14);
            this.btnCurrentOrderBrowseImage.Name = "btnCurrentOrderBrowseImage";
            this.btnCurrentOrderBrowseImage.Size = new System.Drawing.Size(112, 23);
            this.btnCurrentOrderBrowseImage.TabIndex = 1;
            this.btnCurrentOrderBrowseImage.Text = "Wybierz z listy";
            this.btnCurrentOrderBrowseImage.UseVisualStyleBackColor = true;
            // 
            // lCurrentOrderPicture
            // 
            this.lCurrentOrderPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lCurrentOrderPicture.AutoSize = true;
            this.lCurrentOrderPicture.Location = new System.Drawing.Point(331, 19);
            this.lCurrentOrderPicture.Name = "lCurrentOrderPicture";
            this.lCurrentOrderPicture.Size = new System.Drawing.Size(45, 13);
            this.lCurrentOrderPicture.TabIndex = 2;
            this.lCurrentOrderPicture.Text = "Nadruk:";
            // 
            // pictureBoxCurrentOrderImage
            // 
            this.pictureBoxCurrentOrderImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCurrentOrderImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCurrentOrderImage.Image")));
            this.pictureBoxCurrentOrderImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCurrentOrderImage.InitialImage")));
            this.pictureBoxCurrentOrderImage.Location = new System.Drawing.Point(331, 42);
            this.pictureBoxCurrentOrderImage.Name = "pictureBoxCurrentOrderImage";
            this.pictureBoxCurrentOrderImage.Size = new System.Drawing.Size(161, 94);
            this.pictureBoxCurrentOrderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCurrentOrderImage.TabIndex = 1;
            this.pictureBoxCurrentOrderImage.TabStop = false;
            // 
            // gbCurrentOrderData
            // 
            this.gbCurrentOrderData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCurrentOrderData.Controls.Add(this.tbCurrentOrderPhone);
            this.gbCurrentOrderData.Controls.Add(this.tbCurrentOrderEmail);
            this.gbCurrentOrderData.Controls.Add(this.tbCurrentOrderName);
            this.gbCurrentOrderData.Controls.Add(this.lCurrentOrderPhone);
            this.gbCurrentOrderData.Controls.Add(this.lCurrentOrderEmail);
            this.gbCurrentOrderData.Controls.Add(this.lCurrentOrderName);
            this.gbCurrentOrderData.Location = new System.Drawing.Point(6, 19);
            this.gbCurrentOrderData.Name = "gbCurrentOrderData";
            this.gbCurrentOrderData.Size = new System.Drawing.Size(319, 90);
            this.gbCurrentOrderData.TabIndex = 0;
            this.gbCurrentOrderData.TabStop = false;
            this.gbCurrentOrderData.Text = "Dane zamawiającego";
            // 
            // tbCurrentOrderPhone
            // 
            this.tbCurrentOrderPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurrentOrderPhone.Location = new System.Drawing.Point(96, 65);
            this.tbCurrentOrderPhone.Name = "tbCurrentOrderPhone";
            this.tbCurrentOrderPhone.Size = new System.Drawing.Size(217, 20);
            this.tbCurrentOrderPhone.TabIndex = 2;
            // 
            // tbCurrentOrderEmail
            // 
            this.tbCurrentOrderEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurrentOrderEmail.Location = new System.Drawing.Point(96, 41);
            this.tbCurrentOrderEmail.Name = "tbCurrentOrderEmail";
            this.tbCurrentOrderEmail.Size = new System.Drawing.Size(217, 20);
            this.tbCurrentOrderEmail.TabIndex = 1;
            // 
            // tbCurrentOrderName
            // 
            this.tbCurrentOrderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurrentOrderName.Location = new System.Drawing.Point(96, 16);
            this.tbCurrentOrderName.Name = "tbCurrentOrderName";
            this.tbCurrentOrderName.Size = new System.Drawing.Size(217, 20);
            this.tbCurrentOrderName.TabIndex = 0;
            // 
            // lCurrentOrderPhone
            // 
            this.lCurrentOrderPhone.AutoSize = true;
            this.lCurrentOrderPhone.Location = new System.Drawing.Point(6, 68);
            this.lCurrentOrderPhone.Name = "lCurrentOrderPhone";
            this.lCurrentOrderPhone.Size = new System.Drawing.Size(46, 13);
            this.lCurrentOrderPhone.TabIndex = 2;
            this.lCurrentOrderPhone.Text = "Telefon:";
            // 
            // lCurrentOrderEmail
            // 
            this.lCurrentOrderEmail.AutoSize = true;
            this.lCurrentOrderEmail.Location = new System.Drawing.Point(6, 44);
            this.lCurrentOrderEmail.Name = "lCurrentOrderEmail";
            this.lCurrentOrderEmail.Size = new System.Drawing.Size(38, 13);
            this.lCurrentOrderEmail.TabIndex = 1;
            this.lCurrentOrderEmail.Text = "E-mail:";
            // 
            // lCurrentOrderName
            // 
            this.lCurrentOrderName.AutoSize = true;
            this.lCurrentOrderName.Location = new System.Drawing.Point(6, 19);
            this.lCurrentOrderName.Name = "lCurrentOrderName";
            this.lCurrentOrderName.Size = new System.Drawing.Size(83, 13);
            this.lCurrentOrderName.TabIndex = 0;
            this.lCurrentOrderName.Text = "Nazwa / osoba:";
            // 
            // splitContainerHorizLeft
            // 
            this.splitContainerHorizLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerHorizLeft.Location = new System.Drawing.Point(3, 3);
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
            this.splitContainerHorizLeft.Size = new System.Drawing.Size(510, 428);
            this.splitContainerHorizLeft.SplitterDistance = 211;
            this.splitContainerHorizLeft.TabIndex = 1;
            // 
            // panelProductSelector
            // 
            this.panelProductSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProductSelector.Controls.Add(this.numericAddingProductAmount);
            this.panelProductSelector.Controls.Add(this.btnAddProductToOrder);
            this.panelProductSelector.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelProductSelector.Location = new System.Drawing.Point(0, 179);
            this.panelProductSelector.Name = "panelProductSelector";
            this.panelProductSelector.Size = new System.Drawing.Size(510, 32);
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
            this.treeViewProductBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.treeViewProductBrowser.Size = new System.Drawing.Size(510, 177);
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
            this.lvOrderedProducts.Size = new System.Drawing.Size(510, 213);
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
            // gbSelectedOrderParams
            // 
            this.gbSelectedOrderParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSelectedOrderParams.BackColor = System.Drawing.Color.Transparent;
            this.gbSelectedOrderParams.Controls.Add(this.comboBoxSelectedOrderStatus);
            this.gbSelectedOrderParams.Controls.Add(this.lSelectedOrderStatus);
            this.gbSelectedOrderParams.Controls.Add(this.tbSelectedOrderStartDate);
            this.gbSelectedOrderParams.Controls.Add(this.lSelectedOrderStartDate);
            this.gbSelectedOrderParams.Controls.Add(this.tbSelectedOrderEndDate);
            this.gbSelectedOrderParams.Controls.Add(this.lSelectedOrderEndDate);
            this.gbSelectedOrderParams.Controls.Add(this.btnSelectedOrderSetEndDate);
            this.gbSelectedOrderParams.Controls.Add(this.btnSelectedOrderBrowseImage);
            this.gbSelectedOrderParams.Controls.Add(this.lSelectedOrderImage);
            this.gbSelectedOrderParams.Controls.Add(this.pictureBoxSelectedOrderImage);
            this.gbSelectedOrderParams.Controls.Add(this.gbSelectedOrderData);
            this.gbSelectedOrderParams.Location = new System.Drawing.Point(3, 351);
            this.gbSelectedOrderParams.Name = "gbSelectedOrderParams";
            this.gbSelectedOrderParams.Size = new System.Drawing.Size(555, 223);
            this.gbSelectedOrderParams.TabIndex = 7;
            this.gbSelectedOrderParams.TabStop = false;
            this.gbSelectedOrderParams.Text = "Parametry zamówienia";
            // 
            // comboBoxSelectedOrderStatus
            // 
            this.comboBoxSelectedOrderStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxSelectedOrderStatus.FormattingEnabled = true;
            this.comboBoxSelectedOrderStatus.Items.AddRange(new object[] {
            "Własnie zamówione",
            "W trakcie realizacji",
            "Zakończone"});
            this.comboBoxSelectedOrderStatus.Location = new System.Drawing.Point(52, 185);
            this.comboBoxSelectedOrderStatus.Name = "comboBoxSelectedOrderStatus";
            this.comboBoxSelectedOrderStatus.Size = new System.Drawing.Size(121, 21);
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
            // tbSelectedOrderStartDate
            // 
            this.tbSelectedOrderStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSelectedOrderStartDate.Location = new System.Drawing.Point(102, 135);
            this.tbSelectedOrderStartDate.Name = "tbSelectedOrderStartDate";
            this.tbSelectedOrderStartDate.ReadOnly = true;
            this.tbSelectedOrderStartDate.Size = new System.Drawing.Size(278, 20);
            this.tbSelectedOrderStartDate.TabIndex = 153;
            this.tbSelectedOrderStartDate.Text = "Nie ustalono";
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
            // tbSelectedOrderEndDate
            // 
            this.tbSelectedOrderEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSelectedOrderEndDate.Location = new System.Drawing.Point(89, 160);
            this.tbSelectedOrderEndDate.Name = "tbSelectedOrderEndDate";
            this.tbSelectedOrderEndDate.ReadOnly = true;
            this.tbSelectedOrderEndDate.Size = new System.Drawing.Size(210, 20);
            this.tbSelectedOrderEndDate.TabIndex = 453;
            this.tbSelectedOrderEndDate.Text = "Nie ustalono";
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
            // btnSelectedOrderSetEndDate
            // 
            this.btnSelectedOrderSetEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectedOrderSetEndDate.Location = new System.Drawing.Point(305, 157);
            this.btnSelectedOrderSetEndDate.Name = "btnSelectedOrderSetEndDate";
            this.btnSelectedOrderSetEndDate.Size = new System.Drawing.Size(75, 23);
            this.btnSelectedOrderSetEndDate.TabIndex = 0;
            this.btnSelectedOrderSetEndDate.Text = "Ustal datę";
            this.btnSelectedOrderSetEndDate.UseVisualStyleBackColor = true;
            // 
            // btnSelectedOrderBrowseImage
            // 
            this.btnSelectedOrderBrowseImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectedOrderBrowseImage.Location = new System.Drawing.Point(443, 11);
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
            this.lSelectedOrderImage.Location = new System.Drawing.Point(392, 16);
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
            this.pictureBoxSelectedOrderImage.Location = new System.Drawing.Point(392, 39);
            this.pictureBoxSelectedOrderImage.Name = "pictureBoxSelectedOrderImage";
            this.pictureBoxSelectedOrderImage.Size = new System.Drawing.Size(161, 164);
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
            this.gbSelectedOrderData.Size = new System.Drawing.Size(380, 113);
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
            this.tbSelectedOrderPhone.Size = new System.Drawing.Size(278, 20);
            this.tbSelectedOrderPhone.TabIndex = 2;
            // 
            // tbSelectedOrderName
            // 
            this.tbSelectedOrderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSelectedOrderName.Location = new System.Drawing.Point(96, 23);
            this.tbSelectedOrderName.Name = "tbSelectedOrderName";
            this.tbSelectedOrderName.Size = new System.Drawing.Size(278, 20);
            this.tbSelectedOrderName.TabIndex = 0;
            // 
            // tbSelectedOrderEmail
            // 
            this.tbSelectedOrderEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSelectedOrderEmail.Location = new System.Drawing.Point(96, 52);
            this.tbSelectedOrderEmail.Name = "tbSelectedOrderEmail";
            this.tbSelectedOrderEmail.Size = new System.Drawing.Size(278, 20);
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
            // btnSelectedOrderSave
            // 
            this.btnSelectedOrderSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectedOrderSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSelectedOrderSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectedOrderSave.Location = new System.Drawing.Point(3, 580);
            this.btnSelectedOrderSave.Name = "btnSelectedOrderSave";
            this.btnSelectedOrderSave.Size = new System.Drawing.Size(133, 23);
            this.btnSelectedOrderSave.TabIndex = 0;
            this.btnSelectedOrderSave.Text = "Zapisz zmiany";
            this.btnSelectedOrderSave.UseVisualStyleBackColor = false;
            // 
            // btnSelectedOrderDelete
            // 
            this.btnSelectedOrderDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectedOrderDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnSelectedOrderDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectedOrderDelete.Location = new System.Drawing.Point(443, 580);
            this.btnSelectedOrderDelete.Name = "btnSelectedOrderDelete";
            this.btnSelectedOrderDelete.Size = new System.Drawing.Size(115, 23);
            this.btnSelectedOrderDelete.TabIndex = 1;
            this.btnSelectedOrderDelete.Text = "Usuń zamówienie";
            this.btnSelectedOrderDelete.UseVisualStyleBackColor = false;
            // 
            // lvAllOrders
            // 
            this.lvAllOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lvAllOrders.FullRowSelect = true;
            this.lvAllOrders.GridLines = true;
            this.lvAllOrders.Location = new System.Drawing.Point(3, 3);
            this.lvAllOrders.Name = "lvAllOrders";
            this.lvAllOrders.Size = new System.Drawing.Size(555, 345);
            this.lvAllOrders.TabIndex = 6;
            this.lvAllOrders.UseCompatibleStateImageBehavior = false;
            this.lvAllOrders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 36;
            // 
            // columnHeaderTypes
            // 
            this.columnHeaderTypes.Text = "Rodzaje produktów";
            this.columnHeaderTypes.Width = 68;
            // 
            // columnHeaderAmount
            // 
            this.columnHeaderAmount.Text = "Ilośc produktów";
            this.columnHeaderAmount.Width = 66;
            // 
            // columnHeaderEndDate
            // 
            this.columnHeaderEndDate.Text = "Termin";
            this.columnHeaderEndDate.Width = 58;
            // 
            // columnHeaderCompany
            // 
            this.columnHeaderCompany.Text = "Zamawiający";
            this.columnHeaderCompany.Width = 87;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Cena";
            this.columnHeaderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderPrice.Width = 84;
            // 
            // columnHeaderCost
            // 
            this.columnHeaderCost.Text = "Koszt";
            // 
            // columnHeaderProfit
            // 
            this.columnHeaderProfit.Text = "Zysk";
            // 
            // lCopyright
            // 
            this.lCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lCopyright.AutoSize = true;
            this.lCopyright.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lCopyright.Location = new System.Drawing.Point(930, 9);
            this.lCopyright.Name = "lCopyright";
            this.lCopyright.Size = new System.Drawing.Size(155, 13);
            this.lCopyright.TabIndex = 1;
            this.lCopyright.Text = "© 2018 Jan Sudczak, Filip Strózik";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 634);
            this.Controls.Add(this.lCopyright);
            this.Controls.Add(this.splitContainerMain);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "MainWindow";
            this.Text = "SSprint";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.gbCurrentOrderParams.ResumeLayout(false);
            this.gbCurrentOrderParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentOrderImage)).EndInit();
            this.gbCurrentOrderData.ResumeLayout(false);
            this.gbCurrentOrderData.PerformLayout();
            this.splitContainerHorizLeft.Panel1.ResumeLayout(false);
            this.splitContainerHorizLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHorizLeft)).EndInit();
            this.splitContainerHorizLeft.ResumeLayout(false);
            this.panelProductSelector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericAddingProductAmount)).EndInit();
            this.gbSelectedOrderParams.ResumeLayout(false);
            this.gbSelectedOrderParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedOrderImage)).EndInit();
            this.gbSelectedOrderData.ResumeLayout(false);
            this.gbSelectedOrderData.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbCurrentOrderParams;
        private System.Windows.Forms.TextBox tbCurrentOrderEndDate;
        private System.Windows.Forms.Label lCurrentOrderEndDate;
        private System.Windows.Forms.Button btnCurrentOrderSetDate;
        private System.Windows.Forms.Button btnCurrentOrderBrowseImage;
        private System.Windows.Forms.Label lCurrentOrderPicture;
        private System.Windows.Forms.PictureBox pictureBoxCurrentOrderImage;
        private System.Windows.Forms.GroupBox gbCurrentOrderData;
        private System.Windows.Forms.Panel panelProductSelector;
        private System.Windows.Forms.NumericUpDown numericAddingProductAmount;
        private System.Windows.Forms.Button btnAddProductToOrder;
        private System.Windows.Forms.Button btnCurrentOrderAdd;
        private System.Windows.Forms.Button btnCurrentOrderCancel;
        private System.Windows.Forms.TextBox tbCurrentOrderPhone;
        private System.Windows.Forms.TextBox tbCurrentOrderEmail;
        private System.Windows.Forms.TextBox tbCurrentOrderName;
        private System.Windows.Forms.Label lCurrentOrderPhone;
        private System.Windows.Forms.Label lCurrentOrderEmail;
        private System.Windows.Forms.Label lCurrentOrderName;
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
        private System.Windows.Forms.Button btnSelectedOrderDelete;
        private System.Windows.Forms.GroupBox gbSelectedOrderParams;
        private System.Windows.Forms.ComboBox comboBoxSelectedOrderStatus;
        private System.Windows.Forms.Label lSelectedOrderStatus;
        private System.Windows.Forms.TextBox tbSelectedOrderStartDate;
        private System.Windows.Forms.Label lSelectedOrderStartDate;
        private System.Windows.Forms.TextBox tbSelectedOrderEndDate;
        private System.Windows.Forms.Label lSelectedOrderEndDate;
        private System.Windows.Forms.Button btnSelectedOrderSetEndDate;
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
    }
}

