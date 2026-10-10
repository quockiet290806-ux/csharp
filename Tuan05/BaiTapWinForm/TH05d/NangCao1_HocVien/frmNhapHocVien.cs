using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapWinForm.TH05d.NangCao1_HocVien
{
    public partial class frmNhapHocVien : Form
    {
        // Form chính, dùng để cập nhật họ tên vào listbox Lớp A / Lớp B
        private frmQuanLyHocVien frmChinh;

        public frmNhapHocVien(frmQuanLyHocVien frm)
        {
            InitializeComponent();
            frmChinh = frm;
        }

        private void frmNhapHocVien_Load(object sender, EventArgs e)
        {
            cboLop.SelectedIndex = 0;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            if (hoTen == "")
            {
                MessageBox.Show("Bạn phải nhập Họ và Tên!", "Thông báo");
                txtHoTen.Focus();
                return;
            }
            // Tùy theo lớp đã chọn trong combobox mà cập nhật vào listbox tương ứng trên form chính
            frmChinh.ThemHocVien(hoTen, cboLop.Text);
            txtHoTen.Clear();
            txtHoTen.Focus();
        }

        // Đóng form nhập thông tin và trở về form chính
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
