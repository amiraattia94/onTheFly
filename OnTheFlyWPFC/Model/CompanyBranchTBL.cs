//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnTheFlyWPFC.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CompanyBranchTBL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompanyBranchTBL()
        {
            this.EmployeeTBLs = new HashSet<EmployeeTBL>();
            this.invoiceTBLs = new HashSet<invoiceTBL>();
        }
    
        public int branchID { get; set; }
        public string branch_name { get; set; }
        public string address { get; set; }
        public bool status { get; set; }
        public string cityID { get; set; }
    
        public virtual LibyanCitiesTBL LibyanCitiesTBL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeTBL> EmployeeTBLs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<invoiceTBL> invoiceTBLs { get; set; }
    }
}
