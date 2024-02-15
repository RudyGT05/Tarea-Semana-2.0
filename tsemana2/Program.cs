//Escribe un programa que calcule el área de un triángulo.

using System.Formats.Asn1;
using System.Text.RegularExpressions;

Console.WriteLine("Ingrese la base del triangulo");
int bases = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del triangulo");
int altura = int.Parse(Console.ReadLine());

float area = (bases * altura) / 2f;
Console.WriteLine("el area del triangulo es: " + area);

