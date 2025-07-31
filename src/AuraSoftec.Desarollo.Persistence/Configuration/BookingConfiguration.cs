using AuraSoftec.Desarollo.Domain.Entities.Booking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuraSoftec.Desarollo.Persistence.Configuration
{
    public class BookingConfiguration
    {
        public BookingConfiguration(EntityTypeBuilder<BookingEntity> entityBuilder) 
        {
            // Configuration logic for BookingEntity
            // This is a placeholder; actual implementation would involve setting up entity properties, keys, etc.
            // For example:
            entityBuilder.HasKey(b => b.BookingId);
            entityBuilder.Property(b => b.RegisterData).IsRequired();
            entityBuilder.Property(b => b.Code).IsRequired();
            entityBuilder.Property(b => b.Type).IsRequired();
            entityBuilder.Property(b => b.CustomerId).IsRequired();
            entityBuilder.Property(b => b.UserId).IsRequired();

            entityBuilder.HasOne(b => b.User)
                .WithMany(u => u.Bookings)
                .HasForeignKey(b => b.UserId);

            entityBuilder.HasOne(b => b.Customer)
                .WithMany(u => u.Bookings)
                .HasForeignKey(b => b.CustomerId);
        }
    }
}