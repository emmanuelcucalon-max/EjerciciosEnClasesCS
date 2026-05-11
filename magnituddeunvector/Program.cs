double[] Vector1 = new double [5];
double SumaCuadrados = 0;
double Magnitud = 0;
Console.WriteLine("Ingrese los elementos del vector:");
for (int i = 0; i < Vector1.Length; i++)
{
    try
    {
        Console.Write($"Elemento {i + 1}: ");
        Vector1[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        i--; // Decrementar el índice para volver a solicitar el mismo elemento
    }

}
for (int i=0; i<Vector1.Length; i++)
{
    Vector1[i]= Math.Pow(Vector1[i], 2);
}
for (int i=0; i<Vector1.Length; i++)
{
    SumaCuadrados += Vector1[i];
}
for (int i=0; i<Vector1.Length; i++)
{
    Magnitud = Math.Sqrt(SumaCuadrados);
}
Console.WriteLine($"La magnitud del vector es: {Magnitud}");
