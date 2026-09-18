using System;

class SoNguyen {
    static void Main(){
        Console.Write("Nhap so nguyen x: ");
        if (!int.TryParse(Console.ReadLine(), out int x)){
            Console.WriteLine("x khong phai la so nguyen !!");
            Console.WriteLine("Vui cong nhap dung so nguyen !!!");
            return;
        }

        Console.Write("Nhap so nguyen y: ");
        if (!int.TryParse(Console.ReadLine(), out int y)){
            Console.WriteLine("y khong phai la so nguyen !!");
            Console.WriteLine("Vui cong nhap dung so nguyen !!!");
            return;
        }

        //tính mũ
        int KetQua = 1;
        for (int i = 1; i <= y ; i++){
            KetQua *= x;
        }
        Console.WriteLine("Ket qua " + x + " mu " + y + "la: "+KetQua);


        
    }
}