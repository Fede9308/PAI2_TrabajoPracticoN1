public class Operacion
{
    public int Atributo1 { get; set; }

    private int atributo2;
    public int Atributo2 {
        get
        {
            return atributo2;
        }
        set
        {
            if (value == 0)
            {
                throw new ArgumentNullException(nameof(value));
            }
            else
            {
                atributo2 = value;  
            }
        }
    }
    public int ObtenerSuma()
    {
        return Atributo1 + Atributo2;
    }
    public int ObtenerResta()
    {
        return Atributo1 - Atributo2;
    }
    public int ObtenerProducto()
    {
        return Atributo1 * Atributo2;   
    }
    public int ObtenerCociente()
    {
        return Atributo1 % Atributo2;
    }
}