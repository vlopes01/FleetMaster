using System.Data.Entity;
using FleetMaster.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FleetMaster.DAL.Model
{
    public class FleetMasterDBContext : DbContext 
    { 
        public DbSet<EntityType> EntityTypes { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<LoanDetails> LoansDetails { get; set; }

        public DbSet<PurchaseInformation> PurchasesInformation { get; set; }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Vendor> Vendors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }   
}
