using LOT5RDB.Core.Shared.DataObjects;
using LOT5RDB.Equipment.Shared.ItemQualities.Models;
using LOT5RDB.Equipment.Shared.Models;
using LOT5RDB.Equipment.Shared.Weapons.Models;
using LOT5RDB.Skills.Shared.Models;

namespace LOT5RDB.DataGenerator;

public class DataSeeds
{
    public Dictionary<string, LongText> SkillGroupDescriptions { get; set; }
    public Dictionary<string, LongText> SkillDescriptions { get; set; }
    public Dictionary<string, LongText> ItemQualitiesDescriptions { get; set; }
    public Dictionary<string, LongText> WeaponDescriptions { get; set; }

    private List<LongText> _descriptions = new List<LongText>();
    public List<LongText> Descriptions
    {
        get
        {
            if(_descriptions.Count <= 0)
            {
                _descriptions.AddRange(WeaponDescriptions.Values);
                _descriptions.AddRange(ItemQualitiesDescriptions.Values);
                _descriptions.AddRange(SkillDescriptions.Values);
                _descriptions.AddRange(SkillGroupDescriptions.Values);
            }

            return _descriptions;
        }
    }
    
    private List<SkillGroupModel> _skillGroups = new List<SkillGroupModel>();
    public List<SkillGroupModel> SkillGroups
    {

        get
        {
            if(_skillGroups.Count < 1)
            {
                _skillGroups = GetSkillGroups();
            }
            return _skillGroups;
        }
    }

    private List<SkillModel> _skills = new List<SkillModel>();
    public List<SkillModel> Skills
    {
        get
        {
            if(_skills.Count < 1)
            {
                _skills = GetSkills();
            }

            return _skills;
        }
    }

    private List<ItemQualityModel> _itemQualities = new List<ItemQualityModel>();
    public List<ItemQualityModel> ItemQualities {
        get
        {
            if(_itemQualities.Count < 1)
            {
                _itemQualities = GetItemQualities();
            }
            return _itemQualities;
        }  }

    private List<WeaponModel> _weaponModels = new List<WeaponModel>();
    public List<WeaponModel> WeaponModels { get
    {
        if(_weaponModels.Count < 1) { _weaponModels = GetWeapons(); }
        return _weaponModels;
    } }

