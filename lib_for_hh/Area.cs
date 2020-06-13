using System;

namespace lib_for_hh
{
    public class Area
    {
        public double areaRound(double radius)
            {
                double S = Math.PI*Math.Pow(radius,2);
                return S;
            }
        public double areaTriangle(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            if (a > b && a > c && (Math.Pow(a,2) ==( Math.Pow(b, 2)+ Math.Pow(c, 2))))
            {
                Console.WriteLine("Прямоугольный");
            }
            else if(b > a && b > c && (Math.Pow(b, 2) == (Math.Pow(a, 2) + Math.Pow(c, 2))))
            {
                Console.WriteLine("Прямоугольный");
            }
            else if (c > a && c > b && (Math.Pow(c, 2) == (Math.Pow(a, 2) + Math.Pow(b, 2))))
            {
                Console.WriteLine("Прямоугольный");
            }
            return S;
           
        }
    }
}
