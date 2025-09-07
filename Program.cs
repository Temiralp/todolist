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
            //
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
    static void GorevGuncelle()
    {
        Console.Write("degistireceginiz gorev indexini girin: ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("yeni gorevi girin: ");
        string yenigorev = Console.ReadLine();
        string okunanveri = File.ReadAllText("todolist.json");
        gorevler = JsonSerializer.Deserialize<List<string>>(okunanveri);
        gorevler[i] = yenigorev;
        string donusenveri = JsonSerializer.Serialize
        (gorevler);
        File.WriteAllText("todolist.json", donusenveri);
    }
}
