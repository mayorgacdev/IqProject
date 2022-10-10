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
                return years + months / 12 + days / 365 + hours / 8760;
            }
            switch (periodo)
            {
                //case FrecuenciaTasa.Anual:
                //    return years + months / 12 + days / 365 + hours / 8760;
                case FrecuenciaTasa.Mensual:
                    return years * 12 + months + days / 30 + hours / 730.001M;
                case FrecuenciaTasa.Diario:
                    return years * 365 + months * 30 + days + hours / 24;
                case FrecuenciaTasa.Semestral:
                    return years * 2 + months / 6 + days / 182.5M + hours / 4380;
                case FrecuenciaTasa.Cuatrimestral:
                    return years * 3 + months / 4 + (days / (365 / 3)) + hours / 2920;
                case FrecuenciaTasa.Trimestral:
                    return years * 4 + months / 3 + days / 91.25M + hours / 2190;
                case FrecuenciaTasa.Bimestral:
                    return years * 6 + months / 2 + (days / (365 / 6)) + hours / 1460;
                case FrecuenciaTasa.Semanal:
                    return years * 52 + months * 4 + days / 7 + hours / 168;
                default:
                    return 0;
            }
        }
    }
}
