//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarTiresService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Raport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Raport()
        {
            this.RaportCzesc = new HashSet<RaportCzesc>();
            this.RaportUslugi = new HashSet<RaportUslugi>();
        }
    
        public int RaportId { get; set; }
        public Nullable<int> RezerwacjaId { get; set; }
        public Nullable<decimal> KosztCalkowity { get; set; }
    
        public virtual Rezerwacje Rezerwacje { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RaportCzesc> RaportCzesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RaportUslugi> RaportUslugi { get; set; }
    }
}
