public class Reference 
{
    private string _bookName;
    private int _bookChapterNumber;
    private int _firstVerseNumber;
    private int _lastVerseNumber;
    private bool _isMultipleVerse;

    public Reference()
    {
        _bookName = "Proverbs";
        _bookChapterNumber = 3;
        _firstVerseNumber = 5;
        _lastVerseNumber = 6;
        _isMultipleVerse = true;
    }

    public Reference(string bookName, int chapter, int verse)
    {
        _bookName = bookName;
        _bookChapterNumber = chapter;
        _firstVerseNumber = verse;
        _isMultipleVerse = false;
    }

    public Reference(string bookName, int chapter, int firstVerse, int lastVerse)
    {
        _bookName = bookName;
        _bookChapterNumber = chapter;
        _firstVerseNumber = firstVerse;
        _lastVerseNumber = lastVerse;
        _isMultipleVerse = true;
    }
    // Reference to hold the logic of which type of reference is being used is good encapsulation
    // The other parts of the program just pass data and return reference, easy peasy.
    public string GetReferenceString()
    {
        if(_isMultipleVerse)
        {
            return $"{_bookName} {_bookChapterNumber}:{_firstVerseNumber}-{_lastVerseNumber}";
        }
        else
        {
            return $"{_bookName} {_bookChapterNumber}:{_firstVerseNumber}";
        }
    }

}