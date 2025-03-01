using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tareas
{
    class Program
    {
        static void Main(string[] args)
        { 
            var task = new Task(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Esta es la tarea asincrona con hilos");
            });
            task.Start();

            Console.WriteLine("Esta es la tarea sincrona");
            Console.ReadKey();

        }
    
    
    
    }



}