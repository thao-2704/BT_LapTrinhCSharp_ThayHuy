using System;

namespace Bai_4
{
    class Program
    {
        //Nhập vào ba cạnh của tam giác, kiểm tra loại tam giác và tính diện tích
        static void Main(string[] args)
        {
            float a_258, b_258, c_258;
            Console.Write("Moi nhap so thu nhat: ");
            a_258 = float.Parse(Console.ReadLine());

            Console.Write("Moi nhap so thu hai: ");
            b_258 = float.Parse(Console.ReadLine());

            Console.Write("Moi nhap so thu ba: ");
            c_258 = float.Parse(Console.ReadLine());
            Console.WriteLine("***********************************");
            if (a_258 > 0 && b_258 > 0 && c_258 > 0)
            {
                if ((a_258 < b_258 + c_258) && (b_258 < a_258 + c_258) && (c_258 < b_258 + a_258))
                {
                    if ((a_258 * a_258 == b_258 * b_258 + c_258 * c_258)
                        || (b_258 * b_258 == a_258 * a_258 + c_258 * c_258)
                        || (c_258 * c_258 == a_258 * a_258 + b_258 * b_258))
                    {
                        Console.WriteLine("La ba canh cua mot tam giac vuong ");
                    }
                    else
                    {
                        if (a_258 == b_258 && b_258 == c_258)
                            Console.WriteLine("La ba canh cua tam giac deu");
                        else if (a_258 == b_258 || b_258 == c_258 || c_258 == a_258)
                        {
                            Console.WriteLine("La ba canh cua tam giac can");
                        }
                    }
                    float p_258;
                    p_258 = (a_258 + b_258 + c_258) / 2;
                    Console.WriteLine("Dien tich cua tam giac do la: " + Math.Sqrt(p_258 * (p_258 - a_258) * (p_258 - b_258) * (p_258 - c_258)));
                }
                else
                {
                    Console.WriteLine("Khong phai ba canh cua tam giac");
                }
            }
            else
            {
                Console.WriteLine("Khong phai la ba canh cua mot tam giac");
            }
            Console.ReadKey();
        }
    }
}
