using System;

namespace C_Sharp_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book_01 = new Book("Harry Potter","JK Rowling",400);
            Book book_02 = new Book("Lord of the Rings","Tolkein",700);

            System.Console.WriteLine(book_01.pages);

            Console.ReadLine();
        }
    }
}
