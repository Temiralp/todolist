using System;
using System.Text.Json;



public class Program
{
    static List<string> gorevler = new List<string>();

    static void Main()
    {
        Console.WriteLine("gorev ekle 1");
        Console.WriteLine("gorev listele 2");
        Console.WriteLine("gorev guncelle 3");
        Console.WriteLine("gorev sil 4");

        string secim = Console.ReadLine();
        if(secim == "1")
        {
            static void GorevOku()
            {
                string okunan = File.ReadAllText("gorevler.json");
                gorevler = JsonSerializer.Deserialize<List<string>>(okunan);
            }
            static void JsonaYaz()
            {
                string donusen = JsonSerializer.Serialize(gorevler);
                File.WriteAllText("gorevler.json", donusen);
            }
            static void GorevEkle()
            {
                Verioku();
                gorevler.Add(Console.ReadLine());
                Jsonayaz();

            }
        }

        if (secim == "2") { 
        //
        }
        if (secim == "3") { 
        //
        
        }

        if (secim == "4") { 
        //
        }

    }

}
