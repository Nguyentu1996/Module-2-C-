using System;

namespace TimKiemNhiPhan
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int fist = 0;
            int  last =arr.Length - 1;
            int  key = 7  ;
            int  mid = (fist + last) / 2;
            while (fist < last)
            {
                if (arr[mid] == key)
                {
                    break;
                }
                else if (arr[mid] > key)
                        {
                          last = mid -1;
                        }
                else 
                    fist = mid +1 ;

                if (arr[last] == key)
                {
                    Console.WriteLine("1");
                    break;
                }
                else
                {

                    Console.WriteLine("-1");
                    break;
                } 
            }
            
        }
    }
}
