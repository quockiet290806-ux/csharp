using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapWinForm.TH05c.BaiMau3_TreeView
{
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();
        }

        private void frmTreeView_Load(object sender, EventArgs e)
        {
            string[] pb = { "Giám đốc", "Tổ chức hành chính", "Kế hoạch", "Kế Toán" };
            foreach (string s in pb)
            {
                trv_DS.Nodes.Add(s);          //thêm node vào treeview
                cbo_phongban.Items.Add(s);    //thêm item vào combobox
            }
            cbo_phongban.SelectedIndex = 0;   //item đầu tiên được chọn
        }

        // Kiểm tra trùng phòng ban (không phân biệt chữ hoa chữ thường)
        // Trả về true nếu phòng ban chưa có trong treeview
        bool kiemtra(string s)
        {
            foreach (TreeNode node in trv_DS.Nodes)
            {
                if (string.Compare(node.Text, s, true) == 0)
                    return false;
            }
            return true;
        }

        // Thêm phòng ban mới vào treeview và combobox phòng ban
        private void btn_ThemPB_Click(object sender, EventArgs e)
        {
            string ten = txt_phongban.Text.Trim();
            if (ten == "")
            {
                MessageBox.Show("Bạn chưa nhập tên phòng ban!");
                txt_phongban.Focus();
                return;
            }
            // Kiểm tra txt_phongban có tồn tại trong TreeView chưa
            if (kiemtra(ten))
            {
                trv_DS.Nodes.Add(ten);
                cbo_phongban.Items.Add(ten);
                if (cbo_phongban.SelectedIndex < 0)
                    cbo_phongban.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Phòng ban đã tồn tại!");
            txt_phongban.Text = "";
            txt_phongban.Focus();
        }

        // Xóa phòng ban được chọn trong treeview
        private void btn_XoaPB_Click(object sender, EventArgs e)
        {
            // Phải chọn một node phòng ban (node cấp 0), không phải node nhân viên
            if (trv_DS.SelectedNode == null || trv_DS.SelectedNode.Parent != null)
            {
                MessageBox.Show("Bạn hãy chọn phòng ban cần xóa trên cây!");
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                cbo_phongban.Items.Remove(trv_DS.SelectedNode.Text);
                trv_DS.Nodes.Remove(trv_DS.SelectedNode);
                if (cbo_phongban.SelectedIndex < 0 && cbo_phongban.Items.Count > 0)
                    cbo_phongban.SelectedIndex = 0;
            }
        }

        // Thêm nhân viên của phòng ban vào treeview
        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            if (txt_maso.Text.Trim() == "" || txt_hoten.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã số và họ tên nhân viên!");
                return;
            }
            //tìm index của node có nội dung là item được chọn trong
            //combobox phòng ban
            int index = -1;
            foreach (TreeNode node in trv_DS.Nodes)
                if (node.Text == cbo_phongban.Text)
                {
                    index = node.Index;
                    break;
                }
            if (index < 0)
            {
                MessageBox.Show("Bạn chưa chọn phòng ban!");
                return;
            }
            trv_DS.Nodes[index].Nodes.Add(txt_hoten.Text.Trim() + " (" + txt_maso.Text.Trim() + ")");
            trv_DS.ExpandAll(); //mở rộng treeview
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTreeView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