    public DataSeeds()
    {
        SkillGroupDescriptions = GetSkillGroupDescriptions();
        SkillDescriptions = GetSkillDescriptions();
        ItemQualitiesDescriptions = GetItemQualitiesDescription();
        WeaponDescriptions = GetWeaponDescriptions();
    }
    private Dictionary<string, LongText> GetWeaponDescriptions()
    {
        return new Dictionary<string, LongText>
        {
            {
                "Bokken",
                new LongText()
                {
                    Id = Guid.Parse("9d785089-f4a0-447a-86ae-0846dcfdd7af"),
                    Text = @"Bokken are swords carved of wood rather than forged
                            of metal. Generally used as a training weapon, a bokken
                            still can be deadly in a skilled warrior’s hands.
                            A properly shaped bokken can be used for Iaijutsu
                            Cut techniques despite lacking the Razor-Edged quality."
                }
            },
            {
                "Chokutō",
                new LongText()
                {
                    Id = Guid.Parse("7bd3e03d-b9fc-4ef4-b9bc-a582434a14db"),
                    Text = @"The chokutō is an ancient design that predates the
                            advent of the katana. Hung from a belt rather than tucked
                            into a sash, a chokutō is roughly three feet long and has a
                            straight, single-edged blade instead of the gentle curve
                            found in newer Rokugani swords. Many of the clans’
                            most powerful nemuranai—
                            weapons that were wielded
                            by their founding Kami—have this shape, as do the
                            blades used by the Yobanjin of the northern mountains."
                }
            },
            {
                "Dao",
                new LongText()
                {
                    Id = Guid.Parse("3be3c2ec-ffe7-4304-a7d1-c1f3a3afcee0"),
                    Text = @"Dao are weapons that look like a cross between a
                            scimitar, a saber, and a peasant’s machete. They are
                            one-handed swords two to three feet in length with a
                            broad-bellied, single-edged blade designed for slashing
                            and chopping, and are generally wielded in pairs."
                }
            },
            {
                "Gao",
                new LongText()
                {
                    Id = Guid.Parse("fdc8a246-abc4-4e1d-af89-2822acf8f03d"),
                    Text = @"Known colloquially as “tiger hook swords” or “Heaven
                            and Earth, Sun and Moon swords,” gao are curious
                            weapons. Usually wielded in pairs, gao are flat, solid
                            iron or steel blades roughly three feet long with several
                            unique features. Their main blade has a hook at one end
                            and a sharpened spike at the other. The grip is protected
                            by a crescent-shaped hand guard with its points facing
                            outward. Gao can be used to slash, capture, and stab,
                            making them appealing to certain Mirumoto duelists."
                }
            },
            {
                "Jian",
                new LongText()
                {
                    Id = Guid.Parse("4d19ac97-1238-47af-ab8a-2eaae450816e"),
                    Text = @"Known primarily as a duelist’s weapon, the jian is an
                            ancient and elegant sword that has changed very little
                            in design since Rokugan’s misty past yet remains deadly
                            to this day. About the same size as a chokutō, a typical
                            jian has a straight, double-edged blade that tapers
                            to a point; a small, thick, horizontal hand guard; and a
                            heavy pommel with a tassel. Only slightly more common
                            than the chokutō, it is used by some Mirumoto,
                            Kitsuki, or Shiba swordmasters who favor its versatility."
                }
            },
            {
                "Katana",
                new LongText()
                {
                    Id = Guid.Parse("8761953C-0D1F-4EDC-8860-AA949C22C39C"),
                    Text = @"As much a work of art as it is a weapon, the katana is
                            perhaps the most revered weapon in Rokugan. It has an
                            elegant, slightly curved blade between three and four
                            feet long, made of steel that is specially folded during
                            its creation. This unique forging style ensures that the
                            inner part of the blade remains springy and soft while
                            the outside is as hard as tempered steel. Each sword
                            likely has a history and legacy, and it is a constant
                            reminder of the weight that destiny has placed upon
                            its bearer’s shoulders as a samurai of Rokugan"
                }
            },
            {
                "Nodachi",
                new LongText()
                {
                    Id = Guid.Parse("64DC8D84-22D1-4AEB-BDCE-3EFCD4FD839A"),
                    Text = @"Larger than katana, nodachi are long and lethal swords
                            more at home on the battlefield than in a city or at
                            court. Roughly six feet long, these blades are relatively
                            rare due to the skill and strength needed to wield them
                            effectively. There are those who prize the raw force of
                            these blades, however, such as members of the Matsu
                            school. Too large to be worn at the waist, nodachi are
                            normally worn on the back and drawn over the shoulder
                            or even carried into battle by a samurai’s attendant."
                }
            },
            {
                "Zanbatō",
                new LongText()
                {
                    Id = Guid.Parse("725D0771-5EF1-4E96-8F4D-65630EE5094E"),
                    Text = @"Larger even than mighty nodachi, zanbatō are swords
                            with the reach of a spear. Zanbatō have a long, thick,
                            katana-like blade roughly six feet in length attached
                            to a two-handed hilt. They are dedicated anticavalry
                            weapons—indeed, their name means “horse-chopping
                            sword.” The Matsu school is famous for adopting them
                            into the curriculum after their ill-fated encounter with
                            the Utaku cavalry at the Battle of Plum Blossom Pass."
                }
            },
            {
                "Masakari",
                new LongText()
                {
                    Id = Guid.Parse("CA8CD8C7-DE5A-4F41-9A91-5C2C9C75119A"),
                    Text = @"Similar in size and shape to the humble hatchet, a masakari
                            is a one-handed ax with a single-sided ax-head
                            affixed to one end of a short wooden haft. Such axes
                            are an ordinary sight among peasant militia and rōnin
                            who cannot afford a more prestigious weapon."
                }
            },
            {
                "Ono",
                new LongText()
                {
                    Id = Guid.Parse("EF557F8F-149D-4F10-8759-A1D6B7E6968B"),
                    Text = @"The ono is a dedicated, two-handed military ax, a rarity
                            on Rokugan’s battlefields, at least outside of Crab lands.
                            The ono consists of a broad, deeply curved ax-head
                            mounted to a haft nearly as tall as a human. Opposite
                            the ax-head is normally either an ornate peen or a long
                            spike, which can pierce armor or monstrous hide."
                }
            },
            {
                "Scimitar",
                new LongText()
                {
                    Id = Guid.Parse("7BF856DD-DB5F-42FA-89CF-9C84DAC758D4"),
                    Text = @"Perhaps the most common among foreign-designed
                            swords found in Rokugan, scimitars were brought from
                            the Burning Sands to the Emerald Empire by the Unicorn
                            Clan. Often carried in place of the katana by those warriors,
                            scimitars are heavy swords with a long, broad, curving
                            blade. They possess a deadly cutting edge thanks to
                            the extra surface area provided by their curvature."
                }
            },
            {
                "Wakizashi",
                new LongText()
                {
                    Id = Guid.Parse("272AAED4-E935-449B-BEC0-A1F307D0DBFD"),
                    Text = @"Whereas the katana represents a samurai’s status
                            as a warrior, the wakizashi represents their place in
                            Rokugan’s social order and strict caste system. The
                            wakizashi is a small, katana-like sword usually two to
                            three feet in length, with the same flexible blade and lethal
                            edge. It is often made as part of a pair, with the same decorations
                            as its matched katana. The wakizashi also fills
                            another role: it clearly signals that its wearer is a samurai,
                            and a person of honor who will make the ultimate sacrifice
                            for their ideals and their master. It is the tool with
                            which a samurai commits seppuku: ritual suicide, the last
                            protest of an aggrieved and honorable samurai."
                }
            },
            {
                "Ōtsuchi",
                new LongText()
                {
                    Id = Guid.Parse("309B89E0-272B-429A-AB76-CB976B3B3F88"),
                    Text = @"The ōtsuchi is to the carpenter’s hammer what the ono
                            is to the woodcutter’s ax: larger, deadlier, and obviously
                            designed with lethal purpose. With a shaft roughly six
                            feet long topped by a huge, barrel-shaped mallet head,
                            it is built to breach doors and smash walls—but it also
                            works quite well on monsters with rock-like hides, as the
                            warriors of the Hida school often demonstrate."
                }
            },
            {
                "Club",
                new LongText()
                {
                    Id = Guid.Parse("39AAB287-BEAF-40E4-A145-64B262A85888"),
                    Text = @"The humble club is perhaps the oldest weapon in
                            Rokugan—at least among humans. Often little more
                            than a length of stout wood or shaped stone, a club
                            can be fashioned with available materials by nearly
                            anyone. While a club can certainly be used to kill,
                            doing so takes some work on the part of the wielder."
                }
            },
            {
                "Hammer",
                new LongText()
                {
                    Id = Guid.Parse("C6FBCB03-9201-4AA0-B63A-640C727950F6"),
                    Text = @"The simple hammer is used for driving nails and spikes
                            and for other construction work. Throughout most of
                            Rokugan, the hammer is only occasionally used as a
                            weapon—typically in brawls or spur of the moment
                            skirmishes when no other weapon is available."
                }
            },
            {
                "Kiseru",
                new LongText()
                {
                    Id = Guid.Parse("445ED817-F218-43CC-8160-24CFC7334E55"),
                    Text = @"Kiseru are pipes used to smoke various herbs found
                            throughout Rokugan. They consist of a metal mouthpiece
                            and a metal bowl connected by a hollow wood
                            or bamboo tube. Kiseru range in quality from a peasant’s
                            rough-hewn pipe to a courtier or noble’s ivory-and-
                            gold inlaid piece of art. Further, they can function
                            as clandestine weapons. Since kiseru are not formally
                            considered arms, it is easy to get them into places that
                            forbid weapons."
                }
            },
            {
                "Tetsubō",
                new LongText()
                {
                    Id = Guid.Parse("B62E8802-BAED-4B24-86D4-F95DFDD86C82"),
                    Text = @"Long and narrow, a tetsubō can be as tall as a human
                            and normally is constructed of iron or hardwood.
                            Above its grip, a tetsubō is covered in steel, iron, or
                            even jade spikes or studs that add to the weapon’s
                            lethality and crush armor or plated carapace with ease."
                }
            },
            {
                "Jitte",
                new LongText()
                {
                    Id = Guid.Parse("0403C313-C888-4165-BA3E-EA862F7A02E3"),
                    Text = @"Typically just over a foot long, the jitte consists of a
                            short steel or iron rod attached to a wooden handle.
                            The rod tapers to a blunt point and has a single prong
                            that extends from one side. This simple weapon is
                            designed to disarm and subdue targets rather than to
                            kill them. It is carried by law enforcement officers at all
                            levels, from low-ranking town constables to high-ranking
                            magistrates, as a symbol of their office."
                }
            },
            {
                "Knife",
                new LongText()
                {
                    Id = Guid.Parse("1867197E-7356-4CAE-BCA8-3C4FF7364100"),
                    Text = @"Knives come in a dizzying array of types and styles,
                            from the familiar crudely constructed knife in a peasant’s
                            kitchen to the deadly combat knives samurai take
                            into battle. Those particularly designed for combat—
                            like the aiguchi—are often equipped with small hand
                            guards to make them more useful in the field"
                }
            },
            {
                "Nunchaku",
                new LongText()
                {
                    Id = Guid.Parse("DC6F6362-FFB4-4875-8014-C2E83DC4BA64"),
                    Text = @"Originally hailing from the Islands of Spice and Silk,
                            nunchaku have been used in certain Rokugani martial
                            arts schools for centuries. Adapted from a simple
                            threshing tool, nunchaku consist of two wood or iron
                            rods connected by a short length of chain or rope."
                }
            },
            {
                "Tessen",
                new LongText()
                {
                    Id = Guid.Parse("4EF6E7B7-1045-4D4B-AFD0-0C394FCABF43"),
                    Text = @"Carried by courtiers and military leaders alike, tessen
                            are fans specially built for fighting. However, they are
                            not commonly viewed as weapons, and can be openly
                            carried even into formal court chambers or negotiations.
                            Usually made of wood with steel tines, they generally
                            serve as defensive weapons, but wielders can also use
                            them to deliver clubbing blows or to reinforce a punch."
                }
            },
            {
                "Bisentō",
                new LongText()
                {
                    Id = Guid.Parse("728A3BA3-343C-47CC-932F-5720AEED4831"),
                    Text = @"The bisentō is a strange weapon not regularly seen on
                            Rokugan’s battlefields. Essentially a scimitar with an
                            extremely long hilt, the bisentō has a long, yari-like wooden
                            shaft topped by a broad and heavy curved blade.
                            Though it seems awkward and top-heavy, the bisentō is
                            exceptionally dangerous in the right hands. The length
                            of the shaft gives the wielder incredible leverage, allowing
                            them to deliver great chopping blows that can slice
                            a person in half or cleave through heavy armor. Typically
                            seen among the more militant orders of monks, such as
                            the Perfect Land Sect, the bisentō is sometimes used by
                            heavy infantry units, like those of the Daidoji family."
                }
            },
            {
                "Bō",
                new LongText()
                {
                    Id = Guid.Parse("6061E354-7151-4AD8-B8BC-C2FEA19F1CFD"),
                    Text = @"The bō, a humble staff, is a versatile weapon found
                            throughout Rokugan. Roughly six feet long and made
                            from sturdy hardwood, it is carried by travelers who need
                            both a walking stick and an inconspicuous weapon."
                }
            },
            {
                "Ji",
                new LongText()
                {
                    Id = Guid.Parse("CA51E607-66BE-431C-851C-715DC1622262"),
                    Text = @"Also known as the “dagger-spear,” the ji is a long
                            polearm designed more for catching and controlling
                            weapons than for direct attacks. Commonly used by
                            the Dragon and Phoenix Clans, and a specialty of
                            the Shiba Guardian School, the standard ji consists
                            of a long wooden shaft topped by a hooked or crescent-
                            shaped blade. Other ji have a head consisting of
                            a single long, double-edged blade with one or two
                            smaller crescent-shaped blades mounted to the sides."
                }
            },
            {
                "Naginata",
                new LongText()
                {
                    Id = Guid.Parse("1FC3321F-45D2-4E8D-99C9-ABEF09C6F3D8"),
                    Text = @"Most samurai’s preferred polearm, the naginata is highly
                            regarded. It has a long, flexible shaft made of bamboo
                            or springy wood with a large, lightweight, slightly
                            curved blade at the top. A naginata’s blade is forged
                            with the same ceremony and meticulous craftsmanship
                            as a katana’s, and commands the same reverence as
                            the daishō. It is carried in elite units such as the Heaven’s
                            Wing Brotherhood and the Utaku Battle Maidens."
                }
            },
            {
                "Trident",
                new LongText()
                {
                    Id = Guid.Parse("5B09B7F0-FAC3-4634-9480-93A8C3C65229"),
                    Text = @"The trident is a long, triple-headed spear generally associated
                            with fishermen and the sea. On land, the trident is a
                            formidable polearm with exceptional reach that can pierce, trap,
                            and control opponents."
                }
            },
            {
                "Yari",
                new LongText()
                {
                    Id = Guid.Parse("63C1B2B5-9A91-402C-8598-135FE17EFF75"),
                    Text = @"A long-shafted spear, the yari is one of the most common
                            weapons in Rokugan. Between six and eight feet long, its
                            shaft is made of hardwood and topped with a leaf-shaped
                            spearhead. Since it is easy to make, the yari is a customary
                            weapon of ashigaru, but also elite clan samurai such as the
                            Daidoji heavy infantry."
                }
            },
            {
                "Daikyū",
                new LongText()
                {
                    Id = Guid.Parse("EC0D878D-62DE-4138-9468-277D0AA95464"),
                    Text = @"Daikyū are large composite bows designed to be fired
                            from horseback. Conventionally around six feet long,
                            these elegant weapons are constructed by gluing thin layers of wood, horn, leather,
                            and sinew together. Daikyū differ from other bows in that they have an asymmetric shape. 
                            Their grip is about two-thirds of the way from the top, making the
                            top curve longer than the bottom. This allows the bows 
                            to be fired easily from horseback in either direction.
                            Each daikyū is made for a custom fit for a specific user."
                }
            },
            {
                "Shinjo Horsebow",
                new LongText()
                {
                    Id = Guid.Parse("D60BDBBE-4B54-40D1-9288-5939090C042D"),
                    Text = @"Among the Unicorn Clan’s many adopted weapons is a
                            small, sturdy bow used by the nomadic peoples of the
                            steppes far to the west. Called the Shinjo horsebow in
                            Rokugan, this weapon is a compact bow designed to
                            be fired from the back of a moving horse. It is a shortrange
                            weapon intended for raiding and cavalry attacks."
                }
            },
            {
                "Yumi",
                new LongText()
                {
                    Id = Guid.Parse("7A8FCFE8-6F94-4098-BA3B-B48B1FD9967D"),
                    Text = @"The yumi is perhaps the most common bow used by
                            Rokugani samurai. Similar to the daikyū, it is a long,
                            graceful bow made from a composite of horn, sinew,
                            leather, and wood. Smaller than the daikyū, but only
                            just, the yumi has an asymmetric grip, general shape,
                            and long-range killing power similar to those of its larger
                            cousin. Where the daikyū is a cavalry bow, however,
                            the yumi is designed to be fired while standing."
                }
            },
            {
                "Oyumi",
                new LongText()
                {
                    Id = Guid.Parse("7A8FCFE8-6F94-4098-BA3B-B48B1FD9967D"),
                    Text = @"Developed out of necessity to fight the deadly forces of
                            the Shadowlands, this weapon consists of a recurve or
                            traditional bow laid horizontally on a long, stout stock.
                            Held to the shoulder, the oyumi is fired by squeezing
                            a long lever on the bottom of the stock. It fires short,
                            arrow-like projectiles called quarrels. Its existence is a
                            matter of some consternation among the other clans,
                            but the Crab maintain that its use—even in the hands
                            of ashigaru and peasants in times of crisis—has been
                            vital to the preservation of the Empire."
                }
            },
            {
                "Blowgun",
                new LongText()
                {
                    Id = Guid.Parse("1D68E56A-6542-4CFF-AFC7-6807C319A126"),
                    Text = @"Made from a length of hollow bamboo or river reed,
                            the blowgun is one of the simplest weapons that ninja
                            use in their work. The blowgun’s primary use is as
                            a ranged weapon, usually to deliver poison (see the
                            Poisoned Weapons sidebar, page 244). In addition
                            to darts, the blowgun can also be loaded with sand,
                            dust, or other powders to blind or disorient foes, and it
                            can even serve to let its user breathe while underwater."
                }
            },
            {
                "Kama",
                new LongText()
                {
                    Id = Guid.Parse("BA0B15CF-5F31-4EA9-9DDF-5AF0963A62A9"),
                    Text = @"The kama is another weapon adapted from an agricultural
                            implement: in this case, a standard sickle used for
                            harvesting rice. It consists of a short, roughly foot-long
                            wooden haft topped by a long, curved sickle blade.
                            Kama are often used in pairs, sometimes linked at the
                            handles by a length of chain."
                }
            },
            {
                "Kusari-Gama",
                new LongText()
                {
                    Id = Guid.Parse("9B5AE25B-49E3-4F8B-BC67-9645B835ACA7"),
                    Text = @"Extremely versatile and deadly, the kusari-gama is one of
                            the more difficult ninja weapons to master. It is a hybrid
                            weapon consisting of a long-hafted kama with a lengthy
                            chain attached to either the back of the blade or the
                            bottom of the haft. A heavy iron weight called a fundo
                            is mounted at the end of the chain. In combat, a wielder
                            typically spins the chain over their head with one hand
                            while holding the kama in the other. They whip the chain
                            forward, entangling an opponent’s weapon or limbs, then
                            rush in for the killing blow with the kama. A wielder can
                            also attack with the weighted end of the chain, striking
                            opponents at range and keeping them at bay."
                }
            },
            {
                "Shuriken",
                new LongText()
                {
                    Id = Guid.Parse("9B5AE25B-49E3-4F8B-BC67-9645B835ACA7"),
                    Text = @"Favored by shinobi, shuriken are small metal discs with
                            a sharpened edge that come in a dizzying array of sizes
                            and styles. They are designed mainly to distract, but
                            shuriken can also be coated with toxins for lethality,
                            and any cutting edge can kill if used properly."
                }
            }
        };
    }

