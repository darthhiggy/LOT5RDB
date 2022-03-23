namespace LOT5RDB.Core.Shared.DataObjects;

public class LongText
{
    public LongText()
    {

    }

    public LongText(Guid id)
    {
        Id = id;
    }
    public Guid Id { get; set; } = new();
    public string Text { get; set; } = "";
}
