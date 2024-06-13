using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlataformaCursos.Core.Entities;

namespace PlataformaCursos.Infra.Persistence.Mappings
{
    public class UserSubscriptionConfiguration : IEntityTypeConfiguration<UserSubscription>
    {
        public void Configure(EntityTypeBuilder<UserSubscription> builder)
        {
            builder.ToTable("UserSubscriptions");
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Status)
                    .IsRequired();
            builder.Property(d => d.StartDate)
                    .IsRequired();
            builder.Property(d => d.ExpirationDate)
                    .IsRequired();

            builder.HasOne(d => d.User)
                .WithOne(p => p.UserSubscription);
        }
    }
}
