using System;

namespace FleetMaster.Entities.Requests.EntityTypes
{
    public class AddEntityRequest<T>
    {
        public T Data { get; set; }

        public Guid UserId { get; set; }
    }
}
