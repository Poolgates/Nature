namespace Nature.Models.AccountHandler
{
    public interface IAccount
    {
        void InitAccount();
        public void CreatePlayerAccount(string accountName, string password, string email, int Adminlevel);


    }
}
