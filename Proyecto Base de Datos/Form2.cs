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
using System.Data.SqlClient;

namespace Proyecto_Base_de_Datos
{
    public partial class frmInicioSesion : Form
    {
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

        public frmInicioSesion()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            
            frmInicio form1 = new frmInicio();

            string usuarioAdministrador = txtUsuario.Text;
            string contraAdministrador = txtContra.Text;

            SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Database=BDProyecto;Integrated Security=true;");

            cn.Open();

            string query = "SELECT * FROM administrador WHERE admin_user = '" + usuarioAdministrador + "' AND admin_passwrd ='" + contraAdministrador + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, cn);
            DataTable dtable = new DataTable();

            sda.Fill(dtable);

            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = query;

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Admin.adminID = reader["admin_id"].ToString();
                Admin.usuarioAdmin = reader["admin_user"].ToString();
                Admin.adminPuesto = reader["puesto_id_puesto"].ToString();

                Admin.usuarioAdminNombre = reader["admin_pnombre"].ToString();

                Admin.usuarioAdminInicial = reader["admin_inicial"].ToString();

                Admin.usuarioAdminApellidoP = reader["admin_apellidop"].ToString();

            
                Admin.usuarioAdminApellidoM = reader["admin_apellidom"].ToString();
            }

            if(dtable.Rows.Count > 0)
            {
                MessageBox.Show("Datos correctos. Entrando al sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();

                
                form1.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            cmd.Dispose();
            reader.Close();
            cn.Close();
            
            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            this.Hide();
            frmRegistro.Show();
        }
    }
}
