# C#

Bài thực hành cá nhân môn C#, sắp xếp theo ngày giao bài trên Classroom. Tuần 1 bắt đầu ngày 07/09/2026.

## Tổng quan bài thực hành

Các mốc tuần dưới đây được tính theo lịch học, mỗi tuần cách nhau 7 ngày.

| Tuần | Thời gian | Nội dung chính | Chi tiết |
|---|---|---|---|
| 02 | 14–20/09/2026 | Lab02 — C# cơ bản và lập trình hướng đối tượng | [Tuần 02](Tuan02/README.md) |
| 03 | 21–27/09/2026 | Lab03 — LINQ cơ bản | [Tuần 03](Tuan03/README.md) |
| 04 | 28/09–04/10/2026 | Lab04 — Windows Forms cơ bản | [Tuần 04](Tuan04/README.md) |
| 05 | 05–11/10/2026 | Lab05 — Windows Forms nâng cao | [Tuần 05](Tuan05/README.md) |

## Nội dung đã tập hợp

### Tuần 02

- Hai file thực hành về nhập xuất, tính toán, chuỗi, mảng và truyền tham số `ref`/`out`.
- Bài tập xây dựng lớp, đối tượng, kế thừa và đa hình.
- Mã nguồn trong [thuchanh1.cs](Tuan02/thuchanh1.cs), [thuchanh2.cs](Tuan02/thuchanh2.cs) và [báo cáo](Tuan02/baocao.docx).

### Tuần 03

- Truy vấn dữ liệu bằng Query Syntax và Method Syntax.
- Thực hành lọc, biến đổi, sắp xếp, gom nhóm, thống kê và kết hợp dữ liệu.
- Có [bản LINQPad](Tuan03/thuchanh3.linq), [project .NET 8](Tuan03/BaiThucHanhLINQ.csproj) và [báo cáo](Tuan03/BaoCao_ThucHanh_LINQ.docx).

### Tuần 04

- Hai ứng dụng Windows Forms dùng .NET 8 trên Windows.
- [Máy tính bỏ túi](Tuan04/MayTinhBoTui/) và [quản lý thanh toán](Tuan04/QuanLyThanhToan/).
- Kèm [báo cáo thực hành](Tuan04/baocao.docx).

### Tuần 05

- Nhóm bài 05c về ListBox, ComboBox, TreeView, xử lý chuỗi, quản lý sinh viên, từ điển và danh bạ.
- Nhóm bài 05d về Timer, ListView, hộp thoại file, quản lý học viên và đồng hồ đếm ngược.
- Form chính cung cấp menu mở các màn hình bài tập.
- Có các màn hình làm việc với SQL Server để quản lý khoa, môn học, sinh viên, điểm và lớp.
- Kèm [solution Windows Forms](Tuan05/BaiTapWinForm.sln), [script cơ sở dữ liệu](Tuan05/BaiTapWinForm/Bai07_CSDL/Database/QLSinhVien.sql) và [báo cáo](Tuan05/BaoCao_ThucHanh.docx).

## Môi trường sử dụng

- Tuần 03 dùng .NET 8, có thể chạy theo hướng dẫn trong README của tuần.
- Tuần 04 dùng .NET 8 với Windows Forms trên Windows.
- Tuần 05 dùng Visual Studio và .NET Framework 4.7.2. Các màn hình cơ sở dữ liệu cần SQL Server, script dựng dữ liệu và cấu hình máy chủ trong `KetNoi.cs`.

## Cập nhật repository ngày 16/11/2026

- Bổ sung README tổng hợp và liên kết đến mã nguồn, báo cáo của từng tuần.
- Điều chỉnh Author Date và Committer Date của các commit Tuần 02–05 theo mốc lịch học ở bảng trên. Đây là metadata được cập nhật lại ngày 16/11/2026.
- Dọn commit và file thử nghiệm ngày commit khỏi nhánh `main`.
