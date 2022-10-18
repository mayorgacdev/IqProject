using EconomicMF.Domain.Entities.Calculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.AppCore.Contracts.Calculos
{
    public interface IEconomicCalculator<T> 
    {
        decimal CalcularTasa(T economicClass);
        decimal CalcularTiempo(T economicClass);
        decimal CalcularVP(T economicClass);
        decimal CalcularVF(T economicClass);
    }
}
