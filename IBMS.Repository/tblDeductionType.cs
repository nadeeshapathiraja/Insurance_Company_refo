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
    
    public partial class tblDeductionType
    {
        public int DeductionID { get; set; }
        public Nullable<decimal> DeductionRate { get; set; }
        public Nullable<decimal> DeductionAmount { get; set; }
        public string DeductionName { get; set; }
        public Nullable<int> BusinessUnit { get; set; }
    }
}
