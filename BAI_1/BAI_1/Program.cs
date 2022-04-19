using System;

namespace BAITAP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Cau 1: Viet chuong trinh nhap vao so nguyen va kiem tra so do duong hay am");
            Console.WriteLine("Cau 2: Viet chuong trinh cho phep nhap mot so va so do duoc in ra bang chu");
            Console.WriteLine("Cau 3: Viet chuong trinh nhap vao 3 canh va kiem tra 3 canh co tao thanh tam giac khong?");
            Console.WriteLine("Cau 4: Viet chuong trinh nhap vao 3 canh va kiem tra 3 canh co tao thanh tam giac vuong khong?");
            Console.WriteLine("*******************************");
            Console.Write("Moi nhap cau muon hien thi(tu 1-4): ");
            int cau_258 = int.Parse(Console.ReadLine());
            Console.WriteLine("*******************************");
            switch (cau_258)
            {
                case 1:
                    {
                        Console.Clear();
                        int a_258;
                        Console.WriteLine("Cau 1: Viet chuong trinh nhap vao so nguyen va kiem tra so do duong hay am");
                        Console.Write("Moi ban nhap so: ");
                        a_258 = int.Parse(Console.ReadLine());
                        if (a_258 > 0)
                        {
                            Console.WriteLine(a_258 + " la so nguyen duong");

                        }
                        else
                        {
                            if (a_258 == 0)
                                Console.WriteLine(a_258 + " la so khong ");
                            else
                                Console.WriteLine(a_258 + " la so nguyen am");
                        }
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    {
                        Console.Clear();
                        int a_258;
                        Console.WriteLine("Cau 2: Viet chuong trinh cho phep nhap mot so va so do duoc in ra bang chu");
                        Console.WriteLine("Moi ban nhap so can in: ");
                        a_258 = int.Parse(Console.ReadLine());

                        Console.WriteLine("**************************************");
                        if (a_258 == 0)
                            Console.WriteLine("Khong");
                        else if (a_258 == 1)
                            Console.WriteLine("Mot");
                        else if (a_258 == 2)
                            Console.WriteLine("Hai");
                        else if (a_258 == 3)
                            Console.WriteLine("Ba");
                        else if (a_258 == 4)
                            Console.WriteLine("Bon");
                        else if (a_258 == 5)
                            Console.WriteLine("Nam");
                        else if (a_258 == 6)
                            Console.WriteLine("Sau");
                        else if (a_258 == 7)
                            Console.WriteLine("Bay");
                        else if (a_258 == 8)
                            Console.WriteLine("Tam");
                        else if (a_258 == 9)
                            Console.WriteLine("Chin");
                        else
                            Console.WriteLine("Nhap so khong hop le!!!");
                        Console.ReadKey();
                    }
                    break;
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("Cau 3: Viet chuong trinh nhap vao 3 canh va kiem tra 3 canh co tao thanh tam giac khong?");
                        float a_258, b_258, c_258;
                        Console.Write("Moi nhap so thu nhat: ");
                        a_258 = float.Parse(Console.ReadLine());

                        Console.Write("Moi nhap so thu hai: ");
                        b_258 = float.Parse(Console.ReadLine());

                        Console.Write("Moi nhap so thu ba: ");
                        c_258 = float.Parse(Console.ReadLine());
                        Console.WriteLine("***********************************");
                        if ((a_258 < b_258 + c_258) && (b_258 < a_258 + c_258) && (c_258 < b_258 + a_258))
                        {
                            Console.WriteLine("La ba canh cua mot tam giac");
                        }
                        else
                        {
                            Console.WriteLine("Khong phai la ba canh cua mot tam giac");
                        }
                        Console.ReadKey();
                    }
                    break;
                case 4:
                    {
                        Console.Clear();
                        Console.WriteLine("Cau 4: Viet chuong trinh nhap vao 3 canh va kiem tra 3 canh co tao thanh tam giac vuong khong?");
                        float a_258, b_258, c_258;
                        Console.Write("Moi nhap so thu nhat: ");
                        a_258 = float.Parse(Console.ReadLine());

                        Console.Write("Moi nhap so thu hai: ");
                        b_258 = float.Parse(Console.ReadLine());

                        Console.Write("Moi nhap so thu ba: ");
                        c_258 = float.Parse(Console.ReadLine());
                        Console.WriteLine("***********************************");
                        if ((a_258 < b_258 + c_258) && (b_258 < a_258 + c_258) && (c_258 < b_258 + a_258))
                        {
                            if ((a_258 * a_258 == b_258 * b_258 + c_258 * c_258)
                                && (b_258 * b_258 == a_258 * a_258 + c_258 * c_258)
                                && (c_258 * c_258 == a_258 * a_258 + b_258 * b_258))
                            {
                                Console.WriteLine("La ba canh cua mot tam giac vuong ");
                            }
                            else
                            {
                                Console.WriteLine("La ba canh cua mot tam giac thuong ");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Khong phai la ba canh cua mot tam giac");
                        }
                        Console.ReadKey();
                    }
                    break;
                default:
                    Console.WriteLine("Nhap khong hop le!!!");
                    break;
            }
        }
    }
}
