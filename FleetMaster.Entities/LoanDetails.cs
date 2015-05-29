using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetMaster.Entities
{
    [DataContract]
    public class LoanDetails : BaseEntity
    {
        [DataMember]
        public string AgreementNumber { get; set; }

        [DataMember]
        public decimal MonthlyPayment { get; set; }

        [DataMember]
        public DateTimeOffset Start { get; set; }

        [DataMember]
        public DateTimeOffset End { get; set; }

        [DataMember]
        public decimal FinancedAmount { get; set; }

        [DataMember]
        public decimal InterestRate { get; set; }

        [DataMember]
        public decimal ResidualValue { get; set; }

        [DataMember]
        public Guid VendorId { get; set; }

        [ForeignKey("VendorId")]
        [DataMember]
        public virtual Vendor Vendor { get; set; }
    }
}
