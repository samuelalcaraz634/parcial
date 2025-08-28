// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

class Zapato
{
    public string Marca { get; set; }
    public int Talla { get; set; }
    public double Precio { get; set; }
}

class Program
{
    static List<Zapato> inventario = new List<Zapato>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Sistema de Tienda de Zapatos ---");
            Console.WriteLine("1. Agregar zapato");
            Console.WriteLine("2. Ver inventario");
            Console.WriteLine("3. Buscar por talla");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": AgregarZapato(); break;
                case "2": MostrarInventario(); break;
                case "3": BuscarPorTalla(); break;
                case "4": return;
                default: Console.WriteLine("Opción no válida"); break;
            }
        }
    }

    static void AgregarZapato()
    {
        Console.Write("Marca: ");
        string marca = Console.ReadLine();
        Console.Write("Talla: ");
        int talla = int.Parse(Console.ReadLine());
        Console.Write("Precio: ");
        double precio = double.Parse(Console.ReadLine());

        inventario.Add(new Zapato { Marca = marca, Talla = talla, Precio = precio });
        Console.WriteLine("✅ Zapato agregado con éxito.");
    }

    static void MostrarInventario()
    {
        Console.WriteLine("\n--- Inventario ---");
        foreach (var z in inventario)
        {
            Console.WriteLine($"Marca: {z.Marca}, Talla: {z.Talla}, Precio: ${z.Precio}");
        }
    }

    static void BuscarPorTalla()
    {
        Console.Write("Ingrese la talla a buscar: ");
        int talla = int.Parse(Console.ReadLine());

        var resultados = inventario.FindAll(z => z.Talla == talla);
        if (resultados.Count == 0)
        {
            Console.WriteLine("No se encontraron zapatos con esa talla.");
        }
        else
        {
            foreach (var z in resultados)
            {
                Console.WriteLine($"Marca: {z.Marca}, Talla: {z.Talla}, Precio: ${z.Precio}");
            }
        }
    }
}
