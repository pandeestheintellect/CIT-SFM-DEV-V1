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
    
    public partial class service_form
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public service_form()
        {
            this.service_form_files = new HashSet<service_form_files>();
        }
    
        public int ServiceID { get; set; }
        public string ServiceRefNum { get; set; }
        public string CaseRefNum { get; set; }
        public Nullable<System.DateTime> Service_Datetime { get; set; }
        public string Priority { get; set; }
        public Nullable<int> BuildingID { get; set; }
        public string Contact_Person { get; set; }
        public string Location { get; set; }
        public string RoomNo { get; set; }
        public string ServiceType { get; set; }
        public string Work_Requests { get; set; }
        public string Customer_Rep { get; set; }
        public string Customer_Rep_Signature { get; set; }
        public string Work_Completion_Details { get; set; }
        public string Remarks_TC { get; set; }
        public string Client_Comments { get; set; }
        public string Technician_Name { get; set; }
        public string Technician_Signature { get; set; }
        public string Customer_incharge_Name { get; set; }
        public string Customer_incharge_Signature { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> Status_Flag { get; set; }
        public Nullable<int> AssignedBy { get; set; }
        public Nullable<System.DateTime> AssignedDate { get; set; }
        public Nullable<System.DateTime> Technician_Signature_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<service_form_files> service_form_files { get; set; }
    }
}
