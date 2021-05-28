using System;
using System.Collections.Generic;
using VentasVO;

namespace ComercialVO
{
    public class Comercial
    {
        private int id;
        private string nombre;
        private string apellido;
        private string localidad;
        private int edad;
        private List<Ventas> listaVentas;


        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public int Edad { get => edad; set => edad = value; }
        public List<Ventas> ListaVentas { get => listaVentas; set => listaVentas = value; }


        public Comercial(int id, string nombre, string apellido, string localidad, int edad)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Localidad = localidad;
            Edad = edad;
        }
    }
}
