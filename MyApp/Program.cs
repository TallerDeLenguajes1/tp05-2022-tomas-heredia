using System;
Console.WriteLine("ingrese el numero");
string texto = Console.ReadLine();
double numero = float.Parse(texto);
Console.WriteLine("Valor absoluto: "+ Math.Abs(numero));
Console.WriteLine("Cuadrado: "+ Math.Pow(numero,2));
Console.WriteLine("Valor raiz: "+ Math.Sqrt(numero));
Console.WriteLine("Valor seno: "+ Math.Sin(numero));
Console.WriteLine("Valor coseno: "+ Math.Sin(numero));
Console.WriteLine("Valor entero: "+ Math.Truncate(numero));

Console.WriteLine("ingrese el primer numero");
texto = Console.ReadLine();
double primero = float.Parse(texto);
Console.WriteLine("ingrese el segundo numero");
texto = Console.ReadLine();
double segundo = float.Parse(texto);

Console.WriteLine("Valor maximo: "+ Math.Max(primero,segundo));
Console.WriteLine("Valor minimo: "+ Math.Min(primero,segundo));