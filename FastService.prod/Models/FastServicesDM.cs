namespace FastService.prod.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FastServicesDM : DbContext
    {
        public FastServicesDM()
            : base("name=FastServicesCS")
        {
        }

        public virtual DbSet<LastWork> LastWorks { get; set; }
        public virtual DbSet<MainService> MainServices { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MainService>()
                .HasMany(e => e.Services)
                .WithOptional(e => e.MainService)
                .HasForeignKey(e => e.MainServicesId);
        }
    }
}
