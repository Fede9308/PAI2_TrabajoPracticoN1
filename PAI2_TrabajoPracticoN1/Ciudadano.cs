public class Ciudadano
{
    private string nacionalidad;
    public string Nacionalidad {
        get
        {
            return nacionalidad;
        }
        set
        {
           
            if ( value != "Argentino" )
            {
                Argentino = false;
               
            }
            else
            {
                Argentino=true;
               
            }
            nacionalidad = value;   
            
        } 
    }
    public string Nombre { get; set; }

    public string Apellido { get; set; }

   
    public bool Argentino { get; set; }
        


  
}