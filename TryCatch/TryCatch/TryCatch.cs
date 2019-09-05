
using System;
using System.Collections.Generic;
using System.Text;

namespace TryCatch
{
    class TryCatch
    {
      public static void Main()
        {
            try
            {
                Console.WriteLine("input a :");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("input b :");

                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} , {1} , {2}", a, b, a / b);
            }
            catch(DivideByZeroException dze){
                Console.WriteLine(dze.Message);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("go to final");
            }
        }
    }
}
