using Microsoft.EntityFrameworkCore;

namespace Data
{
    internal class MasterDetailsContext : DbContext
    {
        public DbSet<Model.DetailView> DetailsView { get; set; }
        public DbSet<Model.MasterView> MastersView { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source = DESKTOP-J5R38NF;
Initial Catalog = MasterDetails1; 
Persist Security Info = False; 
User ID = user2; 
Password = 12345; 
Pooling = False; 
MultipleActiveResultSets = False; 
Encrypt = False; 
TrustServerCertificate = True; 
Command Timeout = 0"
);
        }
    }
}
