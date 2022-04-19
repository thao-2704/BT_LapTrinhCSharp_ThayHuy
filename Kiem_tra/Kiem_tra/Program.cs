using System;

namespace Kiem_tra
{
    class Program
    {
        public struct Sinhvien
        {
            public int masv_258;
            public string name_258;
            public string class_258;
            public double diemtoan_258, diemvan_258, diemanh_258;
        }
        enum Xep_loai { Gioi, Kha, TrungBinh, Yeu }

        static void NhapThongTinSinhVien(out Sinhvien SV)
        {
            Console.Write(" Ma so: ");
            SV.masv_258 = int.Parse(Console.ReadLine());
            Console.Write(" Ho ten: ");
            SV.name_258 = Console.ReadLine();
            Console.Write(" Lop hoc: ");
            SV.class_258 = Console.ReadLine();
            Console.Write(" Diem toan: ");
            SV.diemtoan_258 = Double.Parse(Console.ReadLine());
            Console.Write(" Diem van: ");
            SV.diemvan_258 = Double.Parse(Console.ReadLine());
            Console.Write(" Diem anh: ");
            SV.diemanh_258 = Double.Parse(Console.ReadLine());
        }
        static double DiemTB_SV(Sinhvien SV)
        {
            return (SV.diemtoan_258 + SV.diemvan_258 + SV.diemanh_258) / 3;
        }
        static void XuatThongTinSinhVien(Sinhvien SV)
        {
            Console.WriteLine(" Ma so: " + SV.masv_258);
            Console.WriteLine(" Ho ten: " + SV.name_258);
            Console.WriteLine(" Lop hoc phan: " + SV.class_258);
            Console.WriteLine(" Diem toan: " + SV.diemtoan_258);
            Console.WriteLine(" Diem van: " + SV.diemvan_258);
            Console.WriteLine(" Diem anh: " + SV.diemanh_258);
            Console.WriteLine(" Diem trung binh: " + DiemTB_SV(SV));
        }
        static void Main(string[] args)
        {
            int n_258;
            string ten_258 = "";
            Console.Write("Moi nhap so sinh vien: ");
            n_258 = int.Parse(Console.ReadLine());
            Sinhvien[] sinhvien_258 = new Sinhvien[n_258];
            for (int i = 0; i < n_258; i++)
            {
                Console.WriteLine("Sinh vien thu {0} : ", i + 1);
                NhapThongTinSinhVien(out sinhvien_258[i]);

            }
            foreach (Sinhvien item in sinhvien_258)
            {
                Console.WriteLine("***********************************\n");
                XuatThongTinSinhVien(item);
                Console.WriteLine("***********************************\n");
            }
            Console.WriteLine("Nhap ten sinh vien can tim: ");
            ten_258 = Console.ReadLine();
            for (int i = 0; i < n_258; i++)
            {
                if (sinhvien_258[i].name_258.Equals(ten_258))
                {
                    Console.WriteLine("Diem trung binh: " + DiemTB_SV(sinhvien_258[i]));
                }
            }

            Console.ReadKey();
        }
    }
}
