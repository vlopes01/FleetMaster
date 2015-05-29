using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using FleetMaster.DAL.Model;
using FleetMaster.Entities;

namespace FleetMaster.DAL.DataAccess.Operations
{
    public class DeleteDBEntityOperation<T> where T : BaseEntity
    {
        private readonly DbSet<T> _entitySet;
        private readonly FleetMasterDBContext _dbcontext;

        public DeleteDBEntityOperation(DbSet<T> entitySet, FleetMasterDBContext dbcontext)
        {
            _entitySet = entitySet;
            _dbcontext = dbcontext;
        }

        public async Task<bool> Execute(Guid id, Guid userId)
        {
            var result = false;

            var targetEntityType = _entitySet.FirstOrDefault(t => t.Id == id);

            if (targetEntityType != null && targetEntityType.Id == id)
            {
                targetEntityType.IsDeleted = true;
                targetEntityType.LastModifiedOn = DateTime.Now;
                targetEntityType.LastModifiedBy = userId;
                await _dbcontext.SaveChangesAsync();
                result = true;
            }

            return result;
        }
    }
}
