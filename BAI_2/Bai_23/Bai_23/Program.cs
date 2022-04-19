using System;

namespace Bai_23
{
    class Program
    {
        //Viết chương trình tìm các số hoàn hảo (perfect number) nhỏ hơn một số nguyên dương n cho trước.
        static void Main(string[] args)
        {
            int n_258, i, j, sum_258;

            Console.Write("Nhap vao so n: ");
            n_258 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***********************************");
            Console.Write("Cac so hoan hao nho hon so vua nhap la: ");
            for (i = 1; i < n_258; i++)
            {
                sum_258 = 0;
                for (j = 1; sum_258 <= i && j < i; ++j)
                {
                    if (i % j == 0)
                    {
                        sum_258 += j;
                    }
                }
                if (sum_258 == i)
                {
                    Console.Write(" " + i);
                }
            }
        }
    }
}
