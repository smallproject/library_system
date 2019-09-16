using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Library_system.Database
{
    class LibrarySystemContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<Account> Accounts { get; set; }
        public System.Data.Entity.DbSet<User> Users { get; set; }
        public System.Data.Entity.DbSet<Index> Indices { get; set; }
    }

}
