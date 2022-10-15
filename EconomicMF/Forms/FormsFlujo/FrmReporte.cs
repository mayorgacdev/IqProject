using EconomicEF.Common.UserCache;
using EconomicMF.AppCore.Processes;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsFlujo
{
    public partial class FrmReporte : Form
    {
        private readonly IUnitOfWork unitOfWork;

        public FrmReporte(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            Charge();
        }

        private async void Charge()
        {
            var projects = await unitOfWork.ProjectClient.GetProjectsAsync(DataOnMemory.SolutionId);

            dtgFNE.DataSource = (from e in (projects)
                                 select new { e.Id, e.Name, e.Duration, e.Description, e.Period, e.TMAR, e.TMARMixta, e.Contribution }).ToList();

            ChargeUcReport(projects);
        }

        private void ChargeUcReport(IEnumerable<ProjectClient> projects)
        {
            if (projects is null)
            {
                return;
            }
            else
            {
                flpReport.Controls.Clear();
                foreach (var item in projects)
                {
                    UCReports uCProject = new UCReports(unitOfWork, item.Id, DataOnMemory.SolutionId);
                    flpReport.Controls.Add(uCProject);
                }
            }
        }

        private async void dtgFNE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int projectId = 0;
                if (dtgFNE.Rows.Count > 0)
                {
                    projectId = (int)dtgFNE.Rows[dtgFNE.CurrentRow.Index].Cells[0].Value;

                    var projecEntry = await unitOfWork.ProjectEntryClient.GetEntriesAsync(projectId);
                    var projectExpense = await unitOfWork.ProjectExpense.GetAllExpenses(projectId);
                    var projectCost = await unitOfWork.CostClient.GetAllCost(projectId);
                    var investmentAreas = await unitOfWork.InvesmentArea.GetProjects(projectId);

                    var totalEntry = ProjectCalculations.TotalIndividual(projecEntry);
                    var totalExpense = ProjectCalculations.TotalIndividual(projectExpense);
                    var totalCost = ProjectCalculations.TotalIndividual(projectCost);
                    var totalInvestment = ProjectCalculations.TotalIndividual(investmentAreas);


                    lblMontoCosto.Text = totalCost.Max(e => e.Valor) + "";
                    lblMontoIngreso.Text = totalEntry.Max(e => e.Valor) + "";
                    lblMontoGasto.Text = totalExpense.Max(e => e.Valor) + "";
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
