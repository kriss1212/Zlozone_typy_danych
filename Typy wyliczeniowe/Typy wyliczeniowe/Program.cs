using System;

class Program
{
    enum DniTygodnia
    {
        Poniedzialek,
        Wtorek,
        Sroda,
        Czwartek,
        Piatek,
        Sobota,
        Niedziela
    }
    enum EtapyPrania
    {
        WstepnePlukanie,
        GlownePranie,
        Plukanie,
        Wirowanie,
        Suszenie
    }

    enum PosilkiDnia
    {
        Sniadanie,
        DrugieSniadanie,
        Obiad,
        Podwieczorek,
        Kolacja
    }

    enum BierkiSzachowe
    {
        Pionek,
        Skoczek,
        Goniec,
        Wieza,
        Hetman,
        Krol
    }

    static void Main()
    {
        // Przykład użycia typu wyliczeniowego
        DniTygodnia dzien = DniTygodnia.Poniedzialek;
        Console.WriteLine("Dzisiejszy dzień to: " + dzien);

        Console.ReadLine();
    }
}

    