public class EstadoAlumno
{
    public int CalificacionUno { get; set; }
    public int CalificacionDos { get; set; }
    public int CalificacionTres { get; set; }

    private string estado;
    public string Estado {
        get
        {
            return estado;
        }

        set
        {
            if((value == "promocionado") || (value == "regular") || (value == "libre"))
            {
                estado = value; 
            }
            else
            {
                throw new ArgumentNullException(nameof(value));
            }
        }
    }

    public double Promedio() 
    {  
         double promedioCalificaciones = (CalificacionUno + CalificacionDos + CalificacionTres) / 3;
         return promedioCalificaciones;
    }
      
    public void CrearEstado(double promedio)
    {
        if (promedio >= 70){
            Estado = "promocionado";
        }
        else if (promedio >= 55 && promedio < 70)
        {
            Estado = "regular";

        }
        else
        {
            Estado = "libre";
        }
    }

}