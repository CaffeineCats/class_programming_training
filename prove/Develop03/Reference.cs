public class Reference 
{
    private string _bookName;
    private int _bookChapterNumber;
    private int _firstVerseNumber;
    private int _lastVerseNumber;
    private bool _isMultipleleVerse;

    public Reference()
    {
        _bookName = "Proverbs";
        _bookChapterNumber = 3;
        _firstVerseNumber = 5;
        _lastVerseNumber = 6;
        _isMultipleleVerse = true;
    }

    public Reference(string bookName, int chapter, int verse)
    {
        _bookName = bookName;
        _bookChapterNumber = chapter;
        _firstVerseNumber = verse;
        _isMultipleleVerse = false;
    }

    public Reference(string bookName, int chapter, int firstVerse, int lastVerse)
    {
        _bookName = bookName;
        _bookChapterNumber = chapter;
        _firstVerseNumber = firstVerse;
        _firstVerseNumber = lastVerse;
        _isMultipleleVerse = true;
    }

    public string GetReferenceString()
    {
        if(_isMultipleleVerse)
        {
            return"JOTARO";
        }
        else
        {
            return "DIO";
        }
    }

}