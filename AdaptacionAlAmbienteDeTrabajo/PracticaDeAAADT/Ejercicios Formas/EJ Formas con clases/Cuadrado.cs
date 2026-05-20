using System;

namespace PracticaDeAAADT
{
    public class Cuadrado : Figuras
    {
        private float LadoCuadrado { get; set; }

        public Cuadrado(float ladoCuadrado)
        {
            this.LadoCuadrado = ladoCuadrado;
        }
        
        public override float Area()
        {
            return LadoCuadrado * LadoCuadrado;
        }

        public override float Perimetro()
        {
            return LadoCuadrado * 4;
        }
    }
}