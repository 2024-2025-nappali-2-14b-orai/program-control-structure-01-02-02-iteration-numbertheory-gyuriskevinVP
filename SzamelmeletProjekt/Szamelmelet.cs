using System.Runtime.InteropServices;

namespace SzamelmeletProjekt;

public static class Szamelmelet
{
    // Az oszt�ly csak egyszer ker�l p�ld�nyos�t�sra
    public static bool OsztoE(int oszto, int szam)
    {
        /* el�gaz�s
        if (szam % oszto == 0)
            return true;
        return
            false;
        */

        // return szam % oszto == 0 ? true : false;

        return szam % oszto == 0;
    }

    public static List<int> GetOsztok(int szam)
    {
        // 6 oszt�i:  (1), 2, 3, (6)
        // 10 oszt�i: (1),2,5, (10)
        
        List<int> osztok = new List<int>();
        if (szam == 0)
            return osztok;
        if (szam < 0)
            szam = -szam;

        osztok.Add(1);
        for (int i = 2; i <= szam/2; i++)
        {
            if (OsztoE(i,szam))
                osztok.Add(i);
        }
        osztok.Add(szam);
        return osztok;
    }

    public static string ListaToString(List<int> list)
    {
        return string.Join(", ", list);
    }

    public static bool PrimszamE(int szam)
    {
        // Primsz�m-e a sz�m
        return GetOsztok(szam).Count == 2;
    }

    public static List<int> GetPrimszamok(int kezdet, int veg)
    {
        // Pr�msz�mok adott intervallumban
        List<int> primek = new List<int>();
        for(int i = kezdet; i <= veg; i++)
        {
            if (PrimszamE(i))
            {
                primek.Add(i);
            }
        }
        return primek;
    }

    public static List<int> GetPrimszamokHatarig(int veg)
    {
        return GetPrimszamok(1, veg);
    }
    public static int GetOsztokOsszege(int szam)
    {
        //int osszeg = 0;
        //List<int> lista = GetOsztok(szam);
        //for(int i = 0; i <= lista.Count; i++)
        //{
        //    osszeg += lista[i];
        //}
        //return osszeg;
        return GetOsztok(szam).Sum();
    }

    public static bool TokeletesE(int szam)
    {
        return false;
    }

    public static List<int> GetTokeletesek(int kezdet, int veg)
    {
        // T�k�letesek adott intervallumban
        return new List<int>();
    }

    public static List<int> GetTokeletesekHatarig(int veg)
    {
        // T�k�letesek adott hat�rig
        return new List<int>();
    }

    public static bool ParossavalSpecialisSzamE(int elsoSzam, int masodikSzam)
    {
        /*
          P�ros�val speci�lis sz�m a 12 �s 42, mivel 12*42 = 504 = 21*24, azaz a k�t sz�m szorzata nem v�ltozik, ha sz�mjegyeiket felcser�lj�k.
         */
        return false;
    }

    public static List<int> GetParossavalSepecialisSzamok(int kezdet, int veg)
    { 
        return new List<int>();
    }
}