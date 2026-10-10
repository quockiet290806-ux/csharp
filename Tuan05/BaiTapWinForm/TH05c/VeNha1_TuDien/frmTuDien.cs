using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapWinForm.TH05c.VeNha1_TuDien
{
    public partial class frmTuDien : Form
    {
        // Danh sách từ lưu sẵn: dsAnh[i] có nghĩa là dsViet[i]
        List<string> dsAnh = new List<string>();
        List<string> dsViet = new List<string>();

        // Đánh dấu người dùng vừa nhấn phím xóa để không tự điền từ
        bool dangXoa = false;
        // Thời điểm click trước đó, dùng để nhận biết double click trên combobox
        DateTime lanClickTruoc = DateTime.MinValue;

        public frmTuDien()
        {
            InitializeComponent();
        }

        private void themTu(string anh, string viet)
        {
            dsAnh.Add(anh);
            dsViet.Add(viet);
        }

        private void frmTuDien_Load(object sender, EventArgs e)
        {
            themTu("student", "Sinh viên, học sinh");
            themTu("teacher", "Giáo viên");
            themTu("worker", "Công nhân");
            themTu("hat", "Cái mũ");
            themTu("head", "Cái đầu");
            themTu("mouse", "Con chuột");
            themTu("cat", "Con mèo");
            themTu("dog", "Con chó");
            themTu("snake", "Con rắn");
            themTu("lamb", "Con cừu non");
            themTu("loan", "Khoản vay");
            themTu("frog", "Con ếch");
            themTu("sheep", "Con cừu");
            themTu("book", "Quyển sách");
            themTu("pen", "Cây bút");
            themTu("table", "Cái bàn");
            themTu("chair", "Cái ghế");
            themTu("house", "Ngôi nhà");
            themTu("school", "Trường học");
            themTu("computer", "Máy tính");
            themTu("water", "Nước");
            themTu("flower", "Bông hoa");
            themTu("friend", "Bạn bè");
            themTu("family", "Gia đình");
            themTu("window", "Cửa sổ");

            foreach (string s in dsAnh)
                cboAnh.Items.Add(s);
            foreach (string s in dsViet)
                cboViet.Items.Add(s);
        }

        // Dò tìm đến từ khớp với các ký tự vừa gõ trong combobox
        private void doTim(ComboBox cbo)
        {
            if (dangXoa)
                return;
            string daGo = cbo.Text;
            if (daGo == "")
                return;
            int vt = cbo.FindString(daGo);
            if (vt >= 0)
            {
                cbo.SelectedIndex = vt;
                // Bôi đen phần được điền thêm để gõ tiếp sẽ thay thế phần này
                cbo.Select(daGo.Length, cbo.Text.Length - daGo.Length);
            }
        }

        // Tra nghĩa của từ đang có trong combobox và hiện qua textbox bên phải
        private void traTu(ComboBox cbo, List<string> nguon, List<string> dich, TextBox txtNghia)
        {
            string tu = cbo.Text.Trim();
            if (tu == "")
                return;
            for (int i = 0; i < nguon.Count; i++)
            {
                if (string.Compare(nguon[i], tu, true) == 0)
                {
                    txtNghia.Text = dich[i];
                    return;
                }
            }
            txtNghia.Text = "Không tìm thấy từ \"" + tu + "\"";
        }

        // Hai lần click liên tiếp trong khoảng thời gian double click của hệ thống
        private bool laDoubleClick()
        {
            DateTime bayGio = DateTime.Now;
            bool kq = (bayGio - lanClickTruoc).TotalMilliseconds <= SystemInformation.DoubleClickTime;
            lanClickTruoc = kq ? DateTime.MinValue : bayGio;
            return kq;
        }

        // ---------- Tab ANH - VIỆT ----------
        private void cboAnh_TextUpdate(object sender, EventArgs e)
        {
            doTim(cboAnh);
        }

        private void cboAnh_KeyDown(object sender, KeyEventArgs e)
        {
            dangXoa = (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete);
            if (e.KeyCode == Keys.Enter)
            {
                traTu(cboAnh, dsAnh, dsViet, txtNghiaViet);
                e.SuppressKeyPress = true;
            }
        }

        private void cboAnh_Click(object sender, EventArgs e)
        {
            if (laDoubleClick())
                traTu(cboAnh, dsAnh, dsViet, txtNghiaViet);
        }

        // ---------- Tab VIỆT - ANH ----------
        private void cboViet_TextUpdate(object sender, EventArgs e)
        {
            doTim(cboViet);
        }

        private void cboViet_KeyDown(object sender, KeyEventArgs e)
        {
            dangXoa = (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete);
            if (e.KeyCode == Keys.Enter)
            {
                traTu(cboViet, dsViet, dsAnh, txtNghiaAnh);
                e.SuppressKeyPress = true;
            }
        }

        private void cboViet_Click(object sender, EventArgs e)
        {
            if (laDoubleClick())
                traTu(cboViet, dsViet, dsAnh, txtNghiaAnh);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
