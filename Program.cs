using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EU
{
  class Program
  {
    static List<Class1> adatok = new List<Class1>();
    static void Main(string[] args)
    {
      ElsoFeladat();
      MasodikFeladat();
      HarmadikFeladat();
      NegyedikFeladat();
      OtodikFeladat();
      HatodikFeladat();
      HetedikFeladat();
      NyolcadikFeladat();
      Console.ReadKey();
    }

    private static void NyolcadikFeladat()
    {
      Console.WriteLine("8. feladat: Statisztika");
      Dictionary<int, int> dic = new Dictionary<int, int>();
      foreach (var a in adatok)
      {
        if (!dic.ContainsKey(a.Csatlakozas.Year))
        {
          dic.Add(a.Csatlakozas.Year, 1);
        }
        else
        {
          dic[a.Csatlakozas.Year] += 1;
        }
      }
      foreach (var d in dic)
      {
        Console.WriteLine($"\t{d.Key} - {d.Value} ország");
      }
    }

    private static void HetedikFeladat()
    {
      DateTime max = new DateTime();
      string orszag = "";
      foreach (var a in adatok)
      {
        if (max < a.Csatlakozas)
        {
          max = a.Csatlakozas;
          orszag = a.Orszag;
        }
      }
      Console.WriteLine($"7. feladat: Legutoljára csatlakozott ország: {orszag}");
    }

    private static void HatodikFeladat()
    {
      bool majusCsatl = false;
      foreach (var a in adatok)
      {
        if (a.Csatlakozas.Month == 05)
        {
          majusCsatl = true;
        }
      }
      if (majusCsatl)
      {
        Console.WriteLine($"6. feladat: Májusban volt csatlakozás");
      }
      else
      {
        Console.WriteLine($"6. feladat: Májusban nem volt csatlakozás");
      }
    }

    private static void OtodikFeladat()
    {
      DateTime csatl = new DateTime();
      foreach (var a in adatok)
      {
        if (a.Orszag == "Magyarország")
        {
          csatl = a.Csatlakozas;
        }
      }
      string moCsatl = csatl.ToShortDateString();
      Console.WriteLine($"5. feladat: Magyarország csatlakozásának dátuma: {moCsatl}");
    }

    private static void NegyedikFeladat()
    {
      int ketezerHet = 0;
      foreach (var a in adatok)
      {
        if (a.Csatlakozas.Year == 2007)
        {
          ketezerHet++; 
        }
      }
      Console.WriteLine($"4. feladat: 2007-ben {ketezerHet} ország csatlakozott.");
    }

    private static void HarmadikFeladat()
    {
      Console.WriteLine($"3. feladat: EU tagállamainak száma: {adatok.Count} db");//Akérmi
    }

    private static void MasodikFeladat()
    {
      Console.WriteLine("2. feladat: adatok beolvasása");
      StreamReader olvas = new StreamReader("EUcsatlakozas.txt");
      while (!olvas.EndOfStream)
      {
        string[] tarolo = olvas.ReadLine().Split(';');
        adatok.Add(new Class1(tarolo[0], Convert.ToDateTime(tarolo[1])));
      }
      olvas.Close();
    }

    private static void ElsoFeladat()
    {

    }
  }
}
