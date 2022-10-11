using EconomicEF.Common.UserCache;
using EconomicMF.AppCore.Processes;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.DataWithList;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Entities.FlowTool;
using EconomicMF.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsProject.FNE
{
    public partial class FrmChargeData : Form
    {
        private readonly IUnitOfWork unitOfWork;
        private Project getProject = new Project();

        public FrmChargeData(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
        }

        private async void FrmChargeData_Load(object sender, EventArgs e)
        {
            getProject = await ChargeProject();
            GetFNE();
            ChargeLabels();
        }

        private async Task<Project> ChargeProject()
        {
            ProjectClient projectClient = await unitOfWork.ProjectClient.GetAsync(DataOnMemory.ProjectId);

            List<Asset> assets = await unitOfWork.AssetClient.GetAllAssetAsync(DataOnMemory.ProjectId);
            List<InvesmentArea> invesmentAreas = await unitOfWork.InvesmentArea.GetProjects(DataOnMemory.ProjectId);
            List<ProjectCost> projectCosts = await unitOfWork.CostClient.GetAllCost(DataOnMemory.ProjectId);
            List<ProjectExpense> projectExpenses = await unitOfWork.ProjectExpense.GetAllExpenses(DataOnMemory.ProjectId);
            List<ProjectEntry> projectEntries = await unitOfWork.ProjectEntryClient.GetEntriesAsync(DataOnMemory.ProjectId);

            if (projectClient.WithFinancing)
            {
                List<InvesmentEntity> invesmentEntities = await unitOfWork.InvesmentEntityClient.GetByProjectIdAsync(DataOnMemory.ProjectId);

                Project project = new Project()
                {
                    Id = DataOnMemory.ProjectId,
                    SolutionId = projectClient.SolutionId,
                    Name = projectClient.Name,
                    Description = projectClient.Description,
                    Period = projectClient.Period,
                    Duration = projectClient.Duration,
                    WithFinancing = projectClient.WithFinancing,
                    TMAR = projectClient.TMAR,
                    TMARMixta = projectClient.TMARMixta,
                    Contribution = projectClient.Contribution,
                    InvestmentArea = invesmentAreas,
                    ProjectCosts = projectCosts,
                    InvestmentEntities = invesmentEntities,
                    ProjectExpenses = projectExpenses,
                    ProjectEntries = projectEntries,
                    Assets = assets,
                };

                return project;
            }
            else
            {
                Project project = new Project()
                {
                    Id = DataOnMemory.ProjectId,
                    SolutionId = projectClient.SolutionId,
                    Name = projectClient.Name,
                    Description = projectClient.Description,
                    Period = projectClient.Period,
                    Duration = projectClient.Duration,
                    WithFinancing = projectClient.WithFinancing,
                    TMAR = projectClient.TMAR,
                    TMARMixta = projectClient.TMARMixta,
                    Contribution = projectClient.Contribution,
                    InvestmentArea = invesmentAreas,
                    ProjectCosts = projectCosts,
                    ProjectExpenses = projectExpenses,
                    ProjectEntries = projectEntries,
                    Assets = assets,
                };

                return project;
            }

        }

        private void GetFNE()
        {
            dtgFNE.DataSource =  ProjectCalculations.AllFNE(getProject);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dtgFNE.Rows.Count > 0)
            {
                ExportarDatos(dtgFNE);
            }
        }


        public void ExportarDatos(DataGridView data)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
                application.Application.Workbooks.Add(true);
                int indice = 0;
                foreach (DataGridViewColumn i in data.Columns)
                {
                    indice++;
                    application.Cells[1, indice] = i.Name;
                }
                int indicefila = 0;
                foreach (DataGridViewRow fila in data.Rows)
                {
                    indicefila++;
                    if (indicefila == 1)
                    {
                        //indicefila++;
                    }
                    indice = 0;
                    foreach (DataGridViewColumn columna in data.Columns)
                    {
                        indice++;
                        application.Cells[indicefila + 1, indice] = fila.Cells[columna.Name].Value;
                    }

                }
                application.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargeLabels()
        {
            List<Flujo> flujo = ProjectCalculations.FNE(getProject);
         
            if (getProject.WithFinancing)
            {
                decimal tmarMixta = CalculusOnMemory.GetTmar(getProject);
                lblTir.Text = Math.Round(ProjectCalculations.TIR(flujo, adivinar: tmarMixta), 2) + " %";
                lblVpn.Text = Math.Round(ProjectCalculations.VPN(flujo, tmarMixta), 2) + " $";
                lblGetTmar.Text = "TMAR mixta";
                lblTasa.Text = tmarMixta + "";
                lblPeriodo.Text = getProject.Period;
            }
            else
            {
                lblTir.Text = Math.Round(ProjectCalculations.TIR(flujo, adivinar: getProject.TMAR), 2) + " %";
                lblVpn.Text = Math.Round(ProjectCalculations.VPN(flujo, getProject.TMAR), 2) + " $";
                lblGetTmar.Text = "TMAR";
                lblTasa.Text = getProject.TMAR + " %";
                lblPeriodo.Text = getProject.Period;
                lblTir.Text = ProjectCalculations.TIR(flujo, getProject.TMAR) + " %";
            }
        }
        private void btnAmortizacion_Click(object sender, EventArgs e)
        {

        }
    }
}
