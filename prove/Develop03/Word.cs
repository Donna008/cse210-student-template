using System;

class Word
{
    public string Text;
    private bool _isHidden;

    // Constructor to initialize a Word with a given text and default IsHidden value (false)
    public Word(string _text)
    {
        Text = _text;
        _isHidden = false;
    }

    // Public method to hide the Word
    public void Hide()
    {
        _isHidden = true;
    }

    // Public method to get the IsHidden status
    public bool GetIsHidden()
    {
        return _isHidden;
    }
}
