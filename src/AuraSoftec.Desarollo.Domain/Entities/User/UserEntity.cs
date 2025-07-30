using AuraSoftec.Desarollo.Domain.Entities.Booking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuraSoftec.Desarollo.Domain.Entities.User
{
   public class UserEntity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public ICollection<BookingEntity> Bookings { get; set; }
    }
}
