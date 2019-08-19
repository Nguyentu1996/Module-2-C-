using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class NhanVien : Animal
    {
        private string bangCap;
        public NhanVien()
        {

        }
        public NhanVien(string hoTen,string gioiTinh,string maSo,string ngaySinh,string bangCap) : base(hoTen,gioiTinh,maSo,ngaySinh) {
            this.bangCap = bangCap;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("nhap thong tin bang cap");
            bangCap = Console.ReadLine();
        }
        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine("bang cap : {0}", bangCap);
        }
    }
}
