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
    
    public partial class tblBankTransactionDetail
    {
        public int BankDetailID { get; set; }
        public Nullable<int> BankID { get; set; }
        public string DraftNo { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> ClientID { get; set; }
        public Nullable<int> PolicyInfoRecID { get; set; }
        public Nullable<int> PaymentID { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public Nullable<int> AgentID { get; set; }
        public Nullable<decimal> AgentAmount { get; set; }
        public Nullable<decimal> IBSAmount { get; set; }
        public string AdditionalInfo { get; set; }
        public Nullable<int> currencyType { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public int IsInvoiceTrf { get; set; }
        public int IsAgentTrf { get; set; }
        public string BankName { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public string FrequncyID { get; set; }
        public string FrequncyDID { get; set; }
    
        public virtual tblClient tblClient { get; set; }
    }
}
