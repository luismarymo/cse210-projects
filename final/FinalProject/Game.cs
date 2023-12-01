using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Game
{
    Randomizer randomizer = new Randomizer();
    private Player _player;

    //lists for possible cats in the different locations
    private List<string> _libraryCats = new List<string>{"Calico", "Orange", "None"};
    private List<string> _parkCats = new List<string>{"Calico", "Orange", "Feral", "Black"};
    private List<string> _storeCats = new List<string>{"Calico", "Black", "None"};

    public Game(Player player)
    {
        _player = player;
    }

    public void Run()
    {
        string option = "";
        while (option != "5")
        {
            Console.WriteLine("\nWhat will you do now?");
            Console.WriteLine("  1. Go to the libary");
            Console.WriteLine("  2. Go to the store");
            Console.WriteLine("  3. Go to the park");
            Console.WriteLine("  4. View stats");
            Console.WriteLine("  5. Quit game");

            Console.Write("\n> ");
            option = Console.ReadLine();

            if (option == "1")
            {
                //instroduce the location
                _player.SetLocation("Library");
                SpawnCat(_libraryCats);
            }

            else if (option == "2")
            {
                _player.SetLocation("Store");
                SpawnCat(_storeCats);
            }

            else if (option == "3")
            {
                _player.SetLocation("Park");
                SpawnCat(_parkCats);
            }

            else if (option == "4")
            {
                _player.GetInfo();
            }

            else if (option == "5")
            {
                continue;
            }

            else //invalid input
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }

    private void SpawnCat(List<string> possibleCats)
    {
        // string typeOfCat = randomizer.GetRandom(possibleCats);

        string typeOfCat = "Calico";

        if (typeOfCat == "Calico")
        {
            CalicoCat cat = new CalicoCat(_player);

            Console.WriteLine(cat.GetDescription());

            //ask the user if they wish to adopt.
            _player.AdoptCat(cat);
        }

        else if (typeOfCat == "Orange")
        {
            OrangeCat cat = new OrangeCat(_player);
            _player.AdoptCat(cat);
        }

        else if (typeOfCat == "Black")
        {
            BlackCat cat = new BlackCat(_player);
            _player.AdoptCat(cat);
        }

        else if (typeOfCat == "Feral")
        {
            FeralCat cat = new FeralCat(_player);
            _player.AdoptCat(cat);
        }

        else //type of cat is "none", therefore no cat showed up
        {
            Console.WriteLine("It seems like there are no cats around today...");
        }
    }

    // private void SpawnCat()
    // {
    //     string location = _player.GetLocation();

    //     string typeOfCat = "";
    //     if (location == "Library")
    //     {
    //         typeOfCat = randomizer.GetRandom(_libraryCats);
    //     }

    //     else if (location == "Store")
    //     {
    //         typeOfCat = randomizer.GetRandom(_storeCats);
    //     }

    //     else if (location == "Park")
    //     {
    //         typeOfCat = randomizer.GetRandom(_parkCats);
    //     }

    //     if (typeOfCat == "Calico")
    //     {
    //         CalicoCat cat = new CalicoCat(_player);
    //         _player.AdoptCat(cat);
    //     }

    //     else if (typeOfCat == "Orange")
    //     {
    //         OrangeCat cat = new OrangeCat(_player);
    //         _player.AdoptCat(cat);
    //     }

    //     else if (typeOfCat == "Black")
    //     {
    //         BlackCat cat = new BlackCat(_player);
    //         _player.AdoptCat(cat);
    //     }

    //     else if (typeOfCat == "Feral")
    //     {
    //         FeralCat cat = new FeralCat(_player);
    //         _player.AdoptCat(cat);
    //     }

    //     else //type of cat is "none", therefore no cat showed up
    //     {
    //         Console.WriteLine("It seems like there are no cats around today...");
    //     }
    // }
}