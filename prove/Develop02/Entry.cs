using System.Transactions;

public class Entry
{
    //strings for entry information
    public string _date;
    public string _prompt; 
    public string _entryText;
    public string _emotion;
    
    //for displaying the entry, properly formatted
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_entryText}\nEmotion: {_emotion}\n");
    }
}