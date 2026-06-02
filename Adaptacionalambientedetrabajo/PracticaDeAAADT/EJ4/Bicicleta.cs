namespace PracticaDeAAADT.EJ4;

public class Bicicleta : IVehiculo
{
    public int Velocidad { get; set; }
    public int Pos { get; set; }

    public Bicicleta()
    {
        Velocidad = 10;
        Pos = 0;
    }

    public void Mover(int minutos)
    {
        Pos += minutos*Velocidad;
    }

    public void Posicion()
    {
        Console.WriteLine("Posicion actual: " + Pos);
    }

    public void ReiniciarPosicion()
    {
        Pos = 0;
    }
}