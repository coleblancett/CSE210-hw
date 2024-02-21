using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public bool AllWordsHidden => _words.All(w => w.IsHidden);

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords(int count)
    {
        var wordsToHide = _words.Where(w => !w.IsHidden).OrderBy(w => Guid.NewGuid()).Take(count);
        foreach (var word in wordsToHide)
        {
            word.IsHidden = true;
        }
    }

    public override string ToString() => $"{_reference}: {string.Join(" ", _words)}";
}