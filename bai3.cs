using System;

class SoNguyen {
    static void Main(){
        Console.Write("Nhap so nguyen x: ");
       if (!int.TryParse(Console.ReadLine(), out int x) ){
            Console.WriteLine("x khong phai so nguyen !!");
            return;
        }
        
        
        Console.Write("Nhap so nguyen y: ");
        if (!int.TryParse(Console.ReadLine(), out int y) ){
            Console.WriteLine("y khong phai so nguyen !!");
            Console.WriteLine("Vui long nhap dung so nguyen !!!");
            return;

        }
        
        //Tính mũ
        int KetQua = 1;
        for (int i = 1; i<=y ; i++){
            KetQua *= x;

           
        } 
        
        Console.WriteLine("Ket qua " + x +" mu " + y + " la: "+KetQua);
    }
    
}