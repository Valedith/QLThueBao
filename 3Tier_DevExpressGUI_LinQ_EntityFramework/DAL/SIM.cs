//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class SIM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SIM()
        {
            this.BILLs = new HashSet<BILL>();
            this.CONTRACTs = new HashSet<CONTRACT>();
            this.DETAILs = new HashSet<DETAIL>();
        }
    
        public string ID_SIM { get; set; }
        public string ID_CUSTOMER { get; set; }
        public Nullable<int> PHONENUMBER { get; set; }
        public Nullable<bool> STATUS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BILL> BILLs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRACT> CONTRACTs { get; set; }
        public virtual CUSTOMER CUSTOMER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETAIL> DETAILs { get; set; }
    }
}
