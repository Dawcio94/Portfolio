using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Przebiegmodel
/// </summary>
public class Przebiegmodel
{
    public string InsertPrzebieg(Przebieg przebieg)
    {

        try
        {
            Baza_PKSEntities db = new Baza_PKSEntities();
            db.Przebieg.Add(przebieg);
            db.SaveChanges();
            return "Dodano";
        }
        catch (Exception e)
        {
            return "Error" + e;
        }
    }

    public string UpdatePrzebieg(decimal Id_przebiegu, Przebieg przebieg)
    {
        try
        {
            Baza_PKSEntities db = new Baza_PKSEntities();
            Przebieg p = db.Przebieg.Find(Id_przebiegu);
            p.Id_miejscowosci = przebieg.Id_miejscowosci;
            p.Id_trasy = przebieg.Id_trasy;
            p.Kolejnosc = przebieg.Kolejnosc;
            p.Roznica_czasu = przebieg.Roznica_czasu;
            db.SaveChanges();
            return "edycja powiodla sie";
        }
        catch (Exception e)
        {
            return "Error" + e;
        }
    }

    public Przebieg GetPrzebieg(decimal Id_przebiegu)
    {
        try
        {
            using (Baza_PKSEntities db = new Baza_PKSEntities())
            {
                Przebieg przebieg = db.Przebieg.Find(Id_przebiegu);
                return przebieg;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }
}