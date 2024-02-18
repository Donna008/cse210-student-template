using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split();
        foreach (var wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWord()
    {
        foreach (var word in _words)
        {
            if (!word.GetIsHidden())
            {
                word.Hide();
                return;
            }
        }
    }

    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine($"{_reference.Verse}\n{GetHiddenText()}\n");
    }

    private string GetHiddenText()
    {
        List<string> hiddenText = new List<string>();
        foreach (var word in _words)
        {
            hiddenText.Add(word.GetIsHidden() ? new string('_', word.Text.Length) : word.Text);
        }
        return string.Join(" ", hiddenText);
    }

    public bool AllWordsHidden()
    {
        return _words.TrueForAll(word => word.GetIsHidden());
    }
}
