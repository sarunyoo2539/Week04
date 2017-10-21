using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data type : short");
            Console.WriteLine("Size :" + sizeof(short));
            Console.WriteLine("Minimum Value :" + (int)short.MinValue);
            Console.WriteLine("Maximum Value :" + (int)short.MaxValue);
        }
    }
}
