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
    
    public partial class lecturer_counselor_master
    {
        public Nullable<int> ID { get; set; }
        public string PayeeID { get; set; }
        public string PayeeName { get; set; }
        public string PayeeType { get; set; }
        public int PBSSID { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string EMail { get; set; }
        public bool Active { get; set; }
        public string EnterUser { get; set; }
        public Nullable<System.DateTime> EnterDate { get; set; }
        public bool SaveStatus { get; set; }
        public string PostUser { get; set; }
        public Nullable<System.DateTime> PostDate { get; set; }
    }
}
