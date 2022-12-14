// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OdataPractice.Models;

#nullable disable

namespace OdataPractice.Data
{
    public partial class SalesDBContext : DbContext
    {
        public SalesDBContext()
        {
        }

        public SalesDBContext(DbContextOptions<SalesDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SalesMains> SalesMains { get; set; }
        public virtual DbSet<SalesSubs> SalesSubs { get; set; }
        public virtual DbSet<items> items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=DESKTOP-KNJBS4G\\SQLEXPRESS;Initial Catalog=SalesDB;User ID=sa;Password=1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<items>(entity =>
            {
                entity.Property(e => e.ItemName).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}