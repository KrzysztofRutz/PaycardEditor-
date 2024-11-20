using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PaycardEditor.Domain.Entities;
using PaycardEditor.Infrastructure.Config;

namespace PaycardEditor.Infrastructure.Context;

internal class PaycardEditorDbContext : DbContext
{
    public DbSet<Paycard> Paycards { get; set; }
    public PaycardEditorDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("paycardEditor");

        modelBuilder.ApplyConfiguration(new PaycardConfiguration());
    }

    public class PaycardEditorDbContextFactory : IDesignTimeDbContextFactory<PaycardEditorDbContext>
    {
        public PaycardEditorDbContextFactory()
        {
        }

        public PaycardEditorDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PaycardEditorDbContext>();
            optionsBuilder.UseSqlServer("Server=LAPTOP-G9F6P9TK\\SQLEXPRESS;Database=PaycardDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True");

            return new PaycardEditorDbContext(optionsBuilder.Options);
        }
    }
}
