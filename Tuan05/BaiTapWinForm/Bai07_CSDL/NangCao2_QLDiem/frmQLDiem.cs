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

namespace BaiTapWinForm.Bai07_CSDL.NangCao2_QLDiem
{
    public partial class frmQLDiem : Form
    {
        public frmQLDiem()
        {
            InitializeComponent();
        }

        private void xoaTextBox()
        {
            txtMaSV.Clear();
            txtMaMonHoc.Clear();
            txtDiem.Clear();
            txtMaSV.Focus();
        }

        // Đọc điểm từ textbox: chỉ được nhập số, trong khoảng 0 - 10
        // Cho phép dùng dấu chấm hoặc dấu phẩy làm dấu thập phân (7.5 hoặc 7,5)
        private bool docDiem(out double diem)
        {
            string s = txtDiem.Text.Trim().Replace(',', '.');
            if (!double.TryParse(s, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out diem))
                return false;
            return diem >= 0 && diem <= 10;
        }

        private bool kiemTraDiem(out double diem)
        {
            if (!docDiem(out diem))
            {
                MessageBox.Show("Điểm phải là số trong khoảng từ 0 đến 10!", "Thông báo");
                txtDiem.SelectAll();
                txtDiem.Focus();
                return false;
            }
            return true;
        }

        // Thêm: Mã sinh viên, Mã môn học, Điểm không được để trống
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string maMH = txtMaMonHoc.Text.Trim();
            double diem;
            if (maSV == "" || maMH == "" || txtDiem.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên, Mã môn học, Điểm không được để trống!", "Thông báo");
                return;
            }
            if (!kiemTraDiem(out diem))
                return;
            try
            {
                int dem = KetNoi.Dem("select count(*) from Diem where MaSinhVien = @MaSV and MaMonHoc = @MaMH",
                    new SqlParameter("@MaSV", maSV), new SqlParameter("@MaMH", maMH));
                if (dem > 0)
                {
                    MessageBox.Show("Sinh viên này đã có điểm môn học này, hãy dùng chức năng Sửa!", "Thông báo");
                    return;
                }
                KetNoi.ThucThi("insert into Diem(MaSinhVien, MaMonHoc, Diem) values(@MaSV, @MaMH, @Diem)",
                    new SqlParameter("@MaSV", maSV),
                    new SqlParameter("@MaMH", maMH),
                    new SqlParameter("@Diem", diem));
                MessageBox.Show("Thêm điểm thành công", "Thông báo");
                xoaTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại!\n" + KetNoi.LayThongBaoLoi(ex), "Lỗi");
            }
        }

        // Xóa: Mã sinh viên, Mã môn học không được để trống, Điểm không nhập dữ liệu
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string maMH = txtMaMonHoc.Text.Trim();
            if (maSV == "" || maMH == "")
            {
                MessageBox.Show("Mã sinh viên, Mã môn học không được để trống!", "Thông báo");
                return;
            }
            if (txtDiem.Text.Trim() != "")
            {
                MessageBox.Show("Khi xóa không nhập Điểm!", "Thông báo");
                txtDiem.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa điểm này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                int kq = KetNoi.ThucThi("delete from Diem where MaSinhVien = @MaSV and MaMonHoc = @MaMH",
                    new SqlParameter("@MaSV", maSV), new SqlParameter("@MaMH", maMH));
                if (kq > 0)
                {
                    MessageBox.Show("Xóa điểm thành công", "Thông báo");
                    xoaTextBox();
                }
                else
                    MessageBox.Show("Không tìm thấy điểm của sinh viên và môn học đã nhập", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại!\n" + KetNoi.LayThongBaoLoi(ex), "Lỗi");
            }
        }

        // Sửa: Mã sinh viên, Mã môn học không được để trống, Điểm phải nhập và chỉ được nhập số
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string maMH = txtMaMonHoc.Text.Trim();
            double diem;
            if (maSV == "" || maMH == "" || txtDiem.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên, Mã môn học, Điểm không được để trống!", "Thông báo");
                return;
            }
            if (!kiemTraDiem(out diem))
                return;
            try
            {
                int kq = KetNoi.ThucThi("update Diem set Diem = @Diem where MaSinhVien = @MaSV and MaMonHoc = @MaMH",
                    new SqlParameter("@Diem", diem),
                    new SqlParameter("@MaSV", maSV),
                    new SqlParameter("@MaMH", maMH));
                if (kq > 0)
                {
                    MessageBox.Show("Sửa điểm thành công", "Thông báo");
                    xoaTextBox();
                }
                else
                    MessageBox.Show("Không tìm thấy điểm của sinh viên và môn học đã nhập", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại!\n" + KetNoi.LayThongBaoLoi(ex), "Lỗi");
            }
        }
    }
}
