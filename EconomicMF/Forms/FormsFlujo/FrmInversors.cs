using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsFlujo
{
    public partial class FrmInversors : Form
    {
        private readonly IUnitOfWork unitOfWork;
        public FrmInversors(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
        }

        private void FrmInversors_Load(object sender, EventArgs e)
        {
            Charge();
        }

        private async void Charge()
        {
            var projectSolutions = (await unitOfWork.ProjectClient.GetProjectsAsync(DataOnMemory.SolutionId));
            var forDtgFne = from e in projectSolutions select new { e.Id, e.Name, e.Duration, e.WithFinancing, e.TMAR, e.TMARMixta, e.Contribution };
            dtgFNE.DataSource = forDtgFne.ToList();

            if (dtgFNE.Rows.Count > 0)
            {
                var test = dtgFNE.Rows[0].Cells[0].Value;
                int projectId = (int)dtgFNE.CurrentRow.Cells[0].Value;
                dtgInvestment.DataSource = (from e in (await unitOfWork.InvesmentEntityClient.GetByProjectIdAsync(projectId)) 
                                           select new { e.Id, e.ProjectId, e.Name, e.Contribution, e.Rate, e.TipoDeAmortización, e.Email, e.LoanTerm}).ToList();
            }


        }
    }
}
