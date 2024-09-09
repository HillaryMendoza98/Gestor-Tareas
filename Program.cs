

using System;
using System.Collections.Generic;

class GestorDeTareas
{
    static void Main()
    {
        List<string> tareas = new List<string>();
        int opcion;

        do
        {
            Console.WriteLine("\n1) Añadir tarea\n2) Ver tareas\n3) Eliminar tarea\n4) Salir");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese una nueva tarea: ");
                    tareas.Add(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Tareas pendientes:");
                    for (int i = 0; i < tareas.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {tareas[i]}");
                    }
                    break;
                case 3:
                    Console.Write("Ingrese el número de la tarea a eliminar: ");
                    int eliminar = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (eliminar >= 0 && eliminar < tareas.Count)
                        tareas.RemoveAt(eliminar);
                    else
                        Console.WriteLine("Número de tarea no válido.");
                    break;
                case 4:
                    Console.WriteLine("Saliendo del gestor de tareas...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != 4);
    }
}
