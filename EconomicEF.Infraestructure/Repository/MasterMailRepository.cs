using EconomicMF.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EconomicEF.Infraestructure.Repository
{
    public abstract class MasterMailServer
    {
        //Atributos
        public List<EmailProp> emailProps { get; set; } = new List<EmailProp>();
        private SmtpClient smtpClient;
        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        //Inicializar propiedades del cliente SMTP
        protected void InitializeComponnent()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }

        public async void SenFiles(string subject, string body, List<string> recipientMail)
        {
            var mailMessage = new MailMessage();
            try
            {
               
                mailMessage.From = new MailAddress(senderMail);
                foreach (string mail in recipientMail)
                {
                    mailMessage.To.Add(mail);
                   
                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;

                foreach (var item in emailProps)
                {
                    mailMessage.Attachments.Add(new Attachment(item.Ruta));//obtiene la ruta del archivo a enviar
                }

                emailProps.Clear();
                await (smtpClient.SendMailAsync(mailMessage));//Enviar mensaje
            }
            catch (Exception)
            {
                throw;
            }

        }

        public async void SendMail(string subject, string body, List<string> recipientMail)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(senderMail);
                foreach (string mail in recipientMail)
                {
                    mailMessage.To.Add(mail);
                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                await smtpClient.SendMailAsync(mailMessage);//Enviar mensaje
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddMessage(EmailProp emailProp)
        {
            emailProps.Add(emailProp);
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address.Equals(email);
            }
            catch
            {
                return false;
            }
        }
    }
}
