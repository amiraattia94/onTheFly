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
    
    public partial class vendorBranchTBL
    {
        public int vendor_branchID { get; set; }
        public int vendorID { get; set; }
        public string cityID { get; set; }
        public string address { get; set; }
        public Nullable<bool> active { get; set; }
        public string name { get; set; }
    
        public virtual LibyanCitiesTBL LibyanCitiesTBL { get; set; }
        public virtual vendorTBL vendorTBL { get; set; }
    }
}
