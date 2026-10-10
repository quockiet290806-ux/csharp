using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapWinForm.TH05c.TaiLop2_QuanLySinhVien
{
    public partial class frmQuanLySinhVien : Form
    {
        // Node gốc "Danh sách lớp"
        // Cấp 0: Danh sách lớp, cấp 1: lớp, cấp 2: "Mã SV, Họ tên", cấp 3: địa chỉ
        private TreeNode nodeGoc;

        public frmQuanLySinhVien()
        {
            InitializeComponent();
        }

        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            nodeGoc = trvLop.Nodes.Add("Danh sách lớp");
            string[] dsLop = { "05DHTH1", "05DHTH2", "05DHTH3", "05DHTH4" };
            foreach (string lop in dsLop)
            {
                nodeGoc.Nodes.Add(lop);
                cboLop.Items.Add(lop);
            }
            cboLop.SelectedIndex = 0;
            trvLop.ExpandAll();

            // Lúc đầu checkbox Thêm lớp là false, ẩn groupbox Thông tin lớp
            chkThemLop.Checked = false;
            grpLop.Visible = false;
        }

        private void chkThemLop_CheckedChanged(object sender, EventArgs e)
        {
            grpLop.Visible = chkThemLop.Checked;
            if (chkThemLop.Checked)
                txtTenLop.Focus();
        }

        // Tìm node lớp theo tên (không phân biệt hoa thường), không có trả về null
        private TreeNode timLop(string tenLop)
        {
            foreach (TreeNode lop in nodeGoc.Nodes)
            {
                if (string.Compare(lop.Text, tenLop, true) == 0)
                    return lop;
            }
            return null;
        }

        // Lấy mã sinh viên từ node sinh viên có dạng "Mã SV, Họ tên"
        private string layMaSV(TreeNode nodeSV)
        {
            return nodeSV.Text.Split(',')[0].Trim();
        }

        // Kiểm tra mã sinh viên đã có trong tất cả các lớp chưa
        private bool trungMaSV(string maSV)
        {
            foreach (TreeNode lop in nodeGoc.Nodes)
            {
                foreach (TreeNode sv in lop.Nodes)
                {
                    if (string.Compare(layMaSV(sv), maSV, true) == 0)
                        return true;
                }
            }
            return false;
        }

        // Thêm lớp mới vào treeview và combobox chọn lớp
        private void btnThemLop_Click(object sender, EventArgs e)
        {
            string tenLop = txtTenLop.Text.Trim();
            if (tenLop == "")
            {
                MessageBox.Show("Bạn chưa nhập tên lớp!", "Thông báo");
                txtTenLop.Focus();
                return;
            }
            if (timLop(tenLop) != null)
            {
                MessageBox.Show("Lớp " + tenLop + " đã tồn tại!", "Thông báo");
                txtTenLop.SelectAll();
                txtTenLop.Focus();
                return;
            }
            nodeGoc.Nodes.Add(tenLop);
            cboLop.Items.Add(tenLop);
            nodeGoc.Expand();
            txtTenLop.Clear();
            txtTenLop.Focus();
        }

        // Thêm sinh viên vào lớp đang chọn trên combobox
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            if (maSV == "" || hoTen == "" || diaChi == "")
            {
                MessageBox.Show("Mã SV, Họ tên, Địa chỉ không được để trống!", "Thông báo");
                return;
            }
            if (trungMaSV(maSV))
            {
                MessageBox.Show("Mã sinh viên " + maSV + " đã tồn tại!", "Thông báo");
                txtMaSV.SelectAll();
                txtMaSV.Focus();
                return;
            }
            TreeNode lop = timLop(cboLop.Text);
            if (lop == null)
            {
                MessageBox.Show("Bạn chưa chọn lớp!", "Thông báo");
                return;
            }

            TreeNode sv = lop.Nodes.Add(maSV + ", " + hoTen);
            sv.Nodes.Add(diaChi);
            lop.ExpandAll();

            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtMaSV.Focus();
        }

        // Chỉ cho xóa node là sinh viên đang chọn trên treeview
        private void btnXoa_Click(object sender, EventArgs e)
        {
            TreeNode node = trvLop.SelectedNode;
            if (node == null || node.Level != 2)
            {
                MessageBox.Show("Bạn hãy chọn một sinh viên trên cây để xóa!", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên " + node.Text + "?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                node.Remove();
                txtMaSV.Clear();
                txtHoTen.Clear();
                txtDiaChi.Clear();
            }
        }

        // Chọn node sinh viên thì hiện thông tin lên các textbox
        private void trvLop_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level != 2)
                return;
            // Tách "Mã SV, Họ tên" thành 2 phần ở dấu phẩy đầu tiên
            string[] tt = e.Node.Text.Split(new char[] { ',' }, 2);
            txtMaSV.Text = tt[0].Trim();
            txtHoTen.Text = tt.Length > 1 ? tt[1].Trim() : "";
            txtDiaChi.Text = e.Node.Nodes.Count > 0 ? e.Node.Nodes[0].Text : "";
            cboLop.SelectedItem = e.Node.Parent.Text;
        }
    }
}
