public class Randomizer
{
    Random random = new Random();

    public string GetRandom(List<string> strings)
    {
        //returns a random string from a list
        int i = random.Next(strings.Count);
        return strings[i];
    }
}