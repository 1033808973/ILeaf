//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ILeaf.Core.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AppointmentShareToUser
    {
        public long AppointmentId { get; set; }
        public long UserId { get; set; }
        public bool IsAccepted { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Appointment Appointment { get; set; }
    }
}