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
    
    public partial class f_sp_Get_History_Result
    {
        public Nullable<System.DateTime> Date { get; set; }
        public string GDC { get; set; }
        public string TransType { get; set; }
        public string AccountNo_GLCode { get; set; }
        public string ContraAccount { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> TaxAmount { get; set; }
        public string CurrencyCode { get; set; }
    }
}
