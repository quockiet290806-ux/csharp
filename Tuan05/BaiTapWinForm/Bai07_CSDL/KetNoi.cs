using System;
using System.Data;
using System.Data.SqlClient;

namespace BaiTapWinForm.Bai07_CSDL
{
    // Lớp dùng chung cho các form của Bài 7: giữ chuỗi kết nối và các thao tác với CSDL QLSinhVien
    public static class KetNoi
    {
        // Cách 1: đăng nhập với quyền Windows Authentication
        // Sửa lại Data Source cho đúng tên server SQL trên máy (ví dụ: .  hoặc  TENMAY\SQLEXPRESS)
        public static string ChuoiKetNoi =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True";


        // Thực hiện câu lệnh Insert / Update / Delete, trả về số dòng bị tác động
        public static int ThucThi(string sql, params SqlParameter[] thamSo)
        {
            SqlConnection conn = new SqlConnection(ChuoiKetNoi);
            try
            {
                //Kiem tra ket noi truoc khi mo
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddRange(thamSo);
                return cmd.ExecuteNonQuery();
            }
            finally
            {
                //Kiem tra ket noi truoc khi dong
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        // Thực hiện câu lệnh Select Count(*), trả về giá trị đếm được
        public static int Dem(string sql, params SqlParameter[] thamSo)
        {
            SqlConnection conn = new SqlConnection(ChuoiKetNoi);
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddRange(thamSo);
                return (int)cmd.ExecuteScalar();
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        // Đổi lỗi của SQL Server thành câu thông báo dễ hiểu
        public static string LayThongBaoLoi(Exception ex)
        {
            SqlException loiSql = ex as SqlException;
            if (loiSql != null)
            {
                if (loiSql.Number == 2627)
                    return "Mã đã tồn tại trong cơ sở dữ liệu (trùng khóa chính).";
                if (loiSql.Number == 547)
                    return "Vi phạm ràng buộc khóa ngoại: mã liên quan không tồn tại hoặc dữ liệu đang được bảng khác sử dụng.";
            }
            return ex.Message;
        }
    }
}
