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
    
    public partial class tblFunctionAccess
    {
        public int FunctionAccessID { get; set; }
        public int AccessLevelTypeID { get; set; }
        public int FunctionID { get; set; }
    
        public virtual tblAccessLevelType tblAccessLevelType { get; set; }
        public virtual tblFunction tblFunction { get; set; }
    }
}
