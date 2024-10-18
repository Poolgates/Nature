using AltV.Net;
using Nature.Factory.ClassicPlayer;


namespace Nature.Models
{
    public class Character : ClassicPlayerDecorator, IScript
    {
        // Gentype
        enum GenderType
        {
            Nothing = 0,
            Man = 1,
            Wife = 2
        }

        // Klassenvariablen
        protected string _name = string.Empty;
        protected int _gender = (int)GenderType.Nothing;

        // Konstruktor
        public Character(IClassicPlayer player) : base(player)
        {
        }
      
        public override ClassicPlayer GetClassicPlayer()
        {
            return _classicPlayer.GetClassicPlayer();
        }

        // Eigenschaften
        public string CharName
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

      
    }
}
