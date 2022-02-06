using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOT5RDB.Core.Equipment.DataObjects;
using LOT5RDB.Core.Skills.DataObjects;

namespace LOT5RDB.Data.Configuration
{
    public static class DataSeeds
    {
        public static List<SkillGroup> GetSkillGroups() => new List<SkillGroup>()
        {
            new SkillGroup()
            {
                Id = 1, Name = "Artisan", Description = @"The high arts of Rokugan have a
                                                            powerful influence on society. While commoners
                                                            produce most items in Rokugan, artisans
                                                            produce influential, sometimes even supernatural
                                                            works that can alter the course of history.
                                                            Artisan skills allow characters to engage in the
                                                            process of creating art."
            },
            new SkillGroup()
            {
                Id = 2, Name = "Martial", Description = @"Samurai were originally warriors,
                                                                            and while members of this societal strata fill
                                                                            many roles in Rokugan now, it is still steeped
                                                                            in martial traditions. As such, Martial skills
                                                                            are seen as being of utmost importance.
                                                                            Martial skills allow characters to fight in duels
                                                                            or battles, defeat physical challenges, successfully
                                                                            wage war, and overcome their own
                                                                            mental limits."
            },
            new SkillGroup()
            {
                Id = 3, Name = "Scholar", Description = @"Information is power, and Scholar
                                                                            skills give a character access to information about
                                                                            society, the world, and other people. Scholar
                                                                            skills allow characters to recall information, identify
                                                                            things related to an area of expertise, observe
                                                                            their environment, and draw conclusions."
            },
            new SkillGroup()
            {
                Id = 4, Name = "Social", Description = @"Courtiers hold incredible sway in
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
            },
            new SkillGroup()
            {
                Id = 5, Name = "Trade", Description = @"These are skills most commonly
                                                                            practiced by occupants of the bottom tiers of
                                                                            Rokugan’s stratified society. Trade skills allow
                                                                            characters to procure resources from their environment
                                                                            and perform work"
            }
        };

        public static object[,] GetSkillGroupObjects() => new object[,]
        {
            {
                1, "Artisan", @"The high arts of Rokugan have a
                                powerful influence on society. While commoners
                                produce most items in Rokugan, artisans
                                produce influential, sometimes even supernatural
                                works that can alter the course of history.
                                Artisan skills allow characters to engage in the
                                process of creating art."
            },
            
            { 
                2, "Martial", @"Samurai were originally warriors,
                            and while members of this societal strata fill
                            many roles in Rokugan now, it is still steeped
                            in martial traditions. As such, Martial skills
                            are seen as being of utmost importance.
                            Martial skills allow characters to fight in duels
                            or battles, defeat physical challenges, successfully
                            wage war, and overcome their own
                            mental limits."
            },
            {
                3, "Scholar", @"Information is power, and Scholar
                                skills give a character access to information about
                                society, the world, and other people. Scholar
                                skills allow characters to recall information, identify
                                things related to an area of expertise, observe
                                their environment, and draw conclusions."
            },
            {
                4, "Social", @"Courtiers hold incredible sway in
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
            },
            {
                5, "Trade", @"These are skills most commonly
                            practiced by occupants of the bottom tiers of
                            Rokugan’s stratified society. Trade skills allow
                            characters to procure resources from their environment
                            and perform work"
            }
        };

