using EconomicEF.Common.UserCache;
using EconomicMF.AppCore.Processes;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.DataWithList;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Entities.FlowTool;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsProject.FNE
{
    public partial class FrmChargeData : Form
    {
        private readonly IUnitOfWork unitOfWork;
        private Project getProject = new Project();
        private int projectId;

        public FrmChargeData(IUnitOfWork unitOfWork, int projectId)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.projectId = projectId;
        }

        private async void FrmChargeData_Load(object sender, EventArgs e)
        {
            getProject = await ChargeProject();
            GetFNE(getProject);
            ValidateInvesmentEntity();
            ChargeLabels(getProject);
        }

        private void ValidateInvesmentEntity()
        {
            if (getProject.WithFinancing)
            {
                btnAmortizacion.Visible = true;
                tgIsFinancement.Visible = true;
                lblFinancing.Visible = true;
            }
            else
            {
                btnAmortizacion.Visible = false;
                tgIsFinancement.Visible = false;
                lblFinancing.Visible = false;
            }
        }

        private async Task<Project> ChargeProject()
        {
            ProjectClient projectClient = await unitOfWork.ProjectClient.GetAsync(projectId);

            List<Asset> assets = await unitOfWork.AssetClient.GetAllAssetAsync(projectId);
            List<InvesmentArea> invesmentAreas = await unitOfWork.InvesmentArea.GetProjects(projectId);
            List<ProjectCost> projectCosts = await unitOfWork.CostClient.GetAllCost(projectId);
            List<ProjectExpense> projectExpenses = await unitOfWork.ProjectExpense.GetAllExpenses(projectId);
            List<ProjectEntry> projectEntries = await unitOfWork.ProjectEntryClient.GetEntriesAsync(projectId);
            var projectentities = await unitOfWork.InvesmentEntityClient.GetByProjectIdAsync(projectId);

            Project project = new Project()
            {
                Id = projectId,
                SolutionId = projectClient.SolutionId,
                CreationDate = projectClient.CreationDate,
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
                InvestmentEntities = projectentities,
            };


            lblCostCount.Text = projectCosts.Count + "";
            lblCountAsset.Text = assets.Count + "";
            lblEntryCount.Text = projectEntries.Count + "";
            lblExpenseCount.Text = projectExpenses.Count + "";
            lblInversionesCount.Text = invesmentAreas.Count + "";
            lblTasa.Text = "Esperando...";

            return project;
        }

        private void GetFNE(Project project)
        {
            try
            {
                if (project.InvestmentArea.Count == 0 || project.Assets.Count == 0 || ExistAny(project) is false)
                {
                    return;
                }

                dtgFNE.DataSource = null;
                dtgFNE.DataSource = ProjectCalculations.AllFNE(project);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private async void ChargeLabels(Project project)
        {
            try
            {
                if (project.InvestmentArea.Count == 0 || project.Assets.Count == 0 || ExistAny(project) is false)
                {
                    return;
                }


                List<Flujo> flujo = ProjectCalculations.FNE(project);
                lblName.Text = project.Name;
                lblDescription.Text = project.Description;
                lblCreation.Text = project.CreationDate.ToShortDateString();

                if (getProject.WithFinancing)
                {
                    List<InvesmentEntity> invesmentEntities = await unitOfWork.InvesmentEntityClient.GetByProjectIdAsync(DataOnMemory.ProjectId);
                    project.InvestmentEntities = invesmentEntities;

                    decimal tmarMixta = ProjectCalculations.TMAR(project);

                    lblVpn.Text = Math.Round(ProjectCalculations.VPN(flujo, tmarMixta), 2) + " $";
                    lblGetTmar.Text = "TMAR mixta";
                    lblTasa.Text = tmarMixta + " %";
                    lblPeriodo.Text = getProject.Period;
                    lblTir.Text = Math.Round(ProjectCalculations.TIR(flujo, adivinar: tmarMixta), 2) + " %";
                }
                else
                {
                    lblVpn.Text = Math.Round(ProjectCalculations.VPN(flujo, project.TMAR), 2) + " $";
                    lblGetTmar.Text = "TMAR";
                    lblTasa.Text = project.TMAR + " %";
                    lblPeriodo.Text = project.Period;
                    lblTir.Text = ProjectCalculations.TIR(flujo, project.TMAR) + " %";
                    lblTir.Text = Math.Round(ProjectCalculations.TIR(flujo, adivinar: project.TMAR), 2) + " %";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAmortizacion_Click(object sender, EventArgs e)
        {
            new FrmShowAmortización(unitOfWork).ShowDialog();
        }

        private bool ExistAny(Project project)
        {
            bool exist = false;
            
            if (project.ProjectCosts.Count == 0)
            {
                exist = false;
            }
            else
            {
                exist = true;
            }

            if (exist)
                return exist;

            if (project.ProjectExpenses.Count == 0)
            {
                exist = false;
            }
            else
            {
                exist = true;
            }

            if (exist)
                return exist;

            if (project.ProjectEntries.Count == 0)
            {
                exist = false;
            }
            else
            {
                exist = true;
            }

            if (exist)
                return exist;

            return exist;

        }

        private async void tgIsFinancement_CheckedChanged(object sender, EventArgs e)
        {
            if (tgIsFinancement.Checked)
            {
                var project = await ChargeProject();
                project.WithFinancing = true;
                GetFNE(project);
                ChargeLabels(project);
            }
            else
            {

                var project = await ChargeProject();
                project.WithFinancing = false;
                GetFNE(project);
                ChargeLabels(project);
            }
        }
    }
}
