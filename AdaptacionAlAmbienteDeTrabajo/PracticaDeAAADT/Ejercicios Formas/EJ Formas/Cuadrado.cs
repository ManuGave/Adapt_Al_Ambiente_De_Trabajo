using System.Security.Cryptography;

namespace PracticaDeAAADT
{

    public class CuadradoSC : IFiguras
    {
        private float LadoCuadrado{ get; set; }
        
        public CuadradoSC(float ladoCuadrado)
        {
            this.LadoCuadrado = ladoCuadrado;

        }

        public float Area()
        {
            return LadoCuadrado * LadoCuadrado;
        }

        public float Perimetro()
        {
            return (LadoCuadrado * 4);
        }
    }

}