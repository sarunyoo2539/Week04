using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data type : sbyte");
            Console.WriteLine("Size :" + sizeof(sbyte));
            Console.WriteLine("Minimum Value :" + (int)sbyte.MinValue);
            Console.WriteLine("Maximum Value :" + (int)sbyte.MaxValue);
        }
    }
}
