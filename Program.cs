using System;
using System.Collections.Generic;
using System.Linq;



int SecretNum = new Random().Next(1, 100);
int NumOfGuess = 0;
int NumOfGuessesLeft = 0;
bool CheatCode = false;
Console.WriteLine("                        ");
Console.WriteLine("It's the 'Guess the secret number game!'");
Console.WriteLine("                        ");
Console.WriteLine("Choose your skill level \n0-Cheaters Are Always Zeros\n1-Your Mom Says Your Good At Games \n2-Easy Street \n3-YOLO \n4-Hold My Beer");
int SkillSelection = Convert.ToInt32(Console.ReadLine());
SkillLevel();
Console.WriteLine("And your guess is...\n");
int UsersGuess = Convert.ToInt32(Console.ReadLine());
NumOfGuessesLeft--;

void SkillLevel()
{
    if (SkillSelection == 0)
    {
        CheatCode = true;
    }
    else if (SkillSelection == 1)
    {
        NumOfGuessesLeft = 8;
    }
    else if (SkillSelection == 2)
    {
        NumOfGuessesLeft = 6;
    }
    else if (SkillSelection == 3)
    {
        NumOfGuessesLeft = 4;
    }
    else if (SkillSelection == 4)
    {
        NumOfGuessesLeft = 1;
    }
}
void Hint()
{
    if (UsersGuess == SecretNum)
    {
        Console.WriteLine("Right On!");
    }
    else if (UsersGuess < SecretNum)
    {
        Console.WriteLine("Your guess was too low");
    }
    else
    {
        Console.WriteLine("Your guess was too high");

    }

}

while (NumOfGuessesLeft > 0 || CheatCode == true)
    if (UsersGuess == SecretNum && CheatCode == false)
    {
        Console.WriteLine(" \n You guessed correctly! \n Congratulations, YOU WON!!");
        break;
    }
    else if (UsersGuess == SecretNum && CheatCode == true)
    {
        Console.WriteLine(" \n A completely worthless win \n PTUI!");
        break;
    }
    else if (NumOfGuessesLeft == 7 || NumOfGuessesLeft == 4)
    {
        NumOfGuess++;
        int CurrentGuess = NumOfGuess + 1;
        Console.WriteLine("\nOh no, thats not right");
        Hint();
        Console.WriteLine($"\nYou're now on guess number ({CurrentGuess})");
        Console.WriteLine($"{NumOfGuessesLeft} guesses left");
        Console.WriteLine("\nTry again\n");
        UsersGuess = Convert.ToInt32(Console.ReadLine());
        NumOfGuessesLeft--;

    }
    else if (NumOfGuessesLeft == 6 || NumOfGuessesLeft == 3)
    {
        NumOfGuess++;
        int CurrentGuess = NumOfGuess + 1;
        Console.WriteLine(" \n psshh... \nWhere'd you learn to Guess?");
        Hint();
        Console.WriteLine($"\nYou're now on guess number ({CurrentGuess})");
        Console.WriteLine($"{NumOfGuessesLeft} guesses left");
        Console.WriteLine("\nAgain\n");
        UsersGuess = Convert.ToInt32(Console.ReadLine());
        NumOfGuessesLeft--;
    }
    else if (NumOfGuessesLeft == 5 || NumOfGuessesLeft == 2 || NumOfGuessesLeft == 1)
    {
        NumOfGuess++;
        int CurrentGuess = NumOfGuess + 1;
        Hint();
        Console.WriteLine("Not even in the ballpark \nGood thing this ain't vegas!");
        Console.WriteLine($"\nYou're now on guess number ({CurrentGuess})");
        Console.WriteLine($"{NumOfGuessesLeft} guesses left");
        Console.WriteLine("\n Again??\n");
        UsersGuess = Convert.ToInt32(Console.ReadLine());
        NumOfGuessesLeft--;
    }
    else if (CheatCode == true)
    {
        NumOfGuess++;
        int CurrentGuess = NumOfGuess + 1;
        Console.WriteLine($"\nYou're now on guess number ({CurrentGuess})");
        Hint();
        Console.WriteLine("Why don't you just give up! \nYou Suck!");
        Console.WriteLine("\n Again, Again, Loser?\n");
        UsersGuess = Convert.ToInt32(Console.ReadLine());

    }
    else
    {
        Hint();
        Console.WriteLine("You failed miserably! \n Thanks for playing!");
        break;
    }








