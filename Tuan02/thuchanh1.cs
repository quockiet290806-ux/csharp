using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_ThucHanh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu chạy các bài thực hành C#");
                Console.WriteLine("1. Bài 1: Nhập xuất họ tên đơn giản");
                Console.WriteLine("2. Bài 2: Định dạng chuỗi chào hỏi");
                Console.WriteLine("3. Bài 3: Tính x^y");
                Console.WriteLine("4. Bài 4: Tính x^y (có kiểm tra lỗi)");
                Console.WriteLine("5. Bài 5: Menu tính toán số thực");
                Console.WriteLine("6. Bài 6: Tìm max 3 số nguyên");
                Console.WriteLine("7. Bài 7: Kiểm tra số nguyên tố");
                Console.WriteLine("8. Bài 8: Hoán vị 2 số thực (ref)");
                Console.WriteLine("9. Bài 9: Max/min 3 số thực (out)");
                Console.WriteLine("10. Bài 10: Kiểm tra chuỗi đối xứng");
                Console.WriteLine("11. Bài 11: Đảo chuỗi");
                Console.WriteLine("12. Bài 12: Chữ hoa/thường và đếm từ");
                Console.WriteLine("13. Bài 13: Lớp sinh viên");
                Console.WriteLine("14. Bài 14: Tính lương nhân viên");
                Console.WriteLine("15. Bài 15: Mảng 1 chiều");
                Console.WriteLine("16. Bài 16: Sắp xếp mảng họ tên");
                Console.WriteLine("17. Bài 17: Mảng 2 chiều");
                Console.WriteLine("0. Thoát");

                string chon = Console.ReadLine();
                Console.WriteLine();

                switch (chon)
                {
                    case "1": Bai1(); break;
                    case "2": Bai2(); break;
                    case "3": Bai3(); break;
                    case "4": Bai4(); break;
                    case "5": Bai5(); break;
                    case "6": Bai6(); break;
                    case "7": Bai7(); break;
                    case "8": Bai8(); break;
                    case "9": Bai9(); break;
                    case "10": Bai10(); break;
                    case "11": Bai11(); break;
                    case "12": Bai12(); break;
                    case "13": Bai13(); break;
                    case "14": Bai14(); break;
                    case "15": Bai15(); break;
                    case "16": Bai16(); break;
                    case "17": Bai17(); break;
                    case "0": return;
                    default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
                }

                Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                Console.ReadKey();
            }
        }

        static void Bai1()
        {
            Console.WriteLine("Bài 1: Nhập xuất họ tên đơn giản");
            Console.Write("Nhap ho ten cua ban: ");
            string hoTen = Console.ReadLine();
            Console.WriteLine("Ban da nhap: " + hoTen);
        }

        static void Bai2()
        {
            Console.WriteLine("Bài 2: Định dạng chuỗi chào hỏi");
            Console.Write("Nhap ho ten cua ban: ");
            string hoTen = Console.ReadLine();
            Console.WriteLine("Chao ban " + hoTen + "!");
        }

        static void Bai3()
        {
            Console.WriteLine("Bài 3: Tính x^y");
            Console.Write("Nhap so nguyen x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen y: ");
            int y = int.Parse(Console.ReadLine());
            long ketQua = (long)Math.Pow(x, y);
            Console.WriteLine($"Ket qua {x} mu {y} la: {ketQua}");
        }

        static void Bai4()
        {
            Console.WriteLine("Bài 4: Tính x^y (có kiểm tra lỗi)");
            int x, y;
            Console.Write("Nhap so nguyen x: ");
            if (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Loi: x khong phai la so nguyen!");
                return;
            }
            Console.Write("Nhap so nguyen y: ");
            if (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Loi: y khong phai la so nguyen!");
                return;
            }
            long ketQua = (long)Math.Pow(x, y);
            Console.WriteLine($"Ket qua {x} mu {y} la: {ketQua}");
        }

        static void Bai5()
        {
            Console.WriteLine("Bài 5: Menu tính toán số thực");
            double x = 0, y = 0;
            bool daNhap = false;

            while (true)
            {
                Console.WriteLine("\nMenu bài 5");
                Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
                Console.WriteLine("2. Tinh x^y");
                Console.WriteLine("3. Tinh can bac 2 cua x va y");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang: ");

                string chon = Console.ReadLine();
                switch (chon)
                {
                    case "1":
                        Console.Write("Nhap x: ");
                        if (!double.TryParse(Console.ReadLine(), out x))
                        {
                            Console.WriteLine("Loi: x khong hop le!");
                            break;
                        }
                        Console.Write("Nhap y: ");
                        if (!double.TryParse(Console.ReadLine(), out y))
                        {
                            Console.WriteLine("Loi: y khong hop le!");
                            break;
                        }
                        daNhap = true;
                        Console.WriteLine($"Da nhap: x = {x}, y = {y}");
                        break;
                    case "2":
                        if (!daNhap) { Console.WriteLine("Chua nhap x, y!"); break; }
                        Console.WriteLine($"{x}^{y} = {Math.Pow(x, y)}");
                        break;
                    case "3":
                        if (!daNhap) { Console.WriteLine("Chua nhap x, y!"); break; }
                        if (x < 0 || y < 0)
                            Console.WriteLine("Khong the tinh can bac 2 cua so am!");
                        else
                            Console.WriteLine($"Can bac 2 cua {x} = {Math.Sqrt(x)}, cua {y} = {Math.Sqrt(y)}");
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            }
        }

        static void Bai6()
        {
            Console.WriteLine("Bài 6: tìm max 3 số nguyên ");
            Console.Write("Nhap a: "); int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: "); int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap c: "); int c = int.Parse(Console.ReadLine());

            int max = TimMaxBaSo(a, b, c);
            Console.WriteLine($"Gia tri lon nhat la: {max}");
        }

        static int TimMaxBaSo(int a, int b, int c)
        {
            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            return max;
        }

        static void Bai7()
        {
            Console.WriteLine("Bài 7:");
            Console.Write("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());

            if (LaSoNguyenTo(n))
                Console.WriteLine($"{n} la so nguyen to.");
            else
                Console.WriteLine($"{n} khong phai so nguyen to.");
        }

        static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void Bai8()
        {
            Console.WriteLine("Bài 8: Hoán vị 2 số thực (ref)");
            Console.Write("Nhap a: "); double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b: "); double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"Truoc hoan vi: a = {a}, b = {b}");
            HoanVi(ref a, ref b);
            Console.WriteLine($"Sau hoan vi:   a = {a}, b = {b}");
        }

        static void HoanVi(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        static void Bai9()
        {
            Console.WriteLine("Bài 9: Tìm max & min 3 số thực (out)");
            Console.Write("Nhap a: "); double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b: "); double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap c: "); double c = double.Parse(Console.ReadLine());

            double max, min;
            TimMaxMin(a, b, c, out max, out min);

            Console.WriteLine($"Max = {max}, Min = {min}");
        }

        static void TimMaxMin(double a, double b, double c, out double max, out double min)
        {
            max = Math.Max(a, Math.Max(b, c));
            min = Math.Min(a, Math.Min(b, c));
        }

        static void Bai10()
        {
            Console.WriteLine("Bài 10: Kiểm tra chuỗi đối xứng");
            Console.Write("Nhap mot chuoi: ");
            string s = Console.ReadLine();
            Console.WriteLine(LaChuoiDoiXung(s)
                ? $"\"{s}\" la chuoi doi xung."
                : $"\"{s}\" khong phai chuoi doi xung.");
        }

        static bool LaChuoiDoiXung(string s)
        {
            string cleaned = new string(s.Where(c => !char.IsWhiteSpace(c)).ToArray()).ToLower();
            int left = 0, right = cleaned.Length - 1;
            while (left < right)
            {
                if (cleaned[left] != cleaned[right]) return false;
                left++;
                right--;
            }
            return true;
        }

        static void Bai11()
        {
            Console.WriteLine("Bài 11: Đảo chuỗi");
            Console.Write("Nhap mot chuoi: ");
            string s = Console.ReadLine();
            Console.WriteLine($"Chuoi dao: {DaoChuoi(s)}");
        }

        static string DaoChuoi(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static void Bai12()
        {
            Console.WriteLine("Bài 12: Chữ hoa/thường và đếm từ");
            Console.Write("Nhap mot chuoi: ");
            string s = Console.ReadLine();
            Console.WriteLine($"Chuoi thuong: {s.ToLower()}");
            Console.WriteLine($"Chuoi hoa:    {s.ToUpper()}");
            Console.WriteLine($"So tu:        {DemSoTu(s)}");
        }

        static int DemSoTu(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return 0;
            return s.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        static void Bai13()
        {
            Console.WriteLine("Bài 13: Lớp sinh viên");
            SinhVien sv = new SinhVien();
            sv.Nhap();
            sv.Xuat();
        }

        static void Bai14()
        {
            Console.WriteLine("Bài 14: Tính lương nhân viên");
            NhanVien nv = new NhanVien();
            nv.Nhap();
            nv.XuatLuong();
        }

        static void Bai15()
        {
            Console.WriteLine("Bài 15: Mảng 1 chiều");
            Console.Write("Nhap so phan tu n: ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            NhapMang(a);
            Console.Write("Mang vua nhap: ");
            InMang(a);

            int max, min;
            TimMaxMinMang(a, out max, out min);
            Console.WriteLine($"\nMax = {max}, Min = {min}");

            int[] soNguyenTo = LaySoNguyenTo(a);
            Console.Write("Cac so nguyen to: ");
            InMang(soNguyenTo);
            Console.WriteLine();
        }

        static void NhapMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void InMang(int[] a)
        {
            foreach (int x in a) Console.Write(x + " ");
        }

        static void TimMaxMinMang(int[] a, out int max, out int min)
        {
            max = a[0]; min = a[0];
            foreach (int x in a)
            {
                if (x > max) max = x;
                if (x < min) min = x;
            }
        }

        static int[] LaySoNguyenTo(int[] a)
        {
            List<int> list = new List<int>();
            foreach (int x in a)
                if (LaSoNguyenTo(x)) list.Add(x);
            return list.ToArray();
        }

        static void Bai16()
        {
            Console.WriteLine("Bài 16: Sắp xếp mảng họ tên");
            Console.Write("Nhap so nguoi n: ");
            int n = int.Parse(Console.ReadLine());

            string[] ten = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ho ten [{i}]: ");
                ten[i] = Console.ReadLine();
            }

            Array.Sort(ten, StringComparer.OrdinalIgnoreCase);

            Console.WriteLine("\nDanh sach sau khi sap xep:");
            foreach (string t in ten) Console.WriteLine("- " + t);
        }

        static void Bai17()
        {
            Console.WriteLine("Bài 17: Mảng 2 chiều");
            Console.Write("Nhap so dong n: "); int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot m: "); int m = int.Parse(Console.ReadLine());

            int[,] A = new int[n, m];
            SinhMangNgauNhien(A, 10, 100);
            Console.WriteLine("\nMang A:");
            InMang2Chieu(A);

            int[] chan, le;
            TachChanLe(A, out chan, out le);

            Console.Write("\nCac so chan: ");
            InMang(chan);
            Console.Write("\nCac so le:   ");
            InMang(le);
            Console.WriteLine();
        }

        static void SinhMangNgauNhien(int[,] A, int min, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    A[i, j] = rnd.Next(min, max + 1);
        }

        static void InMang2Chieu(int[,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    Console.Write($"{A[i, j],4}");
                Console.WriteLine();
            }
        }

        static void TachChanLe(int[,] A, out int[] chan, out int[] le)
        {
            List<int> listChan = new List<int>();
            List<int> listLe = new List<int>();
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 2 == 0) listChan.Add(A[i, j]);
                    else listLe.Add(A[i, j]);
                }
            chan = listChan.ToArray();
            le = listLe.ToArray();
        }
    }

    class SinhVien
    {
        public string MaSV;
        public string HoTen;
        public string DiaChi;
        public int NamThu;
        
        public SinhVien()
        {
            MaSV = "";
            HoTen = "";
            DiaChi = "";
            NamThu = 1;
        }

        public void Nhap()
        {
            Console.Write("Nhap ma sinh vien: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap sinh vien nam thu: ");
            NamThu = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("\nThông tin sinh viên");
            Console.WriteLine($"Ma SV   : {MaSV}");
            Console.WriteLine($"Ho ten  : {HoTen}");
            Console.WriteLine($"Dia chi : {DiaChi}");
            Console.WriteLine($"Nam thu : {NamThu}");
        }
    }

    class NhanVien
    {
        public string HoTen;
        public double MucLuong;
        public int SoNgayVang;

        public NhanVien()
        {
            HoTen = "";
            MucLuong = 0;
            SoNgayVang = 0;
        }

        public void Nhap()
        {
            Console.Write("Nhap ho ten nhan vien: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap muc luong: ");
            MucLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhap so ngay vang: ");
            SoNgayVang = int.Parse(Console.ReadLine());
        }

        public double TinhLuong()
        {
            return MucLuong - SoNgayVang * 100000;
        }

        public void XuatLuong()
        {
            Console.WriteLine("\nThông tin lương");
            Console.WriteLine($"Ho ten      : {HoTen}");
            Console.WriteLine($"Muc luong   : {MucLuong:N0} VNĐ");
            Console.WriteLine($"So ngay vang: {SoNgayVang}");
            Console.WriteLine($"Luong nhan  : {TinhLuong():N0} VNĐ");
        }
    }
}