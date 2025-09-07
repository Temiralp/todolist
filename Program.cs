using System;
using System.Collections.Generic;
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
        if (secim == "1")
        {
            GorevEkle();

        }

        if (secim == "2")
        {
            //
        }
        if (secim == "3")
        {

            GorevGuncelle();
        }

        if (secim == "4")
        {
            //
        }

    }
    static void GorevOku()
    {
        string okunan = File.ReadAllText("todolist.json");
        gorevler = JsonSerializer.Deserialize<List<string>>(okunan);
    }
    static void GorevGuncelle()
    {
        Console.Write("degistireceginiz gorev indexini girin: ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("yeni gorevi girin: ");
        string yenigorev = Console.ReadLine();
        GorevOku();

        gorevler[i] = yenigorev;
       JsonaYaz();
    }

    static void JsonaYaz()
    {
        string donusen = JsonSerializer.Serialize(gorevler);
        File.WriteAllText("todolist.json", donusen);
    }


    static void GorevEkle()
    {
        GorevOku();
        gorevler.Add(Console.ReadLine());
        JsonaYaz();

    }

    static void GoreviSil ()
    {
    
    Console.Writeline ("Lutfen sileceginiz gorevi girin")
        int silinecekGorev = int.Parse(Console.ReadLine());
    string okunanVeri = File.ReadAllText("todolist.json");

    gorevler.RemoveAt(silinecekGorev);

    string donusenveri = JsonSerializer.Serialize
        (gorevler);
    File.WriteAllText ("todolist.json", donusenveri);


    }
}
