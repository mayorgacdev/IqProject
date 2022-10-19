using EconomicEF.Common.UserCache;
using EconomicMF.AppCore.Processes;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Forms.FormsProject;
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
                                 select new { e.Id, e.Name, e.Duration, e.Description, e.Period, e.TMAR,
                                     e.TMARMixta, e.Contribution }).ToList();
            dtgFNE.Columns[0].Visible = false;

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
                    var assets = await unitOfWork.AssetClient.GetAllAssetAsync(projectId);

                    var totalEntry = ProjectCalculations.TotalIndividual(projecEntry);
                    var totalExpense = ProjectCalculations.TotalIndividual(projectExpense);
                    var totalCost = ProjectCalculations.TotalIndividual(projectCost);
                    var totalInvestment = ProjectCalculations.TotalIndividual(investmentAreas);


                    var maxCost = totalCost.Max(e => e.Valor);
                    var minEntry = totalEntry.Min(e => e.Valor);
                    var MaxExpense = totalExpense.Max(e => e.Valor);
                    var assetExpensive = assets.Max(e => e.Amount);

                    lblMontoCosto.Text   = maxCost + " $";
                    lblMontoIngreso.Text = minEntry + " $";
                    lblMontoGasto.Text   = MaxExpense + " $";
                    lblMontoActivo.Text = assetExpensive + " $";

                    lblNombreCosto.Text = totalCost.FirstOrDefault(e => e.Valor == maxCost)?.Nombres;
                    lblNombreIngreso.Text = totalEntry.FirstOrDefault(e => e.Valor == minEntry)?.Nombres;
                    lblNombreGasto.Text = totalExpense.FirstOrDefault(e => e.Valor == MaxExpense)?.Nombres;
                    lblNombreActivo.Text = assets.FirstOrDefault(e => e.Amount == assetExpensive)?.Name;
                    lblInversiónTotal.Text = assets.Sum(e => e.Amount) + investmentAreas.Sum(e => e.Amount) + " $";
                }
                else
                    return;
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos, le faltan datos importantes a su proyecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            FrmSendReportToInversor frmSendReportToInversor = new FrmSendReportToInversor(unitOfWork);
            frmSendReportToInversor.ShowDialog();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var projects = await unitOfWork.ProjectClient.GetProjectsAsync(DataOnMemory.SolutionId);

            var filter = (from r in (projects)
                                select new { r.Id, r.Name, r.Duration, r.Description, r.Period, r.TMAR, r.TMARMixta, r.Contribution }).ToList();


            dtgFNE.DataSource = filter.Where(g => g.Name.Equals(txtNameProject.Texts)).ToList();
            dtgFNE.Columns[0].Visible = false;
        }

        private void txtNameProject__TextChanged(object sender, EventArgs e)
        {
            if (txtNameProject.Texts.Equals(String.Empty))
            {
                Charge();
            }
        }
    }
}
