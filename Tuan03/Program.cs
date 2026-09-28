using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiThucHanhLINQ;

public class MonHoc
{
    public string MaMon { get; set; } = "";
    public string TenMon { get; set; } = "";
    public string He { get; set; } = "";
    public byte SoTiet { get; set; }
}

public class He
{
    public string MaHe { get; set; } = "";
    public string TenHe { get; set; } = "";
}

public static class DuLieu
{
    public static List<MonHoc> DS_Mon()
    {
        return new List<MonHoc>
        {
            new MonHoc { MaMon = "HP2_1", TenMon = "Nền tảng C#", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP2_2", TenMon = "Công nghệ ADO.NET", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP3_1", TenMon = "Lập trình Windows Forms", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP3_2", TenMon = "Xây dựng ứng dụng Windows Forms", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP4_1", TenMon = "Lập trình Web với HTML, CSS và JavaScript", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP4_2", TenMon = "Xây dựng ứng dụng Web với ASP.NET", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP5_1", TenMon = "Lập trình CSDL SQL Server căn bản", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP5_2", TenMon = "Lập trình CSDL SQL Server nâng cao", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "JLCB", TenMon = "Joomla cơ bản", He = "CD", SoTiet = 72 },
            new MonHoc { MaMon = "LINQ", TenMon = "Language-Integrated Query", He = "CD", SoTiet = 64 },
            new MonHoc { MaMon = "DAWEB", TenMon = "Đồ án thực tế Web với ASP.NET", He = "CD", SoTiet = 40 },
            new MonHoc { MaMon = "DAWIN", TenMon = "Đồ án thực tế Windows Forms", He = "CD", SoTiet = 40 },
            new MonHoc { MaMon = "CC++", TenMon = "Lập trình hướng đối tượng với C/C++", He = "CD", SoTiet = 128 },
            new MonHoc { MaMon = "JQUE", TenMon = "JQuery", He = "CD", SoTiet = 22 },
            new MonHoc { MaMon = "XML", TenMon = "Công nghệ XML", He = "CD", SoTiet = 32 },
            new MonHoc { MaMon = "CRYS", TenMon = "Crystal Report trong Visual Studio", He = "CD", SoTiet = 32 },
            new MonHoc { MaMon = "BWEB", TenMon = "HTML, CSS và JavaScript", He = "CD", SoTiet = 32 },
            new MonHoc { MaMon = "XYZ", TenMon = "Chưa đặt tên môn", He = "", SoTiet = 0 }
        };
    }

    public static List<He> DS_He()
    {
        return new List<He>
        {
            new He { MaHe = "KTV", TenHe = "Kỹ thuật viên" },
            new He { MaHe = "CD", TenHe = "Chuyên đề" },
            new He { MaHe = "QT", TenHe = "Chứng chỉ quốc tế" }
        };
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("THỰC HÀNH LINQ CƠ BẢN\n");

        Bai21();
        Bai22();
        Bai31();
        Bai32();
        Bai51();
        Bai52();
        Bai62();

        Console.WriteLine("\nKẾT THÚC CHƯƠNG TRÌNH");
    }
    static void Bai21()
    {
        Console.WriteLine("BÀI 2.1: Truy vấn mảng số nguyên");
        int[] mangSo = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };
        Console.WriteLine("\n--- a. Phần tử chia hết cho 4 và 3 ---");
        var a_query = from n in mangSo
                      where n % 4 == 0 && n % 3 == 0
                      select n;
        Console.WriteLine("Query Syntax: " + string.Join(", ", a_query));
        var a_method = mangSo.Where(n => n % 4 == 0 && n % 3 == 0);
        Console.WriteLine("Method Syntax: " + string.Join(", ", a_method));
        Console.WriteLine("\n--- b. Phần tử <= 3 ---");
        var b_query = from n in mangSo
                      where n <= 3
                      select n;
        Console.WriteLine("Query Syntax: " + string.Join(", ", b_query));
        var b_method = mangSo.Where(n => n <= 3);
        Console.WriteLine("Method Syntax: " + string.Join(", ", b_method));
        Console.WriteLine("\n--- c. Số chẵn / 2, số lẻ giữ nguyên ---");
        var c_query = from n in mangSo
                      select n % 2 == 0 ? n / 2 : n;
        Console.WriteLine("Query Syntax: " + string.Join(", ", c_query));
        var c_method = mangSo.Select(n => n % 2 == 0 ? n / 2 : n);
        Console.WriteLine("Method Syntax: " + string.Join(", ", c_method));
        Console.WriteLine();
    }
    static void Bai22()
    {
        Console.WriteLine("BÀI 2.2: Truy vấn mảng chuỗi");
        string[] mangChuoi = { "đầu", "lòng", "hai", "ả", "tố", "nga",
                               "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân" };

        Console.WriteLine("\n--- a. Phần tử 4 ký tự, sắp xếp theo ký tự đầu ---");
        var a_query = from s in mangChuoi
                      where s.Length == 4
                      orderby s[0]
                      select s;
        Console.WriteLine("Query Syntax: " + string.Join(", ", a_query));
        var a_method = mangChuoi.Where(s => s.Length == 4).OrderBy(s => s[0]);
        Console.WriteLine("Method Syntax: " + string.Join(", ", a_method));
        Console.WriteLine("\n--- b. <chữ thường> - <CHỮ HOA> ---");
        var b_query = from s in mangChuoi
                      select $"{s.ToLower()} - {s.ToUpper()}";
        Console.WriteLine("Query Syntax:");
        foreach (var item in b_query) Console.WriteLine("  " + item);
        var b_method = mangChuoi.Select(s => $"{s.ToLower()} - {s.ToUpper()}");
        Console.WriteLine("Method Syntax:");
        foreach (var item in b_method) Console.WriteLine("  " + item);
        Console.WriteLine("\n--- c. Phần tử chứa ký tự \"u\" ---");
        var c_query = from s in mangChuoi
                      where s.Contains("u")
                      select s;
        Console.WriteLine("Query Syntax: " + string.Join(", ", c_query));
        var c_method = mangChuoi.Where(s => s.Contains("u"));
        Console.WriteLine("Method Syntax: " + string.Join(", ", c_method));
        Console.WriteLine("\n--- d. Phần tử bắt đầu bằng chữ in hoa ---");
        var d_query = from s in mangChuoi
                      where char.IsUpper(s[0])
                      select s;
        Console.WriteLine("Query Syntax: " + string.Join(" ", d_query));
        var d_method = mangChuoi.Where(s => char.IsUpper(s[0]));
        Console.WriteLine("Method Syntax: " + string.Join(" ", d_method));
        Console.WriteLine();
    }
    static void Bai31()
    {
        Console.WriteLine("BÀI 3.1: Thống kê mảng số");
        int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };
        Console.WriteLine("\n--- a. Tổng phần tử, số chẵn, số lẻ ---");
        Console.WriteLine($"Tổng số phần tử: {mangSo.Count()}");
        Console.WriteLine($"Số phần tử chẵn: {mangSo.Count(n => n % 2 == 0)}");
        Console.WriteLine($"Số phần tử lẻ: {mangSo.Count(n => n % 2 != 0)}");
        Console.WriteLine("\n--- b. Tổng, Max, Min ---");
        Console.WriteLine($"Tổng các giá trị: {mangSo.Sum()}");
        Console.WriteLine($"Giá trị lớn nhất: {mangSo.Max()}");
        Console.WriteLine($"Giá trị nhỏ nhất: {mangSo.Min()}");
        Console.WriteLine("\n--- c. Số giá trị khác nhau ---");
        Console.WriteLine($"Số giá trị khác nhau: {mangSo.Distinct().Count()}");
        Console.WriteLine("\n--- d. Phân nhóm theo số dư chia 5 ---");
        var groups = mangSo.GroupBy(n => n % 5);
        foreach (var g in groups)
        {
            Console.WriteLine($"Số dư {g.Key}: {string.Join(", ", g)}");
        }
        Console.WriteLine();
    }
    static void Bai32()
    {
        Console.WriteLine("BÀI 3.2: Thống kê mảng chuỗi");
        string[] monAn = { "Bún bò Huế", "Hủ tiếu heo", "Bánh canh", "Bánh mì",
                           "Nước Cà phê", "Mì quảng", "Cơm tấm", "Nước Chanh dây", "Mì xào",
                           "Bún riêu", "Bánh cuốn", "Mì gói", "Bún chả", "Hủ tiếu Nam vang" };
        Console.WriteLine("\n--- a. Phần tử ngắn nhất và dài nhất ---");
        int minLen = monAn.Min(s => s.Length);
        int maxLen = monAn.Max(s => s.Length);
        var shortest = monAn.Where(s => s.Length == minLen);
        var longest = monAn.Where(s => s.Length == maxLen);
        Console.WriteLine($"Ngắn nhất (độ dài {minLen}): {string.Join(", ", shortest)}");
        Console.WriteLine($"Dài nhất (độ dài {maxLen}): {string.Join(", ", longest)}");
        Console.WriteLine("\n--- b. Phân nhóm theo từ đầu tiên ---");
        var groups = monAn.GroupBy(s => s.Split(' ')[0]);
        foreach (var g in groups)
        {
            Console.WriteLine($"Từ đầu \"{g.Key}\": {string.Join("; ", g)}");
        }
        Console.WriteLine("\n--- c. Số phần tử có từ đầu là \"Bánh\" ---");
        int countBanh = monAn.Count(s => s.StartsWith("Bánh"));
        Console.WriteLine($"Số phần tử: {countBanh}");
        Console.WriteLine();
    }
    static void Bai51()
    {
        Console.WriteLine("BÀI 5.1: Truy vấn cơ bản List<MonHoc>");
        var ds = DuLieu.DS_Mon();
        Console.WriteLine("\n--- a. Môn bắt đầu bằng \"Lập trình\" ---");
        var a_query = from m in ds
                      where m.TenMon.StartsWith("Lập trình")
                      select m.TenMon;
        Console.WriteLine("Query Syntax:");
        foreach (var t in a_query) Console.WriteLine("  " + t);
        var a_method = ds.Where(m => m.TenMon.StartsWith("Lập trình")).Select(m => m.TenMon);
        Console.WriteLine("Method Syntax:");
        foreach (var t in a_method) Console.WriteLine("  " + t);
        Console.WriteLine("\n--- b. Hệ CD, sắp xếp SoTiet giảm, MaMon tăng ---");
        var b_query = from m in ds
                      where m.He == "CD"
                      orderby m.SoTiet descending, m.MaMon
                      select m;
        Console.WriteLine("Query Syntax:");
        foreach (var m in b_query) Console.WriteLine($"  {m.MaMon} - {m.TenMon} ({m.SoTiet} tiết)");
        var b_method = ds.Where(m => m.He == "CD").OrderByDescending(m => m.SoTiet).ThenBy(m => m.MaMon);
        Console.WriteLine("Method Syntax:");
        foreach (var m in b_method) Console.WriteLine($"  {m.MaMon} - {m.TenMon} ({m.SoTiet} tiết)");
        Console.WriteLine("\n--- c. Tên chứa \"web\", lấy TenMon và He ---");
        var c_query = from m in ds
                      where m.TenMon.Contains("web", StringComparison.OrdinalIgnoreCase)
                      select new { m.TenMon, m.He };
        Console.WriteLine("Query Syntax:");
        foreach (var x in c_query) Console.WriteLine($"  {x.TenMon} | {x.He}");
        var c_method = ds.Where(m => m.TenMon.Contains("web", StringComparison.OrdinalIgnoreCase))
                         .Select(m => new { m.TenMon, m.He });
        Console.WriteLine("Method Syntax:");
        foreach (var x in c_method) Console.WriteLine($"  {x.TenMon} | {x.He}");
        Console.WriteLine("\n--- d. Hệ KTV, sắp xếp MaMon tăng ---");
        var d_query = from m in ds
                      where m.He == "KTV"
                      orderby m.MaMon
                      select m;
        Console.WriteLine("Query Syntax:");
        foreach (var m in d_query) Console.WriteLine($"  {m.MaMon} - {m.TenMon}");
        var d_method = ds.Where(m => m.He == "KTV").OrderBy(m => m.MaMon);
        Console.WriteLine("Method Syntax:");
        foreach (var m in d_method) Console.WriteLine($"  {m.MaMon} - {m.TenMon}");
        Console.WriteLine();
    }
    static void Bai52()
    {
        Console.WriteLine("BÀI 5.2: Thống kê List<MonHoc>");
        var ds = DuLieu.DS_Mon();
        Console.WriteLine("\n--- a. Tổng số môn hiện có ---");
        Console.WriteLine($"Tổng số môn: {ds.Count()}");
        Console.WriteLine("\n--- b. Số môn tên bắt đầu \"Lập trình\" ---");
        Console.WriteLine($"Số môn: {ds.Count(m => m.TenMon.StartsWith("Lập trình"))}");
        Console.WriteLine("\n--- c. Tổng số tiết hệ KTV ---");
        Console.WriteLine($"Tổng số tiết: {ds.Where(m => m.He == "KTV").Sum(m => m.SoTiet)}");
        Console.WriteLine("\n--- d. Tổng số môn mỗi hệ ---");
        var d = ds.GroupBy(m => m.He)
                  .Select(g => new { He = string.IsNullOrEmpty(g.Key) ? "(trống)" : g.Key, Tong = g.Count() });
        foreach (var x in d) Console.WriteLine($"  Hệ {x.He}: {x.Tong} môn");
        Console.WriteLine("\n--- e. Nhóm theo Số tiết (giảm dần) ---");
        var e = ds.GroupBy(m => m.SoTiet)
                  .Select(g => new { SoTiet = g.Key, Tong = g.Count() })
                  .OrderByDescending(x => x.SoTiet);
        foreach (var x in e) Console.WriteLine($"  Số tiết {x.SoTiet}: {x.Tong} môn");
        Console.WriteLine("\n--- f. Môn có số tiết cao nhất ---");
        int maxTiet = ds.Max(m => m.SoTiet);
        var f = ds.Where(m => m.SoTiet == maxTiet);
        foreach (var m in f) Console.WriteLine($"  {m.MaMon} - {m.TenMon} ({m.SoTiet} tiết)");
        Console.WriteLine("\n--- g. Thống kê theo Hệ ---");
        var g = ds.GroupBy(m => string.IsNullOrEmpty(m.He) ? "(trống)" : m.He)
                  .Select(gr => new
                  {
                      He = gr.Key,
                      TongMon = gr.Count(),
                      TongTiet = gr.Sum(m => m.SoTiet),
                      MaxTiet = gr.Max(m => m.SoTiet),
                      MinTiet = gr.Min(m => m.SoTiet)
                  });
        foreach (var x in g)
            Console.WriteLine($"  Hệ {x.He}: {x.TongMon} môn, tổng tiết {x.TongTiet}, max {x.MaxTiet}, min {x.MinTiet}");
        Console.WriteLine("\n--- h. Phân nhóm theo Hệ ---");
        var h = ds.GroupBy(m => string.IsNullOrEmpty(m.He) ? "(trống)" : m.He);
        foreach (var gr in h)
        {
            Console.WriteLine($"  Hệ {gr.Key}:");
            foreach (var m in gr) Console.WriteLine($"    {m.MaMon} - {m.TenMon}");
        }
        Console.WriteLine("\n--- i. Phân nhóm theo Số tiết (tăng dần) ---");
        var i = ds.GroupBy(m => m.SoTiet).OrderBy(g => g.Key);
        foreach (var gr in i)
        {
            Console.WriteLine($"  Số tiết {gr.Key}:");
            foreach (var m in gr) Console.WriteLine($"    {m.MaMon} - {m.TenMon}");
        }
        Console.WriteLine("\n--- j. Hệ KTV, phân nhóm theo học phần HP2/3/4/5 ---");
        var j = ds.Where(m => m.He == "KTV")
                  .GroupBy(m => m.MaMon.Length >= 3 ? m.MaMon.Substring(0, 3) : m.MaMon)
                  .OrderBy(g => g.Key);
        foreach (var gr in j)
        {
            Console.WriteLine($"  Học phần {gr.Key}:");
            foreach (var m in gr.OrderBy(m => m.MaMon))
                Console.WriteLine($"    {m.MaMon} - {m.TenMon}");
        }
        Console.WriteLine("\n--- k. Phân nhóm theo Hệ (SoTiet > 40), sắp MaMon ---");
        var k = ds.Where(m => m.SoTiet > 40)
                  .GroupBy(m => string.IsNullOrEmpty(m.He) ? "(trống)" : m.He);
        foreach (var gr in k)
        {
            Console.WriteLine($"  Hệ {gr.Key}:");
            foreach (var m in gr.OrderBy(m => m.MaMon))
                Console.WriteLine($"    {m.MaMon} - {m.TenMon} ({m.SoTiet})");
        }
        Console.WriteLine();
    }

    static void Bai62()
    {
        Console.WriteLine("BÀI 6.2: Join và các toán tử tập hợp");
        var dsMon = DuLieu.DS_Mon();
        var dsHe = DuLieu.DS_He();

        Console.WriteLine("\n--- a. Join: Tên hệ, Mã môn, Tên môn ---");
        var a = from h in dsHe
                join m in dsMon on h.MaHe equals m.He
                select new { h.TenHe, m.MaMon, m.TenMon };
        foreach (var x in a) Console.WriteLine($"  {x.TenHe} | {x.MaMon} | {x.TenMon}");

        Console.WriteLine("\n--- b. Left outer join (hệ chưa có môn) ---");
        var b = from h in dsHe
                join m in dsMon on h.MaHe equals m.He into monGroup
                from m in monGroup.DefaultIfEmpty()
                select new
                {
                    h.TenHe,
                    MaMon = m?.MaMon ?? "(không có)",
                    TenMon = m?.TenMon ?? "(không có)"
                };
        foreach (var x in b) Console.WriteLine($"  {x.TenHe} | {x.MaMon} | {x.TenMon}");

        Console.WriteLine("\n--- c. Full outer (hệ chưa môn + môn chưa hệ) ---");
        var left = from h in dsHe
                   join m in dsMon on h.MaHe equals m.He into monGroup
                   from m in monGroup.DefaultIfEmpty()
                   select new
                   {
                       TenHe = h.TenHe,
                       MaMon = m?.MaMon ?? "(không có)",
                       TenMon = m?.TenMon ?? "(không có)"
                   };
        var rightOnly = from m in dsMon
                        where !dsHe.Any(h => h.MaHe == m.He)
                        select new
                        {
                            TenHe = "(không có hệ)",
                            MaMon = m.MaMon,
                            TenMon = m.TenMon
                        };
        var full = left.Union(rightOnly);
        foreach (var x in full) Console.WriteLine($"  {x.TenHe} | {x.MaMon} | {x.TenMon}");

        Console.WriteLine("\n--- d. Chỉ hệ chưa môn + môn chưa hệ ---");
        var heChuaMon = from h in dsHe
                        where !dsMon.Any(m => m.He == h.MaHe)
                        select new { TenHe = h.TenHe, MaMon = "(không có)", TenMon = "(không có)" };
        var monChuaHe = from m in dsMon
                        where !dsHe.Any(h => h.MaHe == m.He)
                        select new { TenHe = "(không có hệ)", MaMon = m.MaMon, TenMon = m.TenMon };
        foreach (var x in heChuaMon.Union(monChuaHe))
            Console.WriteLine($"  {x.TenHe} | {x.MaMon} | {x.TenMon}");

        Console.WriteLine("\n--- e. 5 môn số tiết giảm dần ---");
        var e = (from m in dsMon
                 join h in dsHe on m.He equals h.MaHe into heGroup
                 from h in heGroup.DefaultIfEmpty()
                 orderby m.SoTiet descending
                 select new
                 {
                     TenHe = h?.TenHe ?? "(không có)",
                     m.MaMon,
                     m.TenMon,
                     m.SoTiet
                 }).Take(5);
        foreach (var x in e) Console.WriteLine($"  {x.TenHe} | {x.MaMon} | {x.TenMon} | {x.SoTiet}");


        Console.WriteLine("\n--- f. Tổng số môn mỗi hệ ---");
        var f = from h in dsHe
                join m in dsMon on h.MaHe equals m.He into monGroup
                select new { h.MaHe, h.TenHe, Tong = monGroup.Count() };
        foreach (var x in f) Console.WriteLine($"  {x.MaHe} - {x.TenHe}: {x.Tong} môn");

        Console.WriteLine("\n--- g. Số loại Số tiết khác nhau ---");
        Console.WriteLine($"Số loại Số tiết: {dsMon.Select(m => m.SoTiet).Distinct().Count()}");
        Console.WriteLine("\n--- h. Môn đầu tiên bắt đầu \"Lập trình\" ---");
        var h_mon = dsMon.FirstOrDefault(m => m.TenMon.StartsWith("Lập trình"));
        if (h_mon != null)
            Console.WriteLine($"  {h_mon.MaMon} - {h_mon.TenMon} ({h_mon.SoTiet} tiết)");
        else
            Console.WriteLine("  Không tìm thấy");
        Console.WriteLine("\n--- i. Môn theo từng hệ, đánh số thứ tự ---");
        var i = from m in dsMon
                group m by (string.IsNullOrEmpty(m.He) ? "(trống)" : m.He) into gr
                select new
                {
                    He = gr.Key,
                    Mons = gr.Select((m, index) => new { STT = index + 1, m.MaMon, m.TenMon })
                };
        foreach (var gr in i)
        {
            Console.WriteLine($"  Hệ {gr.He}:");
            foreach (var x in gr.Mons)
                Console.WriteLine($"    {x.STT}. {x.MaMon} - {x.TenMon}");
        }
        Console.WriteLine();
    }
}
