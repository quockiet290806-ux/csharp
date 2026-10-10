using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapWinForm.TH05c.NangCao1_XuLyChuoi
{
    public partial class frmChuoi : Form
    {
        string[] HO = { "Lê", "Nguyễn", "Lý", "Trần", "Lâm", "Hồ", "Lai", "Huỳnh", "La" };
        string[] TENLOT = { "Quang", "Thành", "Ngọc", "Anh", "Xuân", "Bảo", "Cẩm", "Thị", "Kim", "Thái", "Hồng" };
        string[] TEN = { "Hà", "Danh", "Sơn", "Mai", "Thắng", "Kỳ", "Thành", "Lâm", "Tâm", "Phụng", "Thắm" };
        Random rd = new Random();

        public frmChuoi()
        {
            InitializeComponent();
        }

        // Thêm vào listbox 50 tên kết hợp ngẫu nhiên từ 3 mảng HO, TENLOT, TEN
        private void btnNgauNhien_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                string hoTen = HO[rd.Next(HO.Length)] + " "
                             + TENLOT[rd.Next(TENLOT.Length)] + " "
                             + TEN[rd.Next(TEN.Length)];
                lstTen.Items.Add(hoTen);
            }
        }

        // Lấy họ (từ đầu tiên) và tên (từ cuối cùng) của một họ tên
        private string layHo(string hoTen)
        {
            string[] tu = hoTen.Trim().Split(' ');
            return tu[0];
        }

        private string layTen(string hoTen)
        {
            string[] tu = hoTen.Trim().Split(' ');
            return tu[tu.Length - 1];
        }

        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            if (lstTen.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn phần tử nào!", "Thông báo");
                return;
            }
            // Xóa từ dưới lên để chỉ số các phần tử phía trên không bị thay đổi
            for (int i = lstTen.SelectedIndices.Count - 1; i >= 0; i--)
                lstTen.Items.RemoveAt(lstTen.SelectedIndices[i]);
        }

        private void btnXoaTenSon_Click(object sender, EventArgs e)
        {
            for (int i = lstTen.Items.Count - 1; i >= 0; i--)
            {
                if (string.Compare(layTen(lstTen.Items[i].ToString()), "Sơn", true) == 0)
                    lstTen.Items.RemoveAt(i);
            }
        }

        private void btnXoaHoLe_Click(object sender, EventArgs e)
        {
            for (int i = lstTen.Items.Count - 1; i >= 0; i--)
            {
                if (string.Compare(layHo(lstTen.Items[i].ToString()), "Lê", true) == 0)
                    lstTen.Items.RemoveAt(i);
            }
        }

        // Viết hoa chữ cái đầu của mỗi từ
        private string vietHoaDauTu(string s)
        {
            string[] tu = s.ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tu.Length; i++)
                tu[i] = char.ToUpper(tu[i][0]) + tu[i].Substring(1);
            return string.Join(" ", tu);
        }

        // Đổi kiểu chữ các phần tử đang chọn: 1 - chữ HOA, 2 - chữ thường, 3 - Hoa đầu mỗi từ
        private void doiKieuChu(int kieu)
        {
            if (lstTen.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn phần tử nào!", "Thông báo");
                return;
            }
            // Lưu lại vị trí các phần tử đang chọn vì khi gán lại Items[i] thì vùng chọn bị thay đổi
            int[] viTri = new int[lstTen.SelectedIndices.Count];
            lstTen.SelectedIndices.CopyTo(viTri, 0);

            foreach (int i in viTri)
            {
                string s = lstTen.Items[i].ToString();
                if (kieu == 1)
                    s = s.ToUpper();
                else if (kieu == 2)
                    s = s.ToLower();
                else
                    s = vietHoaDauTu(s);
                lstTen.Items[i] = s;
            }
            // Chọn lại các phần tử như ban đầu
            foreach (int i in viTri)
                lstTen.SetSelected(i, true);
        }

        private void btnChuHoa_Click(object sender, EventArgs e)
        {
            doiKieuChu(1);
        }

        private void btnChuThuong_Click(object sender, EventArgs e)
        {
            doiKieuChu(2);
        }

        private void btnHoaDauTu_Click(object sender, EventArgs e)
        {
            doiKieuChu(3);
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            lstTen.Items.Clear();
        }

        // Double click vào tên đang chọn thì mở InputBox cho nhập tên mới
        private void lstTen_DoubleClick(object sender, EventArgs e)
        {
            int vt = lstTen.SelectedIndex;
            if (vt < 0)
                return;
            string tenCu = lstTen.Items[vt].ToString();
            string tenMoi = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên mới:", "Đổi tên", tenCu);
            // Nhấn Cancel hoặc để trống thì giữ nguyên tên cũ
            if (tenMoi.Trim() != "")
                lstTen.Items[vt] = tenMoi.Trim();
        }
    }
}
