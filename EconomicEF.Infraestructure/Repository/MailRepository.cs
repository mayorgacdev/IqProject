using EconomicMF.Domain.Contracts;

namespace EconomicEF.Infraestructure.Repository
{
    public class MailRepository : MasterMailServer, IMailRepository
    {
        public MailRepository()
        {
            senderMail = "iqprojectsolutions@gmail.com";
            password = "jcxqjnqoybjgrqyy";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            InitializeComponnent();
        }
    }
}
