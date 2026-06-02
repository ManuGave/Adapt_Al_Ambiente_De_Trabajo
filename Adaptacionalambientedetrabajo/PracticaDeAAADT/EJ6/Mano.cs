namespace PracticaDeAAADT.EJ6;

public class Mano
{
    private List<Carta> cartasEnMano;

    public Mano()
    {
        cartasEnMano = new List<Carta>();
    }

    public void recibirCarta(Carta carta)
    {
        if (carta != null)
        {
            cartasEnMano.Add(carta);
        }
    }

    public void mostrarMano()
    {
        Console.WriteLine("Cartas en la mano:");
        foreach (var carta in cartasEnMano)
        {
            Console.WriteLine($"- {carta}");
        }
        Console.WriteLine();
    }

    public int cantidadDeCartas()
    {
        return cartasEnMano.Count;
    }
}