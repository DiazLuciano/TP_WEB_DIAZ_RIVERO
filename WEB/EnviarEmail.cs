using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace WEB
{
    public class EnviarEmail
    {
        MailMessage m = new MailMessage();
        SmtpClient smtp = new SmtpClient();
        

        public bool EnviarCorreo(string email)
        {
            try
            {

                m.To.Add(email);
                m.Subject = "PROBANDO";
                m.SubjectEncoding = System.Text.Encoding.UTF8;

                m.Body = "PROBANDOOOO";
                m.BodyEncoding = System.Text.Encoding.UTF8;
                m.From = new MailAddress("luchodiaz1995@gmail.com");

                smtp.Credentials = new NetworkCredential("luchodiaz1995@gmail.com","leonardmo-70");

                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Host = "smtp.gmail.com";

                try
                {
                    smtp.Send(m);
                }
                catch (Exception)
                {
                    throw;
                }
                //m.From =new MailAddress("luchodiaz1995@gmail.com","Luciano Diaz");
                //m.To.Add(new MailAddress(email));
                //m.Subject = "PRUEBA";
                //smtp.Host = "smtp.gmail.com";
                //smtp.Port = 587;
                //m.Body = "hola";
                //smtp.Credentials = new NetworkCredential("luchodiaz1995@gmail.com", "");
                //smtp.EnableSsl = true;
                //smtp.Send(m);
     
                return true;


            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}