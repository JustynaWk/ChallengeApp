//napisz program.cs, w którym:
// - zadeklarujesz zmienną z imieniem
// - zadeklarujeszz zmiennąz płcią (dobierz zmienną)
// - zadeklarujesz zmienną z wiekiem
// - zweryfikujesz dane i wyświetlisz
//jednek z komunikatów:
// (1) "Kobieta poniżej 30 lat"
// (2) "Ewa, lat 33"
// (3) "Niepełnoletni mężczyzna"
// --------------------------------

var imie = "Anna";
var plec = "kobieta";
var wiek = 33;

if (!(imie == "Ewa") && plec == "kobieta" && wiek < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

else if (imie == "Ewa" && plec == "kobieta" && wiek == 33)
{
    Console.WriteLine("Ewa, kobieta, lat 33");
}

else if (!(plec == "kobieta") && wiek < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}

else
{
    Console.WriteLine("wprowadzone zmienne niespełniające kryteriów 3 wyników zadania");
}

