using System;

class Bai5{
    static void Main(){
        //Menu
        Console.WriteLine("menu");
        Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
        Console.WriteLine("2. Tinh x^y");
        Console.WriteLine("3. Tinh can bac 2 cua x va y");
        Console.WriteLine("4. Thoat");
        Console.WriteLine("Chon: ");
        
        string LuaChon = Console.ReadLine();

        switch (LuaChon){
            case "1":
            //nhap 2 so thuc
             Console.Write("Nhap x");
             double x = double.Parse(Console.ReadLine());
             Console.Write("Nhap x");
             double y = double.Parse(Console.ReadLine());
             Console.WriteLine("Da nhap x = " + x + ", y = " + y);
                break;

            case "2":
            // Tinh x^y 
            Console.Write("Nhap x: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("x^y = " + Math.Pow(a, b));
                break;
            
             case "3":
                // Tinh can bac hai.
                Console.Write("Nhap x: ");
                double c = double.Parse(Console.ReadLine());
                Console.Write("Nhap y: ");
                double d = double.Parse(Console.ReadLine());
                if (c < 0 || d < 0)
                    Console.WriteLine("Khong the tinh can bac hai so am.");
                else
                {
                    Console.WriteLine("Can bac 2 cua x = " + Math.Sqrt(c));
                    Console.WriteLine("Can bac 2 cua y = " + Math.Sqrt(d));
                }
                break;

            case "4":
            //thoat
                Console.WriteLine("Thoat chuong trinh.");
                break;

            default:
                Console.WriteLine("Lua chon khong hop le!");
                break;


                
        }
        

        
    }
}