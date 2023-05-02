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
            if (btnUsuario.Enabled == true)
            {
                btnUsuario.BackColor = Color.FromArgb(35, 40, 45);
                btnUsuario.ForeColor = Color.White;
                btnUsuario.TextAlign = ContentAlignment.MiddleLeft;
                btnUsuario.IconColor = Color.Thistle;
                // currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnUsuario.ImageAlign = ContentAlignment.MiddleLeft;

            }
            if (currentBtn != null)
            {
                //Se regresa la configuración por defecto del boton
                currentBtn.BackColor = Color.FromArgb(35, 40, 45);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Thistle;
                // currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void frmRegistro_Load(object sender, EventArgs e)
        {
            btnUsuario_Click(null, e);
            btnUsuario.BackColor = Color.FromArgb(37, 36, 81);
            btnUsuario.ForeColor = Color.White;
            //Se alinea el texto al centro
            //currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            btnUsuario.IconColor = RGBColors.color1;
            btnUsuario.Enabled = true;
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
            this.Hide();
            frmInicioSesion.Show();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
