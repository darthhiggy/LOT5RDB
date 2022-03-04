namespace LOT5RD.Equipment.Models;

public class ItemQualityModel
{
    public int Id { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
    public Guid DescriptionId { get; set; } = new Guid();
    public List<WeaponModel> Weapons { get; set; } = new List<WeaponModel>();
}
