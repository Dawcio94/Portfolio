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
    
    public partial class Adresy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Adresy()
        {
            this.Klienci = new HashSet<Klienci>();
        }
    
        public int AdresId { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }
        public Nullable<int> NumerDomu { get; set; }
        public Nullable<int> NumerMieszkania { get; set; }
        public string KodPocztowy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Klienci> Klienci { get; set; }
    }
}
