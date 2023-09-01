using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la ruta del directorio:");
        string directorio = Console.ReadLine();

        if (Directory.Exists(directorio))
        {
            Console.WriteLine("Archivos en el directorio y sus subdirectorios:");
            ListarArchivosRecursivamente(directorio);
        }
        else
        {
            Console.WriteLine("El directorio no existe.");
        }

        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }

    static void ListarArchivosRecursivamente(string directorio)
    {
        string[] archivos = Directory.GetFiles(directorio);

        foreach (string archivo in archivos)
        {
            string nombreArchivo = Path.GetFileName(archivo);
            string extension = Path.GetExtension(archivo);
            Console.WriteLine($"Archivo: {nombreArchivo}");
            Console.WriteLine($"Extensión: {extension}");
            Console.WriteLine(new string('-', 30)); // Línea separadora
        }

        string[] subdirectorios = Directory.GetDirectories(directorio);

        foreach (string subdirectorio in subdirectorios)
        {
            ListarArchivosRecursivamente(subdirectorio);
        }
    }
}
