namespace Nature.model
{
    public class Accounts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int playerid { get; set; }
        public string playerName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public ulong socialClub { get; set; }
        public ulong hardwareId { get; set; }
        public string password { get; set; } = string.Empty;
        public int Online { get; set; }
        public bool whitelisted { get; set; }
        public bool ban { get; set; }
        public string banReason { get; set; } = string.Empty;
        public int adminLevel { get; set; }
        public string resetToken { get; set; } = "";
    }
}
