using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetMaster.Entities
{
    [DataContract]
    public class Person : BaseEntity
    {
        [Key, ForeignKey("DefaultVehicle")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataMember]
        public new Guid Id { get; set; }

        [DataMember]
        public byte[] Image { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }
 
        [DataMember]
        public Guid LocationId { get; set; }

        [ForeignKey("LocationId")]
        [DataMember]
        public virtual EntityType Location { get; set; }

        [DataMember]
        public DateTimeOffset DateOfBirth { get; set; }

        [DataMember]
        public string PhoneMobile { get; set; }

        [DataMember]
        public string PhoneHome { get; set; }

        [DataMember]
        public string PhoneWork { get; set; }

        [DataMember]
        public Guid AddressId { get; set; }

        [ForeignKey("AddressId")]
        [DataMember]
        public virtual Address Address { get; set; }

        [DataMember]
        public string EmployeeNumber { get; set; }

        [DataMember]
        public string JobTitle { get; set; }

        [DataMember]
        public bool IsDriver { get; set; }

        [DataMember]
        public string LicenseNumber { get; set; }

        [DataMember]
        public string LicenseClass { get; set; }

        [DataMember]
        public string LicenseCountry { get; set; }

        [DataMember]
        public DateTimeOffset StartDate { get; set; }

        [DataMember]
        public DateTimeOffset LeaveDate { get; set; }
                
        [DataMember]
        public virtual Vehicle DefaultVehicle { get; set; }
    }
}
