using System;
using System.Collections.Generic;
using System.Text;

namespace BaiDiemDanh_26_4
{
    class giai_pt_bac2
    {
        private double a_258, b_258, c_258;
        public giai_pt_bac2()
        {

        }
        public double A_258
        {
            get { return a_258; }
            set { a_258 = value; }

        }
        public double B_258
        {
            get { return b_258; }
            set { b_258 = value; }

        }
        public double C_258
        {
            get { return c_258; }
            set { c_258 = value; }

        }
        public giai_pt_bac2(double a_258, double b_258, double c_258)
        {
            this.A_258 = a_258;
            this.B_258 = b_258;
            this.C_258 = c_258;
        }

        public double Delta(double a_258, double b_258, double c_258)
        {
            return (b_258 * b_258 - 4 * a_258 * c_258);
        }

        public void nghiem_PT(double a_258, double b_258, double c_258)
        {
            double delta_258 = Delta(a_258, b_258, c_258);
            if (a_258 == 0)
            {
                Console.WriteLine("Phuong trinh tro thanh bac nhat");
                Console.WriteLine("Co nghiem bang, x = {0}", -c_258 / b_258);
            }
            else
            {
                if (delta_258 < 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else if (delta_258 == 0)
                    Console.WriteLine("Phuong trinh co nghiem kep: x1 = x2 = {0}", -b_258 / (2 * a_258));
                else
                {
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet: ");
                    Console.WriteLine("x1 = {0}", (-b_258 + Math.Sqrt(delta_258) / (2 * a_258)));
                    Console.WriteLine("x2 = {0}", (-b_258 - Math.Sqrt(delta_258) / (2 * a_258)));
                }

            }
        }
    }
}
