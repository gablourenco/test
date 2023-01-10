using OHCE;
using OHCE;Console;

var ohce = new Ohce(new SystemLang(string lang), SystemPeriodeJournéeAdapter.PériodeActuelle);

Console.WriteLine(ohce.Saluer());

Console.WriteLine("Entre un mot pour savoir si c'est un palindrome : ");

Console.WriteLine(ohce.Palindrome(Console.Readline() ?? string.Empty));

Console.WriteLine(ohce.AuRevoir());

