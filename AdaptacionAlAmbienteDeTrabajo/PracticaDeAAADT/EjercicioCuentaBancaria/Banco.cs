
namespace PracticaDeAAADT.EjercicioCuentaBancaria;

public class Banco
{
    public List<CuentaBancaria> ListaDeCuentas { get; set; } 

    public Banco()
    {
        this.ListaDeCuentas = new List<CuentaBancaria>();
    }

    public void AgregarCuenta(CuentaBancaria cuenta)
    {
        ListaDeCuentas.Add(cuenta);
    }

    public void Transferir(CuentaBancaria origen, CuentaBancaria destino, float monto)
    {
        if (!ListaDeCuentas.Contains(origen) || !ListaDeCuentas.Contains(destino))
        {
            Console.WriteLine("Transferencia rechazada: Una o ambas cuentas no están registradas en el banco.");
            return;
        }


        if (monto <= 0)
        {
            Console.WriteLine("Transferencia rechazada: El monto debe ser positivo.");
            return;
        }



        if (origen.Extraer(monto))
        {
            destino.Depositar(monto);
            Console.WriteLine($"Transferencia exitosa de {monto} realizada.");
        }
        else
        {
            Console.WriteLine("Transferencia rechazada: La cuenta de origen no pudo realizar la extracción.");
        }
    }
}