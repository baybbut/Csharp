using System;


class NhanVien
{
   public string HoTen;
   public double MucLuong;
   public int SoNgayVang;


   // Nhập thông tin nhân viên
   public void Nhap()
   {
       Console.Write("Ho ten: ");
       HoTen = Console.ReadLine();
       Console.Write("Muc luong: ");
       MucLuong = double.Parse(Console.ReadLine());
       Console.Write("So ngay vang: ");
       SoNgayVang = int.Parse(Console.ReadLine());
   }


   // Tính lương
   public double TinhLuong()
   {
       return MucLuong - SoNgayVang * 100000;
   }


   public void Xuat()
   {
       Console.WriteLine("Ho ten: " + HoTen);
       Console.WriteLine("Luong thuc nhan duoc: " + TinhLuong().ToString("N0") + " VND");
   }
}


class TinhToan
{
   static void Main()
   {
       NhanVien nv = new NhanVien();
       nv.Nhap();
       Console.WriteLine("\n--- KET QUA ---");
       nv.Xuat();
   }
}


