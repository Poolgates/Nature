using AltV.Net.Async;
using AltV.Net.Elements.Entities;


namespace Nature.Factory.ClassicPlayer
{
    public interface IClassicPlayer : IPlayer, IAsyncConvertible<IClassicPlayer>
    {
        public new IClassicPlayer ToAsync(IAsyncContext _) => this;
    }
}
