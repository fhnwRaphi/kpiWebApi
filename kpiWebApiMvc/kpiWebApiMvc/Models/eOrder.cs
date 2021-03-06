//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kpiWebApiMvc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class eOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public eOrder()
        {
            this.eSerials = new HashSet<eSerial>();
            this.rOrderProcesses = new HashSet<rOrderProcess>();
        }
    
        public int OrderId { get; set; }
        public int PcbId { get; set; }
        public Nullable<System.DateTime> orderCreateDate { get; set; }
        public Nullable<System.DateTime> orderFinishDate { get; set; }
        public short orderPcNew { get; set; }
        public short orderPcActual { get; set; }
    
        public virtual ePcb ePcb { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<eSerial> eSerials { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rOrderProcess> rOrderProcesses { get; set; }
    }
}
