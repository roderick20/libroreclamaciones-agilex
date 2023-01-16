using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace BuzonDeSugerencias.Helper
{
    public class SendEmailSmarter
    {
        public String ToEmail { get; set; }
        public String Subject { get; set; }
        public String Body { get; set; }

        public String SendEmail { get; set; }
        public String SendPassword { get; set; }
        public String MailServer { get; set; }

        public String Logo { get; set; }

        public SendEmailSmarter()
        {
        }

        public SendEmailSmarter(String ToEmail, String Subject, String Body, String WebRootPath)
        {
            this.ToEmail = ToEmail;
            this.Subject = Subject;
            this.Body = Body;
            this.Logo = WebRootPath;
        }

        public String Error { get; set; }

        public bool Send()
        {
            try
            {


                MailMessage mM = new MailMessage();
                mM.From = new MailAddress(SendEmail, "LIBRO DE RECLAMACIONES");
                mM.To.Add(this.ToEmail);
                mM.Subject = this.Subject;
                mM.IsBodyHtml = true;
                //mM.Body = this.Body;

                String code2 = Guid.NewGuid().ToString();

                string html = this.Body.Replace("$$CODEIMAGEN$$", code2); ;
                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(html, Encoding.UTF8, MediaTypeNames.Text.Html);
                LinkedResource img = new LinkedResource(Logo, MediaTypeNames.Image.Jpeg);
                img.ContentId = code2;
                htmlView.LinkedResources.Add(img);
                mM.AlternateViews.Add(htmlView);

                SmtpClient smtp = new SmtpClient(MailServer);
                smtp.Port = 25;
                smtp.Credentials = new NetworkCredential(SendEmail, SendPassword);
                //smtp.EnableSsl = true;
                smtp.Send(mM);

                return true;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }

            return false;
        }
    }
}
