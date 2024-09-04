using AltV.Net;
using AltV.Net.Async;
using AltV.Net.Client.Elements.Entities;
using AltV.Net.Elements.Entities;
using Nature.Contracts;
using Nature.Factory.ClassicPlayer;
using Nature.Models;

namespace Nature
{
    public class Main : AsyncResource
    {
        public override void OnStart()
        {
            Alt.Log("Der Server wurde gestartet!");
            Services.ServerConfig.LoadServerConfig();
            
            GetPlayerFactory();
            Services.ObjectProvider.CreateObjects();
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
