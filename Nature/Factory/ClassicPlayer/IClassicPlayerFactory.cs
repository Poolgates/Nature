using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nature.Factory.ClassicPlayer
{
    public interface IClassicPlayerFactory
    {
        // ClassicPlayer GetClassicplayer();
        ICharacter CreateCharacterObject();
        IAccount CreateAccountObject();
    }
}
