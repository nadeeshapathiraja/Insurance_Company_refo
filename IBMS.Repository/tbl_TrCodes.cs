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
    
    public partial class tbl_TrCodes
    {
        public int ID { get; set; }
        public string TransType { get; set; }
        public string AreaID { get; set; }
        public string AreaName { get; set; }
        public string SalesRepID { get; set; }
        public string SalesRepName { get; set; }
        public string CustGroupID { get; set; }
        public string CustGroupName { get; set; }
        public int TrCodeID { get; set; }
        public Nullable<bool> isSupplierTrns { get; set; }
        public string Type { get; set; }
        public string PaymentType { get; set; }
    }
}