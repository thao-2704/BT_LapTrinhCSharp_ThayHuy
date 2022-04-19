using System;

namespace Bai_20
{
    class Program
    {
        //Viết chương trình nhậpsốkW điện đã tiêu thụ. Tính tiền điện phải trả, biết rằng khung giá điện như sau:
        // 0kw-500đ ; 100kw-800đ ;  250kw-1000đ ; 350kw-1500đ
        static void Main(string[] args)
        {
            double soKw_258, tongtien_258;
            Console.Write("Moi nhap so kW dien: ");
            soKw_258 = Convert.ToDouble(Console.ReadLine());

            if (soKw_258 < 100)
            {
                tongtien_258 = soKw_258 * 500;
            }
            else
            {
                if (soKw_258 < 250)
                {
                    tongtien_258 = 100 * 500 + (soKw_258 - 100) * 800;
                }
                else
                {
                    if (soKw_258 < 350)
                    {
                        tongtien_258 = 100 * 500 + 150 * 800 + (soKw_258 - 250) * 1000;
                    }
                    else
                    {
                        tongtien_258 = 100 * 500 + 150 * 800 + 100 * 1000 + (soKw_258 - 350) * 1500;
                    }
                }
            }
            Console.WriteLine("Chi phi can phai tra la: " + tongtien_258);
            Console.ReadKey();
        }
    }
}
