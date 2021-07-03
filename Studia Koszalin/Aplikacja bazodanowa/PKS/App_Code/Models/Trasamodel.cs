using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Trasamodel
/// </summary>
public class Trasamodel
{
    public string InsertTrasa(Trasa trasa)
    {

        try
        {
            Baza_PKSEntities db = new Baza_PKSEntities();
            db.Trasa.Add(trasa);
            db.SaveChanges();
            return "Dodano";
        }
        catch (Exception e)
        {
            return "Error" + e;
        }
    }

    public string UpdateTrasa(decimal Id_trasy, Trasa trasa)
    {
        try
        {
            Baza_PKSEntities db = new Baza_PKSEntities();
            Trasa t = db.Trasa.Find(Id_trasy);
            t.Id_miejscowosci_koniec = trasa.Id_miejscowosci_koniec;
            t.Id_miejscowosci_poczatek = trasa.Id_miejscowosci_poczatek;
            t.Oznaczenie_trasy = trasa.Oznaczenie_trasy;
            db.SaveChanges();
            return "edycja powiodla sie";
        }
        catch (Exception e)
        {
            return "Error" + e;
        }
    }

    public Trasa GetTrasa(decimal Id_trasy)
    {
        try
        {
            using (Baza_PKSEntities db = new Baza_PKSEntities())
            {
                Trasa trasa = db.Trasa.Find(Id_trasy);
                return trasa;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }
}