using System;
using System.Collections.Generic;
using System.Text;

namespace BT3
{
    class Pos :IPos
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Conten { get; set; }
        public string Author { get; set; }
        public float Average { get; set; }
        public int[] Rates=new int[4];

        public void Display()
        {
            Console.WriteLine("ID{0} , Title {1} , Conten {2} , Author {3} , AverageRate {4}", Id, Title, Conten, Author, Average);
        }

        public void CalculatorRate()
        {
            float sum = 0;
            foreach(var item in Rates)
            {
               sum+= item;
            }
            Average= sum / Rates.Length;
            
        }
    }
}
