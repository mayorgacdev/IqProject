using System;

namespace EconomicMF.Domain.Entities
{
    public class EmailProp
    {
        public Guid Guid { get; set; }
        public string Email { get; set; }
        public string Ruta { get; set; }

        public EmailProp()
        {
           Guid = Guid.NewGuid();
        }
    }
}
