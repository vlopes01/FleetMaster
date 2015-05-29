using System.Linq;
using FleetMaster.Entities.Enums;

namespace FleetMaster.Entities.Repositories
{
    public interface IEntityTypeRepository : IRepository<EntityType>
    {
        IQueryable<EntityType> Get(EntityTypeGroup group);
    }
}
