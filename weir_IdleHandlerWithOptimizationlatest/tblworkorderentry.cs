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
    
    public partial class tblworkorderentry
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblworkorderentry()
        {
            this.tbl_ProdAndonDisp = new HashSet<tbl_ProdAndonDisp>();
            this.tbl_ProdManMachine = new HashSet<tbl_ProdManMachine>();
            this.tblBreakDownTickects = new HashSet<tblBreakDownTickect>();
            this.tblrejectqties = new HashSet<tblrejectqty>();
        }
    
        public int HMIID { get; set; }
        public int MachineID { get; set; }
        public System.DateTime WOStart { get; set; }
        public Nullable<System.DateTime> WOEnd { get; set; }
        public string PartNo { get; set; }
        public int ShiftID { get; set; }
        public string OperatorID { get; set; }
        public string Prod_Order_No { get; set; }
        public string OperationNo { get; set; }
        public int Yield_Qty { get; set; }
        public int ScrapQty { get; set; }
        public int Total_Qty { get; set; }
        public int ProcessQty { get; set; }
        public int Status { get; set; }
        public System.DateTime CorrectedDate { get; set; }
        public int IsStarted { get; set; }
        public int IsFinished { get; set; }
        public int IsPartialFinish { get; set; }
        public int isWorkOrder { get; set; }
        public System.DateTime PEStartTime { get; set; }
        public int IsMultiWO { get; set; }
        public int IsHold { get; set; }
        public int IsFlag { get; set; }
        public Nullable<int> ProdOrderQty { get; set; }
        public string FGCode { get; set; }
        public Nullable<int> HoldCodeID { get; set; }
        public Nullable<System.DateTime> HoldTime { get; set; }
        public Nullable<int> HoldDuration { get; set; }
        public Nullable<bool> isSplit { get; set; }
        public Nullable<int> CellID { get; set; }
        public Nullable<int> SyncInsert { get; set; }
        public Nullable<int> PartsPerCycle { get; set; }
        public int IsReWork { get; set; }
        public int ReWorkStart { get; set; }
        public int ReWorkEnd { get; set; }
        public Nullable<int> ReWorkReasonID { get; set; }
        public Nullable<System.DateTime> reworkStartTime { get; set; }
        public Nullable<System.DateTime> reworkEndTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ProdAndonDisp> tbl_ProdAndonDisp { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ProdManMachine> tbl_ProdManMachine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBreakDownTickect> tblBreakDownTickects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblrejectqty> tblrejectqties { get; set; }
    }
}
