//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuildInspect.Models.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class chklst_trn_detail
    {
        public int CLTDID { get; set; }
        public Nullable<int> CLTMID { get; set; }
        public Nullable<int> ChkListID { get; set; }
        public string IsDone { get; set; }
        public Nullable<System.DateTime> DateDone { get; set; }
        public string Remarks { get; set; }
    
        public virtual chklst_trn_master chklst_trn_master { get; set; }
    }
}