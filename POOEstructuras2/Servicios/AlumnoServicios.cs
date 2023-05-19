using POO_Estructura23BM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Estructura23BM.Servicios
{
    public class AlumnoServicio
    {

        // public Alumno Agregar()
        // ----- Response Request
        public Alumno Agregar()
        {
            try
            {
                // Constructor
                Alumno alumno2 = new Alumno()
                {
                    ID = 1,
                    Nombre = "abcde",
                    Apellido = "xyz",
                    Fecha = DateTime.Now,
                    Grado = 3,
                    Promedio = 5.2
                };
                return alumno2;
            }
            catch (Exception ex)
            {
                throw new Exception(" < Sucedio un error > " + ex.Message);
            }
        }

        public void Imprimir(Alumno request)
        {
            try
            {
                Console.WriteLine("ID: " + request.ID);
                Console.WriteLine("Nombre: " + request.Nombre);
                Console.WriteLine("Apellido: " + request.Apellido);
                Console.WriteLine("Fecha de inscripción: " + request.Fecha);
                Console.WriteLine("Grado: " + request.Grado);
            }
            catch (Exception ex)
            {
                throw new Exception(" < Sucedio un error > " + ex.Message);
            }
        }
        #region ---Validar---
        public bool ValidarPromedio(double num)
        {
            bool validar = false;
            if (num >= 7)
            {
                validar = true;
            }
            return validar;
        }
        #endregion
    }
}
