namespace EJ2;

public class Cronometro
{
    public int Minutos { get; set; }
    public int Segundos { get; set; }

    public Cronometro()
    {
        Minutos = 0;
        Segundos = 0;
    }

    public void Reiniciar()
    {
        Segundos = 0;
        Minutos = 0;
    }

    public void IncrementarTiempo()
    {
        Segundos += 1;
        if (Segundos == 60)
        {
            Segundos = 0;
            Minutos++;
        }
    }

    public void MostrarTiempo()
    {
        Console.WriteLine("Segundos:" + Segundos + " Minutos:" + Minutos);
    }
}