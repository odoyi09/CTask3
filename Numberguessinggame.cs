
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xyz
{
    class Program
    {
        static void Main(string[] args)
        {
            string level = "";
            int secretNum = Newnum(1,11);
            int secretNum2 = Newnum(1,21);
            int secretNum3 = Newnum(1,51);
            int count = 0;
            int guessLimit = 6;
            int guessLimit2 = 4;
            int guessLimit3 = 3;


            while (true)
            {
                if (count < guessLimit)
                if (count < guessLimit2)
                if (count < guessLimit3)
                {

                   Console.WriteLine("Please Enter level; Easy, Medium or Hard: ");
                   level = Console.ReadLine();

                   Console.Write("Easy Level! Enter a number between 1 and 10 (0 to quit): "); 
                   Console.WriteLine();

                   Console.Write("Medium Level! Enter a number between 1 and 21 (0 to quit): ");
                   Console.WriteLine();

                   Console.Write("Hard Enter! a number between 1 and 51 (0 to quit): ");
                   Console.WriteLine();

                   int input= Convert.ToInt32(Console.ReadLine()); 
                   if (input == 0)
                   return;
                   
                   else if (input < secretNum)
                   {
                       Console.WriteLine("you guess wrong, try again");
                       ++count;
                       continue;
                   }

                else if (input > secretNum)
                 {
                       Console.WriteLine("you guess wrong, try again");
                       ++count;
                       continue;
                   }

                else if (input < secretNum2)
                {
                    Console.WriteLine("you guess wrong, try again");
                       ++count;
                       continue;
                } 

                else if (input > secretNum2)
                {
                    Console.WriteLine("you guess wrong, try again");
                       ++count;
                       continue;
                }

                else if (input < secretNum3)
                {
                    Console.WriteLine("you guess wrong, try again");
                       ++count;
                       continue;
                }
                else if (input > secretNum3)
                {
                    Console.WriteLine("you guess wrong, try again");
                       ++count;
                       continue;
                }
                else
                {
                    Console.WriteLine("you got it right! The number was {0}! ", secretNum);
                    Console.WriteLine("you got it right! The number was {0}! ", secretNum2);
                    Console.WriteLine("you got it right! The number was {0}! ", secretNum3);
                    Console.WriteLine("it took you {0} {1}.\n", count == 0 ? "try" : "tries");


                  break;

                }

                }
              
            }
        }
            static int Newnum (int min, int max)
            {
                Random random = new Random ();
                return random.Next (min, max);

                
            
        }
    }
}
