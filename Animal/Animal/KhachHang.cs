using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class KhachHang : Animal
    {
        private string maKH;
        private string loaiKhachHang;
        KhachHang[] danhsachthem;
        public KhachHang()
        {

        }
        public KhachHang(string maKH,string loaiKhachHang, string hoTen,string gioiTinh,string ngaySinh,string maSo) : base(hoTen, gioiTinh, ngaySinh,maSo)
        {
            this.maKH = maKH;
            this.loaiKhachHang=loaiKhachHang;
        }
        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        public string LoaiKhachHang
        {
            get { return loaiKhachHang; }
            set { loaiKhachHang = value; }
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap loai khach hang");
            LoaiKhachHang = Console.ReadLine();

        }
        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine("ma khach hang : {0} , loai khach hang {1}", maKH, loaiKhachHang);
        }
        public  void TaoDanhSachKhachHang()
        {   
            Console.WriteLine("nhap so luong danh sach khach hang");
           var soluong = Console.ReadLine();
            int n;
            bool result = int.TryParse(soluong, out n);
            if (result)
            {
                 danhsachthem = new KhachHang[n];
                
                for(int i = 0; i < n; i++)
                {
                    danhsachthem[i] = new KhachHang();
                    Console.WriteLine("nhap khach hang thu " + (i + 1));
                    danhsachthem[i].Nhap();
                }
            }
            else Console.WriteLine(" ban nhap sai roi hay nhap lai");

         }
        public void HienthiAllKhachHang()
        {
            if (danhsachthem == null)
            {
                Console.WriteLine("chua co danh sach khach hang");
            }else
            Console.WriteLine("--hien thi tat ca danh sach khach hang --");
            for(int i = 0; i < danhsachthem.Length; i++)
            {
                Console.WriteLine("khach hang thu :" + (i + 1));
                danhsachthem[i].HienThi();
            }
 
           
           
        }

    }
}
