using System;

namespace ThiModul2Cau1
{
    class Program
    {
        public static void InitMatrix()
        {
            
            Console.WriteLine("Nhap N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap M :");
            int m = int.Parse(Console.ReadLine());
            int[,] array = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.WriteLine("nhap phan tu thu arr[{0},{1}]", i, j);
                    array[i, j] = int.Parse(Console.ReadLine());
                }
                
            }
            Console.WriteLine("In Mang");
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write(array[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
        public static void Sum(int[] arr)
        {
            double sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }
        public static void ShowMaxRow()
        {
            Console.WriteLine("Nhap N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap M :");
            int m = int.Parse(Console.ReadLine());
            int[,] array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("nhap phan tu thu arr[{0},{1}]", i, j);
                    array[i, j] = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("In Mang");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Tinh Tong");
            double sum = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    
                    sum += array[i, j];
                }
            }Console.WriteLine(sum);
            
        }
        static void Main(string[] args)
        {
            //InitMatrix();
            int[] array = { 1, 2, 3, 4, 5 };
            Sum(array);
            ShowMaxRow();
        }
    }
}
