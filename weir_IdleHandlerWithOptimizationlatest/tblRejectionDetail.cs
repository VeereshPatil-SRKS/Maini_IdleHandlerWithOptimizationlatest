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
    
    public partial class tblRejectionDetail
    {
        public int rejectionId { get; set; }
        public Nullable<int> fgPartId { get; set; }
        public Nullable<int> defectCodeId { get; set; }
        public Nullable<int> defectQty { get; set; }
        public Nullable<int> machineId { get; set; }
        public Nullable<int> operatorId { get; set; }
        public Nullable<int> isDeleted { get; set; }
        public Nullable<System.DateTime> createdOn { get; set; }
        public Nullable<int> createdBy { get; set; }
        public Nullable<System.DateTime> modifiedOn { get; set; }
        public Nullable<int> modifiedBy { get; set; }
        public string correctedDate { get; set; }
        public string shift { get; set; }
    }
}
