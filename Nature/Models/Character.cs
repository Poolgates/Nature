using AltV.Net;
using Nature.Contracts;
using Nature.Factory.ClassicPlayer;


namespace Nature.Models
{
    public class Character : IScript, ICharacter
    {
        private readonly List<Character> characters = new();

        // Klassenvariable
        private readonly IClassicPlayer? _player;

        // Eigenschaften
        public string CharName { get; set; } = String.Empty;
        public int Gender { get; set; }

        // Konstruktor
        public Character() {}

        public Character(string charname, int gender)
        {
            this.CharName = charname;
            this.Gender = gender;
        }

        public Character(IClassicPlayer player)
        {
            _player = player;         
        }

        // Objectverweis
        public Character GetPlayerCharakter()
        {
            Character player = new(_player!);
            
            return player;
        }

        // Methoden
        public void CreateNewCharacter(string charname, int gender) 
        {
            characters.Add(new Character(charname, gender));
              
            foreach (Character character in characters) 
            {
                Services.ConsolePrint.ConsoleColorMessage(4, character.CharName.ToString()!);
                Services.ConsolePrint.ConsoleColorMessage(4, character.Gender.ToString()!);
            }         
        }
    }
}
