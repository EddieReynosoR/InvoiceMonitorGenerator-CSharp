using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Base_de_Datos
{
    public partial class MostrarRecibosPendientes : Form
    {
        public MostrarRecibosPendientes()
        {
            InitializeComponent();
        }

        private void panelRecibos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MostrarRecibosPendientes_Load(object sender, EventArgs e)
        {
            DetallesRecibo();
            ReciboPanel();
        }

        public void DetallesRecibo()
        {
            Recibo recibo = new Recibo();

            recibo.getListSinFirmas();
        }

        public void ReciboPanel()
        {
            foreach (Recibo cancion in Recibo.lista)
            {
                ReciboFirmas panel = new ReciboFirmas();

                panel.DetallesRecibo(cancion);

                panel.Dock = DockStyle.Top;
                panelRecibos.Controls.Add(panel);
            }
        }
    }
}
