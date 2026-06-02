namespace PracticaDeAAADT.EJ4;

public interface IVehiculo
{
    public int Pos {get; set;}
    public int Velocidad {get; set;}

    public void Mover(int tiempo);

    public void Posicion();

    public void ReiniciarPosicion();



}