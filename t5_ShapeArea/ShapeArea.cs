using System;

namespace t5_ShapeArea
{
    class ShapeArea
    {
        static void Main(string[] args)
        {
            double inpNum = int.Parse(Console.ReadLine());
            Console.WriteLine(ShapeArea.ShpAr(inpNum));
        }

        static double ShpAr(double n)
        {
            return Math.Pow(n, 2) + Math.Pow(n - 1, 2);
        }
    }
}
