/*

namespace PracticaDeAAADT.EjercicioCuentaBancaria;

public abstract class Cuentas
{
    private float Saldo {get; set; }

    public Cuentas(float saldo)
    {
        this.Saldo = saldo;
    }


    public void MostrarSaldo()
    {
        Console.WriteLine("Tu saldo es de: " + Saldo);
    }

    public abstract float Extraer(float valor);

    public abstract float Depositar(float valor);



}
*/


namespace PracticaDeAAADT.EjercicioCuentaBancaria;

public abstract class CuentaBancaria
{
    private float _saldo;

    public float Saldo 
    {
        get { return _saldo; }
    }

    public CuentaBancaria()
    {
        _saldo = 0; // Ambas cuentas arrancan en 0 según el código de prueba
    }

    public void Depositar(float monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine("El monto a depositar debe ser mayor a cero.");
            return;
        }
        _saldo += monto;
    }

    // Cambiamos a bool para que el Banco sepa si la operación fue exitosa o no
    public abstract bool Extraer(float monto);

    public void MostrarSaldo()
    {
        Console.WriteLine($"Tu saldo es de: {_saldo}");
    }

    // Método auxiliar para que las clases hijas puedan restar plata internamente
    protected void ModificarSaldo(float monto)
    {
        _saldo += monto; 
    }
}