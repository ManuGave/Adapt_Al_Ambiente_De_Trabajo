namespace PracticaDeAAADT;

public abstract class Figuras
{
    public string Nombre { get; set; }

    public abstract float Area();

    public abstract float Perimetro();

    public void mostrarDatos()
    {
        Console.WriteLine($"Nombre: {Nombre}", $"Area: {Area()}",$"Perimetro: {Perimetro()}");
    }
}


