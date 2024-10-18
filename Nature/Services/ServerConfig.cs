using AltV.Net.Async;

namespace Nature.Services
{
    public class ServerConfig
    {
        public static void LoadServerConfig()
        {
            string tomlName = "server.toml";
            string path = @"D:\AltVServer";

            // string configFile = Path.Combine(Alt.RootDirectory, tomlName);
            string configFile = Path.Combine(path, tomlName);


            if (File.Exists(configFile))
            {

                AltAsync.Log("===================================================");
 
                ColoredMessage loadTOMLMessage = new();
                loadTOMLMessage += TextColor.White;
                loadTOMLMessage += "Versucht, ";
                loadTOMLMessage += TextColor.Green;
                loadTOMLMessage += tomlName;
                loadTOMLMessage += TextColor.White;
                loadTOMLMessage += " zu laden: ";
                loadTOMLMessage += TextColor.Green;
                loadTOMLMessage += File.Exists(tomlName).ToString();

                ColoredMessage loadConfigMessage = new();
                loadConfigMessage += TextColor.Green;
                loadConfigMessage += tomlName;
                loadConfigMessage += TextColor.White;
                loadConfigMessage += " wurde als Konfigurationswerte verwendet.";

                Alt.LogColored(loadTOMLMessage);
                Alt.LogColored(loadConfigMessage);

                AltAsync.Log("===================================================");
            }
            else
            {
                Alt.LogError($"Die Datei {tomlName} wurde nicht gefunden ");
                Alt.LogError($"Hier ist der Suchort" + configFile);
            }


        }
    }
}
