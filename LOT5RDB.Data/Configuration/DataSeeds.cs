using LOT5RD.Equipment.Models;
using LOT5RD.Skills.Models;
using LOT5RDB.Core.Shared.DataObjects;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace LOT5RDB.Data.Configuration
{
    public class DataSeeds
    {
        public Dictionary<string, LongText> SkillGroupDescriptions { get; set; }
        public Dictionary<string, LongText> SkillDescriptions { get; set; }
        public Dictionary<string, LongText> ItemQualitiesDescriptions { get; set; }
        public Dictionary<string, LongText> WeaponDescriptions { get; set; }
        public DataSeeds()
        {
            SkillGroupDescriptions = GetSkillGroupDescriptions();
            SkillDescriptions = GetSkillDescriptions();
            ItemQualitiesDescriptions = GetItemQualitiesDescription();
            WeaponDescriptions = GetWeaponDescriptions();
        }
        private Dictionary<string, LongText> GetWeaponDescriptions() => new Dictionary<string, LongText>()
        {
            {
                "Boken",
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
        }
        private Dictionary<string, LongText> GetSkillGroupDescriptions() => new Dictionary<string, LongText>()
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
        
        public List<SkillGroupModel> GetSkillGroups() => new List<SkillGroupModel>()
        {
            new SkillGroupModel()
            {
                Id = 1, Name = "Artisan", DescriptionId = SkillGroupDescriptions["Artisan"].Id
            },
            new SkillGroupModel()
            {
                Id = 2, Name = "Martial", DescriptionId = SkillGroupDescriptions["Martial"].Id
            },
            new SkillGroupModel()
            {
                Id = 3, Name = "Scholar", DescriptionId = SkillGroupDescriptions["Scholar"].Id
            },
            new SkillGroupModel()
            {
                Id = 4, Name = "Social", DescriptionId = SkillGroupDescriptions["Social"].Id
            },
            new SkillGroupModel()
            {
                Id = 5, Name = "Trade", DescriptionId = SkillGroupDescriptions["Trade"].Id 
            }
        };
        private Dictionary<string, LongText> GetSkillDescriptions() => new Dictionary<string, LongText>()
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
                "Marital Arts [Melee]", new LongText()
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
                "Marital Arts [Ranged]", new LongText()
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
                "Marital Arts [Unarmed]", new LongText()
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

        public List<SkillModel> GetSkills() => new List<SkillModel>()
        {
            new SkillModel()
            {
                Id = 1,
                Name = "Aesthetics",
                DescriptionId = SkillDescriptions["Aesthetics"].Id,
                SkillGroupId = 1
            },
            new SkillModel()
            {
                Id = 2,
                Name = "Composition",
                DescriptionId = SkillDescriptions["Composition"].Id,
                SkillGroupId = 1
            },
            new SkillModel()
            {
                Id = 3,
                Name = "Design",
                DescriptionId = SkillDescriptions["Design"].Id,
                SkillGroupId = 1
            },
            new SkillModel()
            {
                Id = 4,
                Name = "Smithing",
                DescriptionId = SkillDescriptions["Smithing"].Id,
                SkillGroupId = 1
            },
            new SkillModel()
            {
                Id = 5,
                Name = "Command",
                DescriptionId = SkillDescriptions["Command"].Id,
                SkillGroupId = 4
            },
            new SkillModel()
            {
                Id = 6,
                Name = "Courtesy",
                DescriptionId = SkillDescriptions["Courtesy"].Id,
                SkillGroupId = 4
            },
            new SkillModel()
            {
                Id = 7,
                Name = "Games",
                DescriptionId = SkillDescriptions["Games"].Id,
                SkillGroupId = 4
            },
            new SkillModel()
            {
                Id = 8,
                Name = "Performance",
                DescriptionId = SkillDescriptions["Performance"].Id,
                SkillGroupId = 4
            },
            new SkillModel()
            {
                Id = 9,
                Name = "Culture",
                DescriptionId = SkillDescriptions["Culture"].Id,
                SkillGroupId = 3
            },
            new SkillModel()
            {
                Id = 10,
                Name = "Government",
                DescriptionId = SkillDescriptions["Government"].Id,
                SkillGroupId = 3
            },
            new SkillModel()
            {
                Id = 11,
                Name = "Medicine",
                DescriptionId = SkillDescriptions["Medicine"].Id,
                SkillGroupId = 3
            },
            new SkillModel()
            {
                Id = 12,
                Name = "Sentiment",
                DescriptionId = SkillDescriptions["Sentiment"].Id,
                SkillGroupId = 3
            },
            new SkillModel()
            {
                Id = 13,
                Name = "Theology",
                DescriptionId = SkillDescriptions["Theology"].Id,
                SkillGroupId = 3
            },
            new SkillModel()
            {
                Id = 14,
                Name = "Fitness",
                DescriptionId = SkillDescriptions["Fitness"].Id,
                SkillGroupId = 2
            },
            new SkillModel()
            {
                Id = 15,
                Name = "Martial Arts [Melee]",
                DescriptionId = SkillDescriptions["Martial Arts [Melee]"].Id,
                SkillGroupId = 2
            },
            new SkillModel()
            {
                Id = 16,
                Name = "Martial Arts [Ranged]",
                DescriptionId = SkillDescriptions["Martial Arts [Ranged]"].Id,
                SkillGroupId = 2
            },
            new SkillModel()
            {
                Id = 17,
                Name = "Martial Arts [Unarmed]",
                DescriptionId = SkillDescriptions["Martial Arts [Unarmed]"].Id,
                SkillGroupId = 2
            },
            new SkillModel()
            {
                Id = 18,
                Name = "Mediation",
                DescriptionId = SkillDescriptions["Mediation"].Id,
                SkillGroupId = 2
            },
            new SkillModel()
            {
                Id = 19,
                Name = "Tactics",
                DescriptionId = SkillDescriptions["Tactics"].Id,
                SkillGroupId = 2
            },
            new SkillModel()
            {
                Id = 20,
                Name = "Commerce",
                DescriptionId = SkillDescriptions["Commerce"].Id,
                SkillGroupId = 5
            },
            new SkillModel()
            {
                Id = 21,
                Name = "Labor",
                DescriptionId = SkillDescriptions["Labor"].Id,
                SkillGroupId = 5
            },
            new SkillModel()
            {
                Id = 22,
                Name = "Seafaring",
                DescriptionId = SkillDescriptions["Seafaring"].Id,
                SkillGroupId = 5
            },
            new SkillModel()
            {
                Id = 23,
                Name = "Skulduggery",
                DescriptionId = SkillDescriptions["Skulduggery"].Id,
                SkillGroupId = 5
            },
            new SkillModel()
            {
                Id = 24,
                Name = "Survival",
                DescriptionId = SkillDescriptions["Survival"].Id,
                SkillGroupId = 5
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

        public Dictionary<string, LongText> GetItemQualitiesDescription() => new Dictionary<string, LongText>()
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

        public List<ItemQualityModel> GetItemQualities() => new List<ItemQualityModel>()
        {
            new ItemQualityModel()
            {
                Id = 1, Name = "Ceremonial", DescriptionId = ItemQualitiesDescriptions["Ceremonial"].Id 
            },
            new ItemQualityModel()
            {
                Id = 2, Name = "Concealable", DescriptionId = ItemQualitiesDescriptions["Concealable"].Id
            },
            new ItemQualityModel()
            {
                Id = 3, Name = "Cumbersome", DescriptionId = ItemQualitiesDescriptions["Cumbersome"].Id
            },
            new ItemQualityModel()
            {
                Id = 4, Name = "Damaged", DescriptionId = ItemQualitiesDescriptions["Damaged"].Id 
            },
            new ItemQualityModel()
            {
                Id = 5, Name = "Destroyed", DescriptionId = ItemQualitiesDescriptions["Destroyed"].Id 
            },
            new ItemQualityModel()
            {
                Id = 6, Name = "Durable", DescriptionId = ItemQualitiesDescriptions["Durable"].Id 
            },
            new ItemQualityModel()
            {
                Id = 7, Name = "Forbidden", DescriptionId = ItemQualitiesDescriptions["Forbidden"].Id
            },
            new ItemQualityModel()
            {
                Id = 8, Name = "Mundane", DescriptionId = ItemQualitiesDescriptions["Mundane"].Id 
            },
            new ItemQualityModel()
            {
                Id = 9, Name = "Prepare", DescriptionId = ItemQualitiesDescriptions["Prepare"].Id 
            },
            new ItemQualityModel()
            {
                Id = 10, Name = "Razor-Edged", DescriptionId = ItemQualitiesDescriptions["Razor-Edge"].Id 
            },
            new ItemQualityModel()
            {
                Id = 11, Name = "Resplendent", DescriptionId = ItemQualitiesDescriptions["Resplendent"].Id
            },
            new ItemQualityModel()
            {
                Id = 12, Name = "Sacred", DescriptionId = ItemQualitiesDescriptions["Sacred"].Id
            },
            new ItemQualityModel()
            {
                Id = 13, Name = "Snaring", DescriptionId = ItemQualitiesDescriptions["Snaring"].Id
            },
            new ItemQualityModel()
            {
                Id = 14, Name = "Subtle", DescriptionId = ItemQualitiesDescriptions["Subtle"].Id 
            },
            new ItemQualityModel()
            {
                Id = 15, Name = "Unholy", DescriptionId = ItemQualitiesDescriptions["Unholy"].Id  
            },
            new ItemQualityModel()
            {
                Id = 16, Name = "Wargear", DescriptionId = ItemQualitiesDescriptions["Unholy"].Id 
            }
        };
    }
}
