public class Word
{
    private string _scriptureWord;
    private bool _isHidden;

    public Word(string word)
    {
        _scriptureWord = word;
        _isHidden = false;
    }

    public void HideWord()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        if(_isHidden)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetWordAsCurrentVisibility()
    {
        if(_isHidden)
        {
            List<string> letters = new List<string>();

            for (int i = 1; i <= _scriptureWord.Length; i++)
            {
                letters.Add("_");
            }

            return string.Join("", letters);

        }

        else
        {
            return _scriptureWord;
        }
    }
}