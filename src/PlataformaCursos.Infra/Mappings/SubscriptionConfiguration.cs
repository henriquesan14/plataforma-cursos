using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlataformaCursos.Core.Entities;

namespace PlataformaCursos.Infra.Mappings
{
    public class SubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.ToTable("Subscriptions");
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            builder.Property(d => d.Duration)
                    .IsRequired();

            builder.HasMany(d => d.Courses)
                .WithMany(p => p.Subscriptions)
                .UsingEntity(p => p.ToTable("CoursesSubscriptions"));

            builder.HasMany(d => d.UserSubscriptions)
                .WithOne(p => p.Subscription)
                .HasForeignKey(p => p.SubscriptionId);
        }
    }
}
