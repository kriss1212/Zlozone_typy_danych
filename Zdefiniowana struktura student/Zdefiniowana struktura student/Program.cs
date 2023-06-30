using System;

public enum Plec
{
    Mezczyzna,
    Kobieta
}

public struct Student
{
    public string Nazwisko;
    public int NrAlbumu;
    public double Ocena;
    public Plec Plec;
}

public class Program
{
    public static void WypelnijStudenta(ref Student student)
    {
        Console.Write("Podaj nazwisko studenta: ");
        student.Nazwisko = Console.ReadLine();

        Console.Write("Podaj numer albumu: ");
        student.NrAlbumu = int.Parse(Console.ReadLine());

        do
        {
            Console.Write("Podaj ocenę studenta (2.0 - 5.0): ");
            student.Ocena = double.Parse(Console.ReadLine());
        } while (student.Ocena < 2.0 || student.Ocena > 5.0);

        Console.Write("Podaj płeć studenta (0 - Mezczyzna, 1 - Kobieta): ");
        student.Plec = (Plec)int.Parse(Console.ReadLine());
    }

    public static double ObliczSrednia(Student[] grupa)
    {
        double sumaOcen = 0;
        foreach (var student in grupa)
        {
            sumaOcen += student.Ocena;
        }

        return sumaOcen / grupa.Length;
    }

    public static void WyswietlStudenta(Student student)
    {
        Console.WriteLine($"Nazwisko: {student.Nazwisko}, Numer albumu: {student.NrAlbumu}, " +
                          $"Ocena: {student.Ocena}, Płeć: {student.Plec}");
    }

    public static void Main(string[] args)
    {
        Student[] grupa = new Student[5];

        for (int i = 0; i < grupa.Length; i++)
        {
            Console.WriteLine($"Wprowadź dane dla studenta #{i + 1}:");
            WypelnijStudenta(ref grupa[i]);
        }

        Console.WriteLine("\nInformacje o studentach:");
        foreach (var student in grupa)
        {
            WyswietlStudenta(student);
        }

        double srednia = ObliczSrednia(grupa);
        Console.WriteLine($"\nŚrednia ocen w grupie: {srednia}");
    }
}