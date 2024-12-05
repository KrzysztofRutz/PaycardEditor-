using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using PaycardEditor.Domain.Entities;
using PaycardEditor.Domain.Settings;
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

    internal class PaycardEditorDbContextFactory : IDesignTimeDbContextFactory<PaycardEditorDbContext>
    {
        private readonly AppSettings _settings;

        public PaycardEditorDbContextFactory(IOptions<AppSettings> settings)
        {
            _settings = settings.Value;
        }

        public PaycardEditorDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PaycardEditorDbContext>();
            optionsBuilder.UseSqlServer(_settings.PaycardCS);

            return new PaycardEditorDbContext(optionsBuilder.Options);
        }
    }
}
