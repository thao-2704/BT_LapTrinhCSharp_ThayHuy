using System;

namespace Bai_12
{
    class Program
    {
        //Viết chương trình giải hệ phương trình hai ẩn
        static void Main(string[] args)
        {
            float a1_258, b1_258, c1_258, a2_258, b2_258, c2_258;
            float x_258, y_258, D_258, Dx_258, Dy_258;
            Console.Write("Moi nhap he so a1: ");
            a1_258 = float.Parse(Console.ReadLine());
            Console.Write("Moi nhap he so b1: ");
            b1_258 = float.Parse(Console.ReadLine());
            Console.Write("Moi nhap he so c1: ");
            c1_258 = float.Parse(Console.ReadLine());
            Console.Write("Moi nhap he so a2: ");
            a2_258 = float.Parse(Console.ReadLine());
            Console.Write("Moi nhap he so b2: ");
            b2_258 = float.Parse(Console.ReadLine());
            Console.Write("Moi nhap he so c2: ");
            c2_258 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ta co he phuong trinh:");
            Console.WriteLine("            {0}*x + {1} = {2}", a1_258, b1_258, c1_258);
            Console.WriteLine("            {0}*x + {1} = {2}", a2_258, b2_258, c2_258);

            D_258 = a1_258 * b2_258 - a2_258 * b1_258;
            Dx_258 = c1_258 * b2_258 - c2_258 * b1_258;
            Dy_258 = a1_258 * c2_258 - a2_258 * c1_258;
            if (D_258 == 0)
            {
                if (Dx_258 + Dy_258 == 0)
                    Console.WriteLine("He phuong trinh co vo so nghiem");
                else
                    Console.WriteLine("He phuong trinh vo nghiem");
            }
            else
            {
                x_258 = Dx_258 / D_258;
                y_258 = Dy_258 / D_258;
                Console.WriteLine("He phuong trinh co nghiem (x, y) = ({0}, {1})", x_258, y_258);
            }
        }
    }
}
