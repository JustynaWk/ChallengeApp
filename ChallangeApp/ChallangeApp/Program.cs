var number1 = 50;
var number2 = 10;

if (number1 < number2)
{
    Console.WriteLine("Tak, to prawda - linia 6");
}
else
{
    Console.WriteLine("Nie, to nie prawda - linia 10");
}

var name = "Adam";
var age = 33;

if (name == "Adam" && age < 50)
{
    Console.WriteLine("jestem Adamem przed pięćdziesiątką");
}
else
{
    Console.WriteLine("jestem kimś innym");

}

var name2 = "Jan";
var age2 = 6;

if (!(age < 30))
{
    Console.WriteLine("Warunek został spełniony - linia 31");
}
else
{
    Console.WriteLine("Warunek nie został spełniony - linia 35");

}

bool isActive = true;
if (isActive)
{
    Console.WriteLine("to prawda - linia 42");
}
else
{
    Console.Write("to nieprawda - linia 48");
}

// do else można dodawać kolejne ify w celu dalszych weryfikacji, jeżeli chcemy mieć poziomy:
var age3 = 21;

if (age3 > 50)
{
    Console.WriteLine("powyżej piędziesiątki - linia 51");
}
else if (age3 > 30 && age3 < 50)
{
    Console.WriteLine("powyżej 30 ale przed 50 - linia 55");
}
else if (age3 > 10 && age3 < 30)
{
    Console.WriteLine("powyżej 20 ale przed 30 - linia 62");
}

//zagnieżdżony if

var age4 = 37;
var name3 = "Justyna";

if (age > 50)

{
    if (name == "Justyna")
    {
        Console.WriteLine("Justyna powyżej 50tki - linia 69");
    }
}
else
{
    Console.WriteLine("Justyna poniżej 50tki - linia 80");
}
