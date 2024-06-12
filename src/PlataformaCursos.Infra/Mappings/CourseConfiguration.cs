using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlataformaCursos.Core.Entities;

namespace PlataformaCursos.Infra.Mappings
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses");
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            builder.Property(d => d.Description)
                    .IsRequired()
                    .HasMaxLength(500);
            builder.Property(d => d.Cover)
                    .IsRequired()
                    .HasMaxLength(200);
            builder.HasMany(d => d.Subscriptions)
                .WithMany(p => p.Courses)
                .UsingEntity(p => p.ToTable("CoursesSubscriptions"));
            builder.HasMany(d => d.Modules)
                .WithMany(p => p.Courses)
                .UsingEntity(p => p.ToTable("CoursesModules"));

        }
    }
}
