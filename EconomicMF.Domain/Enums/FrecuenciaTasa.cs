using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.Domain.Enums
{
    public enum FrecuenciaTasa
    {
        //nuevos elementos
        Anual,
        Semestral,
        Cuatrimestral,
        Trimestral,
        Bimestral,
        Mensual,
        Semanal,
        Diario,
        //tasasNominales
        AnualCapSemestralmente,
        AnualCapCuatrimestralmente,
        AnualCapTrimestralmente,
        AnualCapBimestralmente,
        AnualCapMensualmente,
        AnualCapSemanalmente,
        AnualCapDiariamnete,
        AnualCapContinuamente,
    }
}
