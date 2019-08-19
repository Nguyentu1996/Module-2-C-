using System;

namespace Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table(5, 6);
            table.Area();
        Console.WriteLine(table.ToString());
            table.Height = 7;
            table.Width = 9;
            table.Area();
          Console.WriteLine(table.ToString());
        }
    }
}
