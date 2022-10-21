using Microsoft.EntityFrameworkCore;
using Entitites.Concrete;
using Core.Entities.Concrete;
using Core.Utilities.Security.Hashing;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentACarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CarRental;Trusted_Connection=True");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Color>()
                .HasData(
                    new Color { ColorId = 1, ColorName = "White" },
                    new Color { ColorId = 2, ColorName = "Black" },
                    new Color { ColorId = 3, ColorName = "Orange" },
                    new Color { ColorId = 4, ColorName = "Red" },
                    new Color { ColorId = 5, ColorName = "Grey" }
                );
            modelBuilder.Entity<Brand>()
                .HasData(
                    new Brand { BrandId = 1, BrandName = "BMW" },
                    new Brand { BrandId = 2, BrandName = "Skoda" },
                    new Brand { BrandId = 3, BrandName = "Renault" },
                    new Brand { BrandId = 4, BrandName = "Volkswagen" }
                );

            modelBuilder.Entity<Car>()
                .HasData(
                    new Car { CarId=1,BrandId=2,ColorId=3,DailyPrice=400,Description="Fabia",ModelYear=2018,IsRentable=true,OwnerId=1},
                    new Car { CarId = 2, BrandId = 4, ColorId = 4, DailyPrice = 500, Description = "Tiguan", ModelYear = 2020, IsRentable = true, OwnerId = 1 },
                    new Car { CarId =3, BrandId = 3, ColorId = 1, DailyPrice = 300, Description = "Fluence", ModelYear = 2018, IsRentable = true, OwnerId = 1 },
                    new Car { CarId = 4, BrandId = 4, ColorId = 5, DailyPrice = 400, Description = "Golf", ModelYear = 2010, IsRentable = true, OwnerId = 1 },
                    new Car { CarId = 5, BrandId = 1, ColorId = 2, DailyPrice = 800, Description = "X7", ModelYear = 2018, IsRentable = true, OwnerId = 1 }

                );
            modelBuilder.Entity<CarImage>()
              .HasData(
                  new CarImage { Id = 1, CarId = 1, Date = DateTime.Now, ImagePath = "3cffc9b7-e111-4f2e-98bb-70f38a325232.jpg" },
                  new CarImage { Id = 2, CarId = 2, Date = DateTime.Now, ImagePath = "2e73e3d1-4add-4b63-8e2d-5fec0188ef5d.jpg" },
                  new CarImage { Id = 3, CarId = 3, Date = DateTime.Now, ImagePath = "35676709-24bd-4b90-90df-d737bf8d1159.jpg" },
                  new CarImage { Id = 4, CarId = 4, Date = DateTime.Now, ImagePath = "d6448427-0c49-4219-a8bf-625726cd1ad8.jpg" },
                  new CarImage { Id = 5, CarId = 5, Date = DateTime.Now, ImagePath = "c694f801-94c7-4217-9bde-f219e91825e7.jpg" }
              );

            byte[] passwordHash, passwordSalt;
            string password = "12345678";
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            modelBuilder.Entity<User>().HasData(
                    new User { UserId = 1, PasswordHash = passwordHash, PasswordSalt = passwordSalt, Status = true, Email = "akif@ozdemir.com", FirstName = "Mehmet Akif", LastName = "Özdemir" }
                );

            modelBuilder.Entity<OperationClaim>()
                .HasData(
                    new OperationClaim { Id = 1, Name = "user" }
                );
            modelBuilder.Entity<UserOperationClaim>()
                .HasData(
                    new UserOperationClaim { Id = 1, OperationClaimId = 1, UserId = 1 }
                );

            modelBuilder.Entity<Car>()
              .HasOne<Color>()
              .WithMany()
              .HasForeignKey(c => c.ColorId)
             .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Car>()
                .HasOne<Brand>()
                .WithMany()
                .HasForeignKey(c => c.BrandId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<CarImage>()
                .HasOne<Car>()
                .WithMany()
                .HasForeignKey(c => c.CarId);
            modelBuilder.Entity<Rental>()
                .HasOne<Car>()
                .WithMany()
                .HasForeignKey(r => r.CarId);
            modelBuilder.Entity<Rental>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(u => u.UserId);
            modelBuilder.Entity<Rental>()
                .Property(r => r.RentDate)
                .HasColumnType("date");
            modelBuilder.Entity<Rental>()
               .Property(r => r.ReturnDate)
               .HasColumnType("date");


        }
    }


}

