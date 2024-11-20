using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaycardEditor.Domain.Entities;

namespace PaycardEditor.Infrastructure.Config;

public class PaycardConfiguration : BaseEntityConfiguration<Paycard>
{
    public override void Configure(EntityTypeBuilder<Paycard> builder)
    {
        builder.ToTable("Paycards");

        builder.Property(x => x.OwnerAccountNr)
            .HasMaxLength(24)
            .IsRequired();

        builder.Property(x => x.PIN)
            .HasMaxLength(4)
            .IsRequired();

        builder.Property(x => x.SerialNr)
            .HasMaxLength(16)
            .IsRequired();

        builder.HasIndex(x => x.CardId)
            .IsUnique();
        builder.Property(x => x.CardId)
            .HasMaxLength(32)
            .IsRequired();
        
        base.Configure(builder);
    }
}
