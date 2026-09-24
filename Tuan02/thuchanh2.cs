using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_ThucHanh
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
                Console.WriteLine("Menu bài tập thực hành lập trình hướng đối tượng (C#)");
                Console.WriteLine("1. Bài 1.1: Tính tuổi 1 sinh viên");
                Console.WriteLine("2. Bài 1.2: Lớp Point (điểm 2D)");
                Console.WriteLine("3. Bài 1.3: Lớp Person (quản lý nhân khẩu)");
                Console.WriteLine("4. Bài 1.4: Lớp phân số (đa năng toán tử)");
                Console.WriteLine("5. Bài 1.5: Lớp đơn thức");
                Console.WriteLine("6. Bài 2.1: ArrayPoint (lớp chứa Point)");
                Console.WriteLine("7. Bài 2.2: PersonList (quản lý danh sách Person)");
                Console.WriteLine("8. Bài 2.3a: Lớp mảng 1 chiều");
                Console.WriteLine("9. Bài 2.4a: Lớp mảng 2 chiều");
                Console.WriteLine("10. Bài 2.3b: Lớp đa thức");
                Console.WriteLine("11. Bài 2.4b: Lớp dãy phân số");
                Console.WriteLine("12. Bài 2.5: Tính tổng lương phòng ban");
                Console.WriteLine("13. Bài 3.1 & 3.2 & 3.3: Demo sắp xếp (Interface, Delegate)");
                Console.WriteLine("14. Bài 3.4: Console menu (Event/Delegate giải PT bậc 2)");
                Console.WriteLine("15. Bài 3.5: Tính lương nhân viên (kế thừa đa hình)");
                Console.WriteLine("16. Bài 3.6: Tính điểm thí sinh thi tin học");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn bài (0-16): ");

                string chon = Console.ReadLine();
                Console.WriteLine();

                switch (chon)
                {
                    case "1": TestBai1_1(); break;
                    case "2": TestBai1_2(); break;
                    case "3": TestBai1_3(); break;
                    case "4": TestBai1_4(); break;
                    case "5": TestBai1_5(); break;
                    case "6": TestBai2_1(); break;
                    case "7": TestBai2_2(); break;
                    case "8": TestBai2_3a(); break;
                    case "9": TestBai2_4a(); break;
                    case "10": TestBai2_3b(); break;
                    case "11": TestBai2_4b(); break;
                    case "12": TestBai2_5(); break;
                    case "13": TestBai3_123(); break;
                    case "14": TestBai3_4(); break;
                    case "15": TestBai3_5(); break;
                    case "16": TestBai3_6(); break;
                    case "0": return;
                    default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
                }

                Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                Console.ReadKey();
            }
        }

        static void TestBai1_1()
        {
            Console.WriteLine("Bài 1.1: Tính tuổi sinh viên");
            SinhVien sv = new SinhVien();
            sv.Input();
            sv.Output();
        }

        static void TestBai1_2()
        {
            Console.WriteLine("Bài 1.2: Lớp Point");
            Point p1 = new Point(3, 4);
            Point p2 = new Point();
            p2.Input();
            Console.WriteLine($"P1: {p1}, P2: {p2}");
            Console.WriteLine($"P1 + P2 = {p1 + p2}");
            Console.WriteLine($"Khoảng cách: {Point.Distance(p1, p2)}");
            Console.WriteLine($"Trung điểm: {Point.MidPoint(p1, p2)}");
        }

        static void TestBai1_3()
        {
            Console.WriteLine("Bài 1.3: Lớp Person");
            Person p = new Person();
            p.Input();
            p.Output();
        }

        static void TestBai1_4()
        {
            Console.WriteLine("Bài 1.4: Lớp phân số");
            PhanSo ps1 = new PhanSo(1, 2);
            PhanSo ps2 = new PhanSo(3, 4);
            Console.WriteLine($"PS1: {ps1}, PS2: {ps2}");
            Console.WriteLine($"Cộng: {ps1 + ps2}");
            Console.WriteLine($"Nhân: {ps1 * ps2}");
            Console.WriteLine($"PS1 > PS2: {ps1 > ps2}");
        }

        static void TestBai1_5()
        {
            Console.WriteLine("Bài 1.5: Lớp đơn thức");
            DonThuc dt = new DonThuc(3, 2); // 3x^2
            Console.WriteLine($"Đơn thức: {dt}");
            Console.WriteLine($"Tại x = 2, giá trị = {dt.TinhGiaTri(2)}");
            Console.WriteLine($"Đạo hàm: {dt.DaoHam()}");
        }

        static void TestBai2_1()
        {
            Console.WriteLine("Bài 2.1: Array Point");
            ArrayPoint arr = new ArrayPoint();
            arr.Add(new Point(1, 1));
            arr.Add(new Point(2, 2));
            for (int i = 0; i < 2; i++) Console.WriteLine(arr[i]);
        }

        static void TestBai2_2()
        {
            Console.WriteLine("Bài 2.2: PersonList");
            PersonList list = new PersonList();
            list.Input();
            Console.WriteLine("\nDanh sách người còn sống:");
            list.LivingPeople().Output();
        }

        static void TestBai2_3a()
        {
            Console.WriteLine("Bài 2.3: Lớp mảng 1 chiều");
            Mang1Chieu mang = new Mang1Chieu(5);
            mang.Input();
            mang.Output();
            mang.XuatSoChan();
        }

        static void TestBai2_4a()
        {
            Console.WriteLine("Bài 2.4: Lớp mảng 2 chiều");
            Mang2Chieu mang = new Mang2Chieu(2, 2);
            mang.Input();
            mang.Output();
            mang.XuatSoNguyenTo();
        }

        static void TestBai2_3b()
        {
            Console.WriteLine("Bài 2.3 (b): Lớp đa thức");
            DaThuc dt = new DaThuc(2); // Bậc 2
            dt.Input();
            dt.Output();
            Console.Write("Nhập x để tính: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine($"P({x}) = {dt.TinhGiaTri(x)}");
        }

        static void TestBai2_4b()
        {
            Console.WriteLine("Bài 2.4 (b): Dãy phân số");
            DayPhanSo day = new DayPhanSo();
            day.Input();
            Console.WriteLine($"Tổng dãy: {day.TinhTong()}");
        }

        static void TestBai2_5()
        {
            Console.WriteLine("Bài 2.5: Lương nhân viên phòng ban");
            PhongBan pb = new PhongBan();
            pb.Input();
            Console.WriteLine($"Tổng lương phòng ban: {pb.TongLuong():N0} VNĐ");
        }

        static void TestBai3_123()
        {
            Console.WriteLine("Bài 3.1 - 3.3: Demo Sort");
            List<int> list = new List<int> { 5, 2, 8, 1, 9 };
            list.Sort(); // Demo nhanh
            Console.WriteLine("Đã sắp xếp: " + string.Join(", ", list));
        }

        static void TestBai3_4()
        {
            Console.WriteLine("Bài 3.4: Console Menu với Event");
            PTBac2Console app = new PTBac2Console();
            app.Run();
        }

        static void TestBai3_5()
        {
            Console.WriteLine("Bài 3.5: Lương nhân viên đa hình");
            List<NhanVienDaHinh> ds = new List<NhanVienDaHinh>();
            Console.WriteLine("Nhập 1 NV Kinh Doanh:");
            NVKinhDoanh nv1 = new NVKinhDoanh(); nv1.Input(); ds.Add(nv1);
            Console.WriteLine("Nhập 1 NV Sản Xuất:");
            NVSanXuat nv2 = new NVSanXuat(); nv2.Input(); ds.Add(nv2);
            
            Console.WriteLine("\nLương nhân viên:");
            foreach (var nv in ds) nv.Output();
        }

        static void TestBai3_6()
        {
            Console.WriteLine("Bài 3.6: Tính điểm thí sinh");
            List<ThiSinh> ds = new List<ThiSinh>();
            Console.WriteLine("Nhập thí sinh Chuyên:");
            ThiSinhChuyen ts1 = new ThiSinhChuyen(); ts1.Input(); ds.Add(ts1);
            Console.WriteLine("Nhập thí sinh Siêu Cúp:");
            ThiSinhSieuCup ts2 = new ThiSinhSieuCup(); ts2.Input(); ds.Add(ts2);

            Console.WriteLine("\nKết quả thi:");
            foreach (var ts in ds) ts.Output();
        }
    }


    // Bài 1.1
    class SinhVien
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public void Input()
        {
            Console.Write("Nhập họ tên: "); HoTen = Console.ReadLine();
            Console.Write("Nhập năm sinh: "); NamSinh = int.Parse(Console.ReadLine());
        }
        public void Output() => Console.WriteLine($"Sinh viên {HoTen}, Tuổi: {DateTime.Now.Year - NamSinh}");
    }

    // Bài 1.2
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        
        public Point() { X = 0; Y = 0; }
        public Point(double x, double y) { X = x; Y = y; }
        public Point(Point p) { X = p.X; Y = p.Y; }

        public void Input()
        {
            Console.Write("Nhập x: "); X = double.Parse(Console.ReadLine());
            Console.Write("Nhập y: "); Y = double.Parse(Console.ReadLine());
        }
        public void Output() => Console.WriteLine(ToString());
        public override string ToString() => $"({X}, {Y})";

        public static Point operator +(Point a, Point b) => new Point(a.X + b.X, a.Y + b.Y);
        public static Point operator -(Point a, Point b) => new Point(a.X - b.X, a.Y - b.Y);
        public static Point operator -(Point a) => new Point(-a.X, -a.Y);

        public double DistanceTo(Point b) => Math.Sqrt(Math.Pow(X - b.X, 2) + Math.Pow(Y - b.Y, 2));
        public static double Distance(Point a, Point b) => a.DistanceTo(b);

        public Point MidPointWith(Point b) => new Point((X + b.X) / 2, (Y + b.Y) / 2);
        public static Point MidPoint(Point a, Point b) => a.MidPointWith(b);
    }

    // Bài 1.3
    class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public int Yod { get; set; }

        public Person() { }
        public Person(Person p) { Id = p.Id; Name = p.Name; Yob = p.Yob; Yod = p.Yod; }

        public void Input()
        {
            Console.Write("Nhập ID: "); Id = Console.ReadLine();
            Console.Write("Nhập Tên: "); Name = Console.ReadLine();
            Console.Write("Năm sinh: "); Yob = int.Parse(Console.ReadLine());
            Console.Write("Năm mất (0 nếu còn sống): "); Yod = int.Parse(Console.ReadLine());
        }
        public void Output() => Console.WriteLine($"[{Id}] {Name} - Sinh: {Yob} - {(IsLiving() ? "Còn sống" : "Đã mất")}");
        public bool IsLiving() => Yod == 0;
    }

    // Bài 1.4
    class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        public PhanSo() { TuSo = 0; MauSo = 1; }
        public PhanSo(int tu, int mau) { TuSo = tu; MauSo = mau != 0 ? mau : 1; RutGon(); }
        public PhanSo(PhanSo p) { TuSo = p.TuSo; MauSo = p.MauSo; }

        public void RutGon()
        {
            int ucln = UCLN(Math.Abs(TuSo), Math.Abs(MauSo));
            TuSo /= ucln; MauSo /= ucln;
            if (MauSo < 0) { TuSo = -TuSo; MauSo = -MauSo; }
        }
        private int UCLN(int a, int b) => b == 0 ? a : UCLN(b, a % b);

        public override string ToString() => MauSo == 1 ? $"{TuSo}" : $"{TuSo}/{MauSo}";

        public static PhanSo operator +(PhanSo a, PhanSo b) => new PhanSo(a.TuSo * b.MauSo + b.TuSo * a.MauSo, a.MauSo * b.MauSo);
        public static PhanSo operator -(PhanSo a, PhanSo b) => new PhanSo(a.TuSo * b.MauSo - b.TuSo * a.MauSo, a.MauSo * b.MauSo);
        public static PhanSo operator *(PhanSo a, PhanSo b) => new PhanSo(a.TuSo * b.TuSo, a.MauSo * b.MauSo);
        public static PhanSo operator /(PhanSo a, PhanSo b) => new PhanSo(a.TuSo * b.MauSo, a.MauSo * b.TuSo);

        public static bool operator >(PhanSo a, PhanSo b) => a.TuSo * b.MauSo > b.TuSo * a.MauSo;
        public static bool operator <(PhanSo a, PhanSo b) => b > a;
    }

    // Bài 1.5
    class DonThuc
    {
        public double A { get; set; }
        public int N { get; set; }

        public DonThuc(double a, int n) { A = a; N = n >= 0 ? n : 0; }
        public double TinhGiaTri(double x) => A * Math.Pow(x, N);
        public DonThuc DaoHam() => N == 0 ? new DonThuc(0, 0) : new DonThuc(A * N, N - 1);
        public override string ToString() => $"{A}x^{N}";
    }
    #region PHẦN 2: LỚP NÂNG CAO (COLLECTIONS, INDEXER)
    // Bài 2.1
    class ArrayPoint
    {
        private ArrayList list = new ArrayList();
        public void Add(Point p) => list.Add(p);
        public Point this[int i] => (Point)list[i];
    }

    // Bài 2.2
    class PersonList
    {
        private List<Person> list = new List<Person>();
        public void Add(Person p) => list.Add(p);
        public void Input()
        {
            Console.Write("Số lượng người: "); int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) { Person p = new Person(); p.Input(); Add(p); }
        }
        public void Output() { foreach (var p in list) p.Output(); }
        public PersonList LivingPeople()
        {
            PersonList res = new PersonList();
            foreach (var p in list) if (p.IsLiving()) res.Add(p);
            return res;
        }
    }

    // Bài 2.3a
    class Mang1Chieu
    {
        private int[] data;
        public Mang1Chieu(int n) { data = new int[n]; }
        public int this[int i] { get => data[i]; set => data[i] = value; }
        
        public void Input()
        {
            for (int i = 0; i < data.Length; i++) { Console.Write($"a[{i}]= "); data[i] = int.Parse(Console.ReadLine()); }
        }
        public void Output() => Console.WriteLine(string.Join(" ", data));
        public void XuatSoChan()
        {
            Console.Write("Số chẵn: ");
            foreach (int x in data) if (x % 2 == 0) Console.Write(x + " ");
            Console.WriteLine();
        }
    }

    // Bài 2.4a
    class Mang2Chieu
    {
        private int[,] data;
        public Mang2Chieu(int n, int m) { data = new int[n, m]; }
        public int this[int i, int j] { get => data[i, j]; set => data[i, j] = value; }

        public void Input()
        {
            for (int i = 0; i < data.GetLength(0); i++)
                for (int j = 0; j < data.GetLength(1); j++)
                { Console.Write($"a[{i},{j}]= "); data[i, j] = int.Parse(Console.ReadLine()); }
        }
        public void Output()
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++) Console.Write(data[i, j] + "\t");
                Console.WriteLine();
            }
        }
        public void XuatSoNguyenTo()
        {
            Console.Write("Số nguyên tố: ");
            foreach (int x in data)
            {
                bool isPrime = x > 1;
                for (int k = 2; k <= Math.Sqrt(x); k++) if (x % k == 0) { isPrime = false; break; }
                if (isPrime) Console.Write(x + " ");
            }
            Console.WriteLine();
        }
    }

    // Bài 2.3b
    class DaThuc
    {
        private DonThuc[] ds;
        public DaThuc(int n) { ds = new DonThuc[n + 1]; }
        public DonThuc this[int i] { get => ds[i]; set => ds[i] = value; }

        public void Input()
        {
            for (int i = 0; i < ds.Length; i++)
            {
                Console.Write($"Hệ số cho x^{i}: ");
                ds[i] = new DonThuc(double.Parse(Console.ReadLine()), i);
            }
        }
        public void Output() => Console.WriteLine(string.Join(" + ", ds.Select(d => d.ToString())));
        public double TinhGiaTri(double x) => ds.Sum(d => d.TinhGiaTri(x));
    }

    // Bài 2.4
    class DayPhanSo
    {
        private List<PhanSo> list = new List<PhanSo>();
        public void Input()
        {
            Console.Write("Số phân số n: "); int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Tử số {i + 1}: "); int tu = int.Parse(Console.ReadLine());
                Console.Write($"Mẫu số {i + 1}: "); int mau = int.Parse(Console.ReadLine());
                list.Add(new PhanSo(tu, mau));
            }
        }
        public PhanSo TinhTong()
        {
            PhanSo sum = new PhanSo(0, 1);
            foreach (var ps in list) sum += ps;
            return sum;
        }
    }

    // Bài 2.5
    class NhanVienPhongBan
    {
        public string HoTen { get; set; }
        public double Luong { get; set; }
        public int NgayVang { get; set; }
        public double TinhLuong() => Luong - (NgayVang * 100000);
    }
    class PhongBan
    {
        List<NhanVienPhongBan> ds = new List<NhanVienPhongBan>();
        public void Input()
        {
            Console.Write("Số nhân viên: "); int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var nv = new NhanVienPhongBan();
                Console.Write("Họ tên: "); nv.HoTen = Console.ReadLine();
                Console.Write("Mức lương: "); nv.Luong = double.Parse(Console.ReadLine());
                Console.Write("Ngày vắng: "); nv.NgayVang = int.Parse(Console.ReadLine());
                ds.Add(nv);
            }
        }
        public double TongLuong() => ds.Sum(nv => nv.TinhLuong());
    }
   
    // Bài 3.4
    class ConsoleMenu
    {
        public event Action Choose;
        public void RunMenu()
        {
            Console.WriteLine("1. Giải PT bậc 2\n0. Thoát");
            Console.Write("Thực hiện: ");
            if (Console.ReadLine() == "1") Choose?.Invoke();
        }
    }
    class PTBac2Console : ConsoleMenu
    {
        public PTBac2Console() { Choose += GiaiPT; }
        public void Run() => RunMenu();
        private void GiaiPT()
        {
            Console.WriteLine("Đang giải phương trình ax^2 + bx + c = 0...");
            Console.Write("a = "); double a = double.Parse(Console.ReadLine());
            Console.Write("b = "); double b = double.Parse(Console.ReadLine());
            Console.Write("c = "); double c = double.Parse(Console.ReadLine());
            
            double delta = b * b - 4 * a * c;
            if (delta < 0) Console.WriteLine("Vô nghiệm");
            else if (delta == 0) Console.WriteLine($"Nghiệm kép x = {-b / (2 * a)}");
            else Console.WriteLine($"x1 = {(-b + Math.Sqrt(delta)) / (2 * a)}, x2 = {(-b - Math.Sqrt(delta)) / (2 * a)}");
        }
    }

    // Bài 3.5
    abstract class NhanVienDaHinh
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        protected double LuongCoBan = 5000000;
        public virtual void Input()
        {
            Console.Write("Mã NV: "); MaNV = Console.ReadLine();
            Console.Write("Họ tên: "); HoTen = Console.ReadLine();
        }
        public abstract double TinhLuong();
        public virtual void Output() => Console.WriteLine($"[{MaNV}] {HoTen} - Lương: {TinhLuong():N0}");
    }
    class NVKinhDoanh : NhanVienDaHinh
    {
        public int SoHD { get; set; }
        public override void Input() { base.Input(); Console.Write("Số HĐ: "); SoHD = int.Parse(Console.ReadLine()); }
        public override double TinhLuong() => LuongCoBan + (SoHD * 500000);
    }
    class NVSanXuat : NhanVienDaHinh
    {
        public int SoSP { get; set; }
        public override void Input() { base.Input(); Console.Write("Số SP: "); SoSP = int.Parse(Console.ReadLine()); }
        public override double TinhLuong() => (SoSP * 1000) + (SoSP > 3000 ? (SoSP * 1000) * 0.05 : 0);
    }

    // Bài 3.6
    abstract class ThiSinh
    {
        public string Sbd { get; set; }
        public string HoTen { get; set; }
        public double Bai1 { get; set; }
        public double Bai2 { get; set; }
        public double Bai3 { get; set; }

        public virtual void Input()
        {
            Console.Write("SBD: "); Sbd = Console.ReadLine();
            Console.Write("Họ tên: "); HoTen = Console.ReadLine();
            Console.Write("Điểm bài 1,2,3 (cách nhau khoảng trắng): ");
            var diem = Console.ReadLine().Split(' ');
            Bai1 = double.Parse(diem[0]); Bai2 = double.Parse(diem[1]); Bai3 = double.Parse(diem[2]);
        }
        public abstract double TinhTongDiem();
        public void Output() => Console.WriteLine($"[{Sbd}] {HoTen} - Tổng điểm: {TinhTongDiem()}");
    }

    class ThiSinhChuyen : ThiSinh
    {
        public double TiengAnh { get; set; }
        public override void Input()
        {
            base.Input();
            Console.Write("Điểm Tiếng Anh: "); TiengAnh = double.Parse(Console.ReadLine());
        }
        public override double TinhTongDiem()
        {
            double tong = Bai1 + Bai2 + Bai3;
            if (TiengAnh >= 9) tong += 2;
            else if (TiengAnh >= 7) tong += 1;
            return tong;
        }
    }

    class ThiSinhSieuCup : ThiSinh
    {
        public double Csdl { get; set; }
        public override void Input()
        {
            base.Input();
            Console.Write("Điểm CSDL: "); Csdl = double.Parse(Console.ReadLine());
        }
        public override double TinhTongDiem() => Bai1 + Bai2 + Bai3 + Csdl;
    }
    #endregion
}