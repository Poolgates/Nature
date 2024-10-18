namespace Nature.Database
{
    public class MyDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;user=root;password=ora1@lan1;Database=gta;";            
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 25));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }

        public DbSet<Accounts> Account { get; set; }
    }
}
