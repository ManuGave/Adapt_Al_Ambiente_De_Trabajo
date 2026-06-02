/*
using PracticaDeAAADT.EJ3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Probando el Sistema de Jugadores ===\n");
        
        List<IJugadores> equipo = new List<IJugadores>();
        
        Profesional Messi = new Profesional(); 
        Amateur Martin = new Amateur();       

        equipo.Add(Messi);
        equipo.Add(Martin);


        Console.WriteLine("--- Vuelta 1: Todos corren 15 minutos ---");
        foreach (var jugador in equipo)
        {

            bool puedeSeguir = jugador.correr(15); 
            

            Console.WriteLine($"Jugador [{jugador.GetType().Name}]: ¿Pudo terminar la carrera? -> {puedeSeguir}");
            Console.WriteLine($"¿Está cansado?: {jugador.cansado()}\n");
        }



        Console.WriteLine("--- Vuelta 2: Todos corren 10 minutos más ---");
        foreach (var jugador in equipo)
        {
            bool puedeSeguir = jugador.correr(10);
            Console.WriteLine($"Jugador [{jugador.GetType().Name}]: ¿Pudo terminar la carrera? -> {puedeSeguir}");
            Console.WriteLine($"¿Está cansado?: {jugador.cansado()}\n");
        }


        Console.WriteLine("--- Tiempo de recuperación para el Amateur ---");
        Console.WriteLine($"Amateur antes de descansar: ¿Cansado? {Martin.cansado()}");
        

        Martin.descansar(15);
        Console.WriteLine("El Amateur descansa 15 minutos...");
        Console.WriteLine($"Amateur después de descansar: ¿Cansado? {Martin.cansado()}");

        Console.WriteLine("\nPrueba de entrenamiento finalizada. Presioná cualquier tecla para salir.");
        Console.ReadKey();
    }
}

*/