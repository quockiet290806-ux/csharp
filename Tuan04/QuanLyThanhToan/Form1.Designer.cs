namespace KhachSanThanhThanh
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // =========================
        // TIÊU ĐỀ
        // =========================
        private System.Windows.Forms.Label lblTieuDe;

        // =========================
        // THÔNG TIN KHÁCH HÀNG
        // =========================
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblSoNgay;

        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoNgay;

        // =========================
        // LOẠI PHÒNG
        // =========================
        private System.Windows.Forms.GroupBox grpLoaiPhong;
        private System.Windows.Forms.RadioButton radPhongDon;
        private System.Windows.Forms.RadioButton radPhongDoi;
        private System.Windows.Forms.RadioButton radPhongBa;

        // =========================
        // TIỆN NGHI
        // =========================
        private System.Windows.Forms.GroupBox grpTienNghi;
        private System.Windows.Forms.CheckBox chkTV;
        private System.Windows.Forms.CheckBox chkInternet;
        private System.Windows.Forms.CheckBox chkMayNuocNong;

        // =========================
        // DỊCH VỤ
        // =========================
        private System.Windows.Forms.GroupBox grpDichVu;
        private System.Windows.Forms.CheckBox chkKaraoke;
        private System.Windows.Forms.CheckBox chkAnSang;

        // =========================
        // BÊN PHẢI
        // =========================
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnNhapMoi;

        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.TextBox txtThanhTien;

        private System.Windows.Forms.Button btnTongKet;

        private System.Windows.Forms.Label lblThongKe;

        private System.Windows.Forms.Label lblSoNguoi;
        private System.Windows.Forms.TextBox txtSoNguoi;

        private System.Windows.Forms.Label lblTongSoTien;
        private System.Windows.Forms.TextBox txtTongSoTien;

        private System.Windows.Forms.Button btnThoat;

        // =========================
        // ĐƯỜNG PHÂN CÁCH
        // =========================
        private System.Windows.Forms.Panel panelDuongPhanCach;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();

            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSoNgay = new System.Windows.Forms.Label();

            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoNgay = new System.Windows.Forms.TextBox();

            this.grpLoaiPhong = new System.Windows.Forms.GroupBox();
            this.radPhongDon = new System.Windows.Forms.RadioButton();
            this.radPhongDoi = new System.Windows.Forms.RadioButton();
            this.radPhongBa = new System.Windows.Forms.RadioButton();

            this.grpTienNghi = new System.Windows.Forms.GroupBox();
            this.chkTV = new System.Windows.Forms.CheckBox();
            this.chkInternet = new System.Windows.Forms.CheckBox();
            this.chkMayNuocNong = new System.Windows.Forms.CheckBox();

            this.grpDichVu = new System.Windows.Forms.GroupBox();
            this.chkKaraoke = new System.Windows.Forms.CheckBox();
            this.chkAnSang = new System.Windows.Forms.CheckBox();

            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnNhapMoi = new System.Windows.Forms.Button();

            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();

            this.btnTongKet = new System.Windows.Forms.Button();

            this.lblThongKe = new System.Windows.Forms.Label();

            this.lblSoNguoi = new System.Windows.Forms.Label();
            this.txtSoNguoi = new System.Windows.Forms.TextBox();

            this.lblTongSoTien = new System.Windows.Forms.Label();
            this.txtTongSoTien = new System.Windows.Forms.TextBox();

            this.btnThoat = new System.Windows.Forms.Button();

            this.panelDuongPhanCach = new System.Windows.Forms.Panel();

            this.SuspendLayout();

            // =========================================================
            // FORM
            // =========================================================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(700, 350);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Name = "Form1";

            this.Text =
                "frmDangKyKS";

            // =========================================================
            // TIÊU ĐỀ
            // =========================================================

            this.lblTieuDe.AutoSize = true;

            this.lblTieuDe.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif",
                    16F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblTieuDe.ForeColor =
                System.Drawing.Color.DarkOrange;

            this.lblTieuDe.Location =
                new System.Drawing.Point(185, 8);

            this.lblTieuDe.Name =
                "lblTieuDe";

            this.lblTieuDe.Size =
                new System.Drawing.Size(375, 26);

            this.lblTieuDe.TabIndex = 0;

            this.lblTieuDe.Text =
                "KHÁCH SẠN THANH THÀNH - TRẢ PHÒNG";

            // =========================================================
            // ĐƯỜNG PHÂN CÁCH DƯỚI TIÊU ĐỀ
            // =========================================================

            this.panelDuongPhanCach.BackColor =
                System.Drawing.SystemColors.ControlDark;

            this.panelDuongPhanCach.Location =
                new System.Drawing.Point(10, 48);

            this.panelDuongPhanCach.Name =
                "panelDuongPhanCach";

            this.panelDuongPhanCach.Size =
                new System.Drawing.Size(680, 1);

            // =========================================================
            // HỌ VÀ TÊN
            // =========================================================

            this.lblHoTen.AutoSize = true;

            this.lblHoTen.Location =
                new System.Drawing.Point(28, 72);

            this.lblHoTen.Name =
                "lblHoTen";

            this.lblHoTen.Text =
                "Họ và tên:";

            // TextBox họ tên
            this.txtHoTen.Location =
                new System.Drawing.Point(95, 69);

            this.txtHoTen.Name =
                "txtHoTen";

            this.txtHoTen.Size =
                new System.Drawing.Size(195, 20);

            this.txtHoTen.TabIndex = 1;

            this.txtHoTen.TextChanged +=
                new System.EventHandler(
                    this.txtHoTen_TextChanged
                );

            // =========================================================
            // ĐỊA CHỈ
            // =========================================================

            this.lblDiaChi.AutoSize = true;

            this.lblDiaChi.Location =
                new System.Drawing.Point(28, 105);

            this.lblDiaChi.Name =
                "lblDiaChi";

            this.lblDiaChi.Text =
                "Địa chỉ:";

            // TextBox địa chỉ
            this.txtDiaChi.Location =
                new System.Drawing.Point(95, 102);

            this.txtDiaChi.Name =
                "txtDiaChi";

            this.txtDiaChi.Size =
                new System.Drawing.Size(300, 20);

            this.txtDiaChi.TabIndex = 2;

            this.txtDiaChi.TextChanged +=
                new System.EventHandler(
                    this.txtDiaChi_TextChanged
                );

            // =========================================================
            // SỐ NGÀY Ở
            // =========================================================

            this.lblSoNgay.AutoSize = true;

            this.lblSoNgay.Location =
                new System.Drawing.Point(28, 138);

            this.lblSoNgay.Name =
                "lblSoNgay";

            this.lblSoNgay.Text =
                "Số ngày ở:";

            // TextBox số ngày
            this.txtSoNgay.Location =
                new System.Drawing.Point(95, 135);

            this.txtSoNgay.Name =
                "txtSoNgay";

            this.txtSoNgay.Size =
                new System.Drawing.Size(55, 20);

            this.txtSoNgay.TabIndex = 3;

            this.txtSoNgay.TextChanged +=
                new System.EventHandler(
                    this.txtSoNgay_TextChanged
                );

            // =========================================================
            // GROUP LOẠI PHÒNG
            // =========================================================

            this.grpLoaiPhong.Location =
                new System.Drawing.Point(20, 170);

            this.grpLoaiPhong.Name =
                "grpLoaiPhong";

            this.grpLoaiPhong.Size =
                new System.Drawing.Size(125, 115);

            this.grpLoaiPhong.TabIndex = 4;

            this.grpLoaiPhong.TabStop = false;

            this.grpLoaiPhong.Text =
                "Loại phòng";

            // Phòng đơn
            this.radPhongDon.AutoSize = true;

            this.radPhongDon.Location =
                new System.Drawing.Point(10, 25);

            this.radPhongDon.Name =
                "radPhongDon";

            this.radPhongDon.Size =
                new System.Drawing.Size(77, 17);

            this.radPhongDon.TabIndex = 0;

            this.radPhongDon.TabStop = true;

            this.radPhongDon.Text =
                "Phòng đơn";

            this.radPhongDon.UseVisualStyleBackColor =
                true;

            this.radPhongDon.CheckedChanged +=
                new System.EventHandler(
                    this.radPhongDon_CheckedChanged
                );

            // Phòng đôi
            this.radPhongDoi.AutoSize = true;

            this.radPhongDoi.Location =
                new System.Drawing.Point(10, 52);

            this.radPhongDoi.Name =
                "radPhongDoi";

            this.radPhongDoi.Size =
                new System.Drawing.Size(75, 17);

            this.radPhongDoi.TabIndex = 1;

            this.radPhongDoi.Text =
                "Phòng đôi";

            this.radPhongDoi.UseVisualStyleBackColor =
                true;

            this.radPhongDoi.CheckedChanged +=
                new System.EventHandler(
                    this.radPhongDoi_CheckedChanged
                );

            // Phòng ba
            this.radPhongBa.AutoSize = true;

            this.radPhongBa.Location =
                new System.Drawing.Point(10, 79);

            this.radPhongBa.Name =
                "radPhongBa";

            this.radPhongBa.Size =
                new System.Drawing.Size(68, 17);

            this.radPhongBa.TabIndex = 2;

            this.radPhongBa.Text =
                "Phòng ba";

            this.radPhongBa.UseVisualStyleBackColor =
                true;

            this.radPhongBa.CheckedChanged +=
                new System.EventHandler(
                    this.radPhongBa_CheckedChanged
                );

            this.grpLoaiPhong.Controls.Add(
                this.radPhongBa
            );

            this.grpLoaiPhong.Controls.Add(
                this.radPhongDoi
            );

            this.grpLoaiPhong.Controls.Add(
                this.radPhongDon
            );

            // =========================================================
            // GROUP TIỆN NGHI
            // =========================================================

            this.grpTienNghi.Location =
                new System.Drawing.Point(150, 170);

            this.grpTienNghi.Name =
                "grpTienNghi";

            this.grpTienNghi.Size =
                new System.Drawing.Size(140, 115);

            this.grpTienNghi.TabIndex = 5;

            this.grpTienNghi.TabStop = false;

            this.grpTienNghi.Text =
                "Tiện nghi";

            // Tivi
            this.chkTV.AutoSize = true;

            this.chkTV.Location =
                new System.Drawing.Point(10, 25);

            this.chkTV.Name =
                "chkTV";

            this.chkTV.Size =
                new System.Drawing.Size(46, 17);

            this.chkTV.TabIndex = 0;

            this.chkTV.Text =
                "Tivi";

            this.chkTV.UseVisualStyleBackColor =
                true;

            // Internet
            this.chkInternet.AutoSize = true;

            this.chkInternet.Location =
                new System.Drawing.Point(10, 52);

            this.chkInternet.Name =
                "chkInternet";

            this.chkInternet.Size =
                new System.Drawing.Size(67, 17);

            this.chkInternet.TabIndex = 1;

            this.chkInternet.Text =
                "Internet";

            this.chkInternet.UseVisualStyleBackColor =
                true;

            // Máy nước nóng
            this.chkMayNuocNong.AutoSize = true;

            this.chkMayNuocNong.Location =
                new System.Drawing.Point(10, 79);

            this.chkMayNuocNong.Name =
                "chkMayNuocNong";

            this.chkMayNuocNong.Size =
                new System.Drawing.Size(106, 17);

            this.chkMayNuocNong.TabIndex = 2;

            this.chkMayNuocNong.Text =
                "Máy nước nóng";

            this.chkMayNuocNong.UseVisualStyleBackColor =
                true;

            this.grpTienNghi.Controls.Add(
                this.chkMayNuocNong
            );

            this.grpTienNghi.Controls.Add(
                this.chkInternet
            );

            this.grpTienNghi.Controls.Add(
                this.chkTV
            );

            // =========================================================
            // GROUP DỊCH VỤ
            // =========================================================

            this.grpDichVu.Location =
                new System.Drawing.Point(300, 170);

            this.grpDichVu.Name =
                "grpDichVu";

            this.grpDichVu.Size =
                new System.Drawing.Size(115, 115);

            this.grpDichVu.TabIndex = 6;

            this.grpDichVu.TabStop = false;

            this.grpDichVu.Text =
                "Dịch vụ";

            // Karaoke
            this.chkKaraoke.AutoSize = true;

            this.chkKaraoke.Location =
                new System.Drawing.Point(10, 25);

            this.chkKaraoke.Name =
                "chkKaraoke";

            this.chkKaraoke.Size =
                new System.Drawing.Size(68, 17);

            this.chkKaraoke.TabIndex = 0;

            this.chkKaraoke.Text =
                "Karaoke";

            this.chkKaraoke.UseVisualStyleBackColor =
                true;

            // Ăn sáng
            this.chkAnSang.AutoSize = true;

            this.chkAnSang.Location =
                new System.Drawing.Point(10, 52);

            this.chkAnSang.Name =
                "chkAnSang";

            this.chkAnSang.Size =
                new System.Drawing.Size(64, 17);

            this.chkAnSang.TabIndex = 1;

            this.chkAnSang.Text =
                "Ăn sáng";

            this.chkAnSang.UseVisualStyleBackColor =
                true;

            this.grpDichVu.Controls.Add(
                this.chkAnSang
            );

            this.grpDichVu.Controls.Add(
                this.chkKaraoke
            );

            // =========================================================
            // BÊN PHẢI - THANH TOÁN
            // =========================================================

            this.btnThanhToan.Location =
                new System.Drawing.Point(435, 62);

            this.btnThanhToan.Name =
                "btnThanhToan";

            this.btnThanhToan.Size =
                new System.Drawing.Size(80, 28);

            this.btnThanhToan.TabIndex = 7;

            this.btnThanhToan.Text =
                "Thanh toán";

            this.btnThanhToan.UseVisualStyleBackColor =
                true;

            this.btnThanhToan.Click +=
                new System.EventHandler(
                    this.btnThanhToan_Click
                );

            // =========================================================
            // NÚT NHẬP MỚI
            // =========================================================

            this.btnNhapMoi.Location =
                new System.Drawing.Point(525, 62);

            this.btnNhapMoi.Name =
                "btnNhapMoi";

            this.btnNhapMoi.Size =
                new System.Drawing.Size(80, 28);

            this.btnNhapMoi.TabIndex = 8;

            this.btnNhapMoi.Text =
                "Nhập mới";

            this.btnNhapMoi.UseVisualStyleBackColor =
                true;

            this.btnNhapMoi.Click +=
                new System.EventHandler(
                    this.btnNhapMoi_Click
                );

            // =========================================================
            // THÀNH TIỀN
            // =========================================================

            this.lblThanhTien.AutoSize = true;

            this.lblThanhTien.Location =
                new System.Drawing.Point(435, 102);

            this.lblThanhTien.Name =
                "lblThanhTien";

            this.lblThanhTien.Text =
                "Thành tiền:";

            // TextBox thành tiền
            this.txtThanhTien.Location =
                new System.Drawing.Point(505, 99);

            this.txtThanhTien.Name =
                "txtThanhTien";

            this.txtThanhTien.ReadOnly = true;

            this.txtThanhTien.Size =
                new System.Drawing.Size(160, 20);

            this.txtThanhTien.TabIndex = 9;

            this.txtThanhTien.Text =
                "0 VND";

            // =========================================================
            // NÚT TỔNG KẾT
            // =========================================================

            this.btnTongKet.Location =
                new System.Drawing.Point(435, 130);

            this.btnTongKet.Name =
                "btnTongKet";

            this.btnTongKet.Size =
                new System.Drawing.Size(80, 27);

            this.btnTongKet.TabIndex = 10;

            this.btnTongKet.Text =
                "Tổng Kết";

            this.btnTongKet.UseVisualStyleBackColor =
                true;

            this.btnTongKet.Click +=
                new System.EventHandler(
                    this.btnTongKet_Click
                );

            // =========================================================
            // TIÊU ĐỀ THỐNG KÊ
            // =========================================================

            this.lblThongKe.AutoSize = true;

            this.lblThongKe.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif",
                    9F,
                    System.Drawing.FontStyle.Regular
                );

            this.lblThongKe.Location =
                new System.Drawing.Point(435, 163);

            this.lblThongKe.Name =
                "lblThongKe";

            this.lblThongKe.Text =
                "Thống kê tổng kết";

            // =========================================================
            // SỐ LƯỢT NGƯỜI
            // =========================================================

            this.lblSoNguoi.AutoSize = true;

            this.lblSoNguoi.Location =
                new System.Drawing.Point(435, 190);

            this.lblSoNguoi.Name =
                "lblSoNguoi";

            this.lblSoNguoi.Text =
                "Số lượt người:";

            // TextBox số người
            this.txtSoNguoi.Location =
                new System.Drawing.Point(515, 187);

            this.txtSoNguoi.Name =
                "txtSoNguoi";

            this.txtSoNguoi.ReadOnly = true;

            this.txtSoNguoi.Size =
                new System.Drawing.Size(150, 20);

            this.txtSoNguoi.TabIndex = 11;

            // =========================================================
            // TỔNG SỐ TIỀN
            // =========================================================

            this.lblTongSoTien.AutoSize = true;

            this.lblTongSoTien.Location =
                new System.Drawing.Point(435, 220);

            this.lblTongSoTien.Name =
                "lblTongSoTien";

            this.lblTongSoTien.Text =
                "Tổng số tiền:";

            // TextBox tổng tiền
            this.txtTongSoTien.Location =
                new System.Drawing.Point(515, 217);

            this.txtTongSoTien.Name =
                "txtTongSoTien";

            this.txtTongSoTien.ReadOnly = true;

            this.txtTongSoTien.Size =
                new System.Drawing.Size(150, 20);

            this.txtTongSoTien.TabIndex = 12;

            // =========================================================
            // NÚT THOÁT
            // =========================================================

            this.btnThoat.Location =
                new System.Drawing.Point(435, 255);

            this.btnThoat.Name =
                "btnThoat";

            this.btnThoat.Size =
                new System.Drawing.Size(80, 27);

            this.btnThoat.TabIndex = 13;

            this.btnThoat.Text =
                "Thoát";

            this.btnThoat.UseVisualStyleBackColor =
                true;

            this.btnThoat.Click +=
                new System.EventHandler(
                    this.btnThoat_Click
                );

            // =========================================================
            // THÊM CONTROL VÀO FORM
            // =========================================================

            this.Controls.Add(
                this.lblTieuDe
            );

            this.Controls.Add(
                this.panelDuongPhanCach
            );

            // Thông tin khách hàng
            this.Controls.Add(
                this.lblHoTen
            );

            this.Controls.Add(
                this.txtHoTen
            );

            this.Controls.Add(
                this.lblDiaChi
            );

            this.Controls.Add(
                this.txtDiaChi
            );

            this.Controls.Add(
                this.lblSoNgay
            );

            this.Controls.Add(
                this.txtSoNgay
            );

            // Ba nhóm bên trái
            this.Controls.Add(
                this.grpLoaiPhong
            );

            this.Controls.Add(
                this.grpTienNghi
            );

            this.Controls.Add(
                this.grpDichVu
            );

            // Bên phải
            this.Controls.Add(
                this.btnThanhToan
            );

            this.Controls.Add(
                this.btnNhapMoi
            );

            this.Controls.Add(
                this.lblThanhTien
            );

            this.Controls.Add(
                this.txtThanhTien
            );

            this.Controls.Add(
                this.btnTongKet
            );

            this.Controls.Add(
                this.lblThongKe
            );

            this.Controls.Add(
                this.lblSoNguoi
            );

            this.Controls.Add(
                this.txtSoNguoi
            );

            this.Controls.Add(
                this.lblTongSoTien
            );

            this.Controls.Add(
                this.txtTongSoTien
            );

            this.Controls.Add(
                this.btnThoat
            );

            // =========================================================
            // FORM CLOSING
            // =========================================================

            this.FormClosing +=
                new System.Windows.Forms.FormClosingEventHandler(
                    this.Form1_FormClosing
                );

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}