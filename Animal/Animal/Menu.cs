using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Menu
    {
        public static void Main()
        {
            var customers = new List<Customer>() {
                new Customer()
                {
                    Id = 1234,
                    FullName = "Khoa Nguyen",
                    Gender = true
                },
                new Customer()
                {
                    Id = 1235,
                    FullName = "Tu Nguyen",
                    Gender = true
                }
            };

            Console.WriteLine("-------------------------");
            foreach (var customer in customers)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}", customer.Id, customer.FullName, customer.Gender ? "Male" : "Female");
            }

            customers.RemoveAt(0);
            Console.WriteLine("-------------------------");
            foreach (var customer in customers)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}", customer.Id, customer.FullName, customer.Gender ? "Male" : "Female");
            }
            string choice= "";
            while (choice != "ea")
            {
                Console.WriteLine("----Menu------");
                Console.WriteLine("Them khach hang vui long nhap : ac");
                Console.WriteLine("Them Nhan vien nhap : ae");
                Console.WriteLine("Hien Thi Thong Tin Nhan Vien : dae");
                Console.WriteLine("Hien Thi Thong Tin Khach Hang : dac");
                Console.WriteLine("Thong Ke Khach Hang : cs");
                Console.WriteLine("Thoat Chuong Trinh Nhap : ea");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "ac":

                        var danhsach = new KhachHang();
                        danhsach.TaoDanhSachKhachHang();
                        //ma khach hang tang tu dong
                        //gioi tinh chi nam hoac nu 
                        //bang cao dang hoac dai hoc
                        //ngay sinh .lenght<10

                        break;

                    case "ae":
                        var nhanvien = new NhanVien();
                        nhanvien.Nhap();
                        //  nhu tren 
                        //thanh vien hoac vip moi dc add

                        break;
                    case "dae":
                        //hien thi tat ca danh sach nhan vien 
                        break;
                    case "dac":
                        var danhsachhienthi = new KhachHang();
                        danhsachhienthi.HienthiAllKhachHang();
                        //hien thi tat ca danh sach khach hang
                        break;
                    case "cs":
                        // hien thi theo loai khach hang
                        //khach hang moi 
                        // khac hang vip
                        // thanh vien
                        break;
                    case "ea":
                        Console.WriteLine(" ban co muon thoat yes or no");
                        var acept = Console.ReadLine();
                        if (acept == "yes")
                        {
                            choice = "ea";
                        }
                        else if (acept == "no") choice = "";

                        break;

                }
           
                    
            }
        }

        public class Customer
        {
            public int Id { get; set; }
            public string FullName { get; set; }
            public bool Gender { get; set; }
        }
    }
}
