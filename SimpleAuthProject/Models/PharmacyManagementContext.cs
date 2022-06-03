using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace pharmacyManagementWebApiservice.Models
{
    public partial class PharmacyManagementContext : DbContext
    {
        public PharmacyManagementContext()
        {
        }

        public PharmacyManagementContext(DbContextOptions<PharmacyManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DrugDetail> DrugDetails { get; set; }
        public virtual DbSet<NewTab> NewTabs { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<SupplierDetail> SupplierDetails { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-AGNSPA8J\\SQLEXPRESS;Database=PharmacyManagement;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DrugDetail>(entity =>
            {
                entity.HasKey(e => e.DrugId)
                    .HasName("PK__DrugDeta__908D6616211679A1");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("datetime")
                    .HasColumnName("created_by")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DrugName).HasMaxLength(50);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ModifedBy)
                    .HasColumnType("datetime")
                    .HasColumnName("modifed_by");

                entity.Property(e => e.ModifedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifed_date");

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.DrugDetails)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK__DrugDetai__Suppl__276EDEB3");
            });

            modelBuilder.Entity<NewTab>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("New_tab");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .HasColumnName("name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.UserId })
                    .HasName("PK__Orders__12E8D70B5FB09614");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("date")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("created_date");

                entity.Property(e => e.ModifedBy)
                    .HasColumnType("date")
                    .HasColumnName("modifed_by");

                entity.Property(e => e.ModifedDate)
                    .HasColumnType("date")
                    .HasColumnName("modifed_date");

                entity.HasOne(d => d.OrderNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__OrderId__5BE2A6F2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__UserId__5CD6CB2B");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__OrderDet__C3905BCFE5141DE2");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("datetime")
                    .HasColumnName("created_by")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifedBy)
                    .HasColumnType("datetime")
                    .HasColumnName("modifed_by");

                entity.Property(e => e.ModifedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifed_date");

                entity.Property(e => e.OrderPickedUp).HasColumnType("date");

                entity.Property(e => e.OrderPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.DrugId)
                    .HasConstraintName("FK__OrderDeta__DrugI__2A4B4B5E");
            });

            modelBuilder.Entity<SupplierDetail>(entity =>
            {
                entity.HasKey(e => e.SupplierId)
                    .HasName("PK__Supplier__4BE666B42B1BE743");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("datetime")
                    .HasColumnName("created_by")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifedBy)
                    .HasColumnType("datetime")
                    .HasColumnName("modifed_by");

                entity.Property(e => e.ModifedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifed_date");

                entity.Property(e => e.SupplierContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierEmail).HasMaxLength(255);

                entity.Property(e => e.SupplierName).HasMaxLength(50);
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserDeta__1788CC4C2C16E326");

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("datetime")
                    .HasColumnName("created_by")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.ModifedBy)
                    .HasColumnType("datetime")
                    .HasColumnName("modifed_by");

                entity.Property(e => e.ModifedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifed_date");

                entity.Property(e => e.UserAddress).HasMaxLength(255);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.UserPassword).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
