using Nature.Database;
using Nature.Models.AccountHandler;
using System.Reflection;

namespace Nature.Models.CharacterHandler
{
    public class Character : IScript, ICharacter
    {
        // Eigenschaften
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CharName { get; set; } = string.Empty;
        public int Gender { get; set; }

        // Default Konstruktor
        public Character() { }

        // Konstruktor
        public Character(string charName, int gender)
        {
            CharName = charName;
            Gender = gender;
        }

        // Methoden

        public void CreateCharacter(string charName, int gender)
        {
            try
            {
                Character characterData = new Character
                (
                    CharName = charName,
                    Gender = gender

                );


                ServicePropertyList._characterList.Add(characterData);

                using (MyDBContext db = new MyDBContext())
                {
                    db.Character.Add(characterData);
                    db.SaveChanges();
                    Alt.Log($"Account {CharName} mit dem Gender {Gender} wurde in der Datenbank eingetragen");
                };

            }
            catch (Exception e)
            {
                Alt.LogError($"{GetType().Name}.{MethodInfo.GetCurrentMethod()!.Name} zeigt Fehler: {e.Message} ");
            }
        }





            public void SetPlayerGender(int gender) 
        {
            Gender = gender;
        }

        public void SetPlayerCharName(string charName)
        {
            CharName = charName;
        }

        public int GetPlayerGender()
        {
            return Gender;  
        }

        public string GetPlayerCharName()
        {
            return CharName;
        }
    }
}
