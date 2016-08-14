using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that reads the (x,y) coordinates 
    //of two points.  Compute the distance between the 
    //two points using the formula:

    //  Distance = Square Root of[(x2 – x1 ) 2 + (y2 – y1 ) 2]

    public class ExB6
    {
        public static void Main(string[] args)
        {
            String x1String = Console.ReadLine();
            String y1String = Console.ReadLine();
            String x2String = Console.ReadLine();
            String y2String = Console.ReadLine();
            double x1 = Convert.ToDouble(x1String);
            double y1 = Convert.ToDouble(y1String);
            double x2 = Convert.ToDouble(x2String);
            double y2 = Convert.ToDouble(y2String);
            Console.WriteLine(CalculateDistance(x1, y1, x2, y2));


        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
        }
    }
}
