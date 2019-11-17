namespace ltudql_seminar_qlbh
{
    partial class frmmain
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
            this.btthem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(112, 78);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(153, 118);
            this.btthem.TabIndex = 0;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(333, 78);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(157, 118);
            this.btSua.TabIndex = 1;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(535, 78);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(151, 118);
            this.btxoa.TabIndex = 2;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btthem);
            this.Name = "frmmain";
            this.Text = "frmmain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btxoa;
    }
}