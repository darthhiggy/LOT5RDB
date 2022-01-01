using LOT5RDB.Core.Equipment.DataObjects;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LOT5RDB.Pages.Equipment
{
    public class ListModel : PageModel
    {
        private readonly IEquipmentRepository equipmentData;
        [BindProperty(SupportsGet = true)]
        public string WeaponSearchTerm { get; set; }
        public IEnumerable<Weapon> Weapons { get; set; } = Enumerable.Empty<Weapon>();
        public ListModel(IEquipmentRepository restaurantData)
        {
            this.equipmentData = restaurantData;
            WeaponSearchTerm = "";
        }

        public void OnGet()
        {
            Weapons = equipmentData.SearchWeaponByName(WeaponSearchTerm);
        }
    }
}
