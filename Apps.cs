using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

[Serializable]
public class Apps
{
    [XmlIgnore]
    public static string FileName = AppDomain.CurrentDomain.BaseDirectory + "\\config.xml";

    public bool StartWithWindows = false;
    
    [XmlIgnore]
    public static Apps Instance { get; private set; }

    public int Count { get => AppsList.Count; }

    public List<App> AppsList = new List<App>();

    public Apps()
    {

    }

    public void Add(App app)
    {
        AppsList.Add(app);
    }


    // Loads the configuration from file.
    public static void Load()
    {
        var serializer = new XmlSerializer(typeof(Apps));
        Apps.Instance = new Apps();
        if (File.Exists(Apps.FileName))
        {
            using (var fStream = new FileStream(Apps.FileName, FileMode.Open))
                Apps.Instance = (Apps)serializer.Deserialize(fStream);

        }
    }

    // Saves the configuration to file.
    public void Save()
    {
        var serializer = new XmlSerializer(typeof(Apps));

        using (var fStream = new FileStream(Apps.FileName, FileMode.Create))
            serializer.Serialize(fStream, this);
    }

}

[Serializable]
public class App
{
    public string Name { get; set; }
    public int Delay { get; set; }
    public string Path { get; set; }

    public App()
    {

    }
}

