using Microsoft.VisualBasic;

public class Randomizer
{
    Random random = new Random();

    public string GetRandom(List<string> strings)
    {
        int i = random.Next(strings.Count);
        return strings[i];
    }
}