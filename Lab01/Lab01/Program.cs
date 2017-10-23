using System;
namespace thruthTable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A, Y;
            Console.WriteLine("      Y = NOT A");
            Console.WriteLine("-----------------------");
            Console.WriteLine("   A\t|  Y");
            Console.WriteLine("-----------------------");
            A = false; Y = !A;
            Console.WriteLine(" {0}\t| {1}", A, Y);
            A = true; Y = !A;
            Console.WriteLine(" {0}\t| {1}", A, Y);
            
            Console.WriteLine("-----------------------");
        }
    }
}
