using System;

namespace BaiDiemDanh_26_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a_258, b_258, c_258;

            Console.WriteLine(" Moi nhap a,b,c ");
            a_258 = double.Parse(Console.ReadLine());
            b_258 = double.Parse(Console.ReadLine());
            c_258 = double.Parse(Console.ReadLine());

            giai_pt_bac2 giai_pt_258 = new giai_pt_bac2();
            giai_pt_258.nghiem_PT(a_258,b_258,c_258);

            Console.ReadKey();
        }
    }
}
