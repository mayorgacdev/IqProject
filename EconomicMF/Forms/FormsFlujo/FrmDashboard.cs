using EconomicEF.Common.UserCache;
using EconomicMF.AppCore.Processes;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.DataWithList;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Entities.FlowTool;
using EconomicMF.Domain.Enums;
using EconomicMF.Domain.Enums.Others;
using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsFlujo
{
    public partial class FrmDashboard : Form
    {
        IUnitOfWork unitOfWork;
        private int projectId;
        private int solutionId;
        //private int proyectoEscogido;
        public FrmDashboard(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            //projectId = DataOnMemory.ProjectId;
            //projectId = 5;
            this.unitOfWork = unitOfWork;
            solutionId = DataOnMemory.SolutionId;
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            LoadDgv();
            pnlGrafico.Controls.Add(chartFNE);
        }
        private async void LoadPieChart(ProyectoMovimiento movimiento, GunaChart chart)
        {
            chart.Datasets.Clear();
            if (projectId!=0)
            {
                List<PastelData> slices = new List<PastelData>();
                chart.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;
                chart.XAxes.Display = false;
                chart.YAxes.Display = false;
                var dataset = new Guna.Charts.WinForms.GunaPieDataset();
                if (movimiento.Equals(ProyectoMovimiento.Ingreso))
                {
                    IEnumerable<ProjectEntry> ingresos = await unitOfWork.ProjectEntryClient.GetEntriesAsync(projectId);
                    slices = ProjectCalculations.TotalIndividual(ingresos.ToList());
                }
                else if (movimiento.Equals(ProyectoMovimiento.Gasto))
                {
                    IEnumerable<ProjectExpense> expenses = await unitOfWork.ProjectExpense.GetAllExpenses(projectId);
                    slices = ProjectCalculations.TotalIndividual(expenses.ToList());
                }
                else if (movimiento.Equals(ProyectoMovimiento.Costo))
                {
                    IEnumerable<ProjectCost> costos = await unitOfWork.CostClient.GetAllCost(projectId);
                    slices = ProjectCalculations.TotalIndividual(costos.ToList());
                }
                else if (movimiento.Equals(ProyectoMovimiento.Inversion))
                {
                    IEnumerable<InvesmentArea> invesments = await unitOfWork.InvesmentArea.GetProjects(projectId);
                    slices = ProjectCalculations.TotalIndividual(invesments.ToList());
                }
                foreach (var slice in slices)
                {
                    dataset.DataPoints.Add(slice.Nombres, (double)slice.Valor);
                }
                chart.Datasets.Add(dataset);
                chart.Update(); 
            }
        }
        private async void LoadDgv()
        {
            dgvFNE.DataSource = await unitOfWork.ProjectClient.GetProjectsAsync(solutionId);
        }

        private async void dgvFNE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                projectId = (int)dgvFNE.Rows[e.RowIndex].Cells[0].Value;
                var proyecto = await unitOfWork.ProjectClient.GetAsync(projectId);
                if (proyecto == null)
                {
                    throw new ArgumentException("Este proyecto no existe");
                }
                Project project = await ChargeProject();
                LoadFNEChart(ProjectCalculations.FNE(project));
                LoadPieChart(ProyectoMovimiento.Ingreso, chartIngresos);
                LoadPieChart(ProyectoMovimiento.Inversion, ChartInversiones);
                LoadPieChart(ProyectoMovimiento.Gasto, chartGastos);
                LoadPieChart(ProyectoMovimiento.Costo, ChartCostos);
            }
        }
        private void LoadFNEChart(List<Flujo> flujos)
        {
            chartFNE.YAxes.GridLines.Display = false;
            chartFNE.Datasets.Clear();
            //chartFNE.HorizontalScroll.Enabled = true;
            //chartFNE.HorizontalScroll.Visible = true;
            chartFNE.Legend.Display = false;
            var dataset = new Guna.Charts.WinForms.GunaBarDataset();
            for(int i=0;i<flujos.Count;i++)
            {
                int width = chartFNE.Width;
                int height = chartFNE.Height;
                dataset.DataPoints.Add(flujos[i].ToString(), (double)flujos[i].FNE);
                chartFNE.Size = new Size(width += 10, height);
            }
            chartFNE.Datasets.Add(dataset);
            chartFNE.Update();
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
