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

namespace Proyecto_Base_de_Datos
{
    public partial class frmInicio : Form
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

        public frmInicio()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        //Variables para las animaciones de la barra de menu
        bool sidebarExpand;
        bool homeCollapse;

        
        private void Form1_Load(object sender, EventArgs e)
        {
            buttonHome_Click(null, e);
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

        private void buttonHome_Click(object sender, EventArgs e)
        {
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
            AbrirFormHija(new frmGestiondeRecibos());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmAgregarRecibo());
        }

        private void btnSubmenu_Click(object sender, EventArgs e)
        {
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

       
    }
}
