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
    
    public partial class company_master
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public company_master()
        {
            this.users = new HashSet<user>();
        }
    
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string Pincode { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Mob { get; set; }
        public string Email { get; set; }
        public string RegNo { get; set; }
        public string GstRegNo { get; set; }
        public string LogoPath { get; set; }
        public Nullable<decimal> GST { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> IsActive { get; set; }
        public string ShortName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> users { get; set; }
    }
}
