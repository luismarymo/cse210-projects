public class Player
{
    private string _name;
    private int _lvl;
    private string _location;

    //lists for cats adopted and inventory
    private List<Cat> _cats = new List<Cat>();
    private List<string> _inventory = new List<string>();

    public Player(string name)
    {
        _name = name;
        _lvl = 0;
    }

    public int GetLevel()
    {
        return _lvl;
    }

    public void SetLocation(string location)
    {
        _location = location;
    }

    public string GetLocation()
    {
        return _location;
    }

    public void AdoptCat(Cat cat)
    {
        if (cat.CanAdopt())
        {
            _cats.Add(cat);
            Console.WriteLine("Cat adopted!");
            //set name
        }
        
        else
        {
            Console.WriteLine("Oh no! It seems like you cannot adopt this cat.");
        }
    }

    public bool FindItem(string item)
    {
        return _inventory.Contains(item);
    }

    public void GetInfo()
    {
        Console.WriteLine($"Player '{_name}' information:");
        Console.WriteLine($"Level: ");
        Console.WriteLine($"Number of cats adopted: {_cats.Count}");

        Console.Write("\nDo you want to view the cat's information? (y/n) ");
        string response1 = Console.ReadLine();

        if (response1.ToLower() == "y")
        {
            foreach (Cat cat in _cats)
            {
                Console.WriteLine("");
                Console.WriteLine(cat.GetInfo());
            }
        }

        Console.WriteLine($"Number of items in inventory: {_inventory.Count}");
        Console.Write("Do you want to items in the inventory? (y/n) ");

        string response2 = Console.ReadLine();

        if (response2.ToLower() == "y")
        {
            foreach (string item in _inventory)
            {
                Console.WriteLine(item);
            }
        }
    }
}