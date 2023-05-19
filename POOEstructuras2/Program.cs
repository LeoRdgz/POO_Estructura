using POO_Estructura23BM.Entities;
using POO_Estructura23BM.Servicios;
using System;

namespace POO_Estructura23BM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlumnoServicio alumnoServicio = new AlumnoServicio();

            // Alumno alumno = alumnoServicio.Agregar();
            //var res = alumnoServicio.Agregar();
            Alumno request = alumnoServicio.Agregar();

            //if (alumnoServicio.ValidarPromedio(request.Promedio))
            //{
            //    Console.WriteLine("Calificación aprobada");
            //    alumnoServicio.Imprimir(request);
            //}
            //else
            //{
            //    Console.WriteLine("No aprobado");
            //}

        }
    }
}
