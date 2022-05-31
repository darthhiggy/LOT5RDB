using LOT5RDB.Equipment.Shared.Models;
using Newtonsoft.Json;

namespace LOT5RDB.Equipment.Shared.Weapons.Models;

public class Grip
{
    public Grip()
    {
        GripType = GripTypes.Unknown;
        Bonus = string.Empty;
        ExtraDescription = string.Empty;
        Weapons = new();
    }
    
    [JsonConstructor]    
    public Grip(GripTypes gripType, string bonus, string extraDescription)
    {
        GripType = gripType;
        Bonus = bonus;
        ExtraDescription = extraDescription;
        Weapons = new List<WeaponModel>();
    }
    public GripTypes GripType { get; set; }
    public string Bonus { get; set; }
    public string ExtraDescription { get; set; } 
    public List<WeaponModel> Weapons { get; set; } 

    public override string ToString()
    {
        return $"{GripType}{ExtraDescription}: {Bonus}";
    }
}
