using Nature.Models.AccountHandler;
using Nature.Models.CharacterHandler;
using System.Reflection;

namespace Nature.Factory.ClassicPlayer
{
    public class ClassicPlayerFactory : IEntityFactory<IPlayer>, IClassicPlayerFactory
    {
        public IPlayer Create(ICore core, nint entityPointer, uint id)
        {
            IAccount account = CreateAccountObject();
            ICharacter character = CreateCharacterObject();

            return new ClassicPlayer(core, entityPointer, id, account, character);
        }

        public ICharacter CreateCharacterObject()
        {
            // Default character
            ICharacter character = new Character(string.Empty, (int)GenderEnum.GenderType.Nothing);

            try
            {
                // Get character data
                Character characterData = ServicePropertyList._characterList.FirstOrDefault()!;

                // Create character object
                character = new Character
                (
                    characterData.CharName,
                    characterData.Gender
                );

                return character;
            }
            catch (Exception e)
            {
                Alt.LogError($"{typeof(ClassicPlayerFactory).Name}.{MethodInfo.GetCurrentMethod()!.Name} zeigt Fehler: {e.Message} ");
                return character;
            }
            
        }

        public IAccount CreateAccountObject()
        {
            // Default account
            IAccount account = new Account(0, string.Empty, string.Empty, 0, 0, string.Empty, 0, false, false, string.Empty, 0, string.Empty);

            try
            {
                // Get account data
                Account accountData = ServicePropertyList._accountList.FirstOrDefault()!;

                // Create account object
              
                account = new Account
                (
                    accountData.AccountId,
                    accountData.AccountName,
                    accountData.Email,
                    accountData.SocialClubId,
                    accountData.HardwareId,
                    accountData.Password,
                    accountData.Online,
                    accountData.Whitelisted,
                    accountData.Ban,
                    accountData.BanReason,
                    accountData.AdminLevel,
                    accountData.ResetToken
                );
           
                return account;
            }
            catch (Exception e)
            {
                Alt.LogError($"{typeof(ClassicPlayerFactory).Name}.{MethodInfo.GetCurrentMethod()!.Name} zeigt Fehler: {e.Message} ");
                return account;
            }
           
        }
    }
}
