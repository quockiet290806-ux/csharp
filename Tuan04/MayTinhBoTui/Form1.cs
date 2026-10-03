using System;
using System.Windows.Forms;

namespace MayTinhBoTui
{
    public partial class Form1 : Form
    {
        // Lưu số thứ nhất
        double soThuNhat = 0;

        // Lưu phép tính
        string phepTinh = "";

        public Form1()
        {
            InitializeComponent();

            // Hiển thị 0 ban đầu
            txtManHinh.Text = "0";
        }

        // =========================
        // CÁC NÚT SỐ
        // =========================

        private void btn0_Click(object sender, EventArgs e)
        {
            ThemSo("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ThemSo("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ThemSo("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ThemSo("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ThemSo("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ThemSo("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ThemSo("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ThemSo("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ThemSo("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ThemSo("9");
        }


        // =========================
        // THÊM SỐ VÀO MÀN HÌNH
        // =========================

        private void ThemSo(string so)
        {
            if (txtManHinh.Text == "0")
            {
                txtManHinh.Text = so;
            }
            else
            {
                txtManHinh.Text += so;
            }
        }


        // =========================
        // CÁC PHÉP TÍNH
        // =========================

        private void btnCong_Click(object sender, EventArgs e)
        {
            LuuPhepTinh("+");
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            LuuPhepTinh("-");
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            LuuPhepTinh("*");
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            LuuPhepTinh("/");
        }


        // =========================
        // LƯU PHÉP TÍNH
        // =========================

        private void LuuPhepTinh(string phep)
        {
            soThuNhat = double.Parse(txtManHinh.Text);

            phepTinh = phep;

            txtManHinh.Text = "0";
        }


        // =========================
        // NÚT =
        // =========================

        private void btnBang_Click(object sender, EventArgs e)
        {
            double soThuHai = double.Parse(txtManHinh.Text);

            double ketQua = 0;

            switch (phepTinh)
            {
                case "+":
                    ketQua = soThuNhat + soThuHai;
                    break;

                case "-":
                    ketQua = soThuNhat - soThuHai;
                    break;

                case "*":
                    ketQua = soThuNhat * soThuHai;
                    break;

                case "/":

                    if (soThuHai == 0)
                    {
                        MessageBox.Show(
                            "Không thể chia cho 0!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }

                    ketQua = soThuNhat / soThuHai;
                    break;
            }

            txtManHinh.Text = ketQua.ToString();
        }


        // =========================
        // NÚT C - XÓA
        // =========================

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtManHinh.Text = "0";

            soThuNhat = 0;

            phepTinh = "";
        }
    }
}