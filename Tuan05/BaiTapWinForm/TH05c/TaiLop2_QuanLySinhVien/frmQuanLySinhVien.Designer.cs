namespace BaiTapWinForm.TH05c.TaiLop2_QuanLySinhVien
{
    partial class frmQuanLySinhVien
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
            this.trvLop = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.grpSinhVien = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.chkThemLop = new System.Windows.Forms.CheckBox();
            this.grpLop = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.grpSinhVien.SuspendLayout();
            this.grpLop.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvLop
            // 
            this.trvLop.HideSelection = false;
            this.trvLop.Location = new System.Drawing.Point(12, 12);
            this.trvLop.Name = "trvLop";
            this.trvLop.Size = new System.Drawing.Size(230, 356);
            this.trvLop.TabIndex = 0;
            this.trvLop.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvLop_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn Lớp";
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(335, 21);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(280, 21);
            this.cboLop.TabIndex = 2;
            // 
            // grpSinhVien
            // 
            this.grpSinhVien.Controls.Add(this.label2);
            this.grpSinhVien.Controls.Add(this.txtMaSV);
            this.grpSinhVien.Controls.Add(this.label3);
            this.grpSinhVien.Controls.Add(this.txtHoTen);
            this.grpSinhVien.Controls.Add(this.label4);
            this.grpSinhVien.Controls.Add(this.txtDiaChi);
            this.grpSinhVien.Controls.Add(this.btnCapNhat);
            this.grpSinhVien.Controls.Add(this.btnXoa);
            this.grpSinhVien.Location = new System.Drawing.Point(255, 55);
            this.grpSinhVien.Name = "grpSinhVien";
            this.grpSinhVien.Size = new System.Drawing.Size(373, 195);
            this.grpSinhVien.TabIndex = 3;
            this.grpSinhVien.TabStop = false;
            this.grpSinhVien.Text = "Thông tin sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã SV:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(80, 30);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(270, 20);
            this.txtMaSV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(80, 70);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(270, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa Chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(80, 110);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(270, 20);
            this.txtDiaChi.TabIndex = 5;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(80, 150);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(150, 30);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(250, 150);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // chkThemLop
            // 
            this.chkThemLop.AutoSize = true;
            this.chkThemLop.Location = new System.Drawing.Point(258, 262);
            this.chkThemLop.Name = "chkThemLop";
            this.chkThemLop.Size = new System.Drawing.Size(70, 17);
            this.chkThemLop.TabIndex = 4;
            this.chkThemLop.Text = "Thêm lớp";
            this.chkThemLop.UseVisualStyleBackColor = true;
            this.chkThemLop.CheckedChanged += new System.EventHandler(this.chkThemLop_CheckedChanged);
            // 
            // grpLop
            // 
            this.grpLop.Controls.Add(this.label5);
            this.grpLop.Controls.Add(this.txtTenLop);
            this.grpLop.Controls.Add(this.btnThemLop);
            this.grpLop.Location = new System.Drawing.Point(255, 285);
            this.grpLop.Name = "grpLop";
            this.grpLop.Size = new System.Drawing.Size(373, 65);
            this.grpLop.TabIndex = 5;
            this.grpLop.TabStop = false;
            this.grpLop.Text = "Thông tin lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên lớp";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(80, 27);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(160, 20);
            this.txtTenLop.TabIndex = 1;
            // 
            // btnThemLop
            // 
            this.btnThemLop.Location = new System.Drawing.Point(255, 25);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(95, 25);
            this.btnThemLop.TabIndex = 2;
            this.btnThemLop.Text = "Thêm lớp";
            this.btnThemLop.UseVisualStyleBackColor = true;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // frmQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 380);
            this.Controls.Add(this.trvLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.grpSinhVien);
            this.Controls.Add(this.chkThemLop);
            this.Controls.Add(this.grpLop);
            this.Name = "frmQuanLySinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.frmQuanLySinhVien_Load);
            this.grpSinhVien.ResumeLayout(false);
            this.grpSinhVien.PerformLayout();
            this.grpLop.ResumeLayout(false);
            this.grpLop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trvLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.GroupBox grpSinhVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.CheckBox chkThemLop;
        private System.Windows.Forms.GroupBox grpLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Button btnThemLop;
    }
}
