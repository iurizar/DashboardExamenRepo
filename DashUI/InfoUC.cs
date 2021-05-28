using ComercialVO;
using System.Windows.Forms;

namespace DashUI
{
    public partial class InfoUC : UserControl
    {
        private Comercial com;
        private Label id;
        private Label nombre;
        private Label apellido;
        private Label localidad;
        private Label edad;

        public InfoUC(Comercial comercial)
        {
            InitializeComponent();
            com = comercial;
            id = labelID;
            nombre = labelNom;
            apellido = labelApe;
            localidad = labelLoc;
            edad = labelEdad;
        }

        private void InfoUC_Paint(object sender, PaintEventArgs e)
        {
            id.Text = com.Id + "";
            nombre.Text = com.Nombre;
            apellido.Text = com.Apellido;
            localidad.Text = com.Localidad;
            edad.Text = com.Edad + "";
        }
    }
}
