namespace ltudql_seminar_qlbh
{
    partial class frmlogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbnhomatkhau = new System.Windows.Forms.CheckBox();
            this.btxacnhan = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(220, 86);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(214, 20);
            this.tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(220, 128);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(214, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // cbnhomatkhau
            // 
            this.cbnhomatkhau.AutoSize = true;
            this.cbnhomatkhau.Location = new System.Drawing.Point(345, 161);
            this.cbnhomatkhau.Margin = new System.Windows.Forms.Padding(2);
            this.cbnhomatkhau.Name = "cbnhomatkhau";
            this.cbnhomatkhau.Size = new System.Drawing.Size(93, 17);
            this.cbnhomatkhau.TabIndex = 4;
            this.cbnhomatkhau.Text = "Nhớ tài khoản";
            this.cbnhomatkhau.UseVisualStyleBackColor = true;
            this.cbnhomatkhau.CheckedChanged += new System.EventHandler(this.cbnhomatkhau_CheckedChanged);
            // 
            // btxacnhan
            // 
            this.btxacnhan.Location = new System.Drawing.Point(228, 206);
            this.btxacnhan.Margin = new System.Windows.Forms.Padding(2);
            this.btxacnhan.Name = "btxacnhan";
            this.btxacnhan.Size = new System.Drawing.Size(76, 31);
            this.btxacnhan.TabIndex = 5;
            this.btxacnhan.Text = "Xác nhận";
            this.btxacnhan.UseVisualStyleBackColor = true;
            this.btxacnhan.Click += new System.EventHandler(this.btxacnhan_Click);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(345, 206);
            this.btthoat.Margin = new System.Windows.Forms.Padding(2);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(70, 31);
            this.btthoat.TabIndex = 6;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btxacnhan);
            this.Controls.Add(this.cbnhomatkhau);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmlogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.CheckBox cbnhomatkhau;
        private System.Windows.Forms.Button btxacnhan;
        private System.Windows.Forms.Button btthoat;
    }
}

