using System;

namespace SortList
{
    class Program
    {
        public static void Swap( ref int a , ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
           
        }
        public static void Print(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
               Console.Write( array[i]+",");
            }
        }

        public static void QuickSort(int[] array,int left , int right)
        {
           
            if (array == null || array.Length == 0)
            {
                return ;
            }
            if (left >= right)
            {
                return;
            }
            int mid = left + (right - left) / 2;
            int pivot = array[mid];
            int i = left;
            int j = right;
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }
                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    Swap(ref array[i], ref array[j]);
                    i++;
                    j--;
                }
                if (left < j) {
                    QuickSort(array, left, j);
                     }
                if(right> i) {
                    QuickSort(array, i, right); }
            }
            
           

        }
        
        // sắp xếp chèn 
        #region
        public static void InsertSort(int[] array)
        {
            for(int i = 1; i < array.Length; i++)
            {
                for(int j = i; j > 0; j--)
                {
                    if (array[j] < array[j-1])
                    {
                        Swap(ref array[j], ref array[j -1]);
                    }   
                }
            }
            Console.WriteLine(string.Join(",", array));
        }
        #endregion
        //sắp xếp nổi bọt
        #region
        public static void BubbleSort(int[] array)
        {
            for(int i = 0; i<array.Length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ,", array));
        }
        #endregion
        //sắp xếp chọn 
        #region
        public static void SelectedSort(int [] array)
        {
            for(int i = 0; i< array.Length-1 ; i++)
            {
                
                var k = i;
                for(int j = i +1; j < array.Length; j++)
                {
                    if (array[j] < array[k])
                    {
                        k = j;
                    }
                }
                Swap(ref array[i], ref array[k]);

            }
            Console.WriteLine(string.Join(",", array));
        }
        #endregion
        static void Main(string[] args)
        {
            int[] A = { 9, 6, 4, 2, 1, 3, 5, 8, 6, 2, 3, 5, 7 };
            //SelectedSort(A);
            // BubbleSort(A);
            // InsertSort(A);
            
            int left = 0;
            int right = A.Length - 1;
            QuickSort(A, left, right);
            Print(A);
            
        }
    }
}
