using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public static class DataLoader
{
    public static List<Category> LoadData(string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Category>), new XmlRootAttribute("Categories"));
        using (StreamReader reader = new StreamReader(filePath))
        {
            return (List<Category>)serializer.Deserialize(reader);
        }
    }
}
