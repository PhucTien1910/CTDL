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

            int x, kq;           
            IntArray objB = new IntArray();
            
            //Console.WriteLine("Cac phan tu: ");
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
        static void TestInterChangeSort()
        {
            Console.Write("Nhap so luong phan tu trong mang(InterchangeSort): ");
            IntArray objC = new IntArray();
            objC.Nhap1();

            Console.WriteLine("Gia tri cua mang: ");
            objC.Xuat();

            Console.WriteLine("Mang sau khi duoc sap xep la: ");
            objC.InterChangeSort();
            objC.Xuat();
        }
        static void TestBubbleSort()
        {
            Console.Write("Nhap so luong phan tu trong mang(BubbleSort): ");
            IntArray objF = new IntArray();
            objF.Nhap1();

            Console.WriteLine("Gia tri cua mang: ");
            objF.Xuat();

            Console.WriteLine("Mang sau khi duoc sap xep la: ");
            objF.BubbleSort();
            objF.BubbleSort1();
            objF.Xuat();
        }
        static void TestSelectionSort()
        {
            Console.Write("Nhap so luong phan tu trong mang(SelectionSort): ");
            IntArray objD = new IntArray();
            objD.Nhap1();

            Console.WriteLine("Gia tri cua mang: ");
            objD.Xuat();

            Console.WriteLine("Mang sau khi duoc sap xep la: ");
            objD.SelectionSort();
            objD.Xuat();
        }
        static void TestInsertionSort()
        {
            Console.Write("Nhap so luong phan tu trong mang(InsertionSort): ");
            IntArray objE = new IntArray();
            objE.Nhap1();

            Console.WriteLine("Gia tri cua mang: ");
            objE.Xuat();

            Console.WriteLine("Mang sau khi duoc sap xep la: ");
            objE.InsertionSort();
            objE.Xuat();
        }
        static void TestQuickSort()
        {
            Console.Write("Nhap so luong phan tu trong mang(QuickSort): ");
            int t;
            t = int.Parse(Console.ReadLine());
            IntArray objF = new IntArray(t);

            Console.WriteLine("Cac phan tu: ");
            objF.Nhap2();

            Console.WriteLine("Gia tri mang la: ");
            objF.Xuat();

            Console.WriteLine("Gia tri mang sau khi sap xep la: ");
            objF.QuickSort(0, t - 1);
            objF.Xuat();
        }
        static void Main(string[] args)
        {
            //TestConstructor1();
            //TestConstructor2();
            //TestConstructor3();

            //TestLinearSearch();
            //TestBinarySearch();

            TestInterChangeSort();
            TestBubbleSort();
            TestSelectionSort();
            TestInsertionSort();
            TestQuickSort();
            Console.ReadKey();
        }
    }
}
