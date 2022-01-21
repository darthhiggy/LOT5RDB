using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LOT5RDB.Data.Migrations
{
    public partial class SkillandWeaponsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Equipment");

            migrationBuilder.EnsureSchema(
                name: "Skills");

            migrationBuilder.CreateTable(
                name: "Grips",
                schema: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GripType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bonus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExtraDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeaponId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemQualities",
                schema: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillGroupId = table.Column<int>(type: "int", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    Range = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaseDamage = table.Column<int>(type: "int", nullable: false),
                    Deadliness = table.Column<int>(type: "int", nullable: false),
                    Rarity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "WeaponGrips",
                schema: "Equipment",
                columns: table => new
                {
                    GripsId = table.Column<int>(type: "int", nullable: false),
                    WeaponsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponGrips", x => new { x.GripsId, x.WeaponsId });
                    table.ForeignKey(
                        name: "FK_WeaponGrips_Grips_GripsId",
                        column: x => x.GripsId,
                        principalSchema: "Equipment",
                        principalTable: "Grips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeaponGrips_Weapons_WeaponsId",
                        column: x => x.WeaponsId,
                        principalSchema: "Equipment",
                        principalTable: "Weapons",
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

            migrationBuilder.CreateIndex(
                name: "IX_Skills_SkillGroupId",
                schema: "Skills",
                table: "Skills",
                column: "SkillGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponGrips_WeaponsId",
                schema: "Equipment",
                table: "WeaponGrips",
                column: "WeaponsId");

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
                name: "WeaponGrips",
                schema: "Equipment");

            migrationBuilder.DropTable(
                name: "WeaponItemQualities",
                schema: "Equipment");

            migrationBuilder.DropTable(
                name: "Grips",
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
