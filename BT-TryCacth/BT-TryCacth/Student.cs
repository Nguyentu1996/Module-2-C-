using BT_TryCacth;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT_TryCacth
{
    class Student
    {
       public BorrowBook.Book book = new BorrowBook.Book();
        private int studenid;
        private string studentName;
        private int age;
        private string gender;
        private string citi;
        public int StudentID { get { return studenid; } set { studenid = value; } }
        public string StudentName { get {return studentName; } set { studentName = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public string City { get { return citi; } set { citi = value; } }
        public void SetName(string name)
        {
                if (name.Length > 6 && name.Length < 40)
                {
                    studentName = name;
                    
                }
                else
                {
                    Console.WriteLine("erorr , Input again Name > 8 va < 40 ki tu");
                BorrowBook.Book book = new BorrowBook.Book();
                book.AccepDetails();
                }
       
            
        }
        public void SetAge(int age)
        {
            if (age >= 18)
            {
                this.age = age;
            }else
            {
                Console.WriteLine(" input again Age > = 18 ");
                book.AccepDetails();

            }
        }
        public void SetGender(string gender)
        {
            if (gender == "Nam" || gender == "Nu")
            {
                this.gender = gender;
            }
            else
            {
                Console.WriteLine("Gender Nam or Nu , K choi gay or less");
                book.AccepDetails();
            }
        }
        public void SetCity(string citi)
        {
            if (citi.Length > 4 && citi.Length < 40)
            {
                this.citi = citi;
            }else
            {
                Console.WriteLine("Input City Again");
                book.AccepDetails();
            }
           
        }
        public void Display()
        {
            Console.WriteLine("Name {0} , ID {1} , Age {2} , Gender :{3} , City {4}", StudentName, StudentID, Age, Gender, City);
        }
    }
}
namespace BorrowBook
{
    class Book
    {
        public int Soluong{ get; set; }
        public string LoaiSach { get; set; }
        public double Tyle { get; set; }
        public int SoNgayMuon { get; set; }
        public double PhanTramNgayMuon { get; set; }
        public string[] Arr= {  "1.Chuyen Nganh\t\t\t5" ,"2.Van Hoc\t\t\t3","3.Tham Khao\t\t\t4","4.Loai Khac\t\t\t6"} ;
        public void ViewAccepDetails()
        {
            Console.WriteLine("Chi Tiet Muon Sach");
            Console.WriteLine("SoLuong :"+Soluong);
            Console.WriteLine("Loai Sach :"+LoaiSach);
            Console.WriteLine("Tong Tien Phai Tra : "+CalculateAmount());
            
        }
        public void AccepDetails()
        {
            try
            {
                Student student = new Student();
                Console.Write("Nhap Ten SV : ");
                var name = Console.ReadLine();
                student.SetName(name);
                Console.WriteLine("Nhap tuoi : ");
                int age = int.Parse(Console.ReadLine());
                student.SetAge(age);
                Console.WriteLine("Nhap gioi tinh Nam/Nu");
                var gioitinh = Console.ReadLine();
                student.SetGender(gioitinh);
                Console.WriteLine("Nhap ten Thanh Pho");
                var thanhPho = Console.ReadLine();
                student.SetCity(thanhPho);
                Console.WriteLine("Loai Sach \t\t Ty le");
                foreach (var item in Arr)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Chon Loai Sach Muon");
                var choice = int.TryParse(Console.ReadLine(), out int selected);
                do
                {
                    switch (selected)
                    {
                        case 1:
                            LoaiSach = "1.Chuyen Nganh";
                            PhanTramNgayMuon = 5;

                            break;
                        case 2:
                            LoaiSach = "2.Van Hoc";
                            PhanTramNgayMuon = 3;
                            break;
                        case 3:
                            LoaiSach = "3.Tham Khao";
                            PhanTramNgayMuon = 4;
                            break;
                        case 4:
                            LoaiSach = "4.Loai Khac";
                            PhanTramNgayMuon = 6;
                            break;

                    }
                }
                while (choice == false);

                Console.WriteLine("So luong muon");
                Soluong = int.Parse(Console.ReadLine());
                Console.WriteLine("So ngay muon");
                SoNgayMuon = int.Parse(Console.ReadLine());
                Console.WriteLine("Thong tin chi tiet cua SV");
                student.StudentID++;
                student.Display();
            }catch(Exception me)
            {
                Console.WriteLine(me.Message);
            }
            Console.ReadKey();
      

             

        }
        public double CalculateAmount()
        {
            return Soluong * (PhanTramNgayMuon / 100) * SoNgayMuon * 10;
        }
    }
}
