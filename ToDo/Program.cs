// See https://aka.ms/new-console-template for more information
using System;
using EspacioToDo;
using System.Collections.Generic;
Random rand = new Random(); // necesario para numeros randoms
List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();

for (int i = 0; i < 4; i++)
{
    Tarea Ntarea = new Tarea();
    Ntarea.TareaID = i;
    System.Console.WriteLine("Escribra una descripcion de la tarea a realizar");
    Ntarea.Descripcion = Console.ReadLine();
    Ntarea.Duracion = rand.Next(10,101); // el 101 excluido
    tareasPendientes.Add(Ntarea);
}
foreach (Tarea tareas in tareasPendientes)
{
    tareas.Mostrar();
}

System.Console.WriteLine("Por favor ingresa el id de la tarea que quieres pasar a la lista de realizadas: ");
string num = Console.ReadLine();
int IdContr;
bool controlId = int.TryParse(num, out IdContr);

if (!controlId || IdContr >= tareasPendientes.Count )
{
    while (!controlId || IdContr >= tareasPendientes.Count)
    {
        System.Console.WriteLine("Porfavor ingrese un id existente");
        num = Console.ReadLine();
        controlId = int.TryParse(num, out IdContr);
    }
}

List<Tarea> tareasCoincidentes = tareasPendientes.FindAll(t => t.TareaID == IdContr); //creo una nueva lista donde contenga todas las tareas de tareasPendientes usando FindA. dentro puedo poner la condicion que tiene que cumplir

foreach (Tarea tareas in tareasCoincidentes)
{
    tareasRealizadas.Add(tareas); //agrego a la lista de realizadas
    tareasPendientes.Remove(tareas); // elimino de la lista de pendientes
}

System.Console.WriteLine("Ingrese la palabra para buscar la tarea pendiente: ");
string palabra = Console.ReadLine();

Tarea.Buscar(palabra, tareasPendientes); // llamo a la funcion buscar 
System.Console.WriteLine("Todas las tareas Pendientes");
foreach (Tarea tareas in tareasPendientes)
{
    tareas.Mostrar();
}
System.Console.WriteLine("Todas las tareas Realizadas");
foreach (Tarea tareas in tareasRealizadas)
{
    tareas.Mostrar();
}
