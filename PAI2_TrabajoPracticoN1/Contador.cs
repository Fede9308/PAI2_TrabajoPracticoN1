public class Contador
{
  public int Cuenta { get; set; }

  public void IncrementarUno()
    {
        Cuenta += 1;
    }
    public void DecrementarUno()
    {
        Cuenta -= 1;
    }

    public void Incrementar(int cantidad)
    {
        Cuenta += cantidad;
    }

    public void Decrementar(int cantidad)
    {
        Cuenta -= cantidad;
    }
    
    public void InicializarCuenta(int cantidad)
    {
        if (Cuenta != 0)
        {
            Console.WriteLine("No se puede asignar el valor por que la cuenta ya fue inicializada");
        }
        else {
            Cuenta = cantidad;
        }
        
    }
}