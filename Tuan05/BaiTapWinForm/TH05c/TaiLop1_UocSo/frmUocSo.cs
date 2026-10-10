using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapWinForm.TH05c.TaiLop1_UocSo
{
    public partial class frmUocSo : Form
    {
        public frmUocSo()
        {
            InitializeComponent();
        }

        // Chỉ cho gõ ký tự số vào textbox Nhập số
        private void txtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        // Thêm số vừa nhập vào combobox
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int so;
            if (!int.TryParse(txtSo.Text.Trim(), out so) || so <= 0)
            {
                MessageBox.Show("Bạn phải nhập một số nguyên dương!", "Thông báo");
                txtSo.SelectAll();
                txtSo.Focus();
                return;
            }
            // Kiểm tra số đã tồn tại trong combobox chưa
            if (cboSo.Items.Contains(so))
                MessageBox.Show("Số " + so + " đã có trong danh sách!", "Thông báo");
            else
                cboSo.Items.Add(so);
            txtSo.Clear();
            txtSo.Focus();
        }

        // Chọn một số trong combobox thì hiện danh sách ước số qua listbox
        private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSo.SelectedIndex < 0)
                return;
            int so = (int)cboSo.SelectedItem;
            lstUocSo.Items.Clear();
            for (int i = 1; i <= so / 2; i++)
            {
                if (so % i == 0)
                    lstUocSo.Items.Add(i);
            }
            lstUocSo.Items.Add(so);   // một số luôn chia hết cho chính nó
        }

        private bool laSoNguyenTo(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        // Kiểm tra listbox đã có ước số chưa trước khi tính
        private bool coDanhSachUoc()
        {
            if (lstUocSo.Items.Count == 0)
            {
                MessageBox.Show("Bạn hãy chọn một số trong combobox trước!", "Thông báo");
                return false;
            }
            return true;
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (!coDanhSachUoc())
                return;
            long tong = 0;
            foreach (int uoc in lstUocSo.Items)
                tong += uoc;
            MessageBox.Show("Tổng các ước số: " + tong, "Kết quả");
        }

        private void btnSoLuongChan_Click(object sender, EventArgs e)
        {
            if (!coDanhSachUoc())
                return;
            int dem = 0;
            foreach (int uoc in lstUocSo.Items)
            {
                if (uoc % 2 == 0)
                    dem++;
            }
            MessageBox.Show("Số lượng các ước số chẵn: " + dem, "Kết quả");
        }

        private void btnSoLuongNguyenTo_Click(object sender, EventArgs e)
        {
            if (!coDanhSachUoc())
                return;
            int dem = 0;
            foreach (int uoc in lstUocSo.Items)
            {
                if (laSoNguyenTo(uoc))
                    dem++;
            }
            MessageBox.Show("Số lượng các ước số nguyên tố: " + dem, "Kết quả");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Thoát có xác nhận từ người dùng
        private void frmUocSo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
