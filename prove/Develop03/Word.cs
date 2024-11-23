public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // hide the word by converting to "_"
    public void Hide()
    {
        _isHidden = true;
    }

    // make te word visible again
    public void Show()
    {
        _isHidden = false;
    }

    public bool isHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        /* If a word is "faith", it has 5 letters. To display it 
        as "_____", we need a string of underscores that is 5 
        characters long.  generate such a string 
        using the new string('_', length) method.
        */
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        return _text;
    }
}