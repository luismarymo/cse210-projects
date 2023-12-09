using System.Runtime.CompilerServices;
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

    //list for possible location items
    private List<string> _libraryItems = new List<string>{"Dark Arts Book", "Cat Care Book", "Romance Book"};
    private List<string> _StoreItems = new List<string>{"Treat", "Cat Toy", "Bottled Water"};

    public Game(Player player)
    {
        _player = player;
    }

    public void Run()
    {
        string option = "";
        while (option != "5")
        {
            //display menu options
            Console.WriteLine("What will you do now?");
            Console.WriteLine("  1. Go to the libary");
            Console.WriteLine("  2. Go to the store");
            Console.WriteLine("  3. Go to the park");
            Console.WriteLine("  4. View stats");
            Console.WriteLine("  5. Quit game\n");

            Console.Write("> ");
            option = Console.ReadLine();

            Console.WriteLine("");

            //depending on the location chosen, set the player location and give an intruduction. 
            //if there are items to collect in the location, randomize them and add them to the user's inventory
            //then spawn a cat using the corresponding list
            if (option == "1")
            {
                _player.SetLocation("Library");
                Console.WriteLine("Welcome to the library! Here you can find interesting books to read and widen your knowledge!\n");

                string item = randomizer.GetRandom(_libraryItems);
                Console.WriteLine($"You decide to read a {item}\n");

                //if the item is a cat care book and the user doesn't have one already in the inventory, have them level up
                if (item == "Cat Care Book" && !_player.GetInventory().Contains("Cat Care Book"))
                {
                    _player.ModifyLevel(1);
                }

                _player.AddInventoryItem(item);

                SpawnCat(_libraryCats);
            }

            else if (option == "2")
            {
                _player.SetLocation("Store");
                Console.WriteLine("Welcome to the store! What will you buy today?\n");

                string item = randomizer.GetRandom(_StoreItems);
                Console.WriteLine($"The {item} is on sale! You decide to buy it\n");

                //if the item is a cat toy and the user doesn't have one already in the inventory, have them level up
                if (item == "Cat Toy" && !_player.GetInventory().Contains("Cat Toy"))
                {
                    _player.ModifyLevel(1);
                }

                _player.AddInventoryItem(item);

                SpawnCat(_storeCats);
            }

            else if (option == "3")
            {
                _player.SetLocation("Park");
                Console.WriteLine("Welcome to the park! The fresh air and beautiful scenary are always good for the mind.\n");

                SpawnCat(_parkCats);
            }

            else if (option == "4")
            {
                //use the getinfo player method to display player information
                _player.GetInfo();
            }

            else if (option == "5")
            {   
                //user has choosen to quit 
                continue;
            }

            else //invalid input
            {
                Console.WriteLine("Invalid choice.\n");
            }
        }
    }

    private void SpawnCat(List<string> possibleCats)
    {
        //randomize the type of cat to spawn from a given list
        string typeOfCat = randomizer.GetRandom(possibleCats);

        if (typeOfCat == "Calico")
        {
            Console.WriteLine("Look who is around: A Calico Cat!\n");
            CalicoCat cat = new CalicoCat(_player);
            _player.AdoptCat(cat);
        }

        else if (typeOfCat == "Orange")
        {
            Console.WriteLine("To your left: An Orange Cat!\n");
            OrangeCat cat = new OrangeCat(_player);
            _player.AdoptCat(cat);
        }

        else if (typeOfCat == "Black")
        {
            Console.WriteLine("A shadow darts across your vision: It's a Black Cat!\n");
            BlackCat cat = new BlackCat(_player);
            _player.AdoptCat(cat);
        }

        else if (typeOfCat == "Feral")
        {
            Console.WriteLine("Careful with the claws: Here is a Feral Cat!\n");
            FeralCat cat = new FeralCat(_player);
            _player.AdoptCat(cat);
        }

        else //type of cat is "none", therefore no cat showed up
        {
            Console.WriteLine("It seems like there are no cats around today...\n");
        }
    }
}