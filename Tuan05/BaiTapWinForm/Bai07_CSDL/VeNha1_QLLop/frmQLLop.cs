using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapWinForm.Bai07_CSDL.VeNha1_QLLop
{
    public partial class frmQLLop : Form
    {
        public frmQLLop()
        {
            InitializeComponent();
        }

        private void xoaTextBox()
        {
            txtMaKhoa.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtMaKhoa.Focus();
        }

        // Thêm: Mã khoa, Mã lớp, Tên lớp không được để trống
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();
            if (maKhoa == "" || maLop == "" || tenLop == "")
            {
                MessageBox.Show("Mã khoa, Mã lớp, Tên lớp không được để trống!", "Thông báo");
                return;
            }
            try
            {
                int dem = KetNoi.Dem("select count(*) from Lop where MaLop = @MaLop",
                    new SqlParameter("@MaLop", maLop));
                if (dem > 0)
                {
                    MessageBox.Show("Mã lớp " + maLop + " đã tồn tại!", "Thông báo");
                    return;
                }
                KetNoi.ThucThi("insert into Lop(MaLop, TenLop, MaKhoa) values(@MaLop, @TenLop, @MaKhoa)",
                    new SqlParameter("@MaLop", maLop),
                    new SqlParameter("@TenLop", tenLop),
                    new SqlParameter("@MaKhoa", maKhoa));
                MessageBox.Show("Thêm lớp thành công", "Thông báo");
                xoaTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại!\n" + KetNoi.LayThongBaoLoi(ex), "Lỗi");
            }
        }

        // Xóa: Mã lớp không được để trống; Mã khoa, Tên lớp không nhập dữ liệu
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            if (maLop == "")
            {
                MessageBox.Show("Mã lớp không được để trống!", "Thông báo");
                txtMaLop.Focus();
                return;
            }
            if (txtMaKhoa.Text.Trim() != "" || txtTenLop.Text.Trim() != "")
            {
                MessageBox.Show("Khi xóa chỉ nhập Mã lớp, không nhập Mã khoa và Tên lớp!", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa lớp " + maLop + "?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                int kq = KetNoi.ThucThi("delete from Lop where MaLop = @MaLop",
                    new SqlParameter("@MaLop", maLop));
                if (kq > 0)
                {
                    MessageBox.Show("Xóa lớp thành công", "Thông báo");
                    xoaTextBox();
                }
                else
                    MessageBox.Show("Không tìm thấy mã lớp " + maLop, "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại!\n" + KetNoi.LayThongBaoLoi(ex), "Lỗi");
            }
        }

        // Sửa: Mã lớp không để trống; Mã khoa, Tên lớp phải có ít nhất 1 trường có dữ liệu
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();
            if (maLop == "")
            {
                MessageBox.Show("Mã lớp không được để trống!", "Thông báo");
                txtMaLop.Focus();
                return;
            }
            if (maKhoa == "" && tenLop == "")
            {
                MessageBox.Show("Mã khoa, Tên lớp phải có ít nhất một trường có dữ liệu!", "Thông báo");
                return;
            }

            // Chỉ cập nhật những cột có nhập dữ liệu
            List<string> cot = new List<string>();
            List<SqlParameter> thamSo = new List<SqlParameter>();
            if (maKhoa != "")
            {
                cot.Add("MaKhoa = @MaKhoa");
                thamSo.Add(new SqlParameter("@MaKhoa", maKhoa));
            }
            if (tenLop != "")
            {
                cot.Add("TenLop = @TenLop");
                thamSo.Add(new SqlParameter("@TenLop", tenLop));
            }
            thamSo.Add(new SqlParameter("@MaLop", maLop));
            string sql = "update Lop set " + string.Join(", ", cot) + " where MaLop = @MaLop";

            try
            {
                int kq = KetNoi.ThucThi(sql, thamSo.ToArray());
                if (kq > 0)
                {
                    MessageBox.Show("Sửa lớp thành công", "Thông báo");
                    xoaTextBox();
                }
                else
                    MessageBox.Show("Không tìm thấy mã lớp " + maLop, "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại!\n" + KetNoi.LayThongBaoLoi(ex), "Lỗi");
            }
        }
    }
}
