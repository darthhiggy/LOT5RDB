using LOT5RDB.Equipment.Shared.Weapons.Models;

namespace LOT5RDB.Models;

public class WeaponsViewModel
{
    public WeaponsViewModel(List<WeaponModel> items, int count, int pageIndex, int pageSize)
    {
        PageIndex = pageIndex;
        TotalPages = (int) Math.Ceiling(count / (double) pageSize);

        Weapons = items;
    }
    
    public int PageIndex { get; private set; }
    public int TotalPages { get; private set; }
    public bool HasPreviousPage => PageIndex > 1;
    public bool HasNextPage => PageIndex < TotalPages;

    public List<WeaponModel> Weapons { get; set; }

    public static WeaponsViewModel Create(List<WeaponModel> source, int pageIndex, int pageSize)
    {
        var count = source.Count;
        var items = source.Skip((pageIndex-1) * pageSize).Take(pageSize).ToList();
        return new WeaponsViewModel(items, count, pageIndex, pageSize);
    }
}
