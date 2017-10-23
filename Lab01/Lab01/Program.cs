using System;
public class MathTest
{
    static void Main(string[] args)
    {
        for (float x = 0; x < Math.PI * 2.0F; x += 0.3F)
        {
            Console.WriteLine("The sine of {0,10:F} = {1,-10:F6}" +
            spaces(Math.Tan(x)) + "*", x, Math.Tan(x));
        }
    }
    private static string spaces(double val)
    {
        string SpaceString = new String(' ', ((int)(val * 10.0)) + 10);
        return SpaceString;
    }
}
