using Microsoft.Extensions.DependencyInjection;
using Nature.Contracts;
using Nature.Factory.ClassicPlayer;
using Nature.Models;

namespace Nature.Services
{
    internal class ObjectProvider
    {
        public static void CreateObjects()
        {
            IServiceCollection collection = new ServiceCollection();
            // collection.AddTransient<IClassicPlayerFactory, ClassicPlayerFactory>();
            collection.AddTransient<IClassicPlayer, ClassicPlayer>();
            collection.AddTransient<ICharacter, Character>();
           
           
           IServiceProvider provider = collection.BuildServiceProvider();
           Character character = provider.GetService<Character>()!;
           character.CreateNewCharacter("Sotti", 0);
        }
    }
}
