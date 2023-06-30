
using System;

struct Student
{
    public string Imie;
    public string Nazwisko;
    public int NumerIndeksu;
    public string ProgramStudiow;
}

struct Przedmiot
{
    public string Nazwa;
    public string Kod;
    public int ECTS;
    public string Prowadzacy;
}

struct NauczycielAkademicki
{
    public string Imie;
    public string Nazwisko;
    public string TytulNaukowy;
    public string Specjalizacja;
}

class Program
{
    static void Main()
    {
        // Przykład użycia struktur
        Student student = new Student();
        student.Imie = "Jan";
        student.Nazwisko = "Kowalski";
        student.NumerIndeksu = 12345;
        student.ProgramStudiow = "Informatyka";

        Console.WriteLine("Student: {0} {1}, Indeks: {2}, Program studiów: {3}", student.Imie, student.Nazwisko, student.NumerIndeksu, student.ProgramStudiow);

        Przedmiot przedmiot = new Przedmiot();
        przedmiot.Nazwa = "Programowanie";
        przedmiot.Kod = "PROG101";
        przedmiot.ECTS = 6;
        przedmiot.Prowadzacy = "Dr. Nowak";

        Console.WriteLine("Przedmiot: {0} ({1}), ECTS: {2}, Prowadzący: {3}", przedmiot.Nazwa, przedmiot.Kod, przedmiot.ECTS, przedmiot.Prowadzacy);

        NauczycielAkademicki nauczyciel = new NauczycielAkademicki();
        nauczyciel.Imie = "Anna";
        nauczyciel.Nazwisko = "Nowakowska";
        nauczyciel.TytulNaukowy = "Profesor";
        nauczyciel.Specjalizacja = "Sztuczna inteligencja";

        Console.WriteLine("Nauczyciel: {0} {1}, Tytuł naukowy: {2}, Specjalizacja: {3}", nauczyciel.Imie, nauczyciel.Nazwisko, nauczyciel.TytulNaukowy, nauczyciel.Specjalizacja);

        Console.ReadLine();
    }
}