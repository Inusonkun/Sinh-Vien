namespace SINH_VIÊN
{
    partial class Login
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
            this.btThoat = new System.Windows.Forms.Button();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(343, 179);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 0;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btDangNhap
            // 
            this.btDangNhap.Location = new System.Drawing.Point(262, 179);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btDangNhap.TabIndex = 1;
            this.btDangNhap.Text = "Đăng nhập";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.AutoSize = true;
            this.lbDangNhap.Location = new System.Drawing.Point(189, 91);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(81, 13);
            this.lbDangNhap.TabIndex = 2;
            this.lbDangNhap.Text = "Tên đăng nhập";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Location = new System.Drawing.Point(199, 121);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(52, 13);
            this.lbMatKhau.TabIndex = 3;
            this.lbMatKhau.Text = "Mật khẩu";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(276, 88);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(128, 20);
            this.txtUser.TabIndex = 4;
            this.txtUser.Text = "\r\n";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(276, 114);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(128, 20);
            this.txtPass.TabIndex = 5;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(408, 239);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(86, 13);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Quên mật khẩu?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SINH_VIÊN.Properties.Resources.Capture;
            this.pictureBox2.Location = new System.Drawing.Point(31, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(506, 261);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lbDangNhap);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.btThoat);
            this.Name = "Login";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}