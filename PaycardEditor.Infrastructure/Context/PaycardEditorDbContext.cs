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
        private readonly IConfiguration _configuration;

        public PaycardEditorDbContextFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public PaycardEditorDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PaycardEditorDbContext>();
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("PaycardCS"));

            return new PaycardEditorDbContext(optionsBuilder.Options);
        }
    }
}
