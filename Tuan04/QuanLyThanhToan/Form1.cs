using System;
using System.Windows.Forms;

namespace KhachSanThanhThanh
{
    public partial class Form1 : Form
    {
        // Biến thống kê
        int tongSoNguoi = 0;
        double tongTien = 0;

        public Form1()
        {
            InitializeComponent();

            // Ban đầu các nút này bị mờ
            btnThanhToan.Enabled = false;
            btnNhapMoi.Enabled = false;
            btnTongKet.Enabled = false;

            // Chưa có thành tiền
            txtThanhTien.Text = "0 VND";
        }

        // =====================================================
        // KIỂM TRA DỮ LIỆU ĐÃ NHẬP ĐỦ CHƯA
        // =====================================================
        private void KiemTraDuLieu()
        {
            bool hopLe = true;

            // Họ tên
            if (txtHoTen.Text.Trim() == "")
                hopLe = false;

            // Địa chỉ
            if (txtDiaChi.Text.Trim() == "")
                hopLe = false;

            // Số ngày ở
            int soNgay;
            if (!int.TryParse(txtSoNgay.Text, out soNgay) || soNgay <= 0)
                hopLe = false;

            // Phải chọn loại phòng
            if (!radPhongDon.Checked &&
                !radPhongDoi.Checked &&
                !radPhongBa.Checked)
            {
                hopLe = false;
            }

            btnThanhToan.Enabled = hopLe;
        }

        // =====================================================
        // KIỂM TRA KHI NHẬP HỌ TÊN
        // =====================================================
        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            KiemTraDuLieu();
        }

        // =====================================================
        // KIỂM TRA KHI NHẬP ĐỊA CHỈ
        // =====================================================
        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            KiemTraDuLieu();
        }

        // =====================================================
        // KIỂM TRA KHI NHẬP SỐ NGÀY
        // =====================================================
        private void txtSoNgay_TextChanged(object sender, EventArgs e)
        {
            KiemTraDuLieu();
        }

        // =====================================================
        // KHI CHỌN LOẠI PHÒNG
        // =====================================================
        private void radPhongDon_CheckedChanged(object sender, EventArgs e)
        {
            KiemTraDuLieu();
        }

        private void radPhongDoi_CheckedChanged(object sender, EventArgs e)
        {
            KiemTraDuLieu();
        }

        private void radPhongBa_CheckedChanged(object sender, EventArgs e)
        {
            KiemTraDuLieu();
        }

        // =====================================================
        // NÚT THANH TOÁN
        // =====================================================
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int soNgay = int.Parse(txtSoNgay.Text);

            // ---------------------------------------------
            // Tính tiền phòng
            // ---------------------------------------------
            double tienPhong = 0;

            if (radPhongDon.Checked)
            {
                // Phòng đơn: 300.000/ngày
                tienPhong = 300000 * soNgay;
            }
            else if (radPhongDoi.Checked)
            {
                // Phòng đôi: 350.000/ngày
                tienPhong = 350000 * soNgay;
            }
            else if (radPhongBa.Checked)
            {
                // Phòng ba: 400.000/ngày
                tienPhong = 400000 * soNgay;
            }

            // ---------------------------------------------
            // Tiện nghi
            // Mỗi tiện nghi + 10.000
            // ---------------------------------------------
            double tienTienNghi = 0;

            if (chkTV.Checked)
                tienTienNghi += 10000;

            if (chkInternet.Checked)
                tienTienNghi += 10000;

            if (chkMayNuocNong.Checked)
                tienTienNghi += 10000;

            // ---------------------------------------------
            // Dịch vụ Karaoke
            // ---------------------------------------------
            double tienKaraoke = 0;

            if (chkKaraoke.Checked)
                tienKaraoke = 50000;

            // ---------------------------------------------
            // Dịch vụ ăn sáng
            // 50.000/ngày
            // ---------------------------------------------
            double tienAnSang = 0;

            if (chkAnSang.Checked)
                tienAnSang = 50000 * soNgay;

            // ---------------------------------------------
            // Tổng tiền
            // ---------------------------------------------
            double thanhTien =
                tienPhong +
                tienTienNghi +
                tienKaraoke +
                tienAnSang;

            // Hiển thị thành tiền
            txtThanhTien.Text = thanhTien.ToString("N0") + " VND";

            // ---------------------------------------------
            // Cập nhật thống kê
            // ---------------------------------------------
            tongSoNguoi++;
            tongTien += thanhTien;

            // Sau khi thanh toán:
            // - Không cho sửa thông tin
            // - Mở nút Nhập mới
            // - Mở nút Tổng kết
            // - Khóa nút Thanh toán
            KhoaThongTin(true);

            btnThanhToan.Enabled = false;
            btnNhapMoi.Enabled = true;
            btnTongKet.Enabled = true;
        }

        // =====================================================
        // KHÓA / MỞ THÔNG TIN
        // =====================================================
        private void KhoaThongTin(bool khoa)
        {
            txtHoTen.Enabled = !khoa;
            txtDiaChi.Enabled = !khoa;
            txtSoNgay.Enabled = !khoa;

            radPhongDon.Enabled = !khoa;
            radPhongDoi.Enabled = !khoa;
            radPhongBa.Enabled = !khoa;

            chkTV.Enabled = !khoa;
            chkInternet.Enabled = !khoa;
            chkMayNuocNong.Enabled = !khoa;

            chkKaraoke.Enabled = !khoa;
            chkAnSang.Enabled = !khoa;
        }

        // =====================================================
        // NÚT NHẬP MỚI
        // =====================================================
        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            // Xóa thông tin khách hàng
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoNgay.Clear();

            // Bỏ chọn loại phòng
            radPhongDon.Checked = false;
            radPhongDoi.Checked = false;
            radPhongBa.Checked = false;

            // Bỏ chọn tiện nghi
            chkTV.Checked = false;
            chkInternet.Checked = false;
            chkMayNuocNong.Checked = false;

            // Bỏ chọn dịch vụ
            chkKaraoke.Checked = false;
            chkAnSang.Checked = false;

            // Xóa thành tiền
            txtThanhTien.Text = "0 VND";

            // Mở lại các thông tin
            KhoaThongTin(false);

            // Nút thanh toán chờ nhập đủ dữ liệu
            btnThanhToan.Enabled = false;

            // Nhập mới lại bị mờ
            btnNhapMoi.Enabled = false;
        }

        // =====================================================
        // NÚT TỔNG KẾT
        // =====================================================
        private void btnTongKet_Click(object sender, EventArgs e)
        {
            txtSoNguoi.Text = tongSoNguoi.ToString();
            txtTongSoTien.Text = tongTien.ToString("N0") + " VND";
        }

        // =====================================================
        // NÚT THOÁT
        // =====================================================
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // =====================================================
        // KHI ĐÓNG FORM
        // =====================================================
        private void Form1_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}