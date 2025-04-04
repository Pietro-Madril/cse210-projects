class Scripture
{
    private Reference _reference;
    private Word[] _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] wordsArray = text.Split(' ');
        _words = new Word[wordsArray.Length];
        for (int i = 0; i < wordsArray.Length; i++)
        {
            _words[i] = new Word(wordsArray[i]);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        System.Random rand = new System.Random();
        int count = 0;
        while (count < numberToHide)
        {
            int index = rand.Next(_words.Length);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                count++;
            }
        }
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + "\n";
        for (int i = 0; i < _words.Length; i++)
        {
            result += _words[i].GetDisplayText() + " ";
        }
        return result.Trim();
    }

    public bool IsCompletellyHidden()
    {
        for (int i = 0; i < _words.Length; i++)
        {
            if (!_words[i].IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
