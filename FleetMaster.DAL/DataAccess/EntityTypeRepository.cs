using System;
using System.Linq;
using System.Threading.Tasks;
using FleetMaster.DAL.DataAccess.Operations;
using FleetMaster.DAL.Model;
using FleetMaster.Entities;
using FleetMaster.Entities.Enums;
using FleetMaster.Entities.Repositories;

namespace FleetMaster.DAL.DataAccess
{
    public sealed class EntityTypeRepository : IEntityTypeRepository
    {
        private readonly FleetMasterDBContext _dbcontext;

        public EntityTypeRepository()
        {
            _dbcontext = new FleetMasterDBContext();
        }

        public IQueryable<EntityType> Get(EntityTypeGroup group)
        {
            return _dbcontext.EntityTypes.Where(t => t.Type == group && !t.IsDeleted);
        }

        public IQueryable<EntityType> Get()
        {
            return new GetDBEntityOperation<EntityType>(_dbcontext.EntityTypes).Execute();            
        }

        public EntityType Get(Guid id)
        {
            return new GetDBEntityOperation<EntityType>(_dbcontext.EntityTypes).Execute(id);  
        }

        public async Task<EntityType> Add(EntityType newObject, Guid userId)
        {
            var addOperation = new AddDBEntityOperation<EntityType>(_dbcontext.EntityTypes, _dbcontext);
            return await addOperation.Execute(newObject, userId);
        }

        public async Task<bool> Delete(Guid id, Guid userId)
        {                  
            var deleteOperation = new DeleteDBEntityOperation<EntityType>(_dbcontext.EntityTypes, _dbcontext);
            return await deleteOperation.Execute(id, userId);
        }

        public async Task<EntityType> Update(EntityType objectToUpdate, Guid userId)
        {
            var entity = await _dbcontext.EntityTypes.FindAsync(objectToUpdate.Id);
            if (entity == null)
            {
                return null;
            }

            entity.Name = objectToUpdate.Name;
            entity.Description = objectToUpdate.Description;
            entity.LastModifiedBy = userId;
            entity.LastModifiedOn = DateTime.Now;

            await _dbcontext.SaveChangesAsync();

            return entity;
        }
    }
}
