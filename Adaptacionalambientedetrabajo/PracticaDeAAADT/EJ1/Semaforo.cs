namespace PracticaDeAAADT.EJ1;

public class Semaforo
{
    public string color { get; set; }
    public int tiempo { get; set; }
    public bool intermitente { get; set; }


    public Semaforo()
    {
        color = "Verde";
        tiempo = 0;
        intermitente = false;
    }


    public void PasoDelTiempo(int tiempoPasado)
    {

        if (intermitente)
        {
            this.tiempo += tiempoPasado;


            if (tiempoPasado % 2 != 0)
            {
                this.color = (this.color == "Apagado") ? "Amarillo" : "Apagado";
            }
            return; 
        }
        
        this.tiempo += tiempoPasado;
        int momentoActual = this.tiempo % 54;

        if (momentoActual >= 0 && momentoActual <= 29)
        {
            this.color = "Rojo";
        }
        else if (momentoActual >= 30 && momentoActual <= 32)
        {
            this.color = "Rojo + Amarillo";
        }
        else if (momentoActual >= 33 && momentoActual <= 52)
        {
            this.color = "Verde";
        }
        else if (momentoActual == 53)
        {
            this.color = "Amarillo";
        }
    }
    
    public void MostrarColor()
    {
        Console.WriteLine("Tu semáforo está en color: " + this.color);
    }

    public void PonerEnIntermitente()
    {
        this.intermitente = true;
        this.color = "Amarillo";
    }

    public void SacarDeIntermitente()
    {
        this.intermitente = false;
    }
}