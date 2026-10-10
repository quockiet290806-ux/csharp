using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapWinForm.TH05c.BaiMau1_ListBox
{
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        // Button >: chuyển phần tử đang chọn qua listbox phải
        private void btnQuaPhai_Click(object sender, EventArgs e)
        {
            if (lst_Trai.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn phần tử ở listbox trái!", "Thông báo");
                return;
            }
            // Chuyển giá trị chọn bên trái sang phải
            lst_Phai.Items.Add(lst_Trai.SelectedItem);
            // Xóa giá trị chọn bên trái
            lst_Trai.Items.RemoveAt(lst_Trai.SelectedIndex);
        }

        // Button >>: chuyển tất cả phần tử qua listbox phải
        private void btnQuaPhaiAll_Click(object sender, EventArgs e)
        {
            // Chuyển giá trị items bên trái sang phải
            lst_Phai.Items.AddRange(lst_Trai.Items);
            // Xóa giá trị bên trái
            lst_Trai.Items.Clear();
        }

        // Button <: chuyển phần tử đang chọn qua listbox trái
        private void btnQuaTrai_Click(object sender, EventArgs e)
        {
            if (lst_Phai.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn phần tử ở listbox phải!", "Thông báo");
                return;
            }
            lst_Trai.Items.Add(lst_Phai.SelectedItem);
            lst_Phai.Items.RemoveAt(lst_Phai.SelectedIndex);
        }

        // Button <<: chuyển tất cả phần tử qua listbox trái
        private void btnQuaTraiAll_Click(object sender, EventArgs e)
        {
            lst_Trai.Items.AddRange(lst_Phai.Items);
            lst_Phai.Items.Clear();
        }

        // Button Chuyển tùy ý: chọn item nào bên trái thì chuyển item đó qua phải
        // (lst_Trai có SelectionMode = MultiExtended nên chọn được nhiều item)
        private void btnChuyenTuyY_Click(object sender, EventArgs e)
        {
            if (lst_Trai.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn phần tử nào để chuyển!", "Thông báo");
                return;
            }
            // Mỗi lần lấy item đang chọn đầu tiên, chuyển xong thì xóa
            // cho đến khi không còn item nào được chọn
            while (lst_Trai.SelectedItems.Count > 0)
            {
                lst_Phai.Items.Add(lst_Trai.SelectedItems[0]);
                lst_Trai.Items.RemoveAt(lst_Trai.SelectedIndices[0]);
            }
        }

        // Đóng form có xác nhận từ người dùng
        private void frmListBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn đóng form không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No)
                e.Cancel = true;
        }
    }
}
