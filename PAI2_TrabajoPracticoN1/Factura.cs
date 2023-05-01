public class Factura
{
   public int Fecha { get; set; }  
   public double Importe { get; set; }
   public int NumeroFactura { get; set; }

   public int CantidadItems { get; set; }

    public void AsignarNumeroFactura (int numero)
    {
        NumeroFactura = numero; 
    }
    public void AsignarImporte(double importe)
    {
        Importe = importe;  
    }

    public int MostrarNumeroFactura()
    {
        return NumeroFactura;
    }

    public double MostrarImporte()
    {
        return Importe;
    }


}