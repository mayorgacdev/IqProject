using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using System;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsFlujo
{
    public partial class FrmReporte : Form
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly int solutionId;
        public FrmReporte(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.solutionId = DataOnMemory.SolutionId;
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {

        }

        private void Charge()
        {

        }
    }
}
