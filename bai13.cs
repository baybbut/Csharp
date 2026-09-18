using System;


class SinhVien
{
   // Thông tin sinh viên
   public string MaSinhVien;
   public string HoTen;
   public string DiaChi;
   public int NamThuMay;


   // Nhập thông tin sinh viên
   public void Nhap()
   {
       Console.WriteLine("Nhap day du thong tin: ");
       Console.Write("Ma sinh vien: ");
       MaSinhVien = Console.ReadLine();
       Console.Write("Ho ten: ");
       HoTen = Console.ReadLine();
       Console.Write("Dia chi: ");
       DiaChi = Console.ReadLine();
       Console.Write("Sinh vien nam thu may: ");
       NamThuMay = int.Parse(Console.ReadLine());
   }


   // Xuat thong tin sinh vien.
   public void Xuat()
   {
       Console.WriteLine("Thong tin sinh vien la: ");
       Console.WriteLine("Ma sinh vien: " + MaSinhVien);
       Console.WriteLine("Ho ten: " + HoTen);
       Console.WriteLine("Dia chi: " + DiaChi);
       Console.WriteLine("Sinh vien nam thu: " + NamThuMay);
   }
}


class TinhToan
{
   static void Main()
   {
       SinhVien sv = new SinhVien();
       sv.Nhap();
       Console.WriteLine("\n--- THONG TIN SINH VIEN ---");
       sv.Xuat();
   }
}
