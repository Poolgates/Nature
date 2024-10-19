﻿using AltV.Net.Async.Elements.Entities;
using AltV.Net.Async;

namespace Nature.Factory.ClassicPlayer
{
    public class ClassicPlayer : AsyncPlayer, IAsyncConvertible<ClassicPlayer>, IClassicPlayer
    {

        protected ICore _core;
        protected nint _nativePointer;
        protected uint _id;
        public ICharacter _character;

        // Constructors
        public ClassicPlayer(ICore core, nint nativePointer, uint id, ICharacter character) : base(core, nativePointer, id)
        {
            _core = core;
            _nativePointer = nativePointer;
            _id = id;
            _character = character;
        }

        public ClassicPlayer GetClassicPlayer()
        {
            return new ClassicPlayer(_core, _nativePointer, _id, _character);
        }

      

        ClassicPlayer IAsyncConvertible<ClassicPlayer>.ToAsync(IAsyncContext _) => this;
    }
}
