using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BackendHotel.DAL.Entities
{
    public partial class HotelDBContext : DbContext
    {
        public HotelDBContext()
        {
        }

        public HotelDBContext(DbContextOptions<HotelDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<BookingRoomType> BookingRoomTypes { get; set; }
        public virtual DbSet<BookingService> BookingServices { get; set; }
        public virtual DbSet<Deal> Deals { get; set; }
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<RoomTypeFeature> RoomTypeFeatures { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=HotelDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasKey(e => e.IdBooking)
                    .HasName("PK__Booking__E28F86F0BD44C256");

                entity.ToTable("Booking");

                entity.Property(e => e.IdBooking).HasColumnName("id_booking");

                entity.Property(e => e.BookingEndDate)
                    .HasColumnType("date")
                    .HasColumnName("booking_end_date");

                entity.Property(e => e.BookingStartDate)
                    .HasColumnType("date")
                    .HasColumnName("booking_start_date");

                entity.Property(e => e.BookingStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("booking_status");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.TotalPrice)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("total_price");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Booking__id_user__33D4B598");
            });

            modelBuilder.Entity<BookingRoomType>(entity =>
            {
                entity.HasKey(e => new { e.IdBooking, e.IdRoomType })
                    .HasName("PK__Booking___377A7C32FB089DD8");

                entity.ToTable("BookingRoomType");

                entity.Property(e => e.IdBooking).HasColumnName("id_booking");

                entity.Property(e => e.IdRoomType).HasColumnName("id_room_type");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.IdDeal).HasColumnName("id_deal");

                entity.Property(e => e.NumberOfRooms).HasColumnName("number_of_rooms");

                entity.HasOne(d => d.IdBookingNavigation)
                    .WithMany(p => p.BookingRoomTypes)
                    .HasForeignKey(d => d.IdBooking)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Booking_R__id_bo__5DCAEF64");

                entity.HasOne(d => d.IdDealNavigation)
                    .WithMany(p => p.BookingRoomTypes)
                    .HasForeignKey(d => d.IdDeal)
                    .HasConstraintName("FK__Booking_R__id_de__5FB337D6");

                entity.HasOne(d => d.IdRoomTypeNavigation)
                    .WithMany(p => p.BookingRoomTypes)
                    .HasForeignKey(d => d.IdRoomType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Booking_R__id_ro__5EBF139D");
            });

            modelBuilder.Entity<BookingService>(entity =>
            {
                entity.HasKey(e => new { e.IdBooking, e.IdService })
                    .HasName("PK__Booking___7F897DAA74CE77E0");

                entity.ToTable("BookingService");

                entity.Property(e => e.IdBooking).HasColumnName("id_booking");

                entity.Property(e => e.IdService).HasColumnName("id_service");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.HasOne(d => d.IdBookingNavigation)
                    .WithMany(p => p.BookingServices)
                    .HasForeignKey(d => d.IdBooking)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Booking_S__id_bo__36B12243");

                entity.HasOne(d => d.IdServiceNavigation)
                    .WithMany(p => p.BookingServices)
                    .HasForeignKey(d => d.IdService)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Booking_S__id_se__37A5467C");
            });

            modelBuilder.Entity<Deal>(entity =>
            {
                entity.HasKey(e => e.IdDeal)
                    .HasName("PK__Deal__900E0D7AD3C88470");

                entity.ToTable("Deal");

                entity.Property(e => e.IdDeal).HasColumnName("id_deal");

                entity.Property(e => e.DealEndDate)
                    .HasColumnType("date")
                    .HasColumnName("deal_end_date");

                entity.Property(e => e.DealStartDate)
                    .HasColumnType("date")
                    .HasColumnName("deal_start_date");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Discount).HasColumnName("discount");
            });

            modelBuilder.Entity<Feature>(entity =>
            {
                entity.HasKey(e => e.IdFeature)
                    .HasName("PK__Feature__03AA6FED7C54C49C");

                entity.ToTable("Feature");

                entity.Property(e => e.IdFeature).HasColumnName("id_feature");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.FeatureName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("feature_name");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.HasKey(e => e.IdImage)
                    .HasName("PK__Image__C28C621CDB32C04C");

                entity.ToTable("Image");

                entity.Property(e => e.IdImage).HasColumnName("id_image");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.IdRoomType).HasColumnName("id_room_type");

                entity.Property(e => e.ImagePath)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("image_path");

                entity.HasOne(d => d.IdRoomTypeNavigation)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.IdRoomType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Image__id_room_t__286302EC");
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity.HasKey(e => e.IdPrice)
                    .HasName("PK__Price__D8A23E8395E1FF3A");

                entity.ToTable("Price");

                entity.Property(e => e.IdPrice).HasColumnName("id_price");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.IdRoomType).HasColumnName("id_room_type");

                entity.Property(e => e.PriceEndDate)
                    .HasColumnType("date")
                    .HasColumnName("price_end_date");

                entity.Property(e => e.PriceStartDate)
                    .HasColumnType("date")
                    .HasColumnName("price_start_date");

                entity.Property(e => e.PriceValue)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("price_value");

                entity.HasOne(d => d.IdRoomTypeNavigation)
                    .WithMany(p => p.Prices)
                    .HasForeignKey(d => d.IdRoomType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Price__id_room_t__2B3F6F97");
            });

            modelBuilder.Entity<RoomType>(entity =>
            {
                entity.HasKey(e => e.IdRoomType)
                    .HasName("PK__Room_Typ__5F5FAC2CB9AD15B3");

                entity.ToTable("RoomType");

                entity.Property(e => e.IdRoomType).HasColumnName("id_room_type");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.NumberOfRooms).HasColumnName("number_of_rooms");

                entity.Property(e => e.RoomTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("room_type_name");
            });

            modelBuilder.Entity<RoomTypeFeature>(entity =>
            {
                entity.HasKey(e => new { e.IdRoomType, e.IdFeature })
                    .HasName("PK__Room_Typ__9F650AD2A50299B4");

                entity.ToTable("RoomTypeFeature");

                entity.Property(e => e.IdRoomType).HasColumnName("id_room_type");

                entity.Property(e => e.IdFeature).HasColumnName("id_feature");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.HasOne(d => d.IdFeatureNavigation)
                    .WithMany(p => p.RoomTypeFeatures)
                    .HasForeignKey(d => d.IdFeature)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Room_Type__id_fe__3B75D760");

                entity.HasOne(d => d.IdRoomTypeNavigation)
                    .WithMany(p => p.RoomTypeFeatures)
                    .HasForeignKey(d => d.IdRoomType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Room_Type__id_ro__3A81B327");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasKey(e => e.IdService)
                    .HasName("PK__Service__D06FB5A88B4B9393");

                entity.ToTable("Service");

                entity.Property(e => e.IdService).HasColumnName("id_service");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.ServiceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("service_name");

                entity.Property(e => e.ServicePrice)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("service_price");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK__User__D2D14637C61464C4");

                entity.ToTable("User");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.UserType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_type");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
