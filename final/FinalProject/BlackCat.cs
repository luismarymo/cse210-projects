public class BlackCat : Cat
{
    Random random = new Random();

    private int _magicLvl;

    public BlackCat(Player owner) : base(owner)
    {
        //randomize the magic level when creating the instance
        _magicLvl = random.Next(1,4);
        _description = $"The black cat is mysterious and mystical. Not evil like the old tales want you to believe, they are a great companion to those who appreciate the occult.\nAdoption: Black cats have only one requirement; be as knowledgeable as them in the dark arts!\nThis cat's magic level: {_magicLvl}\n";
    }

    public override bool CanAdopt()
    {
        //if user is above certain level, always return true
        if (_owner.GetLevel() >= 3)
        {
            return true;
        }

        else
        {
            int counter = 0;

            //check the player's inventory to match specific string and add 1 to the counter when they do
            foreach (string item in _owner.GetInventory())
            {
                if (item == "Dark Arts Book")
                {
                    counter++;
                }
            }

            //compare the counter to the magic level and return true if they are the same
            if (counter >= _magicLvl)
            {
                _owner.ModifyLevel(1);
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}