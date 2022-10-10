using EconomicMF.Domain.Entities.Flows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.Domain.Entities.Calculos
{
    //se quito el abstracto
    public  class EconomicDto
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public decimal ValorPresente { get; set; }
        public decimal ValorFuturo { get; set; }
        public decimal TasaInteres { get; set; }
        public decimal NumPeriodos { get; set; }
        public User Usuario { get; set; }
    }
}
