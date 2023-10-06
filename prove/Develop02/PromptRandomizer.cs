public class PromptRandomizer
{
    //create an instance of random
    Random random = new Random();

    //list to store prompts
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What thing did I wish to do today that I was unable to?",
        "If I could change one thing about my day, what would that be?",
        "Was there an activity that I did today, that I would like to do again?",
        "What did I do today to strenghten my relationship with the Lord?"
    };

    //choose a random index from the list of prompts, and return it.
    public string ChoosePrompt()
    {
        int i = random.Next(_prompts.Count);
        return _prompts[i];
    }
}