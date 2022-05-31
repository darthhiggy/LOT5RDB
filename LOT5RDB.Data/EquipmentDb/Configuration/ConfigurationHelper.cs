using System.Reflection;

namespace LOT5RDB.Data.EquipmentDb.Configuration;

public static class ConfigurationHelper
{
    public static string GetJsonStringFromEmbeddedResource(string resourceName)
    {
        var assembly = Assembly.GetExecutingAssembly();
        foreach(var rec in assembly.GetManifestResourceNames())
        {
            Console.WriteLine(rec);
        }
        using Stream stream = assembly.GetManifestResourceStream(resourceName);
        using StreamReader reader = new StreamReader(stream);
        return reader.ReadToEnd();
    }
}
