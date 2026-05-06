using Microsoft.EntityFrameworkCore;

namespace DataAccess.Entities
{
    public class MyCRMContext : DbContext
    {
        public MyCRMContext(DbContextOptions<MyCRMContext> options)
            : base(options)
        {        
            var databaseProvider = Database.ProviderName;
            if (databaseProvider != "Microsoft.EntityFrameworkCore.InMemory")
            {
                Database.Migrate();
                if (!Contacts.Any())
                {
                    var contact1 = new Contact
                    {
                        FirstName = "John",
                        LastName = "Doe",
                        Account = new Account("Microsoft")
                    };

                    var contact2 = new Contact
                    {
                        FirstName = "Jane",
                        LastName = "Smith",
                        Account = new Account("Google")
                    };

                    Contacts.AddRange(contact1, contact2);
                    SaveChanges();
                }
            }
            else
            {
                Database.EnsureCreated();
            }
        }

        public DbSet<Account> Accounts { get; set; } = null!;

        public DbSet<Contact> Contacts { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Account>().ToTable("Accounts");
           modelBuilder.Entity<Contact>().ToTable("Contacts");
        }
    }
}
