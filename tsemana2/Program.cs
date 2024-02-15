//Escribe un programa que lea una cadena de texto y cuente el número de vocales que contiene.

using System.Text.RegularExpressions;

Console.WriteLine("Escriba el texto");
string texto = Console.ReadLine();
int vocales = Regex.Matches(texto,"[aeiouAEIOU]").Count;
Console.WriteLine("Su palabra tiene: "+vocales);

