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
    public partial class ReciboFirmas : UserControl
    {

        public static string id;
        public ReciboFirmas()
        {
            InitializeComponent();
        }

        public void DetallesRecibo(Recibo e)
        {
            lblNumeroFolio.Text = e.numFolio;

            id = lblNumeroFolio.Text;

            lblImporte.Text = "$" + e.importe;

            lblPeriodo.Text = e.periodo;

            lblSocio.Text = e.reciboSocio;

            lblEstatus.Text = e.reciboEstatus;

            lblAdmins.Text = e.admins;
        }

        private void ReciboFirmas_Load(object sender, EventArgs e)
        {

        }

        private void btnFirma_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Initial Catalog=BDProyecto;Integrated Security=True";

            string numFolio = lblNumeroFolio.Text;

            string query2 = "INSERT INTO firma(administrador_admin_id, recibo_num_folio, firma_fecha)VALUES(@administrador_admin_id, @recibo_num_folio, @firma_fecha)";

            using (SqlConnection cn = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand(query2, cn);

                cmd.Parameters.AddWithValue("@administrador_admin_id", Admin.adminID);
                cmd.Parameters.AddWithValue("@recibo_num_folio", numFolio);
                cmd.Parameters.AddWithValue("@firma_fecha", DateTime.Now);

                cn.Open();
                cmd.ExecuteNonQuery();

            }

            DialogResult result = MessageBox.Show("El recibo se ha registrado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            if (result == DialogResult.OK)
            {



            }

        }

        private void lblAdmins_Click(object sender, EventArgs e)
        {

        }
    }
}
