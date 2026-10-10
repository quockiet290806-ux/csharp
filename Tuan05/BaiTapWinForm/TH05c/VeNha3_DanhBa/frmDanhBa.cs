using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapWinForm.TH05c.VeNha3_DanhBa
{
    public partial class frmDanhBa : Form
    {
        public frmDanhBa()
        {
            InitializeComponent();
        }

        // Vẽ icon hình người 16x16 để đưa vào ImageList
        private Bitmap taoIcon(Color mau)
        {
            Bitmap bmp = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                using (SolidBrush co = new SolidBrush(mau))
                {
                    g.FillEllipse(co, 5, 1, 6, 6);          // đầu
                    g.FillPie(co, 2, 8, 12, 14, 180, 180);  // thân
                }
            }
            return bmp;
        }

        private void frmDanhBa_Load(object sender, EventArgs e)
        {
            // Hình 0: chữ cái chưa có người, hình 1: chữ cái đã có người / người trong danh bạ
            imgDanhBa.Images.Add(taoIcon(Color.DarkGoldenrod));
            imgDanhBa.Images.Add(taoIcon(Color.RoyalBlue));

            // Treeview chứa tất cả các ký tự từ A đến Z
            for (char c = 'A'; c <= 'Z'; c++)
            {
                TreeNode node = trvDanhBa.Nodes.Add(c.ToString());
                node.ImageIndex = 0;
                node.SelectedImageIndex = 0;
            }
        }

        // Lấy chữ cái đầu của tên, bỏ dấu tiếng Việt (Ánh -> A, Đức -> D)
        // Trả về '\0' nếu tên không bắt đầu bằng chữ cái
        private char layChuCaiDau(string ten)
        {
            string s = ten.Trim().ToUpper();
            if (s == "")
                return '\0';
            if (s[0] == 'Đ')
                return 'D';
            // Tách ký tự có dấu thành ký tự gốc + dấu, lấy ký tự gốc
            char c = s.Substring(0, 1).Normalize(NormalizationForm.FormD)[0];
            if (c >= 'A' && c <= 'Z')
                return c;
            return '\0';
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            if (firstName == "" || lastName == "")
            {
                MessageBox.Show("Bạn phải nhập đủ First Name và Last Name!", "Thông báo");
                return;
            }
            char chuDau = layChuCaiDau(firstName);
            if (chuDau == '\0')
            {
                MessageBox.Show("First Name phải bắt đầu bằng chữ cái!", "Thông báo");
                txtFirstName.SelectAll();
                txtFirstName.Focus();
                return;
            }

            // Node chữ cái nằm ở vị trí tương ứng trong bảng chữ cái
            TreeNode nodeChu = trvDanhBa.Nodes[chuDau - 'A'];
            string ten = firstName + ", " + lastName;
            foreach (TreeNode n in nodeChu.Nodes)
            {
                if (string.Compare(n.Text, ten, true) == 0)
                {
                    MessageBox.Show("Người này đã có trong danh bạ!", "Thông báo");
                    return;
                }
            }

            TreeNode nodeMoi = nodeChu.Nodes.Add(ten);
            nodeMoi.ImageIndex = 1;
            nodeMoi.SelectedImageIndex = 1;
            nodeChu.ImageIndex = 1;
            nodeChu.SelectedImageIndex = 1;
            nodeChu.Expand();
            trvDanhBa.SelectedNode = nodeMoi;

            txtFirstName.Clear();
            txtLastName.Clear();
            txtFirstName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
