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
    
    public partial class DeliveryTBL
    {
        public int deliveryID { get; set; }
        public Nullable<bool> full_delivery { get; set; }
        public int carID { get; set; }
        public int driverID { get; set; }
        public int invoiceID { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
        public int statusID { get; set; }
    
        public virtual DeliveryStatusTBL DeliveryStatusTBL { get; set; }
        public virtual VehicleTBL VehicleTBL { get; set; }
        public virtual EmployeeTBL EmployeeTBL { get; set; }
        public virtual InvoiceTBL InvoiceTBL { get; set; }
    }
}
