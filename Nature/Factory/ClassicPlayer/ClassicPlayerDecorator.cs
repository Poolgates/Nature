namespace Nature.Factory.ClassicPlayer
{
    public class ClassicPlayerDecorator : IClassicPlayer
    {
        protected IClassicPlayer _classicPlayer;
        public ClassicPlayerDecorator(IClassicPlayer classicPlayer)
        {
            _classicPlayer = classicPlayer;
        }

        public virtual ClassicPlayer GetClassicPlayer()
        {
            return _classicPlayer.GetClassicPlayer();
        }

    
    }
}
