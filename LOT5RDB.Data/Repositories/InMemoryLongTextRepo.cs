using LOT5RDB.Core.Shared.DataObjects;
using LOT5RDB.Core.Shared.Interfaces;
using LOT5RDB.Data.Configuration;

namespace LOT5RDB.Data.Repositories;

public class InMemoryLongTextRepo : ILongTextRepo
{
    public List<LongText> LongTexts { get; set; }
    
    public InMemoryLongTextRepo()
    {
        var dataSeeds = new DataSeeds();
        LongTexts = dataSeeds.SkillDescriptions.Values
            .Concat(dataSeeds.WeaponDescriptions.Values)
            .Concat(dataSeeds.ItemQualitiesDescriptions.Values)
            .Concat(dataSeeds.SkillGroupDescriptions.Values)
            .ToList();
    }
    public LongText GetLongTextById(Guid id) => LongTexts.First(e => e.Id == id);
    
    public LongText AddLongText(LongText longText)
    {
        longText.Id = Guid.NewGuid();
        LongTexts.Add(longText);
        return longText;
    }
    
    public LongText UpdateLongText(LongText longText)
    {
        var text = LongTexts.First(e => e.Id == longText.Id);
        if(text.Id == Guid.Empty)
        {
            return AddLongText(longText);
        }

        text = longText;
        return text;
    }
    public int DeleteLongText(Guid id)
    {
        return LongTexts.Remove(LongTexts.First(w => w.Id == id)) ? 0 : 1;
    }
}
