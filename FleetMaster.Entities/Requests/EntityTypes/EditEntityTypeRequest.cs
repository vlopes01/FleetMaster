using System;

namespace FleetMaster.Entities.Requests.EntityTypes
{
    public class EditEntityTypeRequest : BaseRequest
    {
        public Guid Id { get; set; }
    }
}
