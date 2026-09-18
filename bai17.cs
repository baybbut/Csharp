using System;

class Mang
{
    // Tạo mảng
    public int[,] TaoMang(int n, int m)
    {
        int[,] a = new int[n, m];
        Random random = new Random();
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                a[i, j] = random.Next(10, 101);
        return a;
    }

    // in mảng 2 chiều
    public void InMang(int[,] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
                Console.Write(a[i, j] + "\t");
            Console.WriteLine();
        }
    }

    // in số chẵn
    public void InSoChan(int[,] a)
    {
        Console.Write("Mang so chan: ");
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
                if (a[i, j] % 2 == 0) Console.Write(a[i, j] + " ");
        Console.WriteLine();
    }

    // in số lẻ
    public void InSoLe(int[,] a)
    {
        Console.Write("Mang so le: ");
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
                if (a[i, j] % 2 != 0) Console.Write(a[i, j] + " ");
        Console.WriteLine();
    }
}

class TinhToan
{
    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Nhap m: ");
        int m = int.Parse(Console.ReadLine());
        if (n <= 0 || m <= 0) { Console.WriteLine("n va m phai > 0."); return; }

        Mang xuLy = new Mang();
        int[,] a = xuLy.TaoMang(n, m);
        Console.WriteLine("\n--- MANG NGAU NHIEN ---");
        xuLy.InMang(a);
        xuLy.InSoChan(a);
        xuLy.InSoLe(a);
    }
}
