﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlataformaCursos.Core.Entities;

namespace PlataformaCursos.Infra.Mappings
{
    public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.ToTable("Lessons");
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            builder.Property(d => d.Description)
                    .IsRequired()
                    .HasMaxLength(500);
            builder.Property(d => d.LinkVideo)
                    .IsRequired()
                    .HasMaxLength(300);
            builder.Property(d => d.Duration)
                    .IsRequired();
            builder.HasMany(d => d.UserLessonsCompleted)
                .WithOne(p => p.Lesson)
                .HasForeignKey(p => p.LessonId);
            builder.HasMany(d => d.Modules)
                .WithMany(p => p.Lessons)
                .UsingEntity(p => p.ToTable("LessonModules"));
        }
    }
}
