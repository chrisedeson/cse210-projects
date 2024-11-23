public class Scripture
{
    Reference _reference = new Reference("", 3, 3);

    private List<Word> _words = new List<Word>();

    public Scripture(String text)
    {
        string[] words = text.Split(' ');

        foreach (string wordText in words)
        {
            _words.Add(new Word(wordText));
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

        Random rand = new Random();
        int index = rand.Next(_words.Count);

    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int wordsHidden = 0;

        while (wordsHidden < numberToHide)
        {
            int index = rand.Next(_words.Count);

            // Check if the word at the index is already hidden
            if (!_words[index].isHidden())
            {
                _words[index].Hide();
                wordsHidden++;
            }

            // If all words are already hidden, break out of the loop
            if (isCompletelyHidden())
            {
                break;
            }
        }
    }

    public bool isCompletelyHidden()
    {
        // Check if every word in the scripture is hidden
        foreach (Word word in _words)
        {
        if (!word.isHidden()) // If any word is still visible, return false
            {
            return false;
            }
        }
        return true; // All words are hidden
    }

}