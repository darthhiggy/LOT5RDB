
using System.Security.Principal;
using System.Text.Json;
using LOT5RDB.DataGenerator;
using Newtonsoft.Json;

var dataSeeder = new DataSeeds();
//var returnValue = typeof(List<SkillModel>).GetProperty("Skills").GetValue(dataSeeder);
var type = dataSeeder.GetType();
var props = type.GetProperties().FirstOrDefault(p => p.Name.Equals("Descriptions"));
var value = props.GetValue(dataSeeder);
var jsonString = JsonConvert.SerializeObject(value);
Console.WriteLine(jsonString);
