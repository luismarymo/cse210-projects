using System.Buffers;

public class OrangeCat : Cat
{
    public OrangeCat(Player owner) : base(owner)
    {
        _description = "The orange cats are the most playful and fun of cats out there, and they'd love a new friend to play with!\nAdoption: Orange cats tend to have a big appetite; always have a treat ready for them!\n";
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
            //check inventory for treat
            return _owner.GetInventory().Contains("Treat");
        }
    }
}