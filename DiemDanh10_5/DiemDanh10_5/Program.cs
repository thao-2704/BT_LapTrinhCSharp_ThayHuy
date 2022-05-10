using System;

namespace DiemDanh10_5
{
    class Program
    {
        static void Nhap_mang(int[] a_258, int n)
        {  
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu  a[{0}]: ", i);
                a_258[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Xuat_mang(int[] a_258, int n)
        {
            Console.Write("Mang vua nhap: ");
            for( int i=0; i<n; i++)
            {
                Console.Write(a_258[i] + " ");
            }
        }
        static void Max_min(int[] a_258, int n)
        {
            Console.Write("-----------------------------------------------------------\n");
            Console.Write("\nTim phan tu lon nhat, phan tu nho nhat trong mang:\n");
            
            int i, max_258, min_258;
            max_258 = a_258[0];
            min_258 = a_258[0];

            for (i = 1; i < n; i++)
            {
                if (a_258[i] > max_258)
                {
                    max_258 = a_258[i];
                }


                if (a_258[i] < min_258)
                {
                    min_258 = a_258[i];
                }
            }
            Console.Write("Phan tu lon nhat trong mang la: {0}\n", max_258);
            Console.Write("Phan tu nho nhat trong mang la: {0}\n\n", min_258);
        }
        static void Sap_Xep(int[] a_258, int n)
        {
            int tg_258;
            for (int i = 0; i < n; i++)
            {
                for ( int j = i + 1; j < n; j++)
                {
                    if (a_258[j] < a_258[i])
                    {
                        //cach trao doi gia tri
                        tg_258 = a_258[i];
                        a_258[i] = a_258[j];
                        a_258[j] = tg_258;
                    }
                }
            }
            Console.Write("-----------------------------------------------------------\n");
            Console.Write("\nCac phan tu mang theo thu tu tang dan:\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a_258[i]);
            }

        }
        
        static void Main(string[] args)
        {
            int[] arr_258 = new int[100];
            int i, n;
            Console.Write("Nhap so phan tu : ");
            n = Convert.ToInt32(Console.ReadLine());
            Nhap_mang(arr_258,n);
            Xuat_mang(arr_258, n);
            Max_min(arr_258, n);
            Sap_Xep(arr_258, n);


            Console.ReadKey();
        }

    }
    
}
