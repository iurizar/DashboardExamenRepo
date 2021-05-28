using System;

namespace VentasVO
{
    public class Ventas
    {
        private int empresa;
        private int[] ventasMensuales;

        public int Empresa { get => empresa; set => empresa = value; }
        public int[] VentasMensuales { get => ventasMensuales; set => ventasMensuales = value; }

        public Ventas(int empresa, int[] ventasMensuales)
        {
            Empresa = empresa;
            VentasMensuales = ventasMensuales;
        }
    }
}
