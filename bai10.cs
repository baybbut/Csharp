using System;


class Chuoi
{
   // Kiem tra chuoi doc xuoi va nguoc co giong nhau khong.
   public bool LaChuoiDoiXung(string s)
   {
       int i = 0;
       int j = s.Length - 1;
       while (i < j)
       {
           if (s[i] != s[j]) return false;
           i++;
           j--;
       }
       return true;
   }
}


class TinhToan
{
   static void Main()
   {
       Console.Write("Nhap chuoi: ");
       string s = Console.ReadLine();
       Chuoi xuLy = new Chuoi();


       if (xuLy.LaChuoiDoiXung(s))
           Console.WriteLine("Chuoi doi xung.");
       else
           Console.WriteLine("Chuoi khong doi xung.");
   }
}
