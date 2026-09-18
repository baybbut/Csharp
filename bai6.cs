using System;


class ReturnGiaTri
{
   public int TimMax(int a, int b, int c)
   {
       int max = a;
       if (b > max) max = b;
       if (c > max) max = c;
       return max;
   }
}


class Program
{
   static void Main()
   {
       Console.Write("Nhap a: ");
       int a = int.Parse(Console.ReadLine());
       Console.Write("Nhap b: ");
       int b = int.Parse(Console.ReadLine());
       Console.Write("Nhap c: ");
       int c = int.Parse(Console.ReadLine());


       ReturnGiaTri xuLy = new ReturnGiaTri();
       Console.WriteLine("Gia tri lon nhat = " + xuLy.TimMax(a, b, c));
   }
}
