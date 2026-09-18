using System;


class PThuc
{
   // kiem tra
   public bool LaSoNguyenTo(int n)
   {
       if (n < 2) return false;
       for (int i = 2; i * i <= n; i++)
           if (n % i == 0) return false;
       return true;
   }
}


class Program
{
   static void Main()
   {
       Console.Write("Nhap n: ");
       int n = int.Parse(Console.ReadLine());
       PThuc kt = new PThuc();


       if (kt.LaSoNguyenTo(n))
           Console.WriteLine(n + " la so nguyen to.");
       else
           Console.WriteLine(n + " khong phai la so nguyen to.");
   }
}


