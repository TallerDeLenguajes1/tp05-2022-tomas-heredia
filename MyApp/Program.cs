
int aux =0;
while (aux == 0)
{   Console.WriteLine("Que operacion desea realizar?");
    Console.WriteLine("1_Sumar  2_Restar   3_Dividir   4_Multiplicar   5_Salir");
    string texto = Console.ReadLine();
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

