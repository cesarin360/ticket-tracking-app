using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Bdl_Grupo2_ProyectoFinal_A.Conexion
{
    public class SendEmail
    {
        public bool sendMail(string to, string asunto, string email, string code, string title, bool link = false)
        {  
            string body = @"
                        <div style='background-color:lightblue;border:1px#000000;-moz-border-radius:7px;-webkit-border-radius:7px;padding:10px;text-align:center;'>
                        <img src='https://i.ibb.co/KGnscbL/Logo-Dev-Solutions.png' style='width:400PX;'>
                        <h1 style='color:#7c795d;font-family:'Trocchi',serif;font-size:45px;font-weight:normal;line-height:48px;margin:0;'>Notificación DevSolutions</h1>
                        <p style='width:1000px;color:#4c4a37;font-family:'Source Sans Pro',sans-serif;font-size:18px;line-height:32px;margin:24px;'>" + email + @"</p>
                        <h2 style='color:#7c795d;font-family:'Source Sans Pro',sans-serif;font-size:28px;font-weight:400;line-height:32px;margin:24px;'>" + title + @" <b>" + code + @"</b></h2>          
                        <a href='https://localhost:44368/Ticket/Crear' role='button'>Crear Nuevo Ticket</a></div>
                        <hr style='margin-top:20px;'>
                        <p style='color:#a0a6b5;font-size:12px;padding-bottom:10px;text-align:center;line-height:18px;'>Has recibido este e - mail porque eres usuario registrado en DevSolutions al amparo de nuestra Política de Privacidad.Este e-mail se ha enviado desde DevSolutions
                        (DGNET Ltd, con número de registro 189977 y domicilio en 64A Cumberland Street, Edimburgo EH3 6RE, Reino Unido)</p>";
            if (link)
            {
                body = @"
                        <div style='background-color:lightblue;border:1px#000000;-moz-border-radius:7px;-webkit-border-radius:7px;padding:10px;text-align:center;'>
                        <img src='https://i.ibb.co/KGnscbL/Logo-Dev-Solutions.png' style='width:400PX;'>
                        <h1 style='color:#7c795d;font-family:'Trocchi',serif;font-size:45px;font-weight:normal;line-height:48px;margin:0;'>Notificación DevSolutions</h1>
                        <p style='width:1000px;color:#4c4a37;font-family:'Source Sans Pro',sans-serif;font-size:18px;line-height:32px;margin:24px;'>" + email + @"</p>
                        <h2 style='color:#7c795d;font-family:'Source Sans Pro',sans-serif;font-size:28px;font-weight:400;line-height:32px;margin:24px;'>" + title + @" <b>" + code + @"</b></h2>          
                        <a href='https://localhost:44368/Ticket/ListTickets' role='button'>Ver tickets</a></div>
                        <hr style='margin-top:20px;'>
                        <p style='color:#a0a6b5;font-size:12px;padding-bottom:10px;text-align:center;line-height:18px;'>Has recibido este e - mail porque eres usuario registrado en DevSolutions al amparo de nuestra Política de Privacidad.Este e-mail se ha enviado desde DevSolutions
                        (DGNET Ltd, con número de registro 189977 y domicilio en 64A Cumberland Street, Edimburgo EH3 6RE, Reino Unido)</p>";
            }
            
            
            bool msge;
            string from = "PON TU CORREO AQUÍ";
            string displayName = "DevSolutions";
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from, displayName);
                mail.To.Add(to);
                mail.Subject = asunto;
                mail.Body = body;
                mail.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.office365.com", 587);
                client.Credentials = new NetworkCredential(from, "PON TU CONTRASEÑA AQUÍ");
                client.EnableSsl = true;
                client.Send(mail);
                msge = true;

            }
            catch 
            {
                msge = false;
            }

            return msge;
        }
    }
}