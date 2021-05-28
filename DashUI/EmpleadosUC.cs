using EmpleadoVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashUI
{
    public partial class EmpleadosUC : UserControl
    {
        private DataGridView dgvEmpleado;
        private List<Empleado> empleados;
        public EmpleadosUC(List<Empleado> empleados)
        {
            InitializeComponent();
            dgvEmpleados = dgvEmpleado;
            this.empleados = empleados;
        }

        private void EmpleadosUC_Paint(object sender, PaintEventArgs e)
        {
            BindingSource bs = new BindingSource();
            foreach(Empleado emp in empleados)
            {
                bs.Add(emp);
            }
            dgvEmpleados.DataSource = bs;
            dgvEmpleado.AutoGenerateColumns = true;
        }
    }
}
