using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlataformaCursos.Core.Entities;

namespace PlataformaCursos.Infra.Mappings
{
    public class PaymentSubscriptionConfiguration : IEntityTypeConfiguration<PaymentSubscription>
    {
        public void Configure(EntityTypeBuilder<PaymentSubscription> builder)
        {
            builder.ToTable("PaymentsSubscription");
            builder.HasKey(d => d.Id);
            builder.Property(d => d.ProcessingDate)
                    .IsRequired();
            builder.Property(d => d.Status)
                    .IsRequired();
            builder.Property(d => d.Message)
                    .IsRequired()
                    .HasMaxLength(300);
            builder.Property(d => d.Value)
                    .IsRequired()
                    .HasPrecision(5, 2);
            builder.Property(d => d.PaymentLink)
                    .IsRequired()
                    .HasMaxLength(300);
            builder.Property(d => d.PaymentExternalId)
                    .IsRequired()
                    .HasMaxLength(100);
            builder.Property(d => d.DueDate)
                    .IsRequired();

            builder.HasOne(d => d.UserSubscription)
                .WithOne(e => e.PaymentSubscription)
                .HasForeignKey<UserSubscription>(e => e.Id);
        }
    }
}
