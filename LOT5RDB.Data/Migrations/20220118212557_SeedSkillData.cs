using System.Windows.Markup;
using Microsoft.EntityFrameworkCore.Migrations;
using LOT5RDB.Data.Configuration;
#nullable disable

namespace LOT5RDB.Data.Migrations
{
    public partial class SeedSkillData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SkillGroups",
                schema: "Skills",
                columns: new[] {"Id", "Name", "Description"},
                values: DataSeeds.GetSkillGroupObjects());

            migrationBuilder.InsertData(
                table: "Skills",
                schema: "Skills",
                columns: new[] {"Id", "Name", "Description", "SkillGroupId"},
                values: DataSeeds.GetSkillObjects());
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            for (int i = 1; i < DataSeeds.GetSkillObjects().Length; i++)
            {
                migrationBuilder.DeleteData(
                    table: "Skills",
                    schema: "Skills",
                    keyColumn: "Id",
                    keyValue: i);
            }

            for (int i = 1; i < DataSeeds.GetSkillGroupObjects().Length; i++)
            {
                migrationBuilder.DeleteData(
                    table: "SkillGroups",
                    schema: "Skills",
                    keyColumn: "Id",
                    keyValue: i);
            }
        }
    }
}
