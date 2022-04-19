using System;

namespace Bai_7
{
    class Program
    {
        //Giải phương trình bậc nhất ax + b = 0
        static void Main(string[] args)
        {
            Double a_258, b_258;
            Console.Write("Moi ban nhap a: ");
            a_258 = double.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap b: ");
            b_258 = double.Parse(Console.ReadLine());
            Console.WriteLine("**************************************");
            if (a_258 == 0)
            {
                if (b_258 != 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else
                    Console.WriteLine("Phuong trinh vo so nghiem");
            }
            else
                Console.WriteLine("Phuong trinh co nghiem x = " + (-b_258) / a_258);
            Console.ReadKey();
        }
    }
}
