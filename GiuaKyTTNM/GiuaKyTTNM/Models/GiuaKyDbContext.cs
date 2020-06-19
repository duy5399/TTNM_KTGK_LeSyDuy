namespace GiuaKyTTNM.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GiuaKyDbContext : DbContext
    {
        public GiuaKyDbContext()
            : base("name=GiuaKyDbContext")
        {
        }

        public virtual DbSet<CATEGORY> CATEGORies { get; set; }
        public virtual DbSet<PRODUCT> PRODUCTs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CATEGORY>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CATEGORY>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<CATEGORY>()
                .HasMany(e => e.PRODUCTs)
                .WithRequired(e => e.CATEGORY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.Note)
                .IsUnicode(false);
        }
    }
}
