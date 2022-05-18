﻿using System;
/* codigo de calculadora 2
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
double primero1 = float.Parse(texto);
Console.WriteLine("ingrese el segundo numero");
texto = Console.ReadLine();
double segundo1 = float.Parse(texto);

Console.WriteLine("Valor maximo: "+ Math.Max(primero1,segundo1));
Console.WriteLine("Valor minimo: "+ Math.Min(primero1,segundo1));*/
﻿
/*codigo de calculadora 1*/
void calculadora(string cadena1, string cadena2){
    int aux =0;
    while (aux == 0)
    {   Console.WriteLine("Que operacion desea realizar?");
        Console.WriteLine("1_Sumar  2_Restar   3_Dividir   4_Multiplicar   5_Salir");
        string texto = Console.ReadLine();
        int operacion = Int32.Parse(texto);
        int resultado = 0;
        if (operacion == 1)
        {
            
            int primero = Int32.Parse(cadena1);
            int segundo = Int32.Parse(cadena2);
            resultado = primero + segundo;
            string total = resultado.ToString();
            Console.WriteLine("la suma de "+primero+" y "+segundo+" es "+total);
        }else
        {
            if (operacion == 2)
            {
                int primero = Int32.Parse(cadena1);
                int segundo = Int32.Parse(cadena2);
                resultado = primero - segundo;
                string total = resultado.ToString();
                Console.WriteLine("la resta de "+primero+" y "+segundo+" es "+total);
            }else
            {
                if (operacion == 3)
                {
                    int primero = Int32.Parse(cadena1);
                    int segundo = Int32.Parse(cadena2);
                    
                    resultado = primero / segundo;
                    string total = resultado.ToString();
                    Console.WriteLine("la divicion de "+primero+" y "+segundo+" es "+total);
                }else
                {
                    if (operacion == 4)
                    {
                        int primero = Int32.Parse(cadena1);
                        int segundo = Int32.Parse(cadena2);
                        resultado = primero * segundo;
                        string total = resultado.ToString();
                        Console.WriteLine("la multiplicacion de "+primero+" y "+segundo+" es "+total);
                    }else
                    {
                        aux = 1;
                    }
                }
            }
        }
    }
}
string stringEntre(string cadena, string inicio, string final){
            string resultado = "";
            if (cadena.Contains(inicio) && cadena.Contains(final))
            {
                int inicioIndex = cadena.IndexOf(inicio, 0) + inicio.Length;
                int finalIndex = cadena.IndexOf(final, inicioIndex);
                resultado = cadena.Substring(inicioIndex, finalIndex - inicioIndex);
                return resultado;
            }

            return resultado;
        }

string texto = "hola soy texto 1";
Console.WriteLine("Tomando 2 digitos: "+ texto.Substring(0,2));
Console.WriteLine("Longitud: "+ texto.Length);


string texto2 = " unido a texto 2";
string concatenada = texto + texto2;
Console.WriteLine("Concatenadas: "+ concatenada);

string palabra1 = "hola";
string palabra2 = "texto";
string cortado = stringEntre(texto, palabra1, palabra2);
Console.WriteLine("Cortado: "+ cortado);


Console.WriteLine("ingrese un numero");
string numero1 = Console.ReadLine();
Console.WriteLine("ingrese otro numero");
string numero2 = Console.ReadLine();

calculadora(numero1,numero2);


foreach (char i in texto)
{
    Console.WriteLine(i.ToString());
}

Console.WriteLine("indice de la ocurrencia de la palabra "+ palabra2+" en el texto "+texto.IndexOf(palabra2));

Console.WriteLine("Mayusculas: "+ texto.ToUpper());
Console.WriteLine("Minuscula: "+ texto.ToLower());

Console.WriteLine("El resultado de comparar "+texto+" con "+ texto2+" es: "+ texto.CompareTo(texto2));

Console.WriteLine("ingrese una operacion");
string operacion = Console.ReadLine();
if (operacion.IndexOf("+") != -1)
{
    string num1 = operacion.Substring(0,operacion.IndexOf("+"));
    
    string num2 = operacion.Substring(operacion.IndexOf("+")+1);
    
    calculadora(num1,num2);
}