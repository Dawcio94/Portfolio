//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class Baza_PKSEntities : DbContext
{
    public Baza_PKSEntities()
        : base("name=Baza_PKSEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<Autokar> Autokar { get; set; }
    public virtual DbSet<Kierowca> Kierowca { get; set; }
    public virtual DbSet<Kurs> Kurs { get; set; }
    public virtual DbSet<Miejscowości> Miejscowości { get; set; }
    public virtual DbSet<Przebieg> Przebieg { get; set; }
    public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    public virtual DbSet<Trasa> Trasa { get; set; }
}
