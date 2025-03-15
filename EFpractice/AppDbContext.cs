using Microsoft.EntityFrameworkCore;

namespace EFpractice
{
    internal class  AppDbContext :DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Player { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-ZAKIR;Database=EFTeamsPractice;Trusted_Connection=True;TrustServerCertificate=true");
        }
    }
}
