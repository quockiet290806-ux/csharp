namespace BaiTapWinForm.TH05c.NangCao1_XuLyChuoi
{
    partial class frmChuoi
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
            this.btnNgauNhien = new System.Windows.Forms.Button();
            this.lstTen = new System.Windows.Forms.ListBox();
            this.btnXoaDangChon = new System.Windows.Forms.Button();
            this.btnXoaTenSon = new System.Windows.Forms.Button();
            this.btnXoaHoLe = new System.Windows.Forms.Button();
            this.btnChuHoa = new System.Windows.Forms.Button();
            this.btnChuThuong = new System.Windows.Forms.Button();
            this.btnHoaDauTu = new System.Windows.Forms.Button();
            this.btnXoaTatCa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNgauNhien
            // 
            this.btnNgauNhien.Location = new System.Drawing.Point(20, 15);
            this.btnNgauNhien.Name = "btnNgauNhien";
            this.btnNgauNhien.Size = new System.Drawing.Size(200, 30);
            this.btnNgauNhien.TabIndex = 0;
            this.btnNgauNhien.Text = "Nhập tên ngẫu nhiên";
            this.btnNgauNhien.UseVisualStyleBackColor = true;
            this.btnNgauNhien.Click += new System.EventHandler(this.btnNgauNhien_Click);
            // 
            // lstTen
            // 
            this.lstTen.FormattingEnabled = true;
            this.lstTen.ItemHeight = 13;
            this.lstTen.Location = new System.Drawing.Point(20, 55);
            this.lstTen.Name = "lstTen";
            this.lstTen.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTen.Size = new System.Drawing.Size(200, 329);
            this.lstTen.TabIndex = 1;
            this.lstTen.DoubleClick += new System.EventHandler(this.lstTen_DoubleClick);
            // 
            // btnXoaDangChon
            // 
            this.btnXoaDangChon.Location = new System.Drawing.Point(240, 55);
            this.btnXoaDangChon.Name = "btnXoaDangChon";
            this.btnXoaDangChon.Size = new System.Drawing.Size(340, 34);
            this.btnXoaDangChon.TabIndex = 2;
            this.btnXoaDangChon.Text = "Xóa Phần tử đang chọn";
            this.btnXoaDangChon.UseVisualStyleBackColor = true;
            this.btnXoaDangChon.Click += new System.EventHandler(this.btnXoaDangChon_Click);
            // 
            // btnXoaTenSon
            // 
            this.btnXoaTenSon.Location = new System.Drawing.Point(240, 101);
            this.btnXoaTenSon.Name = "btnXoaTenSon";
            this.btnXoaTenSon.Size = new System.Drawing.Size(340, 34);
            this.btnXoaTenSon.TabIndex = 3;
            this.btnXoaTenSon.Text = "Xóa phần tử có tên là Sơn";
            this.btnXoaTenSon.UseVisualStyleBackColor = true;
            this.btnXoaTenSon.Click += new System.EventHandler(this.btnXoaTenSon_Click);
            // 
            // btnXoaHoLe
            // 
            this.btnXoaHoLe.Location = new System.Drawing.Point(240, 147);
            this.btnXoaHoLe.Name = "btnXoaHoLe";
            this.btnXoaHoLe.Size = new System.Drawing.Size(340, 34);
            this.btnXoaHoLe.TabIndex = 4;
            this.btnXoaHoLe.Text = "Xóa Phần tử có họ là Lê";
            this.btnXoaHoLe.UseVisualStyleBackColor = true;
            this.btnXoaHoLe.Click += new System.EventHandler(this.btnXoaHoLe_Click);
            // 
            // btnChuHoa
            // 
            this.btnChuHoa.Location = new System.Drawing.Point(240, 193);
            this.btnChuHoa.Name = "btnChuHoa";
            this.btnChuHoa.Size = new System.Drawing.Size(340, 34);
            this.btnChuHoa.TabIndex = 5;
            this.btnChuHoa.Text = "Chuyển PT đang chọn thành chữ HOA";
            this.btnChuHoa.UseVisualStyleBackColor = true;
            this.btnChuHoa.Click += new System.EventHandler(this.btnChuHoa_Click);
            // 
            // btnChuThuong
            // 
            this.btnChuThuong.Location = new System.Drawing.Point(240, 239);
            this.btnChuThuong.Name = "btnChuThuong";
            this.btnChuThuong.Size = new System.Drawing.Size(340, 34);
            this.btnChuThuong.TabIndex = 6;
            this.btnChuThuong.Text = "Chuyển PT đang chọn thành chữ thường";
            this.btnChuThuong.UseVisualStyleBackColor = true;
            this.btnChuThuong.Click += new System.EventHandler(this.btnChuThuong_Click);
            // 
            // btnHoaDauTu
            // 
            this.btnHoaDauTu.Location = new System.Drawing.Point(240, 285);
            this.btnHoaDauTu.Name = "btnHoaDauTu";
            this.btnHoaDauTu.Size = new System.Drawing.Size(340, 34);
            this.btnHoaDauTu.TabIndex = 7;
            this.btnHoaDauTu.Text = "Chuyển PT đang chọn thành viết Hoa đầu mỗi từ";
            this.btnHoaDauTu.UseVisualStyleBackColor = true;
            this.btnHoaDauTu.Click += new System.EventHandler(this.btnHoaDauTu_Click);
            // 
            // btnXoaTatCa
            // 
            this.btnXoaTatCa.Location = new System.Drawing.Point(240, 331);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.Size = new System.Drawing.Size(340, 34);
            this.btnXoaTatCa.TabIndex = 8;
            this.btnXoaTatCa.Text = "Xóa tất cả các Phần tử";
            this.btnXoaTatCa.UseVisualStyleBackColor = true;
            this.btnXoaTatCa.Click += new System.EventHandler(this.btnXoaTatCa_Click);
            // 
            // frmChuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnNgauNhien);
            this.Controls.Add(this.lstTen);
            this.Controls.Add(this.btnXoaDangChon);
            this.Controls.Add(this.btnXoaTenSon);
            this.Controls.Add(this.btnXoaHoLe);
            this.Controls.Add(this.btnChuHoa);
            this.Controls.Add(this.btnChuThuong);
            this.Controls.Add(this.btnHoaDauTu);
            this.Controls.Add(this.btnXoaTatCa);
            this.Name = "frmChuoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChuoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNgauNhien;
        private System.Windows.Forms.ListBox lstTen;
        private System.Windows.Forms.Button btnXoaDangChon;
        private System.Windows.Forms.Button btnXoaTenSon;
        private System.Windows.Forms.Button btnXoaHoLe;
        private System.Windows.Forms.Button btnChuHoa;
        private System.Windows.Forms.Button btnChuThuong;
        private System.Windows.Forms.Button btnHoaDauTu;
        private System.Windows.Forms.Button btnXoaTatCa;
    }
}
