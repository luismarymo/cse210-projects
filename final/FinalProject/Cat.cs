public abstract class Cat
{
    DateTime currentTime = DateTime.Now;

    //attributes for name, description, date adopted and possible owner
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

        Console.WriteLine("");
    }

    public void SetDate()
    {
        _dateAdopted = currentTime.ToString("dd/MM/yyyy hh:mm tt");
    }

    public string GetDescription()
    {
        return _description;
    }

    public virtual string GetInfo()
    {
        //returns cat information. to be overriden for cats with extra information
        return $"Name: {_name}\n{_description}Date Adopted: {_dateAdopted}\n";
    }

    public abstract bool CanAdopt();
}