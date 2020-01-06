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
    
    public partial class tblClientRenewelRequestHeader
    {
        public int ClientRequestHeaderID { get; set; }
        public Nullable<int> ClientID { get; set; }
        public Nullable<int> PartnerID { get; set; }
        public Nullable<System.DateTime> RequestedDate { get; set; }
        public Nullable<bool> IsQuotationCreated { get; set; }
        public Nullable<int> AgentID { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string FileNo { get; set; }
        public Nullable<System.DateTime> InspectionDate { get; set; }
        public string AdditionalNote { get; set; }
        public string Other { get; set; }
        public Nullable<int> TransactionID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> IntroducerID { get; set; }
        public Nullable<int> AccountHandlerID { get; set; }
        public Nullable<int> PremiumID { get; set; }
        public Nullable<System.DateTime> PolicyStart { get; set; }
        public Nullable<System.DateTime> PolicyEnd { get; set; }
        public Nullable<System.DateTime> FPolicyStart { get; set; }
        public Nullable<System.DateTime> FPolicyEnd { get; set; }
        public Nullable<int> DeductibleID { get; set; }
        public Nullable<int> PilotPremiumID { get; set; }
        public Nullable<System.DateTime> JoinDate { get; set; }
        public Nullable<double> Exclusions { get; set; }
        public string OptionalCovers { get; set; }
        public string Occupation { get; set; }
        public Nullable<int> FrequncyID { get; set; }
        public Nullable<int> CurrancyID { get; set; }
        public string MembershipID { get; set; }
        public Nullable<int> SchemeID { get; set; }
        public string Exclu { get; set; }
        public string GroupID { get; set; }
        public string Year { get; set; }
    }
}
