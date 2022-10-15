using EconomicEF.Common.UserCache;
using EconomicMF.AppCore.Processes;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.DataWithList;
using EconomicMF.Domain.Entities.Flows;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private async void btnDowloadReport_Click(object sender, EventArgs e)
        {
            /*
            string a = Application.StartupPath;
            Microsoft.Reporting.WinForms.LocalReport lr = new Microsoft.Reporting.WinForms.LocalReport();
            var projectAsync = await unitOfWork.ProjectClient.GetAsync(projectId);
            bool mejor = false;
            string mimetype = string.Empty;
            string encoding = string.Empty;
            string extension = string.Empty;
            Microsoft.Reporting.WinForms.Warning[] warnings;
            string deviceInfo = "";
            string[] streamIds;
            var project = projectAsync;
            var projects = await unitOfWork.ProjectClient.GetAllAsync();

            mejor = project == ProjectCalculations.GetBestProject(projects.ToList(), projectId) ? true : false;

            if (project.EntidadInvs.Count >= 1)
            {
                lr.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", ProjectCalculations.FlujosReport(project)));
                lr.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ProjectCalculations.DatosProjecto(project, mejor)));
                lr.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet3", ProjectCalculations.DatosPastel(project)));
                lr.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet4", ProjectCalculations.Financiamientos(project)));
                lr.ReportPath = Path.Combine(Application.StartupPath, "ReportFinan.rdlc");
            }
            else
            {
                lr.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", ProjectCalculations.FlujosReport(project)));
                lr.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ProjectCalculations.DatosProjecto(project, mejor)));
                lr.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet3", ProjectCalculations.DatosPastel(project)));
                lr.ReportPath = Path.Combine(Application.StartupPath, "ReportProyect.rdlc");
            }
            var bytes = lr.Render("PDF", deviceInfo, out mimetype, out encoding, out extension, out streamIds, out warnings);
            File.WriteAllBytes(DataOnMemory.Path + project.Name + ".pdf", bytes);*/

            // TODO: recuerda rellenar ProjectWithList 
        }

        private void btnDowloadReport_Click_1(object sender, EventArgs e)
        {

        }

        private async Task<Project> ChargeProject()
        {
            ProjectClient projectClient = await unitOfWork.ProjectClient.GetAsync(projectId);

            List<Asset> assets = await unitOfWork.AssetClient.GetAllAssetAsync(projectId);
            List<InvesmentArea> invesmentAreas = await unitOfWork.InvesmentArea.GetProjects(projectId);
            List<ProjectCost> projectCosts = await unitOfWork.CostClient.GetAllCost(projectId);
            List<ProjectExpense> projectExpenses = await unitOfWork.ProjectExpense.GetAllExpenses(projectId);
            List<ProjectEntry> projectEntries = await unitOfWork.ProjectEntryClient.GetEntriesAsync(projectId);

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
            };

            return project;

        }
    }
}
