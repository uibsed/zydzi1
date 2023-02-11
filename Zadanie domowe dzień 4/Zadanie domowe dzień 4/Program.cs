var name = "Barnaba";
var gender = "man";
var age = 50;
if (name == "Barnaba" && age == 50)
{
    Console.WriteLine("Barnaba lat 50");
}
else if (gender == "man")
{
    if (age < 50)
    {
        Console.WriteLine("Mężczyzna poniżej 50 lat");
    }
    if (age > 50)
    {
        Console.WriteLine("Mężczyzna po 50 roku życia");
    }
}
else if (gender == "woman")
{
    if (age < 50)
    {
        Console.WriteLine("Kobieta poniżej 50 lat");
    }
    if (age > 50)
    {
        Console.WriteLine("Kobieta po 50 roku życia");
    }
}