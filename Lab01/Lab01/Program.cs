using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data type : byte");
            Console.WriteLine("Size :" + sizeof(byte));
            Console.WriteLine("Minimum Value :" + (int)byte.MinValue);
            Console.WriteLine("Maximum Value :" + (int)byte.MaxValue);
        }
    }
}
