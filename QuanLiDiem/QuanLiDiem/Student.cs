using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace QuanLiDiem
{
    class Student

    {
        public int iD = 0;
        public ArrayList studentArr = new ArrayList();
        private string fullname;
        private int id;
        private string lop;
        private int semester;
        private float averageMark;
        public string FullName { get=>fullname; set=>fullname=value; }
        public int ID { get=>id; set=>id=value; }
        public string Class { get=>lop; set=>lop=value; }
        public int Semester { get=>semester; set=>semester=value; }
        public float AverageMark { get=>averageMark; set=>averageMark=value; }
        public float[] aveArr = new float[5];
        public Student()
        {

        }
        public void Avecal()
        {
            float total = 0;

            for (int i = 0; i < aveArr.Length; i++)
            {
                total += aveArr[i];

            }
             AverageMark = total / aveArr.Length;
            Console.WriteLine("Average {0}", AverageMark);
            
            studentArr.Add(AverageMark);
           


        }
        public void Averagemark()
        {
            
            for (int i = 0; i < aveArr.Length; i++)
            {
                Console.WriteLine("input mark {0} : ", (i + 1));
                aveArr[i] = int.Parse(Console.ReadLine());
                studentArr.Add(aveArr[i]);    
            }
            

        }
        public void Show()
        {
            foreach (var ave in studentArr)
            {
                Console.WriteLine("Student Mark {0}", ave);

            }
        }
    }
}
