using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Random random = new Random();
           // bool isthere = true;
            int userGuess;
            int revealDoor = 0;
            int didntSwitch=0;
            int didSwitch =0;
            
           
            


            for (int i = 0; i <10000; i++)
            {

                   bool[] doors = { false, false, false };
                

                userGuess = random.Next(0, 3);
                doors[i % 3] = true;

                for (int n = 0; n < doors.Length; n++)
                {


                    if (doors[n] == false && n != userGuess)
                    {

                        revealDoor = n;
                        

                    }


                   


                }
                

                


               if(doors[userGuess])
                {

                    didntSwitch++;


                }



                
                

                    for (int w = 0; w < doors.Length; w++)
                    {

                        if (w != userGuess && w != revealDoor)
                        {
                            userGuess = w;

                        }




                    }

                    if (doors[userGuess])
                    {
                        didSwitch++;

                    }



                   

                

            }



            Console.WriteLine("you have gotten it incorrect " + didntSwitch + " if you didn't switch and have gotten it correct " + didSwitch + " if you did switch");
            Console.ReadLine();




        }





    }
}
