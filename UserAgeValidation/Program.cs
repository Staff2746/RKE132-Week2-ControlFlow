// See https://aka.ms/new-console-template for more information

// Rakendus küsib kasutajalt valida tema sugu (m/f)
// Rakendus küsib kasutajalt tema perekonna nime
// Lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
// "Welcome , Mr. [kasutaja perekonnanimi]" / "Welcome , Ms. [kasutaja perekonnanimi]"

using System.Threading.Channels;

Console.WriteLine("Please select Your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine());
Console.WriteLine("Please enter your Last name:");
String userLastName = Console.ReadLine();

if(userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}







