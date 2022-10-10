using EconomicMF.Domain.Entities.Calculos;

namespace EconomicMF.AppCore.Contracts.Calculos
{
    public interface IAnualidadCalculator : IEconomicCalculator<AnnuityDto>
    {
        decimal CalcularPago(AnnuityDto anualidad);
        decimal CalcularGradiente(AnnuityDto series);
        decimal CalcularFuturoGradiente(AnnuityDto serie);
    }
}
