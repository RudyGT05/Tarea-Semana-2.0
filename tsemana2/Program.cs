//Escribe un programa que lea una cadena de texto y la imprima al revés

Console.WriteLine("Escriba el texto");
string texto = Console.ReadLine();
string txtm = new string(texto.Reverse().ToArray());
Console.WriteLine(txtm);
