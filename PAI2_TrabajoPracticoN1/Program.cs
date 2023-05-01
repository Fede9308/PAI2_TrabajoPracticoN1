using System;

    class Program
    {
    public static void Main(string[] args)
    {
        Alumno alumno = new Alumno();
        alumno.Nombre = "Federico";
        alumno.AsignarEdad(40);
        Console.WriteLine(alumno.Nombre);
        Console.WriteLine(alumno.Edad);

        Console.WriteLine("");

        Console.WriteLine("N°1 Clase Animal");
        Animal perro = new Animal();
        perro.AsignarEspecie("Canis Familiaris");
        perro.AsignarCantidadDePatas(5);
        perro.AsignarPeso(8);
        Console.WriteLine(perro.Especie);
        Console.WriteLine(perro.CantidadDePatas);
        Console.WriteLine(perro.Peso);

        Console.WriteLine("");

        Console.WriteLine("N°2 Calse Factura");
        Factura factura1 = new Factura();

        factura1.AsignarNumeroFactura(5);
        factura1.AsignarImporte(420.69);
        int factura1NumeroFactura = factura1.MostrarNumeroFactura();
        double factura1Importe = factura1.MostrarImporte();
        Console.WriteLine(factura1NumeroFactura);
        Console.WriteLine(factura1Importe);

        Console.WriteLine("");

        Console.WriteLine("N°3 Clase Contador");
        Contador contador = new Contador();
        contador.IncrementarUno();
        Console.WriteLine(contador.Cuenta);
        contador.Incrementar(10);
        Console.WriteLine(contador.Cuenta);
        contador.Decrementar(5);
        Console.WriteLine(contador.Cuenta);
        contador.InicializarCuenta(30);
        Console.WriteLine(contador.Cuenta);

        Console.WriteLine("");

        Console.WriteLine("N°4 Clase Ciudadano");

        Ciudadano marcelo = new Ciudadano();
        marcelo.Nacionalidad = "Español";
        marcelo.Nombre = "Marcelo";
        marcelo.Apellido = "Juárez";
        Console.WriteLine($"¿Es {marcelo.Nombre} {marcelo.Apellido} argentino? " + marcelo.Argentino);

        Ciudadano silvio = new Ciudadano();
        silvio.Nacionalidad = "Argentino";
        silvio.Nombre = "Silvio";
        silvio.Apellido = "Fama";
        Console.WriteLine($"¿Es {silvio.Nombre} {silvio.Apellido} argentino? " + silvio.Argentino);

        Ciudadano michael = new Ciudadano();
        michael.Nacionalidad = "Japonesa";
        michael.Nombre = "Michael";
        michael.Apellido = "Yukimoto";
        Console.WriteLine($"¿Es {michael.Nombre} {michael.Apellido} argentino? " + michael.Argentino);

        Console.WriteLine("");

        Console.WriteLine("N°5 Clase EstadoAlumno");

        EstadoAlumno estadoAlumno1 = new EstadoAlumno();
        estadoAlumno1.CalificacionUno = 69;
        estadoAlumno1.CalificacionDos = 55;
        estadoAlumno1.CalificacionTres = 60;
        double calificacionFinal = estadoAlumno1.Promedio();

        estadoAlumno1.CrearEstado(calificacionFinal);

        Console.WriteLine("la calificación final del alumno es: " + calificacionFinal);
        Console.WriteLine("El estado del alumno es: " + estadoAlumno1.Estado);

        Console.WriteLine("");

        Console.WriteLine("N°6 Clase Operación");

        Operacion operacion = new Operacion();
        Console.WriteLine("Ingrese el primer número");
        operacion.Atributo1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número");
        operacion.Atributo2 = int.Parse(Console.ReadLine());

        int sumaA1yA2 = operacion.ObtenerSuma();
        int restaA1yA2 = operacion.ObtenerResta();
        int productoA1yA2 = operacion.ObtenerProducto();
        int cocienteA1yA2 = operacion.ObtenerCociente();

        Console.WriteLine("La suma es " + sumaA1yA2);
        Console.WriteLine("La resta es " + restaA1yA2);
        Console.WriteLine("La multiplicación es " + productoA1yA2);
        Console.WriteLine("El cociente es " + cocienteA1yA2);


    }
    }
