using System;
using System.Diagnostics;
using System.Linq;


namespace Negocio.Paralilismo
{
    public class PruebaHilos
    {
        public void Observar()
        {
            //Obtenemos la lista de los procesos de nuestra máquina
            var procedimiento = from proc in Process.GetProcesses()
                                orderby proc.Id
                                select proc;
            //Recorre los procesos encontrados
            foreach (var proceso in procedimiento)
            {
                Console.WriteLine("PID: {0}, Nombre: {1}", proceso.Id, proceso.ProcessName);
            }
            Console.WriteLine("------------------------------------");
            //Obtener un proceso via PID
            Process miProceso = null;
            int pidChrome = 1000;
            try
            {
                miProceso = Process.GetProcessById(pidChrome);
                Console.WriteLine("PID: {0}, Nombre: {1}", miProceso.Id, miProceso.ProcessName);
                //Aqui tenemos una lista de hilos en el proceso
                ProcessThreadCollection hilos = miProceso.Threads;
                //Aqui recorremos los hilos encontrados
                foreach (ProcessThread hilo in hilos)
                {
                    Console.WriteLine("Id del hilo: {0}, Inicio: {1}, Prioridad: {2}",
                        hilo.Id, hilo.StartTime, hilo.PriorityLevel);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            Console.WriteLine("------------------------------------");
            //Un modulo es un .dll o .exe alojado en un proceso
            //Un sistema de 32 bits no puede acceder a los modulos de 64, se debe configurar
            //El proyecto en donde se esta trabajando, en el apartado Any CPU
            Console.WriteLine("Los modulos del proceso---{0}---son: ", miProceso.ProcessName);
            //Obtenemos los modulos del proyecto
            ProcessModuleCollection modulos = miProceso.Modules;
            foreach (ProcessModule modulo in modulos)
            {
                Console.WriteLine("Módulo: {0}", modulo.ModuleName);
            }
            Console.WriteLine(".......");
        }
    }
}

