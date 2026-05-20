using System.Security.Cryptography;

namespace PracticaDeAAADT
{

    public class RectanguloSC : IFiguras
    {
        private float baseRectangulo { get; set; }
        private float alturaRectangulo { get; set; }

        public RectanguloSC(float baseRectangulo, float alturaRectangulo)
        {
            this.baseRectangulo = baseRectangulo;
            this.alturaRectangulo = alturaRectangulo;

        }

        public float Area()
        {
            return baseRectangulo * alturaRectangulo;
        }

        public float Perimetro()
        {
            return (baseRectangulo + alturaRectangulo) * 2;
        }
    }

}