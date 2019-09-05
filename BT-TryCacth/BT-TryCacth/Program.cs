

using System;

namespace Library
{
    class Program
    {
       
        static void Main(string[] args)
        {
            BorrowBook.Book book = new BorrowBook.Book();
            book.AccepDetails();
            book.ViewAccepDetails();
           
        }
    }
}
