using System;

namespace CSExercises
{
    //Given a three-digit integer as input write a C# program 
    //to determine whether the number is an Armstrong number.
    //
    //An Armstrong number is one for which the sum of each digit 
    //raised to the power of number of digits results in the number itself.
    //
    //For a three digit number 153 =  13 + 53 + 33  
    //
    //Confine the input to 3 digit examples only ie., number values 100…999.


    public class ExC5
    {
        public static void Main(string[] args)
        {
            String inputString = Console.ReadLine();
            int input = Convert.ToInt32(inputString);
            if (IsArmstrongNumber(input) == true)
            {
                Console.WriteLine("Armstrong number");
            }
            else Console.WriteLine("Not armstrong number");

        }


        public static bool IsArmstrongNumber(int n)
        {
            int sum = (int)(Math.Pow(n % 10, 3) + Math.Pow(n/10 % 10, 3) + Math.Pow(n / 100 % 10, 3));
            if (sum == n)
            {
                return true;
            }
            else return false;
          

        }
    }
}