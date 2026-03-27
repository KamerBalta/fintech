using Fintech.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Fintech.DataAccess.Concrete.Context
{
    public class FintechContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // BURADAKİ Connection String'i kendi MSSQL server ismine göre düzenlemelisin
            // Server=BURAYA_SERVER_ISMI; Database=FintechDb; Trusted_Connection=True; TrustServerCertificate=True;
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-1K2JHII\SQLEXPRESS;Database=FintechDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<User> Users { get; set; }
        // Diğer tabloları (Transactions, Accounts vb.) buraya daha sonra ekleyeceğiz.
    
        public DbSet<Transaction> Transactions { get; set; }
    
    }

}