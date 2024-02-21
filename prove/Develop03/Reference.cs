using System;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int? _verseEnd;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd) : this(book, chapter, verseStart)
    {
        _verseEnd = verseEnd;
    }

    public override string ToString() => $"{_book} {_chapter}:{_verseStart}{(_verseEnd.HasValue ? $"-{_verseEnd}" : "")}";
}