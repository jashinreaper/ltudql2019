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
            this.tbdangnhap = new System.Windows.Forms.TextBox();
            this.tbmatkhau = new System.Windows.Forms.TextBox();
            this.cbnhomatkhau = new System.Windows.Forms.CheckBox();
            this.btxacnhan = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // tbdangnhap
            // 
            this.tbdangnhap.Location = new System.Drawing.Point(294, 106);
            this.tbdangnhap.Name = "tbdangnhap";
            this.tbdangnhap.Size = new System.Drawing.Size(284, 22);
            this.tbdangnhap.TabIndex = 2;
            // 
            // tbmatkhau
            // 
            this.tbmatkhau.Location = new System.Drawing.Point(294, 157);
            this.tbmatkhau.Name = "tbmatkhau";
            this.tbmatkhau.Size = new System.Drawing.Size(284, 22);
            this.tbmatkhau.TabIndex = 3;
            // 
            // cbnhomatkhau
            // 
            this.cbnhomatkhau.AutoSize = true;
            this.cbnhomatkhau.Location = new System.Drawing.Point(460, 198);
            this.cbnhomatkhau.Name = "cbnhomatkhau";
            this.cbnhomatkhau.Size = new System.Drawing.Size(118, 21);
            this.cbnhomatkhau.TabIndex = 4;
            this.cbnhomatkhau.Text = "Nhớ mật khẩu";
            this.cbnhomatkhau.UseVisualStyleBackColor = true;
            this.cbnhomatkhau.CheckedChanged += new System.EventHandler(this.cbnhomatkhau_CheckedChanged);
            // 
            // btxacnhan
            // 
            this.btxacnhan.Location = new System.Drawing.Point(304, 253);
            this.btxacnhan.Name = "btxacnhan";
            this.btxacnhan.Size = new System.Drawing.Size(101, 38);
            this.btxacnhan.TabIndex = 5;
            this.btxacnhan.Text = "Xác nhận";
            this.btxacnhan.UseVisualStyleBackColor = true;
            this.btxacnhan.Click += new System.EventHandler(this.btxacnhan_Click);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(460, 253);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(94, 38);
            this.btthoat.TabIndex = 6;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btxacnhan);
            this.Controls.Add(this.cbnhomatkhau);
            this.Controls.Add(this.tbmatkhau);
            this.Controls.Add(this.tbdangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmlogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbdangnhap;
        private System.Windows.Forms.TextBox tbmatkhau;
        private System.Windows.Forms.CheckBox cbnhomatkhau;
        private System.Windows.Forms.Button btxacnhan;
        private System.Windows.Forms.Button btthoat;
    }
}

