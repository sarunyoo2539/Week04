using System;
namespace thruthTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10 , b = 20 , x = 5 , y = 2 , A,B,C,D,E,F,G,H,I,J;
            
            A = a + b;
            B = x - b;
            C = x * b;
            D = y / a;
            E = b % y;
            F = y + 10 % x;
            G = a / 3 * 5;
            H = 9 / 2 * a;
            I = y % 8;
            J = 100 * x + y % 2 - a;

            Console.WriteLine("Answer :\n {0}\n {1}\n {2}\n {3}\n {4}\n {5}\n {6}\n {7}\n {8}\n {9}\n", A,B,C,D,E,F,G,H,I,J);
        }
    }
}
