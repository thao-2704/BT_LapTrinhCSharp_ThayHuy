using System;

namespace Bai58_70
{
    class Program
    {
        static void Bai_58()
        {

            int i, j, n_258, dem_258;
            Console.Write("Moi nhap n so can in ra: ");
            n_258 = int.Parse(Console.ReadLine());
            for (i = 1; i < n_258; i++)
            {
                dem_258 = 0;
                for (j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        dem_258++;
                    }
                }
                if (dem_258 == 0 && i > 1)
                {
                    Console.Write("{0 } ", i);
                }
            }

        }
        static void Bai_59()
        {
            int n_258;
            String[] can = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
            String[] chi = { "Than", "Dau", "Tuat", "Hoi", "Ti", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui" };
            Console.Write("Moi nhap nam: ");
            n_258 = int.Parse(Console.ReadLine());
            Console.WriteLine("***********************************");
            Console.WriteLine("{0} - {1} {2}", n_258, can[n_258 % 10], chi[n_258 % 12]);
            Console.WriteLine("{0} - {1} {2}", n_258 + 60, can[n_258 % 10], chi[n_258 % 12]);
        }
        static int[] nhap_mang(int min, int max)
        {
            int n;
            do
            {
                Console.Write("Nhap so phan tu mang (n > 0): ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            int[] a_258 = new int[n];
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                int x = rd.Next(min, max);
                a_258[i] = x;
            }
            return a_258;
        }
        static void xuat_mang(int[] a_258, int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine($"arr[{i}] = " + a_258[i]);
            }
        }
        static int sum_arr(int[] a_258)
        {
            int s_258 = 0;
            for (int i = 0; i < a_258.Length; i++)
            {
                if (a_258[i] > 0)
                {
                    s_258 += a_258[i];
                }
            }
            return s_258;
        }
        static int nhap_p(int n)
        {
            int p_258 = -1;
            do
            {
                try
                {
                    Console.Write("Nhap p tu ban phim (0 <= p <= {0}) : ", n - 1);
                    p_258 = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    p_258 = -1;
                }

            } while ((p_258 < 0 || p_258 >= n));
            return p_258;
        }
        static void Xoa_pt(int[] a_258, int p_258)
        {
            for (int i = p_258; i < a_258.Length - 1; i++)
            {
                a_258[i] = a_258[i + 1];
            }
        }
        static void Bai_61()
        {
            int[] a_258 = nhap_mang(-100, 100);
            xuat_mang(a_258, a_258.Length);
            Console.Write("\nTong phan tu nguyen duong : {0} \n", sum_arr(a_258));
            int p_258 = nhap_p(a_258.Length);
            Console.WriteLine("Mang sau khi xoa la: ");
            Xoa_pt(a_258, p_258);
            xuat_mang(a_258, a_258.Length - 1);
        }
        static int tongsole(int[] a_258)
        {
            int dem_258 = 0;
            for (int i = 0; i < a_258.Length; i++)
            {
                if (a_258[i] % 4 == 0 && Math.Abs(a_258[i]) % 10 == 6)
                    dem_258++;
            }
            return dem_258;
        }
        static void nhandoi_ptle(int[] a_258)
        {
            for (int i = 0; i < a_258.Length; i++)
            {
                if (a_258[i] % 2 != 0)
                    a_258[i] *= 2;
            }
            Console.WriteLine("Mang sau khi duoc nhan doi phan tu le la:");
        }
        static void Bai_63()
        {
            int[] a_258 = nhap_mang(-100, 100);
            xuat_mang(a_258, a_258.Length);
            Console.WriteLine("Cac so chia het cho 4 va co chu so tan cung 6 la: {0}", tongsole(a_258));
            nhandoi_ptle(a_258);
            xuat_mang(a_258, a_258.Length);
        }
        static void kt_tong(int[] a_258)
        {
            int s1 = 0, s2 = 0;
            for (int i = 0; i < a_258.Length; i++)
            {
                //tong le o vi tri chan
                if (i % 2 == 0 && a_258[i] % 2 != 0)
                {
                    s1 += a_258[i];
                }
                //tong chan o vi tri le
                if (i % 2 != 0 && a_258[i] % 2 == 0)
                {
                    s2 += a_258[i];
                }
            }
            Console.Write($"Tong le vi tri chan ({s1}) va tong chan o vi tri le ({s2}) ");
            if (s1 == s2)
            {
                Console.WriteLine("bang nhau");
            }
            else
            {
                Console.WriteLine("khong bang nhau");
            }
        }
        static int uc(int a_258, int b_258)
        {
            while (a_258 != b_258)
            {
                if (a_258 > b_258)
                {
                    a_258 -= b_258;
                }
                else
                {
                    b_258 -= a_258;
                }
            }
            return a_258;
        }
        static void kt_ntcungnhau(int[] a_258)
        {
            Console.WriteLine("Cac cap nguyen to cung nhau :");
            for (int i = 0; i < a_258.Length - 1; ++i)
            {
                for (int j = i + 1; j < a_258.Length; ++j)
                    if (uc(a_258[i], a_258[j]) == 1)
                        Console.WriteLine($"({a_258[i]}, {a_258[j]})");
            }
        }
        static void Bai_62()
        {
            int[] a_258 = { 14, 14, 11, 16, 12 };
            //show values array
            xuat_mang(a_258, a_258.Length);
            //check sum 
            kt_tong(a_258);
            //check coprime
            kt_ntcungnhau(a_258);
        }
        static void Main(string[] args)
        {
            int bai_258;
            Console.WriteLine("1/ Bai 58: Viet chuong trinh in ra cac nguyen to nho hon so n cho truoc");
            Console.WriteLine("2/ Bai 59: Nhap nam duong lich, xuat ten nam am lich");
            Console.WriteLine("3/ Bai 61: Nhap mang ngau nhien, thuc hien tinh tong so nguyen duong va xoa phan tu");
            Console.WriteLine("4/ Bai 63: Nhap mang ngau nhien, dem phan tu chia het cho 4 va co chu so tan cung la 6, nhan doi phan tu le");
            Console.WriteLine("5/ Bai 62: Nhap mang ngau nhien, kiem tra nguyen to cung nhau,tong cac nguyen to o vi tri le co bang o vi tri chan khong");
            Console.WriteLine("**********************************");
            Console.Write("Moi chon so bai: ");
            bai_258 = int.Parse(Console.ReadLine());
            switch (bai_258)
            {
                case 1:
                    Console.Clear();
                    Bai_58();
                    break;
                case 2:
                    Console.Clear();
                    Bai_59();
                    break;
                case 3:
                    Console.Clear();
                    Bai_61();
                    break;
                case 4:
                    Console.Clear();
                    Bai_63();
                    break;
                case 5:
                    Console.Clear();
                    Bai_62();
                    break;
            }
            Console.ReadKey();
        }
    }
}
