namespace LOT5RDB.Equipment.Models;

public class ItemQualityModel
{
    public int Id { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
    public Guid DescriptionId { get; set; } = new();
    public List<WeaponModel> Weapons { get; set; } = new();
}
