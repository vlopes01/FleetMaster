using System;

namespace FleetMaster.Entities.Requests
{
    public class BaseRequest
    {
        public Guid UserId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
