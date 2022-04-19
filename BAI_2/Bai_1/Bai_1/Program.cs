using System;

namespace Bai_1
{
    class Program
    {
        //Nhập vào diện tích S của một mặt cầu, tính thể tích V của mặt cầu đó
        static void Main(string[] args)
        {
            const Double p_258 = 3.14;
            Double s_258, v_258;
            Console.Write("Moi ban nhap dien tich: ");
            s_258 = Double.Parse(Console.ReadLine());
            Console.WriteLine("The tich cua hinh cau la: " + (4 / 3) * p_258 * Math.Pow((s_258 / 4 * p_258), 3));

        }
    }
}
