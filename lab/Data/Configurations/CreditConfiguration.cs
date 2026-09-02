using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using lab.Models;

namespace lab.Data.Configurations
{
    public class CreditConfiguration : IEntityTypeConfiguration<Credit>
    {
        public void Configure(EntityTypeBuilder<Credit> builder)
        {
            builder.ToTable("Credits");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Status)
                .IsRequired();

            builder.Property(c => c.AcademicYear)
                .IsRequired();

            builder.Property(c => c.Date)
                .IsRequired();

            builder.HasOne(c => c.Student)
                .WithMany(s => s.Credits)
                .HasForeignKey(c => c.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.Discipline)
                .WithMany(d => d.Credits)
                .HasForeignKey(c => c.DisciplineId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(c => c.StudentId);
            builder.HasIndex(c => c.DisciplineId);
            builder.HasIndex(c => c.AcademicYear);
        }
    }
}