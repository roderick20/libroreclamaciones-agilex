using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Net.Mime;

namespace Admision.Helper
{
    public class SendEmailGmail
    {
        public String ToEmail { get; set; }
        public String Subject { get; set; }
        public String Body { get; set; }

        public String WebRootPath { get; set; }

        public SendEmailGmail(String ToEmail, String Subject, String Body, String WebRootPath)
        {
            this.ToEmail = ToEmail;
            this.Subject = Subject;
            this.Body = Body;
            this.WebRootPath = WebRootPath;
        }

        public String Error { get; set; }

        public bool Send()
        {
            try
            {

                var fromAddress = new MailAddress("agile.sendmail@gmail.com", "Electrosur");
                var toAddress = new MailAddress(ToEmail);//, "To Name");
                const string fromPassword = "Aladino?09";
                string subject = this.Subject;
                

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                String code2 = Guid.NewGuid().ToString();
                string html = this.Body.Replace("$$CODEIMAGEN$$", code2); ;
                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(html, Encoding.UTF8, MediaTypeNames.Text.Html);
                LinkedResource img = new LinkedResource(WebRootPath + "/images/logo.jpg", MediaTypeNames.Image.Jpeg);
                img.ContentId = code2;
                htmlView.LinkedResources.Add(img);


                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject//,
                    //Body = body
                })
                {
                    message.AlternateViews.Add(htmlView);
                    smtp.Send(message);
                }

                
            }
            catch //(Exception ep)
            {
                //ViewBag.Error = ex.Message;
            }


            

            return false;
        }
    }
}