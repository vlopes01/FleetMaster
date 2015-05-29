using System.Runtime.Serialization;
using FleetMaster.Entities.Enums;

namespace FleetMaster.Entities
{
    [DataContract]
    public class EntityType : BaseEntity
    {
        public EntityType()
        { 
        }

        public EntityType(EntityTypeGroup type, string name, string description)
        {
            Type = type;
            Name = name;
            Description = description;
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        public EntityTypeGroup Type { get; set; }
    }
}
