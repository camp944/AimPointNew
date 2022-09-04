using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AimPoint30.Entities.Model
{
    public partial class AimPointContext : DbContext
    {
        public AimPointContext()
        {
        }

        public AimPointContext(DbContextOptions<AimPointContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Day1> Day1s { get; set; } = null!;
        public virtual DbSet<Day7> Day7s { get; set; } = null!;
        public virtual DbSet<Hour3> Hour3s { get; set; } = null!;
        public virtual DbSet<Min30> Min30s { get; set; } = null!;
        public virtual DbSet<Min6> Min6s { get; set; } = null!;
        public virtual DbSet<SightDay1> SightDay1s { get; set; } = null!;
        public virtual DbSet<SightDay7> SightDay7s { get; set; } = null!;
        public virtual DbSet<SightHour3> SightHour3s { get; set; } = null!;
        public virtual DbSet<SightMin30> SightMin30s { get; set; } = null!;
        public virtual DbSet<SightMin6> SightMin6s { get; set; } = null!;
        public virtual DbSet<SightWeek4> SightWeek4s { get; set; } = null!;
        public virtual DbSet<Week4> Week4s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=pi;Username=postgres;Password=05172522");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Day1>(entity =>
            {
                entity.ToTable("Day_1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('\"Day1_Seq_Id\"'::regclass)");

                entity.Property(e => e.DateRequest)
                    .HasMaxLength(55)
                    .HasColumnName("date_request");

                entity.Property(e => e.Price)
                    .HasPrecision(10, 2)
                    .HasColumnName("price");
            });

            modelBuilder.Entity<Day7>(entity =>
            {
                entity.ToTable("Day_7");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('\"Day7_Seq_Id\"'::regclass)");

                entity.Property(e => e.DateRequest)
                    .HasMaxLength(55)
                    .HasColumnName("date_request");

                entity.Property(e => e.Price)
                    .HasPrecision(10, 2)
                    .HasColumnName("price");
            });

            modelBuilder.Entity<Hour3>(entity =>
            {
                entity.ToTable("Hour_3");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('\"Hour3_Seq_Id\"'::regclass)");

                entity.Property(e => e.DateRequest)
                    .HasMaxLength(55)
                    .HasColumnName("date_request");

                entity.Property(e => e.Price)
                    .HasPrecision(10, 2)
                    .HasColumnName("price");
            });

            modelBuilder.Entity<Min30>(entity =>
            {
                entity.ToTable("Min_30");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('\"Min30_Seq_Id\"'::regclass)");

                entity.Property(e => e.DateRequest)
                    .HasMaxLength(55)
                    .HasColumnName("date_request");

                entity.Property(e => e.Price)
                    .HasPrecision(10, 2)
                    .HasColumnName("price");
            });

            modelBuilder.Entity<Min6>(entity =>
            {
                entity.ToTable("Min_6");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('\"Min6_Seq_Id\"'::regclass)");

                entity.Property(e => e.DateRequest)
                    .HasMaxLength(55)
                    .HasColumnName("date_request");

                entity.Property(e => e.Price)
                    .HasPrecision(10, 2)
                    .HasColumnName("price");
            });

            modelBuilder.Entity<SightDay1>(entity =>
            {
                entity.ToTable("SightDay_1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('\"SightDay1_Seq_Id\"'::regclass)");

                entity.Property(e => e.DateEnd)
                    .HasMaxLength(55)
                    .HasColumnName("date_end");

                entity.Property(e => e.DateInit)
                    .HasMaxLength(55)
                    .HasColumnName("date_init");

                entity.Property(e => e.PriceEnd)
                    .HasPrecision(10, 2)
                    .HasColumnName("price_end");

                entity.Property(e => e.PriceInit)
                    .HasPrecision(10, 2)
                    .HasColumnName("price_init");

                entity.Property(e => e.PriceTarget)
                    .HasPrecision(10, 2)
                    .HasColumnName("price_target");
            });

            modelBuilder.Entity<SightDay7>(entity =>
            {
                entity.ToTable("SightDay_7");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('\"SightDay7_Seq_Id\"'::regclass)");

                entity.Property(e => e.DateEnd)
                    .HasMaxLength(55)
                    .HasColumnName("date_end");

                entity.Property(e => e.DateInit)
                    .HasMaxLength(55)
                    .HasColumnName("date_init");

                entity.Property(e => e.PriceEnd)
                    .HasPrecision(10, 2)
                    .HasColumnName("price_end");

                entity.Property(e => e.PriceInit)
                    .HasPrecision(10, 2)
                    .HasColumnName("price_init");

                entity.Property(e => e.PriceTarget)
                    .HasPrecision(10, 2)
                    .HasColumnName("price_target");
            });

            modelBuilder.Entity<SightHour3>(entity =>
            {
                entity.ToTable("SightHour_3");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('\"SightHour3_Seq_Id\"'::regclass)");

                entity.Property(e => e.DateEnd)
                    .HasMaxLength(55)
                    .HasColumnName("date_end");

                entity.Property(e => e.DateInit)
                    .HasMaxLength(55)
                    .HasColumnName("date_init");

                entity.Property(e => e.PriceEnd)
                    .HasPrecision(10, 2)
                    .HasColumnName("price_end");

                entity.Property(e => e.PriceInit)
                    .HasPrecision(10, 2)
                    .HasColumnName("price_init");

                entity.Property(e => e.PriceTarget)
                    .HasPrecision(10, 2)
                    .HasColumnName("price_target");
            });

            modelBuilder.Entity<SightMin30>(entity =>
            {
                entity.ToTable("SightMin_30");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('\"SightMin30_Seq_Id\"'::regclass)");

                entity.Property(e => e.DateEnd)
                    .HasMaxLength(55)
                    .HasColumnName("date_end");

                entity.Property(e => e.DateInit)
                    .HasMaxLength(55)
                    .HasColumnName("date_init");

                entity.Property(e => e.PriceEnd)
                    .HasPrecision(10, 2)
                    .HasColumnName("price_end");

                entity.Property(e => e.PriceInit)
                    .HasPrecision(10, 2)
                    .HasColumnName("price_init");

                entity.Property(e => e.PriceTarget)
                    .HasPrecision(10, 2)
                    .HasColumnName("price_target");
            });

            modelBuilder.Entity<SightMin6>(entity =>
            {
                entity.ToTable("SightMin_6");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('\"SightMin6_Seq_Id\"'::regclass)");

                entity.Property(e => e.DateEnd)
                    .HasMaxLength(55)
                    .HasColumnName("date_end");

                entity.Property(e => e.DateInit)
                    .HasMaxLength(55)
                    .HasColumnName("date_init");

                entity.Property(e => e.PriceEnd)
                    .HasPrecision(10, 2)
                    .HasColumnName("price_end");

                entity.Property(e => e.PriceInit)
                    .HasPrecision(10, 2)
                    .HasColumnName("price_init");

                entity.Property(e => e.PriceTarget)
                    .HasPrecision(10, 2)
                    .HasColumnName("price_target");
            });

            modelBuilder.Entity<SightWeek4>(entity =>
            {
                entity.ToTable("SightWeek_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('\"SightWeek4_Seq_Id\"'::regclass)");

                entity.Property(e => e.DateEnd)
                    .HasMaxLength(55)
                    .HasColumnName("date_end");

                entity.Property(e => e.DateInit)
                    .HasMaxLength(55)
                    .HasColumnName("date_init");

                entity.Property(e => e.PriceEnd)
                    .HasPrecision(10, 2)
                    .HasColumnName("price_end");

                entity.Property(e => e.PriceInit)
                    .HasPrecision(10, 2)
                    .HasColumnName("price_init");

                entity.Property(e => e.PriceTarget)
                    .HasPrecision(10, 2)
                    .HasColumnName("price_target");
            });

            modelBuilder.Entity<Week4>(entity =>
            {
                entity.ToTable("Week_4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('\"Week4_Seq_Id\"'::regclass)");

                entity.Property(e => e.DateRequest)
                    .HasMaxLength(55)
                    .HasColumnName("date_request");

                entity.Property(e => e.Price)
                    .HasPrecision(10, 2)
                    .HasColumnName("price");
            });

            modelBuilder.HasSequence("Day1_Seq_Id")
                .HasMin(0)
                .HasMax(2147483647);

            modelBuilder.HasSequence("Day7_Seq_Id")
                .HasMin(0)
                .HasMax(2147483647);

            modelBuilder.HasSequence("Hour3_Seq_Id")
                .HasMin(0)
                .HasMax(2147483647);

            modelBuilder.HasSequence("Min30_Seq_Id")
                .HasMin(0)
                .HasMax(2147483647);

            modelBuilder.HasSequence("Min6_Seq_Id")
                .HasMin(0)
                .HasMax(2147483647);

            modelBuilder.HasSequence("SightDay1_Seq_Id")
                .HasMin(0)
                .HasMax(2147483647);

            modelBuilder.HasSequence("SightDay7_Seq_Id")
                .HasMin(0)
                .HasMax(2147483647);

            modelBuilder.HasSequence("SightHour3_Seq_Id")
                .HasMin(0)
                .HasMax(2147483647);

            modelBuilder.HasSequence("SightMin30_Seq_Id")
                .HasMin(0)
                .HasMax(2147483647);

            modelBuilder.HasSequence("SightMin6_Seq_Id")
                .HasMin(0)
                .HasMax(2147483647);

            modelBuilder.HasSequence("SightWeek4_Seq_Id")
                .HasMin(0)
                .HasMax(2147483647);

            modelBuilder.HasSequence("Week4_Seq_Id")
                .HasMin(0)
                .HasMax(2147483647);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
