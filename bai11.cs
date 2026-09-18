using System;


class Chuoi
{
  
   public int DoDai(string s)
   {
       return s.Length;
   }
}


class TinhToan
{
   static void Main()
   {
       Console.Write("Nhap chuoi: ");
       string s = Console.ReadLine();
       Chuoi xuLy = new Chuoi();
       Console.WriteLine("Do dai chuoi = " + xuLy.DoDai(s));
   }
}
