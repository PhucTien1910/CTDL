using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    internal class MangSinhVien
    {
        //Thuộc tính 
        private SinhVien[] a;

        //Constructor
        public MangSinhVien() { }
        
        //Nhập
        public void Nhap()
        {
            Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());
            a = new SinhVien[n];
          
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Nhap thong tin cho sinh vien thu {i + 1}: ");
                SinhVien sv = new SinhVien();
                sv.Nhap();
                a[i] = sv;

                //string msx;
                //msx = Console.ReadLine();
                //int vt;
                //vt = int.Parse(Console.ReadLine());
                //TonTai(msx, vt);

                Console.WriteLine();
            }            
        }

        //Xuất
        public void Xuat()
        {
            for (int i = 0; i < a.Length; i++)
            {               
                SinhVien sinhVien = a[i];
                Console.WriteLine($"Sinh vien thu {i + 1}: ");
                sinhVien.Xuat();
                sinhVien.getloai();
                

                Console.WriteLine();
            }
        }

        //Kiểm tra
        public bool TonTai(string msx, int vt)
        {
            Console.Write("Kiem tra ma so sinh vien: ");
            vt = int.Parse(Console.ReadLine());
            for (int i = 0; i < vt; i++)
            {
                if (a[i].maSo.CompareTo(msx) == 0)
                {
                    Console.WriteLine("Ma so sinh vien vua nhap ton tai trong danh sach !");
                    return true;
                }
                else
                {
                    Console.WriteLine("Ma so sinh vien vua nhap khong 2ton tai trong danh sach !");
                }
            }
            return false;
        }

    } 
}
