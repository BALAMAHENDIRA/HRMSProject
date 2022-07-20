using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HRMSProject.Repository.Models
{
    public partial class carRentalContext : DbContext
    {
        public carRentalContext()
        {
        }

        public carRentalContext(DbContextOptions<carRentalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Rental> Rentals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB;Initial Catalog=carRental; Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(e => e.Vin)
                    .HasName("PK__Cars__C5DF234D70327EE5");

                entity.Property(e => e.Vin).HasColumnName("VIN");

                entity.Property(e => e.Brand)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CarSeats).HasColumnName("Car_Seats");

                entity.Property(e => e.CarType)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("Car_type");

                entity.Property(e => e.CategoryId).HasColumnName("Category_ID");

                entity.Property(e => e.Color)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseDate)
                    .HasColumnType("date")
                    .HasColumnName("Purchase_Date");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("PK__category__DD5DDDBD6FF80BAD");

                entity.ToTable("category");

                entity.Property(e => e.CatId).HasColumnName("cat_id");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category_name");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Mobile_phone");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location");

                entity.Property(e => e.LocationId).HasColumnName("Location_ID");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StreetNumber).HasColumnName("Street_Number");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("logs");

                entity.Property(e => e.Activity)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("activity");

                entity.Property(e => e.ActivityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("activity_date");
            });

            modelBuilder.Entity<Rental>(entity =>
            {
                entity.HasKey(e => e.ReservationNumber)
                    .HasName("PK__Rental__3E712F1C23DF59A7");

                entity.ToTable("Rental");

                entity.Property(e => e.ReservationNumber).HasColumnName("Reservation_Number");

                entity.Property(e => e.Amount)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.PickUpDate)
                    .HasColumnType("date")
                    .HasColumnName("Pick_up_date");

                entity.Property(e => e.PickUpLocation).HasColumnName("Pick_up_location");

                entity.Property(e => e.ReturnDate)
                    .HasColumnType("date")
                    .HasColumnName("Return_date");

                entity.Property(e => e.ReturnLocation).HasColumnName("Return_location");

                entity.Property(e => e.Vin).HasColumnName("VIN");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Rentals)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Rental__Customer__32E0915F");

                entity.HasOne(d => d.PickUpLocationNavigation)
                    .WithMany(p => p.RentalPickUpLocationNavigations)
                    .HasForeignKey(d => d.PickUpLocation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Rental__Pick_up___33D4B598");

                entity.HasOne(d => d.ReturnLocationNavigation)
                    .WithMany(p => p.RentalReturnLocationNavigations)
                    .HasForeignKey(d => d.ReturnLocation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Rental__Return_l__34C8D9D1");

                entity.HasOne(d => d.VinNavigation)
                    .WithMany(p => p.Rentals)
                    .HasForeignKey(d => d.Vin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Rental__VIN__31EC6D26");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
