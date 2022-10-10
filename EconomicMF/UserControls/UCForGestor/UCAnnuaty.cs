using EconomicMF.Domain.Entities.Calculos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconomicMF.UserControls.UCForGestor
{
    public partial class UCAnnuaty : UserControl
    {
        private AnnuityDto anualidad;
        public UCAnnuaty(AnnuityDto anualidad)
        {
            InitializeComponent();
            this.anualidad = anualidad;
        }

        private void UCAnnuaty_Load(object sender, EventArgs e)
        {
            ChargeLabels();
        }

        private void ChargeLabels()
        {
            lblPresente.Text = anualidad.ValorPresente.ToString();
            lblFuturo.Text = anualidad.ValorFuturo.ToString();
            lblPer.Text = anualidad.NumPeriodos.ToString();
            lblFrec.Text = anualidad.Periodo.ToString();
            lblAnualidad.Text = anualidad.PagoAnual.ToString();
            lblType.Text = anualidad.TipoAnualidad.ToString();
            lblRate.Text = anualidad.TasaInteres.ToString();
            lblGracia_Incr.Text = (!anualidad.GetType().IsSubclassOf(typeof(AnnuityDto))) ? anualidad.PeriodoGracia.ToString() : 
                ((Serie)anualidad).Crecimiento.ToString();
            lblGracia_Incremento.Text = (!anualidad.GetType().IsSubclassOf(typeof(AnnuityDto))) ? "Per Gracia": "Incremento";
        }
    }
}
