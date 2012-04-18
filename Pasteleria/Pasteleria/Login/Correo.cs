using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace Pasteleria
{
   public class Correo
    {
        MailMessage correo = new MailMessage();
        SmtpClient smtpServidor = new SmtpClient("smtp.gmail.com");

        public Correo()
        { 
        }

        public string MandarCorreo(string CorreoEmpleado, string Asunto, string Mensaje)
        {
            try
            {
                correo.From = new MailAddress("equiporeposteria@gmail.com");
                correo.To.Add(CorreoEmpleado);
                correo.Subject = Asunto;
                correo.Body = Mensaje;

                smtpServidor.Port = 587;
                smtpServidor.Credentials = new System.Net.NetworkCredential("equiporeposteria", "reposteria2012");
                smtpServidor.EnableSsl = true;

                smtpServidor.Send(correo);

                return "Hemos mandado a " + CorreoEmpleado + " la información de su cuenta";
            }

            catch
            {
                return "ERROR";
            }
        }

    }
}