        public static List<Skill> GetSkills() => new List<Skill>()
        {
            new Skill()
            {
                Id = 1,
                Name = "Aesthetics",
                Description = "",
                SkillGroupId = 1
            },
            new Skill()
            {
                Id = 2,
                Name = "Composition",
                Description = "",
                SkillGroupId = 1
            },
            new Skill()
            {
                Id = 3,
                Name = "Design",
                Description = "",
                SkillGroupId = 1
            },
            new Skill()
            {
                Id = 4,
                Name = "Smithing",
                Description = "",
                SkillGroupId = 1
            },
            new Skill()
            {
                Id = 5,
                Name = "Command",
                Description = "",
                SkillGroupId = 4
            },
            new Skill()
            {
                Id = 6,
                Name = "Courtesy",
                Description = "",
                SkillGroupId = 4
            },
            new Skill()
            {
                Id = 7,
                Name = "Games",
                Description = "",
                SkillGroupId = 4
            },
            new Skill()
            {
                Id = 8,
                Name = "Performance",
                Description = "",
                SkillGroupId = 4
            },
            new Skill()
            {
                Id = 9,
                Name = "Culture",
                Description = "",
                SkillGroupId = 3
            },
            new Skill()
            {
                Id = 10,
                Name = "Government",
                Description = "",
                SkillGroupId = 3
            },
            new Skill()
            {
                Id = 11,
                Name = "Medicine",
                Description = "",
                SkillGroupId = 3
            },
            new Skill()
            {
                Id = 12,
                Name = "Sentiment",
                Description = "",
                SkillGroupId = 3
            },
            new Skill()
            {
                Id = 13,
                Name = "Theology",
                Description = "",
                SkillGroupId = 3
            },
            new Skill()
            {
                Id = 14,
                Name = "Fitness",
                Description = "",
                SkillGroupId = 2
            },
            new Skill()
            {
                Id = 15,
                Name = "Martial Arts [Melee]",
                Description = "",
                SkillGroupId = 2
            },
            new Skill()
            {
                Id = 16,
                Name = "Martial Arts [Ranged]",
                Description = "",
                SkillGroupId = 2
            },
            new Skill()
            {
                Id = 17,
                Name = "Martial Arts [Unamred]",
                Description = "",
                SkillGroupId = 2
            },
            new Skill()
            {
                Id = 18,
                Name = "Mediation",
                Description = "",
                SkillGroupId = 2
            },
            new Skill()
            {
                Id = 19,
                Name = "Tactics",
                Description = "",
                SkillGroupId = 2
            },
            new Skill()
            {
                Id = 20,
                Name = "Commerce",
                Description = "",
                SkillGroupId = 5
            },
            new Skill()
            {
                Id = 21,
                Name = "Labor",
                Description = "",
                SkillGroupId = 5
            },
            new Skill()
            {
                Id = 22,
                Name = "Seafaring",
                Description = "",
                SkillGroupId = 5
            },
            new Skill()
            {
                Id = 23,
                Name = "Skulduggery",
                Description = "",
                SkillGroupId = 5
            },
            new Skill()
            {
                Id = 24,
                Name = "Survival",
                Description = "",
                SkillGroupId = 5
            }
        };

        public static object[,] GetSkillObjects() => new object[,]
        {
            {
                1,
                "Aesthetics",
                "",
                1
            },
            
            {
                2,
                "Composition",
                "",
                1
            },
            
            {
                3,
                "Design",
                "",
                1
            },
            
            {
                4,
                "Smithing",
                "",
                1
            },
            
            {
                5,
                "Command",
                "",
                4
            },
            
            {
                6,
                "Courtesy",
                "",
                4
            },
            
            {
                7,
                "Games",
                "",
                4
            },
            
            {
                8,
                "Performance",
                "",
                4
            },
            
            {
                9,
                "Culture",
                "",
                3
            },
            
            {
                10,
                "Government",
                "",
                3
            },
            
            {
                11,
                "Medicine",
                "",
                3
            },
            
            {
                12,
                "Sentiment",
                "",
                3
            },
            
            {
                13,
                "Theology",
                "",
                3
            },
            
            {
                14,
                "Fitness",
                "",
                2
            },
            
            {
                15,
                "Martial Arts [Melee]",
                "",
                2
            },
            
            {
                16,
                "Martial Arts [Ranged]",
                "",
                2
            },
            
            {
                17,
                "Martial Arts [Unamred]",
                "",
                2
            },
            
            {
                18,
                "Mediation",
                "",
                2
            },
            
            {
                19,
                "Tactics",
                "",
                2
            },
            
            {
                20,
                "Commerce",
                "",
                5
            },
            
            {
                21,
                "Labor",
                "",
                5
            },
            
            {
                22,
                "Seafaring",
                "",
                5
            },
            
            {
                23,
                "Skulduggery",
                "",
                5
            },
            
            {
                24,
                "Survival",
                "",
                5
            }
        };

