using System.Diagnostics.CodeAnalysis;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    public Reference(string book , int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        

    }
    public string GetBook()
    {
        return _book;
    }

    public int GetChapter()
    {
        return _chapter;
    }
    public string GetVerses()
    {
        return $"{_startVerse}";
    }
    public string GetReferences()
    {
        return $"{_book} {_chapter}:{_startVerse}";
    }
}