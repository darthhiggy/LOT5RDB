namespace LOT5RD.Equipment.Models;

public class Grip
{
    public int Id { get; set; } = 0;
    public GripTypes GripType { get; set; } = GripTypes.Unknown;
    public string Bonus { get; set; } = string.Empty;
    public string ExtraDescription { get; set; } = string.Empty;
    public List<WeaponModel> Weapons { get; set; } = new List<WeaponModel>();

    public override string ToString()
    {
        return $"{GripType}{ExtraDescription}: {Bonus}";
    }
}
