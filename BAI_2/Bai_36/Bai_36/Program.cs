using System;

namespace Bai_36
{
    class Program
    {
        //Viết chương trình in ra nsố nguyên tố đầu tiên (nnhập từ bàn phím).
        static void Main(string[] args)
        {
            int n_258, k_258 = 2, count;

            Console.Write("Moi nhap n: ");
            n_258 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cac so nguyen to la:");
            for (int i = 1; i <= n_258;)
            {
                count = 0;
                for (int j = 2; j <= Math.Sqrt(k_258); j++)
                {
                    if (k_258 % j == 0)
                    {
                        count++;

                    }
                }

                if (count == 0)
                {
                    Console.Write(" " + k_258);
                    i++;
                }
                k_258++;
            }
            Console.ReadKey();
        }
    }
}
