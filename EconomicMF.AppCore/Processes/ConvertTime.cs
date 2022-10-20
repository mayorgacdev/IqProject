using EconomicMF.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.AppCore.Processes
{
    public static class ConvertTime
    {
        public static decimal GetTime(FrecuenciaTasa periodo, decimal years, decimal months, decimal days, decimal hours)
        {
            if (periodo.ToString().Contains("Anual", StringComparison.CurrentCultureIgnoreCase))
            {
                return Math.Round((years + months / 12 + days / 365 + hours / 8760),4);
            }
            switch (periodo)
            {
                case FrecuenciaTasa.Mensual:
                    return Math.Round((years * 12 + months + days / 30 + hours / 730.001M),4);
                case FrecuenciaTasa.Diario:
                    return Math.Round((years * 365 + months * 30 + days + hours / 24),4);
                case FrecuenciaTasa.Semestral:
                    return Math.Round((years * 2 + months / 6 + days / 182.5M + hours / 4380),4);
                case FrecuenciaTasa.Cuatrimestral:
                    return Math.Round((years * 3 + months / 4 + (days / (365 / 3)) + hours / 2920), 4);
                case FrecuenciaTasa.Trimestral:
                    return Math.Round((years * 4 + months / 3 + days / 91.25M + hours / 2190), 4);
                case FrecuenciaTasa.Bimestral:
                    return Math.Round((years * 6 + months / 2 + (days / (365 / 6)) + hours / 1460), 4);
                case FrecuenciaTasa.Semanal:
                    return Math.Round((years * 52 + months * 4 + days / 7 + hours / 168), 4);
                default:
                    return 0;
            }
        }
    }
}
