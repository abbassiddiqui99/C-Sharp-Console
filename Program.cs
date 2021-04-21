using System;

namespace C_Sharp_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter First Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Second Number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine(num1/num2);
            }
            catch (System.DivideByZeroException)
            {
                System.Console.WriteLine("Attempted to divide by zero");                
            }
            catch (System.FormatException)
            {
                System.Console.WriteLine("Wrong Input");                
            }
            finally {
                System.Console.WriteLine("Always Executed");
            }
            

            Console.ReadLine();
        }
    }
}
