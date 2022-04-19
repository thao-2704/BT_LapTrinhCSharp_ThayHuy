using System;

namespace Bai_6
{
    class Program
    {
        //Nhập vào ba số nguyên, in ra màn hình theo thứ tự tăng dần, chỉ dùng một biến phụ
        static void Main(string[] args)
        {
            int a_258, b_258, c_258, tg_258;
            Console.Write("Moi nhap so thu nhat: ");
            a_258 = int.Parse(Console.ReadLine());
            Console.Write("Moi nhap so thu hai: ");
            b_258 = int.Parse(Console.ReadLine());
            Console.Write("Moi nhap so thu ba: ");
            c_258 = int.Parse(Console.ReadLine());
            Console.WriteLine("***********************************");
            if (a_258 < b_258)
            {
                tg_258 = a_258;
                a_258 = b_258;
                b_258 = tg_258;
            }
            if (a_258 < c_258)
            {
                tg_258 = a_258;
                a_258 = c_258;
                c_258 = tg_258;
            }
            if (b_258 < c_258)
            {
                tg_258 = b_258;
                b_258 = c_258;
                c_258 = tg_258;
            }
            Console.WriteLine("Cac so theo thu tu tang dan la: {0} < {1} < {2}", c_258, b_258, a_258);
        }
    }
}
