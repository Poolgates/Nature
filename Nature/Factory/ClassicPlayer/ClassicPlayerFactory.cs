namespace Nature.Factory.ClassicPlayer
{

    interface IClassicPlayerFactory
    {
        ClassicPlayer GetClassicplayer();
    }


    public class ClassicPlayerFactory : IEntityFactory<IPlayer>
    {
        public IPlayer Create(ICore core, nint entityPointer, uint id)
        {
           
            Character character = new Character("", (int)Character.GenderType.Nothing);

            return new ClassicPlayer(core, entityPointer, id, character);
        }
    }
}
