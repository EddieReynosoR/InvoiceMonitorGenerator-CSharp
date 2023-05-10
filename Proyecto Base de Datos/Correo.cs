using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Mail;

namespace Proyecto_Base_de_Datos
{
    public partial class Correo : Form
    {
        public Correo()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MailMessage mm = new MailMessage("edix.gamer.23@gmail.com", txtCorreo.Text);

            mm.Subject = "TEST";
            mm.Body = "TEST";


            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;

            NetworkCredential nc = new NetworkCredential("edix.gamer.23@gmail.com", "hksqbjucpciytymh");

            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            smtp.Send(mm);

            MessageBox.Show("Mensaje enviado con exito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
