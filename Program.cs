using System;

namespace C_Sharp_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticAttributes check = new StaticAttributes("Unstoppable", "Unknown", 240);
            
            System.Console.WriteLine(StaticAttributes.songCount);
            System.Console.WriteLine(check.getStaticAttribute());
        }
    }
}
