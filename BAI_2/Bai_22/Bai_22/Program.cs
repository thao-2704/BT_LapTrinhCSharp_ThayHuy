using System;

namespace Bai_22
{
    class Program
    {
        //Viết chương trình liệt kê, đếm và tính tổng các ước số của số nguyên dương n(nnhập từ bàn phím).
        static void Main(string[] args)
        {
            int n_258, sum_258 = 0, count_258 = 0, i;
            Console.Write("Moi ban nhap so can thuc hien: ");
            n_258 = int.Parse(Console.ReadLine());
            if (n_258 <= 0)
            {
                Console.WriteLine("So vua nhap khong hop le!!!");
            }
            else
            {
                Console.WriteLine("***********************************");
                Console.Write("Cac uoc so cua so vua nhap la: ", n_258);
                for (i = 1; i <= n_258; i++)
                {
                    if (n_258 % i == 0)
                        Console.Write(" " + i);
                    count_258++;
                    sum_258 += i;
                }
                Console.WriteLine();
                Console.WriteLine("So vua nhap co {0} uoc so", count_258);
                Console.WriteLine("Tong cac uoc so la: " + sum_258);
            }
            Console.ReadKey();
        }
    }
}
