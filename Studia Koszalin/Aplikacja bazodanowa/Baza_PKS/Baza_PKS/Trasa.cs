//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Baza_PKS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trasa
    {
        public Trasa()
        {
            this.Kurs = new HashSet<Kurs>();
            this.Przebieg = new HashSet<Przebieg>();
        }
    
        public decimal Id_trasy { get; set; }
        public decimal Id_miejscowosci_poczatek { get; set; }
        public decimal Id_miejscowosci_koniec { get; set; }
        public string Oznaczenie_trasy { get; set; }
    
        public virtual ICollection<Kurs> Kurs { get; set; }
        public virtual Miejscowości Miejscowości { get; set; }
        public virtual Miejscowości Miejscowości1 { get; set; }
        public virtual ICollection<Przebieg> Przebieg { get; set; }
    }
}
