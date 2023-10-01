using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    internal class Program
    {
        static void TestSinhVien()
        {
            SinhVien svA = new SinhVien();
            svA.Nhap();
            Console.WriteLine("Thong tin svA: ");
            Console.WriteLine("----------------");
            svA.Xuat();

            Console.WriteLine("----------------");
            SinhVien svB = new SinhVien("18DH001", "Lam Thanh Ngoc", "CNPM", 2000, 7.6F);
            svB.Xuat();

            Console.WriteLine("----------------");
            SinhVien svC = new SinhVien("18DH002", "Nguyen Van A", "CNPM", 2001, 9F);
            svC.Xuat();
        }

        static void MangSinhVien()
        {
            MangSinhVien dssv = new MangSinhVien();
            dssv.Nhap();
            Console.WriteLine("Danh sach sinh vien: ");
            dssv.Xuat();
            Console.WriteLine("Danh sach sinh vien sau khi duoc sap xep theo ten: ");
            dssv.SapXepHoTen();
            dssv.Xuat();

        }
        static void Main(string[] args)
        {
            //TestSinhVien();
            MangSinhVien();
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
