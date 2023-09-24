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

            int vt = 0;
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Nhap thong tin cho sinh vien thu {i + 1}: ");
                SinhVien sv = new SinhVien();
                sv.Nhap();
                a[i] = sv;

                //Gọi phương thức kiểm tra mã số sinh viên đã tồn tại chưa ?
                do
                {
                    if (TonTai(sv.maSo, vt))
                    {
                        Console.WriteLine("Ma so sinh vien da ton tai. Moi ban nhap lai !!");
                        sv.Nhap();
                    }
                }
                while(TonTai(sv.maSo, vt));
                
                a[vt] = sv;
                vt++;
                Console.WriteLine();               
            }
            
        }

        //Xuất
        public void Xuat()
        {
            for (int i = 0; i < a.Length; i++)
            {               
                SinhVien sv = a[i];
                Console.WriteLine($"Sinh vien thu {i + 1}: ");
                sv.Xuat();
                sv.getloai();
                

                Console.WriteLine();
            }
        }

        //Kiểm tra mã số sinh viên đã tồn tại chưa ?
        public bool TonTai(string msx, int vt)
        {            
            for (int i = 0; i < vt; i++)
            {
                if (a[i].maSo.CompareTo(msx) == 0)
                {                    
                    return true;
                }
            }
            return false;
        }

    } 
}
