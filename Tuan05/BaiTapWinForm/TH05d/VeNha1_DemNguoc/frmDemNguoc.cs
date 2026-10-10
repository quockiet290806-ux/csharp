using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapWinForm.TH05d.VeNha1_DemNguoc
{
    public partial class frmDemNguoc : Form
    {
        // Tổng số giây còn lại
        int conLai = 0;
        // true khi đang tạm dừng giữa chừng (nhấn Bắt đầu thì đếm tiếp)
        bool tamDung = false;

        public frmDemNguoc()
        {
            InitializeComponent();
        }

        private void txtThoiGian_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        // Hiển thị số giây còn lại theo dạng giờ:phút:giây
        private void hienThi()
        {
            int gio = conLai / 3600;
            int phut = (conLai % 3600) / 60;
            int giay = conLai % 60;
            lblThoiGian.Text = gio.ToString("00") + ":" + phut.ToString("00") + ":" + giay.ToString("00");
        }

        // Đọc một ô nhập, để trống thì coi như 0
        private bool docSo(TextBox txt, int max, out int so)
        {
            so = 0;
            if (txt.Text.Trim() == "")
                return true;
            return int.TryParse(txt.Text.Trim(), out so) && so >= 0 && so <= max;
        }

        private void khoaNhap(bool khoa)
        {
            txtGio.ReadOnly = khoa;
            txtPhut.ReadOnly = khoa;
            txtGiay.ReadOnly = khoa;
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (!tamDung)
            {
                int gio, phut, giay;
                if (!docSo(txtGio, 99, out gio) || !docSo(txtPhut, 59, out phut) || !docSo(txtGiay, 59, out giay))
                {
                    MessageBox.Show("Thời gian không hợp lệ! (Giờ: 0-99, Phút: 0-59, Giây: 0-59)", "Thông báo");
                    return;
                }
                conLai = gio * 3600 + phut * 60 + giay;
                if (conLai == 0)
                {
                    MessageBox.Show("Bạn hãy nhập thời gian cần đếm ngược!", "Thông báo");
                    return;
                }
            }
            tamDung = false;
            hienThi();
            khoaNhap(true);
            btnBatDau.Enabled = false;
            btnTamDung.Enabled = true;
            timer1.Start();
        }

        private void btnTamDung_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            tamDung = true;
            btnBatDau.Enabled = true;
            btnTamDung.Enabled = false;
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            tamDung = false;
            conLai = 0;
            hienThi();
            khoaNhap(false);
            btnBatDau.Enabled = true;
            btnTamDung.Enabled = false;
        }

        // Mỗi giây giảm thời gian còn lại đi 1, về 0 thì dừng và thông báo
        private void timer1_Tick(object sender, EventArgs e)
        {
            conLai--;
            hienThi();
            if (conLai <= 0)
            {
                timer1.Stop();
                khoaNhap(false);
                btnBatDau.Enabled = true;
                btnTamDung.Enabled = false;
                MessageBox.Show("Hết giờ!", "Thông báo");
            }
        }
    }
}
