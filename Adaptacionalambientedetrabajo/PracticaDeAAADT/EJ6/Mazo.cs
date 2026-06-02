namespace PracticaDeAAADT.EJ6;

public class Mazo
{
    private List<Carta> cartas;
    private Random random;

    public Mazo()
    {
        cartas = new List<Carta>();
        random = new Random();
        string[] palos = { "Espadas", "Bastos", "Oros", "Copas" };
        
        foreach (var palo in palos)
        {
            for (int i = 1; i <= 12; i++)
            {
                if (i == 8 || i == 9) continue; 
                cartas.Add(new Carta(palo, i));
            }
        }
    }

    public void barajar()
    {

        int n = cartas.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            Carta valor = cartas[k];
            cartas[k] = cartas[n];
            cartas[n] = valor;
        }
    }

    public Carta robarCarta()
    {
        if (cartas.Count == 0)
        {
            throw new InvalidOperationException("Error: El mazo está vacío. No quedan cartas para robar.");
        }
        
        int indexTope = cartas.Count - 1;
        Carta cartaRobada = cartas[indexTope];
        cartas.RemoveAt(indexTope);
            
        return cartaRobada;
    }

    public int cuantasCartasQuedan()
    {
        return cartas.Count;
    }
}