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

                
                try
                {
                    smtp.Send(m);
                }
                catch (Exception)
                {
                    throw;
                }
     
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