using System.Security.Cryptography;

namespace PracticaDeAAADT
{

    public class Circulo : IFiguras
    {
        private float radio { get; set; }

        public Circulo(float radio)
        {
            this.radio = radio;
        }

        public float Area()
        {
            return Single.Pi * (radio * radio);
        }

        public float Perimetro()
        {
            return Single.Pi * 2 * radio;
        }
    }

}