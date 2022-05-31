using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LOT5RDB.Data.Migrations.EquipmentDb
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Equipment");

            migrationBuilder.EnsureSchema(
                name: "Skills");

            migrationBuilder.CreateTable(
                name: "ItemQualities",
                schema: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemQualities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkillGroups",
                schema: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                schema: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkillGroupId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_SkillGroups_SkillGroupId",
                        column: x => x.SkillGroupId,
                        principalSchema: "Skills",
                        principalTable: "SkillGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                schema: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    Range = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaseDamage = table.Column<int>(type: "int", nullable: false),
                    Deadliness = table.Column<int>(type: "int", nullable: false),
                    Grips = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rarity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapons_Skills_SkillId",
                        column: x => x.SkillId,
                        principalSchema: "Skills",
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeaponItemQualities",
                schema: "Equipment",
                columns: table => new
                {
                    QualitiesId = table.Column<int>(type: "int", nullable: false),
                    WeaponsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponItemQualities", x => new { x.QualitiesId, x.WeaponsId });
                    table.ForeignKey(
                        name: "FK_WeaponItemQualities_ItemQualities_QualitiesId",
                        column: x => x.QualitiesId,
                        principalSchema: "Equipment",
                        principalTable: "ItemQualities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeaponItemQualities_Weapons_WeaponsId",
                        column: x => x.WeaponsId,
                        principalSchema: "Equipment",
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Equipment",
                table: "ItemQualities",
                columns: new[] { "Id", "DescriptionId", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("fc81b4aa-eb77-48d1-aa72-e6664b30a5bc"), true, "Ceremonial" },
                    { 2, new Guid("dfd36c34-9c81-4e52-b0cf-354bb949cbc2"), true, "Concealable" },
                    { 3, new Guid("89d3bcfd-2c6b-4477-9494-325e62b84575"), true, "Cumbersome" },
                    { 4, new Guid("93ddcfac-65eb-4597-a7f0-21597d483715"), true, "Damaged" },
                    { 5, new Guid("6b101e42-cdaa-4f31-8bfd-25bd104c7d30"), true, "Destroyed" },
                    { 6, new Guid("f677c10e-4f44-489d-93ff-32338d326b4f"), true, "Durable" },
                    { 7, new Guid("b29bc7f7-1ed8-42b1-99e9-37e0c2cefda7"), true, "Forbidden" },
                    { 8, new Guid("a6aa065e-374f-41e3-a86a-004b18093c4e"), true, "Mundane" },
                    { 9, new Guid("7c6be140-ec3a-4e92-9f72-95976aae917f"), true, "Prepare" },
                    { 10, new Guid("16bd58e5-32d8-4e38-a864-accb556e923d"), true, "Razor-Edged" },
                    { 11, new Guid("28dd5718-b1cd-4217-9d1e-51a560bdb812"), true, "Resplendent" },
                    { 12, new Guid("6580f21f-4f76-4987-b1db-8482c17c4ce2"), true, "Sacred" },
                    { 13, new Guid("2b44d64a-b5ef-4725-aceb-98b8f3584fdd"), true, "Snaring" },
                    { 14, new Guid("c569f579-5097-49ad-8411-58692e36c642"), true, "Subtle" },
                    { 15, new Guid("03861fad-00e7-4979-8f0f-b1c4e0559b93"), true, "Unholy" },
                    { 16, new Guid("03861fad-00e7-4979-8f0f-b1c4e0559b93"), true, "Wargear" }
                });

            migrationBuilder.InsertData(
                schema: "Skills",
                table: "SkillGroups",
                columns: new[] { "Id", "DescriptionId", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("03b6062e-7c0e-4ba0-93ab-f3b41c13261b"), true, "Artisan" },
                    { 2, new Guid("1f28aca2-2231-47cd-b8a9-fa487c3c2c4a"), true, "Martial" },
                    { 3, new Guid("574fea87-6fc0-488f-b452-22d4cbaf7784"), true, "Scholar" },
                    { 4, new Guid("758a9a52-f869-49f7-87bd-4234e1018a27"), true, "Social" },
                    { 5, new Guid("148939ba-86eb-4c5b-8df0-c230f8257589"), true, "Trade" }
                });

            migrationBuilder.InsertData(
                schema: "Skills",
                table: "Skills",
                columns: new[] { "Id", "DescriptionId", "IsActive", "Name", "SkillGroupId" },
                values: new object[,]
                {
                    { 1, new Guid("1879583a-b7bb-455d-93d6-b4fbee6078a2"), true, "Aesthetics", 1 },
                    { 2, new Guid("d80bc5bf-4931-4fd1-857e-497eccdbf342"), true, "Composition", 1 },
                    { 3, new Guid("17a19c61-26cb-433e-aa2e-64a366d31239"), true, "Design", 1 },
                    { 4, new Guid("923f8290-f0f3-4e6d-a2de-db55c18540d4"), true, "Smithing", 1 },
                    { 5, new Guid("7aa51fd4-3e68-452c-9d74-c2c451d9b1df"), true, "Command", 4 },
                    { 6, new Guid("7b29a2b0-36ea-44be-961f-d77bac1418c1"), true, "Courtesy", 4 },
                    { 7, new Guid("ea6a04a7-9e1c-4541-b220-5fd28475646f"), true, "Games", 4 },
                    { 8, new Guid("aebc434f-6060-47ff-aae8-2455ad957fa0"), true, "Performance", 4 },
                    { 9, new Guid("b8e30628-b535-4c91-b168-ccccf49cee88"), true, "Culture", 3 },
                    { 10, new Guid("62489655-9d8e-4f19-95ff-53abcdf51a56"), true, "Government", 3 },
                    { 11, new Guid("4a494aae-1dc9-49b9-9c88-2aeeed24584e"), true, "Medicine", 3 },
                    { 12, new Guid("0882d9c1-323a-42b4-9225-9261b99658db"), true, "Sentiment", 3 },
                    { 13, new Guid("6d59586f-7b4e-497f-9db1-b2a403c021ce"), true, "Theology", 3 },
                    { 14, new Guid("06ddcb2c-c011-4b2b-bed7-336258a71b26"), true, "Fitness", 2 },
                    { 15, new Guid("9bf05308-4c5d-498c-9b83-441934b9879d"), true, "Martial Arts [Melee]", 2 },
                    { 16, new Guid("bba94dda-3c39-48f0-b53d-9ba014a0e369"), true, "Martial Arts [Ranged]", 2 },
                    { 17, new Guid("c7949ac1-bbc9-4108-8a10-9d10c046e441"), true, "Martial Arts [Unarmed]", 2 },
                    { 18, new Guid("f03aa519-4193-4ee1-bd7d-63b469f7bcda"), true, "Meditation", 2 },
                    { 19, new Guid("481e4264-f1e6-4112-9e88-bb669fc4fa3c"), true, "Tactics", 2 },
                    { 20, new Guid("d457ba6d-8f6c-4a4a-a0dd-f7d229ea7a00"), true, "Commerce", 5 },
                    { 21, new Guid("e610bc1e-f62e-4238-90b3-af3e86a14f2f"), true, "Labor", 5 },
                    { 22, new Guid("3c7caaa2-7d10-4f98-ab23-051d677d58c1"), true, "Seafaring", 5 },
                    { 23, new Guid("faccaf45-a3cd-4c96-ae3e-9bb07a9c9c2d"), true, "Skulduggery", 5 },
                    { 24, new Guid("1804a803-48a9-4f32-884f-e9e7787d75dd"), true, "Survival", 5 }
                });

            migrationBuilder.InsertData(
                schema: "Equipment",
                table: "Weapons",
                columns: new[] { "Id", "BaseDamage", "Category", "Deadliness", "DescriptionId", "Grips", "IsActive", "Name", "Price", "Range", "Rarity", "SkillId" },
                values: new object[,]
                {
                    { 1, 3, 1, 3, new Guid("9d785089-f4a0-447a-86ae-0846dcfdd7af"), "[{\"GripType\":1,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]},{\"GripType\":2,\"Bonus\":\"Damage +2\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Bokken", 10, "1-1", 3, 15 },
                    { 2, 4, 1, 5, new Guid("7bd3e03d-b9fc-4ef4-b9bc-a582434a14db"), "[{\"GripType\":1,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Chokutō", 2000, "0-1", 7, 15 },
                    { 3, 4, 1, 5, new Guid("3be3c2ec-ffe7-4304-a7d1-c1f3a3afcee0"), "[{\"GripType\":1,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Dao", 1500, "1-1", 6, 15 },
                    { 4, 4, 1, 3, new Guid("fdc8a246-abc4-4e1d-af89-2822acf8f03d"), "[{\"GripType\":1,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Gao", 1500, "1-1", 7, 15 },
                    { 5, 4, 1, 4, new Guid("4d19ac97-1238-47af-ab8a-2eaae450816e"), "[{\"GripType\":1,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]},{\"GripType\":2,\"Bonus\":\"Deadliness +1\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Jian", 1500, "0-1", 7, 15 },
                    { 6, 4, 1, 5, new Guid("8761953c-0d1f-4edc-8860-aa949c22c39c"), "[{\"GripType\":1,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]},{\"GripType\":2,\"Bonus\":\"Deadliness +2\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Katana", 2000, "1-1", 7, 15 },
                    { 7, 5, 1, 6, new Guid("64dc8d84-22d1-4aeb-bdce-3efcd4fd839a"), "[{\"GripType\":2,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Nodachi", 2000, "1-2", 8, 15 },
                    { 8, 4, 1, 5, new Guid("7bf856dd-db5f-42fa-89cf-9c84dac758d4"), "[{\"GripType\":1,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Scimitar", 2000, "1-1", 8, 15 },
                    { 9, 3, 1, 5, new Guid("272aaed4-e935-449b-bec0-a1f307d0dbfd"), "[{\"GripType\":1,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]},{\"GripType\":2,\"Bonus\":\"Deadliness +2\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Wakizashi", 1500, "0-1", 7, 15 },
                    { 10, 6, 1, 7, new Guid("725d0771-5ef1-4e96-8f4d-65630ee5094e"), "[{\"GripType\":2,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Zanbatō", 4000, "1-2", 8, 15 },
                    { 11, 3, 2, 4, new Guid("ca8cd8c7-de5a-4f41-9a91-5c2c9c75119a"), "[{\"GripType\":1,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]},{\"GripType\":2,\"Bonus\":\"Deadliness +2\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Masakari", 30, "0-1", 5, 15 },
                    { 12, 5, 2, 6, new Guid("ef557f8f-149d-4f10-8759-a1d6b7e6968b"), "[{\"GripType\":2,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Ono", 500, "1-2", 7, 15 },
                    { 13, 5, 3, 2, new Guid("39aab287-beaf-40e4-a145-64b262a85888"), "[{\"GripType\":1,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]},{\"GripType\":2,\"Bonus\":\"Damage +1\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Club", 10, "0-1", 1, 15 },
                    { 14, 5, 3, 2, new Guid("c6fbcb03-9201-4aa0-b63a-640c727950f6"), "[{\"GripType\":1,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]},{\"GripType\":2,\"Bonus\":\"Damage +2\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Hammer", 20, "0-1", 4, 15 },
                    { 15, 2, 3, 2, new Guid("445ed817-f218-43cc-8160-24cfc7334e55"), "[{\"GripType\":1,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Kiseru", 100, "0-0", 5, 15 },
                    { 16, 8, 3, 3, new Guid("309b89e0-272b-429a-ab76-cb976b3b3f88"), "[{\"GripType\":2,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Ōtsuchi", 3000, "1-1", 8, 15 },
                    { 17, 7, 3, 3, new Guid("b62e8802-baed-4b24-86d4-f95dfdd86c82"), "[{\"GripType\":2,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Tetsubō", 2000, "1-2", 5, 15 },
                    { 18, 3, 4, 2, new Guid("0403c313-c888-4165-ba3e-ea862f7a02e3"), "[{\"GripType\":1,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Jitte", 10, "0-0", 5, 15 },
                    { 19, 2, 4, 4, new Guid("1867197e-7356-4cae-bca8-3c4ff7364100"), "[{\"GripType\":1,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]},{\"GripType\":2,\"Bonus\":\"Deadliness +2\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Knife", 100, "0-0", 5, 15 },
                    { 20, 4, 4, 3, new Guid("dc6f6362-ffb4-4875-8014-c2e83dc4ba64"), "[{\"GripType\":1,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]},{\"GripType\":2,\"Bonus\":\"Snaring\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Nunchaku", 100, "0-1", 6, 15 },
                    { 21, 4, 4, 3, new Guid("4ef6e7b7-1045-4d4b-afd0-0c394fcabf43"), "[{\"GripType\":1,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Tessen", 1500, "0-1", 7, 15 },
                    { 22, 5, 5, 2, new Guid("728a3ba3-343c-47cc-932f-5720aeed4831"), "[{\"GripType\":1,\"Bonus\":\"Range 1\",\"ExtraDescription\":\"\",\"Weapons\":[]},{\"GripType\":2,\"Bonus\":\"Damage +2\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Bisentō", 1500, "2-2", 8, 15 },
                    { 23, 6, 5, 2, new Guid("6061e354-7151-4ad8-b8bc-c2fea19f1cfd"), "[{\"GripType\":2,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Bō", 20, "1-2", 2, 15 },
                    { 24, 5, 5, 2, new Guid("ca51e607-66be-431c-851c-715dc1622262"), "[{\"GripType\":2,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Ji", 700, "2-2", 6, 15 },
                    { 25, 6, 5, 6, new Guid("1fc3321f-45d2-4e8d-99c9-abef09c6f3d8"), "[{\"GripType\":2,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Naginata", 1000, "2-2", 8, 15 },
                    { 26, 4, 5, 4, new Guid("5b09b7f0-fac3-4634-9480-93a8c3c65229"), "[{\"GripType\":2,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Trident", 1000, "2-2", 7, 15 },
                    { 27, 5, 5, 3, new Guid("63c1b2b5-9a91-402c-8598-135fe17eff75"), "[{\"GripType\":2,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Yari", 500, "2-2", 3, 15 },
                    { 28, 6, 6, 4, new Guid("ec0d878d-62de-4138-9468-277d0aa95464"), "[{\"GripType\":2,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Daikyū", 600, "3-5", 6, 16 },
                    { 29, 4, 6, 5, new Guid("d60bdbbe-4b54-40d1-9288-5939090c042d"), "[{\"GripType\":2,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Shinjo Horsebow", 600, "2-4", 4, 16 },
                    { 30, 5, 6, 3, new Guid("7a8fcfe8-6f94-4098-ba3b-b48b1fd9967d"), "[{\"GripType\":2,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Yumi", 300, "2-5", 3, 16 },
                    { 31, 7, 7, 3, new Guid("f283fa16-6b2a-4de7-8f6d-91f8cdabd0bd"), "[{\"GripType\":2,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Oyumi", 400, "2-5", 8, 16 },
                    { 32, 1, 8, 2, new Guid("1d68e56a-6542-4cff-afc7-6807c319a126"), "[{\"GripType\":1,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Blowgun", 50, "2-3", 7, 16 },
                    { 33, 3, 8, 3, new Guid("ba0b15cf-5f31-4ea9-9ddf-5af0963a62a9"), "[{\"GripType\":1,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Kama", 100, "0-1", 4, 15 },
                    { 34, 3, 8, 3, new Guid("9b5ae25b-49e3-4f8b-bc67-9645b835aca7"), "[{\"GripType\":1,\"Bonus\":\"-\",\"ExtraDescription\":\"\",\"Weapons\":[]},{\"GripType\":2,\"Bonus\":\"Range 2-3\",\"ExtraDescription\":\"\",\"Weapons\":[]}]", true, "Kusari-Gama", 500, "0-0", 6, 15 },
                    { 35, 2, 8, 4, new Guid("662ac896-8686-4cc1-93f2-ea44e2416b40"), "[{\"GripType\":1,\"Bonus\":\"-\",\"ExtraDescription\":\"(stab or slash)\",\"Weapons\":[]},{\"GripType\":1,\"Bonus\":\"Martial Arts [Ranged], Range 1-3\",\"ExtraDescription\":\"(thrown)\",\"Weapons\":[]}]", true, "Shuriken", 100, "0-0", 6, 15 }
                });

            migrationBuilder.InsertData(
                schema: "Equipment",
                table: "WeaponItemQualities",
                columns: new[] { "QualitiesId", "WeaponsId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 9 },
                    { 1, 21 },
                    { 2, 15 },
                    { 2, 18 },
                    { 2, 19 },
                    { 2, 21 },
                    { 2, 32 },
                    { 2, 33 },
                    { 2, 34 },
                    { 2, 35 },
                    { 3, 10 },
                    { 3, 16 },
                    { 3, 17 },
                    { 3, 22 },
                    { 3, 25 },
                    { 6, 8 },
                    { 6, 17 },
                    { 6, 19 },
                    { 6, 22 },
                    { 8, 1 },
                    { 8, 11 },
                    { 8, 13 },
                    { 8, 14 },
                    { 8, 15 },
                    { 8, 19 },
                    { 8, 23 },
                    { 9, 31 },
                    { 10, 2 },
                    { 10, 6 },
                    { 10, 7 },
                    { 10, 8 },
                    { 10, 9 },
                    { 10, 25 },
                    { 13, 4 },
                    { 13, 18 },
                    { 13, 24 },
                    { 13, 26 },
                    { 13, 34 },
                    { 16, 10 }
                });

            migrationBuilder.InsertData(
                schema: "Equipment",
                table: "WeaponItemQualities",
                columns: new[] { "QualitiesId", "WeaponsId" },
                values: new object[,]
                {
                    { 16, 12 },
                    { 16, 16 },
                    { 16, 17 },
                    { 16, 22 },
                    { 16, 24 },
                    { 16, 25 },
                    { 16, 26 },
                    { 16, 27 },
                    { 16, 28 },
                    { 16, 29 },
                    { 16, 31 },
                    { 16, 34 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Skills_SkillGroupId",
                schema: "Skills",
                table: "Skills",
                column: "SkillGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponItemQualities_WeaponsId",
                schema: "Equipment",
                table: "WeaponItemQualities",
                column: "WeaponsId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_SkillId",
                schema: "Equipment",
                table: "Weapons",
                column: "SkillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeaponItemQualities",
                schema: "Equipment");

            migrationBuilder.DropTable(
                name: "ItemQualities",
                schema: "Equipment");

            migrationBuilder.DropTable(
                name: "Weapons",
                schema: "Equipment");

            migrationBuilder.DropTable(
                name: "Skills",
                schema: "Skills");

            migrationBuilder.DropTable(
                name: "SkillGroups",
                schema: "Skills");
        }
    }
}
