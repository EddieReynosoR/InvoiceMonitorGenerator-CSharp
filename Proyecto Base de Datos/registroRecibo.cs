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
    public partial class registroRecibo : UserControl
    {
        public static string id;
        public registroRecibo()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            id = lblNumeroFolio.Text;

            EditarRecibo editar = new EditarRecibo();
            editar.Show();
        }

        public void DetallesRecibo(Recibo e)
        {
            lblNumeroFolio.Text = e.numFolio;

            id = lblNumeroFolio.Text;

            lblImporte.Text = "$" + e.importe;

            lblPeriodo.Text = e.periodo;

            lblSocio.Text = e.reciboSocio;

            lblEstatus.Text = e.reciboEstatus;
        }

        private void registroRecibo_Load(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            id = lblNumeroFolio.Text;
            ImprimirRecibo imprimir = new ImprimirRecibo();

            imprimir.Show();
        }
    }
}
