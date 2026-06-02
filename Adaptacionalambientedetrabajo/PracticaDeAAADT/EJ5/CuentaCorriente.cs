
namespace PracticaDeAAADT.EjercicioCuentaBancaria;

public class CuentaCorriente : CuentaBancaria
{
    public float LimiteDescubierto { get; set; }


    public CuentaCorriente(float limiteDescubierto) : base()
    {
        this.LimiteDescubierto = limiteDescubierto;
    }

    public override bool Extraer(float monto)
    {
        if (monto <= 0) return false;


        if (Saldo - monto < -LimiteDescubierto)
        {
            Console.WriteLine("Operación rechazada: Supera el límite de descubierto.");
            return false;
        }

        ModificarSaldo(-monto);
        return true;
    }
}