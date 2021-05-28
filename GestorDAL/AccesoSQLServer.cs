using EmpleadoVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GestorDAL
{
    public class AccesoSQLServer
    {
        //Consulta: EmployeeID, FirstName, LastName, BirthDate, Country
        private const string CONSULTA = "SELECT EmployeeID, FirstName, LastName,BirthDate,Country FROM dbo.Employees";

        public AccesoSQLServer()
        {

        }

        public List<Empleado> ConsultaEmpleados()
        {
            return EjecutaConsulta();
        }

        private List<Empleado> EjecutaConsulta()
        {
            SqlConnection conn = null;
            SqlCommand cmmd = null;
            SqlDataReader reader = null;
            List<Empleado> empleados = new List<Empleado>();

            ConnectionManager connectionManager = new ConnectionManager();

            try
            {
                conn = connectionManager.ConectaBBDD();
                conn.Open();
                cmmd = new SqlCommand(CONSULTA, conn);
                reader = cmmd.ExecuteReader();

                while(reader.Read())
                {
                    int id;
                    string nombre, apellido, pais;
                    DateTime fechaNac;

                    id = reader.GetInt32(0);
                    nombre = reader.GetString(1);
                    apellido = reader.GetString(2);
                    fechaNac = reader.GetDateTime(3);
                    pais = reader.GetString(4);

                    Empleado unEmpleado = new Empleado(id, nombre, apellido, fechaNac, pais);
                    empleados.Add(unEmpleado);
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            } finally
            {
                cmmd.Dispose();
                reader.Close();
                conn.Close();
            }

            return empleados;
        }
    }
}
