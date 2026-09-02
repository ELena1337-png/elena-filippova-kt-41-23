using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using lab.Models;

namespace lab.Data.Configurations
{
    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.ToTable("Grades");

            builder.HasKey(g => g.Id);

            builder.Property(g => g.Value)
                .IsRequired();

            builder.Property(g => g.AcademicYear)
                .IsRequired();

            builder.Property(g => g.Date)
                .IsRequired();

            // Grade -> Student: many-to-one
            builder.HasOne(g => g.Student)
                .WithMany(s => s.Grades)
                .HasForeignKey(g => g.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            // Grade -> Discipline: many-to-one
            builder.HasOne(g => g.Discipline)
                .WithMany(d => d.Grades)
                .HasForeignKey(g => g.DisciplineId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(g => g.StudentId);
            builder.HasIndex(g => g.DisciplineId);
            builder.HasIndex(g => g.AcademicYear);
        }
    }
}