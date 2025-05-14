using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFSampleOne.Entities;

public partial class ShopDbContext : DbContext
{
    public ShopDbContext()
    {
    }

    public ShopDbContext(DbContextOptions<ShopDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Manager> Managers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<VTopSell> VTopSells { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost;Database=ShopDb;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Cyrillic_General_CI_AS");

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC0786F2227D");

            entity.HasIndex(e => e.Email, "UNIQUE_Email").IsUnique();

            entity.HasIndex(e => e.Phone, "UNIQUE_Phone").IsUnique();

            entity.HasIndex(e => new { e.FirstName, e.LastName }, "UQ_Name").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.FirstName).HasMaxLength(300);
            entity.Property(e => e.LastName).HasMaxLength(300);
            entity.Property(e => e.Phone)
                .HasMaxLength(14)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<CustomerAddress>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.CustomerId, "UQ__Customer__A4AE64D903FCBAF4").IsUnique();

            entity.Property(e => e.City).HasMaxLength(400);
            entity.Property(e => e.Number).HasMaxLength(15);
            entity.Property(e => e.Street).HasMaxLength(500);

            entity.HasOne(d => d.Customer).WithOne()
                .HasForeignKey<CustomerAddress>(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CustomerA__Custo__5CD6CB2B");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Departme__3214EC07D58E4D29");

            entity.HasIndex(e => e.Name, "UQ__Departme__D9C1FA00B5F51B2F").IsUnique();

            entity.Property(e => e.Name)
                .HasMaxLength(900)
                .HasColumnName("NAME");

            entity.HasOne(d => d.HeadNavigation).WithMany(p => p.Departments)
                .HasForeignKey(d => d.Head)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__Department__Head__797309D9");
        });

        modelBuilder.Entity<Manager>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Managers__3214EC0742F322D0");

            entity.HasIndex(e => e.Phone, "UQ__Managers__5C7E359E4308FC7B").IsUnique();

            entity.Property(e => e.FirstName).HasMaxLength(300);
            entity.Property(e => e.LastName).HasMaxLength(300);
            entity.Property(e => e.Phone)
                .HasMaxLength(14)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Position).HasMaxLength(250);

            entity.HasMany(d => d.DepartmentsNavigation).WithMany(p => p.Managers)
                .UsingEntity<Dictionary<string, object>>(
                    "DepartmentsManager",
                    r => r.HasOne<Department>().WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Departmen__Depar__7D439ABD"),
                    l => l.HasOne<Manager>().WithMany()
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Departmen__Manag__7C4F7684"),
                    j =>
                    {
                        j.HasKey("ManagerId", "DepartmentId");
                        j.ToTable("DepartmentsManagers");
                    });
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Orders__3214EC072D869852");

            entity.Property(e => e.Date).HasColumnType("datetime");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Orders__Customer__6EF57B66");

            entity.HasOne(d => d.Manager).WithMany(p => p.Orders)
                .HasForeignKey(d => d.ManagerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__Orders__ManagerI__6FE99F9F");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.LineId }).HasName("PK_OrderId_LineId");

            entity.Property(e => e.LineId).HasDefaultValue((short)1);
            entity.Property(e => e.Qty).HasDefaultValue((short)1);

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__OrderDeta__Order__71D1E811");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__OrderDeta__Produ__73BA3083");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Products__3214EC078CA275E8");

            entity.HasIndex(e => e.Price, "NUQ_Price");

            entity.HasIndex(e => e.Name, "UQ_Name").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Name).HasMaxLength(700);
            entity.Property(e => e.Price).HasColumnType("money");
        });

        modelBuilder.Entity<VTopSell>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_TopSells");

            entity.Property(e => e.Name).HasMaxLength(700);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
