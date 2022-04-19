using System;

namespace Bai_Kiemtra_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cau_58;
            Console.WriteLine("Cau 1: Viet phuong thuc in ra tong, hieu, tich, thuong cua hai so cho truoc");
            Console.WriteLine("Cau 2: Viet phunog thuc in ra la co viet nam bang cac dau = va *");
            Console.WriteLine("Cau 3: Viet phuong thuc doi so thap phan thanh so nhi phan");
            Console.WriteLine("Cau 4: Viet phuong thuc in ra cac thong tin cua ban than(ho, ten, lop, masv)");
            Console.WriteLine("******************************************* ");
            Console.Write("Moi nhap cau muon chay:");
            cau_58 = int.Parse(Console.ReadLine());
            switch (cau_58)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Cau 1: Viet phuong thuc in ra tong, hieu, tich, thuong cua hai so cho truoc");
                    Console.WriteLine("******************************************* ");
                    float a_58, b_58;
                    Console.Write("Moi nhap so thu nhat: ");
                    a_58 = float.Parse(Console.ReadLine());
                    Console.Write("Moi nhap so thu hai: ");
                    b_58 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Tong a+b la: " + (a_58 + b_58));
                    Console.WriteLine("Hieu a-b la: " + (a_58 - b_58));
                    Console.WriteLine("Tich a*b la: " + (a_58 * b_58));
                    Console.WriteLine("Thuong a/b la: " + Math.Round((a_58 / b_58), 2));
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Cau 2: Viet phuong thuc in ra la co viet nam bang cac dau = va *");
                    Console.WriteLine("******************************************* ");
                    int dai_58 = 20;
                    int rong_58 = 50;
                    char vien_58 = '=';
                    char hinhtrong_58 = '*';
                    int countDoc_58 = 0;
                    int countRong_58 = 0;
                    do
                    {
                        countRong_58 = 0;
                        do
                        {
                            if (countDoc_58 % (dai_58 - 1) == 0 || ((countDoc_58 % (dai_58 - 1) != 0) && (countRong_58 % (rong_58 - 1) == 0)))
                            {
                                Console.Write(vien_58);
                            }
                            else
                            {
                                Console.Write(hinhtrong_58);
                            }
                            countRong_58++;
                        } while (countRong_58 < rong_58);

                        Console.WriteLine();

                        countDoc_58++;
                    } while (countDoc_58 < dai_58);
                    Console.ReadKey();

                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Cau 3: Viet phuong thuc doi so thap phan thanh so nhi phan");
                    Console.WriteLine("******************************************* ");
                    int thapphan_58, i;
                    String trunggian_58 = string.Empty;
                    Console.Write("Nhap vao so can chuyen doi:");
                    thapphan_58 = int.Parse(Console.ReadLine());
                    for (i = 0; thapphan_58 > 0; i++)
                    {
                        trunggian_58 = thapphan_58 % 2 + trunggian_58;
                        thapphan_58 = thapphan_58 / 2;
                    }
                    Console.WriteLine("So thap phan sau khi chuyen la: " + trunggian_58);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Cau 4: Viet phuong thuc in ra cac thong tin cua ban than(ho, ten, lop, masv)");
                    Console.WriteLine("******************************************* ");
                    String hoten_58, lop_58, masv_58;
                    Console.Write("Moi nhap ho va ten: ");
                    hoten_58 = Console.ReadLine();
                    Console.Write("Moi nhap lop: ");
                    lop_58 = Console.ReadLine();
                    Console.Write("Moi nhap ma sinh vien: ");
                    masv_58 = Console.ReadLine();
                    Console.WriteLine("******************************************* ");
                    Console.WriteLine("Ho va ten: " + hoten_58);
                    Console.WriteLine("Lop hoc phan: " + lop_58);
                    Console.WriteLine("Ma sinh vien: " + masv_58);
                    break;
                default:
                    Console.WriteLine("Nhap khong hop le!!!");
                    break;

            }
            Console.ReadKey();
        }
    }
}
