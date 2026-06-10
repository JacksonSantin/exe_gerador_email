using System.Text.Json;

namespace GeradorEmail;

public class AppConfig
{
    public string Domain { get; set; } = "meudominio.com";
}

public static class ConfigManager
{

    private static readonly string ConfigDirectory =
    Path.Combine(
        Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData),
        "GeradorEmail");
    private static readonly string ConfigPath =
    Path.Combine(
        ConfigDirectory,
        "config.json");

    public static AppConfig Load()
    {
        try
        {
            if (!Directory.Exists(ConfigDirectory))
            {
                Directory.CreateDirectory(ConfigDirectory);
            }

            if (!File.Exists(ConfigPath))
            {
                var config = new AppConfig();

                Save(config);

                return config;
            }

            string json = File.ReadAllText(ConfigPath);

            return JsonSerializer.Deserialize<AppConfig>(json) ?? new AppConfig();
        }
        catch
        {
            return new AppConfig();
        }
    }

    public static void Save(AppConfig config)
    {
        Directory.CreateDirectory(ConfigDirectory);

        string json =
            JsonSerializer.Serialize(
                config,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

        File.WriteAllText(ConfigPath, json);
    }
}