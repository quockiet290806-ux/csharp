using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapWinForm.TH05c.VeNha2_ListBoxSo
{
    public partial class frmListboxSo : Form
    {
        public frmListboxSo()
        {
            InitializeComponent();
        }

        // Chỉ cho gõ ký tự số (số tự nhiên)
        private void txtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        // Thêm số tự nhiên N vào listbox
        private void btnNhap_Click(object sender, EventArgs e)
        {
            long n;
            if (!long.TryParse(txtSo.Text.Trim(), out n) || n < 0)
            {
                MessageBox.Show("Bạn phải nhập một số tự nhiên!", "Thông báo");
                txtSo.SelectAll();
                txtSo.Focus();
                return;
            }
            lstSo.Items.Add(n);
            txtSo.Clear();
            txtSo.Focus();
        }

        // Lấy giá trị số của phần tử thứ i trong listbox
        private long giaTri(int i)
        {
            return Convert.ToInt64(lstSo.Items[i]);
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            long tong = 0;
            for (int i = 0; i < lstSo.Items.Count; i++)
                tong += giaTri(i);
            MessageBox.Show("Tổng các phần tử trong List: " + tong, "Kết quả");
        }

        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            // Xóa phần tử cuối trước rồi mới xóa phần tử đầu
            if (lstSo.Items.Count > 0)
                lstSo.Items.RemoveAt(lstSo.Items.Count - 1);
            if (lstSo.Items.Count > 0)
                lstSo.Items.RemoveAt(0);
        }

        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            // Xóa từ dưới lên để không bị lệch chỉ số
            for (int i = lstSo.SelectedIndices.Count - 1; i >= 0; i--)
                lstSo.Items.RemoveAt(lstSo.SelectedIndices[i]);
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            lstSo.ClearSelected();
            for (int i = 0; i < lstSo.Items.Count; i++)
                lstSo.Items[i] = giaTri(i) + 2;
        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            lstSo.ClearSelected();
            for (int i = 0; i < lstSo.Items.Count; i++)
                lstSo.Items[i] = giaTri(i) * giaTri(i);
        }

        // Chọn các phần tử có số dư khi chia 2 bằng soDu (0: chẵn, 1: lẻ)
        private void chonTheoSoDu(int soDu)
        {
            lstSo.ClearSelected();
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                if (giaTri(i) % 2 == soDu)
                    lstSo.SetSelected(i, true);
            }
        }

        private void btnChonChan_Click(object sender, EventArgs e)
        {
            chonTheoSoDu(0);
        }

        private void btnChonLe_Click(object sender, EventArgs e)
        {
            chonTheoSoDu(1);
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
