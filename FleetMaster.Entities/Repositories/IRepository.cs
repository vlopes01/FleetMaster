using System;
using System.Linq;
using System.Threading.Tasks;

namespace FleetMaster.Entities.Repositories
{
    public interface IRepository<T>
    {
        IQueryable<T> Get();
        
        T Get(Guid id);
             
        Task<T> Update(T objectToUpdate, Guid userId);
        
        Task<T> Add(T newObject, Guid userId);
        
        Task<bool> Delete(Guid id, Guid userId);
    }
}
