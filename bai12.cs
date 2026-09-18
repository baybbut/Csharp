using System;


class Chuoi
{
 
   public void XuLy(string s, out string chuThuong, out string chuHoa, out int soTu)
   {
       s = s.Trim();
       chuThuong = s.ToLower();
       chuHoa = s.ToUpper();
       if (s.Length == 0)
           soTu = 0;
       else
           soTu = s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
   }
}


class TinhToan
{
   static void Main()
   {
       Console.Write("Nhap chuoi nhieu tu: ");
       string s = Console.ReadLine();
       Chuoi xuLy = new Chuoi();
       xuLy.XuLy(s, out string thuong, out string hoa, out int soTu);
       Console.WriteLine("Chu thuong la: " + thuong);
       Console.WriteLine("Chu hoa la: " + hoa);
       Console.WriteLine("So tu trong chuoi la: " + soTu);
   }
}


