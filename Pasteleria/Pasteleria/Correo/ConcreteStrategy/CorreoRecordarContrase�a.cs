using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace Pasteleria
{
    class CorreoRecordarContraseña : CorreoStrategy
    {
        MailMessage correo = new MailMessage();
        SmtpClient smtpServidor = new SmtpClient("smtp.gmail.com");

        public override string MandarCorreo(string correoDestino)
        {
            try
            {
                correo.From = new MailAddress("equiporeposteria@gmail.com");
                correo.To.Add(correoDestino);
                correo.Subject = "Datos de cuenta en repostería";
                correo.Body = "CRI CRI";

                smtpServidor.Port = 587;
                smtpServidor.Credentials = new System.Net.NetworkCredential("equiporeposteria", "reposteria2012");
                smtpServidor.EnableSsl = true;

                smtpServidor.Send(correo);

                return "Hemos mandado a " + correoDestino + " la información de su cuenta";
            }

            catch
            {
                return "ERROR";
            }
        }
    }
}