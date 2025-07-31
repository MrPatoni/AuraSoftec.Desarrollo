using AuraSoftec.Desarollo.Domain.Entities.Customer;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuraSoftec.Desarollo.Persistence.Configuration
{
    public class CustomerConfiguration
    {
        public CustomerConfiguration(EntityTypeBuilder<CustomerEntity> entityBuilder) 
        {
             //Configuration logic for CustomerEntity
             //This is a placeholder; actual implementation would involve setting up entity properties, keys, etc.
             //For example:
             entityBuilder.HasKey(c => c.CustomerId);
             entityBuilder.Property(c => c.FullName).IsRequired();
             entityBuilder.Property(c => c.DocumentNumber).IsRequired();

            entityBuilder.HasMany(u => u.Bookings)
                .WithOne(b => b.Customer)
                .HasForeignKey(b => b.CustomerId);
        }
    }
}
