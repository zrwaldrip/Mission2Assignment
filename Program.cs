// See https://aka.ms/new-console-template for more information
namespace Mission2Assignment;

internal class Program
{
    private static void Main(string[] args)
    {
        
        int[] combinations = new int[11];
        int[] percentages = new int[11];
        int numRolls = 0;
        
        Console.WriteLine("How many times do you want to roll the dice?");
        numRolls = int.Parse(Console.ReadLine());

        //creating an instance of the RollDice class and rolling the dice
        //it returns the array of times rolled for each number
        RollDice rd = new RollDice(numRolls);
        combinations = rd.rollDice();
        
        //Adding percentages to the percentages array
        for (int i = 0; i < combinations.Length; i++)
        {
            percentages[i] = (combinations[i] * 100 / numRolls);
        }

        //printing out the results
        Console.WriteLine("\nPrinting results for " + numRolls + " rolls");
        Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
        for (int i = 0; i < 11; i++)
        {
            string output = (i + 2) + ": ";

            for (int j = 0; j < percentages[i]; j++)
            {
                output += "*";
            }
            
            Console.WriteLine(output);
        }
    }
}