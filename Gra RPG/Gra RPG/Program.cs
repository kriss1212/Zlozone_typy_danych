using System;

public enum Rzadkosc
{
    Powszechny,
    Rzadki,
    Unikalny,
    Epicki
}

public enum TypPrzedmiotu
{
    Bron,
    Zbroja,
    Amulet,
    Pierscien,
    Helm,
    Tarcza,
    Buty
}

public struct Przedmiot
{
    public float waga;
    public int wartosc;
    public Rzadkosc rzadkosc;
    public TypPrzedmiotu typ;
    public string nazwaWlasna;

    public void WypelnijPrzedmiot(float _waga, int _wartosc, Rzadkosc _rzadkosc, TypPrzedmiotu _typ, string _nazwaWlasna)
    {
        waga = _waga;
        wartosc = _wartosc;
        rzadkosc = _rzadkosc;
        typ = _typ;
        nazwaWlasna = _nazwaWlasna;
    }

    public void WyswietlPrzedmiot()
    {
        Console.WriteLine("Przedmiot: " + nazwaWlasna);
        Console.WriteLine("Typ: " + typ);
        Console.WriteLine("Rzadkosc: " + rzadkosc);
        Console.WriteLine("Waga: " + waga);
        Console.WriteLine("Wartosc: " + wartosc);
    }
}

public class Program
{
    public static Random random = new Random();

    public static Przedmiot LosujPrzedmiot(Przedmiot[] przedmioty)
    {
        int index = random.Next(przedmioty.Length);
        return przedmioty[index];
    }

    public static Przedmiot[] PrzygotujPrzedmioty()
    {
        Przedmiot[] przedmioty = new Przedmiot[4];

        przedmioty[0].WypelnijPrzedmiot(2.5f, 10, Rzadkosc.Powszechny, TypPrzedmiotu.Bron, "Miecz");
        przedmioty[1].WypelnijPrzedmiot(5.0f, 50, Rzadkosc.Rzadki, TypPrzedmiotu.Zbroja, "Pancerz");
        przedmioty[2].WypelnijPrzedmiot(0.5f, 20, Rzadkosc.Unikalny, TypPrzedmiotu.Pierscien, "Pierscien Mocy");
        przedmioty[3].WypelnijPrzedmiot(1.0f, 30, Rzadkosc.Epicki, TypPrzedmiotu.Helm, "Hełm Nieśmiertelności");

        return przedmioty;
    }

    public static void Main(string[] args)
    {
        Przedmiot[] przedmioty = PrzygotujPrzedmioty();

        Przedmiot wylosowanyPrzedmiot = LosujPrzedmiot(przedmioty);

        wylosowanyPrzedmiot.WyswietlPrzedmiot();
    }
}