    public List<WeaponModel> GetWeapons()
    {
        return new List<WeaponModel>()
        {
            new()
            {
                Id = 1,
                Name = "Bokken",
                Category = WeaponCategories.Sword,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.ToLower().StartsWith("martial arts [melee]"))?.Id ?? 0,
                Range = new Ranges(1, 1),
                BaseDamage = 3,
                Deadliness = 3,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.OneHanded,
                        Bonus = "-"
                    },
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "Damage +2"
                    }
                },
                // Qualities = GetItemQualities().Where(q => q.Name.ToLower().StartsWith("mundane")).ToList(),
                Rarity = 3,
                Price = new Price(10),
                DescriptionId = GetWeaponDescriptions()["Bokken"].Id
            },
            new()
            {
                Id = 2,
                Name = "Chokutō",
                Category = WeaponCategories.Sword,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(0, 1),
                BaseDamage = 4,
                Deadliness = 5,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.OneHanded,
                        Bonus = "-"
                    }
                },
                // Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "ceremonial" or "razor-edged").ToList(),
                Rarity = 7,
                Price = new Price(2000),
                DescriptionId = GetWeaponDescriptions()["Chokutō"].Id
            },
            new()
            {
                Id = 3,
                Name = "Dao",
                Category = WeaponCategories.Sword,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(1, 1),
                BaseDamage = 4,
                Deadliness = 5,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.OneHanded,
                        Bonus = "-"
                    }
                },
                //Qualities = new List<ItemQualityModel>(),
                Rarity = 6,
                Price = new Price(1500),
                DescriptionId = GetWeaponDescriptions()["Dao"].Id
            },
            new()
            {
                Id = 4,
                Name = "Gao",
                Category = WeaponCategories.Sword,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(1, 1),
                BaseDamage = 4,
                Deadliness = 3,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.OneHanded,
                        Bonus = "-"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower().Equals("snaring")).ToList(),
                Rarity = 7,
                Price = new Price(1500),
                DescriptionId = GetWeaponDescriptions()["Gao"].Id
            },
            new()
            {
                Id = 5,
                Name = "Jian",
                Category = WeaponCategories.Sword,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(0, 1),
                BaseDamage = 4,
                Deadliness = 4,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.OneHanded,
                        Bonus = "-"
                    },
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "Deadliness +1"
                    }
                },
                Rarity = 7,
                Price = new Price(1500),
                DescriptionId = GetWeaponDescriptions()["Jian"].Id
            },
            new()
            {
                Id = 6,
                Name = "Katana",
                Category = WeaponCategories.Sword,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(1, 1),
                BaseDamage = 4,
                Deadliness = 5,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.OneHanded,
                        Bonus = "-"
                    },
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "Deadliness +2"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "ceremonial" or "razor-edged").ToList(),
                Rarity = 7,
                Price = new Price(2000),
                DescriptionId = GetWeaponDescriptions()["Katana"].Id
            },
            new()
            {
                Id = 7,
                Name = "Nodachi",
                Category = WeaponCategories.Sword,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(1, 2),
                BaseDamage = 5,
                Deadliness = 6,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "-"
                    }
                },
                Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "ceremonial" or "razor-edged").ToList(),
                Rarity = 8,
                Price = new Price(2000),
                DescriptionId = GetWeaponDescriptions()["Nodachi"].Id
            },
            new()
            {
                Id = 8,
                Name = "Scimitar",
                Category = WeaponCategories.Sword,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(1, 1),
                BaseDamage = 4,
                Deadliness = 5,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.OneHanded,
                        Bonus = "-"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "durable" or "razor-edged").ToList(),
                Rarity = 8,
                Price = new Price(2000),
                DescriptionId = GetWeaponDescriptions()["Scimitar"].Id
            },
            new()
            {
                Id = 9,
                Name = "Wakizashi",
                Category = WeaponCategories.Sword,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(0, 1),
                BaseDamage = 3,
                Deadliness = 5,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.OneHanded,
                        Bonus = "-"
                    },
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "Deadliness +2"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "ceremonial" or "razor-edged").ToList(),
                Rarity = 7,
                Price = new Price(1500),
                DescriptionId = GetWeaponDescriptions()["Wakizashi"].Id
            },
            new()
            {
                Id = 10,
                Name = "Zanbatō",
                Category = WeaponCategories.Sword,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(1, 2),
                BaseDamage = 6,
                Deadliness = 7,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "-"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "cumbersome" or "wargear").ToList(),
                Rarity = 8,
                Price = new Price(4000),
                DescriptionId = GetWeaponDescriptions()["Zanbatō"].Id
            },
            new()
            {
                Id = 11,
                Name = "Masakari",
                Category = WeaponCategories.Axes,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(0, 1),
                BaseDamage = 3,
                Deadliness = 4,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.OneHanded,
                        Bonus = "-"
                    },
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "Deadliness +2"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "mundane").ToList(),
                Rarity = 5,
                Price = new Price(30),
                DescriptionId = GetWeaponDescriptions()["Masakari"].Id
            },
            new()
            {
                Id = 12,
                Name = "Ono",
                Category = WeaponCategories.Axes,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(1, 2),
                BaseDamage = 5,
                Deadliness = 6,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "-"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "wargear").ToList(),
                Rarity = 7,
                Price = new Price(500),
                DescriptionId = GetWeaponDescriptions()["Ono"].Id
            },
            new()
            {
                Id = 13,
                Name = "Club",
                Category = WeaponCategories.BluntWeapons,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(0, 1),
                BaseDamage = 5,
                Deadliness = 2,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.OneHanded,
                        Bonus = "-"
                    },
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "Damage +1"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "mundane").ToList(),
                Rarity = 1,
                Price = new Price(10),
                DescriptionId = GetWeaponDescriptions()["Club"].Id
            },
            new()
            {
                Id = 14,
                Name = "Hammer",
                Category = WeaponCategories.BluntWeapons,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(0, 1),
                BaseDamage = 5,
                Deadliness = 2,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.OneHanded,
                        Bonus = "-"
                    },
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "Damage +2"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "mundane").ToList(),
                Rarity = 4,
                Price = new Price(20),
                DescriptionId = GetWeaponDescriptions()["Hammer"].Id
            },
            new()
            {
                Id = 15,
                Name = "Kiseru",
                Category = WeaponCategories.BluntWeapons,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(0, 0),
                BaseDamage = 2,
                Deadliness = 2,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.OneHanded,
                        Bonus = "-"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "concealable" or "mundane").ToList(),
                Rarity = 5,
                Price = new Price(100),
                DescriptionId = GetWeaponDescriptions()["Kiseru"].Id
            },
            new()
            {
                Id = 16,
                Name = "Ōtsuchi",
                Category = WeaponCategories.BluntWeapons,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(1, 1),
                BaseDamage = 8,
                Deadliness = 3,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "-"
                    }
                },
                Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "cumbersome" or "mundane").ToList(),
                Rarity = 8,
                Price = new Price(3000),
                DescriptionId = GetWeaponDescriptions()["Ōtsuchi"].Id
            },
            new()
            {
                Id = 17,
                Name = "Tetsubō",
                Category = WeaponCategories.BluntWeapons,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(1, 2),
                BaseDamage = 7,
                Deadliness = 3,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "-"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "cumbersome" or "mundane" or "wargear").ToList(),
                Rarity = 5,
                Price = new Price(2000),
                DescriptionId = GetWeaponDescriptions()["Tetsubō"].Id
            },
            new()
            {
                Id = 18,
                Name = "Jitte",
                Category = WeaponCategories.HandWeapons,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(0, 0),
                BaseDamage = 3,
                Deadliness = 2,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.OneHanded,
                        Bonus = "-"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "concealable" or "snaring").ToList(),
                Rarity = 5,
                Price = new Price(10),
                DescriptionId = GetWeaponDescriptions()["Jitte"].Id
            },
            new()
            {
                Id = 19,
                Name = "Knife",
                Category = WeaponCategories.HandWeapons,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(0, 0),
                BaseDamage = 2,
                Deadliness = 4,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.OneHanded,
                        Bonus = "-"
                    },
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "Deadliness +2"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "concealable" or "mundane" or "razor-edged").ToList(),
                Rarity = 5,
                Price = new Price(100),
                DescriptionId = GetWeaponDescriptions()["Knife"].Id
            },
            new()
            {
                Id = 20,
                Name = "Nunchaku",
                Category = WeaponCategories.HandWeapons,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(0, 1),
                BaseDamage = 4,
                Deadliness = 3,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.OneHanded,
                        Bonus = "-"
                    },
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "Snaring"
                    }
                },
                //Qualities = new List<ItemQualityModel>(),
                Rarity = 6,
                Price = new Price(100),
                DescriptionId = GetWeaponDescriptions()["Nunchaku"].Id
            },
            new()
            {
                Id = 21,
                Name = "Tessen",
                Category = WeaponCategories.HandWeapons,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(0, 1),
                BaseDamage = 4,
                Deadliness = 3,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.OneHanded,
                        Bonus = "-"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "ceremonial" or "concealable").ToList(),
                Rarity = 7,
                Price = new Price(1500),
                DescriptionId = GetWeaponDescriptions()["Tessen"].Id
            },
            new()
            {
                Id = 22,
                Name = "Bisentō",
                Category = WeaponCategories.Polearms,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(2, 2),
                BaseDamage = 5,
                Deadliness = 2,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.OneHanded,
                        Bonus = "Range 1"
                    },
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "Damage +2"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "cumbersome" or "durable" or "wargear").ToList(),
                Rarity = 8,
                Price = new Price(1500),
                DescriptionId = GetWeaponDescriptions()["Bisentō"].Id
            },
            new()
            {
                Id = 23,
                Name = "Bō",
                Category = WeaponCategories.Polearms,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(1, 2),
                BaseDamage = 6,
                Deadliness = 2,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "-"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "mundane").ToList(),
                Rarity = 2,
                Price = new Price(20),
                DescriptionId = GetWeaponDescriptions()["Bō"].Id
            },
            new()
            {
                Id = 24,
                Name = "Ji",
                Category = WeaponCategories.Polearms,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(2, 2),
                BaseDamage = 5,
                Deadliness = 2,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "-"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "snaring" or "wargear").ToList(),
                Rarity = 6,
                Price = new Price(700),
                DescriptionId = GetWeaponDescriptions()["Ji"].Id
            },
            new()
            {
                Id = 25,
                Name = "Naginata",
                Category = WeaponCategories.Polearms,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(2, 2),
                BaseDamage = 6,
                Deadliness = 6,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "-"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "cumbersome" or "razor-edged" or "wargear").ToList(),
                Rarity = 8,
                Price = new Price(1000),
                DescriptionId = GetWeaponDescriptions()["Naginata"].Id
            },
            new()
            {
                Id = 26,
                Name = "Trident",
                Category = WeaponCategories.Polearms,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(2, 2),
                BaseDamage = 4,
                Deadliness = 4,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "-"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "snaring" or "wargear").ToList(),
                Rarity = 7,
                Price = new Price(1000),
                DescriptionId = GetWeaponDescriptions()["Trident"].Id
            },
            new()
            {
                Id = 27,
                Name = "Yari",
                Category = WeaponCategories.Polearms,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(2, 2),
                BaseDamage = 5,
                Deadliness = 3,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "-"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "wargear").ToList(),
                Rarity = 3,
                Price = new Price(500),
                DescriptionId = GetWeaponDescriptions()["Yari"].Id
            },
            new()
            {
                Id = 28,
                Name = "Daikyū",
                Category = WeaponCategories.Bows,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Ranged]"))?.Id ?? 0,
                Range = new Ranges(3, 5),
                BaseDamage = 6,
                Deadliness = 4,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "-"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "wargear").ToList(),
                Rarity = 6,
                Price = new Price(600),
                DescriptionId = GetWeaponDescriptions()["Daikyū"].Id
            },
            new()
            {
                Id = 29,
                Name = "Shinjo Horsebow",
                Category = WeaponCategories.Bows,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Ranged]"))?.Id ?? 0,
                Range = new Ranges(2, 4),
                BaseDamage = 4,
                Deadliness = 5,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "-"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "wargear").ToList(),
                Rarity = 4,
                Price = new Price(600),
                DescriptionId = GetWeaponDescriptions()["Shinjo Horsebow"].Id
            },
            new()
            {
                Id = 30,
                Name = "Yumi",
                Category = WeaponCategories.Bows,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Ranged]"))?.Id ?? 0,
                Range = new Ranges(2, 5),
                BaseDamage = 5,
                Deadliness = 3,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "-"
                    }
                },
                //Qualities = new List<ItemQualityModel>(),
                Rarity = 3,
                Price = new Price(300),
                DescriptionId = GetWeaponDescriptions()["Yumi"].Id
            },
            new()
            {
                Id = 31,
                Name = "Oyumi",
                Category = WeaponCategories.Crossbows,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Ranged]"))?.Id ?? 0,
                Range = new Ranges(2, 5),
                BaseDamage = 7,
                Deadliness = 3,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "-"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "prepare" or "wargear").ToList(),
                Rarity = 8,
                Price = new Price(400),
                DescriptionId = GetWeaponDescriptions()["Oyumi"].Id
            },
            new()
            {
                Id = 32,
                Name = "Blowgun",
                Category = WeaponCategories.SpecialistWeapons,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Ranged]"))?.Id ?? 0,
                Range = new Ranges(2, 3),
                BaseDamage = 1,
                Deadliness = 2,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.OneHanded,
                        Bonus = "-"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "concealable").ToList(),
                Rarity = 7,
                Price = new Price(50),
                DescriptionId = GetWeaponDescriptions()["Blowgun"].Id
            },
            new()
            {
                Id = 33,
                Name = "Kama",
                Category = WeaponCategories.SpecialistWeapons,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(0, 1),
                BaseDamage = 3,
                Deadliness = 3,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.OneHanded,
                        Bonus = "-"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "concealable").ToList(),
                Rarity = 4,
                Price = new Price(100),
                DescriptionId = GetWeaponDescriptions()["Kama"].Id
            },
            new()
            {
                Id = 34,
                Name = "Kusari-Gama",
                Category = WeaponCategories.SpecialistWeapons,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(0, 0),
                BaseDamage = 3,
                Deadliness = 3,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.OneHanded,
                        Bonus = "-"
                    },
                    new()
                    {
                        GripType = GripTypes.TwoHanded,
                        Bonus = "Range 2-3"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "concealable" or "snaring" or "wargear").ToList(),
                Rarity = 6,
                Price = new Price(500),
                DescriptionId = GetWeaponDescriptions()["Kusari-Gama"].Id
            },
            new()
            {
                Id = 35,
                Name = "Shuriken",
                Category = WeaponCategories.SpecialistWeapons,
                SkillId = GetSkills().FirstOrDefault(s => s.Name.StartsWith("Martial Arts [Melee]"))?.Id ?? 0,
                Range = new Ranges(0, 0),
                BaseDamage = 2,
                Deadliness = 4,
                Grips = new List<Grip>()
                {
                    new()
                    {
                        GripType = GripTypes.OneHanded,
                        Bonus = "-",
                        ExtraDescription = "(stab or slash)"
                    },
                    new()
                    {
                        GripType = GripTypes.OneHanded,
                        Bonus = "Martial Arts [Ranged], Range 1-3",
                        ExtraDescription = "(thrown)"
                    }
                },
                //Qualities = GetItemQualities().Where(q => q.Name.ToLower() is "concealable").ToList(),
                Rarity = 6,
                Price = new Price(100),
                DescriptionId = GetWeaponDescriptions()["Shuriken"].Id
            }
        };
    }

    private Dictionary<string, LongText> GetSkillGroupDescriptions()
    {
        return new Dictionary<string, LongText>
        {
            {
                "Artisan",
                new LongText()
                {
                    Id = Guid.Parse("03b6062e-7c0e-4ba0-93ab-f3b41c13261b"),
                    Text = @"The high arts of Rokugan have a
                            powerful influence on society. While commoners
                            produce most items in Rokugan, artisans
                            produce influential, sometimes even supernatural
                            works that can alter the course of history.
                            Artisan skills allow characters to engage in the
                            process of creating art."
                }
            },
            {
                "Martial",
                new LongText()
                {
                    Id = Guid.Parse("1f28aca2-2231-47cd-b8a9-fa487c3c2c4a"),
                    Text = @"Samurai were originally warriors,
                            and while members of this societal strata fill
                            many roles in Rokugan now, it is still steeped
                            in martial traditions. As such, Martial skills
                            are seen as being of utmost importance.
                            Martial skills allow characters to fight in duels
                            or battles, defeat physical challenges, successfully
                            wage war, and overcome their own
                            mental limits."
                }
            },
            {
                "Scholar",
                new LongText()
                {
                    Id = Guid.Parse("574fea87-6fc0-488f-b452-22d4cbaf7784"),
                    Text = @"Information is power, and Scholar
                            skills give a character access to information about
                            society, the world, and other people. Scholar
                            skills allow characters to recall information, identify
                            things related to an area of expertise, observe
                            their environment, and draw conclusions."
                }
            },
            {
                "Social",
                new LongText()
                {
                    Id = Guid.Parse("758a9a52-f869-49f7-87bd-4234e1018a27"),
                    Text = @"Courtiers hold incredible sway in
                            Rokugan, negotiating the agreements by which
                            wars are waged and averted and influencing
                            marriages, trade, and other events of great
                            import in the lives of samurai. Thus, Social skills
                            are at least somewhat important to almost all
                            samurai, from the most silver-tongued denizens
                            of ruling courts to the roughest of field soldiers.
                            Social skills allow characters to affect the emotions
                            and thoughts of others through rhetoric,
                            behavior, and body language."
                }
            },
            {
                "Trade",
                new LongText()
                {
                    Id = Guid.Parse("148939ba-86eb-4c5b-8df0-c230f8257589"),
                    Text = @"These are skills most commonly
                            practiced by occupants of the bottom tiers of
                            Rokugan’s stratified society. Trade skills allow
                            characters to procure resources from their environment
                            and perform work"
                }
            }
        };
    }

    public List<SkillGroupModel> GetSkillGroups()
    {
        return new List<SkillGroupModel>()
        {
            new()
            {
                Id = 1, Name = "Artisan", DescriptionId = SkillGroupDescriptions["Artisan"].Id
            },
            new()
            {
                Id = 2, Name = "Martial", DescriptionId = SkillGroupDescriptions["Martial"].Id
            },
            new()
            {
                Id = 3, Name = "Scholar", DescriptionId = SkillGroupDescriptions["Scholar"].Id
            },
            new()
            {
                Id = 4, Name = "Social", DescriptionId = SkillGroupDescriptions["Social"].Id
            },
            new()
            {
                Id = 5, Name = "Trade", DescriptionId = SkillGroupDescriptions["Trade"].Id
            }
        };
    }
    private Dictionary<string, LongText> GetSkillDescriptions()
    {
        return new Dictionary<string, LongText>
        {
            {
                "Aesthetics", new LongText()
                {
                    Id = Guid.Parse("1879583a-b7bb-455d-93d6-b4fbee6078a2"),
                    Text = @"Art has been expected to be half of a samurai’s pursuits
                            since the founding of the Empire. An appreciation
                            and understanding of art is so ingrained in a samurai’s
                            training that to look upon a work and not be moved is,
                            to the samurai, a sure sign of barbarianism, a charge
                            that bestows great shame upon those who bear it. The
                            more martial clans understand that art is essential for
                            clearing a warrior’s mind and reminding them of life
                            while so often surrounded by death.
                            The Aesthetics skill covers activities that create
                            non-utilitarian visual art, such as bonsai (trimming
                            plants to encourage their growth in an artistic fashion),
                            ikebana (flower arrangement), origami, painting,
                            and rock gardening. Such arts serve a deeply important
                            role in the courts of Rokugan, and any courtier is
                            expected to have an understanding of their principles,
                            techniques, and guiding philosophies. By understanding
                            a work of art, one can gain insight into its creator,
                            and that insight can be invaluable in pursuing political
                            agendas and court intrigue alike."
                }
            },
            {
                "Composition", new LongText()
                {
                    Id = Guid.Parse("d80bc5bf-4931-4fd1-857e-497eccdbf342"),
                    Text = @"Almost all samurai are literate, for holding nearly any
                            office, bureaucratic or military, requires the ability to
                            read and write. Thus, while not all samurai explore the
                            finer points of wordsmithing, literature is an elevated
                            art in Rokugan. Courtly samurai are expected to know
                            dozens of classic poems by heart and grasp literary
                            allusions that can provide important subtext in conversation.
                            The best poets compose in the moment, with
                            every sentence they speak layered with meaning.
                            Haiku, a three-line poem with five syllables in the first
                            line, seven in the second, then five in the last, is one of
                            the most popular forms of poetry in Rokugan. Writers
                            often use it to describe a moment in time, from the first
                            snowflake seen in winter to a moment of tranquility by a
                            pond. Others practice different forms of poetry, including
                            longer poems and competitions of linked poems
                            traded back and forth, or write prose in the form of travel
                            diaries, philosophical essays, and even fantastical tales.
                            Literature allows a character to create powerful
                            compositions that sway readers and to understand the
                            literary devices and allusions that underlie such influential
                            works. Additionally, the aesthetics of calligraphy are
                            important to many writers in Rokugan, so Composition
                            also governs the act of putting words on a surface in
                            ink in a pleasing way."
                }
            },
            {
                "Design", new LongText()
                {
                    Id = Guid.Parse("17a19c61-26cb-433e-aa2e-64a366d31239"),
                    Text = @"Presentation matters. At court, it is often said that
                            beautiful looks reflect a beautiful soul, and also whispered
                            that one whose soul is corrupt will display physical
                            signs of that corruption. Despite wiser words on the
                            subject by Shinsei and other sages, a skilled samurai
                            who dresses shabbily will often be seen as lesser than
                            the barely competent one who is well dressed.
                            Design covers the act of making clothes for times of
                            peace and formal occasions. After all, arms and armor
                            are not appropriate for all situations in a samurai’s life,
                            much as some individuals might lament this reality.
                            However, that does not mean that a samurai attending
                            court can afford to choose their garments with any less
                            care than when they take to the battlefield. Carefully
                            selected clothes and adornments are vital weapons
                            and armor to courtiers, allowing them to send subtle
                            signals to others and avoid humiliation at the hands of
                            enemies. Thus, the creation, maintenance, and assessment
                            of clothing is an important field of expertise,
                            allowing a character to create and improve on items
                            worn in many formal situations."
                }
            },
            {
                "Smithing", new LongText()
                {
                    Id = Guid.Parse("923f8290-f0f3-4e6d-a2de-db55c18540d4"),
                    Text = @"Samurai are warriors, and even their arts are influenced
                            by war. The Smithing skill covers the creation of arms
                            and armor for ceremonial and battlefield use. Many
                            samurai go into battle wielding armor and weaponry
                            that are stunning works of art in their own right.
                            The finest armor and weapons—especially the
                            daishō—are created with an eye toward both use and
                            aesthetic, as they will be in service for centuries. They
                            must reflect the influence and wealth of the family that
                            owns them, for the sword is said to be the outward
                            manifestation of the samurai’s soul. Ruling families have
                            weapons hundreds of years old, displayed in a place of
                            honor as a living reminder of each family’s history. The
                            Phoenix and Crane are famous for the beauty of their
                            work, while the Crab blades are known for durability and
                            effectiveness. Those rare creations worked by a Kakita
                            smith are widely acknowledged to be the greatest of all."
                }
            },
            {
                "Command", new LongText()
                {
                    Id = Guid.Parse("7aa51fd4-3e68-452c-9d74-c2c451d9b1df"),
                    Text = @"The ability to speak authoritatively is as imperative for
                            the courtier—who guide their charges through complicated
                            ceremonies and social events—as it is for the
                            bushi—who shepherds their soldiers through battles
                            and wars. Lives hang in the balance, and one word can
                            inspire victory or lead to disaster. When chaos arises,
                            it is the duty of those in command to take charge and
                            to instill order, and they will be the ones judged on the
                            success or failure of the operation, not their underlings.
                            The Command skill is used to instill obedience,
                            whether in court or on the battlefield. It is generally
                            most effective when used to motivate subordinates
                            rather than peers, or in the context of a clear command
                            structure, as it revolves around telling others what to
                            do (and, usually, expecting them to do it)."
                }
            },
            {
                "Courtesy", new LongText()
                {
                    Id = Guid.Parse("7b29a2b0-36ea-44be-961f-d77bac1418c1"),
                    Text = @"The essential Social skill of Rokugan’s highest circles
                            of power, the Courtesy skill represents a character’s
                            ability to influence others’ opinions, persuade others
                            to a course of action, outmaneuver their opponents,
                            win arguments, steer a conversation in a desired direction,
                            and deliver cunning put-downs—all without ever
                            openly giving offense or stepping beyond the complex
                            rules of Rokugani etiquette.
                            In the vicious world of court politics, politeness is
                            a deadly weapon in a courtier’s arsenal. Baiting someone
                            to an outburst of emotion can destroy their reputation
                            and earn their enmity for life, while deflecting
                            someone’s wrath onto oneself, taking the blame for a
                            mistake, can put them in one’s debt and foster new
                            alliances. Courtesy is also needed when one wishes to
                            influence the perceived truth of a matter that may be in
                            question, regardless of the actual truth."
                }
            },
            {
                "Games", new LongText()
                {
                    Id = Guid.Parse("ea6a04a7-9e1c-4541-b220-5fd28475646f"),
                    Text = @"Games are an important tool at court, serving as a vital
                            outlet for the rivalries that develop in the highest circles
                            of power and as a crucial opportunity to maintain
                            and develop relationships, especially outside of the
                            strict confines that one’s station would usually dictate.
                            As a result, success at games is one way
                            a new arrival at court can earn distinction
                            and get access to people of much higher
                            rank, whom they would otherwise be
                            unable to approach. However, only the
                            truly naïve overlook the fact that games
                            are merely one more means to an end in
                            the shifting world of court politics.
                            The games of Rokugan are as varied
                            as the clans, but first among them is Go, a
                            game played with black and white stones
                            and a wooden board. Played by peasant and
                            Emperor, young and old, bushi and monk, it
                            can be found in all walks of life in Rokugan.
                            The rules are simple, but mastering the game
                            requires years of dedication; proficiency is always
                            worthy of respect.
                            Other games include Fortunes and Winds, a dice
                            game many samurai see as a pastime for the lower
                            classes; Sadane, a game of biting insults that courtiers
                            enjoy; Karuta, a card game of trick taking using both
                            illustrations and lines of poetry; and Shōgi, a tactical
                            game of generals, cavalry, and assorted soldiers."
                }
            },
            {
                "Performance", new LongText()
                {
                    Id = Guid.Parse("aebc434f-6060-47ff-aae8-2455ad957fa0"),
                    Text = @"The Performance skill pertains to the act of entertaining
                            others with active arts, from song to dance to storytelling.
                            Performances of sufficient caliber can help
                            to bridge political divides, influence people to rethink
                            their lives, or even set off artistic or political movements.
                            Performance is also used for impersonating others,
                            though obviously doing so would be dishonorable.
                            Performers occupy an unusual place in Rokugan.
                            Commoners who practice the performing arts are
                            treated poorly by the upper classes and are considered
                            unworthy of the status of craftspeople or farmers.
                            However, every court features musicians, dancers,
                            and artists who are of common birth but are allowed to
                            bring entertainment to those of high station. Their dishonorable
                            status is tolerably ignored—as long as they
                            entertain their betters. Meanwhile, samurai performers
                            are praised by their peers for having an “expressive
                            nature,” or a “poetic soul.”"
                }
            },
            {
                "Culture", new LongText()
                {
                    Id = Guid.Parse("b8e30628-b535-4c91-b168-ccccf49cee88"),
                    Text = @"Like most countries, the Emerald Empire has a wealth
                            of ceremonies, festivals, social trends, and local practices
                            that locals largely internalize. The Culture skill can
                            be used to procure knowledge of these traditions and
                            practices, even when a character is far from home.
                            The Culture skill covers knowledge of the Emerald
                            Empire’s customs, traditions, families, trends, geography,
                            and practices. This includes recent goings-on,
                            historical events, and persons of significance, as well
                            as staying current with the fashions that hold sway over
                            the courts of provincial lords and the Emperor.
                            While such knowledge might seem trivial, it can
                            allow a character to learn where to meet people of
                            importance in a new place, how to interact comfortably
                            with the locals, and what recent news to avoid mentioning
                            while making pleasant conversation."
                }
            },
            {
                "Government", new LongText()
                {
                    Id = Guid.Parse("62489655-9d8e-4f19-95ff-53abcdf51a56"),
                    Text = @"The daimyō of the samurai clans, who rule the various
                            provinces of the Emerald Empire in the Emperor’s
                            name, must serve in many capacities. Each of these
                            individuals must be part warlord, part courtier, and part
                            bureaucrat, and they must act effectively in each of
                            these spheres to maintain their rule. This encompasses
                            a strong understanding of political machinations,
                            a solid foundation in logistics, and a familiarity with
                            Rokugan’s strict and sometimes arcane legal system,
                            which favors status rather than testimony and propriety
                            over evidence. Most daimyō keep a number of valued
                            retainers who are experts in these fields close to them
                            for consultation."
                }
            },
            {
                "Medicine", new LongText()
                {
                    Id = Guid.Parse("4a494aae-1dc9-49b9-9c88-2aeeed24584e"),
                    Text = @"The healers of Rokugan, epitomized by Lady Asako herself,
                            have dedicated themselves to understanding the
                            mystical underpinnings of wellness and disease, and to
                            rebalance the body’s natural ability to heal itself using a
                            combination of pressure points, correspondences, and
                            herbal remedies. The Medicine skill encompasses all of
                            these elements.
                            Prospective healers must first understand the systems
                            of the body, and then gain the practical knowledge
                            of how to apply their knowledge to properly
                            diagnose and treat their patients. Of course, some dishonorable
                            characters use their medicinal knowledge to
                            cause harm instead of to heal, meddling with doses
                            to create deleterious or even deadly side effects, or
                            selecting toxic herbs with which to poison a rival.
                            More practical in its application than some other
                            Scholar skills, Medicine covers knowledge of the
                            human body and its functions. However, Medicine is
                            also a practiced art, so it often behaves like an Artisan
                            skill when used to heal injuries or create medicines.
                            While any skill can operate with another skill group’s
                            approaches, it is fairly common for the Medicine skill to
                            do so. Thus, several examples of when it uses Artisan
                            skill approaches are noted in the following text."
                }
            },
            {
                "Sentiment", new LongText()
                {
                    Id = Guid.Parse("0882d9c1-323a-42b4-9225-9261b99658db"),
                    Text = @"The Sentiment skill reflects a character’s ability to understand
                            the psychology and emotions of others. It is used
                            to spot emotions like hostility and fear in others, to
                            empathize, and to know how people will behave based
                            on their emotional state. It is also used to see through
                            lies—and understand why those lies are being told."
                }
            },
            {
                "Theology", new LongText()
                {
                    Id = Guid.Parse("6d59586f-7b4e-497f-9db1-b2a403c021ce"),
                    Text = @"Theology covers knowledge of religious philosophy,
                            doctrine, and practice. Rokugan is often called the
                            Land of Ten Thousand Fortunes, and a proper grounding
                            in Theology is required to know of even a portion
                            of them. A character can use Theology to know about
                            kami, the Fortunes, and the powers and deities associated
                            with Shinseism and other religious traditions,
                            as well as to make supplications to these powers. A
                            character versed in Theology is also versed in religious
                            history and associated knowledge, including astronomy
                            (for the study of portents) and the related fields of
                            metaphysics and science with mystical implications.
                            Theology is also the skill used for most invocations—
                            the powerful appeals to the kami that shugenja
                            make to wield astonishing elemental powers. However,
                            for most characters, Theology does not involve such
                            flashy displays, dealing more in the doctrines and histories
                            of the various spiritual traditions of Rokugan. It
                            usually entails knowledge of rituals of philosophical
                            and religious significance, as well as of communion with
                            the forces of the universe on a more subtle level. Not
                            everyone has the potential to become a shugenja—and
                            perhaps more importantly, the shugenja schools guard
                            their secrets jealously—so most priests in the Emerald
                            Empire are humble keepers of the faith, serving the
                            kami via proper veneration and performing social and
                            religious functions for their communities. Monks, courtiers,
                            and even bushi are also likely to study Theology,
                            for a variety of personal and societal reasons."
                }
            },
            {
                "Fitness", new LongText()
                {
                    Id = Guid.Parse("06ddcb2c-c011-4b2b-bed7-336258a71b26"),
                    Text = @"Fitness is a reflection of a samurai’s capacity to perform
                            feats of physical prowess and grace. It governs activities
                            such as running, leaping, lifting heavy objects,
                            marching long distances, swimming quickly, and other
                            such physical feats that rely on quick bursts of power
                            and precision or sustained physical effort. Additionally,
                            the Fitness skill governs a character’s ability to avoid
                            lethal harm when struck, resist the Shadowlands Taint,
                            and recover from poison and disease. Finally, Fitness
                            can be used to resist, withstand, or otherwise take a hit
                            on the battlefield."
                }
            },
            {
                "Martial Arts [Melee]", new LongText()
                {
                    Id = Guid.Parse("9bf05308-4c5d-498c-9b83-441934b9879d"),
                    Text = @"Whatever other arts they practice, a bushi’s foremost
                            art is always the art of battle, and even samurai who
                            rarely take the field often train extensively in the martial
                            arts as an exercise in self-mastery. Nearly all of them
                            receive some training in use of a melee weapon, even if
                            they prefer a weapon such as a bow. While many samurai
                            believe sword fighting to be the most refined of
                            martial arts, there are numerous schools that are more
                            renowned for their use of other melee weapons. Samurai
                            in Rokugan use the great clubs known as tetsubō,
                            spears, naginata and other polearms, and even staves,
                            depending on the teachings of their school and their
                            own personal preferences.
                            Martial Arts [Melee] covers combat with close-quarters
                            weapons in both practice and theory."
                }
            },
            {
                "Martial Arts [Ranged]", new LongText()
                {
                    Id = Guid.Parse("bba94dda-3c39-48f0-b53d-9ba014a0e369"),
                    Text = @"Any warrior who takes the battlefield regularly knows
                            well the value of the bow—and the risks of underestimating
                            it. While armor can often turn an arrow at range
                            and it is no replacement for a melee weapon once battle
                            lines close, the effect of a well-coordinated volley
                            can be staggering, as each wounded warrior removes
                            not just one enemy from the field, but any other combatants
                            who move to retrieve them. A master archer
                            is terrifying to behold, capable of slaying foes from
                            considerable distances. Even humble ranged weapons,
                            such as slings and hurled projectiles, can be quite
                            deadly in a fight, removing combatants from the battle.
                            On the other end of the spectrum, the Crab Clan has
                            constructed numerous siege-scale ranged weapons
                            meant to engage large demons and other supernatural
                            horrors from high atop the Kaiu Wall.
                            Martial Arts [Ranged] covers combat with thrown
                            and projectile weapons in both practice and theory."
                }
            },
            {
                "Martial Arts [Unarmed]", new LongText()
                {
                    Id = Guid.Parse("c7949ac1-bbc9-4108-8a10-9d10c046e441"),
                    Text = @"Most samurai practice unarmed fighting. It is an important
                            element of many armed combat styles, as in actual
                            practice, armed and unarmed combat are deeply intertwined.
                            Some schools, however, teach it exclusively, for
                            philosophical or practical reasons. Monks, for instance,
                            cannot legally wield daishō, and thus are often practitioners
                            of advanced unarmed techniques.
                            As with other martial arts, traditions spring up and
                            vanish frequently over the centuries, and when visiting
                            a monastery, it is not uncommon to discover that its
                            members practice arts rarely seen outside its walls.
                            Martial Arts [Unarmed] covers combat with the
                            body as one’s primary weapon in both practice and
                            theory, as well as the use of some improvised weapons."
                }
            },
            {
                "Meditation", new LongText()
                {
                    Id = Guid.Parse("c7949ac1-bbc9-4108-8a10-9d10c046e441"),
                    Text = @"The life of a samurai is one of stress and turmoil.
                            Meditation helps a samurai look past worries about
                            tomorrow, missed opportunities of the past, and
                            even the insistence of the world of now to find peace
                            within themself.
                            Martial skills are defined by struggle, and for many
                            warriors, the greatest struggle is the one within. Meditation
                            is the skill that covers the battles fought in one’s
                            own mind. It is the skill used to process one’s own emotions,
                            to recover mental control when shocked, and
                            to resist confusion and supernatural influence of the
                            mind. War might be a samurai’s pursuit, but a human
                            being at war must face the steady erosion of the soul or
                            risk succumbing completely to brutality. Most samurai
                            train in Meditation both to ready their minds for the
                            terrors of battle and to seek greater cosmic knowledge
                            within themselves."
                }
            },
            {
                "Tactics", new LongText()
                {
                    Id = Guid.Parse("481E4264-F1E6-4112-9E88-BB669FC4FA3C"),
                    Text = @"Leadership is not just charisma and force of will—a
                            samurai who takes the battlefield must also make wise
                            decisions. Battles are not won without casualties, and
                            every commander spends the lives of their soldiers to
                            achieve victory, but this does not mean that they value
                            these lives any less.
                            Samurai learn many arts, but the practice of war is
                            among their core functions. While it may be true that
                            every battle’s outcome is decided before the first soldier
                            moves, it falls to battlefield leaders, from generals
                            to squad sergeants, to make that outcome a reality.
                            Tactics governs battlefield leadership, from the general’s
                            tent to the front line. It reflects a character’s awareness
                            of the flow of battle and their ability to both stick
                            to their orders and seize the opportunities that arise
                            to greatest effect. While the Command skill is used to
                            motivate soldiers, restore morale, and maintain order,
                            the Tactics skill is used to effectively manage troops
                            who are already obedient. Whereas the Government
                            skill handles logistics in the lead-up to battle, the Tactics
                            skill governs a character’s ability to think and react
                            once the battle is joined."
                }
            },
            {
                "Commerce", new LongText()
                {
                    Id = Guid.Parse("d457ba6d-8f6c-4a4a-a0dd-f7d229ea7a00"),
                    Text = @"The Commerce skill covers the buying and selling of
                            goods for a profit, as well as related activities. At its
                            heart, commerce is not about negotiating for a better
                            price (it is unseemly to give someone less than their
                            work is worth, after all) but of knowing how to play
                            the market to exchange more goods for less work. To
                            operate any sort of business successfully, a character
                            must have at least a cursory proficiency in this skill, for
                            without it, they are sure to see their fortunes collapse.
                            Most samurai view money as a societal necessity,
                            but a “dirty” one—after all, their lords provide
                            them with the tools and equipment they require. In
                            Rokugan, skill with money is the skill that no one values
                            but everyone needs. Further, they see merchants
                            as creating nothing, and so most of Rokugan puts merchants
                            below peasants in the social order. However, in
                            many cities, merchants are as powerful as samurai, and
                            far wealthier."
                }
            },
            {
                "Labor", new LongText()
                {
                    Id = Guid.Parse("d457ba6d-8f6c-4a4a-a0dd-f7d229ea7a00"),
                    Text = @"Shinsei spoke highly of the simple virtues of manual
                            work, and while most samurai (and most peasants, for
                            that matter) disagree with his glowing assessment,
                            none can deny that society’s existence requires a
                            great deal of backbreaking labor on somebody’s part.
                            From farming to construction to simple ditch-digging,
                            countless tasks must be completed for the Emerald
                            Empire to continue functioning.
                            The skills in the Labor skill group are all complicated
                            areas of expertise in their own right, even if samurai
                            tend to look askance at them as fields of study. Farmers
                            know a great deal of their fields, potters of their art,
                            and smiths of metallurgy, even if they are not revered
                            by the ruling class for the mastery they achieve. Those
                            skilled in labor are those who know the most efficient
                            ways of performing their duties, as well as how to effectively
                            use the tools of their trade."
                }
            },
            {
                "Seafaring", new LongText()
                {
                    Id = Guid.Parse("3c7caaa2-7d10-4f98-ab23-051d677d58c1"),
                    Text = @"Though many Rokugani live their whole lives without
                            seeing the ocean, it has an enormous impact on the
                            entire country. A great deal of Rokugan’s food and staples
                            such as salt come from the sea. Further, despite
                            Rokugan’s inhospitable policy toward foreigners, foreign
                            trade does occur in numerous port cities, both
                            under the sanction of the Empire and clandestinely.
                            The sailors who steer these vessels comprehend
                            the arts of navigation, knot-tying, sail-setting, and a
                            thousand odd jobs, and they must understand how
                            these disparate duties fit together or risk being lost
                            on the open seas. The Seafaring skill also handles river
                            travel. Rivers are often the fastest roads in the Emerald
                            Empire, and barges are a key element as travel and
                            trade alike. Grain, tea, sake, logs, mineral wealth, and
                            other supplies are often moved from city to city by river,
                            or to the coast where larger ships move them to
                            major ports. An expert seafarer can be the difference
                            between a force arriving on time for a battle or a day
                            behind, and keeping those armies fed."
                }
            },
            {
                "Skulduggery", new LongText()
                {
                    Id = Guid.Parse("faccaf45-a3cd-4c96-ae3e-9bb07a9c9c2d"),
                    Text = @"The rule of law is not absolute in the Emerald Empire,
                            no matter how harsh the consequences for breaking
                            the law often are. Criminal elements exist everywhere,
                            primarily in the form of bandits and dispossessed individuals.
                            While brigands and thieves usually turn to this
                            path out of necessity and almost invariably struggle
                            to survive, some criminals are tremendously successful,
                            creating massive cartels and criminal operations
                            that spread across numerous cities. Skulduggery also
                            includes the craft of spies, as many of the tricks they
                            use are similar to those of criminals. Sleight of hand,
                            stealth, disguise, lockpicking, and trapmaking are just
                            as important to the criminal and spymaster’s portfolio
                            as is deception, dissembling, and misdirection."
                }
            },
            {
                "Survival", new LongText()
                {
                    Id = Guid.Parse("faccaf45-a3cd-4c96-ae3e-9bb07a9c9c2d"),
                    Text = @"Whether this means hunting, fishing, gathering plants,
                            or even engaging in small operations such as prospecting
                            for ore or acquiring other valuable goods for trade,
                            it is crucial to the survival of many people in Rokugan.
                            Scouts and wayfinders take this a step further to be
                            able to navigate and conceal their paths through the
                            wilderness, as well as to cross large distances by foot or
                            on horseback in the shortest possible amount of time.
                            Hunting dogs and birds, riding steeds, and beasts
                            of burden go a long way to ensure survival in
                            the roughest of terrain and climates, and
                            so these creatures must be properly
                            cared for and trained.
                            Most samurai tend to have only a passing familiarity
                            with this sort of subsistence living, though some clans
                            and schools encourage their members to learn basic
                            proficiency at survival in the wild; especially if they rule
                            a domain far from larger cities."
                }
            }
        };
    }

    public List<SkillModel> GetSkills()
    {
        return new List<SkillModel>()
        {
            
            new()
            {
                Id = 1,
                Name = "Aesthetics",
                DescriptionId = SkillDescriptions["Aesthetics"].Id,
                SkillGroupId = 1
            },
            new()
            {
                Id = 2,
                Name = "Composition",
                DescriptionId = SkillDescriptions["Composition"].Id,
                SkillGroupId = 1
            },
            new()
            {
                Id = 3,
                Name = "Design",
                DescriptionId = SkillDescriptions["Design"].Id,
                SkillGroupId = 1
            },
            new()
            {
                Id = 4,
                Name = "Smithing",
                DescriptionId = SkillDescriptions["Smithing"].Id,
                SkillGroupId = 1
            },
            new()
            {
                Id = 5,
                Name = "Command",
                DescriptionId = SkillDescriptions["Command"].Id,
                SkillGroupId = 4
            },
            new()
            {
                Id = 6,
                Name = "Courtesy",
                DescriptionId = SkillDescriptions["Courtesy"].Id,
                SkillGroupId = 4
            },
            new()
            {
                Id = 7,
                Name = "Games",
                DescriptionId = SkillDescriptions["Games"].Id,
                SkillGroupId = 4
            },
            new()
            {
                Id = 8,
                Name = "Performance",
                DescriptionId = SkillDescriptions["Performance"].Id,
                SkillGroupId = 4
            },
            new()
            {
                Id = 9,
                Name = "Culture",
                DescriptionId = SkillDescriptions["Culture"].Id,
                SkillGroupId = 3
            },
            new()
            {
                Id = 10,
                Name = "Government",
                DescriptionId = SkillDescriptions["Government"].Id,
                SkillGroupId = 3
            },
            new()
            {
                Id = 11,
                Name = "Medicine",
                DescriptionId = SkillDescriptions["Medicine"].Id,
                SkillGroupId = 3
            },
            new()
            {
                Id = 12,
                Name = "Sentiment",
                DescriptionId = SkillDescriptions["Sentiment"].Id,
                SkillGroupId = 3
            },
            new()
            {
                Id = 13,
                Name = "Theology",
                DescriptionId = SkillDescriptions["Theology"].Id,
                SkillGroupId = 3
            },
            new()
            {
                Id = 14,
                Name = "Fitness",
                DescriptionId = SkillDescriptions["Fitness"].Id,
                SkillGroupId = 2
            },
            new()
            {
                Id = 15,
                Name = "Martial Arts [Melee]",
                DescriptionId = SkillDescriptions["Martial Arts [Melee]"].Id,
                SkillGroupId = 2
            },
            new()
            {
                Id = 16,
                Name = "Martial Arts [Ranged]",
                DescriptionId = SkillDescriptions["Martial Arts [Ranged]"].Id,
                SkillGroupId = 2
            },
            new()
            {
                Id = 17,
                Name = "Martial Arts [Unarmed]",
                DescriptionId = SkillDescriptions["Martial Arts [Unarmed]"].Id,
                SkillGroupId = 2
            },
            new()
            {
                Id = 18,
                Name = "Meditation",
                DescriptionId = SkillDescriptions["Meditation"].Id,
                SkillGroupId = 2
            },
            new()
            {
                Id = 19,
                Name = "Tactics",
                DescriptionId = SkillDescriptions["Tactics"].Id,
                SkillGroupId = 2
            },
            new()
            {
                Id = 20,
                Name = "Commerce",
                DescriptionId = SkillDescriptions["Commerce"].Id,
                SkillGroupId = 5
            },
            new()
            {
                Id = 21,
                Name = "Labor",
                DescriptionId = SkillDescriptions["Labor"].Id,
                SkillGroupId = 5
            },
            new()
            {
                Id = 22,
                Name = "Seafaring",
                DescriptionId = SkillDescriptions["Seafaring"].Id,
                SkillGroupId = 5
            },
            new()
            {
                Id = 23,
                Name = "Skulduggery",
                DescriptionId = SkillDescriptions["Skulduggery"].Id,
                SkillGroupId = 5
            },
            new()
            {
                Id = 24,
                Name = "Survival",
                DescriptionId = SkillDescriptions["Survival"].Id,
                SkillGroupId = 5
            }
        };
    }

    public Dictionary<string, LongText> GetItemQualitiesDescription()
    {
        return new Dictionary<string, LongText>
        {
            {
                "Ceremonial", new LongText()
                {
                    Id = Guid.Parse("fc81b4aa-eb77-48d1-aa72-e6664b30a5bc"),
                    Text = @"Ceremonial equipment is indicative of the wearer’s
                            rank. It can be brought into many contexts in which
                            similar items might not be allowed. Rarely, a character
                            might be loaned a Ceremonial item to provide them
                            with authority during a task.
                            While wearing one or more Ceremonial items openly,
                            reduce TN of checks to convince others of your real
                            or assumed identity as the known owner of that item
                            (or one of their allies) by 1.
                            At the end of any scene in which you use a Ceremonial
                            item of a character with higher status without their
                            permission, you must forfeit 3 honor."
                }
            },
            {
                "Concealable", new LongText()
                {
                    Id = Guid.Parse("dfd36c34-9c81-4e52-b0cf-354bb949cbc2"),
                    Text = @"Some weapons and armor are easy to hide on one’s
                            person, due to size or deliberate design.
                            Unless explicitly worn openly or revealed for use,
                            a Concealable item is assumed to be hidden. When
                            observing the wearer of a hidden item, a character
                            must succeed at a TN 3 Design (Air) or Smithing
                            (Air) check to discern that the wearer is armed or
                            armored. If the onlooker succeeds with two or more
                            bonus successes, they also determine the type of the
                            hidden item.
                            Concealable armor can be worn under loose-fitting
                            clothes, but you can only benefit from the resistance and
                            qualities of one set of armor at a time (see page 238).
                            Concealable weapons can also be drawn more
                            quickly in combat. As part of an Attack action, you may
                            ready or sheathe one Concealable weapon."
                }
            },
            {
                "Cumbersome", new LongText()
                {
                    Id = Guid.Parse("89d3bcfd-2c6b-4477-9494-325e62b84575"),
                    Text = @"This item is heavy or unwieldy, and impossible to conceal
                            on one’s person.
                            While wearing Cumbersome armor, increase the TN
                            of your checks to maneuver in your environment (such
                            as Movement action checks) by 1.
                            If you moved this turn, increase the TN of Attack
                            action checks using a Cumbersome weapon by 1."
                }
            },
            {
                "Damaged", new LongText()
                {
                    Id = Guid.Parse("93ddcfac-65eb-4597-a7f0-21597d483715"),
                    Text = @"Samurai must carefully maintain their kit in the field, for
                            routine wear and tear will eventually ruin nearly any tool.
                            While many samurai have staff to assist with such matters,
                            most battle-tested samurai have learned at least
                            the basics needed to keep their equipment functional.
                            If a weapon or tool becomes Damaged, increase
                            the TN of checks to use it by 1.
                            If armor becomes Damaged, reduce all resistances
                            it provides by 2 (to a minimum of 0).
                            If a Damaged item becomes Damaged again, it loses
                            Damaged and becomes Destroyed instead. If it becomes
                            Destroyed for any other reason, it also loses Damaged."
                }
            },
            {
                "Destroyed", new LongText()
                {
                    Id = Guid.Parse("6b101e42-cdaa-4f31-8bfd-25bd104c7d30"),
                    Text = @"Extreme events or long use without maintenance can
                            shatter, tear, or otherwise render an item nonfunctional.
                            Such an item is broken and cannot be used for its
                            intended function. It might still be usable as an improvised
                            weapon or tool, at the GM’s discretion."
                }
            },
            {
                "Durable", new LongText()
                {
                    Id = Guid.Parse("f677c10e-4f44-489d-93ff-32338d326b4f"),
                    Text = @"Items crafted to last can endure damage that would
                            destroy less well-made works.
                            If a Durable item would become Damaged, it loses
                            Durable instead. If a Durable item would be Destroyed,
                            it loses Durable and becomes Damaged instead."
                }
            },
            {
                "Forbidden", new LongText()
                {
                    Id = Guid.Parse("b29bc7f7-1ed8-42b1-99e9-37e0c2cefda7"),
                    Text = @"Rokugani laws are unforgiving, and many things are contraband.
                            This includes many illicit substances, heretical
                            art or literature, and foreign items that have not been
                            transported through strictly regulated trade routes.
                            At the end of any scene in which you used a Forbidden
                            item openly in public, you must forfeit 3 glory."
                }
            },
            {
                "Mundane", new LongText()
                {
                    Id = Guid.Parse("a6aa065e-374f-41e3-a86a-004b18093c4e"),
                    Text = @"Mundane items are objects that are found in all contexts
                            of daily life, and are permitted to anyone in most
                            social contexts (within reason). After all, people in
                            many walks of life need tools like knives, walking sticks,
                            and wheat threshers, even if these items can be utilized
                            to deadly effect by someone sufficiently determined.
                            Wearing a Mundane item openly has no additional
                            effects, though onlookers still take note of the fact that
                            you are armed if the item could be used as a weapon."
                }
            },
            {
                "Prepare", new LongText()
                {
                    Id = Guid.Parse("7c6be140-ec3a-4e92-9f72-95976aae917f"),
                    Text = @"This item must be reloaded, reset, or otherwise prepared
                            after use.
                            After you use this item, you cannot use it again until
                            it has been prepared. As a Support action, while it is
                            readied, you may prepare this item for use."
                }
            },
            {
                "Razor-Edge", new LongText()
                {
                    Id = Guid.Parse("16bd58e5-32d8-4e38-a864-accb556e923d"),
                    Text = @"Some weapons are particularly sharp, and thus brittle,
                            and must be carefully honed to keep functioning at
                            their best. The traditional Rokugani katana is one such
                            weapon—its keen edge lets it hew off limbs more easily
                            than other swords, but it is also more susceptible to
                            damage if swung carelessly at armored foes.
                            When you succeed at an Attack action check that
                            deals damage to a target using a Razor-Edged item, if
                            the damage dealt is reduced to 0 before they defend,
                            this item becomes Damaged.
                            When you make an Attack action check with a
                            Razor-Edged weapon, you may spend Opportunity as follows:
                            More than one Opportunity: Treat the deadliness of this 
                            weapon as 1 higher per opportunity spent this way."
                }
            },
            {
                "Resplendent", new LongText()
                {
                    Id = Guid.Parse("28dd5718-b1cd-4217-9d1e-51a560bdb812"),
                    Text = @"An item with the Resplendent quality is embellished to
                            attract attention to its presenter or wearer.
                            While wearing one or more Resplendent items, if
                            you would be awarded 1 or more glory, you receive
                            that amount of glory plus 1 instead."
                }
            },
            {
                "Sacred", new LongText()
                {
                    Id = Guid.Parse("6580f21f-4f76-4987-b1db-8482c17c4ce2"),
                    Text = @"Items with the Sacred quality are imbued with purifying
                            power—often in the form of jade, the mystical stone
                            said to be the tears shed by Amaterasu, the goddess
                            of the sun and protector against the terror of the night.
                            Such items are anathema to the denizens of the Shadowlands
                            and other horrors that prey upon humanity.
                            When an Otherworldly being makes an Attack or
                            Intrigue action check targeting the wearer of one or
                            more Sacred items, increase the TN by 1.
                            While you are carrying one or more Sacred items, if
                            you would gain the Afflicted condition, you must choose
                            one of those items to become Damaged instead.
                            Sacred weapons ignore all resistances possessed
                            by Otherworldly and Tainted beings."
                }
            },
            {
                "Snaring", new LongText()
                {
                    Id = Guid.Parse("2b44d64a-b5ef-4725-aceb-98b8f3584fdd"),
                    Text = @"Flexible or, in some cases, harshly curved weapons are
                            excellent for snaring, grabbing, and disarming.
                            When performing an Attack action with a Snaring
                            weapon, you may spend opportunity as follows:
                            One or more opportunity: One target of the attack with vigilance lower
                            than or equal to the opportunity spent this way suffers the
                            Immobilized condition."
                }
            },
            {
                "Subtle", new LongText()
                {
                    Id = Guid.Parse("c569f579-5097-49ad-8411-58692e36c642"),
                    Text = @"An item with the Subtle quality is made to not stand
                            out, and people tend to overlook it.
                            Increase the TN of checks to ascertain information
                            about the item by 1. At the GM’s discretion, this also
                            applies to checks to discern what the creator or wearer
                            of the piece intends by presenting it, or to learn anything
                            of value about that person from it."
                }
            },
            {
                "Unholy", new LongText()
                {
                    Id = Guid.Parse("03861fad-00e7-4979-8f0f-b1c4e0559b93"),
                    Text = @"Some physical artifacts carry a dreadful miasma. They
                            may have been tainted by direct exposure to the power
                            of the Shadowlands or by foul rituals, but some are
                            made with obsidian, said to be the shed blood of Onnotangu,
                            the god of the moon and ancient foe of the Kami.
                            After a character suffers a critical strike from an
                            Unholy weapon, they suffer the Afflicted condition.
                            At the end of each scene in which you use an Unholy
                            item, you suffer the Afflicted condition.
                            Unholy weapons ignore all resistances possessed
                            by Otherworldly beings."
                }
            },
            {
                "Wargear", new LongText()
                {
                    Id = Guid.Parse("625f74c3-89d2-4211-abfd-ea4f86c52834"),
                    Text = @"Implements seen in battle and few other contexts—
                            items with the Wargear quality—are decidedly inappropriate
                            for most social contexts. Wargear makes
                            people nervous, which impedes efforts at diplomacy.
                            Whenever another character suffers 1 or more strife
                            due to the actions of someone wearing one or more
                            Wargear items, they suffer that amount plus 1 instead."
                }
            }
        };
    }

    public List<ItemQualityModel> GetItemQualities()
    {
        return new List<ItemQualityModel>()
        {
            new()
            {
                Id = 1, Name = "Ceremonial", DescriptionId = ItemQualitiesDescriptions["Ceremonial"].Id
            },
            new()
            {
                Id = 2, Name = "Concealable", DescriptionId = ItemQualitiesDescriptions["Concealable"].Id
            },
            new()
            {
                Id = 3, Name = "Cumbersome", DescriptionId = ItemQualitiesDescriptions["Cumbersome"].Id
            },
            new()
            {
                Id = 4, Name = "Damaged", DescriptionId = ItemQualitiesDescriptions["Damaged"].Id
            },
            new()
            {
                Id = 5, Name = "Destroyed", DescriptionId = ItemQualitiesDescriptions["Destroyed"].Id
            },
            new()
            {
                Id = 6, Name = "Durable", DescriptionId = ItemQualitiesDescriptions["Durable"].Id
            },
            new()
            {
                Id = 7, Name = "Forbidden", DescriptionId = ItemQualitiesDescriptions["Forbidden"].Id
            },
            new()
            {
                Id = 8, Name = "Mundane", DescriptionId = ItemQualitiesDescriptions["Mundane"].Id
            },
            new()
            {
                Id = 9, Name = "Prepare", DescriptionId = ItemQualitiesDescriptions["Prepare"].Id
            },
            new()
            {
                Id = 10, Name = "Razor-Edged", DescriptionId = ItemQualitiesDescriptions["Razor-Edge"].Id
            },
            new()
            {
                Id = 11, Name = "Resplendent", DescriptionId = ItemQualitiesDescriptions["Resplendent"].Id
            },
            new()
            {
                Id = 12, Name = "Sacred", DescriptionId = ItemQualitiesDescriptions["Sacred"].Id
            },
            new()
            {
                Id = 13, Name = "Snaring", DescriptionId = ItemQualitiesDescriptions["Snaring"].Id
            },
            new()
            {
                Id = 14, Name = "Subtle", DescriptionId = ItemQualitiesDescriptions["Subtle"].Id
            },
            new()
            {
                Id = 15, Name = "Unholy", DescriptionId = ItemQualitiesDescriptions["Unholy"].Id
            },
            new()
            {
                Id = 16, Name = "Wargear", DescriptionId = ItemQualitiesDescriptions["Unholy"].Id
            }
        };
    }


}
