namespace programowanie_SSprint
{
    partial class ColorEditor
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Czerwony",
            "#ff0000"}, -1);
            this.lvColors = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxEditArea = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lID = new System.Windows.Forms.Label();
            this.btnApplyChanges = new System.Windows.Forms.Button();
            this.lHex = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.tbHex = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBoxColorList = new System.Windows.Forms.GroupBox();
            this.notificationPanel1 = new programowanie_SSprint.Views.HelperViews.NotificationPanel();
            this.groupBoxEditArea.SuspendLayout();
            this.groupBoxColorList.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvColors
            // 
            this.lvColors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvColors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderName,
            this.columnHeaderHex});
            this.lvColors.FullRowSelect = true;
            this.lvColors.GridLines = true;
            this.lvColors.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvColors.Location = new System.Drawing.Point(3, 16);
            this.lvColors.Name = "lvColors";
            this.lvColors.Size = new System.Drawing.Size(248, 178);
            this.lvColors.TabIndex = 0;
            this.lvColors.UseCompatibleStateImageBehavior = false;
            this.lvColors.View = System.Windows.Forms.View.Details;
            this.lvColors.SelectedIndexChanged += new System.EventHandler(this.lvColors_SelectedIndexChanged);
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
            // columnHeaderHex
            // 
            this.columnHeaderHex.Text = "Wartość HEX";
            this.columnHeaderHex.Width = 82;
            // 
            // groupBoxEditArea
            // 
            this.groupBoxEditArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEditArea.Controls.Add(this.btnCancel);
            this.groupBoxEditArea.Controls.Add(this.tbID);
            this.groupBoxEditArea.Controls.Add(this.lID);
            this.groupBoxEditArea.Controls.Add(this.btnApplyChanges);
            this.groupBoxEditArea.Controls.Add(this.lHex);
            this.groupBoxEditArea.Controls.Add(this.lName);
            this.groupBoxEditArea.Controls.Add(this.tbHex);
            this.groupBoxEditArea.Controls.Add(this.tbName);
            this.groupBoxEditArea.Location = new System.Drawing.Point(267, 42);
            this.groupBoxEditArea.Name = "groupBoxEditArea";
            this.groupBoxEditArea.Size = new System.Drawing.Size(196, 232);
            this.groupBoxEditArea.TabIndex = 2;
            this.groupBoxEditArea.TabStop = false;
            this.groupBoxEditArea.Text = "Edycja zaznaczonego koloru";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(6, 174);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(184, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbID
            // 
            this.tbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbID.Location = new System.Drawing.Point(33, 87);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(157, 20);
            this.tbID.TabIndex = 7;
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(6, 90);
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
            this.btnApplyChanges.Location = new System.Drawing.Point(6, 203);
            this.btnApplyChanges.Name = "btnApplyChanges";
            this.btnApplyChanges.Size = new System.Drawing.Size(184, 23);
            this.btnApplyChanges.TabIndex = 5;
            this.btnApplyChanges.Text = "Zapisz zmiany";
            this.btnApplyChanges.UseVisualStyleBackColor = false;
            this.btnApplyChanges.Click += new System.EventHandler(this.btnApplyChanges_Click);
            // 
            // lHex
            // 
            this.lHex.AutoSize = true;
            this.lHex.Location = new System.Drawing.Point(6, 65);
            this.lHex.Name = "lHex";
            this.lHex.Size = new System.Drawing.Size(75, 13);
            this.lHex.TabIndex = 3;
            this.lHex.Text = "Wartość HEX:";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lName.Location = new System.Drawing.Point(6, 37);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(49, 13);
            this.lName.TabIndex = 2;
            this.lName.Text = "Nazwa:";
            // 
            // tbHex
            // 
            this.tbHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHex.Location = new System.Drawing.Point(84, 62);
            this.tbHex.Name = "tbHex";
            this.tbHex.Size = new System.Drawing.Size(106, 20);
            this.tbHex.TabIndex = 1;
            this.tbHex.TextChanged += new System.EventHandler(this.tbHex_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(61, 34);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(129, 20);
            this.tbName.TabIndex = 0;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNew.Location = new System.Drawing.Point(173, 203);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Dodaj nowy";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(6, 203);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBoxColorList
            // 
            this.groupBoxColorList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxColorList.Controls.Add(this.lvColors);
            this.groupBoxColorList.Controls.Add(this.btnDelete);
            this.groupBoxColorList.Controls.Add(this.btnAddNew);
            this.groupBoxColorList.Location = new System.Drawing.Point(4, 42);
            this.groupBoxColorList.Name = "groupBoxColorList";
            this.groupBoxColorList.Size = new System.Drawing.Size(254, 232);
            this.groupBoxColorList.TabIndex = 5;
            this.groupBoxColorList.TabStop = false;
            this.groupBoxColorList.Text = "Lista wprowadzonych kolorów";
            // 
            // notificationPanel1
            // 
            this.notificationPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notificationPanel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.notificationPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notificationPanel1.Location = new System.Drawing.Point(7, 5);
            this.notificationPanel1.MinimumSize = new System.Drawing.Size(245, 20);
            this.notificationPanel1.Name = "notificationPanel1";
            this.notificationPanel1.NotificationTime = 8000;
            this.notificationPanel1.Size = new System.Drawing.Size(456, 31);
            this.notificationPanel1.TabIndex = 6;
            // 
            // ColorEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 286);
            this.Controls.Add(this.notificationPanel1);
            this.Controls.Add(this.groupBoxColorList);
            this.Controls.Add(this.groupBoxEditArea);
            this.MinimumSize = new System.Drawing.Size(457, 274);
            this.Name = "ColorEditor";
            this.Text = "Edytor kolorów";
            this.Load += new System.EventHandler(this.ColorEditor_Load);
            this.groupBoxEditArea.ResumeLayout(false);
            this.groupBoxEditArea.PerformLayout();
            this.groupBoxColorList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvColors;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderHex;
        private System.Windows.Forms.GroupBox groupBoxEditArea;
        private System.Windows.Forms.Button btnApplyChanges;
        private System.Windows.Forms.Label lHex;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbHex;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBoxColorList;
        private Views.HelperViews.NotificationPanel notificationPanel1;
    }
}