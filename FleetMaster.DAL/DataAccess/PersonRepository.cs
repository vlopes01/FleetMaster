using System;
using System.Linq;
using System.Threading.Tasks;
using FleetMaster.DAL.DataAccess.Operations;
using FleetMaster.DAL.Model;
using FleetMaster.Entities;
using FleetMaster.Entities.Repositories;

namespace FleetMaster.DAL.DataAccess
{
    public class PersonRepository : IPersonRepository
    {
        private readonly FleetMasterDBContext _dbcontext;

        public PersonRepository()
        {
            _dbcontext = new FleetMasterDBContext();
        }

        public IQueryable<Person> Get()
        {
            return _dbcontext.Persons.Where(t => !t.IsDeleted);
        }

        public Person Get(Guid id)
        {
            return _dbcontext.Persons.FirstOrDefault(t => t.Id == id);
        }

        public Task<Person> Update(Person objectToUpdate, Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<Person> Add(Person newObject, Guid userId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid id, Guid userId)
        {
            var deleteOperation = new DeleteDBEntityOperation<Person>(_dbcontext.Persons, _dbcontext);
            return await deleteOperation.Execute(id, userId);
        }
    }
}
