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
    
    public partial class Friendship
    {
        public long Account1 { get; set; }
        public long Account2 { get; set; }
        public bool IsAccepted { get; set; }
    
        public virtual Account User1 { get; set; }
        public virtual Account User2 { get; set; }
    }
}