        public static List<Grip> GetGrips() => new List<Grip>()
        {
            new Grip()
            {
                Id = 1,
                GripType = GripTypes.OneHanded,
                Bonus = "-"
            },
            new Grip()
            {
                Id = 2,
                GripType = GripTypes.OneHanded,
                Bonus = "Range 1"
            },
            new Grip()
            {
                Id = 3,
                GripType = GripTypes.OneHanded,
                Bonus = "-",
                ExtraDescription = "(stab or slash)"
            },
            new Grip()
            {
                Id = 4,
                GripType = GripTypes.OneHanded,
                Bonus = "Martial Arts [Ranged], Range 1-3",
                ExtraDescription = "(thrown)"
            },
            new Grip()
            {
                Id = 5,
                GripType = GripTypes.TwoHanded,
                Bonus = "-"
            },
            new Grip()
            {
                Id = 6,
                GripType = GripTypes.TwoHanded,
                Bonus = "Damage +1"
            },
            new Grip()
            {
                Id = 7,
                GripType = GripTypes.TwoHanded,
                Bonus = "Damage +2"
            },
            new Grip()
            {
                Id = 8,
                GripType = GripTypes.TwoHanded,
                Bonus = "Deadliness +1"
            },
            new Grip()
            {
                Id = 9,
                GripType = GripTypes.TwoHanded,
                Bonus = "Deadliness +2"
            },
            new Grip()
            {
                Id = 10,
                GripType = GripTypes.TwoHanded,
                Bonus = "Snaring"
            },
            new Grip()
            {
                Id = 11,
                GripType = GripTypes.TwoHanded,
                Bonus = "Range 2-3"
            }
        };

        public static object[,] GetGripObjects() => new object[,]
        {
            {
                1,
                GripTypes.OneHanded,
                "-",
                ""
            },
            {
                2,
                GripTypes.OneHanded,
                "Range 1",
                ""
            },
            {
                3,
                GripTypes.OneHanded,
                "-",
                "(stab or slash)"
            },
            {
                4,
                GripTypes.OneHanded,
                "Martial Arts [Ranged], Range 1-3",
                "(thrown)"
            },
            {
                5,
                GripTypes.TwoHanded,
                "-",
                ""
            },
            {
                6,
                GripTypes.TwoHanded,
                "Damage +1",
                ""
            },
            {
                7,
                GripTypes.TwoHanded,
                "Damage +2",
                ""
            },
            {
                8,
                GripTypes.TwoHanded,
                "Deadliness +1",
                ""
            },
            {
                9,
                GripTypes.TwoHanded,
                "Deadliness +2",
                ""
            },
            {
                10,
                GripTypes.TwoHanded,
                "Snaring",
                ""
            },
            {
                11,
                GripTypes.TwoHanded,
                "Range 2-3",
                ""
            }
        };

