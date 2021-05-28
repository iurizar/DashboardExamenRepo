using ComercialVO;
using EmpleadoVO;
using GestorDAL;
using System;
using System.Collections.Generic;
using VentasVO;

namespace GestorBLL
{
    public class Controlador
    {
        private Comercial com;
        private int selec;

        public Controlador(Comercial comercial)
        {
            com = comercial;
        }

        public Controlador(int seleccion)
        {
            selec = seleccion;
        }

        public Controlador() { }

        public List<Empleado> GetEmpleados()
        {
            return RecuperaEmpleados();
        }

        public Comercial RecuperaComercial()
        {
            return LeeComercial();
        }

        public Comercial RecuperaVentas()
        {
            return LeeVentas();
        }

        private List<Empleado> RecuperaEmpleados()
        {
            AccesoSQLServer connBBDD = new AccesoSQLServer();
            return connBBDD.ConsultaEmpleados();
        }

        private Comercial LeeVentas()
        {
            AccesoBBDD bbdd = new AccesoBBDD(com);
            return bbdd.GetVentas();
            
        }

        private Comercial LeeComercial()
        {
            AccesoBBDD bbdd = new AccesoBBDD(selec);
            com = bbdd.GetComercial();
            return com;
        }
    }
}
