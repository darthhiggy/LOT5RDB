namespace LOT5RDB.DataGenerator;

public class DataGenerator
{
    public static void Generate(string destination)
    {
        
        
    }

    public static string GetJsonString<T>(string propertyToGet)
    {
        var dataSeeder = new DataSeeds();
        var returnValue = typeof(T).GetProperty(propertyToGet).GetValue(dataSeeder);
        return "";
    }
}
