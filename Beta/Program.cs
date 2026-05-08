int[] numero= new int[5];
int suma = 0;
double Promedio = 0;

for(int i=0;i<numero.Length;i++)
{
    try
    {
        Console.Write("Digite el valor"+(i+1)+":");
        numero[i]=int.Parse(Console.ReadLine()!);
    }
    catch(FormatException)
    {
        Console.WriteLine("Escriba un numero en el formato correcto");
        i--;
    }
    foreach(int Numero in numero)
    {
        suma+=Numero;
    }
}