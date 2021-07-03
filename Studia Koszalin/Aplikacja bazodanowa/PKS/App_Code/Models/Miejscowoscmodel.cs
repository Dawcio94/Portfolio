using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Miejscemodel
/// </summary>
public class Miejscowoscmodel
{
    public string InsertMiejscowosc(Miejscowości miejscowosc)
    {

        try
        {
            Baza_PKSEntities db = new Baza_PKSEntities();
            db.Miejscowości.Add(miejscowosc);
            db.SaveChanges();
            return "Dodano";
        }
        catch (Exception e)
        {
            return "Error" + e;
        }
    }

    public string UpdateMiejscowosc(decimal Id_miejscowosci, Miejscowości miejscowosc)
    {
        try
        {
            Baza_PKSEntities db = new Baza_PKSEntities();
            Miejscowości m = db.Miejscowości.Find(Id_miejscowosci);
            m.Nazwa_miejscowosci = miejscowosc.Nazwa_miejscowosci;
            db.SaveChanges();
            return "edycja powiodla sie";
        }
        catch (Exception e)
        {
            return "Error" + e;
        }
    }

    public Miejscowości GetMiejscowosc(decimal Id_miejscowosci)
    {
        try
        {
            using (Baza_PKSEntities db = new Baza_PKSEntities())
            {
                Miejscowości miejscowosc = db.Miejscowości.Find(Id_miejscowosci);
                return miejscowosc;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }
}