using AltV.Net.Async.Elements.Entities;
using AltV.Net.Async;
using Nature.Models.CharacterHandler;

namespace Nature.Factory.ClassicPlayer
{
    public class ClassicPlayer : AsyncPlayer, IAsyncConvertible<ClassicPlayer>, IClassicPlayer
    {

        protected ICore _core;
        protected nint _nativePointer;
        protected uint _id;
        public IAccount _account;
        public ICharacter _character;
       

        // Constructors
        public ClassicPlayer(ICore core, nint nativePointer, uint id, IAccount account, ICharacter character) : base(core, nativePointer, id)
        {
            _core = core;
            _nativePointer = nativePointer;
            _id = id;
            _account = account;
            _character = character;
        }

        public ClassicPlayer GetClassicPlayer()
        {
            return new ClassicPlayer(_core, _nativePointer, _id, _account, _character);
        }

      

        ClassicPlayer IAsyncConvertible<ClassicPlayer>.ToAsync(IAsyncContext _) => this;
    }
}
