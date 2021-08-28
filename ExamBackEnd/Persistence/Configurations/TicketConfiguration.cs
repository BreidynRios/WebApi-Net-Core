using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable("Ticket");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("Id");

            builder.Property(e => e.UserId)
                .HasColumnName("UserId");

            builder.Property(e => e.CreatedDate)
                .HasColumnName("CreatedDate")
                .HasColumnType("datetime");

            builder.Property(e => e.UpdatedDate)
                .HasColumnName("UpdatedDate")
                .HasColumnType("datetime");

            builder.Property(e => e.Status)
                .HasColumnName("Status");

            builder.HasOne(d => d.User)
                .WithMany(p => p.Tickets)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ticket_User");
        }
    }
}
