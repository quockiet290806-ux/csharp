using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapWinForm.TH05c.BaiMau2_ComboBox
{
    public partial class frmCboDanToc : Form
    {
        public frmCboDanToc()
        {
            InitializeComponent();
        }

        // Load 5 dân tộc vào combobox
        private void btn_loadDL_Click(object sender, EventArgs e)
        {
            string[] dt = { "Kinh", "Hoa", "K’Me", "H’Mong", "Khac" };
            // Xóa dữ liệu cũ để nhấn nhiều lần không bị trùng
            cbo_dt.Items.Clear();
            foreach (string s in dt)
            {
                cbo_dt.Items.Add(s);
            }
        }

        // Cách 1: nhấn button Hiển thị, dân tộc được chọn hiện ra label
        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            string s = "Dân tộc được chọn: ";
            if (cbo_dt.SelectedIndex >= 0)
                lbl_kq.Text = s + cbo_dt.SelectedItem.ToString();
            else
                lbl_kq.Text = "Bạn chưa chọn dân tộc";
        }

        // Cách 2: hiện MessageBox ngay khi chọn
        private void cbo_dt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_dt.SelectedIndex >= 0)
                MessageBox.Show("Dân tộc được chọn: " + cbo_dt.SelectedItem.ToString());
        }
    }
}
