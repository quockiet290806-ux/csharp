using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapWinForm.Bai07_CSDL.BaiMau_QLKhoa
{
    public partial class QLKhoa : Form
    {
        SqlConnection conn;

        public QLKhoa()
        {
            InitializeComponent();
            conn = new SqlConnection(KetNoi.ChuoiKetNoi);
        }

        // Thêm Mã khoa, Tên khoa vừa nhập vào bảng Khoa
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text.Trim() == "" || txtTenKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa, Tên khoa không được để trống!");
                return;
            }
            try
            {
                //Kiem tra ket noi truoc khi mo
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                //Xac dinh chuoi truy van
                string insertString;
                insertString = "insert into Khoa values(@MaKhoa, @TenKhoa)";
                //Khai bao command moi
                SqlCommand cmd = new SqlCommand(insertString, conn);
                cmd.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text.Trim());
                cmd.Parameters.AddWithValue("@TenKhoa", txtTenKhoa.Text.Trim());
                //Goi ExecuteNonQuery de gui command
                cmd.ExecuteNonQuery();
                //Hien thi thong bao
                MessageBox.Show("Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại\n" + KetNoi.LayThongBaoLoi(ex));
            }
            finally
            {
                //Kiem tra ket noi truoc khi dong
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        // Xóa khoa có Mã khoa vừa nhập khỏi bảng Khoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được để trống!");
                return;
            }
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                //Chuoi truy van ung voi yeu cau xoa du lieu
                string deleteString = "delete Khoa where MaKhoa = @MaKhoa";
                SqlCommand cmd = new SqlCommand(deleteString, conn);
                cmd.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text.Trim());
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Không tìm thấy mã khoa " + txtMaKhoa.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại\n" + KetNoi.LayThongBaoLoi(ex));
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        // Sửa Tên khoa của khoa có Mã khoa vừa nhập
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text.Trim() == "" || txtTenKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa, Tên khoa không được để trống!");
                return;
            }
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                //Chuoi truy van ung voi yeu cau sua du lieu
                string updateString = "update Khoa set TenKhoa = @TenKhoa where MaKhoa = @MaKhoa";
                SqlCommand cmd = new SqlCommand(updateString, conn);
                cmd.Parameters.AddWithValue("@TenKhoa", txtTenKhoa.Text.Trim());
                cmd.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text.Trim());
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Không tìm thấy mã khoa " + txtMaKhoa.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại\n" + KetNoi.LayThongBaoLoi(ex));
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
