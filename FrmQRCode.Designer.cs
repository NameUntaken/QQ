namespace QQ2018
{
    partial class FrmQRCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQRCode));
            this.btnBackToLigin = new System.Windows.Forms.Button();
            this.picQRQQ = new System.Windows.Forms.PictureBox();
            this.picQRCode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQRQQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackToLigin
            // 
            this.btnBackToLigin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBackToLigin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToLigin.ForeColor = System.Drawing.Color.White;
            this.btnBackToLigin.Location = new System.Drawing.Point(146, 324);
            this.btnBackToLigin.Name = "btnBackToLigin";
            this.btnBackToLigin.Size = new System.Drawing.Size(229, 55);
            this.btnBackToLigin.TabIndex = 0;
            this.btnBackToLigin.Text = "返回";
            this.btnBackToLigin.UseVisualStyleBackColor = false;
            this.btnBackToLigin.Click += new System.EventHandler(this.btnBackToLigin_Click);
            // 
            // picQRQQ
            // 
            this.picQRQQ.BackColor = System.Drawing.Color.Transparent;
            this.picQRQQ.BackgroundImage = global::QQ2018.Properties.Resources.qq;
            this.picQRQQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picQRQQ.Location = new System.Drawing.Point(12, 12);
            this.picQRQQ.Name = "picQRQQ";
            this.picQRQQ.Size = new System.Drawing.Size(50, 50);
            this.picQRQQ.TabIndex = 1;
            this.picQRQQ.TabStop = false;
            // 
            // picQRCode
            // 
            this.picQRCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picQRCode.BackgroundImage")));
            this.picQRCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picQRCode.Location = new System.Drawing.Point(168, 100);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(178, 178);
            this.picQRCode.TabIndex = 2;
            this.picQRCode.TabStop = false;
            // 
            // FrmQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(532, 412);
            this.Controls.Add(this.picQRCode);
            this.Controls.Add(this.picQRQQ);
            this.Controls.Add(this.btnBackToLigin);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQRCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmQRCode";
            ((System.ComponentModel.ISupportInitialize)(this.picQRQQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackToLigin;
        private System.Windows.Forms.PictureBox picQRQQ;
        private System.Windows.Forms.PictureBox picQRCode;
    }
}