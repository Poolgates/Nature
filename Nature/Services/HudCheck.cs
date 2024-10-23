using AltV.Net.Async;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nature.Services
{
    public static class HudCheck
    {
        [AsyncClientEvent("Server:CEF:setCefStatus")]
        public static async void SetCefStatus(ClassicPlayer player, bool status)
        {
            if (player == null || !player.Exists) return;
            await AltAsync.Do(() => player.SetSyncedMetaData("IsCefOpen", status));
        }

        public static bool IsCefOpen(this ClassicPlayer player)
        {
            if (player == null || !player.Exists) return false;
            player.GetSyncedMetaData("IsCefOpen", out bool isCefOpened);
            return isCefOpened;
        }
    }
}
