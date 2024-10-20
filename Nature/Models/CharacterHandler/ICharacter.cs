using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nature.Models.CharacterHandler
{
    public interface ICharacter
    {
        int GetPlayerGender();
        void SetPlayerGender(int gender);
        string GetPlayerCharName();
        void SetPlayerCharName(string charName);
        void CreateCharacter(string charName, int gender);
    }
}
