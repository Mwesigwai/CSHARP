using System;
using projLib;
string retry;

do
{
    Console.WriteLine("Rolling dice game");
    Class1.RollDice();
    System.Console.WriteLine("Restart?");
    retry = Console.ReadLine();
}while(retry == "yes");