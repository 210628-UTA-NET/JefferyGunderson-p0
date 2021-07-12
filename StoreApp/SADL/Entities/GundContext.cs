using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace SADL.Entities
{
    public partial class GundContext : DbContext
    {
        
        public GundContext()
       {
       }
    public GundContext(DbContextOptions<GundContext> options)
        : base(options){}
    
    

    public virtual DbSet<SAModels.Customer> Customers { get; set; }
    public virtual DbSet<SAModels.StoreFront> StoreFronts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<SAModels.Customer>(entity =>
        {

            entity.ToTable("Customer");

            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CustomerEmail)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CustomerName)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<SAModels.StoreFront>(entity =>
        {

            entity.ToTable("storeFront");

            entity.Property(e => e.Address)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("store_address");

            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("store_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
