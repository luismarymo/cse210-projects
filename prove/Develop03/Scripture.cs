using System.Runtime.CompilerServices;

public class Scripture
{
    Random random = new Random();

    private Reference _reference;
    private string _scripture;

    //list for the words of the scripture
    private List<Word> _words = new List<Word>();

    //list to store indexes of words not hidden
    private List<int> _indexes = new List<int>();

    public Scripture(Reference referecence, string scripture)
    {
        //without providing a reference and scripture, an instance cannot be created
        _reference = referecence;
        _scripture = scripture;
    }

    public void SplitScripture()
    {
        //splits the scripture and adds its pieces as Word objects into the _word list
        string[] pieces = _scripture.Split(' ');
        
        int n = 0;
        foreach(string piece in pieces)
        {
            Word word = new Word(piece);

            _words.Add(word);
            _indexes.Add(n++);
        }
    }
    
    public void DisplayText()
    {
        //writes the reference and then shows every item in _words
        Console.Write(_reference.GetReference());

        foreach(Word word in _words)
        {
            Console.Write($"{word.Show()} ");
        }
    }

    public void HideWords()
    {
        //hides three words at a time by checking first that there are words left to hide, then chooses a random index from _indexes, and uses it to hide a word
        for(int i = 0; i < 3; i++)
        {
            if(_indexes.Count != 0)
            {
                int j = random.Next(_indexes.Count);
                _words[_indexes[j]].Hide();

                //removes the hidden item's index
                _indexes.RemoveAt(j);
            }
        }
    }

    public bool IsFullyHidden()
    {
        //checks if scripture is fully hidden by counting the items in _indexes
        if(_indexes.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}