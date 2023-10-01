using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BaiTap1
{
    internal class SinhVien
    {
        //Thuộc tính
        public string maSo;
        private string hoTen;
        private string chuyenNganh;
        private int namSinh;
        private float diemTB;
        private string loai;

        //Get/Set
        public string getMaso()
        {
            return maSo;
        }
        public void setmaSo(string newmaSo)
        {
            maSo = newmaSo;
        }
        public string gethoTen()
        {
            return hoTen;
        }
        public void sethoTen(string newhoTen)
        {
            hoTen = newhoTen;
        }
        private string getchuyenNganh()
        {
            return chuyenNganh;
        }
        private void setchuyenNganh(string newchuyenNganh)
        {
            chuyenNganh = newchuyenNganh;
        }
        private int getnamSinh()
        {
            return namSinh;
        }
        private void setnamSinh(int newnamSinh)
        {
            namSinh = newnamSinh;
        }
        private float getdiemTB()
        {
            return diemTB;
        }
        private void setdiemTB(float newdiemTB)
        {
            diemTB = newdiemTB;
        }
        public string getloai()
        {
            return loai;
        }
        public void setloai(string newloai)
        {
            loai = newloai;
        }

        //Constructor
        public SinhVien() { }  
        public SinhVien(string maSo, string hoTen, string chuyenNganh, int namSinh, float diemTB)
        {
            this.maSo = maSo;
            this.hoTen = hoTen;
            this.chuyenNganh = chuyenNganh;
            this.namSinh = namSinh;
            this.diemTB = diemTB;
            //XepLoai();
        }
        public SinhVien(SinhVien sv) { }

        //Kiểm tra
        public bool KiemTraNamSinh(int ns)
        {
           if(ns > 2004 && ns < 2074)
            {
                //Console.WriteLine("Nam sinh hop le !!");
                return true;
            }
           else
            {
                //Console.WriteLine("Nam sinh khong hop le !!");
                return false;
            }
        }
        public bool KiemTraDiemTB(float dtb)
        {
            if (dtb >= 0 && dtb <= 10)
            {
                return true;
            }
            else
                return false;
        }

        //Nhập
        public void Nhap()
        {
            Console.Write("Nhap ma sinh vien: ");
            maSo = Console.ReadLine();         
            Console.Write("Nhap ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap chuyen nganh: ");
            chuyenNganh = Console.ReadLine();           
            bool validInput = false;
            while(!validInput)
            {
                Console.Write("Nhap nam sinh: ");
                string input = Console.ReadLine();
                if (Int32.TryParse(input, out namSinh))
                {
                    if(namSinh >= 2004 && namSinh <= 2074)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Gia tri khong hop le. Moi ban nhap lai !!");
                    }
                }
            }
            Console.Write("Diem TB: ");
            diemTB = float.Parse(Console.ReadLine());            
        }

        //Xuất
        public void Xuat()
        {
            Console.WriteLine("Ma so la: {0}", maSo);
            Console.WriteLine("Ho ten: {0}", hoTen);
            Console.WriteLine("Chuyen nganh: {0}", chuyenNganh);
            Console.WriteLine("Nam sinh: {0}", namSinh);
            Console.WriteLine("Diem TB: {0}", diemTB);
            XepLoai();
        }

        //Kiểm tra 
        public void XepLoai()
        {
            if(diemTB < 5)
            {
                Console.WriteLine("Diem kem !");
            }
            else if(diemTB >= 5 && diemTB < 7)
            {
                Console.WriteLine("Diem trung binh !");
            }
            else if(diemTB >= 7 && diemTB < 8)
            {
                Console.WriteLine("Diem kha !");
            }
            else
            {
                Console.WriteLine("Diem gioi !");
            }
        }      
    }
}
