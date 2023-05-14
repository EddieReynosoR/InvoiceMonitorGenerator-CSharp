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
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using System.Globalization;

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
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtInicial.Text) || string.IsNullOrEmpty(txtRFC.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtApellidoP.Text) || string.IsNullOrEmpty(txtApellidoM.Text) || string.IsNullOrEmpty(txtColonia.Text) || string.IsNullOrEmpty(txtCalle.Text) || string.IsNullOrEmpty(txtNInterior.Text) || string.IsNullOrEmpty(txtNExterior.Text) || string.IsNullOrEmpty(txtCP.Text))
            {
                MessageBox.Show("Debe Ingresar los datos Correspondientes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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
            txtNombre.Focus();
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNombre, "Debe Introducir el nombre");
                txtNombre.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten letras");
                e.Handled= true;
                
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtInicial.Focus();
            }
        }

        private void txtInicial_Validating(object sender, CancelEventArgs e)
        {
            if (txtInicial.Text.Trim() == "")
            {
                errorProvider1.SetError(txtInicial, "Debe Introducir la inicial");
                txtInicial.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
     
        private void txtInicial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                    txtApellidoP.Focus();
            }
        }

        private void txtApellidoP_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellidoP.Text.Trim() == "")
            {
                errorProvider1.SetError(txtApellidoP, "Debe Introducir el Apellido Paterno");
                txtApellidoP.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    


        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (IsValidEmail(txtEmail.Text))
                {
                    txtColonia.Focus();
                }
                else
                {
                    MessageBox.Show("Formato no valido para email");
                    txtEmail.Focus();
                }
                
            }
            
        }

        private void fechaNacimiento_CloseUp(object sender, EventArgs e)
        {

        }

        private void txtApellidoP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtApellidoM.Focus();
            }
        }
        
        private void txtInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permite letras");
                
            }
        }

        private void txtApellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten letras");
                e.Handled = true;

            }

        }

        private void txtApellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten letras");
                e.Handled = true;

            }
        }

        private void txtApellidoM_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellidoM.Text.Trim() == "")
            {
                errorProvider1.SetError(txtApellidoM, "Debe Introducir el Apellido Materno");
                txtApellidoM.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtApellidoM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fechaNacimiento.Focus();
            }
        }

        private void txtRFC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtRFC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se aceptan letras y numeros");
                e.Handled = true;

            }
        }

        private void txtColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtColonia_Validating(object sender, CancelEventArgs e)
        {
            if (txtColonia.Text.Trim() == "")
            {
                errorProvider1.SetError(txtColonia, "Debe Introducir la colonia");
                txtColonia.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtColonia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCalle.Focus();
            }
        }

        private void txtCalle_Validating(object sender, CancelEventArgs e)
        {
            if (txtCalle.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCalle, "Debe Introducir la calle");
                txtCalle.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtNInterior_Validating(object sender, CancelEventArgs e)
        {
            if (txtNInterior.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNInterior, "Debe Introducir el Numero Interior");
                txtNInterior.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtNInterior_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;
                MessageBox.Show("Solo se puede introducir números");
            }
        }

        private void txtCalle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNInterior.Focus();
            }
        }

        private void txtNInterior_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNExterior.Focus();
            }
        }

        private void txtNExterior_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCP.Focus();
            }
        }

        private void txtCP_Validating(object sender, CancelEventArgs e)
        {
            if (txtCP.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCP, "Debe Introducir el Codigo Postal");
                txtCP.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtCP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fechaIngreso.Focus();
            }
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;
                MessageBox.Show("Solo se puede introducir números");
            }
        }

        private void txtInicial_TextChanged(object sender, EventArgs e)
        {
            if (txtInicial.Text.Length > 1)
            {
                MessageBox.Show("Solo se permite una letra");
            }
        }
    }
}
