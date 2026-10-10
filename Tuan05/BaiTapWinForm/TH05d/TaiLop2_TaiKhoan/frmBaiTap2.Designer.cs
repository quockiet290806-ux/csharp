namespace BaiTapWinForm.TH05d.TaiLop2_TaiKhoan
{
    partial class frmBaiTap2
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
            this.txtSoTK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lvTaiKhoan = new System.Windows.Forms.ListView();
            this.colSTT = new System.Windows.Forms.ColumnHeader();
            this.colSoTK = new System.Windows.Forms.ColumnHeader();
            this.colTenKH = new System.Windows.Forms.ColumnHeader();
            this.colDiaChi = new System.Windows.Forms.ColumnHeader();
            this.colSoTien = new System.Windows.Forms.ColumnHeader();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tài khoản";
            // 
            // txtSoTK
            // 
            this.txtSoTK.Location = new System.Drawing.Point(220, 59);
            this.txtSoTK.Name = "txtSoTK";
            this.txtSoTK.Size = new System.Drawing.Size(350, 20);
            this.txtSoTK.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên khách hàng";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(220, 89);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(350, 20);
            this.txtTenKH.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Địa chỉ khách hàng";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(220, 119);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(350, 20);
            this.txtDiaChi.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số tiền trong tài khoản";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(220, 149);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(350, 20);
            this.txtSoTien.TabIndex = 8;
            this.txtSoTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTien_KeyPress);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(220, 182);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 26);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(310, 182);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 26);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(400, 182);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 26);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(490, 182);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 26);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lvTaiKhoan
            // 
            this.lvTaiKhoan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colSoTK,
            this.colTenKH,
            this.colDiaChi,
            this.colSoTien});
            this.lvTaiKhoan.FullRowSelect = true;
            this.lvTaiKhoan.GridLines = true;
            this.lvTaiKhoan.HideSelection = false;
            this.lvTaiKhoan.Location = new System.Drawing.Point(12, 220);
            this.lvTaiKhoan.MultiSelect = false;
            this.lvTaiKhoan.Name = "lvTaiKhoan";
            this.lvTaiKhoan.Size = new System.Drawing.Size(576, 165);
            this.lvTaiKhoan.TabIndex = 13;
            this.lvTaiKhoan.UseCompatibleStateImageBehavior = false;
            this.lvTaiKhoan.View = System.Windows.Forms.View.Details;
            this.lvTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.lvTaiKhoan_SelectedIndexChanged);
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            this.colSTT.Width = 50;
            // 
            // colSoTK
            // 
            this.colSoTK.Text = "Số tài khoản";
            this.colSoTK.Width = 120;
            // 
            // colTenKH
            // 
            this.colTenKH.Text = "Tên khách hàng";
            this.colTenKH.Width = 150;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ";
            this.colDiaChi.Width = 130;
            // 
            // colSoTien
            // 
            this.colSoTien.Text = "Số tiền";
            this.colSoTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colSoTien.Width = 110;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(450, 395);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(138, 20);
            this.txtTongTien.TabIndex = 15;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmBaiTap2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoTK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lvTaiKhoan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTongTien);
            this.Name = "frmBaiTap2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaiTap2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView lvTaiKhoan;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colSoTK;
        private System.Windows.Forms.ColumnHeader colTenKH;
        private System.Windows.Forms.ColumnHeader colDiaChi;
        private System.Windows.Forms.ColumnHeader colSoTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongTien;
    }
}
