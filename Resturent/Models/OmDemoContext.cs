using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Resturent.Models
{
    public partial class OmDemoContext : DbContext
    {
        public OmDemoContext()
        {
        }

        public OmDemoContext(DbContextOptions<OmDemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Addon> Addons { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<PriceManagement> PriceManagements { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Variation> Variations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=localhost;User Id=sa;Password = reallyStrongPwd123; Database=OmDemo; Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Addon>(entity =>
            {
                entity.ToTable("Addon", "Config");

                entity.HasIndex(e => e.AddonName, "UQ__Addon__F83A0AD37576E5EB")
                    .IsUnique();

                entity.Property(e => e.AddonId).HasColumnName("AddonID");

                entity.Property(e => e.AddonName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EDate)
                    .HasColumnType("datetime")
                    .HasColumnName("eDate");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.MDate)
                    .HasColumnType("datetime")
                    .HasColumnName("mDate");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category", "Config");

                entity.HasIndex(e => e.CategoryName, "UQ__Category__8517B2E0A32F1396")
                    .IsUnique();

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EDate)
                    .HasColumnType("datetime")
                    .HasColumnName("eDate");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.MDate)
                    .HasColumnType("datetime")
                    .HasColumnName("mDate");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("Items", "Config");

                entity.HasIndex(e => e.ItemName, "UQ__Items__4E4373F782764F2A")
                    .IsUnique();

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Items__CategoryI__151B244E");
            });

            modelBuilder.Entity<PriceManagement>(entity =>
            {
                entity.HasKey(e => e.PriceId)
                    .HasName("Pk_PriceId");

                entity.ToTable("PriceManagement", "Config");

                entity.Property(e => e.EDate)
                    .HasColumnType("datetime")
                    .HasColumnName("eDate");

                entity.Property(e => e.ItemId).HasColumnName("itemId");

                entity.Property(e => e.MDate)
                    .HasColumnType("datetime")
                    .HasColumnName("mDate");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Table>(entity =>
            {
                entity.ToTable("Table", "Config");

                entity.HasIndex(e => e.TableName, "UQ__Table__733652EE50B91B96")
                    .IsUnique();

                entity.Property(e => e.TableId).HasColumnName("TableID");

                entity.Property(e => e.EDate)
                    .HasColumnType("datetime")
                    .HasColumnName("eDate");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsAdmin).HasDefaultValueSql("((0))");

                entity.Property(e => e.MDate)
                    .HasColumnType("datetime")
                    .HasColumnName("mDate");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.TableDesc).IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User", "Account");

                entity.HasIndex(e => e.UserName, "UQ__User__C9F284565D19066F")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.EDate)
                    .HasColumnType("datetime")
                    .HasColumnName("eDate");

                entity.Property(e => e.EmailId)
                    .IsUnicode(false)
                    .HasColumnName("EmailID");

                entity.Property(e => e.EmailPass).IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsAdmin).HasDefaultValueSql("((0))");

                entity.Property(e => e.MDate)
                    .HasColumnType("datetime")
                    .HasColumnName("mDate");

                entity.Property(e => e.MobileNo).HasMaxLength(100);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Variation>(entity =>
            {
                entity.ToTable("Variation", "Config");

                entity.HasIndex(e => e.VariationName, "UQ__Variatio__EF20A5A41FDA2D3E")
                    .IsUnique();

                entity.Property(e => e.VariationId).HasColumnName("VariationID");

                entity.Property(e => e.EDate)
                    .HasColumnType("datetime")
                    .HasColumnName("eDate");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.MDate)
                    .HasColumnType("datetime")
                    .HasColumnName("mDate");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.VariationName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
