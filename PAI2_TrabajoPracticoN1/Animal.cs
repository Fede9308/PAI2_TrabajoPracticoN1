public class Animal
{
   public string Especie { get; set; }
   public int CantidadDePatas { get; set; }

   public double Peso { get; set; }

    public void AsignarEspecie(string especie)
    {
        Especie = especie;
    }
    public void AsignarCantidadDePatas(int patas)
    {
        CantidadDePatas = patas;
    }
    public void AsignarPeso(double peso)
    {
        Peso = peso;
    }
}