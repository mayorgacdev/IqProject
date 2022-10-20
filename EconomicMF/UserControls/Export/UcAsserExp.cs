using DocumentFormat.OpenXml.Office2010.CustomUI;
using EconomicMF.AppCore.Processes;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.DataWithList;
using EconomicMF.Domain.Entities.Flows;
using ExportToExcel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconomicMF.UserControls.Export
{
    public partial class UcAsserExp : UserControl
    {
        private IUnitOfWork unitOfWork;
        private int projectId;

        public UcAsserExp(IUnitOfWork unitOfWork, int projectId)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.projectId = projectId;
        }

        private async Task<Project> ChargeProject()
        {
            ProjectClient projectClient = await unitOfWork.ProjectClient.GetAsync(projectId);

            List<Asset> assets = await unitOfWork.AssetClient.GetAllAssetAsync(projectId);

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
                Assets = assets,
            };

            return project;
        }

        private async void btnDowloadReport_Click(object sender, System.EventArgs e)
        {
            var project = await ChargeProject();
            Random random = new Random();

            if (project.Assets.Count > 0)
            {
                string path = string.Empty;
                string get = string.Empty;
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    path = folderBrowserDialog.SelectedPath + "\\";
                    get = folderBrowserDialog.SelectedPath + "\\";
                }

                foreach (var item in project.Assets)
                {
                    if (item.IsDepreciable) { 
                    if (item.DepreciationRate.Equals("DDDS"))
                    {
                        path = $"{path}dep{random.Next(20,555)}.xlsx";
                        CreateExcelFile.CreateExcelDocument(ProjectCalculations.DDDS(item.Amount, item.Terms, item.AmountResidual, 2), path);
                        path = string.Empty;
                        path = get;
                    }
                    else if (item.DepreciationRate.Equals("DSDA"))
                    {
                        path = $"{path}dep{random.Next(20, 555)}.xlsx";
                        CreateExcelFile.CreateExcelDocument(ProjectCalculations.DSDA(item.Amount, item.Terms, item.AmountResidual), path);
                        path = string.Empty;
                        path = get;
                    }
                    else
                    {
                        path = $"{path}dep{random.Next(20, 555)}.xlsx";
                        CreateExcelFile.CreateExcelDocument(ProjectCalculations.DLR(item.Amount, item.Terms, item.AmountResidual), path);
                        path = string.Empty;
                        path = get;
                    }
                    }
                }
            }
            else
            {
                MessageBox.Show("No tienes activos en tu proyecto que se puedan depreciar");
            }

        }

        private void UcAsserExp_Load(object sender, EventArgs e)
        {
            Charge();
        }

        private async void Charge()
        {
            var project = await ChargeProject();

            lblName.Text = project.Name;
            lblPeriod.Text = project.Assets.Count + "";
        }

        private void UcAsserExp_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(33, 30, 39);
        }

        private void UcAsserExp_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(33, 30, 70);
        }
    }
}
