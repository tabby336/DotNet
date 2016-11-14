using Microsoft.EntityFrameworkCore;

namespace DataLayer 
{
    public class ProductManagement : DbContext
    {

        //public ProductManagement(DbContextOptions<ProductManagement> options) : base(options) 
        //{}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().Property(customer=>customer.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Customer>().Property(customer=>customer.Address).IsRequired().HasMaxLength(300);
            modelBuilder.Entity<Customer>().Property(customer => customer.PhoneNumber)
                    .IsRequired().Equals(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");
            modelBuilder.Entity<Customer>().Property(customer => customer.Email)
                    .IsRequired().Equals(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=paranoiaa;Host=localhost;Port=5432;Database=ioana;Pooling=true;");
        }

        public DbSet<Product> Products {get; set;}
        
        public DbSet<Customer> Customers {get; set;}
    }
}