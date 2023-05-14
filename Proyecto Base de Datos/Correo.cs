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
using System.Globalization;
using System.Text.RegularExpressions;

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
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(txtCorreo.Text))
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
}
