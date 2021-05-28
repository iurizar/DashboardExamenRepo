using ComercialVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DashUI
{
    public partial class VentasUC : UserControl
    {
        private Chart ventas;
        private Comercial com;
        public VentasUC(Comercial com)
        {
            InitializeComponent();
            ventas = chartVentas;
            this.com = com;
        }

        private void DibujaGrafico(object sender, PaintEventArgs e)
        {
            List<string> meses = new List<string>(new string[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            ventas.Series[0].Name = "Empresa 1";
            Series serie2 = new Series("Empresa 2");
            ventas.Series.Add(serie2);
            ventas.Series[0].Points.DataBindXY(meses, com.ListaVentas.ElementAt(0).VentasMensuales);
            ventas.Series[1].Points.DataBindXY(meses, com.ListaVentas.ElementAt(1).VentasMensuales);
            ventas.Series[0].IsValueShownAsLabel = true;
            ventas.Series[1].IsValueShownAsLabel = true;
        }
    }
}
