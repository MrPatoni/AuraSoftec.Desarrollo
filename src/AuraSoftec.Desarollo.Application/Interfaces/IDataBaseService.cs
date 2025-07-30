using AuraSoftec.Desarollo.Domain.Entities.Booking;
using AuraSoftec.Desarollo.Domain.Entities.Customer;
using AuraSoftec.Desarollo.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuraSoftec.Desarollo.Application.Interfaces
{
    public interface IDataBaseService
    {
        DbSet<UserEntity> User { get; set; }
        DbSet<CustomerEntity> Customer { get; set; }
        DbSet<BookingEntity> Booking { get; set; }
        Task<bool> SaveAsync();
    }
}
