namespace Mission2Assignment;

public class RollDice
{
    private int numRolls = 0;
    private int[] combinations = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
    private int roll = 0;
    Random rnd = new Random();

    public RollDice(int numRolls)
    {
        this.numRolls = numRolls;
    }

    public int[] rollDice()
    {
        for (int i = 0; i < this.numRolls; i++)
        {
            roll = rnd.Next(1, 7) + rnd.Next(1, 7);

            this.combinations[roll - 2]++;
        }
        
        return combinations;
    }
}