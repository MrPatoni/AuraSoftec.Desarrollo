using AuraSoftec.Desarollo.Domain.Entities.User;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuraSoftec.Desarollo.Persistence.Configuration
{
    public class UserConfiguration
    {
        public UserConfiguration(EntityTypeBuilder<UserEntity> entityBuilder)
        {
            entityBuilder.HasKey(u => u.UserId);
            entityBuilder.Property(u => u.FirstName).IsRequired();
            entityBuilder.Property(u => u.LastName).IsRequired();
            entityBuilder.Property(u => u.UserName).IsRequired();
            entityBuilder.Property(u => u.UserPassword).IsRequired();

            entityBuilder.HasMany(u => u.Bookings)
                .WithOne(b => b.User)
                .HasForeignKey(b => b.UserId);
        }
    }
}
