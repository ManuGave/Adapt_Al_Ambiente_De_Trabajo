/*using System;

namespace  EJ2
{
    

public class Semaforo
{
    // Definición de tiempos en segundos
    private const int TIEMPO_ROJO = 30;
    private const int TIEMPO_ROJO_AMARILLO = 2;
    private const int TIEMPO_VERDE = 20;
    private const int TIEMPO_AMARILLO = 2;
    private const int TOTAL_CICLO = TIEMPO_ROJO + TIEMPO_ROJO_AMARILLO + TIEMPO_VERDE + TIEMPO_AMARILLO;

    private int _tiempoAcumulado;
    private bool _esIntermitente;

    public Semaforo(string colorInicial)
    {
        _esIntermitente = false;
        SetColorInicial(colorInicial);
    }

    private void SetColorInicial(string color)
    {
        // Normalizamos el texto para evitar errores de mayúsculas/minúsculas
        switch (color.Trim().ToLower())
        {
            case "rojo":
                _tiempoAcumulado = 0;
                break;
            case "rojo + amarillo":
            case "rojo amarillo":
                _tiempoAcumulado = TIEMPO_ROJO;
                break;
            case "verde":
                _tiempoAcumulado = TIEMPO_ROJO + TIEMPO_ROJO_AMARILLO;
                break;
            case "amarillo":
                _tiempoAcumulado = TIEMPO_ROJO + TIEMPO_ROJO_AMARILLO + TIEMPO_VERDE;
                break;
            default:
                Console.WriteLine($"Color '{color}' no válido. Iniciando en Rojo por defecto.");
                _tiempoAcumulado = 0;
                break;
        }
    }

    public void PasoDelTiempo(int segundos)
    {
        _tiempoAcumulado += segundos;
        
        // Si no es intermitente, mantenemos el tiempo dentro del ciclo de 54 segundos
        if (!_esIntermitente)
        {
            _tiempoAcumulado %= TOTAL_CICLO;
        }
    }

    public void MostrarColor()
    {
        if (_esIntermitente)
        {
            // Lógica de parpadeo: par = Amarillo, impar = Apagado
            if (_tiempoAcumulado % 2 == 0)
                Console.WriteLine("Color actual: Amarillo (Intermitente)");
            else
                Console.WriteLine("Color actual: Apagado");
            return;
        }

        // Lógica de secuencia normal
        if (_tiempoAcumulado < TIEMPO_ROJO)
            Console.WriteLine("Color actual: Rojo");
        else if (_tiempoAcumulado < (TIEMPO_ROJO + TIEMPO_ROJO_AMARILLO))
            Console.WriteLine("Color actual: Rojo + Amarillo");
        else if (_tiempoAcumulado < (TIEMPO_ROJO + TIEMPO_ROJO_AMARILLO + TIEMPO_VERDE))
            Console.WriteLine("Color actual: Verde");
        else
            Console.WriteLine("Color actual: Amarillo");
    }

    public void PonerEnIntermitente()
    {
        _esIntermitente = true;
        _tiempoAcumulado = 0; // Reinicia el contador para el ritmo del parpadeo
        Console.WriteLine("Semaforo puesto en MODO INTERMITENTE.");
    }

    public void SacarDeIntermitente()
    {
        _esIntermitente = false;
        _tiempoAcumulado = 0; // Al salir, vuelve a Rojo según la lógica de inicio
        Console.WriteLine("Semaforo vuelto a MODO NORMAL (Rojo).");
    }
}

// Clase de prueba
class Program
{
    static void Main()
    {
        // Ejemplo de inicialización en Verde
        Semaforo miSemaforo = new Semaforo("Verde");
        
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
}
*/