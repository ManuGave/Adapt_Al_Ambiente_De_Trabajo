namespace PracticaDeAAADT.EJ3;

public interface IJugadores
{
    public int minutosRestantes { get; set; }

    public bool correr(int minutos);
    
    public bool cansado();

    void descansar(int minutos);
}