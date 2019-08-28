using System;

namespace TestDelegate
{
    public delegate void Math(int a, int b);
    class Program
    {
        static void Add(int a , int b)
        {
            int result = a + b;
            Console.WriteLine("result : {0}", result);
        }
        static void Subtraction(int a , int b)
        {
            int result = a - b;
            Console.WriteLine("result : {0}", result);
        }
        static void Multiplication(int a ,int b)
        {
            int result = a * b;
            Console.WriteLine("result : {0}", result);
        }
        static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("result : {0}", result);
        }
        static void Main(string[] args)
        {

            Math math = new Math(Add);
            math += new Math(Subtraction);
            math += new Math(Division);
            math += new Math(Multiplication);
            math(20, 10);

        }

    }
}
