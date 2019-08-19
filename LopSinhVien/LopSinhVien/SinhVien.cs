using System;
using System.Collections.Generic;
using System.Text;

namespace LopSinhVien
{
    class SinhVien
    {
        private int maSv;
        private string hoTen;
        private double diemLT, diemTH, diemTB;
        public SinhVien()
        {

        }
        public int maSV
        {
            get
            {
                return maSv;
            }
            set
            {
                maSv = value;
            }
        }
        public string HoTen
        {
            get { return hoTen; }
            set
            {
                hoTen = value;
            }
        }
        public double DiemLT
        {
            get
            {
                return diemLT;
            }
            set {
                diemLT = value;
                }
        }
       public SinhVien(int maSv,string hoTen,double diemLT)
        {
            this.maSv = maSv;
            this.hoTen = hoTen;
            this.diemLT = diemLT;
        }
        public double tinhDiemTB()
        {
            double diemTB = diemLT/2;
            return diemTB;
        }
        public void hienThi()
        {
            Console.WriteLine("Ma sv :{0}", maSv);
            Console.WriteLine("Ho ten :{0}", hoTen);
            Console.WriteLine("diem lt :{0}", diemLT);
        
            
            Console.WriteLine("diem tB :{0}", tinhDiemTB());
        }
    }
}
