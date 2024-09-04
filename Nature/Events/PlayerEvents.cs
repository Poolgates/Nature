using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using Nature.Factory.ClassicPlayer;
using Nature.Models;
using Nature.Services;

namespace Nature.Events
{
    public enum CharacterGender
    {
        Men,
        Women
    }

    public class PlayerEvents : IScript
    {
        [ScriptEvent(ScriptEventType.PlayerConnect)]
        public static void OnPlayerConnect(ClassicPlayer player, String reason)
        {
            player.Spawn(new Position(-425, 1115, 326), 1000);
            player.Model = (uint)PedModel.Business01AFY;

            Alt.Log(reason);
        }

        [ScriptEvent(ScriptEventType.PlayerDisconnect)]
        public static void OnPlayerDisconnect(ClassicPlayer player, String reason)
        {
            player.Model = 0;
            player.Despawn();
            Alt.Log(reason);
        }

        [ScriptEvent(ScriptEventType.PlayerDead)]
        public static void OnPlayerDead(ClassicPlayer player, IEntity killer, uint weapon)
        {
            Alt.Log($"PlayerDead: {player.Id}");
            Alt.Log($"Killer: {killer.Id}");
            Alt.Log($"Weapon: {weapon}");
        }
    }
}
