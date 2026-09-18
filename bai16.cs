using System;


class TinhToan
{
   static void Main()
   {
       Console.Write("Nhap so luong nguoi n: ");
       int n = int.Parse(Console.ReadLine());
       if (n <= 0) { Console.WriteLine("n phai > 0."); return; }


       string[] hoTen = new string[n];


       // Nhập tên
       for (int i = 0; i < n; i++)
       {
           Console.Write("Ho ten [" + i + "]: ");
           hoTen[i] = Console.ReadLine();
       }


       // Sắp xếp mảng lớn dần
       for (int i = 0; i < n - 1; i++)
           for (int j = i + 1; j < n; j++)
               if (string.Compare(hoTen[i], hoTen[j], StringComparison.CurrentCultureIgnoreCase) > 0)
               {
                   string temp = hoTen[i];
                   hoTen[i] = hoTen[j];
                   hoTen[j] = temp;
               }


       Console.WriteLine("\n--- DANH SACH SAU KHI SAP XEP ---");
       for (int i = 0; i < n; i++)
           Console.WriteLine(hoTen[i]);
   }
}
