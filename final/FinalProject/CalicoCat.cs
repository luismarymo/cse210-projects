public class CalicoCat : Cat
{
    public CalicoCat(Player owner) : base(owner)
    {
        _description = "The calico cat is truly the friendliest of them all, they love cuddles and pets. With their easy going personality, anyone can be their friend!\nAdoption: Calico cats love people! They'd love an owner, except those that live in the library; they already have a family!";
    }

    public override bool CanAdopt()
    {
        if (_owner.GetLocation() != "Library")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}