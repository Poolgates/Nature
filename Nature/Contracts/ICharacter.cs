using Nature.Models;

namespace Nature.Contracts
{
    public interface ICharacter
    {
        Character GetPlayerCharakter();
        void CreateNewCharacter(string charname, int gender);
    }
}
