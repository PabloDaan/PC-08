using System;

class ClaseSemana8
{
    static void Main()
    {
        int nota1 = 10, nota2 = 20, nota3 = 30, nota4 = 40;
        float precio = 12.20f;
        double distancia = 12345.6789;
        char inicial = 'A';
        string nombre = "Andres Alvarado";
        bool esMayorDeEdad = true;
        int edad = 25;

        Console.WriteLine($"Nombre: {nombre}, Edad: {edad}");

        Console.WriteLine($"Nombre: {nombre}, Nota1: {nota1}");

        Console.WriteLine(string.Format("Nombre: {0}, Nota3: {1}", nombre, nota3));

        Console.WriteLine($"Precio: {precio:F2}");

        string entrada = "123";
        if (int.TryParse(entrada, out int numero))
        {
            Console.WriteLine(numero);
        }
        else
        {
            Console.WriteLine("Conversión fallida.");
        }
    }
}
// Pablo Daniel Ajanel Navarro 1279925
