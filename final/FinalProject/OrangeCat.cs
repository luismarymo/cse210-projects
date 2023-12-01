using System.Buffers;

public class OrangeCat : Cat
{
    public OrangeCat(Player owner) : base(owner)
    {
        _description = "\nAdoption:";
    }

    public override bool CanAdopt()
    {
        if (_owner.GetLevel() >= 3)
        {
            return true;
        }

        else
        {
            return _owner.FindItem("Treat");
        }
    }
}