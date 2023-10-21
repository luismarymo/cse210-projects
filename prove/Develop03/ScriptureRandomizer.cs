using System.Security.Cryptography.X509Certificates;

public class ScriptureRandomizer
{   
    Random random = new Random();

    private string _chosenChapter;
    private int _chosenStart;
    private int _chosenEnd = 0; //set value in case the scripture has only one verse
    private string _chosenScripture;

    //list with scriptures
    private List<string> _scriptures = new List<string>()
    {
        "Proverbs 3~5~6~Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.",
        "John 3~16~For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
        "Doctrine & Convenants~10~4~Do not run faster or labor more than you have strength and means provided to enable you to translate; but be diligent unto the end.",
        "Alma 7~11~12~And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities.",
        "2 Nephi 26~28~Behold, hath the Lord commanded any that they should not partake of his goodness? Behold I say unto you, Nay; but all men are privileged the one like unto the other, and none are forbidden."
    };

    public void ChooseScripture()
    {
        //choose the scripture and store its parts in the attributes
        int i = random.Next(_scriptures.Count);
        string[] pieces = _scriptures[i].Split('~');

        _chosenChapter = pieces[0];
        _chosenStart = int.Parse(pieces[1]);
        
        bool isNumeric = int.TryParse(pieces[2], out _chosenEnd);
        if(isNumeric)
        {   
            _chosenScripture = pieces[3];
        }
        else
        {
            _chosenScripture = pieces[2]; //since its not numeric, the scripture has only one verse and the third piece is the scripture
        }
    }

    //getter methods for the parts of the scripture
    public string GetChapter()
    {
        return _chosenChapter;
    }

    public int GetStartVerse()
    {
        return _chosenStart;
    }

    public int GetEndVerse()
    {
        return _chosenEnd;
    }

    public string GetScripture()
    {
        return _chosenScripture;
    }
}