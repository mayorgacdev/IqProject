using EconomicMF.Domain.Entities.Calculos;
using EconomicMF.Domain.Enums;
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
            lblPresente.Text = anualidad.PresentValue.ToString();
            lblFuturo.Text = anualidad.FutureValue.ToString();
            lblPer.Text = anualidad.NumPeriodos.ToString();
            lblFrec.Text = anualidad.Periodo.ToString();
            lblAnualidad.Text = anualidad.PagoAnual.ToString();
            //lblIncr.Text = anualidad.TipoAnualidad.ToString();
            lblRate.Text = anualidad.TasaInteres.ToString();
            lblPerGracia.Text = anualidad.PeriodoGracia.ToString();
            if (anualidad.Crecimiento.Equals(TipoCrecimiento.Geometrico))
            {
                lblIncr.Text = $"{anualidad.Crecimiento*100} %";
            }
            else
            {
                lblIncr.Text = anualidad.Crecimiento.ToString();
            }
        }
    }
}
