//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IBMS.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_SupplierMaster_Log
    {
        public int AutoID { get; set; }
        public Nullable<int> ID { get; set; }
        public string Supplier { get; set; }
        public string Name { get; set; }
        public string GroupDescription { get; set; }
        public Nullable<bool> CheckTerms { get; set; }
        public string PostalAddress1 { get; set; }
        public string PostalAddress2 { get; set; }
        public string PostalAddress3 { get; set; }
        public string ContactPerson { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Fax { get; set; }
        public string E_Mail { get; set; }
        public Nullable<int> AreasID { get; set; }
        public string Area { get; set; }
        public Nullable<bool> ChargeTax { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyDescription { get; set; }
        public string AccountTerms { get; set; }
        public string SettlementTermDays { get; set; }
        public string PhysicalAddress1 { get; set; }
        public string PhysicalAddress2 { get; set; }
        public string PhysicalAddress3 { get; set; }
        public string DeliveryAdd1Line1 { get; set; }
        public string DeliveryAdd1Line2 { get; set; }
        public string DeliveryAdd1Line3 { get; set; }
        public string AgeingPeriod { get; set; }
        public Nullable<double> CreditLimit { get; set; }
        public string DefaultDeliveryAdd1 { get; set; }
        public string DefaultDeliveryAdd2 { get; set; }
        public string DefaultDeliveryAdd3 { get; set; }
        public string SettlementTerm { get; set; }
        public string Registration { get; set; }
        public string TaxNumber { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isEdit { get; set; }
        public Nullable<bool> PostStatus { get; set; }
        public string Mode { get; set; }
        public Nullable<System.DateTime> LogDate { get; set; }
    }
}
