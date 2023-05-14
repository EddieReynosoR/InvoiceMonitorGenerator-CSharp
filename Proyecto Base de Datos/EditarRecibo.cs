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
using DocumentFormat.OpenXml.Wordprocessing;

namespace Proyecto_Base_de_Datos
{
    public partial class EditarRecibo : Form
    {
        public EditarRecibo()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Database=BDProyecto;Integrated Security=true;");

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás segur@ de que quieres dar de baja este recibo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                cn.Open();
                SqlCommand elimina = new SqlCommand("DELETE from recibo WHERE num_folio=@num_folio", cn);
                elimina.Parameters.AddWithValue("@num_folio", lblFolio.Text);

                elimina.ExecuteNonQuery();

                SqlCommand elimina2 = new SqlCommand("DELETE FROM firma WHERE recibo_num_folio=@num_folio", cn);
                elimina2.Parameters.AddWithValue("@num_folio", lblFolio.Text);

                elimina2.ExecuteNonQuery();

                MessageBox.Show("Recibo eliminado.");

                cn.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cn.Open();

            string query = "UPDATE recibo SET estatus_estatus_codigo=@estatus_estatus_codigo WHERE num_folio=@num_folio";


            SqlCommand cmd = new SqlCommand(query, cn);

            cmd.Parameters.AddWithValue("@estatus_estatus_codigo", cmbEstatus.SelectedItem);
            cmd.Parameters.AddWithValue("@num_folio", lblFolio.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Recibo Actualizado");

            cn.Close();
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

        private void lblFolio_Click(object sender, EventArgs e)
        {

        }
    }
}
