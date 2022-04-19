using System;

namespace Bai_13
{
    class Program
    {
        //Viết chương trình nhập vào ngày tháng năm. Kiểm tra hợp lệ và tính thứ trong tuần của ngày đó
        static void Main(string[] args)
        {
            int ngay_258, thang_258, nam_258, ngaycuatuan_258, ngaytoida_258;
            Console.Write("Moi ban nhap ngay: ");
            ngay_258 = int.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap thang: ");
            thang_258 = int.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap nam: ");
            nam_258 = int.Parse(Console.ReadLine());
            Console.WriteLine("*************************************");
            if (nam_258 < 0 && thang_258 < 0 && ngay_258 < 0)
                Console.WriteLine("Ngay thang nam khong hop le!!!");
            if (thang_258 < 1 || thang_258 > 12)
                Console.WriteLine("Nhap khong hop le!!!");
            else
            {
                switch (thang_258)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        ngaytoida_258 = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        ngaytoida_258 = 30;
                        break;
                    case 2:
                        if ((nam_258 % 4 == 0 && nam_258 % 100 != 0) || nam_258 % 400 == 0)
                            ngaytoida_258 = 29;
                        else
                            ngaytoida_258 = 28;
                        break;
                    default:
                        ngaytoida_258 = 0;
                        break;
                }
                if (ngay_258 > ngaytoida_258 || ngay_258 < 1)
                    Console.WriteLine("Ngay khong hop le!!!");
                else
                {

                    nam_258 -= (14 - thang_258) / 12;
                    thang_258 += 12 * ((14 - thang_258) / 12) - 2;
                    ngaycuatuan_258 = (ngay_258 + nam_258 + nam_258 / 4 - nam_258 / 100 + nam_258 / 400 + (31 * thang_258) / 12) % 7;
                    if (ngaycuatuan_258 == 0)
                        Console.WriteLine("Chu Nhat\n");
                    else
                        Console.WriteLine("Thu {0}", ngaycuatuan_258 + 1);
                }
            }
            Console.ReadKey();
        }
    }
}
