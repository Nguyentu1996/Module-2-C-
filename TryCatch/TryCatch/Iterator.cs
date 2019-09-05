using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TryCatch
{
    class Iterator : IEnumerable
    {
        string[] Name = { "tu", "phong", "dao" };
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Name.Length; i++)
            {
                yield return Name[i];
            }
        }
        public static void Main()
        {
            string[] NameClass = { "c1", "c2", "c3" };
            GenericDepartment<string> generic = new GenericDepartment<string>(NameClass);
            foreach(string val in generic)
            {
                Console.WriteLine(val);
            }
            int[] age = { 20, 21, 22, 23 };
            GenericDepartment<int> genericDepartment = new GenericDepartment<int>(age);
            foreach(int old in age)
            {
                Console.WriteLine(old);
            }
            Iterator item = new Iterator();
            Console.WriteLine("name");
            foreach(var name in item)
            {
                Console.WriteLine(name);
            }
        }
    }
    class GenericDepartment<T>
    {
        T[] item;
        public GenericDepartment(T[] val)
        {
            item = val;
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach(T value in item)
            {
                yield return value;
            }
        }
           
            
        
    }
}
