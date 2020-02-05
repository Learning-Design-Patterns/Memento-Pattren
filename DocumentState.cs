public class DocumentState
{
    private string _content;
    private string _fontName;
    private int _fontSize;

    public DocumentState(string content, string fontName, int fontSize)
    {
        _content = content;
        _fontName = fontName;
        _fontSize = fontSize;
    }

    public string Content { get => _content; }
    public string FontName { get => _fontName; }
    public int FontSize { get => _fontSize; }
}