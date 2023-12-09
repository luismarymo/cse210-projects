using System.Net;
using System.Runtime.InteropServices;

public class FeralCat : Cat
{
    Random random = new Random(); 
    private int _attempts; //attempts until adoption

    public FeralCat(Player owner) : base(owner)
    {
        //set the attempts to 0
        _attempts = 0;
        _description = "The feral cats are misunderstood little guys. They have had a rough life, so they are wary and careful around strangers, understandably so.\nAdoption: It is only through a stroke of luck that a feral cat will allow themselves to be tamed. Are you willing to take the risk of getting scratched?\n";
    }

    public override string GetInfo()
    {
        //override getinfo to display n of attempts
        return $"Name: {_name}\nAttemps until adoption: {_attempts}\n{_description}Date Adopted: {_dateAdopted}\n";
    }

    public override bool CanAdopt()
    {
        string response;
        do
        {
            //add 1 to the attemps on every iteration
            _attempts++;

            //ensure the user wants to try again
            Console.Write($"This is attempt {_attempts}. Are you sure you wish to try to adopt this cat? (y/n) ");
            response = Console.ReadLine();

            Console.WriteLine("");

            if (response.ToLower() == "n")
            {
                break; //loop out
            }

            //get a random number from 1 to 100. if it's lower or equal to 30, return true (30% probability)
            int chance = random.Next(1,101);
            if (chance <= 30)
            {
                return true; 
            }

            else
            {
                Console.WriteLine("You were unsuccessfull.\n");

                //if the user tried 3 times and was unsuccesfull, they level down by 1
                if (_attempts == 3)
                {
                    Console.WriteLine("The Feral Cat has grown tired of you bothering it, so it scratched you!");
                    _owner.ModifyLevel(-1);
                }
            }

        } while (response.ToLower() == "y" && _attempts < 3);

        return false;
    }
}