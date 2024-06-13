using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlataformaCursos.Core.Entities;

namespace PlataformaCursos.Infra.Persistence.Mappings
{
    public class UserLessonCompletedConfiguration : IEntityTypeConfiguration<UserLessonCompleted>
    {
        public void Configure(EntityTypeBuilder<UserLessonCompleted> builder)
        {
            builder.ToTable("UserLessonsCompleted");
            builder.HasKey(d => d.Id);
            builder.Property(d => d.EndDate)
                    .IsRequired();
            builder.Property(d => d.Grade)
                    .IsRequired();
            builder.Property(d => d.EndDate)
                    .IsRequired();

            builder.HasOne(d => d.User)
                .WithMany(p => p.UserLessonsCompleted)
                .HasForeignKey(p => p.LessonId);
            builder.HasOne(d => d.Lesson)
                .WithMany(p => p.UserLessonsCompleted)
                .HasForeignKey(p => p.LessonId);
        }
    }
}
