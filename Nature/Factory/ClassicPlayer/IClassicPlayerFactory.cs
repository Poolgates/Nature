using AltV.Net;
using AltV.Net.Elements.Entities;

namespace Nature.Factory.ClassicPlayer
{
    public interface IClassicPlayerFactory
    {
        IPlayer Create(ICore core, nint entityPointer, uint id);
    }
}
