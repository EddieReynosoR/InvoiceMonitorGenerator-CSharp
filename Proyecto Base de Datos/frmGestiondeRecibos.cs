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
    public partial class frmGestiondeRecibos : Form
    {
        public frmGestiondeRecibos()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            frmHistorialdeCambios frmHistorialdeCambios = new frmHistorialdeCambios();  
            frmHistorialdeCambios.Show();
        }

        private void frmGestiondeRecibos_Load(object sender, EventArgs e)
        {
            DetallesRecibo();
            ReciboPanel();
        }

        public void DetallesRecibo()
        {
            Recibo recibo = new Recibo();

            recibo.getList();
        }

        public void ReciboPanel()
        {
            foreach(Recibo cancion in Recibo.lista)
            {
                registroRecibo panel = new registroRecibo();

                panel.DetallesRecibo(cancion);

                panel.Dock = DockStyle.Top;
                panelRecibos.Controls.Add(panel);
            }
        }
    }
}
