using AuraSoftec.Desarollo.Application.Interfaces;
using AuraSoftec.Desarollo.Domain.Entities.Booking;
using AuraSoftec.Desarollo.Domain.Entities.Customer;
using AuraSoftec.Desarollo.Domain.Entities.User;
using AuraSoftec.Desarollo.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuraSoftec.Desarollo.Persistence.DataBase
{
    //Servico de base de datos que hereda de DbContext
    public class DataBaseService : DbContext, IDataBaseService
    {
        // Permite ingresar o recibir la conexion a la base de datos
        public DataBaseService(DbContextOptions options) : base(options)
        {

        }
        // invocar las tablas a traves de las entidades
        public DbSet<UserEntity> User { get; set; }
        public DbSet<CustomerEntity> Customer { get; set; }
        public DbSet<BookingEntity> Booking { get; set; }

        public async Task<bool> SaveAsync()
        {
            // Guarda los cambios en la base de datos
            return await SaveChangesAsync() > 0;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuracion de las entidades
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataBaseService).Assembly);
            base.OnModelCreating(modelBuilder);
            EntityConfiguration(modelBuilder);
        }

        private void EntityConfiguration(ModelBuilder modelBuilder)
        {
            // Aqui se pueden agregar configuraciones adicionales de las entidades si es necesario
            // Por ejemplo, se pueden configurar relaciones, restricciones, etc.
            new UserConfiguration(modelBuilder.Entity<UserEntity>());
            new CustomerConfiguration(modelBuilder.Entity<CustomerEntity>());
            new BookingConfiguration(modelBuilder.Entity<BookingEntity>());
        }
    }
}