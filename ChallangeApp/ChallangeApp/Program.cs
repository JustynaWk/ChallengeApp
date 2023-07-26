using System;

Console.WriteLine("Witaj, jak się nazywasz?");
string userName = Console.ReadLine();

Console.WriteLine("Witaj," + userName + " jak się dziś czujesz?");
string userResponse = Console.ReadLine();

Console.WriteLine("tia, a już się bałem, że naczytam się ludzkiego marudzenia...");
Console.WriteLine("No dobrze, to zacznijmy zabawę.");

Console.WriteLine("Wprowadź proszę dowolną cyfrę (o ile wiesz, czym różni się cyfra od liczby):");
string userX = Console.ReadLine();
var x = int.Parse(userX);
Console.WriteLine("Dobrze, zatem " + userX + " to będzie nasz x.");

Console.WriteLine("A teraz wprowadź, proszę, drugą cyfrę:");
string userY = Console.ReadLine();
var y = int.Parse(userY);
Console.WriteLine("Dziękuję, zatem " + userY + " to będzie nasze y.");

Console.WriteLine("Powiedz, " + userName + " czy jesteś gtowy na czary?");
string userResponse2 = Console.ReadLine();  

if (userResponse2 == "tak")     // znaleźć odpowiedź na pytanie: jak tu wskazać, że można odpowiedzieć też "Tak", "t", "T", "OK", "ok"...
    {
    Console.WriteLine("No to zaczynamy!");

    var result = (x + y);
    Console.WriteLine(userX + " dodać " + userY + " jest równe " + result);
    var result2 = (x - y);
    Console.WriteLine(userX + " odjąć " + userY + " jest równe " + result2);
    var result3 = (x * y);
    Console.WriteLine(userX + " pomnożone przez " + userY + " jest równe " + result3);
    var result4 = (x / y);
    Console.WriteLine(userX + " dzielone przez " + userY + " jest równe " + result4);
}
else
    {
       Console.WriteLine("Nie umiesz się bawić, żegnam zatem chłodno.");
    }