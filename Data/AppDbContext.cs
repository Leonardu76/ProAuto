using Microsoft.EntityFrameworkCore;
using Proauto.Models;

namespace Proauto.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Associate> Associates { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Associate>().HasData(
                new Associate
                {
                    Id = 1,
                    Name = "João Silva",
                    CPF = "11111111111",
                    Phone = "5531988888888"

                },
                new Associate
                {
                    Id = 2,
                    Name = "Maria Souza",
                    CPF = "22222222222",
                    Phone = "5531999999999"
                }
            );

            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle
                {
                    Id = 1,
                    Plate = "ABC1234",
                    AssociateId = 1
                },
                new Vehicle
                {
                    Id = 2,
                    Plate = "XYZ9999",
                    AssociateId = 2
                }
            );

            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    Id = 1,
                    Street = "Rua A",
                    Number = "100",
                    City = "BH",
                    State = "MG",
                    ZipCode = "30100000",
                    AssociateId = 1
                },
                new Address
                {
                    Id = 2,
                    Street = "Rua B",
                    Number = "200",
                    City = "BH",
                    State = "MG",
                    ZipCode = "30200000",
                    AssociateId = 2
                }
            );
        }
    }
}