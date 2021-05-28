using ComercialVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using VentasVO;

namespace GestorDAL
{
    public class AccesoBBDD
    {
        //..\\..\\..\\
        private const string RUTADATOS = "Data\\1_datos_comerciales.csv";
        private const string RUTAVENTAS = "Data\\2_facturacion_comercial.csv";
        private int seleccion;
        private Comercial com;

        public AccesoBBDD(int seleccion)
        {
            this.seleccion = seleccion;
        }
        
        public AccesoBBDD(Comercial com)
        {
            this.com = com;
        }

        public Comercial GetComercial()
        {
            return LeeComercial();
        }

        public Comercial GetVentas()
        {
            return LeeVentas();
        }

        private Comercial LeeComercial()
        {
            DataTable dtComercial = CSVaDataTable(RUTADATOS);
            DataRow[] dr = dtComercial.Select("numero_comercial = " + seleccion);
            return new Comercial(int.Parse((string)dr[0]["numero_comercial"]), (string)dr[0]["nombre"], (string)dr[0]["apellido"], (string)dr[0]["localidad"], int.Parse((string)dr[0]["edad"]));
        }

        private Comercial LeeVentas()
        {
            com.ListaVentas = new List<Ventas>();
            DataTable dtVentas = CSVaDataTable(RUTAVENTAS);
            DataRow[] dr;
            if(seleccion < 1)
            {
                dr = dtVentas.Select("numero_comercial = " + com.Id);
            } else
            {
                dr = dtVentas.Select("numero_comercial = " + seleccion);
            }

            for (int i = 0; i < dr.Length; i++)
            {
                int[] ventasMensuales = new int[12];
                string[] fila = string.Join(",", dr[i].ItemArray).Split(',').ToArray();
                for (int z = 2; z < fila.Length; z++)
                {
                    ventasMensuales[z - 2] = int.Parse(fila[z]);
                }
                Ventas v = new Ventas(int.Parse(fila[1]), ventasMensuales);
                com.ListaVentas.Add(v);
            }
            return com;
        }

        private DataTable CSVaDataTable(string ruta)
        {
            StreamReader sr = new StreamReader(ruta);
            string[] columnas = sr.ReadLine().Split(',');
            DataTable tb = new DataTable();
            foreach (string columna in columnas)
            {
                tb.Columns.Add(columna);
            }

            while (!sr.EndOfStream)
            {
                string[] filas = sr.ReadLine().Split(',');
                DataRow dr = tb.NewRow();
                for (int i = 0; i < columnas.Length; i++)
                {
                    dr[i] = filas[i];
                }
                tb.Rows.Add(dr);
            }
            return tb;
        }
    }
}
