namespace Nature.Events
{
    public class PlayerEvents : IScript
    {
        [ScriptEvent(ScriptEventType.PlayerConnect)]
        public static void OnPlayerConnect(ClassicPlayer player, string reason)
        {
          
            player.Spawn(new Position(-425, 1115, 326), 1000);
            player.Model = (uint)PedModel.Business01AFY;
            
           

            ConsolePrint.ConsoleColorMessage(4, player._character.CharName);
            ConsolePrint.ConsoleColorMessage(4, player._character.Gender.ToString());


            player._character.GetPlayerGender(1);
            player._character.GetPlayerCharName("Test");
            ConsolePrint.ConsoleColorMessage(4, player._character.CharName);
            ConsolePrint.ConsoleColorMessage(4, player._character.Gender.ToString());



            Alt.Log(reason);
        }

        [ScriptEvent(ScriptEventType.PlayerDisconnect)]
        public static void OnPlayerDisconnect(ClassicPlayer player, string reason)
        {
            player.Model = 0;
            player.Despawn();
            Alt.Log(reason);
        }

        [ScriptEvent(ScriptEventType.PlayerDead)]
        public static void OnPlayerDead(ClassicPlayer player, AltV.Net.Elements.Entities.IEntity killer, uint weapon)
        {
            Alt.Log($"PlayerDead: {player.Id}");
            Alt.Log($"Killer: {killer.Id}");
            Alt.Log($"Weapon: {weapon}");
        }
    }
}
