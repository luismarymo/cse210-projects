public abstract class Cat
{
    //attributes for name, description and date adopted
    protected string _name;
    protected string _description;
    protected string _dateAdopted;

    protected Player _owner;

    public Cat(Player owner)
    {
        _owner = owner;
    }
    
    public void SetName()
    {
        //prompts the user for a name
        Console.Write("Enter the name of your cat: ");
        _name = Console.ReadLine();
    }

    public string GetDescription()
    {
        return _description;
    }

    public virtual string GetInfo()
    {
        return $"Name: {_name}\n{_description}\n{_dateAdopted}";
    }

    public abstract bool CanAdopt();
}