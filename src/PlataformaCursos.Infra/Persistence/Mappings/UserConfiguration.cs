using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlataformaCursos.Core.Entities;

namespace PlataformaCursos.Infra.Persistence.Mappings
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            builder.Property(d => d.Email)
                    .IsRequired()
                    .HasMaxLength(200);
            builder
                .HasIndex(e => e.Email)
                .IsUnique();
            builder.Property(d => d.Password)
                    .IsRequired()
                    .HasMaxLength(200);
            builder.Property(d => d.BirthDate)
                    .IsRequired();
            builder.Property(d => d.Document)
                    .IsRequired()
                    .HasMaxLength(100);
            builder.Property(d => d.Password)
                    .IsRequired()
                    .HasMaxLength(200);
            builder.Property(d => d.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(100);
            builder.Property(d => d.Role)
                    .IsRequired();
            builder.Property(d => d.Active)
                    .IsRequired();


            builder.HasMany(d => d.UserSubscriptions)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);

            builder.HasMany(d => d.UserLessonsCompleted)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);
        }
    }
}
