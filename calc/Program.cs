using System;
using projLib;

string retry;
string userChoice;
Class1.AskUserTheirName();
do
{
    Console.WriteLine("Rolling dice game");
    Class1.RollDice();
    System.Console.WriteLine("Roll again?");
    retry = Console.ReadLine();
    if(retry == "n")
        {
            do{
                System.Console.WriteLine("print random names? now?");
                userChoice = Console.ReadLine();
                Class1.RandomWords();
            }while(userChoice == "y");
        }
}while(retry == "yes");



