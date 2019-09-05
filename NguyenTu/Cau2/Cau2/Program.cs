using System;

namespace Cau2
{
    class Program
    {
        public class Cau2
        {
            public static int[] Arr;
            public static void Main()
            {
                InitMenu();
            }
            public static void InitMenu()
            {
                int option = 0;
                do
                {
                    Console.WriteLine("1. Create Array");
                    Console.WriteLine("2. Is increase Array");
                    Console.WriteLine("3. Sort Array");
                    Console.WriteLine("4. Find array");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine("Please select an opition");
                    Console.WriteLine("Opition: ");
                    if (int.TryParse(Console.ReadLine(), out var number))
                    {
                        option = number;
                    }
                }
                while (option > 7 || option <= 0);
                Process(option);
            }
            public static void Process(int selected)
            {
                Console.Clear();
                switch (selected)
                {
                    case 1:
                        {
                            Console.WriteLine(" Create Array ");
                            InitArray();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Is increase Array");
                            if (IsIncreaseArray(Arr))
                            {
                                Console.WriteLine(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine(false);
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(" Sort Array ");
                            SelectionSort(Arr);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Find array ");
                            Console.WriteLine("Input number ");
                            int n;
                            do
                            {
                                int.TryParse(Console.ReadLine(), out n);
                                Console.WriteLine("Input number ");
                            }
                            while (n <= 0);
                            if (binarySearch(Arr, n) == -1)
                            {
                                Console.WriteLine("Not find");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Number position to search for: {0}", string.Join(",", binarySearch(Arr, n)));
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Exit ");
                            break;
                        }
                }
                InitMenu();
            }
            public static void InitArray()
            {
                Console.WriteLine("Input size  : ");
                int n;
                do
                {
                    int.TryParse(Console.ReadLine(), out n);
                    
                }
                while (n <= 0);
                Arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    var number = 0;
                    var kt = false;
                    do
                    {
                        Console.WriteLine("Input array{0}: ", i + 1);
                        if (int.TryParse(Console.ReadLine(), out number))
                        {
                            Arr[i] = number;
                            kt = true;
                        }
                    }
                    while (!kt);
                }
                Console.WriteLine("---------------------");
            }
            public static bool IsIncreaseArray(int[] A)
            {
                for (int i = 0; i < A.Length - 1; i++)
                {
                    if (A[i] > A[i + 1]) return false;
                }
                return true;
            }
            public static void SelectionSort(int[] A)
            {
                for (int i = 0; i < A.Length - 1; i++)
                {
                    var min = A[i];
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if (A[j] < min)
                        {
                            min = A[j];
                            var tem = A[i];
                            A[i] = A[j];
                            A[j] = tem;
                        }
                    }
                }
                Show(Arr);
                Console.WriteLine();
                Console.WriteLine("---------------------");
            }
            public static int binarySearch(int[] A, int n)
            {
                int min = 0;
                int max = A.Length - 1;
                int mid = 0;
                while (min <= max)
                {
                    mid = (max + min) / 2;
                    if (A[mid] == n)
                    {
                        return mid;
                    }
                    else if (A[mid] < n)
                    {
                        min = mid + 1;
                    }
                    else
                    {
                        max = mid - 1;
                    }
                }
                return -1;
            }
            public static void Show(int[] Arr)
            {
                foreach (int item in Arr)
                {
                    Console.Write(" {0} ", item);
                }
            }
            public static void swap(ref int a, ref int b)
            {
                int temp = a;
                a = b;
                b = temp;
            }


        }
    }
}
