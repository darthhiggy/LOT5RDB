using Microsoft.EntityFrameworkCore.Migrations;
using LOT5RDB.Data.Configuration;

#nullable disable

namespace LOT5RDB.Data.TempStuff;

public partial class SeedWeaponData : Migration
{
    // private readonly DataSeeds _seedData;
    // public SeedWeaponData()
    // {
    //     _seedData = new DataSeeds();
    // }
    // protected override void Up(MigrationBuilder migrationBuilder)
    // {
    //     var itemQualityDescriptions = new List<string[]>();
    //     foreach(var item in _seedData.ItemQualitiesDescriptions)
    //     {
    //         var properties = new List<string>();
    //         foreach(var prop in item.GetType().GetProperties())
    //         {
    //             properties.Add(prop.ToString());
    //         } 
    //         itemQualityDescriptions.Add(properties.ToArray());
    //     }
    //     migrationBuilder.InsertData(
    //         table: "ItemQualities",
    //         schema: "Equipment",
    //         columns: new[] { "Id", "Name", "Description" },
    //         values: itemQualityDescriptions.ToArray())
    //         });
    //
    // }
    //
    // protected override void Down(MigrationBuilder migrationBuilder)
    // {
    //     for (int i = 1; i < DataSeeds.GetGripObjects().Length; i++)
    //     {
    //         migrationBuilder.DeleteData(
    //             table: "Grips",
    //             schema: "Equipment",
    //             keyColumn: "Id",
    //             keyValue: i);
    //     }
    //
    //     for (int i = 1; i < DataSeeds.GetItemQualitiesObjects().Length; i++)
    //     {
    //         migrationBuilder.DeleteData(
    //             table: "ItemQualities",
    //             schema: "Equipment",
    //             keyColumn: "Id",
    //             keyValue: i);
    //     }
    // }
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        throw new NotImplementedException();
    }
}
