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
    
    public partial class tblOperatorDashboard
    {
        public int OperatorDashboardID { get; set; }
        public int MachineID { get; set; }
        public System.DateTime CorrectedDate { get; set; }
        public int SlNo { get; set; }
        public string MessageCode { get; set; }
        public string MessageDescription { get; set; }
        public System.DateTime MessageStartTime { get; set; }
        public Nullable<System.DateTime> MessageEndTime { get; set; }
        public Nullable<int> TotalDurationinMin { get; set; }
        public System.DateTime InsertedOn { get; set; }
        public int InsertedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public int IsDeleted { get; set; }
    
        public virtual tblmachinedetail tblmachinedetail { get; set; }
    }
}
