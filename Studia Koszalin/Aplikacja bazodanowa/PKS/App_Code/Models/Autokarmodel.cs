using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Autokarmodel
/// </summary>
public class Autokarmodel
{
    public string InsertAutokary(Autokar autokar)
    {

        try
        {
            Baza_PKSEntities db = new Baza_PKSEntities();
            db.Autokar.Add(autokar);
            db.SaveChanges();
            return "Dodano";
        }
        catch (Exception e)
        {
            return "Error" + e;
        }
    }

    public string UpdateAutokary(decimal Id_autokaru, Autokar autokar)
    {
        try
        {
            Baza_PKSEntities db = new Baza_PKSEntities();
            Autokar a = db.Autokar.Find(Id_autokaru);
            a.Nr_rejestr = autokar.Nr_rejestr;
            a.Marka = autokar.Marka;
            a.Model = autokar.Model;
            a.Liczba_miejsc = autokar.Liczba_miejsc;
            a.Id_kursu = autokar.Id_kursu;
            db.SaveChanges();
            return "edycja powiodla sie";
        }
        catch (Exception e)
        {
            return "Error" + e;
        }
    }

    public Autokar GetAutokar(decimal Id_autokaru)
    {
        try
        {
            using (Baza_PKSEntities db = new Baza_PKSEntities())
            {
                Autokar autokar = db.Autokar.Find(Id_autokaru);
                return autokar;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }

}