using FontAwesome.Sharp;
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
//using System.Windows.Media;

namespace Proyecto_Base_de_Datos
{
    public partial class frmInicio : Form
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
            if (btnInicio.Enabled == true)
            {
                btnInicio.BackColor = Color.FromArgb(35, 40, 45);
                btnInicio.ForeColor = Color.White;
                btnInicio.TextAlign = ContentAlignment.MiddleLeft;
                btnInicio.IconColor = Color.Thistle;
                // currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
                
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
        public frmInicio()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 85);


        }

        //Variables para las animaciones de la barra de menu
        bool sidebarExpand;
        bool homeCollapse;

        
        private void Form1_Load(object sender, EventArgs e)
        {
            buttonHome_Click(null, e);
            btnInicio.BackColor = Color.FromArgb(37, 36, 81);
            btnInicio.ForeColor = Color.White;
            //Se alinea el texto al centro
            //currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            btnInicio.IconColor = RGBColors.color1;
            btnInicio.Enabled = true;
        }

        //Animacion de la barra de menu
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;  
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start(); 
        }

        //Animacion del submenu
        private void HomeTimer_Tick(object sender, EventArgs e)
        {
            if(homeCollapse)
            {
                btnActivarSubmenu.Hide();
                HomeContainer.Height += 10;
                if(HomeContainer.Height==HomeContainer.MaximumSize.Height)
                {
                    homeCollapse= false;
                    HomeTimer.Stop();
                }
            }
            else
            {
                btnActivarSubmenu.Show();
                HomeContainer.Height -= 10;
                if (HomeContainer.Height == HomeContainer.MinimumSize.Height)
                {
                    homeCollapse = true;
                    HomeTimer.Stop();
                }
            }
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
        private void buttonHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            AbrirFormHija(new frmMenu());
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmInicioSesion form2 = new frmInicioSesion();
            this.Hide();
            form2.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

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

        private void AbrirFormHija(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            AbrirFormHija(new frmGestiondeRecibos());
            

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            AbrirFormHija(new frmAgregarRecibo());
            
        }

        private void btnSubmenu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            AbrirFormHija(new frmSubmenu());
            
        }

        private void btnActivarSubmenu_Click(object sender, EventArgs e)
        {
            HomeTimer.Start();
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            HomeTimer.Start();
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
