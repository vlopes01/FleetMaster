using System.Runtime.Serialization;

namespace FleetMaster.Entities
{
    [DataContract]
    public class Vendor : BaseEntity
    {
        [DataMember]
        public string Name { get; set; }
    }
}
