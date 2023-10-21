public class Reference{
    private string _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string chapter, int startVerse)
    {
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = 0;
    }

    public Reference(string chapter, int startVerse, int endVerse)
    {
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetReference()
    {
        //if the ending verse is not 0, then the scripture has multiple verses
        if (_endVerse != 0)
        {
            return $"{_chapter}:{_startVerse}-{_endVerse} ";
        }
        else
        {
            return $"{_chapter}:{_startVerse} ";
        }
    }
}