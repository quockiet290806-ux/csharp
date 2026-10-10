using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapWinForm.TH05d.TaiLop1_SinhVien
{
    public partial class frmBaitap1 : Form
    {
        public frmBaitap1()
        {
            InitializeComponent();
        }

        private void frmBaitap1_Load(object sender, EventArgs e)
        {
            // Thêm dữ liệu vào combobox dân tộc
            string[] danToc = { "Kinh", "Hoa", "Khơ-me", "H'Mông", "Tày", "Khác" };
            foreach (string s in danToc)
                cboDanToc.Items.Add(s);
            cboDanToc.SelectedIndex = 0;
        }

        private bool trungMaSV(string maSV)
        {
            foreach (ListViewItem item in lvSinhVien.Items)
            {
                if (string.Compare(item.SubItems[1].Text, maSV, true) == 0)
                    return true;
            }
            return false;
        }

        private string layGioiTinh()
        {
            return radNam.Checked ? "Nam" : "Nữ";
        }

        // Ghép các ngoại ngữ được check thành một chuỗi, ví dụ "Anh, Pháp"
        private string layNgoaiNgu()
        {
            List<string> ds = new List<string>();
            if (chkAnh.Checked) ds.Add("Anh");
            if (chkPhap.Checked) ds.Add("Pháp");
            if (chkHoa.Checked) ds.Add("Hoa");
            return string.Join(", ", ds);
        }

        // Đưa các control nhập về trạng thái ban đầu
        private void lamMoi()
        {
            txtHoTen.Clear();
            txtMaSV.Clear();
            txtMaSV.ReadOnly = false;
            radNam.Checked = true;
            chkAnh.Checked = false;
            chkPhap.Checked = false;
            chkHoa.Checked = false;
            cboDanToc.SelectedIndex = 0;
            txtHoTen.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string maSV = txtMaSV.Text.Trim();
            if (hoTen == "" || maSV == "")
            {
                MessageBox.Show("Bạn phải nhập Họ tên và Mã sinh viên!", "Thông báo");
                return;
            }
            // Thêm không cho trùng mã sinh viên
            if (trungMaSV(maSV))
            {
                MessageBox.Show("Mã sinh viên " + maSV + " đã tồn tại!", "Thông báo");
                txtMaSV.Focus();
                return;
            }
            ListViewItem item = new ListViewItem(hoTen);
            item.SubItems.Add(maSV);
            item.SubItems.Add(layGioiTinh());
            item.SubItems.Add(layNgoaiNgu());
            item.SubItems.Add(cboDanToc.Text);
            lvSinhVien.Items.Add(item);
            lvSinhVien.SelectedItems.Clear();
            lamMoi();
        }

        private void xoaSinhVien()
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn sinh viên cần xóa!", "Thông báo");
                return;
            }
            ListViewItem item = lvSinhVien.SelectedItems[0];
            if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên " + item.Text + "?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                item.Remove();
                lamMoi();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaSinhVien();
        }

        // Menu Xóa của ContextMenuStrip khi click phải vào listview
        private void mnuXoa_Click(object sender, EventArgs e)
        {
            xoaSinhVien();
        }

        // Sửa thông tin sinh viên đang chọn, không cho sửa Mã sinh viên
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn sinh viên cần sửa!", "Thông báo");
                return;
            }
            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Họ tên không được để trống!", "Thông báo");
                txtHoTen.Focus();
                return;
            }
            ListViewItem item = lvSinhVien.SelectedItems[0];
            item.SubItems[0].Text = txtHoTen.Text.Trim();
            item.SubItems[2].Text = layGioiTinh();
            item.SubItems[3].Text = layNgoaiNgu();
            item.SubItems[4].Text = cboDanToc.Text;
        }

        // Chọn một dòng trên listview thì hiện thông tin lên các control
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                txtMaSV.ReadOnly = false;
                return;
            }
            ListViewItem item = lvSinhVien.SelectedItems[0];
            txtHoTen.Text = item.SubItems[0].Text;
            txtMaSV.Text = item.SubItems[1].Text;
            txtMaSV.ReadOnly = true;    // không cho sửa mã sinh viên
            if (item.SubItems[2].Text == "Nam")
                radNam.Checked = true;
            else
                radNu.Checked = true;
            string ngoaiNgu = item.SubItems[3].Text;
            chkAnh.Checked = ngoaiNgu.Contains("Anh");
            chkPhap.Checked = ngoaiNgu.Contains("Pháp");
            chkHoa.Checked = ngoaiNgu.Contains("Hoa");
            cboDanToc.SelectedItem = item.SubItems[4].Text;
        }

        // Hỏi xác nhận trước khi đóng form
        private void frmBaitap1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng form không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
