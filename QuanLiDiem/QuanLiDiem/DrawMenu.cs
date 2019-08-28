using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLiDiem
{
    class DrawMenu
    {
        
        
        StudentMark Student = new StudentMark();
        Student std = new Student();
       
       
        public void InsertStudent()
        {
            
            Console.WriteLine("Nhap full name");
            var fullname = Console.ReadLine();
            Console.WriteLine("Nhap Lop");
            var lop = Console.ReadLine();
            Console.WriteLine("Nhap semester");
            var seme = int.Parse(Console.ReadLine());
            std.Averagemark();

            var item = new Student()
            {
                FullName = fullname,
                Class = lop,
                Semester = seme,
                ID = std.iD
               

        };
            Student.Insert(item);
           
        }
        public void Display()
        {
            Console.WriteLine("Full Name\t\tClass\t\tID\t\tSemester");
            if(Student.studentList!= null && Student.studentList.Count > 0)
            {
                foreach(Student student in Student.studentList)
                {
                    Console.WriteLine(student.FullName+"\t\t\t"+student.Class+"\t\t"+student.ID+"\t\t"+student.Semester+ "\t\t");
                    
                }
                
                
            }
        }
        public void Menu()
        {
            int choice = -1;
            while (choice != 4)
            {
                Console.WriteLine("MeNu");
                Console.WriteLine("1 : insert");
                Console.WriteLine("2 : view");
                Console.WriteLine("3 : averageMark");
                Console.WriteLine("4: exit");
                int selected;
                bool check = int.TryParse(Console.ReadLine(),  out selected);
                if (check && selected >0 && selected<5 )
                {
                    switch (selected)
                    {
                        case 1:
                            std.iD+=1;
                            InsertStudent();
                            
                            break;
                        case 2:
                            Display();
                            
                            break;
                        case 3:
                            std.Avecal();
                            break;
                        case 4:
                            break;
                    }
                }
            }
        }
    }
}
