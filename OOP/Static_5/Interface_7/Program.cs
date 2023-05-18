using Interface_7.Models;
using System.Collections;

namespace Interface_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kaleci kaleci = new()
            {
                Adi = "Tafarel",
                Soyadi = "Tefal",
                ElleTopKontrolu = 80,
                BirthTarihi = new DateTime(2000, 12, 12),
                Agresiflik = 10,
                FormaNumarasi = "50",
                Mevki = Mevki.Kale,
                MilliFutbolcu = false,
                SolakMi = false,
                Takim = "Galatasaray",
                TopaUcmaKontrolu = 100,
                TopKontrolu = 100,
                ToplamGolSayisi = 5,
                TopOynabiliyormu = true,
                TransferPulu = 5.000000M,
                Yas = 35
            };

            Forvet forvet = new()
            {
                Adi = "Sabri",
                Soyadi = "Sarıoğlu",
                BirthTarihi = new DateTime(2000, 12, 12),
                Agresiflik = 100,
                FormaNumarasi = "55",
                Mevki = Mevki.Bilinmiyor,
                MilliFutbolcu = true, // malesef
                SolakMi = false,
                Takim = "Galatasaray",
                TopKontrolu = 1,
                ToplamGolSayisi = 5,
                TopOynabiliyormu = false,
                TransferPulu = 0,
                Yas = 35
            };
            ArrayList fulbols = new ArrayList();
            fulbols.Add(forvet);
            fulbols.Add(kaleci);
            #region Old
            //foreach (var futbol in fulbols )
            //{
            //Console.WriteLine(futbol);

            //if (futbol is Kaleci)
            //{
            //    Kaleci qapi= (Kaleci)futbol;
            //    Console.WriteLine(qapi.Adi+" "+qapi.Soyadi);
            //}
            //else if (futbol is Forvet)
            //{
            //    Forvet saq= (Forvet)futbol;
            //    Console.WriteLine(saq.Adi + " " + saq.Soyadi);
            //}

            //if (futbol is Kaleci qapi)
            //{   
            //    Console.WriteLine(qapi.Adi+" "+qapi.Soyadi);
            //}
            //else if (futbol is Forvet saq)
            //{
            //    Console.WriteLine(saq.Adi + " " + saq.Soyadi);
            //} 
            //}
            #endregion
            for (int i = 0; i < fulbols.Count; i++)
            {
                Console.WriteLine($"{i}->{fulbols[i]}");
            }
            Console.WriteLine("id daxil edin");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Futbolcu \n" + fulbols[index]);
            Console.WriteLine("-----------------------------");
            
        }
    }
}