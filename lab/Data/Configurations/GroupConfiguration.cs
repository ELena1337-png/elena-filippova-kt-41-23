using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using lab.Models;

namespace lab.Data.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.ToTable("Groups");

            builder.HasKey(g => g.Id);

            builder.Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(g => g.AdmissionYear)
                .IsRequired();

            builder.Property(g => g.IsDeleted)
                .HasDefaultValue(false);

            // Group -> Specialty: many-to-one
            builder.HasOne(g => g.Specialty)
                .WithMany(s => s.Groups)
                .HasForeignKey(g => g.SpecialtyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(g => g.IsDeleted);
        }
    }
}