using System;
using MathNet.Numerics;

namespace Test_LinearRegression
{
    class Program
    {
        static void Main(string[] args)
        {
            testA();
            testB();
            Console.ReadLine();
        }

        static void testA()
        {
            double[] xdata = new double[] { 10, 20 };
            double[] ydata = new double[] { 0, 1 };

            var p = (Fit.Line(xdata, ydata));
            double a = p.Item1; 
            double m = p.Item2; 
            Console.WriteLine($"y = {m}x+{a}");
        }
    
    static void testB()
    {
        double[] xdata = new double[] { 20, 30 };
        double[] ydata = new double[] { 1, 0 };

        var p = (Fit.Line(xdata, ydata));
        double a = p.Item1; 
        double m = p.Item2; 
        Console.WriteLine($"y = {m}x+{a}");
    }
}
}