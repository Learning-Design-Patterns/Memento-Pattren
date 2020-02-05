public class Document
{
    private string _content;
    private string _fontName;
    private int _fontSize;
    public string Content
    {
        get => _content;
        set => _content = value;
    }
    public string FontName
    {
        get => _fontName;
        set => _fontName = value;
    }
    public int FontSize
    {
        get => _fontSize;
        set => _fontSize = value;
    }

    public DocumentState CreateState() => new DocumentState(Content, FontName, FontSize);

    public void Restore(DocumentState state)
    {
        FontName = state.FontName;
        FontSize = state.FontSize;
        Content = state.Content;
    }
}