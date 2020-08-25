using System;
using Negocio.Paralilismo;

namespace ParalelismoAlejo
{
    class Program
    {
        static void Main(string[] args)
        {
            var Documento = new Documento();
            Console.WriteLine("AppendLines-WriteAllLines-Lee las lineas de un archivo y las agrega a otro nuevo.");
            Console.WriteLine("Ejercicio Secuencial con For/ ,mirar los archivos dias/fecha");
            Documento.AgregarLineas();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Ejercicio con Parallel.Foreach--Traer archivos");
            Documento.TraerArchivos();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Ejercicio con Secuenciasl con Foreach--Traer directorios");
            Documento.AtraerDirectorios();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Ejercicio con Secuencial Foreach--Traer unidades");
            Documento.TraerUnidades();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Hilos de procesos en nuestras máquinas");
            var PruebaHilos = new PruebaHilos();
            PruebaHilos.Observar();
        }
    }
}
