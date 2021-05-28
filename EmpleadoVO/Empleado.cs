using System;

namespace EmpleadoVO
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public string Pais { get; set; }

        public Empleado(int id, string nombre, string apellido, DateTime fechaNac, string pais)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            FechaNac = fechaNac;
            Pais = pais;
        }
    }
}
