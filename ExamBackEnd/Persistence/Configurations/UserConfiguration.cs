using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("Id");

            builder.Property(e => e.Name)
                .HasColumnName("Name")
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.LastName)
                .HasColumnName("LastName")
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Email)
                .HasColumnName("Email")
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.CreatedDate)
                .HasColumnName("CreatedDate")
                .HasColumnType("datetime");

            builder.Property(e => e.UpdatedDate)
                .HasColumnName("UpdatedDate")
                .HasColumnType("datetime");

            builder.Property(e => e.Status)
                .HasColumnName("Status");
        }
    }
}
