using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetMaster.Entities
{
    [DataContract]
    public class Vehicle : BaseEntity
    {
        [DataMember]
        public byte[] Image { get; set; }

        [DataMember]
        public int Year { get; set; }

        [DataMember]
        public string LicensePlate { get; set; }

        [DataMember]
        public string Color { get; set; }   

        [DataMember]
        public Guid TypeId { get; set; }

        [ForeignKey("TypeId")]
        [DataMember]
        public virtual EntityType Type { get; set; }

        [DataMember]
        public Guid StatusId { get; set; }

        [ForeignKey("StatusId")]
        [DataMember]
        public virtual EntityType Status { get; set; }

        [DataMember]
        public Guid MakeId { get; set; }

        [ForeignKey("MakeId")]
        [DataMember]
        public virtual EntityType Make { get; set; }

        [DataMember]
        public Guid ModelId { get; set; }

        [ForeignKey("ModelId")]
        [DataMember]
        public virtual EntityType Model { get; set; }
        
        [DataMember]
        public Guid FuelTypeId { get; set; }

        [ForeignKey("FuelTypeId")]
        [DataMember]
        public virtual EntityType FuelType { get; set; }

        [DataMember]
        public Guid FuelUnitId { get; set; }

        ////[InverseProperty("Id")]
        [ForeignKey("FuelUnitId")]
        [DataMember]
        public virtual EntityType FuelUnit { get; set; }

        [DataMember]
        public Guid? PurchaseInformationId { get; set; }

        [ForeignKey("PurchaseInformationId")]
        [DataMember]
        public virtual PurchaseInformation PurchaseInformation { get; set; }

        [DataMember]
        public Guid? LoanDetailsId { get; set; }

        [ForeignKey("LoanDetailsId")]
        [DataMember]
        public virtual LoanDetails LoanDetails { get; set; }

        [DataMember]
        public Guid? DefaultDriverId { get; set; }

        [ForeignKey("DefaultDriverId")]
        [DataMember]
        public virtual Person DefaultDriver { get; set; }
    }
}
