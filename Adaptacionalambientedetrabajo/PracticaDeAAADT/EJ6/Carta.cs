namespace PracticaDeAAADT.EJ6;


public class Carta
    {
        public string Palo { get; init; }
        public int Numero { get; init; }

        public Carta(string palo, int numero)
        {
            Palo = palo;
            Numero = numero;
        }

        public override string ToString()
        {
            return $"{Numero} de {Palo}";
        }
    }