        public static List<ItemQuality> GetItemQualities() => new List<ItemQuality>()
        {
            new ItemQuality()
            {
                Id = 1, Name = "Ceremonial", Description = @"Ceremonial equipment is indicative of the wearer’s
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
            },
            new ItemQuality()
            {
                Id = 2, Name = "Concealable", Description = @"Some weapons and armor are easy to hide on one’s
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
            },
            new ItemQuality()
            {
                Id = 3, Name = "Cumbersome", Description = @"This item is heavy or unwieldy, and impossible to conceal
                                                                                    on one’s person.
                                                                                    While wearing Cumbersome armor, increase the TN
                                                                                    of your checks to maneuver in your environment (such
                                                                                    as Movement action checks) by 1.
                                                                                    If you moved this turn, increase the TN of Attack
                                                                                    action checks using a Cumbersome weapon by 1."
            },
            new ItemQuality()
            {
                Id = 4, Name = "Damaged", Description = @"Samurai must carefully maintain their kit in the field, for
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
            },
            new ItemQuality()
            {
                Id = 5, Name = "Destroyed", Description = @"Extreme events or long use without maintenance can
                                                                                    shatter, tear, or otherwise render an item nonfunctional.
                                                                                    Such an item is broken and cannot be used for its
                                                                                    intended function. It might still be usable as an improvised
                                                                                    weapon or tool, at the GM’s discretion."
            },
            new ItemQuality()
            {
                Id = 6, Name = "Durable", Description = @"Items crafted to last can endure damage that would
                                                                                destroy less well-made works.
                                                                                If a Durable item would become Damaged, it loses
                                                                                Durable instead. If a Durable item would be Destroyed,
                                                                                it loses Durable and becomes Damaged instead."
            },
            new ItemQuality()
            {
                Id = 7, Name = "Forbidden", Description =
                    @"Rokugani laws are unforgiving, and many things are contraband.
                                                                                This includes many illicit substances, heretical
                                                                                art or literature, and foreign items that have not been
                                                                                transported through strictly regulated trade routes.
                                                                                At the end of any scene in which you used a Forbidden
                                                                                item openly in public, you must forfeit 3 glory."
            },
            new ItemQuality()
            {
                Id = 8, Name = "Mundane", Description = @"Mundane items are objects that are found in all contexts
                                                                                of daily life, and are permitted to anyone in most
                                                                                social contexts (within reason). After all, people in
                                                                                many walks of life need tools like knives, walking sticks,
                                                                                and wheat threshers, even if these items can be utilized
                                                                                to deadly effect by someone sufficiently determined.
                                                                                Wearing a Mundane item openly has no additional
                                                                                effects, though onlookers still take note of the fact that
                                                                                you are armed if the item could be used as a weapon."
            },
            new ItemQuality()
            {
                Id = 9, Name = "Prepare", Description = @"This item must be reloaded, reset, or otherwise prepared
                                                                                after use.
                                                                                After you use this item, you cannot use it again until
                                                                                it has been prepared. As a Support action, while it is
                                                                                readied, you may prepare this item for use."
            },
            new ItemQuality()
            {
                Id = 10, Name = "Razor-Edged", Description = @"Some weapons are particularly sharp, and thus brittle,
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
            },
            new ItemQuality()
            {
                Id = 11, Name = "Resplendent", Description = @"An item with the Resplendent quality is embellished to
                                                                                    attract attention to its presenter or wearer.
                                                                                    While wearing one or more Resplendent items, if
                                                                                    you would be awarded 1 or more glory, you receive
                                                                                    that amount of glory plus 1 instead."
            },
            new ItemQuality()
            {
                Id = 12, Name = "Sacred", Description = @"Items with the Sacred quality are imbued with purifying
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
            },
            new ItemQuality()
            {
                Id = 13, Name = "Snaring", Description = @"Flexible or, in some cases, harshly curved weapons are
                                                                                excellent for snaring, grabbing, and disarming.
                                                                                When performing an Attack action with a Snaring
                                                                                weapon, you may spend opportunity as follows:
                                                                                One or more opportunity: One target of the attack with vigilance lower
                                                                                than or equal to the opportunity spent this way suffers the
                                                                                Immobilized condition."
            },
            new ItemQuality()
            {
                Id = 14, Name = "Subtle", Description = @"An item with the Subtle quality is made to not stand
                                                                                out, and people tend to overlook it.
                                                                                Increase the TN of checks to ascertain information
                                                                                about the item by 1. At the GM’s discretion, this also
                                                                                applies to checks to discern what the creator or wearer
                                                                                of the piece intends by presenting it, or to learn anything
                                                                                of value about that person from it."
            },
            new ItemQuality()
            {
                Id = 15, Name = "Unholy", Description = @"Some physical artifacts carry a dreadful miasma. They
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
            },
            new ItemQuality()
            {
                Id = 16, Name = "Wargear", Description = @"Implements seen in battle and few other contexts—
                                                                                items with the Wargear quality—are decidedly inappropriate
                                                                                for most social contexts. Wargear makes
                                                                                people nervous, which impedes efforts at diplomacy.
                                                                                Whenever another character suffers 1 or more strife
                                                                                due to the actions of someone wearing one or more
                                                                                Wargear items, they suffer that amount plus 1 instead."
            }
        };

        public static object[,] GetItemQualitiesObjects() => new object[,]
        {
            
            {
                1, "Ceremonial", @"Ceremonial equipment is indicative of the wearer’s
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
            },
            
            {
                2, "Concealable", @"Some weapons and armor are easy to hide on one’s
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
            },
            
