using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            int nLargest, nSmallest, nCurrent;
           string strEntry;


            Console.WriteLine("Enter an integer");
            nLargest = nSmallest = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another interger or Q to quit");
            strEntry = Console.ReadLine();


            while(strEntry != "Q")
            {
                nCurrent = Convert.ToInt32(strEntry);

                if(nCurrent > nLargest)
                {
                    nLargest = nCurrent;
                }

                else if(nCurrent < nSmallest)
                {
                    nSmallest = nCurrent;
                }


                Console.WriteLine("Enter another integer or Q to quit");
                strEntry = Console.ReadLine();

                    Console.WriteLine("The largest value you entered was " + nLargest + " .");
                    Console.WriteLine("The smallest value you entered was " + nSmallest + " .");


                            Console.ReadLine();        

            }

           
        }
    }
}
