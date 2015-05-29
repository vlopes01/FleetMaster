using System.Data.Entity.Migrations;
using FleetMaster.DAL.Model;

namespace FleetMaster.DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<FleetMasterDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(FleetMasterDBContext context)
        {         
        }     
    }
}
