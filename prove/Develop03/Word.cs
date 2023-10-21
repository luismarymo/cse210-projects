public class Word
{
    private string _word;
    public bool _isHidden;

    public Word(string word)
    {
        // saves the word to the attribute and sets its visibility
        _word = word;
        _isHidden = false;
    }

    public void Hide()
    {
        //changes the visibility
        _isHidden = true;
    }

    public string Show()
    {
        //checks if the word is visible. if it is, it returns the string with the word
        //if its not, returns a string made of underscores the lenght of the original word
        if(!_isHidden)
        {
            return _word;
        }
        else
        {
            string blank = new string('_', _word.Length);
            return blank;
        }
    }
}