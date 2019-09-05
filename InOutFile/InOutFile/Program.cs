using System;
using System.IO;

namespace InOutFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileName = new FileStream("text.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for(int i = 1; i <= 20; i++)
            {
                fileName.WriteByte((byte)i);

            }
            fileName.Position = 0;
            for(int i = 0; i <= 20; i++)
            {
                Console.Write(fileName.ReadByte() + " ");
            }
            fileName.Close();
            Console.ReadKey();
        }
    }
}
