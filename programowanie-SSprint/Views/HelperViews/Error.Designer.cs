namespace programowanie_SSprint.Views.HelperViews
{
    partial class Error
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
            this.btnOk = new System.Windows.Forms.Button();
            this.lMessage = new System.Windows.Forms.Label();
            this.tbLongMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(375, 189);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Location = new System.Drawing.Point(12, 9);
            this.lMessage.MinimumSize = new System.Drawing.Size(400, 0);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(400, 13);
            this.lMessage.TabIndex = 2;
            this.lMessage.Text = "Short message";
            // 
            // tbLongMessage
            // 
            this.tbLongMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLongMessage.Location = new System.Drawing.Point(12, 70);
            this.tbLongMessage.Multiline = true;
            this.tbLongMessage.Name = "tbLongMessage";
            this.tbLongMessage.ReadOnly = true;
            this.tbLongMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLongMessage.Size = new System.Drawing.Size(438, 113);
            this.tbLongMessage.TabIndex = 3;
            this.tbLongMessage.Text = "Long\r\nmessage\r\n (hidden by default)";
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(462, 224);
            this.ControlBox = false;
            this.Controls.Add(this.tbLongMessage);
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.btnOk);
            this.MaximumSize = new System.Drawing.Size(900, 400);
            this.Name = "Error";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.TextBox tbLongMessage;
    }
}