using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            string strPlayerName;
            double dblHits, dblAtBats;
            double dblBattingAverage;
            
            int an1, an2;
            double sum, difference, product, quotient;

            
            Console.WriteLine("This program calucaltes a beseball player batting average");
            Console.WriteLine("");
            Console.WriteLine("Enter the player's name: ");
            strPlayerName = Console.ReadLine();


            Console.WriteLine("Enter the players # of hit:  ");
            dblHits = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter thre player's # of at bats: ");
            dblAtBats = Convert.ToDouble(Console.ReadLine());

            dblBattingAverage = dblHits / dblAtBats;

            Console.WriteLine(strPlayerName + "\'s batting average is " + dblBattingAverage);
            Console.ReadLine();
            

            Console.WriteLine("give me a #???");
            an1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give me another #??");
            an2 = Convert.ToInt32(Console.ReadLine());

            sum = an1 + an2;
            difference = an1 - an2;
            product = an1 * an2;
            quotient = (double)an1 / an2;

            Console.WriteLine("the first number you have giving is " + an1 + "\n and the second number you have given me is " + an2 + " \n the sum of these numbers are? " + sum  + " \n the difference is " + difference +  " \n the product is "+product+ "\n the quotient is " + quotient);
            Console.ReadLine();


        }
    }
}
