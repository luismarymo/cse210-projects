using System.Runtime.InteropServices;

public class FeralCat : Cat
{
    private int _attemps;

    public FeralCat(Player owner) : base(owner)
    {
        _attemps = 0;
        _description = "\nAdoption:";
    }

    public override string GetInfo()
    {
        return $"Name: {_name}\nAttemps until adoption: {_attemps}\n{_description}\n{_dateAdopted}";
    }

    public override bool CanAdopt()
    {
        for (int i = 0; i > 3; i++)
        {
            //
        }

        return true;
    }
}