using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaiTapWinForm.TH05c.BaiMau1_ListBox;
using BaiTapWinForm.TH05c.BaiMau2_ComboBox;
using BaiTapWinForm.TH05c.BaiMau3_TreeView;
using BaiTapWinForm.TH05c.TaiLop1_UocSo;
using BaiTapWinForm.TH05c.TaiLop2_QuanLySinhVien;
using BaiTapWinForm.TH05c.NangCao1_XuLyChuoi;
using BaiTapWinForm.TH05c.VeNha1_TuDien;
using BaiTapWinForm.TH05c.VeNha2_ListBoxSo;
using BaiTapWinForm.TH05c.VeNha3_DanhBa;
using BaiTapWinForm.TH05d.BaiMau1_Timer;
using BaiTapWinForm.TH05d.BaiMau2_ListView;
using BaiTapWinForm.TH05d.BaiMau3_FileDialog;
using BaiTapWinForm.TH05d.TaiLop1_SinhVien;
using BaiTapWinForm.TH05d.TaiLop2_TaiKhoan;
using BaiTapWinForm.TH05d.NangCao1_HocVien;
using BaiTapWinForm.TH05d.VeNha1_DemNguoc;
using BaiTapWinForm.Bai07_CSDL.BaiMau_QLKhoa;
using BaiTapWinForm.Bai07_CSDL.TaiLop1_QLMonHoc;
using BaiTapWinForm.Bai07_CSDL.NangCao1_QLSinhVien;
using BaiTapWinForm.Bai07_CSDL.NangCao2_QLDiem;
using BaiTapWinForm.Bai07_CSDL.VeNha1_QLLop;

namespace BaiTapWinForm.TH05d.VeNha2_FormMain
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Hiển thị form bài tập tương ứng với menu được chọn
        private void moForm(Form frm)
        {
            frm.ShowDialog();
            frm.Dispose();
        }

        // ---------- TH 05c ----------
        private void mnu05cMau1_Click(object sender, EventArgs e)
        {
            moForm(new frmListBox());
        }

        private void mnu05cMau2_Click(object sender, EventArgs e)
        {
            moForm(new frmCboDanToc());
        }

        private void mnu05cMau3_Click(object sender, EventArgs e)
        {
            moForm(new frmTreeView());
        }

        private void mnu05cTaiLop1_Click(object sender, EventArgs e)
        {
            moForm(new frmUocSo());
        }

        private void mnu05cTaiLop2_Click(object sender, EventArgs e)
        {
            moForm(new frmQuanLySinhVien());
        }

        private void mnu05cNangCao1_Click(object sender, EventArgs e)
        {
            moForm(new frmChuoi());
        }

        private void mnu05cVeNha1_Click(object sender, EventArgs e)
        {
            moForm(new frmTuDien());
        }

        private void mnu05cVeNha2_Click(object sender, EventArgs e)
        {
            moForm(new frmListboxSo());
        }

        private void mnu05cVeNha3_Click(object sender, EventArgs e)
        {
            moForm(new frmDanhBa());
        }

        // ---------- TH 05d ----------
        private void mnu05dMau1_Click(object sender, EventArgs e)
        {
            moForm(new frmTimer());
        }

        private void mnu05dMau2_Click(object sender, EventArgs e)
        {
            moForm(new frmListView());
        }

        private void mnu05dMau3_Click(object sender, EventArgs e)
        {
            moForm(new frmFileDialog());
        }

        private void mnu05dTaiLop1_Click(object sender, EventArgs e)
        {
            moForm(new frmBaitap1());
        }

        private void mnu05dTaiLop2_Click(object sender, EventArgs e)
        {
            moForm(new frmBaiTap2());
        }

        private void mnu05dNangCao1_Click(object sender, EventArgs e)
        {
            moForm(new frmQuanLyHocVien());
        }

        private void mnu05dVeNha1_Click(object sender, EventArgs e)
        {
            moForm(new frmDemNguoc());
        }

        // ---------- Bài 7 - Cơ sở dữ liệu ----------
        private void mnuBai7Khoa_Click(object sender, EventArgs e)
        {
            moForm(new QLKhoa());
        }

        private void mnuBai7MonHoc_Click(object sender, EventArgs e)
        {
            moForm(new frmQLMonHoc());
        }

        private void mnuBai7SinhVien_Click(object sender, EventArgs e)
        {
            moForm(new frmQLSinhVien());
        }

        private void mnuBai7Diem_Click(object sender, EventArgs e)
        {
            moForm(new frmQLDiem());
        }

        private void mnuBai7Lop_Click(object sender, EventArgs e)
        {
            moForm(new frmQLLop());
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
