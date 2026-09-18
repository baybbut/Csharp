using System;


class XuLy
{
   // ref cho phep thay doi truc tiep hai bien ban dau.
   public void HoanVi(ref double a, ref double b)
   {
       double temp = a;
       a = b;
       b = temp;
   }
}


class TinhToan
{
   static void Main()
   {
       Console.Write("Nhap a: ");
       double a = double.Parse(Console.ReadLine());
       Console.Write("Nhap b: ");
       double b = double.Parse(Console.ReadLine());


       Console.WriteLine("Truoc khi hoan vi: a = " + a + ", b = " + b);
       XuLy xuLy = new XuLy();
       xuLy.HoanVi(ref a, ref b);
       Console.WriteLine("Sau khi hoan vi: a = " + a + ", b = " + b);
   }
}


