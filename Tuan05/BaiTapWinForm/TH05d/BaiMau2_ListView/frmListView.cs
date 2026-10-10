using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapWinForm.TH05d.BaiMau2_ListView
{
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        // Kiểm tra trùng mã số sinh viên, boQua là dòng không cần so sánh (dùng khi sửa)
        private bool trungMaSV(string mssv, ListViewItem boQua)
        {
            foreach (ListViewItem item in lstv1.Items)
            {
                if (item != boQua && string.Compare(item.Text, mssv, true) == 0)
                    return true;
            }
            return false;
        }

        private bool kiemTraNhap()
        {
            if (txtmssv.Text.Trim() == "" || txthoten.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập Mã SV và Họ tên!", "Thông báo");
                return false;
            }
            return true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (!kiemTraNhap())
                return;
            if (trungMaSV(txtmssv.Text.Trim(), null))
            {
                MessageBox.Show("Mã số sinh viên đã tồn tại!", "Thông báo");
                txtmssv.Focus();
                return;
            }
            //cách 1
            //lstv1.Items.Add(txtmssv.Text).SubItems.Add(txthoten.Text);
            //cách 2
            ListViewItem item = new ListViewItem();
            ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();
            item.Text = txtmssv.Text.Trim();
            subitem.Text = txthoten.Text.Trim();
            item.SubItems.Add(subitem);
            lstv1.Items.Add(item);
            //cách 3
            /*ListViewItem item1 = new ListViewItem(new[] { txtmssv.Text, txthoten.Text });
            lstv1.Items.Add(item1); */

            txtmssv.Clear();
            txthoten.Clear();
            txtmssv.Focus();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem l in lstv1.SelectedItems)
            {
                l.Remove();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (lstv1.FocusedItem != null && lstv1.FocusedItem.Index >= 0)
            {
                if (!kiemTraNhap())
                    return;
                ListViewItem item = lstv1.FocusedItem;
                if (trungMaSV(txtmssv.Text.Trim(), item))
                {
                    MessageBox.Show("Mã số sinh viên đã tồn tại!", "Thông báo");
                    return;
                }
                item.SubItems[0].Text = txtmssv.Text.Trim();
                item.SubItems[1].Text = txthoten.Text.Trim();
            }
        }

        // Chọn một dòng thì đưa thông tin lên textbox để sửa
        private void lstv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstv1.SelectedItems.Count > 0)
            {
                txtmssv.Text = lstv1.SelectedItems[0].SubItems[0].Text;
                txthoten.Text = lstv1.SelectedItems[0].SubItems[1].Text;
            }
        }
    }
}
