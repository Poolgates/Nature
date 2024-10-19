using AltV.Net;
using Nature.Factory.ClassicPlayer;
using static Nature.Models.Character;


namespace Nature.Models
{
    public interface ICharacter
    {
        string CharName { get; set; }
        int Gender { get; set; }

        void GetPlayerGender(int gender);
        void GetPlayerCharName(string charName);
    }



    public class Character : IScript, ICharacter
    {
        // Gentype
        public enum GenderType
        {
            Nothing = 0,
            Man = 1,
            Wife = 2
        }

        // Klassenvariablen
        protected string _charNname = string.Empty;
        protected int _gender = (int)GenderType.Nothing;

        // Konstruktor
        public Character(string charName, int gender)
        {
            CharName = charName;
            Gender = gender;
        }

        // Eigenschaften
        public string CharName { get; set; }
        public int Gender { get; set; }

        public void GetPlayerGender(int gender)
        {
            GenderType _gender = (GenderType)gender;
            Gender = gender;
        }

        public void GetPlayerCharName(string charName)
        {
            CharName = charName;
        }
    }
}
