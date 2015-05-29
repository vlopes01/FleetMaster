using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetMaster.Entities
{
    [DataContract]
    public class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }

        [DataMember]
        public Guid CreatedBy { get; set; }

        [DataMember]
        public DateTimeOffset CreatedOn { get; set; }

        [DataMember]
        public Guid LastModifiedBy { get; set; }

        [DataMember]
        public DateTimeOffset LastModifiedOn { get; set; }  
    }
}
