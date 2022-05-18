Console.WriteLine("ingrese el numero");
string texto = Console.ReadLine();
int numero = Int32.Parse(texto);
int invertido = 0;
int aux = 0;
if (numero > 0)
{
    while (aux == 0)
    {
        if (numero >= 10)
        {
            invertido = invertido*10 + numero%10;
            numero = numero/10;
        }else
        {
            invertido = invertido*10 + numero;
            aux = 1;
        } 
    }
    
}
Console.Write("Numero invertido = "+invertido);