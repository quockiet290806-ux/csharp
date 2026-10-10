using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapWinForm.TH05d.BaiMau3_FileDialog
{
    public partial class frmFileDialog : Form
    {
        public frmFileDialog()
        {
            InitializeComponent();
        }

        // Lưu nội dung đã nhập thành file *.txt
        private void btnLuu_Click(object sender, EventArgs e)
        {
            SaveFileDialog svg = new SaveFileDialog();
            svg.Filter = "Text files | *.txt";
            if (svg.ShowDialog() == DialogResult.OK)
            {
                string filename;
                filename = svg.FileName;
                textBox1.Text = filename;
                StreamWriter sw = File.CreateText(filename);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
        }

        // Mở file *.txt và hiển thị nội dung lên richTextBox
        private void btnMo_Click(object sender, EventArgs e)
        {
            //Lọc loại đuôi file theo mong muốn
            openFileDialog1.Filter = "All Text File (*.txt)|*.txt";
            openFileDialog1.FileName = "";
            //Nếu dialog openFileDialog1 chọn OK
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Gán đường dẫn lên Textbox
                textBox1.Text = openFileDialog1.FileName;
                //Đọc dữ liệu từ file txt dùng StreamReader
                StreamReader f = new StreamReader(openFileDialog1.FileName);
                //Đọc dữ liệu text và gán vào richTextbox
                richTextBox1.Text = f.ReadToEnd();
                // Đóng luồng đọc
                f.Close();
            }
        }
    }
}
