using System;

namespace Bai_31
{
    class Program
    {
        //Viết chương trình in bảng cửu chương từ 2cđến 9 ra màn hình.
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("=== IN BANG CUU CHUONG ===");
            for (i = 1; i <= 10; i++)
            {
                for (j = 2; j <= 9; j++)
                {
                    Console.Write("| {0} x {1} = {2}\t", j, i, (i * j));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
