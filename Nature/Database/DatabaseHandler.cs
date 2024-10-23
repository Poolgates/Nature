using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Nature.Database
{
    public class DatabaseHandler
    {
        public static async void LoadAllPlayerAccounts()
        {
            try
            {
                await using MyDBContext db = new MyDBContext();
                ServicePropertyList._accountList = new List<Account>(db.Account);

                ConsolePrint.ConsoleColorMessageMulti(2, $"{ServicePropertyList._accountList.Count}", 7, " Accounts wurden geladen");            
            }
            catch (Exception e)
            {
                Alt.LogError($"{typeof(DatabaseHandler).Name}.{MethodInfo.GetCurrentMethod()!.Name} zeigt Fehler: {e.Message} ");
            }
        }

        public static async void LoadAllPlayerCharacters()
        {
            try
            {
                await using MyDBContext db = new MyDBContext();
                ServicePropertyList._characterList = new List<Character>(db.Character);
                ConsolePrint.ConsoleColorMessageMulti(2, $"{ServicePropertyList._characterList.Count}", 7, " Characters wurden geladen");
            }
            catch (Exception e)
            {
                Alt.LogError($"{typeof(DatabaseHandler).Name}.{MethodInfo.GetCurrentMethod()!.Name} zeigt Fehler: {e.Message} ");
            }
        }
    }
}
