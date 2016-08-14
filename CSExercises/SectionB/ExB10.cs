using System;

namespace CSExercises
{
    public class ExB10
    {
        //Consider the simple Geometric example of determining 
        //the area of a triangle, given the lengths of 
        //    its three sides a, b and c.
        //
        //Use the formula:  AREA = SQUAREROOT[s(s - a)(s - b)(s - c)]
        //                     where s = (a+b+c) / 2
        //
        //Does your program always work? If not 
        //alter it to consider situations fro which 
        //it fails.You can return a special value like -1 to 
        //indicate that you cannot calculate the area.


        public static void Main(string[] args)
        {
            String aString = Console.ReadLine();
            String bString = Console.ReadLine();
            String cString = Console.ReadLine();
            double a = Convert.ToDouble(aString);
            double b = Convert.ToDouble(bString);
            double c = Convert.ToDouble(cString);

            if (a + b >= c || a + c >= b || b + c >= a)
            {
                Console.WriteLine(CalculateArea(a, b, c));
            }
            else Console.WriteLine("NaN");

        }

        public static double CalculateArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }
    }
}