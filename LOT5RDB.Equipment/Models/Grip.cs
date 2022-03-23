namespace LOT5RDB.Equipment.Models;

public class Grip
{
    public GripTypes GripType { get; set; } = GripTypes.Unknown;
    public string Bonus { get; set; } = string.Empty;
    public string ExtraDescription { get; set; } = string.Empty;
    public List<WeaponModel> Weapons { get; set; } = new();

    public override string ToString()
    {
        return $"{GripType}{ExtraDescription}: {Bonus}";
    }
}
