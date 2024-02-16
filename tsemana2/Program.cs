using System.Text.RegularExpressions;

1.

 //entero a decimal

int ent = 8;
decimal dec = Convert.ToDecimal(ent);

Console.WriteLine("8 en decimal es:" + dec.ToString("0.0"));

2.

  //decimal a flotante

decimal dec = 8.10m;
float flo = (float)(dec);

Console.WriteLine("el numero decimal " + dec + " ha sido cambiado a flotante: " + flo);

3.

 //flotante a entero

float flo = 8.1f;
int ent = Convert.ToInt16(flo);



Console.WriteLine("el numero flotante " + flo + " ha sido cambiado a entero: " + ent);

4.

 //caracter a entero

char cara = 'A';
int ent = Convert.ToInt16(cara);



Console.WriteLine("el Caracter " + cara + " ha sido cambiado a entero: " + ent);

5.

//entero a caracter

int ent = 65;
char cara = Convert.ToChar(ent);



Console.WriteLine("el entero " + ent + " ha sido cambiado a Caracter: " + cara);


6.

//Suma de dos enteros

using System.Diagnostics.CodeAnalysis;

int n1 = 5;
int n2 = 10;
int suma = n1 + n2;



Console.WriteLine("La suma de los dos numeros es: " + suma);

7.
//resta de dos decimales

using System.Diagnostics.CodeAnalysis;

decimal n1 = 10.50m;
decimal n2 = 5.20m;
decimal resta = n1 - n2;

8.

//multiplicacion de dos flotantes

using System.Diagnostics.CodeAnalysis;

float n1 = 10.5f;
float n2 = 5.1f;
float multi = n1 * n2;



Console.WriteLine("La multiplicacion de los dos numeros es: " + multi);

9.

//división de dos números enteros

using System.Diagnostics.CodeAnalysis;

int n1 = 10;
int n2 = 5;
float division = n1 / n2;



Console.WriteLine("La division de los dos numeros es: " + division);

10.

//módulo de dos números enteros

using System.Diagnostics.CodeAnalysis;

int n1 = 12;
int n2 = 5;
float mod = n1 % n2;



Console.WriteLine("La division de los dos numeros es: " + mod);

11.

//Escribe un programa que lea una cadena de texto y la imprima en mayúsculas.

Console.WriteLine("Escriba el texto");
string texto = Console.ReadLine();
string txtm = texto.ToUpper();
Console.WriteLine(txtm);

12.

//Escribe un programa que lea una cadena de texto y la imprima en minúsculas

Console.WriteLine("Escriba el texto");
string texto = Console.ReadLine();
string txtm = texto.ToLower();
Console.WriteLine(txtm);

13.
//Escribe un programa que lea una cadena de texto y la imprima al revés

Console.WriteLine("Escriba el texto");
string texto = Console.ReadLine();
string txtm = new string(texto.Reverse().ToArray());
Console.WriteLine(txtm);

14.

//Escribe un programa que lea una cadena de texto y busque una palabra en ella

Console.WriteLine("Escriba el texto");
string texto = Console.ReadLine();
Console.WriteLine("Cual es la palabra que busca?");
string palabra = Console.ReadLine();
if (texto.Contains(palabra))


    Console.WriteLine("La palabra si está en el texto");

else

    Console.WriteLine("La palabra no esta en el texto");

15.
//Escribe un programa que lea una cadena de texto y cuente el número de vocales que contiene.

using System.Text.RegularExpressions;

Console.WriteLine("Escriba el texto");
string texto = Console.ReadLine();
int vocales = Regex.Matches(texto, "[aeiouAEIOU]").Count;
Console.WriteLine("Su palabra tiene: " + vocales);

16.

//Escribe un programa que calcule el área de un triángulo.

using System.Formats.Asn1;
using System.Text.RegularExpressions;

Console.WriteLine("Ingrese la base del triangulo");
int bases = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del triangulo");
int altura = int.Parse(Console.ReadLine());

float area = (bases * altura) / 2f;
Console.WriteLine("el area del triangulo es: " + area);
17.

//Escribe un programa que calcule el volumen de una esfera.

using System.Formats.Asn1;
using System.Text.RegularExpressions;

Console.WriteLine("Ingrese el radio de la esfera");
double radio = double.Parse(Console.ReadLine());
double volumen = (3.14 * (4 * (radio * radio * radio))) / 3;

Console.WriteLine("el volumen de una esfera es: " + volumen);

18.

//Escribe un programa que calcule la distancia entre dos puntos

Console.WriteLine("Ingrese las coordenadas del primer punto:");
Console.Write("Ingrese x: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Ingrese y: ");
double y1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese las coordenadas del segundo punto:");
Console.Write(" Ingrese x: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Ingrese y: ");
double y2 = double.Parse(Console.ReadLine());
double resultado = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
Console.WriteLine("La distancia es de:" + resultado);


19.
//Escribe un programa que calcule la temperatura en grados Fahrenheit a partir de la temperatura en grados Celsius

Console.WriteLine("Ingrese la temperatura en grados celsius:");
double celsius = double.Parse(Console.ReadLine());
double fahrenheit = (celsius * 9 / 5) + 32;

Console.WriteLine("la temperatura en grados Fahrenheit es de:" + fahrenheit);

20.
//Escribe un programa que calcule la temperatura en grados Celsius a partir de la temperatura en grados Fahrenheit.

Console.WriteLine("Ingrese la temperatura en grados Fahrenheit:");
double fahrenheit = double.Parse(Console.ReadLine());
double celsius = (fahrenheit - 32) * 5 / 9;

