using ComercialVO;
using EmpleadoVO;
using GestorBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasVO;

namespace DashUI
{
    public partial class MainUI : Form
    {
        private Panel panel;
        private Comercial com;
        private UserControl info;
        private UserControl ventas;
        private UserControl empleadosUC;
        private UserControl informeUC;
        public MainUI()
        {
            InitializeComponent();
            panel = panelUC;
        }

        private void SeleccionaComercial(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Label label = (Label)sender;
            int seleccion = int.Parse(label.Text);
            Controlador controller = new Controlador(seleccion);
            com = controller.RecuperaComercial();
            info = new InfoUC(com);
            panel.Controls.Add(info);
        }

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Controlador controller = new Controlador(com);
            com = controller.RecuperaVentas();
            ventas = new VentasUC(com);
            panel.Controls.Add(ventas);
        }

        private void buttonEmp_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Controlador controller = new Controlador();
            List<Empleado> empleados = controller.GetEmpleados();
            empleadosUC = new EmpleadosUC(empleados);
            panel.Controls.Add(empleadosUC);
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            informeUC = new InformeUC();
            panel.Controls.Add(informeUC);
            
        }
    }
}
