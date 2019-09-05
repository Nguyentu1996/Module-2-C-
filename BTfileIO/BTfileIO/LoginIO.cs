using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BTfileIO
{
    public class LoginIO
    {
        public static string file = $"c:\\FileNameIO\\input.txt";
        public static void CreateFile()
        {
            
            using (StreamWriter sw = File.CreateText(file))
            {
              
               Console.WriteLine("intput size  ");
                    var size = int.Parse(Console.ReadLine());
                    sw.WriteLine(size);
                    for (int i = 0; i < size; i++)
                    {
                        Console.WriteLine($"input A[{i}]");
                        var write = Console.ReadLine();
                        sw.Write(string.Join(" ",write));
                    }
                }
            
        }
        public static void Sum()
        {
            using(StreamReader sr = File.OpenText(file))
            {
                int index = 0;
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    if (index == 0)
                    {
                        index++;
                        continue;
                    }
                    Console.WriteLine(string.Join(" ",s));
                    var array = s.Split(" ");

                    int sum = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += int.Parse(array[i]);
                    }
                    
                    Console.WriteLine(sum);
                }
               



            }
        }
        public static void ReadFile()
        {
            using(StreamReader sr= File.OpenText(file))
            {
                string s;
                
                while((s = sr.ReadLine()) != null)
                {
                    s = sr.ReadLine();
                    Console.WriteLine(string.Join(" ",s));

                }
 
            }
        }
        public static void Main()
        {
            CreateFile();
            ReadFile();
            Sum();
        }

    }
}