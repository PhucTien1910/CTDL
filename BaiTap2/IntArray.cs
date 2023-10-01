using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata;
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
            this.arr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                this.arr[i] = arr[i];
            }
        }
        public IntArray(IntArray obj) { }

        //Kiểm tra
        public bool KiemTraKT(int n)
        {
            if (n > 0 && n < 1000000)
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
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}]= ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
       
        public void Nhap1()
        {
            int t;
            t= int.Parse(Console.ReadLine());
            arr = new int[t];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}]: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        //Luồng QuickSort
        public void Nhap2()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}]: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Xuat()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        //Tìm kiếm tuần tự 
        public int LinearSearch(int x)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
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

        //Biến tạm
        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        //InterChangeSort
        public void InterChangeSort()
        {          
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }                   
                }
            }
        }

        //BubbleSort từ trái->phải
        public void BubbleSort()
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[i], ref arr[j + 1]);
                    }
                }
            }
        }

        //BubbleSort từ phải sang trái 
        public void BubbleSort1()
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] < arr[j-1])
                    {
                        Swap(ref arr[j], ref arr[j - 1]);
                    }
                }
            }
        }
        
        //SelectionSort
        public void SelectionSort()
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                int min_pos = i;
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min_pos])
                    {
                        min_pos = j;
                    }
                }
                Swap(ref arr[i], ref arr[min_pos]);
            }
        }

        //InsertionSort
        public void InsertionSort()
        {
            for(int i = 1; i < arr.Length; i++)
            {
                int x = arr[i];
                int pos = i - 1;
                while (pos >= 0 && x < arr[pos])
                {
                    arr[pos + 1] = arr[pos];
                    pos--;
                }
                arr[pos + 1] = x;
            }   
        }

        //QuickSort
        public int Partition(int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;
            for(int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    Swap(ref arr[j], ref arr[i]);
                }
            }            
            Swap(ref arr[i + 1], ref arr[right]);
            return i + 1;
        }
        public void QuickSort(int left, int right)
        {
            if(left < right)
            {
                int q = Partition(left, right);
                QuickSort(left, q - 1);
                QuickSort(q + 1, right);
            }
        }
    }
}
