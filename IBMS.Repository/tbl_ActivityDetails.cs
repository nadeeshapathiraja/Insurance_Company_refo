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
    
    public partial class tbl_ActivityDetails
    {
        public int ID { get; set; }
        public int Index_JobSchActuals { get; set; }
        public string JobNo { get; set; }
        public string ActivityID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
        public Nullable<int> ActivityStatus { get; set; }
        public string TechinianID { get; set; }
        public Nullable<decimal> CompletionPcn { get; set; }
        public Nullable<bool> PBSSPostedStatus { get; set; }
        public Nullable<System.DateTime> PBSSPostedDate { get; set; }
        public Nullable<bool> UTEPostedStatus { get; set; }
        public Nullable<System.DateTime> UTEPostedDate { get; set; }
        public Nullable<bool> IsPBSSEdited { get; set; }
        public Nullable<System.DateTime> PBSSEditedDate { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<System.DateTime> LogDate { get; set; }
        public string LastEditBy { get; set; }
    }
}
