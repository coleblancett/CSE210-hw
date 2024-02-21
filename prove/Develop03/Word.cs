using System;

class Word
{
    private string _text;
    public bool IsHidden { get; set; }

    public Word(string text)
    {
        _text = text;
    }

    public override string ToString() => IsHidden ? "_____" : _text;
}   