using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class IntArray
    {
        //Thuộc tính
        private int[] arr;

        //Indexer
        public int this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        //Constructor
        public IntArray() { }
        public IntArray(int k) //Phát sinh mảng k ngẫu nhiên
        {
            arr = new int[k];
            Random r = new Random();
            for (int i = 0; i < k; i++)
            {
                arr[i] = r.Next(1, 200);
            }
        }
        public IntArray(int[] arr) 
        {
            this.arr = new int [arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                this.arr[i] = arr[i];
            }
        }
        public IntArray(IntArray obj) { }

        //Kiểm tra
        public bool KiemTraKT(int n )
        {
            if( n > 0 && n < 1000000 )
                return true;
            else
                return false;
        }
        public void Nhap()
        {
            //Nhập tổng số phần tử trong mảng
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());

            //Khai báo mảng
            arr = new int[n];

            //Nhập mảng
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}]= ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }           
        }

        //Luồng BinarySearch
        public void Nhap1()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}]: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Xuat()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();             
        }

        //Tìm kiếm tuần tự 
        public int LinearSearch(int x)
        {
            int n = arr.Length;
            for(int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        //Tìm kiếm nhị phân
        public int BinarySearch(int x)
        {
            int n = arr.Length;
            int left = 0;
            int right = n - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (x == arr[mid])
                    return mid;
                else if (x > arr[mid])
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
        
        //InterChangeSort
        public void InterChangSort()
        {          
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }                   
                }
            }
        }
        
        //BubbleSort
        public void BubbleSort()
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = 0; j <arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
        }
    }
}
