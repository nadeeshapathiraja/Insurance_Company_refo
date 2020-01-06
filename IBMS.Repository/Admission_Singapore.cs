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
    
    public partial class Admission_Singapore
    {
        public int SingaporeAdmissionId { get; set; }
        public string PatientName { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string ReferenceNo { get; set; }
        public string PassportNumber { get; set; }
        public string Scheme { get; set; }
        public Nullable<System.DateTime> InceptionDate { get; set; }
        public Nullable<decimal> Deductible { get; set; }
        public Nullable<decimal> DeductibleForTheYear { get; set; }
        public Nullable<decimal> Exclusions { get; set; }
        public string Hospital { get; set; }
        public Nullable<System.DateTime> InimatedDate { get; set; }
        public Nullable<System.DateTime> AdmissionDate { get; set; }
        public Nullable<System.DateTime> DischargeDate { get; set; }
        public string CaseNumber { get; set; }
        public string Illness { get; set; }
        public string ConsultantName { get; set; }
        public string InformedBy { get; set; }
        public Nullable<decimal> GOPAmount { get; set; }
        public Nullable<decimal> ExtendedGOP { get; set; }
        public Nullable<decimal> FinalAmount { get; set; }
        public Nullable<decimal> ConsultantFee { get; set; }
        public Nullable<decimal> ReferalFee { get; set; }
        public Nullable<System.DateTime> ReferalFeeReceivedDate { get; set; }
        public Nullable<System.DateTime> FinalBillReceivedDate { get; set; }
        public string ReferalFeeReceivedTTNo { get; set; }
        public Nullable<decimal> PaymentGivenToAccount { get; set; }
        public string Remark { get; set; }
        public string CMAInvoiceNumber { get; set; }
        public Nullable<int> MemberID { get; set; }
        public Nullable<int> DependantID { get; set; }
        public Nullable<decimal> FinalBill { get; set; }
        public Nullable<System.DateTime> ExtendedGOPDate { get; set; }
        public string CountryID { get; set; }
    }
}
