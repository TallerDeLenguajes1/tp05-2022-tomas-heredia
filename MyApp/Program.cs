﻿using System;
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
Console.WriteLine("Valor minimo: "+ Math.Min(primero1,segundo1));
﻿
int aux =0;
while (aux == 0)
{   Console.WriteLine("Que operacion desea realizar?");
    Console.WriteLine("1_Sumar  2_Restar   3_Dividir   4_Multiplicar   5_Salir");
    texto = Console.ReadLine();
    int operacion = Int32.Parse(texto);
    int resultado = 0;
    if (operacion == 1)
    {
        Console.WriteLine("Ingrese el primer numero");
        texto = Console.ReadLine();
        int primero = Int32.Parse(texto);
        Console.WriteLine("Ingrese el segundo numero");
        texto = Console.ReadLine();
        int segundo = Int32.Parse(texto);
        resultado = primero + segundo;
        Console.WriteLine("El resultado de la suma es: "+resultado);
    }else
    {
        if (operacion == 2)
        {
            Console.WriteLine("Ingrese el primer numero");
            texto = Console.ReadLine();
            int primero = Int32.Parse(texto);
            Console.WriteLine("Ingrese el segundo numero");
            texto = Console.ReadLine();
            int segundo = Int32.Parse(texto);
            resultado = primero - segundo;
            Console.WriteLine("El resultado de la resta es: "+resultado);
        }else
        {
            if (operacion == 3)
            {
                Console.WriteLine("Ingrese el primer numero");
                texto = Console.ReadLine();
                int primero = Int32.Parse(texto);
                int segundo = 0;
                while (segundo == 0)
                {
                   Console.WriteLine("Ingrese el segundo numero");
                    texto = Console.ReadLine();
                    segundo = Int32.Parse(texto); 
                }
                
                resultado = primero / segundo;
                Console.WriteLine("El resultado de la divicion es: "+ resultado);
            }else
            {
                if (operacion == 4)
                {
                    Console.WriteLine("Ingrese el primer numero");
                    texto = Console.ReadLine();
                    int primero = Int32.Parse(texto);
                    Console.WriteLine("Ingrese el segundo numero");
                    texto = Console.ReadLine();
                    int segundo = Int32.Parse(texto);
                    resultado = primero * segundo;
                    Console.WriteLine("El resultado de la multiplicacion es: "+resultado);
                }else
                {
                    aux = 1;
                }
            }
        }
    }
}

