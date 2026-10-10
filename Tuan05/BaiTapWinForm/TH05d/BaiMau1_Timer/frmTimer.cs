using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapWinForm.TH05d.BaiMau1_Timer
{
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();
        }

        private void frmTimer_Load(object sender, EventArgs e)
        {
            // Hiện giờ ngay khi mở form, không phải chờ Tick đầu tiên
            label1.Text = DateTime.Now.ToString();
        }

        // timer1: Enabled = true, Interval = 1000 nên mỗi giây sự kiện Tick phát sinh 1 lần
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Lấy thời gian hệ thống
            DateTime now = DateTime.Now;
            label1.Text = now.ToString();
        }
    }
}
