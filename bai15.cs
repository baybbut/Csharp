using System;


class Mang
{
   // Nhập mảng
   public void NhapMang(int[] a)
   {
       for (int i = 0; i < a.Length; i++)
       {
           Console.Write("a[" + i + "] = ");
           a[i] = int.Parse(Console.ReadLine());
       }
   }


   // In mảng ra
   public void InMang(int[] a)
   {
       for (int i = 0; i < a.Length; i++)
           Console.Write(a[i] + " ");
       Console.WriteLine();
   }


   // Tìm phần tử max
   public int TimMax(int[] a)
   {
       int max = a[0];
       for (int i = 1; i < a.Length; i++)
           if (a[i] > max) max = a[i];
       return max;
   }


   // Tìm phần tử min.
   public int TimMin(int[] a)
   {
       int min = a[0];
       for (int i = 1; i < a.Length; i++)
           if (a[i] < min) min = a[i];
       return min;
   }


   // In số nguyên tố
   public void InSoNguyenTo(int[] a)
   {
       for (int i = 0; i < a.Length; i++)
           if (LaSoNguyenTo(a[i]))
               Console.Write(a[i] + " ");
       Console.WriteLine();
   }


   private bool LaSoNguyenTo(int n)
   {
       if (n < 2) return false;
       for (int i = 2; i * i <= n; i++)
           if (n % i == 0) return false;
       return true;
   }
}


class TinhToan
{
   static void Main()
   {
       Console.Write("Nhap so phan tu n: ");
       int n = int.Parse(Console.ReadLine());
       if (n <= 0) { Console.WriteLine("n phai > 0."); return; }


       int[] a = new int[n];
       Mang xuLy = new Mang();
       xuLy.NhapMang(a);
       Console.Write("Mang vua nhap la: ");
       xuLy.InMang(a);
       Console.WriteLine("Phan tu max: " + xuLy.TimMax(a));
       Console.WriteLine("Phan tu min: " + xuLy.TimMin(a));
       Console.Write("So nguyen to: ");
       xuLy.InSoNguyenTo(a);
   }
}
