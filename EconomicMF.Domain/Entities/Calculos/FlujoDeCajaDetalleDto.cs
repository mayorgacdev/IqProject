﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.Domain.Entities.Calculos
{
    public class FlujoDeCajaDetalleDto
    {
        public int Id { get; set; }
        public int IdFlujoDeCaja { get; set; }
        public int IdEconomic { get; set; }
    }
}
