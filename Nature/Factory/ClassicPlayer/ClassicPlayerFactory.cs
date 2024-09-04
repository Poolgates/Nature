using AltV.Net;
using AltV.Net.Elements.Entities;
using Nature.Contracts;
using Nature.Models;

namespace Nature.Factory.ClassicPlayer
{
    internal class ClassicPlayerFactory : IEntityFactory<IPlayer>
    {
        public IPlayer Create(ICore core, nint entityPointer, uint id)
        {   
            return new ClassicPlayer(core, entityPointer, id);
        }
    }
}
