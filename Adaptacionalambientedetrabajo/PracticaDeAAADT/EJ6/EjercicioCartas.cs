namespace PracticaDeAAADT.EJ6;


    
    class Program
    {
        static void Main(string[] args)
        {
            Mazo mazo = new Mazo();
            mazo.barajar();
            
            Mano jugador1 = new Mano();
            Mano jugador2 = new Mano();
            

            for (int i = 0; i < 3; i++) 
            {
                jugador1.recibirCarta(mazo.robarCarta());
                jugador2.recibirCarta(mazo.robarCarta());
            }

            Console.WriteLine("=== JUGADOR 1 ===");
            jugador1.mostrarMano();

            Console.WriteLine("=== JUGADOR 2 ===");
            jugador2.mostrarMano();

            Console.Write("Cartas restantes en el mazo: ");
            Console.WriteLine(mazo.cuantasCartasQuedan());

            Console.ReadKey();
        }
    }
