namespace projLib;
public class Class1
{
    public static void RollDice()
    {
        Random randomDiceNum = new Random();
        int randomNum = randomDiceNum.Next(1,6);
        Console.WriteLine("You rolled number: " + randomNum);
    }

    public static void AskUserTheirName()
    {
        System.Console.WriteLine("Welcome! what is your name?");
        string name = Console.ReadLine();
        System.Console.WriteLine("Hello " + name);
    }

    public static void RandomWords()
    {
        string[] randomNames ={
            "Isaac", "Jacob", "John"
        };

        Random random = new Random();
        int randomIndex = random.Next(0, 3);
            System.Console.WriteLine(randomNames[randomIndex]);
    }
}
