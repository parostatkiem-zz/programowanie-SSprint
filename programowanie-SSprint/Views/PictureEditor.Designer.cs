namespace programowanie_SSprint
{
    partial class PictureEditor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Słoneczko",
            "JanuszSoft"}, -1);
            this.lvPictures = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLastUsedIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxEditArea = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBoxGraphics = new System.Windows.Forms.PictureBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lID = new System.Windows.Forms.Label();
            this.btnApplyChanges = new System.Windows.Forms.Button();
            this.lName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBoxGraphicList = new System.Windows.Forms.GroupBox();
            this.btnChooseSelected = new System.Windows.Forms.Button();
            this.notificationPanel1 = new programowanie_SSprint.Views.HelperViews.NotificationPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxEditArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraphics)).BeginInit();
            this.groupBoxGraphicList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvPictures
            // 
            this.lvPictures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPictures.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderName,
            this.columnHeaderLastUsedIn});
            this.lvPictures.FullRowSelect = true;
            this.lvPictures.GridLines = true;
            this.lvPictures.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvPictures.Location = new System.Drawing.Point(3, 16);
            this.lvPictures.Name = "lvPictures";
            this.lvPictures.Size = new System.Drawing.Size(356, 205);
            this.lvPictures.TabIndex = 0;
            this.lvPictures.UseCompatibleStateImageBehavior = false;
            this.lvPictures.View = System.Windows.Forms.View.Details;
            this.lvPictures.SelectedIndexChanged += new System.EventHandler(this.lvPictures_SelectedIndexChanged);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 44;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Nazwa";
            this.columnHeaderName.Width = 81;
            // 
            // columnHeaderLastUsedIn
            // 
            this.columnHeaderLastUsedIn.Text = "Ostatnio użyta dla firmy";
            this.columnHeaderLastUsedIn.Width = 128;
            // 
            // groupBoxEditArea
            // 
            this.groupBoxEditArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEditArea.Controls.Add(this.btnCancel);
            this.groupBoxEditArea.Controls.Add(this.pictureBoxGraphics);
            this.groupBoxEditArea.Controls.Add(this.tbID);
            this.groupBoxEditArea.Controls.Add(this.lID);
            this.groupBoxEditArea.Controls.Add(this.btnApplyChanges);
            this.groupBoxEditArea.Controls.Add(this.lName);
            this.groupBoxEditArea.Controls.Add(this.tbName);
            this.groupBoxEditArea.Location = new System.Drawing.Point(380, 47);
            this.groupBoxEditArea.Name = "groupBoxEditArea";
            this.groupBoxEditArea.Size = new System.Drawing.Size(196, 256);
            this.groupBoxEditArea.TabIndex = 0;
            this.groupBoxEditArea.TabStop = false;
            this.groupBoxEditArea.Text = "Edycja zaznaczonej grafiki";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(6, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(184, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBoxGraphics
            // 
            this.pictureBoxGraphics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxGraphics.Image = global::programowanie_SSprint.Properties.Resources.empty_image;
            this.pictureBoxGraphics.InitialImage = global::programowanie_SSprint.Properties.Resources.empty_image;
            this.pictureBoxGraphics.Location = new System.Drawing.Point(9, 71);
            this.pictureBoxGraphics.Name = "pictureBoxGraphics";
            this.pictureBoxGraphics.Size = new System.Drawing.Size(181, 113);
            this.pictureBoxGraphics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGraphics.TabIndex = 8;
            this.pictureBoxGraphics.TabStop = false;
            // 
            // tbID
            // 
            this.tbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbID.Location = new System.Drawing.Point(33, 45);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(140, 20);
            this.tbID.TabIndex = 7;
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(6, 48);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(21, 13);
            this.lID.TabIndex = 6;
            this.lID.Text = "ID:";
            // 
            // btnApplyChanges
            // 
            this.btnApplyChanges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyChanges.BackColor = System.Drawing.Color.LightGreen;
            this.btnApplyChanges.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApplyChanges.Location = new System.Drawing.Point(6, 227);
            this.btnApplyChanges.Name = "btnApplyChanges";
            this.btnApplyChanges.Size = new System.Drawing.Size(184, 23);
            this.btnApplyChanges.TabIndex = 2;
            this.btnApplyChanges.Text = "Zapisz zmiany";
            this.btnApplyChanges.UseVisualStyleBackColor = false;
            this.btnApplyChanges.Click += new System.EventHandler(this.btnApplyChanges_Click);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lName.Location = new System.Drawing.Point(6, 22);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(49, 13);
            this.lName.TabIndex = 2;
            this.lName.Text = "Nazwa:";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(61, 19);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(112, 20);
            this.tbName.TabIndex = 0;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNew.Location = new System.Drawing.Point(281, 227);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Dodaj nową";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(6, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBoxGraphicList
            // 
            this.groupBoxGraphicList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGraphicList.Controls.Add(this.btnChooseSelected);
            this.groupBoxGraphicList.Controls.Add(this.lvPictures);
            this.groupBoxGraphicList.Controls.Add(this.btnAddNew);
            this.groupBoxGraphicList.Controls.Add(this.btnDelete);
            this.groupBoxGraphicList.Location = new System.Drawing.Point(12, 47);
            this.groupBoxGraphicList.Name = "groupBoxGraphicList";
            this.groupBoxGraphicList.Size = new System.Drawing.Size(362, 256);
            this.groupBoxGraphicList.TabIndex = 5;
            this.groupBoxGraphicList.TabStop = false;
            this.groupBoxGraphicList.Text = "Lista dostępnych grafik";
            // 
            // btnChooseSelected
            // 
            this.btnChooseSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseSelected.BackColor = System.Drawing.Color.LightGreen;
            this.btnChooseSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChooseSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChooseSelected.Location = new System.Drawing.Point(87, 227);
            this.btnChooseSelected.Name = "btnChooseSelected";
            this.btnChooseSelected.Size = new System.Drawing.Size(188, 23);
            this.btnChooseSelected.TabIndex = 9;
            this.btnChooseSelected.Text = "Wybierz zaznaczony element";
            this.btnChooseSelected.UseVisualStyleBackColor = false;
            this.btnChooseSelected.Click += new System.EventHandler(this.btnChooseSelected_Click);
            // 
            // notificationPanel1
            // 
            this.notificationPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notificationPanel1.BackColor = System.Drawing.Color.White;
            this.notificationPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notificationPanel1.Location = new System.Drawing.Point(12, 12);
            this.notificationPanel1.MinimumSize = new System.Drawing.Size(245, 20);
            this.notificationPanel1.Name = "notificationPanel1";
            this.notificationPanel1.NotificationTime = 6000;
            this.notificationPanel1.Size = new System.Drawing.Size(564, 28);
            this.notificationPanel1.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PictureEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 315);
            this.Controls.Add(this.notificationPanel1);
            this.Controls.Add(this.groupBoxGraphicList);
            this.Controls.Add(this.groupBoxEditArea);
            this.MinimumSize = new System.Drawing.Size(510, 320);
            this.Name = "PictureEditor";
            this.Text = "Edytor grafik";
            this.Load += new System.EventHandler(this.PictureEditor_Load);
            this.groupBoxEditArea.ResumeLayout(false);
            this.groupBoxEditArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraphics)).EndInit();
            this.groupBoxGraphicList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPictures;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderLastUsedIn;
        private System.Windows.Forms.GroupBox groupBoxEditArea;
        private System.Windows.Forms.Button btnApplyChanges;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.PictureBox pictureBoxGraphics;
        private System.Windows.Forms.GroupBox groupBoxGraphicList;
        private System.Windows.Forms.Button btnCancel;
        private Views.HelperViews.NotificationPanel notificationPanel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnChooseSelected;
    }
}