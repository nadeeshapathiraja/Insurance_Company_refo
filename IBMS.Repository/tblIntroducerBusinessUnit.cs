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
    
    public partial class tblIntroducerBusinessUnit
    {
        public int IntroducerBusinessUnitID { get; set; }
        public int IntroducerID { get; set; }
        public int BUID { get; set; }
    
        public virtual tblBussinessUnit tblBussinessUnit { get; set; }
        public virtual tblIntroducer tblIntroducer { get; set; }
    }
}
