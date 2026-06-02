
namespace PracticaDeAAADT.EjercicioCuentaBancaria;

public class CajaDeAhorro : CuentaBancaria
{
    public override bool Extraer(float monto)
    {
        if (monto <= 0) return false;

        if (Saldo - monto < 0)
        {
            Console.WriteLine("Operación rechazada: No hay dinero disponible.");
            return false;
        }

        ModificarSaldo(-monto);
        return true;
    }
}