using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Enums.Others;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EconomicMF.Forms
{
    public partial class FrmResolveDepreciation : Form
    {
        private readonly IUnitOfWork solutionServices;
        private int activoId;
        public FrmResolveDepreciation(IUnitOfWork solutionServices)
        {
            InitializeComponent();
            this.solutionServices = solutionServices;
            this.activoId = DataOnMemory.ActivoId;
        }


        private void cmbDepreciation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbDepreciation.SelectedIndex == -1)
            //{
            //    return;
            //}
            //else if (cmbDepreciation.SelectedIndex == 0)
            //{
            //    var data = solutionServices.GetByActivoId(activoId);
            //    dtgvDepreciación.DataSource =  ProjectCalculations.DDDS(data.Precio, data.Tiempo, data.ValorResidual);
            //}
            //else if (cmbDepreciation.SelectedIndex == 1)
            //{
            //    var data = solutionServices.GetByActivoId(activoId);
            //    dtgvDepreciación.DataSource = ProjectCalculations.DSDA(data.Precio, data.Tiempo, data.ValorResidual);
            //}
            //else if (cmbDepreciation.SelectedIndex == 2)
            //{
            //    var data = solutionServices.GetByActivoId(activoId);
            //    dtgvDepreciación.DataSource = ProjectCalculations.DLR(data.Precio, data.Tiempo, data.ValorResidual);
            //}
        }

        private void FrmResolveDepreciation_Load(object sender, EventArgs e)
        {
            cmbDepreciation.Items.AddRange(Enum.GetValues(typeof(Depreciacion)).Cast<object>().ToArray());
        }
    }
}
