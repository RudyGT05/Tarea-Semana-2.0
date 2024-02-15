//Escribe un programa que calcule el volumen de una esfera.

using System.Formats.Asn1;
using System.Text.RegularExpressions;

Console.WriteLine("Ingrese el radio de la esfera");
double radio = double.Parse(Console.ReadLine());
double volumen =   (3.14 * (4*(radio*radio*radio)))/3;

Console.WriteLine("el volumen de una esfera es: " + volumen);

