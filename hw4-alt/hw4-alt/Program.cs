using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4_alt
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int passingYards =0, passingTouchdown =0, passingInteceptions =0, rushingYards =0, rushingTouchdowns, receptions, receivingYards =0, receivingTouchdowns;
            int userYards, userPass, userInterception, userRushYards, userRushTouchdowns, userReception, userReceivingYards, userReceivingTouchdown;

            Console.WriteLine("What are the amount yards by passing ");
            userYards = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("What are the amount yards rushing ");
            userRushYards = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("How many touchdowns were made with a pass ");
            userPass = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many Interceptions were made ");
            userInterception = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many Touchdowns were made by rushing touchdowns");
            userRushTouchdowns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many recptions were made ");
            userReception = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many touchdowns were made by receiving ");
            userReceivingTouchdown = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many Yards were made by receiving ");
            userReceivingYards = Convert.ToInt32(Console.ReadLine());


            passingTouchdown = userPass * 4;
                 passingInteceptions = userInterception * 2;
                 rushingTouchdowns = userRushTouchdowns * 6;
                 receptions = userReception * 1;
                 receivingTouchdowns = userReceivingTouchdown * 6;




              if (userYards > 25)
              {

                 userYards /= 25;

                  passingYards= userYards;


              }

      

            if (userRushYards > 10)
            {

                for (int i = userRushYards; i > 10; i -= 10)
                {
                    
                    
                    rushingYards++;
                }

               
               
            }

    

            if (userReceivingYards > 10)
            {

                userReceivingYards = userReceivingYards /= 10;



                receivingYards = userReceivingYards;
            }


           




            Console.WriteLine("You got " + passingYards + " points for Passing" + "\n You got " + rushingYards+ " points for rushing" + "\n You got "+ userPass + " points for passing" + "\n You lost " +userInterception + "from Inteception"
                + "\n You got "+ userRushTouchdowns+ " points for Rushing in for a touchdown"+ "\n You got "+ userReception+ " points from reception" + "\n You got " + userReceivingYards + "points from Yards reciving"  );
            Console.ReadLine();
            */

            /*

            double att =0, comp =0, yds =0, td=0, inter=0, passer;

            double a, b, c, d;

          


            Console.WriteLine("How many attempts where made by the qb");
            att = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many completions where made by the qb");
            comp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many passing yards where made by the qb");
            yds = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many touchdown passes where made by the qb");
            td = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many interceptions where made by the qb");
            inter = Convert.ToDouble(Console.ReadLine());

  a = (comp / att - .3) * 5;
            b = (yds / att - 3) * .25;
            c = (td / att) * 20;
            d = 2.375 - (inter / att * 25);
            passer = ((a + b + c + d) / 6) * 100;





            if (a > 2.375)
            {
                a = 2.375;
            }

            else if(a < 0)
            {
                a = 0;
            }

          


            if (b > 2.375)
            {
                b = 2.375;
            }

            else if (b < 0)
            {
                b = 0;
            }

           


            if (c > 2.375)
            {
                c = 2.375;
            }

            else if (c < 0)
            {
                c = 0;
            }



            Console.WriteLine("Your qb rating is " + passer);
            Console.ReadLine();

            */



            /*

            Random rand = new Random();


            int correct =0;
            int wrong = 0;
            string done;
           
            int answer;

            do
            {

            int randnum = rand.Next(0, 13);

            int randnum2 = rand.Next(0, 13);
            int question = randnum * randnum2;

                Console.WriteLine("what is " + randnum + " times " + randnum2);
                answer = Convert.ToInt32(Console.ReadLine());

                if (answer == question)
                {
                    correct++;
                    Console.WriteLine("Correct your answer " + answer + " is correct Well done");
                    Console.WriteLine(randnum + " plus " + randnum2 + " equals " + question);
                    Console.ReadLine();
                }

                else
                {


                    wrong++;
                    Console.WriteLine("That is incorrect your answer " + answer + "is wrong");
                    Console.WriteLine(randnum + " plus " + randnum2 + " equals " + question);
                    Console.ReadLine();
                }


                Console.WriteLine("To quit the quiz press e \n You have got " + correct + " correct and " + wrong + " wrong");
                done = Console.ReadLine();



            } while (done != "e");

                    */



            List<string> shopping = new List<string>();



            // variable declarations
            string strChoice = "";

            //menu loop
            while (strChoice != "4")
            {
                //main menu
                Console.WriteLine("-------Main Menu--------");
                Console.WriteLine("1.\tAdd Names to a File");
                Console.WriteLine("2.\tView Names in a File");
                Console.WriteLine("3.\tExit");
                strChoice = Console.ReadLine();


                //process choice
                switch (strChoice)
                {
                    case "1":
                        AddNames(shopping);
                        break;
                    case "2":
                        ViewNames(shopping);
                        break;
                    case "3":
                        deleteNames();
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine(strChoice + " is not a valid choice.");
                        break;
                }
            }







        }

        private static void ViewNames(List<string> view)
        {

            for (int i = 0; i < view.Count; i++)
            {

            }

            Console.WriteLine(view);
        }







        private static void deleteNames()
        {
            throw new NotImplementedException();
        }






        private static void AddNames(List<string> add)
        {

            for (int i = 0; i < add.Count; i++)
            {

            }

            string item;


        }
    }
}
