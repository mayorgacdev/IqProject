//using EconomicMF.Domain.Entities.Calculos;
using EconomicMF.Domain.Entities;
using EconomicMF.Domain.Entities.Calculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.AppCore.Contracts.Calculos
{
    public interface IConversor
    {
        decimal Convertir(ConversionDto conversor);
    }
}
