using LOT5RDB.Core.Shared.DataObjects;
using LOT5RDB.Core.Shared.Interfaces;
using LOT5RDB.Equipment.Shared.Weapons.Models;
using Newtonsoft.Json;

namespace LOT5RDB.Equipment.Shared.ItemQualities.Models;

public class ItemQualityModel : BaseEntity<int>, IEntity<int>
{
    public ItemQualityModel()
    {
        Name = String.Empty;
        DescriptionId = Guid.Empty;
        Weapons = new List<WeaponModel>();
    }

    public ItemQualityModel(string name, Guid descriptionId)
    {
        Name = name;
        DescriptionId = descriptionId;
        Weapons = new List<WeaponModel>();
    }

    [JsonConstructor]
    public ItemQualityModel(int id, string name, Guid descriptionId)
    {
        Id = id;
        Name = name;
        DescriptionId = descriptionId;
        Weapons = new List<WeaponModel>();
    }
    
    public Guid DescriptionId { get; set; }
    public List<WeaponModel> Weapons { get; set; }
}
