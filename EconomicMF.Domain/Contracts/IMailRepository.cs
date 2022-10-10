using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.Domain.Contracts
{
    public interface IMailRepository
    {
        void SendMail(string subject, string body, List<string> recipientMail, string path);
        void SendMail(string subject, string body, List<string> recipientMail);
    }
}
