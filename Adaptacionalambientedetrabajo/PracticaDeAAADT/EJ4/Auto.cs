namespace PracticaDeAAADT.EJ4;

public class Auto : IVehiculo
{
    public int Velocidad { get; set; }
    public int Pos { get; set; }

    public Auto(int velocidad)
    {
        this.Velocidad = velocidad;
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