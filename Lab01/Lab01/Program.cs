using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data type : ushort");
            Console.WriteLine("Size :" + sizeof(ushort));
            Console.WriteLine("Minimum Value :" + (int)ushort.MinValue);
            Console.WriteLine("Maximum Value :" + (int)ushort.MaxValue);
        }
    }
}
