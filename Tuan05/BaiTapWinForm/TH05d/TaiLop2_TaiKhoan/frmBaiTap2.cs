using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapWinForm.TH05d.TaiLop2_TaiKhoan
{
    public partial class frmBaiTap2 : Form
    {
        public frmBaiTap2()
        {
            InitializeComponent();
        }

        private void xoaTextBox()
        {
            txtSoTK.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSoTien.Clear();
        }

        // Trở về trạng thái ban đầu: button là "Thêm", khóa button Lưu
        private void thoatCheDoThem()
        {
            btnThem.Text = "Thêm";
            btnLuu.Enabled = false;
        }

        // Đánh lại STT và tính lại Tổng tiền sau khi Thêm, Xóa
        // Số tiền của mỗi dòng được giữ trong Tag của ListViewItem
        private void capNhatSTTvaTongTien()
        {
            decimal tong = 0;
            for (int i = 0; i < lvTaiKhoan.Items.Count; i++)
            {
                lvTaiKhoan.Items[i].Text = (i + 1).ToString();
                tong += (decimal)lvTaiKhoan.Items[i].Tag;
            }
            txtTongTien.Text = tong.ToString("#,##0");
        }

        private bool trungSoTK(string soTK)
        {
            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                if (item.SubItems[1].Text == soTK)
                    return true;
            }
            return false;
        }

        // Chỉ cho gõ số vào ô Số tiền
        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        // Thêm <-> Hủy
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                lvTaiKhoan.SelectedItems.Clear();
                btnThem.Text = "Hủy";
                btnLuu.Enabled = true;
                xoaTextBox();
                txtSoTK.Focus();
            }
            else
            {
                thoatCheDoThem();
                xoaTextBox();
            }
        }

        // Lưu dữ liệu từ các textbox vào listview
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string soTK = txtSoTK.Text.Trim();
            string tenKH = txtTenKH.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            decimal soTien;

            if (soTK == "" || tenKH == "" || diaChi == "" || txtSoTien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin tài khoản!", "Thông báo");
                return;
            }
            if (!decimal.TryParse(txtSoTien.Text.Trim(), out soTien) || soTien < 0)
            {
                MessageBox.Show("Số tiền không hợp lệ!", "Thông báo");
                txtSoTien.Focus();
                return;
            }
            if (trungSoTK(soTK))
            {
                MessageBox.Show("Số tài khoản " + soTK + " đã tồn tại!", "Thông báo");
                txtSoTK.Focus();
                return;
            }

            ListViewItem item = new ListViewItem("");   // cột STT, đánh số sau
            item.SubItems.Add(soTK);
            item.SubItems.Add(tenKH);
            item.SubItems.Add(diaChi);
            item.SubItems.Add(soTien.ToString("#,##0"));
            item.Tag = soTien;
            lvTaiKhoan.Items.Add(item);

            capNhatSTTvaTongTien();
            thoatCheDoThem();
        }

        // Xóa mẫu tin hiện hành trong listview
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count == 0)
                return;
            if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lvTaiKhoan.SelectedItems[0].Remove();
                capNhatSTTvaTongTien();
                xoaTextBox();
                btnXoa.Enabled = false;
            }
        }

        // Click một khách hàng trong listview thì hiện thông tin lên các textbox
        private void lvTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count == 0)
            {
                btnXoa.Enabled = false;
                return;
            }
            thoatCheDoThem();
            ListViewItem item = lvTaiKhoan.SelectedItems[0];
            txtSoTK.Text = item.SubItems[1].Text;
            txtTenKH.Text = item.SubItems[2].Text;
            txtDiaChi.Text = item.SubItems[3].Text;
            txtSoTien.Text = ((decimal)item.Tag).ToString("0");
            btnXoa.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
