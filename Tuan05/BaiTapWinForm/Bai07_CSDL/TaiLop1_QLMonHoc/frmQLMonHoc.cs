using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapWinForm.Bai07_CSDL.TaiLop1_QLMonHoc
{
    public partial class frmQLMonHoc : Form
    {
        public frmQLMonHoc()
        {
            InitializeComponent();
        }

        private void xoaTextBox()
        {
            txtMaMonHoc.Clear();
            txtTenMonHoc.Clear();
            txtMaMonHoc.Focus();
        }

        // Thêm: Mã môn học, Tên môn học không được để trống
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaMonHoc.Text.Trim();
            string ten = txtTenMonHoc.Text.Trim();
            if (ma == "" || ten == "")
            {
                MessageBox.Show("Mã môn học, Tên môn học không được để trống!", "Thông báo");
                return;
            }
            try
            {
                int dem = KetNoi.Dem("select count(*) from MonHoc where MaMonHoc = @Ma",
                    new SqlParameter("@Ma", ma));
                if (dem > 0)
                {
                    MessageBox.Show("Mã môn học " + ma + " đã tồn tại!", "Thông báo");
                    return;
                }
                KetNoi.ThucThi("insert into MonHoc(MaMonHoc, TenMonHoc) values(@Ma, @Ten)",
                    new SqlParameter("@Ma", ma), new SqlParameter("@Ten", ten));
                MessageBox.Show("Thêm môn học thành công", "Thông báo");
                xoaTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại!\n" + KetNoi.LayThongBaoLoi(ex), "Lỗi");
            }
        }

        // Xóa: Mã môn học không được để trống, Tên môn học không nhập dữ liệu
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaMonHoc.Text.Trim();
            if (ma == "")
            {
                MessageBox.Show("Mã môn học không được để trống!", "Thông báo");
                txtMaMonHoc.Focus();
                return;
            }
            if (txtTenMonHoc.Text.Trim() != "")
            {
                MessageBox.Show("Khi xóa chỉ nhập Mã môn học, không nhập Tên môn học!", "Thông báo");
                txtTenMonHoc.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa môn học " + ma + "?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                int kq = KetNoi.ThucThi("delete from MonHoc where MaMonHoc = @Ma",
                    new SqlParameter("@Ma", ma));
                if (kq > 0)
                {
                    MessageBox.Show("Xóa môn học thành công", "Thông báo");
                    xoaTextBox();
                }
                else
                    MessageBox.Show("Không tìm thấy mã môn học " + ma, "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại!\n" + KetNoi.LayThongBaoLoi(ex), "Lỗi");
            }
        }

        // Sửa: Mã môn học, Tên môn học không được để trống
        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaMonHoc.Text.Trim();
            string ten = txtTenMonHoc.Text.Trim();
            if (ma == "" || ten == "")
            {
                MessageBox.Show("Mã môn học, Tên môn học không được để trống!", "Thông báo");
                return;
            }
            try
            {
                int kq = KetNoi.ThucThi("update MonHoc set TenMonHoc = @Ten where MaMonHoc = @Ma",
                    new SqlParameter("@Ten", ten), new SqlParameter("@Ma", ma));
                if (kq > 0)
                {
                    MessageBox.Show("Sửa môn học thành công", "Thông báo");
                    xoaTextBox();
                }
                else
                    MessageBox.Show("Không tìm thấy mã môn học " + ma, "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại!\n" + KetNoi.LayThongBaoLoi(ex), "Lỗi");
            }
        }
    }
}
