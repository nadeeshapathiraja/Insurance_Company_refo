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
    
    public partial class tblAgent
    {
        public int AgentID { get; set; }
        public string AgentName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public Nullable<double> RateValue { get; set; }
        public string AgentCode { get; set; }
        public string AgentType { get; set; }
        public string AgentNIC { get; set; }
        public string AgentBRNo { get; set; }
        public Nullable<int> CompID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string Account { get; set; }
    
        public virtual tblCompany tblCompany { get; set; }
        public virtual tblUser tblUser { get; set; }
        public virtual tblUser tblUser1 { get; set; }
    }
}