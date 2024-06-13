using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlataformaCursos.Core.Entities;

namespace PlataformaCursos.Infra.Persistence.Mappings
{
    public class ModuleConfiguration : IEntityTypeConfiguration<Module>
    {
        public void Configure(EntityTypeBuilder<Module> builder)
        {
            builder.ToTable("Modules");
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            builder.Property(d => d.Description)
                    .IsRequired()
                    .HasMaxLength(500);

            builder.HasMany(d => d.Lessons)
                .WithOne(p => p.Module)
                .HasForeignKey(p => p.ModuleId);

            builder.HasOne(d => d.Course)
                .WithMany(p => p.Modules)
                .HasForeignKey(p => p.CourseId);

        }
    }
}
