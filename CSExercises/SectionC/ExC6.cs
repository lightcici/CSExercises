using System;

namespace CSExercises
{
    //Electrifying Electronics Pte Ltd. manufactures 
    //three audio-visual electronic products named 
    //as TV, DVD, and MP3.  The table below gives 
    //the unit price for each of these products:

    //PRODUCT   PRICE
    //TV	    $900
    //DVD	    $500
    //MP3	    $700

    //Retailers make orders for these products. 
    //Each order will have the product code and quantity 
    //(only one product in an order).  The company has a policy 
    //that discount of 10% is given when the order amount exceeds 
    //$5000 and 15% discount when the order amount exceeds $10000.  
    //These discounts apply to TV and DVD only and no discount is provided for MP3.

    //Write a program that would prompt the user successively 
    //the three product codes viz., TV, DVD, MP3 and after each prompt, 
    //the user enters the order quantity for that product.  
    //Then apply the price computations.  (Obviously, if the user does not 
    //wish to order the item prompted he/she would enter a zero for the order quantity).

    public class ExC6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many TV do you want to order?");
            int tvQty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many DVD do you want to order?");
            int dvdQty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many MP3 do you want to order?");
            int mp3Qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CalculateTotalPrice(tvQty, dvdQty, mp3Qty));



        }

        public static double CalculateTotalPrice(int tvQty, int dvdQty, int mp3Qty)
        {
            double sum = 0;
            double sumTvDvd = 900 * tvQty + 500 * dvdQty;
            if (sumTvDvd <= 5000)
            {
                sum = sumTvDvd + 700 * mp3Qty;
            }
            else if (sumTvDvd > 5000 && sumTvDvd <= 10000)
            {
                sum = 0.9*sumTvDvd + 700 * mp3Qty;
            }
            else if(sumTvDvd > 10000)
            {
                sum = 0.85*sumTvDvd + 700 * mp3Qty;
            }
            return sum;

        }
    }
}