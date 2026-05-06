int edad = 0;
Console.WriteLine("Ingrese su edad:");
edad = int.Parse(Console.ReadLine()!);

Console.WriteLine("Usted es: " + (edad >= 18 ? "Mayor de edad" : "Menor de edad"));