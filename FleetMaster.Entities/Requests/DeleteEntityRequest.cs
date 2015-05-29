using System;

namespace FleetMaster.Entities.Requests.EntityTypes
{
    public class DeleteEntityRequest 
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
    }
}
