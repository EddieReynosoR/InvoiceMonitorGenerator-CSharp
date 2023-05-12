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
using System.Diagnostics.CodeAnalysis;

namespace Proyecto_Base_de_Datos
{
    public partial class frmAgregarRecibo : Form
    {
        public frmAgregarRecibo()
        {
            InitializeComponent();
        }

        private void btnInsertarSocio_Click(object sender, EventArgs e)
        {
            InsertarSocio insertarSocio = new InsertarSocio();
            insertarSocio.Show();

        }

        public void MostrarSocios()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Database=BDProyecto;Integrated Security=true;");

            cn.Open();

            string query = "SELECT socio_nombre, socio_inicial, socio_apellidop, socio_rfc FROM socio";


            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmbSocio.Items.Add(dr["socio_rfc"].ToString());
                cmbSocio.DisplayMember = dr["socio_rfc"].ToString() + " " + dr["socio_nombre"].ToString() + " " + dr["socio_inicial"].ToString() + " " + dr["socio_apellidop"].ToString();
                cmbSocio.ValueMember = dr["socio_rfc"].ToString();
            }

            cn.Close();
        }

        private void frmAgregarRecibo_Load(object sender, EventArgs e)
        {
            MostrarSocios();

            lblAdmin.Text = Admin.usuarioAdminNombre + Admin.usuarioAdminInicial + Admin.usuarioAdminApellidoP + Admin.usuarioAdminApellidoM + DateTime.Now;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Initial Catalog=BDProyecto;Integrated Security=True";

            string query = "INSERT INTO recibo(num_folio, fecha, importe, importe_letra, periodo, socio_socio_rfc, estatus_estatus_codigo)VALUES(@num_folio, @fecha, @importe, @importe_letra, @periodo, @socio_socio_rfc, @estatus_estatus_codigo)";

            string numFolio = txtNFolio.Text;
            float importeFolio = float.Parse(txtImporte.Text);
            string importeLetraFolio = NumeroALetras(importeFolio);

            string periodoFolio = fechaRecibo.Value.Year.ToString() + "-" + fechaRecibo.Value.AddYears(1).ToString();

            using (SqlConnection cn = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.Parameters.AddWithValue("@num_folio", numFolio);
                cmd.Parameters.AddWithValue("@fecha", fechaRecibo.Value.Date);
                cmd.Parameters.AddWithValue("@importe", importeFolio);
                cmd.Parameters.AddWithValue("@importe_letra", importeLetraFolio);
                cmd.Parameters.AddWithValue("@periodo", periodoFolio);
                cmd.Parameters.AddWithValue("@socio_socio_rfc", cmbSocio.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@estatus_estatus_codigo", "V");

                cn.Open();
                cmd.ExecuteNonQuery();

            }


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

        private void clasePaneles2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void refrescarSocios_Tick(object sender, EventArgs e)
        {
        }

        private void cmbSocio_DropDown(object sender, EventArgs e)
        {
            cmbSocio.Items.Clear();
            MostrarSocios();
        }

        public static string NumeroALetras(float numberAsString)
        {
            string dec;

            var entero = Convert.ToInt64(Math.Truncate(numberAsString));
            var decimales = Convert.ToInt32(Math.Round((numberAsString - entero) * 100, 2));
            if (decimales > 0)
            {
                //dec = " PESOS CON " + decimales.ToString() + "/100";
                dec = $" PESOS {decimales:0,0} /100";
            }
            //Código agregado por mí
            else
            {
                //dec = " PESOS CON " + decimales.ToString() + "/100";
                dec = $" PESOS {decimales:0,0} /100";
            }
            var res = NumeroALetras(Convert.ToDouble(entero)) + dec;
            return res;
        }
        [SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator")]
        private static string NumeroALetras(double value)
        {
            string num2Text; value = Math.Truncate(value);
            if (value == 0) num2Text = "CERO";
            else if (value == 1) num2Text = "UNO";
            else if (value == 2) num2Text = "DOS";
            else if (value == 3) num2Text = "TRES";
            else if (value == 4) num2Text = "CUATRO";
            else if (value == 5) num2Text = "CINCO";
            else if (value == 6) num2Text = "SEIS";
            else if (value == 7) num2Text = "SIETE";
            else if (value == 8) num2Text = "OCHO";
            else if (value == 9) num2Text = "NUEVE";
            else if (value == 10) num2Text = "DIEZ";
            else if (value == 11) num2Text = "ONCE";
            else if (value == 12) num2Text = "DOCE";
            else if (value == 13) num2Text = "TRECE";
            else if (value == 14) num2Text = "CATORCE";
            else if (value == 15) num2Text = "QUINCE";
            else if (value < 20) num2Text = "DIECI" + NumeroALetras(value - 10);
            else if (value == 20) num2Text = "VEINTE";
            else if (value < 30) num2Text = "VEINTI" + NumeroALetras(value - 20);
            else if (value == 30) num2Text = "TREINTA";
            else if (value == 40) num2Text = "CUARENTA";
            else if (value == 50) num2Text = "CINCUENTA";
            else if (value == 60) num2Text = "SESENTA";
            else if (value == 70) num2Text = "SETENTA";
            else if (value == 80) num2Text = "OCHENTA";
            else if (value == 90) num2Text = "NOVENTA";
            else if (value < 100) num2Text = NumeroALetras(Math.Truncate(value / 10) * 10) + " Y " + NumeroALetras(value % 10);
            else if (value == 100) num2Text = "CIEN";
            else if (value < 200) num2Text = "CIENTO " + NumeroALetras(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) num2Text = NumeroALetras(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) num2Text = "QUINIENTOS";
            else if (value == 700) num2Text = "SETECIENTOS";
            else if (value == 900) num2Text = "NOVECIENTOS";
            else if (value < 1000) num2Text = NumeroALetras(Math.Truncate(value / 100) * 100) + " " + NumeroALetras(value % 100);
            else if (value == 1000) num2Text = "MIL";
            else if (value < 2000) num2Text = "MIL " + NumeroALetras(value % 1000);
            else if (value < 1000000)
            {
                num2Text = NumeroALetras(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0)
                {
                    num2Text = num2Text + " " + NumeroALetras(value % 1000);
                }
            }
            else if (value == 1000000)
            {
                num2Text = "UN MILLON";
            }
            else if (value < 2000000)
            {
                num2Text = "UN MILLON " + NumeroALetras(value % 1000000);
            }
            else if (value < 1000000000000)
            {
                num2Text = NumeroALetras(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0)
                {
                    num2Text = num2Text + " " + NumeroALetras(value - Math.Truncate(value / 1000000) * 1000000);
                }
            }
            else if (value == 1000000000000) num2Text = "UN BILLON";
            else if (value < 2000000000000) num2Text = "UN BILLON " + NumeroALetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            else
            {
                num2Text = NumeroALetras(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0)
                {
                    num2Text = num2Text + " " + NumeroALetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);
                }
            }
            return num2Text;
        }

        private void cmbSocio_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblTest.Text = cmbSocio.ValueMember.ToString();
        }

        private void txtNFolio_Validating(object sender, CancelEventArgs e)
        {
            if (txtNFolio.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNFolio, "Debe Introducir el numero de folio");
                txtNFolio.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras");
            }
        }

        private void txtNFolio_Validating_1(object sender, CancelEventArgs e)
        {

        }

        private void txtNFolio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtImporte.Focus();
            }
        }

        private void txtNFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;
                MessageBox.Show("Solo se puede introducir números");
            }
        }

        private void txtImporte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbSocio.Focus();
            }
        }
    }
}
