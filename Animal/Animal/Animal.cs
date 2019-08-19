using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Animal
    {
        private string hoTen;
        private string maSo;
        private string gioiTinh;
        private string ngaySinh;

        public Animal()
        {

        }
        public Animal(string hoTen,string maSo,string gioiTinh,string ngaySinh)
        {
            this.hoTen = hoTen;
            this.maSo = maSo;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
        }
        public string Hoten
        {
            get
            {
                return hoTen;
            }
            set
            {
                hoTen = value;
            }
        }
        public string Maso
        { 
            get
            {
                return maSo;
            }
            set
            {
                maSo = value;
            }
        }
        public string GioiTinh
        {
            get
            {
                return gioiTinh;
            }
            set
            {
                gioiTinh = value;
            }
        }
        public string NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public virtual void Nhap()
        {
            Console.WriteLine("nhap ma so");
            Maso = Console.ReadLine();
            Console.WriteLine("nhap ho ten");
            Hoten = Console.ReadLine();
            Console.WriteLine("nhap gioi tinh");
            GioiTinh = Console.ReadLine();
            Console.WriteLine("nhap ngay thang nam sinh");
            NgaySinh = Console.ReadLine();
        }
        public virtual void HienThi()
        {
            Console.WriteLine("maso: {0} , hoten :{1} , gioitinh :{2} , ngaysinh : {3}", maSo, hoTen, gioiTinh,ngaySinh);
        }
    }
}
