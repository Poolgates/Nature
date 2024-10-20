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
                Alt.Log($"{ServicePropertyList._accountList.Count} Accounts wurden geladen.");
            }
            catch (Exception e)
            {
                Alt.Log($"{e}");
            }
        }

        public static async void LoadAllPlayerCharacters()
        {
            try
            {
                await using MyDBContext db = new MyDBContext();
                ServicePropertyList._characterList = new List<Character>(db.Character);
                Alt.Log($"{ServicePropertyList._characterList.Count} Charakter wurden geladen.");
            }
            catch (Exception e)
            {
                Alt.Log($"{e}");
            }
        }
    }
}