Console.WriteLine("la temperatura en grados Celsius es de:" + celsius);
1.

 //entero a decimal

int ent = 8;
decimal dec = Convert.ToDecimal(ent);

Console.WriteLine("8 en decimal es:" + dec.ToString("0.0"));

2.

  //decimal a flotante

decimal dec = 8.10m;
float flo = (float)(dec);

Console.WriteLine("el numero decimal " + dec + " ha sido cambiado a flotante: " + flo);

3.

 //flotante a entero

float flo = 8.1f;
int ent = Convert.ToInt16(flo);



Console.WriteLine("el numero flotante " + flo + " ha sido cambiado a entero: " + ent);

4.

 //caracter a entero

char cara = 'A';
int ent = Convert.ToInt16(cara);



Console.WriteLine("el Caracter " + cara + " ha sido cambiado a entero: " + ent);

5.

//entero a caracter

int ent = 65;
char cara = Convert.ToChar(ent);



Console.WriteLine("el entero " + ent + " ha sido cambiado a Caracter: " + cara);


6.

//Suma de dos enteros

using System.Diagnostics.CodeAnalysis;

int n1 = 5;
int n2 = 10;
int suma = n1 + n2;



Console.WriteLine("La suma de los dos numeros es: " + suma);

7.
//resta de dos decimales

using System.Diagnostics.CodeAnalysis;

decimal n1 = 10.50m;
decimal n2 = 5.20m;
decimal resta = n1 - n2;

8.

//multiplicacion de dos flotantes

using System.Diagnostics.CodeAnalysis;

float n1 = 10.5f;
float n2 = 5.1f;
float multi = n1 * n2;



Console.WriteLine("La multiplicacion de los dos numeros es: " + multi);

9.

//división de dos números enteros

using System.Diagnostics.CodeAnalysis;

int n1 = 10;
int n2 = 5;
float division = n1 / n2;



Console.WriteLine("La division de los dos numeros es: " + division);

10.

//módulo de dos números enteros

using System.Diagnostics.CodeAnalysis;

int n1 = 12;
int n2 = 5;
float mod = n1 % n2;



Console.WriteLine("La division de los dos numeros es: " + mod);

11.

//Escribe un programa que lea una cadena de texto y la imprima en mayúsculas.

Console.WriteLine("Escriba el texto");
string texto = Console.ReadLine();
string txtm = texto.ToUpper();
Console.WriteLine(txtm);

12.

//Escribe un programa que lea una cadena de texto y la imprima en minúsculas

Console.WriteLine("Escriba el texto");
string texto = Console.ReadLine();
string txtm = texto.ToLower();
Console.WriteLine(txtm);

13.
//Escribe un programa que lea una cadena de texto y la imprima al revés

Console.WriteLine("Escriba el texto");
string texto = Console.ReadLine();
string txtm = new string(texto.Reverse().ToArray());
Console.WriteLine(txtm);

14.

//Escribe un programa que lea una cadena de texto y busque una palabra en ella

Console.WriteLine("Escriba el texto");
string texto = Console.ReadLine();
Console.WriteLine("Cual es la palabra que busca?");
string palabra = Console.ReadLine();
if (texto.Contains(palabra))


    Console.WriteLine("La palabra si está en el texto");

else

    Console.WriteLine("La palabra no esta en el texto");

15.
//Escribe un programa que lea una cadena de texto y cuente el número de vocales que contiene.

using System.Text.RegularExpressions;

Console.WriteLine("Escriba el texto");
string texto = Console.ReadLine();
int vocales = Regex.Matches(texto, "[aeiouAEIOU]").Count;
Console.WriteLine("Su palabra tiene: " + vocales);

16.

//Escribe un programa que calcule el área de un triángulo.

using System.Formats.Asn1;
using System.Text.RegularExpressions;

Console.WriteLine("Ingrese la base del triangulo");
int bases = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del triangulo");
int altura = int.Parse(Console.ReadLine());

float area = (bases * altura) / 2f;
Console.WriteLine("el area del triangulo es: " + area);
17.

//Escribe un programa que calcule el volumen de una esfera.

using System.Formats.Asn1;
using System.Text.RegularExpressions;

Console.WriteLine("Ingrese el radio de la esfera");
double radio = double.Parse(Console.ReadLine());
double volumen = (3.14 * (4 * (radio * radio * radio))) / 3;

Console.WriteLine("el volumen de una esfera es: " + volumen);

18.

//Escribe un programa que calcule la distancia entre dos puntos

Console.WriteLine("Ingrese las coordenadas del primer punto:");
Console.Write("Ingrese x: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Ingrese y: ");
double y1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese las coordenadas del segundo punto:");
Console.Write(" Ingrese x: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Ingrese y: ");
double y2 = double.Parse(Console.ReadLine());
double resultado = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
Console.WriteLine("La distancia es de:" + resultado);


19.
//Escribe un programa que calcule la temperatura en grados Fahrenheit a partir de la temperatura en grados Celsius

Console.WriteLine("Ingrese la temperatura en grados celsius:");
double celsius = double.Parse(Console.ReadLine());
double fahrenheit = (celsius * 9 / 5) + 32;

Console.WriteLine("la temperatura en grados Fahrenheit es de:" + fahrenheit);

20.
//Escribe un programa que calcule la temperatura en grados Celsius a partir de la temperatura en grados Fahrenheit.

Console.WriteLine("Ingrese la temperatura en grados Fahrenheit:");
double fahrenheit = double.Parse(Console.ReadLine());
double celsius = (fahrenheit - 32) * 5 / 9;

Console.WriteLine("la temperatura en grados Celsius es de:" + celsius);

