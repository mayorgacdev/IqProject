using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Enums;
using EconomicMF.Domain.Enums.Conversiones;

namespace EconomicMF.Domain.Entities.Calculos
{
    public class ConversionDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal TasaOriginal { get; set; }
        public decimal TasaActual { get; set; }
        public TipoTasa TipoOriginal { get; set; }
        public TipoTasa TipoActual { get; set; }
        public FrecuenciaTasa FrecCapOriginal { get; set; }
        public FrecuenciaTasa FrecCapActual { get; set; }
        public int CapitalizacionOriginal { get; set; }
        public int CapitalizacionActual { get; set; }
        //public UserDto Usuario { get; set; }
    }
}
