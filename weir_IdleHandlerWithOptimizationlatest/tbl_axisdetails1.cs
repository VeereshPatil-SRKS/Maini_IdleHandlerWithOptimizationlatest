//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace i_facility_IdleHandlerWithOptimization
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_axisdetails1
    {
        public int ADID { get; set; }
        public int MachineID { get; set; }
        public string Axis { get; set; }
        public Nullable<decimal> AbsPos { get; set; }
        public Nullable<decimal> RelPos { get; set; }
        public Nullable<decimal> MacPos { get; set; }
        public Nullable<decimal> DistPos { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public Nullable<System.DateTime> InsertedOn { get; set; }
    }
}
