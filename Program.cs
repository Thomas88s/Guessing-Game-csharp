using System;
using System.Collections.Generic;
using System.Linq;

namespace Gussing_Game_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int UsersGuess = Convert.ToInt32(Console.ReadLine());
            int SecretNum = 49;
            int NumOfGuess = 0;

            Console.WriteLine("                        ");
            Console.WriteLine("It's the guess the secret number game!");
            Console.WriteLine("                        ");

            Console.WriteLine("Wanna take a guess?");
            if (UsersGuess == SecretNum)
            {
                Console.WriteLine(" \n You guessed correctly!");
            }
            while (NumOfGuess < 3)
            {

                if (NumOfGuess == 0)
                {
                    NumOfGuess++;
                    Console.WriteLine("On no, thats not right \n Try again \n");
                    UsersGuess = Convert.ToInt32(Console.ReadLine());
                }
                else if (NumOfGuess == 1)
                {
                    NumOfGuess++;
                    Console.WriteLine("psshh... \n Where'd you learn to Guess? \n Again");
                    UsersGuess = Convert.ToInt32(Console.ReadLine());
                }
                else if (NumOfGuess == 2)
                {
                    NumOfGuess++;
                    Console.WriteLine("Not even in the ballpark \n Good thing this ain't vegas! \n Again?? ");
                    UsersGuess = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("You failed miserably! \n Thanks for playing!");
                    break;
                }


            }
        }

    }
}

