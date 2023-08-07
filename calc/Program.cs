using System;
using projLib;

string retry;
Class1.AskUserTheirName();

do
{
    Console.WriteLine("Rolling dice game");
    Class1.RollDice();
    System.Console.WriteLine("Roll again?");
    retry = Console.ReadLine();
}while(retry == "yes");

System.Console.WriteLine("hello.......................");