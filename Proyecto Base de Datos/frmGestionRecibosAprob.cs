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
    public partial class frmGestionRecibosAprob : Form
    {
        public frmGestionRecibosAprob()
        {
            InitializeComponent();
        }

        private void panelRecibos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmGestionRecibosAprob_Load(object sender, EventArgs e)
        {
            DetallesRecibo();
            ReciboPanel();
        }

        public void DetallesRecibo()
        {
            Recibo recibo = new Recibo();

            recibo.getListConFirmas();
        }

        public void ReciboPanel()
        {
            foreach (Recibo cancion in Recibo.lista)
            {
                registroRecibo panel = new registroRecibo();

                panel.DetallesRecibo(cancion);

                panel.Dock = DockStyle.Top;
                panelRecibos.Controls.Add(panel);
            }
        }
    }
}
