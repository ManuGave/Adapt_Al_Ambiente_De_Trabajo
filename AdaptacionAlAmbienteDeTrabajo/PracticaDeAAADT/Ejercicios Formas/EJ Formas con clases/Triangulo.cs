using System.Security.Cryptography;

namespace  PracticaDeAAADT
{

        
        
    public class Triangulo : IFiguras
    {
        private float baseTriangulo { get; set; }
        private float alturaTriangulo { get; set; }

        public Triangulo(float baseTriangulo, float alturaTriangulo)
        {
            this.baseTriangulo = alturaTriangulo;
            this.baseTriangulo = baseTriangulo;

        }

        public float Area()
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }

        public float Perimetro()
        {
            float hipotenusa = alturaTriangulo * alturaTriangulo + (baseTriangulo + baseTriangulo) / 2;
            return hipotenusa * 2 + baseTriangulo;
            //Supongo que es isoceles qsy
        }
    }
}