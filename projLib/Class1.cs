namespace projLib;
public class Class1
{
    public static void RollDice()
    {
        Random randomDiceNum = new Random();
        int randomNum = randomDiceNum.Next(1,6);
        Console.WriteLine("You rolled number: " + randomNum);
    }
}
