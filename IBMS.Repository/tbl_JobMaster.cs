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
    
    public partial class tbl_JobMaster
    {
        public int ID { get; set; }
        public string JobNo { get; set; }
        public string JobDescription { get; set; }
        public Nullable<System.DateTime> JobStartDate { get; set; }
        public Nullable<System.DateTime> JobEndDate { get; set; }
        public Nullable<System.DateTime> EstJobStartDate { get; set; }
        public Nullable<System.DateTime> EstJobEndDate { get; set; }
        public Nullable<int> JobStatusID { get; set; }
        public string JobStatusName { get; set; }
        public string ProjectManagerCode { get; set; }
        public string ProjectSupervisorCode { get; set; }
        public string ProjectTeamLeadCode { get; set; }
        public string ProjectEngineerCode { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public Nullable<bool> isEdited { get; set; }
        public Nullable<System.DateTime> EditedDate { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<bool> PostedStatus { get; set; }
        public Nullable<System.DateTime> PostedDate { get; set; }
        public Nullable<System.DateTime> LogDate { get; set; }
    }
}
