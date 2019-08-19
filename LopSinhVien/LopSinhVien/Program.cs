
using System;

namespace LopSinhVien
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sinhvien = new SinhVien(001,"Tu",10);
           
            sinhvien.tinhDiemTB();
            sinhvien.hienThi();
            SinhVien hocsinh = new SinhVien();
            hocsinh.maSV = 002;
            hocsinh.DiemLT = 9;
            hocsinh.HoTen = "huy";
            hocsinh.tinhDiemTB();
            hocsinh.hienThi();
            

           
        }
    }
}
