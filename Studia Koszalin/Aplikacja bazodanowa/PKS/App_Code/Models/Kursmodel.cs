using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Kursmodel
/// </summary>
public class Kursmodel
{
    public string InsertKurs(Kurs kurs)
    {

        try
        {
            Baza_PKSEntities db = new Baza_PKSEntities();
            db.Kurs.Add(kurs);
            db.SaveChanges();
            return "Dodano";
        }
        catch (Exception e)
        {
            return "Error" + e;
        }
    }

    public string UpdateKurs(decimal Id_kursu, Kurs kurs)
    {
        try
        {
            Baza_PKSEntities db = new Baza_PKSEntities();
            Kurs k = db.Kurs.Find(Id_kursu);
            k.Oznaczenie = kurs.Oznaczenie;
            k.Id_trasy = kurs.Id_trasy;
            k.Godzina_rozpoczecia = kurs.Godzina_rozpoczecia;
            k.Ilość_pasażerów = kurs.Ilość_pasażerów;
            k.Data_kursu = kurs.Data_kursu;
            db.SaveChanges();
            return "edycja powiodla sie";
        }
        catch (Exception e)
        {
            return "Error" + e;
        }
    }

    public Kurs GetKurs(decimal Id_kursu)
    {
        try
        {
            using (Baza_PKSEntities db = new Baza_PKSEntities())
            {
                Kurs kurs = db.Kurs.Find(Id_kursu);
                return kurs;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }
}