using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class Program
    {
        static void TestConstructor1()
        {
            IntArray obj = new IntArray(20);
            Console.WriteLine("Gia tri mang phat sinh la: ");
            obj.Xuat();                       
        }

        static void TestConstructor2()
        {
            int[] a = { 4, 7, 9, 10, 20, 8, 3, 17, 10, 6 };
            IntArray obj = new IntArray(a);
            Console.WriteLine("Gia tri mang: ");
            obj.Xuat();
        }

        static void TestConstructor3()
        {
            IntArray obj1 = new IntArray();
            obj1.Nhap();
            Console.WriteLine("Gia tri mang copy: ");
            obj1.Xuat();
        }
        
        static void TestLinearSearch()
        {
            int k, x, kq;
            Console.Write("Nhap so luong phan tu trong mang: ");
            int.TryParse(Console.ReadLine(), out k);
            IntArray objA = new IntArray(k);
            Console.WriteLine("Cac phan tu: ");
            objA.Xuat();

            //Tìm x
            Console.Write("Gia tri can tim x = ");
            int.TryParse(Console.ReadLine(), out x);

            kq = objA.LinearSearch(x);
            if(kq == -1)
            {
                Console.WriteLine("Khong ton tai {0} !", x);
            }
            else
            {
                Console.WriteLine("Co {0} o vi tri thu {1}", x, kq);
            }
        }

        static void TestBinarySearch()
        {
            Console.Write("Nhap so luong phan tu trong mang: ");

            int t, x, kq;
            t = int.Parse(Console.ReadLine());
            IntArray objB = new IntArray(t);
            
            Console.WriteLine("Cac phan tu: ");
            objB.Nhap1();

            //Tìm x
            Console.Write("Gia tri can tim x = ");
            x = int.Parse(Console.ReadLine());

            kq = objB.BinarySearch(x);
            if (kq == -1)
            {
                Console.WriteLine("Khong ton tai {0} !", x);
            }
            else
            {
                Console.WriteLine("Co {0} o vi tri thu {1}", x, kq);
            }
        }
        static void Main(string[] args)
        {
            //TestConstructor1();
            //TestConstructor2();
            //TestConstructor3();

            //TestLinearSearch();
            TestBinarySearch();
            

            Console.ReadKey();
        }
    }
}
