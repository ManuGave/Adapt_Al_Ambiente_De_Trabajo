using System.Security.Cryptography;

namespace PracticaDeAAADT
{

    public class CirculoSC : IFiguras
    {
        private float radio { get; set; }

        public CirculoSC(float radio)
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