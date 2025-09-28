# Btap1_LapTrinh Web
# NGUYỄN LAM SƠN
# MSSV:K225480106076
##   BÀI TOÁN: ĐO SỨC MẠNH CỦA NHÂN VẬT
# Tổng quan về công cụ và công việc được dùng trong bài <br>
1) DLL: Thư mục chứa các thư viện động (Dynamic Link Libraries). Những thư viện này thường chứa các hàm hoặc module dùng chung cho nhiều phần khác trong dự án <br>
- Chứa các module tách biệt như xử lý dữ liệu, tính toán, bảo mật...
- Giúp tái sử dụng mã và giảm sự phụ thuộc giữa các phần.
- Có thể được build thành .dll và gọi từ các project khác.
2) console app:Thư mục chứa project chính – có thể là ứng dụng console viết bằng C# hoặc .NET. Đây là nơi chứa mã nguồn chính như Program.cs, các class, và cấu hình <br>
- Chứa file Program.cs hoặc Main() – điểm bắt đầu của chương trình.
- Có thể chứa các class xử lý logic, nhập xuất, tính toán, v.v.
- Là nơi bạn viết mã để chạy chương trình console.
3) WDF ( Windows froms ): Có thể là viết tắt của Windows Driver Framework, đây là nơi chứa mã nguồn cho driver thiết bị. Dùng trong các ứng dụng hệ thống hoặc phần mềm điều khiển phần cứng <br>
- Là một loại ứng dụng desktop có giao diện người dùng, được xây dựng bằng .NET Framework hoặc .NET Core.
- Dùng để tạo các cửa sổ, nút bấm, textbox, bảng dữ liệu, biểu đồ… giống như các phần mềm bạn chạy trên Windows.
- Được thiết kế bằng cách kéo-thả các thành phần giao diện trong Visual Studio, rất trực quan.
- Kết nối với DLL,Giao diện sẽ gọi các hàm xử lý logic nằm trong thư viện DLL. Ví dụ: xử lý dữ liệu, tính toán, truy xuất cơ sở dữ liệu ,Nếu có phần backend hoặc API, WinForms có thể gọi và hiển thị dữ liệu từ đó.
4) Web App :  (ứng dụng web) là một chương trình chạy trên trình duyệt, cho phép người dùng tương tác qua giao diện đồ họa. Trong môi trường .NET, Web App thường được xây dựng bằng <br>
- được viết bằngHTML / CSS / JavaScript, Tạo giao diện người dùng, hiệu ứng, bố cục.
- công cụ hỗ trợ Azure IIS – triển khai Web App lên môi trường thật = máy chủ của Windows
- Sever nhận dữ liệu để DLL xử lý, để ra kết quả dạng json
- client nhận json, cập nhật giao diện

## 1. Tạo DLL <br>
<img width="435" height="270" alt="image" src="https://github.com/user-attachments/assets/be34ddaa-8188-43d5-a7e8-40e923151817" /> <br>
## 2. Tạo consoleapp và File exe <br>
### a) Dẫn DLL vào refenrences của console app <br>
<img width="436" height="252" alt="image" src="https://github.com/user-attachments/assets/75d7ec30-3927-48a4-b540-3cc8f360a168" /> <br>
### b) chạy file exe của console app và kết quả <br>
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/2c23e4b4-884a-43e8-ab37-c98c73fb05b7" /> <br>
### 3. Tạo WDF <br> 
<img width="432" height="325" alt="image" src="https://github.com/user-attachments/assets/f35cf9fc-817e-45bd-8f71-c0c03b7cd1d7" /> <br>
### a) link DLL vào WFA <br>
<img width="892" height="622" alt="image" src="https://github.com/user-attachments/assets/8fa593d8-d80a-4609-9cdb-774df6d6e66f" /> <br>
### b) kết quả chạy WFA <br>
<img width="1129" height="682" alt="image" src="https://github.com/user-attachments/assets/d7ba5147-c2bd-4f26-ac2e-25b843146ca7" /> <br>
## 4 Tạo WEB <br>
<img width="448" height="173" alt="image" src="https://github.com/user-attachments/assets/6b0ce3ad-1bdc-4fb4-8f2b-58dbc0f02e0e" /> <br>
### a) Link DLL vào WEB <br>
<img width="431" height="633" alt="image" src="https://github.com/user-attachments/assets/c83e4628-3f55-4374-8b08-f7111fa92022" /> <br>
### b) viết code, Tạo Backend <br>
<img width="426" height="90" alt="image" src="https://github.com/user-attachments/assets/de30e7b2-bc1f-491d-b97c-d9b3e03a0c90" /> <br>
### c) Cấu Hình IIS VÀ APP pool <br>
## địa chỉ: cosmic.local <br>
<img width="692" height="684" alt="image" src="https://github.com/user-attachments/assets/59879248-e269-44c9-8b91-c12fbc5370df" /> <br>
<img width="693" height="840" alt="image" src="https://github.com/user-attachments/assets/2c1f6373-9737-4103-8e9f-e5607d2a21a6" /> <br>
<img width="653" height="470" alt="image" src="https://github.com/user-attachments/assets/08f5748c-8e3f-4f66-9509-e12508f33d0d" /> <br>
### d) Kết quả <br>
<img width="719" height="595" alt="image" src="https://github.com/user-attachments/assets/c81235f1-fbfb-4a48-9a65-8c1a6d1bf53b" /> <br>





