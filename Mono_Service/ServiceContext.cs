namespace Mono_Service
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ServiceContext : DbContext
    {
        public ServiceContext()
            : base("name=ServiceContext")
        {
        }

        public virtual DbSet<VehicleMake> VehicleMake { get; set; }
        public virtual DbSet<VehicleModel> VehicleModel { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleMake>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleMake>()
                .Property(e => e.Abrv)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleModel>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleModel>()
                .Property(e => e.Abrv)
                .IsUnicode(false);
        }
    }
}
