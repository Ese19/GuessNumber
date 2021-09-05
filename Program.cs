using System.Reflection.Emit;
using System.Data;
using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            string difficulty = "";
            Console.WriteLine("Select a difficulty(easy / intermediate / hard):");
            difficulty = Console.ReadLine();

            if(difficulty == "easy")
            {
                int randomNum = rd.Next(1, 10);

                for(int i = 0; i < 6; i++)
                {
                    int num;
                    Console.WriteLine("Guess a number from 1 to 10: ");
                    num = int.Parse(Console.ReadLine());

                    if(num == randomNum)
                    {
                        Console.WriteLine("Correct!!");
                        break;
                    }
                    else
                    {
                        if(i >= 5){
                            Console.WriteLine("Time's up, You Lost.");
                        }
                        continue;
                    }
                }

            }

            else if (difficulty == "intermediate")
            {
                int randomNum = rd.Next(1, 20);

                for(int i = 0; i < 4; i++)
                {
                    int num;
                    Console.WriteLine("pick a number from 1 to 20: ");
                    num = int.Parse(Console.ReadLine());

                    if(num == randomNum)
                    {
                        Console.WriteLine("Correct!!");
                        break;
                    }
                    else
                    {
                        if(i >= 3){
                            Console.WriteLine("Time's up, You Lost.");
                        }
                        continue;
                    }
                }
            }

            else if(difficulty == "hard")
            {
                int randomNum = rd.Next(1, 50);

                for(int i = 0; i < 3; i++)
                {
                    int num;
                    Console.WriteLine("pick a number from 1 t0 50: ");
                    num = int.Parse(Console.ReadLine());

                    if(num == randomNum)
                    {
                        Console.WriteLine("Correct!!");
                        break;
                    }
                    else
                    {
                        if(i >= 2){
                            Console.WriteLine("Time's up, You Lost.");
                        }
                        continue;
                    }
                }
            }

            else
            {
                Console.WriteLine("GoodBye!");
            }
        }
    }
}
