using Nature.Database;
using System.ComponentModel;
using System.Reflection;

namespace Nature.Models.AccountHandler
{
    public class Account : IScript, IAccount
    {
        // Eigenschaften  
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountId { get; set; }
        public string AccountName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public ulong SocialClubId { get; set; }
        public ulong HardwareId { get; set; }
        public string Password { get; set; } = string.Empty;
        public int Online { get; set; }
        public bool Whitelisted { get; set; }
        public bool Ban { get; set; }
        public string BanReason { get; set; } = string.Empty;
        public int AdminLevel { get; set; }
        public string ResetToken { get; set; } = "";


        // Default Konstruktor
        public Account() {}

        // Konstruktor  
        public Account(int accountId, string accountName, string email, ulong socialClubId, ulong hardwareId, string password, int online, bool whitelisted, bool ban, string banReason, int Adminlevel, string resetToken)
        {
            AccountId = accountId;
            AccountName = accountName;
            Email = email;
            SocialClubId = socialClubId;
            HardwareId = hardwareId;
            Password = password;
            Online = online;
            Whitelisted = whitelisted;
            Ban = ban;
            BanReason = banReason;
            AdminLevel = Adminlevel;
            ResetToken = resetToken;
        }

        public void InitAccount()
        {

        }

        public void CreatePlayerAccount(string accountName, string password, string email, int adminlevel)
        {
            try
            {
                Account accountData = new Account
                (
                    AccountId = SetAccountId(),
                    AccountName = accountName,
                    Email = email,
                    SocialClubId = 0,
                    HardwareId = 0,
                    Password = password,
                    Online = 0,
                    Whitelisted = false,
                    Ban = false,
                    BanReason = string.Empty,
                    AdminLevel = adminlevel,
                    ResetToken = string.Empty
                );

               
                ServicePropertyList._accountList.Add(accountData);

                using (MyDBContext db = new MyDBContext())
                {
                    db.Account.Add(accountData);
                    db.SaveChanges();
                    Alt.Log($"Account {AccountName} mit der ID {AccountId} wurde in der Datenbank eingetragen");
                };

            }
            catch (Exception e)
            {
                Alt.LogError($"{GetType().Name}.{MethodInfo.GetCurrentMethod()!.Name} zeigt Fehler: {e.Message} ");
            }
        }

        // SET-Methoden
        private static int SetAccountId()
        {
            using (MyDBContext db = new MyDBContext())
            {
                if(db.Account.Count() == 0)
                {
                    return 1;
                }
                else
                { 
                    var accountId = db.Account.Max(x => x.AccountId) + 1;
                    return accountId;
                }
            }
        }
  

    }
}
