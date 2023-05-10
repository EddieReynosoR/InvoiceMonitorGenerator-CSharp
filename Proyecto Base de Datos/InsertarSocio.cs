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
    public partial class InsertarSocio : Form
    {
        public InsertarSocio()
        {
            InitializeComponent();
        }

        private void clasePaneles3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Initial Catalog=BDProyecto;Integrated Security=True";

            string query = "INSERT INTO socio(socio_rfc, socio_nombre, socio_inicial, socio_apellidop, socio_apellidom, socio_calle, socio_numint, socio_numext, socio_colonia, socio_cp, socio_email, socio_fnacimiento, socio_fingreso, ciudad_id_ciudad)VALUES(@socio_rfc, @socio_nombre, @socio_inicial, @socio_apellidop, @socio_apellidom, @socio_calle, @socio_numint, @socio_numext, @socio_colonia, @socio_cp, @socio_email, @socio_fnacimiento, @socio_fingreso, @ciudad_id_ciudad)";

            string socio_rfc = txtRFC.Text;
            string socio_nombre = txtNombre.Text;
            string socio_inicial = txtInicial.Text;
            string socio_apellidop = txtApellidoP.Text;
            string socio_apellidom = txtApellidoM.Text;
            string socio_calle = txtCalle.Text;
            string socio_numint = txtNInterior.Text;
            string socio_numext = txtNExterior.Text;
            string socio_colonia = txtColonia.Text;
            int socio_ciudad = cmbCiudad.SelectedIndex;
            string socio_cp = txtCP.Text;
            string socio_email = txtEmail.Text;
            
            

            using (SqlConnection cn = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.Parameters.AddWithValue("@socio_rfc", socio_rfc);
                cmd.Parameters.AddWithValue("@socio_nombre", socio_nombre);
                cmd.Parameters.AddWithValue("@socio_inicial", socio_inicial);
                cmd.Parameters.AddWithValue("@socio_apellidop", socio_apellidop);
                cmd.Parameters.AddWithValue("@socio_apellidom", socio_apellidom);
                cmd.Parameters.AddWithValue("@socio_calle", socio_calle);
                cmd.Parameters.AddWithValue("@socio_numint", socio_numint);
                cmd.Parameters.AddWithValue("@socio_numext", socio_numext);
                cmd.Parameters.AddWithValue("@socio_colonia", socio_colonia);
                cmd.Parameters.AddWithValue("@socio_cp", socio_cp);
                cmd.Parameters.AddWithValue("@socio_email", socio_email);
                cmd.Parameters.AddWithValue("@socio_fnacimiento", fechaNacimiento.Value.Date);
                cmd.Parameters.AddWithValue("@socio_fingreso", fechaIngreso.Value.Date);
                cmd.Parameters.AddWithValue("@ciudad_id_ciudad", socio_ciudad + 1);

                cn.Open();
                cmd.ExecuteNonQuery();

            }

            DialogResult result = MessageBox.Show("Socio añadido correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                frmAgregarRecibo frmAgregar = new frmAgregarRecibo();
                Hide();

                frmAgregar.MostrarSocios();
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmAgregarRecibo frmAgregar = new frmAgregarRecibo();
            Hide();

            frmAgregar.MostrarSocios();

            
        }

        public void RellenarComboBox()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Database=BDProyecto;Integrated Security=true;");

            cn.Open();

            string query = "SELECT ciudad_nombre, id_ciudad FROM ciudad";


            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {               
                cmbCiudad.Items.Add(dr["ciudad_nombre"].ToString());
                cmbCiudad.DisplayMember = dr["ciudad_nombre"].ToString();
                cmbCiudad.ValueMember = dr["id_ciudad"].ToString();
            }

            cn.Close();
        }

        private void InsertarSocio_Load(object sender, EventArgs e)
        {
            RellenarComboBox();
        }
    }
}
