using AltV.Net;
using AltV.Net.Async;
using AltV.Net.Async.Elements.Entities;
using AltV.Net.Client.Elements.Entities;
using AltV.Net.Client.Elements.Interfaces;
using AltV.Net.Elements.Entities;
using Nature.Contracts;
using Nature.Models;

namespace Nature.Factory.ClassicPlayer
{
    public class ClassicPlayer : AsyncPlayer, IClassicPlayer
    {
        // Fields

       
        

        // Constructors
        public ClassicPlayer(ICore core, nint nativePointer, uint id) : base(core, nativePointer, id)
        {
            
        }

      

        IClassicPlayer IAsyncConvertible<IClassicPlayer>.ToAsync(IAsyncContext _) => this;

        // Methods
        /* 
            public void CheckPlayerIsInGame()
            {
                ClassicPlayerFactory factory = new();
                ClassicPlayer player = (ClassicPlayer)factory.Create(core, nativePointer, id);
                MyPlayer = player;
                Alt.Log("Players IP:" + MyPlayer.Ip.ToString());           
            }
        */
    }
}
