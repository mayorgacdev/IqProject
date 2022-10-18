using EconomicMF.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.Domain.Contracts
{
    public interface IMailRepository
    {
        bool IsValidEmail(string email);
        List<EmailProp> emailProps { get; set; }
        void SendMail(string subject, string body, List<string> recipientMail);
        void SenFiles(string subject, string body, List<string> recipientMail);
        void AddMessage(EmailProp emailProp);
    }
}
