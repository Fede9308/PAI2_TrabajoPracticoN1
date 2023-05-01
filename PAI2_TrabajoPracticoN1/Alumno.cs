public class Alumno
{
    public string Nombre { get; set; }
    public byte Edad { get; set; }

    public void AsignarEdad(byte edad)
    {
        Edad = edad;    
    }
}