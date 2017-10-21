using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            String Name , Last;
            int Code;
            double GPA;

            Name = Console.ReadLine();
            Last = Console.ReadLine();
            int.TryParse(Console.ReadLine(), out Code);
            double.TryParse(Console.ReadLine(), out GPA);

            Console.WriteLine();
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Last Name: {0}", Last);
            Console.WriteLine("Age: {0}", Code);
            Console.WriteLine("Height: {0}", GPA);


        }
    }
}
