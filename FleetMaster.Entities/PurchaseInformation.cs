using System;
using System.Runtime.Serialization;

namespace FleetMaster.Entities
{
    [DataContract]
    public class PurchaseInformation : BaseEntity
    {
        [DataMember]
        public decimal Price { get; set; }
        
        [DataMember]
        public DateTimeOffset Date { get; set; }
        
        [DataMember]
        public int OdometerInformation { get; set; }
        
        [DataMember]
        public DateTimeOffset WarrantyExpireDate { get; set; }

        [DataMember]
        public int WarrantyExpireMeter { get; set; }
    }
}
