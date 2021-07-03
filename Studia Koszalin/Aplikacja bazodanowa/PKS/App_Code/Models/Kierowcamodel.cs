using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Autokarmodel
/// </summary>
public class Kierowcamodel
{
    public string InsertKierowca(Kierowca kierowca)
    {

        try
        {
            Baza_PKSEntities db = new Baza_PKSEntities();
            db.Kierowca.Add(kierowca);
            db.SaveChanges();
            return "Dodano";
        }
        catch (Exception e)
        {
            return "Error" + e;
        }
    }

    public string UpdateKierowca(decimal Id_kierowcy, Kierowca kierowca)
    {
        try
        {
            Baza_PKSEntities db = new Baza_PKSEntities();
            Kierowca k = db.Kierowca.Find(Id_kierowcy);
            k.Imie_Nazwisko = kierowca.Imie_Nazwisko;
            k.Id_kursu = kierowca.Id_kursu;
            db.SaveChanges();
            return "edycja powiodla sie";
        }
        catch (Exception e)
        {
            return "Error" + e;
        }
    }

    public Kierowca GetKierowca(decimal Id_kierowcy)
    {
        try
        {
            using (Baza_PKSEntities db = new Baza_PKSEntities())
            {
                Kierowca kierowca = db.Kierowca.Find(Id_kierowcy);
                return kierowca;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }

}