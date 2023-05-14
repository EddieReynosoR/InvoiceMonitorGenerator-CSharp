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
        
        public string ObtenerAdminJefe(string id)
        {
            string admin = "";
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Database=BDProyecto;Integrated Security=true; MultipleActiveResultSets=True;");

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            string sql = "SELECT administrador.admin_pnombre + ' ' + admin_inicial+ ' ' +  admin_apellidop + ' ' +  admin_apellidom  AS 'nombre_admin', firma_fecha,puesto.puesto_nombre FROM firma INNER JOIN administrador on firma.administrador_admin_id = administrador.admin_id LEFT JOIN puesto on administrador.puesto_id_puesto = puesto.id_puesto LEFT JOIN recibo on firma.recibo_num_folio = recibo.num_folio WHERE administrador.puesto_id_puesto = '1' AND recibo.num_folio = '"+id+"'; ";
            cmd.CommandText = sql;


            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    admin = reader["nombre_admin"].ToString() +" "+ reader["firma_fecha"].ToString() + " " + reader["puesto_nombre"].ToString();

                }
                conn.Close();
                conn.Dispose();
            }

            return admin;
        }

        public string ObtenerAdminAsistente(string id)
        {
            string admin = "";
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Database=BDProyecto;Integrated Security=true; MultipleActiveResultSets=True;");

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            string sql = "SELECT administrador.admin_pnombre + ' ' + admin_inicial+ ' ' +  admin_apellidop + ' ' +  admin_apellidom  AS 'nombre_admin', firma_fecha,puesto.puesto_nombre FROM firma INNER JOIN administrador on firma.administrador_admin_id = administrador.admin_id LEFT JOIN puesto on administrador.puesto_id_puesto = puesto.id_puesto LEFT JOIN recibo on firma.recibo_num_folio = recibo.num_folio WHERE administrador.puesto_id_puesto = '2' AND recibo.num_folio = '" + id + "'; ";
            cmd.CommandText = sql;


            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    admin = reader["nombre_admin"].ToString() + " " + reader["firma_fecha"].ToString() + " " + reader["puesto_nombre"].ToString();

                }
                conn.Close();
                conn.Dispose();
            }

            return admin;
        }

        public void DetallesRecibo(Recibo e)
        {
            lblNumeroFolio.Text = e.numFolio;

            id = lblNumeroFolio.Text;

            lblImporte.Text = "$" + e.importe;

            lblPeriodo.Text = e.periodo;

            lblSocio.Text = e.reciboSocio;

            lblEstatus.Text = e.reciboEstatus;

            lblAdmin2.Text = ObtenerAdminJefe(e.numFolio);
            lblAdmins.Text = ObtenerAdminAsistente(e.numFolio);
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

        private void lblPeriodo_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void lblImporte_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lblNumeroFolio_Click(object sender, EventArgs e)
        {

        }

        private void lblAdmins_Click(object sender, EventArgs e)
        {

        }

        private void lblSocio_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void lblEstatus_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
