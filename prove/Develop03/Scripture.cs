using System.Security.Cryptography;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Scripture()
    {
        _reference = new Reference();

        string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding; " +
                               "in all thy ways acknowledge him, and he shall direct thy paths.";

        string[] words = scriptureText.Split(" ");

        foreach (string word in words)
        {
            Word appendableWordItem = new Word(word);

            _words.Add(appendableWordItem);
        };
    }

    public Scripture(Reference scriptureReference, string scriptureText)
    {
        _reference = scriptureReference; 

        string[] words = scriptureText.Split(" ");

        foreach (string word in words)
        {
            Word appendableWordItem = new Word(word);

            _words.Add(appendableWordItem);
        };
    }

    public string GetRenderedScriptureText()
    {
        List<string> words = new List<string>();

        foreach(Word word in _words)
        {
            words.Add(word.GetWordAsCurrentVisibility());
        }

        return $"{_reference.GetReferenceString()} {string.Join(" ", words)}";
    }

    public bool AreThereUnHiddenWordsLeft()
    {
        foreach(Word word in _words)
        {
            if(!word.IsHidden())
            {
                return true;
            }
        }

        return false;
    }

    public void HideUpToThreeWords()
    {
        Random randomGenerator = new Random();

        int hidingWordCounter = 1;
        
        while(hidingWordCounter <= 3 && AreThereUnHiddenWordsLeft())
        {
            bool keepHiding = true;

            while(keepHiding)
            {
                int randomNumber = randomGenerator.Next(0, _words.Count());

                if (!_words[randomNumber].IsHidden())
                {
                    _words[randomNumber].HideWord();

                    keepHiding = false;
                }
            }
            
            hidingWordCounter++;
        }
    }
}