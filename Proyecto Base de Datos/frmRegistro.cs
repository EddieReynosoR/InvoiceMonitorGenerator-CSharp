using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using System.Data.SqlClient;

namespace Proyecto_Base_de_Datos
{
    public partial class frmRegistro: Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        
        private static extern IntPtr CreateRoundRectRgn
        (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
        );

        public frmRegistro()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            //Condicion diferente a nulo
            if (senderBtn != null)
            {
                //Se llama primero a este método para desactivar el
                //Boton anterior
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                //Cambiar el color de fondo del boton y el texto
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                //Se alinea el texto al centro
                //currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                //Cambiamos la relacion de la imagen con le texto
                // currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //Icono a la derecha
                //currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //borde izquierdo del boton

                //El icono de la barra de titulo cambie al icono del 
                //boton seleccionado y el color
                //btnHome.IconChar = currentBtn.IconChar;
                //btnHome.IconColor = color;
            }
        }
        //Desactivar el resaltado del boton
        private void DisableButton()
        {
            
        }
        private void frmRegistro_Load(object sender, EventArgs e)
        {
            RellenarComboBox();
        }

        private void AbrirFormHija (object formHija)
        {
            if(this.panelContenedor.Controls.Count > 0)
                 this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock= DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            //public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            AbrirFormHija(new frmRegistroUsuario());
            
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            AbrirFormHija(new frmRegistroEmpleado());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            frmInicioSesion frmInicioSesion = new frmInicioSesion();
            Hide();
            frmInicioSesion.Show();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtInicial.Text) || string.IsNullOrEmpty(txtContra.Text) || string.IsNullOrEmpty(txtContraC.Text) || string.IsNullOrEmpty(txtApellidoP.Text) || string.IsNullOrEmpty(txtApellidoM.Text) || string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContraC.Text) || cmbPuesto.SelectedIndex == 0)
            {
                MessageBox.Show("Debe Ingresar los datos Correspondientes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string adminNombre = txtNombre.Text;
            string adminInicial = txtInicial.Text;
            string adminApellidoP = txtApellidoP.Text;
            string adminApellidoM = txtApellidoM.Text;

            string adminUsuario = txtUsuario.Text;
            string adminContra = txtContra.Text;

            int puestoNum = cmbPuesto.SelectedIndex;


            string query = "INSERT INTO administrador(admin_user, admin_passwrd, admin_pnombre, admin_inicial, admin_apellidop, admin_apellidom, puesto_id_puesto)VALUES(@admin_user, @admin_passwrd, @admin_pnombre, @admin_inicial, @admin_apellidop, @admin_apellidom, @puesto_id_puesto)";

            using (SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Database=BDProyecto;Integrated Security=true;"))
            {
                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.Parameters.AddWithValue("@admin_user", adminUsuario);

                cmd.Parameters.AddWithValue("@admin_passwrd", adminContra);

                cmd.Parameters.AddWithValue("@admin_pnombre", adminNombre);

                cmd.Parameters.AddWithValue("@admin_inicial", adminInicial);

                cmd.Parameters.AddWithValue("@admin_apellidop", adminApellidoP);

                cmd.Parameters.AddWithValue("@admin_apellidom", adminApellidoM);

                cmd.Parameters.AddWithValue("@puesto_id_puesto", puestoNum + 1);


                cn.Open();
                cmd.ExecuteNonQuery();
            }

            DialogResult result = MessageBox.Show("Administrador registrado con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if(result == DialogResult.OK)
            {
                frmInicioSesion frmInicioSesion = new frmInicioSesion();
                Hide();
                frmInicioSesion.Show();
            }

            
        }

        public void RellenarComboBox()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Database=BDProyecto;Integrated Security=true;");

            cn.Open();

            string query = "SELECT puesto_nombre, id_puesto FROM puesto";
           

            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmbPuesto.Items.Add(dr["puesto_nombre"].ToString());
                cmbPuesto.DisplayMember = dr["puesto_nombre"].ToString();
                cmbPuesto.ValueMember = dr["id_puesto"].ToString();
            }

            cn.Close();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

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

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtInicial.Focus();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras");
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

        private void txtInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras");
            }
        }

        private void txtApellidoP_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellidoP.Text.Trim() == "")
            {
                errorProvider1.SetError(txtApellidoP, "Debe Introducir el apellido paterno");
                txtApellidoP.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtApellidoP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtApellidoM.Focus();
            }
        }

        private void txtApellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras");
            }
        }

        private void txtApellidoM_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellidoM.Text.Trim() == "")
            {
                errorProvider1.SetError(txtApellidoM, "Debe Introducir el apellido paterno");
                txtApellidoM.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtApellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras");
            }
        }

        private void txtApellidoM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUsuario.Focus();
            }
        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsuario.Text.Trim() == "")
            {
                errorProvider1.SetError(txtUsuario, "Debe Introducir el usuario");
                txtUsuario.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtContra.Focus();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se aceptan letras y numeros");
                e.Handled = true;

            }
        }

        private void txtContra_Validating(object sender, CancelEventArgs e)
        {
            if (txtContra.Text.Trim() == "")
            {
                errorProvider1.SetError(txtContra, "Debe Introducir la contraseña");
                txtContra.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtContra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtContra.Text.Length <= 8)
                {
                    MessageBox.Show("Se necesita minimo 8 caracteres");
                    txtContra.Focus();
                }
                else
                {
                    txtContraC.Focus();
                }
                
            }
        }

        private void txtContraC_Validating(object sender, CancelEventArgs e)
        {
            if (txtContraC.Text.Trim() == "")
            {
                errorProvider1.SetError(txtContraC, "Debe Introducir la confirmacion de contraseña");
                txtContraC.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtContraC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtContra.Text == txtContraC.Text)
                {
                    cmbPuesto.Focus();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                    txtContraC.Focus();
                }
                
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
