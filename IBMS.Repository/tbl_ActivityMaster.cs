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
    
    public partial class tbl_ActivityMaster
    {
        public int ID { get; set; }
        public string ActivityCode { get; set; }
        public string ActivityName { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<bool> isEdited { get; set; }
        public Nullable<System.DateTime> EditedDate { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<bool> PostedStatus { get; set; }
        public Nullable<System.DateTime> PostedDate { get; set; }
        public Nullable<System.DateTime> LogDate { get; set; }
    }
}
