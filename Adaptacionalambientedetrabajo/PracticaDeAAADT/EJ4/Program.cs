/*using PracticaDeAAADT.EJ4;

class Program
{
    static void Main(string[] args)
    {
        List<IVehiculo> cochera = new List<IVehiculo>();

        Camion miCamion = new Camion();
        Bicicleta miBici = new Bicicleta();
        Auto miAuto = new Auto(60);

        cochera.Add(miCamion);
        cochera.Add(miBici);
        cochera.Add(miAuto);

        Console.WriteLine("--- Estado Inicial ---");
        foreach (var v in cochera)
        {
            Console.Write($"{v.GetType().Name} -> ");
            v.Posicion();
        }

        Console.WriteLine("\nMoviendo todos los vehículos por 10 minutos...");
        foreach (var v in cochera)
        {
            v.Mover(10);
        }

        Console.WriteLine("\n--- Posición Post Movimiento ---");
        foreach (var v in cochera)
        {
            Console.Write($"{v.GetType().Name} (Vel: {v.Velocidad}) -> ");
            v.Posicion();
        }

        Console.WriteLine("\nMoviendo el Auto 5 minutos más...");
        miAuto.Mover(5);
        Console.Write("Auto -> ");
        miAuto.Posicion();

        Console.WriteLine("\nReiniciando posiciones...");
        foreach (var v in cochera)
        {
            v.ReiniciarPosicion();
        }

        Console.WriteLine("\n--- Estado Final ---");
        foreach (var v in cochera)
        {
            Console.Write($"{v.GetType().Name} -> ");
            v.Posicion();
        }

        Console.ReadKey();
    }
}

*/