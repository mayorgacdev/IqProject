using EconomicMF.AppCore.Processes;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.DataWithList;
using EconomicMF.Domain.Entities.Flows;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace EconomicMF.UserControls
{
    public partial class UCReports : UserControl
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly int projectId;
        private readonly int solutionId;
        public UCReports(IUnitOfWork projectServices, int projectId, int solutionId)
        {
            InitializeComponent();
            this.unitOfWork = projectServices;
            this.projectId = projectId;
            this.solutionId = solutionId;
        }

        private void UCReports_Load(object sender, EventArgs e)
        {
            ChargeLabels();
        }

        private async void ChargeLabels()
        {
            var data = await unitOfWork.ProjectClient.GetAsync(projectId);

            lblNameProject.Text = data.Name.ToString();
            lblCreacion.Text = data.CreationDate.ToShortDateString();
            lblFinancing.Text = data.WithFinancing.ToString();

            if (data.WithFinancing)
            {
                lblNameRate.Text = "TMAR MIXTA";
                lblRate.Text = data.TMARMixta.ToString();
            }
            else
            {
                lblNameRate.Text = "TMAR";
                lblRate.Text = data.TMAR.ToString();
            }
        }

        private void UCReports_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkSlateGray;
        }

        private void UCReports_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(33, 30, 39);
        }



        private async void btnDowloadReport_Click_1(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath;
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    path = folderBrowserDialog.SelectedPath + "\\";
                }
                LocalReport lr = new LocalReport();
                var projectAsync = await unitOfWork.ProjectClient.GetAsync(projectId);
                bool mejor = false;
                string mimetype = string.Empty;
                string encoding = string.Empty;
                string extension = string.Empty;
                Warning[] warnings;
                string deviceInfo = "";
                string[] streamIds;
                var project = await ChargeProject();
                List<Project> projects = await ChargeProjects();

                mejor = project == ProjectCalculations.GetBestProject(projects, solutionId) ? true : false;

                if (project.WithFinancing)
                {
                    lr.DataSources.Add(new ReportDataSource("DataSet2", ProjectCalculations.FlujosReport(project)));
                    lr.DataSources.Add(new ReportDataSource("DataSet1", ProjectCalculations.DatosProjecto(project, mejor)));
                    lr.DataSources.Add(new ReportDataSource("DataSet3", ProjectCalculations.DatosPastel(project)));
                    lr.DataSources.Add(new ReportDataSource("DataSet4", ProjectCalculations.Financiamientos(project)));
                    lr.ReportPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName.Replace("bin", "ReportFinan.rdlc");
                }
                else
                {
                    lr.DataSources.Add(new ReportDataSource("DataSet2", ProjectCalculations.FlujosReport(project)));
                    lr.DataSources.Add(new ReportDataSource("DataSet1", ProjectCalculations.DatosProjecto(project, mejor)));
                    lr.DataSources.Add(new ReportDataSource("DataSet3", ProjectCalculations.DatosPastel(project)));
                    lr.ReportPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName.Replace("bin", "ReportProyect.rdlc");
                }
                var bytes = lr.Render("PDF", deviceInfo, out mimetype, out encoding, out extension, out streamIds, out warnings);
                File.WriteAllBytes(path + project.Name + ".pdf", bytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private async Task<List<Project>> ChargeProjects()
        {
            var projects = await unitOfWork.ProjectClient.GetProjectsAsync(solutionId);
            List<Project> result = new List<Project>();
            foreach (var item in projects)
            {
                List<Asset> assets = await unitOfWork.AssetClient.GetAllAssetAsync(item.Id);
                List<InvesmentArea> invesmentAreas = await unitOfWork.InvesmentArea.GetProjects(item.Id);
                List<ProjectCost> projectCosts = await unitOfWork.CostClient.GetAllCost(item.Id);
                List<ProjectExpense> projectExpenses = await unitOfWork.ProjectExpense.GetAllExpenses(item.Id);
                List<ProjectEntry> projectEntries = await unitOfWork.ProjectEntryClient.GetEntriesAsync(item.Id);
                List<InvesmentEntity> invesmentEntities = await unitOfWork.InvesmentEntityClient.GetByProjectIdAsync(item.Id);
                Project project = new Project()
                {
                    Id = item.Id,
                    SolutionId = item.SolutionId,
                    CreationDate = item.CreationDate,
                    Name = item.Name,
                    Description = item.Description,
                    Period = item.Period,
                    Duration = item.Duration,
                    WithFinancing = item.WithFinancing,
                    TMAR = item.TMAR,
                    TMARMixta = item.TMARMixta,
                    Contribution = item.Contribution,
                    InvestmentArea = invesmentAreas,
                    ProjectCosts = projectCosts,
                    ProjectExpenses = projectExpenses,
                    ProjectEntries = projectEntries,
                    Assets = assets,
                    InvestmentEntities = invesmentEntities,
                };
                result.Add(project);
            }
            return result;
        }
        private async Task<Project> ChargeProject()
        {

            ProjectClient projectClient = await unitOfWork.ProjectClient.GetAsync(projectId);

            List<Asset> assets = await unitOfWork.AssetClient.GetAllAssetAsync(projectId);
            List<InvesmentArea> invesmentAreas = await unitOfWork.InvesmentArea.GetProjects(projectId);
            List<ProjectCost> projectCosts = await unitOfWork.CostClient.GetAllCost(projectId);
            List<ProjectExpense> projectExpenses = await unitOfWork.ProjectExpense.GetAllExpenses(projectId);
            List<ProjectEntry> projectEntries = await unitOfWork.ProjectEntryClient.GetEntriesAsync(projectId);
            List<InvesmentEntity> invesmentEntities = await unitOfWork.InvesmentEntityClient.GetByProjectIdAsync(projectId);
            int h = 0;
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
                InvestmentEntities = invesmentEntities,
            };

            return project;

        }

    }
}
