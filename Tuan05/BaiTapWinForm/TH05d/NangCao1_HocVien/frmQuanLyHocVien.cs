using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapWinForm.TH05d.NangCao1_HocVien
{
    public partial class frmQuanLyHocVien : Form
    {
        public frmQuanLyHocVien()
        {
            InitializeComponent();
        }

        // Form nhập học viên mới gọi phương thức này để đưa họ tên vào listbox tương ứng
        public void ThemHocVien(string hoTen, string lop)
        {
            if (lop == "Lớp A")
                lstLopA.Items.Add(hoTen);
            else
                lstLopB.Items.Add(hoTen);
        }

        // Chuyển các mục đang chọn từ listbox nguồn sang listbox đích
        private void chuyenLop(ListBox nguon, ListBox dich)
        {
            while (nguon.SelectedItems.Count > 0)
            {
                dich.Items.Add(nguon.SelectedItems[0]);
                nguon.Items.RemoveAt(nguon.SelectedIndices[0]);
            }
        }

        private void xoaDangChon(ListBox lst)
        {
            for (int i = lst.SelectedIndices.Count - 1; i >= 0; i--)
                lst.Items.RemoveAt(lst.SelectedIndices[i]);
        }

        private void mnuNhapMoi_Click(object sender, EventArgs e)
        {
            frmNhapHocVien frm = new frmNhapHocVien(this);
            frm.ShowDialog();
        }

        private void mnuChuyenB_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn học viên trong Lớp A trước!", "Thông báo");
                return;
            }
            chuyenLop(lstLopA, lstLopB);
        }

        private void mnuChuyenA_Click(object sender, EventArgs e)
        {
            if (lstLopB.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn học viên trong Lớp B trước!", "Thông báo");
                return;
            }
            chuyenLop(lstLopB, lstLopA);
        }

        // Xóa tất cả các học viên đang chọn trong Lớp A và Lớp B
        private void mnuXoa_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItems.Count == 0 && lstLopB.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn học viên cần xóa trước!", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa các học viên đang chọn?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                xoaDangChon(lstLopA);
                xoaDangChon(lstLopB);
            }
        }

        private void mnuKetThuc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn kết thúc chương trình không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
