using LOT5RDB.Core.Equipment.DataObjects;
using LOT5RDB.Core.Shared.DataObjects;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOT5RDB.Core.Skills.DataObjects;

namespace LOT5RDB.Data.Repositories
{
    public class InMemoryEquipmentRepo : IEquipmentRepository
    {
        public List<Weapon> Weapons { get; set; } = new List<Weapon>();

        public InMemoryEquipmentRepo()
        {
            Weapons = new List<Weapon>
            {
                new Weapon
                {
                    Id = 1,
                    Category = WeaponCategories.Sword,
                    Name = "Bokken",
                    Skill = new Skill(0),
                    BaseDamage = 3,
                    Deadliness = 3,
                    Range = new Core.Shared.DataObjects.Ranges(1,1),
                    Grips = new List<Grip>{new Grip { GripType = GripTypes.OneHanded, Bonus = "-", ExtraDescription = ""}, new Grip { GripType = GripTypes.TwoHanded, Bonus = "Damage +2", ExtraDescription = ""} },
                    Qualities = new List<ItemQuality>{new ItemQuality { Id = 1, Name = "Mundane", Description = "Description"} },
                    Price = new Price(10),
                    Rarity = 3,
                    Description = @"Bokken are swords carved of wood rather than forged
                                    of metal. Generally used as a training weapon, a bokken
                                    still can be deadly in a skilled warrior’s hands.
                                    A properly shaped bokken can be used for Iaijutsu
                                    Cut techniques despite lacking the Razor-Edged quality"
                },
                new Weapon
                {
                    Id = 2,
                    Category = WeaponCategories.Sword,
                    Name = "Chokutō",
                    Skill = new Skill(0),
                    BaseDamage = 4,
                    Deadliness = 5,
                    Range = new Core.Shared.DataObjects.Ranges(0, 1),
                    Grips = new List<Grip>{ new Grip { GripType= GripTypes.OneHanded, Bonus= "-", ExtraDescription =""} },
                    Qualities = new List<ItemQuality> { new ItemQuality { Id = 2, Name = "Ceremonial", Description = "Description" }, new ItemQuality { Id = 3, Name = "Razor-Edge", Description="Description"} },
                    Price = new Price(2000),
                    Rarity = 7,
                    Description = @"The chokutō is an ancient design that predates the
                                    advent of the katana. Hung from a belt rather than tucked
                                    into a sash, a chokutō is roughly three feet long and has a
                                    straight, single-edged blade instead of the gentle curve
                                    found in newer Rokugani swords. Many of the clans’
                                    most powerful nemuranai—
                                    weapons that were wielded
                                    by their founding Kami—have this shape, as do the
                                    blades used by the Yobanjin of the northern mountains."
                }
            };
        }

        public Weapon AddWeapon(Weapon weapon)
        {
            Weapon dbWeapon = GetWeaponById(weapon.Id) ?? SearchWeaponByName(weapon.Name).First();
            if(dbWeapon == null)
            {
                Weapons.Add(weapon);
            }
            return weapon;
        }

        public int DeleteWeapon(int id)
        {
            Weapon weapon = GetWeaponById(id);
            if(weapon == null)
            {
                return 0;
            }
            else
            {
                Weapons.Remove(weapon);
                return 1;
            }
        }

        public List<Weapon> GetAllWeapons()
        {
            return Weapons;
        }

        public Weapon GetWeaponById(int id)
        {
            return Weapons.FirstOrDefault(w => w.Id == id) ?? new Weapon();
        }

        public List<Weapon> SearchWeaponByName(string searchString)
        {
            if(string.IsNullOrWhiteSpace(searchString))
            {
                return GetAllWeapons();
            }

            return Weapons.Where(w => w.Name.ToLower().StartsWith(searchString.ToLower())).ToList();
        }

        public Weapon UpdateWeapon(Weapon weapon)
        {
            var obj = Weapons.FirstOrDefault(w => w.Id == weapon.Id) ?? weapon;

            obj = weapon;

            return obj;
        }

        public int Commit()
        {
            return 0;
        }
    }
}