            {
                3, "Cumbersome", @"This item is heavy or unwieldy, and impossible to conceal
                                                                                    on one’s person.
                                                                                    While wearing Cumbersome armor, increase the TN
                                                                                    of your checks to maneuver in your environment (such
                                                                                    as Movement action checks) by 1.
                                                                                    If you moved this turn, increase the TN of Attack
                                                                                    action checks using a Cumbersome weapon by 1."
            },
            
            {
                4, "Damaged", @"Samurai must carefully maintain their kit in the field, for
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
            },
            
            {
                5, "Destroyed", @"Extreme events or long use without maintenance can
                                                                                    shatter, tear, or otherwise render an item nonfunctional.
                                                                                    Such an item is broken and cannot be used for its
                                                                                    intended function. It might still be usable as an improvised
                                                                                    weapon or tool, at the GM’s discretion."
            },
            
            {
                6, "Durable", @"Items crafted to last can endure damage that would
                                                                                destroy less well-made works.
                                                                                If a Durable item would become Damaged, it loses
                                                                                Durable instead. If a Durable item would be Destroyed,
                                                                                it loses Durable and becomes Damaged instead."
            },
            
            {
                7, "Forbidden", 
                    @"Rokugani laws are unforgiving, and many things are contraband.
                                                                                This includes many illicit substances, heretical
                                                                                art or literature, and foreign items that have not been
                                                                                transported through strictly regulated trade routes.
                                                                                At the end of any scene in which you used a Forbidden
                                                                                item openly in public, you must forfeit 3 glory."
            },
            
            {
                8, "Mundane", @"Mundane items are objects that are found in all contexts
                                                                                of daily life, and are permitted to anyone in most
                                                                                social contexts (within reason). After all, people in
                                                                                many walks of life need tools like knives, walking sticks,
                                                                                and wheat threshers, even if these items can be utilized
                                                                                to deadly effect by someone sufficiently determined.
                                                                                Wearing a Mundane item openly has no additional
                                                                                effects, though onlookers still take note of the fact that
                                                                                you are armed if the item could be used as a weapon."
            },
            
            {
                9, "Prepare", @"This item must be reloaded, reset, or otherwise prepared
                                                                                after use.
                                                                                After you use this item, you cannot use it again until
                                                                                it has been prepared. As a Support action, while it is
                                                                                readied, you may prepare this item for use."
            },
            
            {
                10, "Razor-Edged", @"Some weapons are particularly sharp, and thus brittle,
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
            },
            
            {
                11, "Resplendent", @"An item with the Resplendent quality is embellished to
                                                                                    attract attention to its presenter or wearer.
                                                                                    While wearing one or more Resplendent items, if
                                                                                    you would be awarded 1 or more glory, you receive
                                                                                    that amount of glory plus 1 instead."
            },
            
            {
                12, "Sacred", @"Items with the Sacred quality are imbued with purifying
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
            },
            
            {
                13, "Snaring", @"Flexible or, in some cases, harshly curved weapons are
                                                                                excellent for snaring, grabbing, and disarming.
                                                                                When performing an Attack action with a Snaring
                                                                                weapon, you may spend opportunity as follows:
                                                                                One or more opportunity: One target of the attack with vigilance lower
                                                                                than or equal to the opportunity spent this way suffers the
                                                                                Immobilized condition."
            },
            
            {
                14, "Subtle", @"An item with the Subtle quality is made to not stand
                                                                                out, and people tend to overlook it.
                                                                                Increase the TN of checks to ascertain information
                                                                                about the item by 1. At the GM’s discretion, this also
                                                                                applies to checks to discern what the creator or wearer
                                                                                of the piece intends by presenting it, or to learn anything
                                                                                of value about that person from it."
            },
            
            {
                15, "Unholy", @"Some physical artifacts carry a dreadful miasma. They
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
            },
            
            {
                16, "Wargear", @"Implements seen in battle and few other contexts—
                                                                                items with the Wargear quality—are decidedly inappropriate
                                                                                for most social contexts. Wargear makes
                                                                                people nervous, which impedes efforts at diplomacy.
                                                                                Whenever another character suffers 1 or more strife
                                                                                due to the actions of someone wearing one or more
                                                                                Wargear items, they suffer that amount plus 1 instead."
            }
        };
    }
}
