using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AbnourTask.Ef
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        protected ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Customer).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Order).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Sale).Assembly);

            modelBuilder.Entity<Order>()
                .HasOne(c => c.Customer)
                .WithMany(o => o.Order)
                .HasForeignKey(o => o.CustomerId)
                .HasPrincipalKey(c => c.CustomerId);

            modelBuilder.Entity<Order>()
                .HasOne(c => c.Sale)
                .WithMany(o => o.Order)
                .HasForeignKey(o => o.SalesId)
                .HasPrincipalKey(c => c.SaleId);
        }

    }
}