namespace BaiTapWinForm.TH05c.VeNha2_ListBoxSo
{
    partial class frmListboxSo
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lstSo = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnXoaDauCuoi = new System.Windows.Forms.Button();
            this.btnXoaDangChon = new System.Windows.Forms.Button();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnBinhPhuong = new System.Windows.Forms.Button();
            this.btnChonChan = new System.Windows.Forms.Button();
            this.btnChonLe = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTieuDe.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTieuDe.Location = new System.Drawing.Point(12, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(446, 40);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "LISTBOX";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSo);
            this.groupBox1.Controls.Add(this.btnNhap);
            this.groupBox1.Controls.Add(this.lstSo);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 290);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listbox";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(12, 22);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(166, 20);
            this.txtSo.TabIndex = 0;
            this.txtSo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSo_KeyPress);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(12, 50);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(166, 28);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "&Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lstSo
            // 
            this.lstSo.FormattingEnabled = true;
            this.lstSo.ItemHeight = 13;
            this.lstSo.Location = new System.Drawing.Point(12, 88);
            this.lstSo.Name = "lstSo";
            this.lstSo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstSo.Size = new System.Drawing.Size(166, 186);
            this.lstSo.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTong);
            this.groupBox2.Controls.Add(this.btnXoaDauCuoi);
            this.groupBox2.Controls.Add(this.btnXoaDangChon);
            this.groupBox2.Controls.Add(this.btnTang2);
            this.groupBox2.Controls.Add(this.btnBinhPhuong);
            this.groupBox2.Controls.Add(this.btnChonChan);
            this.groupBox2.Controls.Add(this.btnChonLe);
            this.groupBox2.Location = new System.Drawing.Point(215, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 290);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xử lý Listbox";
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(15, 22);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(213, 28);
            this.btnTong.TabIndex = 0;
            this.btnTong.Text = "Tổng các phần tử trong List";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnXoaDauCuoi
            // 
            this.btnXoaDauCuoi.Location = new System.Drawing.Point(15, 60);
            this.btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            this.btnXoaDauCuoi.Size = new System.Drawing.Size(213, 28);
            this.btnXoaDauCuoi.TabIndex = 1;
            this.btnXoaDauCuoi.Text = "Xóa Phần tử đầu và cuối";
            this.btnXoaDauCuoi.UseVisualStyleBackColor = true;
            this.btnXoaDauCuoi.Click += new System.EventHandler(this.btnXoaDauCuoi_Click);
            // 
            // btnXoaDangChon
            // 
            this.btnXoaDangChon.Location = new System.Drawing.Point(15, 98);
            this.btnXoaDangChon.Name = "btnXoaDangChon";
            this.btnXoaDangChon.Size = new System.Drawing.Size(213, 28);
            this.btnXoaDangChon.TabIndex = 2;
            this.btnXoaDangChon.Text = "Xóa Phần tử đang chọn";
            this.btnXoaDangChon.UseVisualStyleBackColor = true;
            this.btnXoaDangChon.Click += new System.EventHandler(this.btnXoaDangChon_Click);
            // 
            // btnTang2
            // 
            this.btnTang2.Location = new System.Drawing.Point(15, 136);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(213, 28);
            this.btnTang2.TabIndex = 3;
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.UseVisualStyleBackColor = true;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // btnBinhPhuong
            // 
            this.btnBinhPhuong.Location = new System.Drawing.Point(15, 174);
            this.btnBinhPhuong.Name = "btnBinhPhuong";
            this.btnBinhPhuong.Size = new System.Drawing.Size(213, 28);
            this.btnBinhPhuong.TabIndex = 4;
            this.btnBinhPhuong.Text = "Thay bằng bình phương";
            this.btnBinhPhuong.UseVisualStyleBackColor = true;
            this.btnBinhPhuong.Click += new System.EventHandler(this.btnBinhPhuong_Click);
            // 
            // btnChonChan
            // 
            this.btnChonChan.Location = new System.Drawing.Point(15, 212);
            this.btnChonChan.Name = "btnChonChan";
            this.btnChonChan.Size = new System.Drawing.Size(213, 28);
            this.btnChonChan.TabIndex = 5;
            this.btnChonChan.Text = "Chọn số chẵn";
            this.btnChonChan.UseVisualStyleBackColor = true;
            this.btnChonChan.Click += new System.EventHandler(this.btnChonChan_Click);
            // 
            // btnChonLe
            // 
            this.btnChonLe.Location = new System.Drawing.Point(15, 250);
            this.btnChonLe.Name = "btnChonLe";
            this.btnChonLe.Size = new System.Drawing.Size(213, 28);
            this.btnChonLe.TabIndex = 6;
            this.btnChonLe.Text = "Chọn số lẻ";
            this.btnChonLe.UseVisualStyleBackColor = true;
            this.btnChonLe.Click += new System.EventHandler(this.btnChonLe_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(12, 360);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(446, 30);
            this.btnKetThuc.TabIndex = 3;
            this.btnKetThuc.Text = "&KẾT THÚC";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // frmListboxSo
            // 
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 400);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnKetThuc);
            this.Name = "frmListboxSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListbox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.ListBox lstSo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnXoaDauCuoi;
        private System.Windows.Forms.Button btnXoaDangChon;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnBinhPhuong;
        private System.Windows.Forms.Button btnChonChan;
        private System.Windows.Forms.Button btnChonLe;
        private System.Windows.Forms.Button btnKetThuc;
    }
}
