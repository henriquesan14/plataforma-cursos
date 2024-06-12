using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlataformaCursos.Core.Entities;

namespace PlataformaCursos.Infra.Mappings
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
                .WithMany(p => p.Modules)
                .UsingEntity(p => p.ToTable("LessonModules"));

            builder.HasMany(d => d.Courses)
                .WithMany(p => p.Modules)
                .UsingEntity(p => p.ToTable("CoursesModules"));

        }
    }
}
