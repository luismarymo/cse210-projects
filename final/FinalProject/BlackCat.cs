public class BlackCat : Cat
{
    Randomizer randomizer = new Randomizer();
    private int _magicLvl;

    private List<string> _possibleLvls = new List<string>{"1", "2", "3"};

    public BlackCat(Player owner) : base(owner)
    {
        _magicLvl = int.Parse(randomizer.GetRandom(_possibleLvls));
        _description = "\nAdoption:";
    }

    public override string GetInfo()
    {
        return $"Name: {_name}\nMagic Level: {_magicLvl}\n{_description}\n{_dateAdopted}";
    }

    public override bool CanAdopt()
    {
        if (_owner.GetLevel() >= 3)
        {
            return true;
        }

        else
        {
            int counter = 0;
            for (int i = 0; i < _magicLvl; i++)
            {
                if (_owner.FindItem("Dark Arts Book"))
                {
                    counter++;
                }
            }

            if (counter == _magicLvl)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}