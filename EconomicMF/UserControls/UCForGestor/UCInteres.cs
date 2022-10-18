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
    public partial class UCInteres : UserControl
    {
        private RateDto interes;
        public UCInteres(RateDto interes)
        {
            InitializeComponent();
            this.interes = interes;
        }

        private void UCInteres_Load(object sender, EventArgs e)
        {
            ChargeLabels();
        }

        private void ChargeLabels()
        {
            lblPresente.Text = interes.PresentValue.ToString();
            lblFuturo.Text = interes.FutureValue.ToString();
            lblMoment.Text = interes.NumPeriodos.ToString();
            lblFrec.Text = interes.FrecuenciaTasa.ToString();
            lblRate.Text = interes.TasaInteres.ToString();
        }
    }
}
