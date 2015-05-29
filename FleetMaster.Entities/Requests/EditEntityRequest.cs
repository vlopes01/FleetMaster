using System;

namespace FleetMaster.Entities.Requests.EntityTypes
{
    public class EditEntityRequest<T> 
    {
        public T Data { get; set; }

        public Guid UserId { get; set; }
    }
}
