using EconomicMF.Domain.Entities.Calculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.AppCore.Contracts.Calculos
{
    public interface IEconomicCalculator<TEntity> where TEntity : EconomicDto
    {
        decimal CalcularTasa(TEntity economicClass);
        decimal CalcularTiempo(TEntity economicClass);
        decimal CalcularVP(TEntity economicClass);
        decimal CalcularVF(TEntity economicClass);
    }
}
