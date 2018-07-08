namespace programowanie_SSprint.Views.HelperViews
{
    partial class NotificationPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lText = new System.Windows.Forms.Label();
            this.theBgWorker = new System.ComponentModel.BackgroundWorker();
            this.lAmount = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lText
            // 
            this.lText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lText.AutoEllipsis = true;
            this.lText.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)), true);
            this.lText.Location = new System.Drawing.Point(33, 1);
            this.lText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.lText.Name = "lText";
            this.lText.Size = new System.Drawing.Size(236, 25);
            this.lText.TabIndex = 0;
            this.lText.Text = "dsdsdgasdgsdgasdgsdgas dgasdas gdasg asd dgas gdasg ds g";
            // 
            // lAmount
            // 
            this.lAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lAmount.Location = new System.Drawing.Point(266, -4);
            this.lAmount.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lAmount.Name = "lAmount";
            this.lAmount.Size = new System.Drawing.Size(38, 27);
            this.lAmount.TabIndex = 2;
            this.lAmount.Text = "(3)";
            this.lAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(35, 28);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 1;
            this.pictureBoxIcon.TabStop = false;
            // 
            // NotificationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lAmount);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.lText);
            this.MinimumSize = new System.Drawing.Size(245, 20);
            this.Name = "NotificationPanel";
            this.Size = new System.Drawing.Size(307, 28);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lText;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.ComponentModel.BackgroundWorker theBgWorker;
        private System.Windows.Forms.Label lAmount;
    }
}
