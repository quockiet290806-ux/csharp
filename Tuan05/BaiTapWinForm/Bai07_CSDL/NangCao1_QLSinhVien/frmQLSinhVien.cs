using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapWinForm.Bai07_CSDL.NangCao1_QLSinhVien
{
    public partial class frmQLSinhVien : Form
    {
        public frmQLSinhVien()
        {
            InitializeComponent();
        }

        private void xoaTextBox()
        {
            txtMaLop.Clear();
            txtMaSV.Clear();
            txtTenSV.Clear();
            txtNgaySinh.Clear();
            txtMaLop.Focus();
        }

        // Đọc ngày sinh nhập theo dạng ngày/tháng/năm
        private bool docNgaySinh(out DateTime ngaySinh)
        {
            return DateTime.TryParseExact(txtNgaySinh.Text.Trim(), "d/M/yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh);
        }

        // Thêm: Mã lớp, Mã sinh viên, Tên sinh viên, Ngày sinh không được để trống
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            string maSV = txtMaSV.Text.Trim();
            string tenSV = txtTenSV.Text.Trim();
            DateTime ngaySinh;

            if (maLop == "" || maSV == "" || tenSV == "" || txtNgaySinh.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp, Mã sinh viên, Tên sinh viên, Ngày sinh không được để trống!", "Thông báo");
                return;
            }
            if (!docNgaySinh(out ngaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ! Nhập theo dạng ngày/tháng/năm, ví dụ 25/12/2004", "Thông báo");
                txtNgaySinh.Focus();
                return;
            }
            try
            {
                int dem = KetNoi.Dem("select count(*) from SinhVien where MaSinhVien = @MaSV",
                    new SqlParameter("@MaSV", maSV));
                if (dem > 0)
                {
                    MessageBox.Show("Mã sinh viên " + maSV + " đã tồn tại!", "Thông báo");
                    return;
                }
                KetNoi.ThucThi("insert into SinhVien(MaSinhVien, HoTen, NgaySinh, MaLop) " +
                               "values(@MaSV, @HoTen, @NgaySinh, @MaLop)",
                    new SqlParameter("@MaSV", maSV),
                    new SqlParameter("@HoTen", tenSV),
                    new SqlParameter("@NgaySinh", ngaySinh),
                    new SqlParameter("@MaLop", maLop));
                MessageBox.Show("Thêm sinh viên thành công", "Thông báo");
                xoaTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại!\n" + KetNoi.LayThongBaoLoi(ex), "Lỗi");
            }
        }

        // Xóa: Mã sinh viên, Tên sinh viên không được để trống; Mã lớp, Ngày sinh không nhập dữ liệu
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string tenSV = txtTenSV.Text.Trim();
            if (maSV == "" || tenSV == "")
            {
                MessageBox.Show("Mã sinh viên, Tên sinh viên không được để trống!", "Thông báo");
                return;
            }
            if (txtMaLop.Text.Trim() != "" || txtNgaySinh.Text.Trim() != "")
            {
                MessageBox.Show("Khi xóa không nhập Mã lớp và Ngày sinh!", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên " + maSV + "?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                // Xóa sinh viên có mã và tên trùng với thông tin vừa nhập
                int kq = KetNoi.ThucThi("delete from SinhVien where MaSinhVien = @MaSV and HoTen = @HoTen",
                    new SqlParameter("@MaSV", maSV), new SqlParameter("@HoTen", tenSV));
                if (kq > 0)
                {
                    MessageBox.Show("Xóa sinh viên thành công", "Thông báo");
                    xoaTextBox();
                }
                else
                    MessageBox.Show("Không tìm thấy sinh viên có mã và tên như đã nhập", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại!\n" + KetNoi.LayThongBaoLoi(ex), "Lỗi");
            }
        }

        // Sửa: Mã sinh viên không được để trống; Mã lớp, Tên sinh viên, Ngày sinh
        // phải có ít nhất một trường có dữ liệu, trường nào không nhập thì không thay đổi
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            string maSV = txtMaSV.Text.Trim();
            string tenSV = txtTenSV.Text.Trim();
            DateTime ngaySinh = DateTime.Today;

            if (maSV == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống!", "Thông báo");
                txtMaSV.Focus();
                return;
            }
            if (maLop == "" && tenSV == "" && txtNgaySinh.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp, Tên sinh viên, Ngày sinh phải có ít nhất một trường có dữ liệu!", "Thông báo");
                return;
            }
            if (txtNgaySinh.Text.Trim() != "" && !docNgaySinh(out ngaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ! Nhập theo dạng ngày/tháng/năm, ví dụ 25/12/2004", "Thông báo");
                txtNgaySinh.Focus();
                return;
            }

            // Chỉ đưa vào câu lệnh update những cột có nhập dữ liệu
            List<string> cot = new List<string>();
            List<SqlParameter> thamSo = new List<SqlParameter>();
            if (maLop != "")
            {
                cot.Add("MaLop = @MaLop");
                thamSo.Add(new SqlParameter("@MaLop", maLop));
            }
            if (tenSV != "")
            {
                cot.Add("HoTen = @HoTen");
                thamSo.Add(new SqlParameter("@HoTen", tenSV));
            }
            if (txtNgaySinh.Text.Trim() != "")
            {
                cot.Add("NgaySinh = @NgaySinh");
                thamSo.Add(new SqlParameter("@NgaySinh", ngaySinh));
            }
            thamSo.Add(new SqlParameter("@MaSV", maSV));
            string sql = "update SinhVien set " + string.Join(", ", cot) + " where MaSinhVien = @MaSV";

            try
            {
                int kq = KetNoi.ThucThi(sql, thamSo.ToArray());
                if (kq > 0)
                {
                    MessageBox.Show("Sửa sinh viên thành công", "Thông báo");
                    xoaTextBox();
                }
                else
                    MessageBox.Show("Không tìm thấy mã sinh viên " + maSV, "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại!\n" + KetNoi.LayThongBaoLoi(ex), "Lỗi");
            }
        }
    }
}
