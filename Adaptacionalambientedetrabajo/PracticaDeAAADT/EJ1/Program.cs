/*namespace PracticaDeAAADT.EJ1;

class Program
{
    static void Main()
    {
        // Ejemplo de inicialización en Verde
        Semaforo miSemaforo = new Semaforo();
        
        Console.WriteLine("--- Inicio ---");
        miSemaforo.MostrarColor(); // Debería ser Verde

        Console.WriteLine("\n--- Pasan 21 segundos ---");
        miSemaforo.PasoDelTiempo(21);
        miSemaforo.MostrarColor(); // Debería haber cambiado a Amarillo (20s de verde + 1s de amarillo)

        Console.WriteLine("\n--- Modo Intermitente ---");
        miSemaforo.PonerEnIntermitente();
        miSemaforo.MostrarColor(); // Amarillo
        miSemaforo.PasoDelTiempo(1);
        miSemaforo.MostrarColor(); // Apagado
    }
}
*/