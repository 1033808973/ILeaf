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
    
    public partial class Attachment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Attachment()
        {
            this.AttachmentAccesses = new HashSet<AttachmentAccess>();
            this.CourseAttachments = new HashSet<CourseAttachment>();
        }
    
        public long Id { get; set; }
        public Nullable<long> UploaderId { get; set; }
        public string FileName { get; set; }
        public long Size { get; set; }
        public string StoragePath { get; set; }
        public System.DateTime ExpireTime { get; set; }
        public Nullable<System.DateTime> UploadTime { get; set; }
        public bool IsPublic { get; set; }
    
        public virtual Account Account { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttachmentAccess> AttachmentAccesses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseAttachment> CourseAttachments { get; set; }
    }
}