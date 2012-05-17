using System.Net.Mail;

namespace Pasteleria
{
    class CorreoNuevaCuenta : CorreoStrategy
    {
        MailMessage correo = new MailMessage();
        SmtpClient smtpServidor = new SmtpClient("smtp.gmail.com");

        public override string MandarCorreo(string correoDestino)
        {
            try
            {
                correo.From = new MailAddress("equiporeposteria@gmail.com");
                correo.To.Add(correoDestino);
                correo.Subject = "Nueva cuenta";
                correo.Body = "Tu Nueva Cuenta\n\nGracias por haber creado una cuenta en Reposteria.";

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
