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
    
    public partial class loginTrackerDetail
    {
        public int loginTrackerDetailsId { get; set; }
        public Nullable<int> machineId { get; set; }
        public Nullable<int> operatorId { get; set; }
        public Nullable<int> currentFGPart { get; set; }
        public string currentTicketRaisedId { get; set; }
        public Nullable<System.DateTime> loginDateTime { get; set; }
        public Nullable<System.DateTime> logoutDateTime { get; set; }
        public bool isLoggedIn { get; set; }
        public Nullable<System.DateTime> insertedOn { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public string shift { get; set; }
        public string correctedDate { get; set; }
    }
}