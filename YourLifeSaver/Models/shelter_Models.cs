namespace YourLifeSaver.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class shelter_Models : DbContext
    {
        public shelter_Models()
            : base("name=shelter_Models")
        {
        }

        public virtual DbSet<shelter> shelters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<shelter>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<shelter>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<shelter>()
                .Property(e => e.Suburb)
                .IsUnicode(false);

            modelBuilder.Entity<shelter>()
                .Property(e => e.Longitude);

            modelBuilder.Entity<shelter>()
                .Property(e => e.Latitude);
        }
    }
}
