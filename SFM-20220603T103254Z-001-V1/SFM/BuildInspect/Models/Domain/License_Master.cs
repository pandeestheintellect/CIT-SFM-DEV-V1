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
    
    public partial class License_Master
    {
        public int LicenseID { get; set; }
        public int CompanyID { get; set; }
        public Nullable<System.DateTime> License_Start_Date { get; set; }
        public Nullable<System.DateTime> License_End_Date { get; set; }
        public Nullable<int> IsActive { get; set; }
        public string LicenseKey { get; set; }
        public Nullable<int> No_of_Days { get; set; }
        public Nullable<System.DateTime> Creation_Date { get; set; }
    }
}
