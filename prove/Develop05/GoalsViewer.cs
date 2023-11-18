using System.Diagnostics.Tracing;

public class GoalsViewer
{
    private List<Goal> _goals = new List<Goal>(); //list to store goals
    private int _score; //amount of points

    public void Menu()
    {
        string option = "";
        while (option != "6")
        {
            //display the score
            Console.Write("\nYou have ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(_score);
            Console.ResetColor();
            Console.WriteLine(" points.");

            //menu options
            Console.WriteLine("\nMenu Options: ");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();

            if (option == "1")
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");

                //ask for general information that all goals share, then create the instances for each type depending on the input
                Console.Write("Which type would you like to create? ");
                string goalType = Console.ReadLine();

                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                int value = int.Parse(Console.ReadLine());

                if (goalType == "1")
                {
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, value);

                    _goals.Add(simpleGoal);
                }

                else if (goalType == "2")
                {
                    EternalGoal eternalGoal = new EternalGoal(name, description, value);

                    _goals.Add(eternalGoal);
                }

                else if (goalType == "3")
                {   
                    //ask for info specific to goal type
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int checks = int.Parse(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int totalValue = int.Parse(Console.ReadLine());

                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, value, checks, totalValue);

                    _goals.Add(checklistGoal);
                }
            }

            else if (option == "2")
            {
                //list the goals using their GetGoal method
                int i = 1;
                Console.WriteLine("The goals are: ");

                foreach (Goal goal in _goals)
                {
                    Console.WriteLine($"{i}.  {goal.GetGoal()}");
                    i++;
                }
            }

            else if (option == "3" || option == "4")
            {
                //ask for file name, and then call the corresponding method for saving or loading
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();

                if (option == "3")
                {
                    SaveToFile(filename);
                }

                else
                {
                    LoadFromFile(filename);
                }
            }

            else if (option == "5")
            {
                //list only the name of the goals
                int i = 1;
                Console.WriteLine("The goals are: ");
                
                foreach (Goal goal in _goals)
                {
                    Console.WriteLine($"{i}.  {goal.GetName()}");
                    i++;
                }

                Console.Write("Which goal did you accomplish? ");
                int j = int.Parse(Console.ReadLine());
                j--; //substract 1 to match goal index in list

                //record the event for the goal and add value to current score
                int points = _goals[j].RecordEvent();
                _score += points;

                Console.Write("Congratulations! You have earned ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(points);
                Console.ResetColor();
                Console.WriteLine(" points.");
                
                Console.Write("You now have ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(_score);
                Console.ResetColor();
                Console.WriteLine(" points.");
            }

            else if (option == "6")
            {
                continue; //loop out
            }

            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }

    private void SaveToFile(string filename)
    {
        //saves all goals in _goals to a file using their SaveGoal method
        using (StreamWriter goalFile = new StreamWriter(filename))
        {
            goalFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                goalFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    private void LoadFromFile(string filename)
    {
        //empty the list to load new goals
        _goals.Clear();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] pieces = line.Split("|");

            int i = 0;
            if (int.TryParse(pieces[0], out i))
            {
                //if the first string is numeric, save it as the current score
                _score = int.Parse(pieces[0]);
                continue;
            }

            //save the values all goals share
            string name = pieces[1];
            string description = pieces[2];
            int value = int.Parse(pieces[3]);

            //depending on the first string, create the appropiate goal and store its extra attributtes
            if (pieces[0] == "SimpleGoal")
            {
                bool isComplete = Convert.ToBoolean(pieces[4]);

                SimpleGoal simpleGoal = new SimpleGoal(name, description, value, isComplete);

                _goals.Add(simpleGoal);
            }

            else if (pieces[0] == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(name, description, value);

                _goals.Add(eternalGoal);
            }

            else if (pieces[0] == "ChecklistGoal")
            {
                int checks = int.Parse(pieces[4]);
                int checkedd = int.Parse(pieces[5]);
                int totalValue = int.Parse(pieces[6]);

                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, value, checks, checkedd, totalValue);

                _goals.Add(checklistGoal);
            }
        }
    }
}