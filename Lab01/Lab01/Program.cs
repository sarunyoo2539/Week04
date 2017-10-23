using System;
namespace variableProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            const double lightSpeed = 186000d;   // miles per second
            Console.WriteLine("Light speed = {0} Mile Per second", lightSpeed);
            const double mileTokm = 1.609344;
            Console.WriteLine("Light speed = {0} km Per second", lightSpeed * mileTokm);
            const double SunToMarsDistance = 227940000;  // miles
            Console.WriteLine("SunToMarsDistance = {0} km", SunToMarsDistance * mileTokm);
            double SunToMarsTimeOfLight = SunToMarsDistance / lightSpeed;  // miles
            Console.WriteLine("SunToMarsTimeOfLight = {0} seconds", SunToMarsTimeOfLight);
            Console.WriteLine("SunToMarsTimeOfLight = {0} minutes", SunToMarsTimeOfLight / 60d);
            
        }
    }
}
