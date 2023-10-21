public class Word
{
    private string _scriptureWord;
    private bool _isVisible;

    public Word(string word)
    {
        _scriptureWord = word;
        _isVisible = true;
    }

    public void HideWord()
    {
        _isVisible = false;
    }

    public bool IsVisible()
    {
        if(_isVisible)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetWordWithCurrentVisibility()
    {
        if(_isVisible)
        {
            return _scriptureWord;
        }

        else
        {
            List<string> letters = new List<string>();

            for (int i = 1; i <= _scriptureWord.Length; i++)
            {
                letters.Add("_");
            }

            return string.Join("", letters);
        }
    }
}