using AltV.Net.Async;

namespace Nature
{
    public class Main : AsyncResource
    {
        public override void OnStart()
        {
            Alt.Log("Der Server wurde gestartet!");
            Services.ServerConfig.LoadServerConfig();

            Database.DatabaseHandler.LoadAllPlayerAccounts();
            Database.DatabaseHandler.LoadAllPlayerCharacters();

            GetPlayerFactory();
            Services.ServerEntitySync.LoadEntitySync();

          
        }

        public override void OnStop()
        {
            Alt.Log("Server ist gestoppt.");
        }

        public override IEntityFactory<IPlayer> GetPlayerFactory()
        {
            return new ClassicPlayerFactory();
        }
    }
}
