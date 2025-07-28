namespace EspacioToDo;

public class Tarea {
    public int TareaID {get; set;}
    public string Descripcion {get; set;}
    public int Duracion {get; set;}

    public void Mostrar (){
        System.Console.WriteLine($"Id de la tarea: {TareaID}");
        System.Console.WriteLine($"Descripcion de la tarea: {Descripcion}");
        System.Console.WriteLine($"Duracion de la tarea: {Duracion}");
        System.Console.WriteLine("-----------------");
    }
    public static void Buscar (string palabra, List<Tarea> tareasPendientes){ //funcion static lo que me deja llamarla nombrando a la clase y luego el nombre del metodo
        bool encontrada = false;
        foreach (Tarea tareas in tareasPendientes)
        {
            if (tareas.Descripcion.Contains(palabra,StringComparison.OrdinalIgnoreCase))
            {
                System.Console.WriteLine("La tarea encontrada es: ");
                System.Console.WriteLine($"Id de la tarea: {tareas.TareaID}");
                System.Console.WriteLine($"Descripcion de la tarea: {tareas.Descripcion}");
                System.Console.WriteLine($"Duracion de la tarea: {tareas.Duracion}");
                System.Console.WriteLine("-----------------");
                encontrada = true;
            }

        }
        if (!encontrada)
        {
            System.Console.WriteLine("Tarea no encontrada.");
        }
    }
}