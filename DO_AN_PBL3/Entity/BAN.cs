//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DO_AN_PBL3.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class BAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BAN()
        {
            this.HOA_DON = new HashSet<HOA_DON>();
        }
    
        public int ID_BAN { get; set; }
        public Nullable<int> ID_KV { get; set; }
        public string Tenban { get; set; }
        public Nullable<bool> TinhTrang { get; set; }
        public Nullable<int> ID_ban_Chuyen { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOA_DON> HOA_DON { get; set; }
    }
}
