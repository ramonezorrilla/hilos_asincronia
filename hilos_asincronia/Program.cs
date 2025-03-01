using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tareas
{
    class Program
    {
        static async Task Main(string[] args)
        { 
            var task = new Task(() => // Crear una tarea asincrona con un lambda como parametro
            {
                Thread.Sleep(1000);
                Console.WriteLine("Esta es la tarea asincrona con hilos");
            });
            task.Start();

            var task2 = new Task(() => // Crear una tarea asincrona con un lambda como parametro
            {
                Thread.Sleep(1000);
                Console.WriteLine("Esta es la tarea asincrona con hilos 2");
            });
            task2.Start();
            await  task; // Espera a que la tarea termine
            await task2; // Espera a que la tarea termine
            Console.WriteLine("Esta es la tarea sincrona");
            Console.ReadKey();

        }
    
    
    
    }



}