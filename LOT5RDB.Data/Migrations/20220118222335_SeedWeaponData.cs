using Microsoft.EntityFrameworkCore.Migrations;
using LOT5RDB.Data.Configuration;

#nullable disable

namespace LOT5RDB.Data.Migrations
{
    public partial class SeedWeaponData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Grips",
                schema: "Equipment",
                columns: new[] { "Id", "GripType", "Bonus", "ExtraDescription" },
                values: DataSeeds.GetGripObjects());

            migrationBuilder.InsertData(
                table: "ItemQualites",
                schema: "Equipment",
                columns: new[] { "Id", "Name", "Description" },
                values: DataSeeds.GetItemQualitiesObjects());

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            for (int i = 1; i < DataSeeds.GetGripObjects().Length; i++)
            {
                migrationBuilder.DeleteData(
                    table: "Grips",
                    schema: "Equipment",
                    keyColumn: "Id",
                    keyValue: i);
            }

            for (int i = 1; i < DataSeeds.GetItemQualitiesObjects().Length; i++)
            {
                migrationBuilder.DeleteData(
                    table: "ItemQualities",
                    schema: "Equipment",
                    keyColumn: "Id",
                    keyValue: i);
            }
        }
    }
}
