using System.Runtime.CompilerServices;

public class Player
{
    //attributes for name, level and location
    private string _name;
    private int _lvl;
    private string _location;

    //lists for cats adopted and inventory
    private List<Cat> _cats = new List<Cat>();
    private List<string> _inventory = new List<string>();

    public Player(string name)
    {
        _name = name;
        _lvl = 0; //default to 0
    }

    public void ModifyLevel(int number)
    {
        //modifies the player level by a given number
        _lvl += number;
        Console.WriteLine($"!! Your current level has been modified by {number}. You are now on level {_lvl}.\n");
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

    public List<string> GetInventory()
    {
        return _inventory;
    }

    public void AdoptCat(Cat cat)
    {
        //displays the cat description and asks the user if they wish to attempt to adopt the given cat
        Console.WriteLine(cat.GetDescription());
        Console.Write("Do you wish to attempt to adopt this cat? (y/n) ");
        string response = Console.ReadLine();

        Console.WriteLine("");

        if (response.ToLower() == "y")
        {
            //use the cat method canadopt to check if the user meets the requirements for adoption
            //if they do, prompt for a name and set adoption date
            if (cat.CanAdopt())
            {
                cat.SetName();
                cat.SetDate();

                _cats.Add(cat);
                Console.WriteLine("Cat adopted!\n");
                
                //if user adopts 1, 5 or 10 cats, they level up by 1
                if (_cats.Count == 1 || _cats.Count == 5 || _cats.Count == 10)
                {
                    ModifyLevel(1);
                }
            }
            
            else 
            {
                Console.WriteLine("Oh no! It seems like you cannot adopt this cat.\n");
            }
        }
    }

    public void AddInventoryItem(string item)
    {
        //adds item to inventory
        _inventory.Add(item);
    }

    public void GetInfo()
    {
        //displays player information and asks they user if they wish to see details about cats adopted and inventory items
        Console.WriteLine($"Player '{_name}' information:");
        Console.WriteLine($"Level: {_lvl}");
        Console.WriteLine($"Number of cats adopted: {_cats.Count}\n");

        Console.Write("Do you want to view the cats' information? (y/n) ");
        string response1 = Console.ReadLine();

        Console.WriteLine("");

        if (response1.ToLower() == "y")
        {
            foreach (Cat cat in _cats)
            {
                Console.WriteLine(cat.GetInfo());
            }
        }

        Console.WriteLine($"Number of items in inventory: {_inventory.Count}");
        Console.Write("Do you want to view the items in the inventory? (y/n) ");
        string response2 = Console.ReadLine();

        Console.WriteLine("");

        if (response2.ToLower() == "y")
        {
            foreach (string item in _inventory)
            {
                Console.WriteLine($"- {item}");
            }
        }

        Console.WriteLine("");
    }
}