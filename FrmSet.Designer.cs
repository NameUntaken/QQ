namespace QQ2018
{
    partial class FrmSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSet));
            this.btnBackToLoginFramSet = new System.Windows.Forms.Button();
            this.lblIntSet = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblLogPort = new System.Windows.Forms.Label();
            this.lblToServer = new System.Windows.Forms.Label();
            this.lblLogAddress = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtQQPort = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtQQAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBackToLoginFramSet
            // 
            this.btnBackToLoginFramSet.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBackToLoginFramSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToLoginFramSet.Location = new System.Drawing.Point(125, 317);
            this.btnBackToLoginFramSet.Name = "btnBackToLoginFramSet";
            this.btnBackToLoginFramSet.Size = new System.Drawing.Size(230, 57);
            this.btnBackToLoginFramSet.TabIndex = 0;
            this.btnBackToLoginFramSet.Text = "返回";
            this.btnBackToLoginFramSet.UseVisualStyleBackColor = false;
            this.btnBackToLoginFramSet.Click += new System.EventHandler(this.btnBackToLoginFramSet_Click);
            // 
            // lblIntSet
            // 
            this.lblIntSet.BackColor = System.Drawing.Color.Transparent;
            this.lblIntSet.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIntSet.ForeColor = System.Drawing.Color.Black;
            this.lblIntSet.Location = new System.Drawing.Point(12, 42);
            this.lblIntSet.Name = "lblIntSet";
            this.lblIntSet.Size = new System.Drawing.Size(100, 23);
            this.lblIntSet.TabIndex = 1;
            this.lblIntSet.Text = "网络设置";
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblType.ForeColor = System.Drawing.Color.Black;
            this.lblType.Location = new System.Drawing.Point(25, 98);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(100, 23);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "类型";
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(156, 98);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 23);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "地址";
            // 
            // lblPort
            // 
            this.lblPort.BackColor = System.Drawing.Color.Transparent;
            this.lblPort.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPort.ForeColor = System.Drawing.Color.Black;
            this.lblPort.Location = new System.Drawing.Point(312, 98);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(100, 23);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "端口";
            // 
            // lblLogPort
            // 
            this.lblLogPort.BackColor = System.Drawing.Color.Transparent;
            this.lblLogPort.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLogPort.ForeColor = System.Drawing.Color.Black;
            this.lblLogPort.Location = new System.Drawing.Point(326, 247);
            this.lblLogPort.Name = "lblLogPort";
            this.lblLogPort.Size = new System.Drawing.Size(56, 23);
            this.lblLogPort.TabIndex = 1;
            this.lblLogPort.Text = "端口";
            // 
            // lblToServer
            // 
            this.lblToServer.BackColor = System.Drawing.Color.Transparent;
            this.lblToServer.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblToServer.ForeColor = System.Drawing.Color.Black;
            this.lblToServer.Location = new System.Drawing.Point(12, 202);
            this.lblToServer.Name = "lblToServer";
            this.lblToServer.Size = new System.Drawing.Size(150, 20);
            this.lblToServer.TabIndex = 1;
            this.lblToServer.Text = "登录到服务器";
            // 
            // lblLogAddress
            // 
            this.lblLogAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblLogAddress.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLogAddress.ForeColor = System.Drawing.Color.Black;
            this.lblLogAddress.Location = new System.Drawing.Point(156, 247);
            this.lblLogAddress.Name = "lblLogAddress";
            this.lblLogAddress.Size = new System.Drawing.Size(55, 23);
            this.lblLogAddress.TabIndex = 1;
            this.lblLogAddress.Text = "地址";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(80, 98);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(70, 25);
            this.txtType.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(217, 98);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(70, 25);
            this.txtAddress.TabIndex = 2;
            // 
            // txtQQPort
            // 
            this.txtQQPort.Location = new System.Drawing.Point(388, 245);
            this.txtQQPort.Name = "txtQQPort";
            this.txtQQPort.Size = new System.Drawing.Size(70, 25);
            this.txtQQPort.TabIndex = 2;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(391, 96);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(70, 25);
            this.txtPort.TabIndex = 2;
            // 
            // txtQQAddress
            // 
            this.txtQQAddress.Location = new System.Drawing.Point(217, 245);
            this.txtQQAddress.Name = "txtQQAddress";
            this.txtQQAddress.Size = new System.Drawing.Size(70, 25);
            this.txtQQAddress.TabIndex = 2;
            // 
            // FrmSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(532, 412);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtQQPort);
            this.Controls.Add(this.txtQQAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblLogAddress);
            this.Controls.Add(this.lblToServer);
            this.Controls.Add(this.lblLogPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblIntSet);
            this.Controls.Add(this.btnBackToLoginFramSet);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmSet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackToLoginFramSet;
        private System.Windows.Forms.Label lblIntSet;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblLogPort;
        private System.Windows.Forms.Label lblToServer;
        private System.Windows.Forms.Label lblLogAddress;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtQQPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtQQAddress;
    }
}