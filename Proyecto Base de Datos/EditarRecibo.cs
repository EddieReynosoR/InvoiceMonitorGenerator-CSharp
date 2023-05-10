using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_Base_de_Datos
{
    public partial class EditarRecibo : Form
    {
        public EditarRecibo()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás segur@ de que quieres dar de baja este recibo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        public void DetallesRecibo()
        {
            Recibo recibo = new Recibo();
            recibo.SeleccionarRecibo(registroRecibo.id);

            lblFolio.Text = recibo.numFolio;


            lblImporte.Text = "$" + recibo.importe;

            lblImporteLetra.Text = recibo.importeLetra;


            lblSocio.Text = recibo.reciboSocio;

            lblEstatus.Text = recibo.reciboEstatus;
        }
        public void llenarComboBox()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Database=BDProyecto;Integrated Security=true;");

            cn.Open();

            string query = "SELECT estatus_codigo, estatus_nombre, estatus_descripcion FROM estatus";


            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmbEstatus.Items.Add(dr["estatus_codigo"].ToString() + " " + dr["estatus_nombre"].ToString() + "\n" + dr["estatus_descripcion"].ToString());
                cmbEstatus.DisplayMember = dr["estatus_codigo"].ToString();
                cmbEstatus.ValueMember = dr["estatus_codigo"].ToString();
            }

            cn.Close();
        }

        private void EditarRecibo_Load(object sender, EventArgs e)
        {
            llenarComboBox();
            DetallesRecibo();
        }
    }
}
