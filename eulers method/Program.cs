using System;

namespace eulers_method
{
    class Program
    {
        //these are initial conditions and problem specific parameters
        const double initialT = 1;
        const double initialY = 2;
        const double dt = 0.01;
        const double finalT = 2.1;

        //this function describes the first order differential equation
        static double dydt(double t, double y) => (Math.Pow(y, 2) + 2 * t * y) / (3 + Math.Pow(t, 2));
        static void Main(string[] args)
        {
            Console.WriteLine("The given ordered pairs are of t and y respectively");
            EulerMethod();
            Console.ReadKey();
        }
        //dont change these two functions
        static void EulerMethod(double t = initialT, double y = initialY)
        {
            Console.WriteLine($"{t} , {y}");

            if (t > finalT)
                return;

           
            EulerMethod(t + dt, y+ dydt(t,y)*dt);
        }
    }
}
