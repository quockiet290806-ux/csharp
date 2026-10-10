namespace BaiTapWinForm.Bai07_CSDL.NangCao1_QLSinhVien
{
    partial class frmQLSinhVien
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
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã lớp";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(160, 62);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(230, 20);
            this.txtMaLop.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã sinh viên";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(160, 97);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(230, 20);
            this.txtMaSV.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên sinh viên";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(160, 132);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(230, 20);
            this.txtTenSV.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày sinh";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(160, 167);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(230, 20);
            this.txtNgaySinh.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(160, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "(nhập theo dạng ngày/tháng/năm)";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(70, 210);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 30);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(177, 210);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 30);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(284, 210);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 30);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmQLSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 258);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Name = "frmQLSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}
