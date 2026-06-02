namespace PracticaDeAAADT.EJ3;

public class Profesional : IJugadores
{
    public int minutosRestantes { get; set; }

    public Profesional()
    {
        minutosRestantes = 40;
    }
    
    public bool correr(int minutos)
    {
        minutosRestantes -= minutos;
        return (minutosRestantes >= 0);
    }

    public bool cansado()
    {
        return (minutosRestantes <= 0);
    }
    
    public void descansar(int minutos)
    {
        minutosRestantes += minutos;
    }
    
    
}