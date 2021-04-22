using System;

namespace C_Sharp_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Book book_01 = new Book("Harry Potter","JK Rowling",400);
            // Book book_02 = new Book("Lord of the Rings","Tolkein",700);

            // System.Console.WriteLine(book_01.pages);

            Student student_01 = new Student("Abbas Hussain","BSCS",2.7f);
            Student student_02 = new Student("Ammad Hussain","ACCA",3.6f);

            System.Console.WriteLine("{0} Can you goto Abroad {1} because your CGPA is {2}",student_01.name,student_01.Abroad(),student_01.gpa);
            System.Console.WriteLine("{0} Can you goto Abroad {1} because your CGPA is {2}",student_02.name,student_02.Abroad(),student_02.gpa);

            Console.ReadLine();
        }
    }
}
