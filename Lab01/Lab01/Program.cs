using System;
namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            Random random = new Random();
            int randomNumber = random.Next(0, 9);
            bool B = A < randomNumber;
            Console.WriteLine("Answer A < randomNumber = {0}" , B);
        }
    }
}
