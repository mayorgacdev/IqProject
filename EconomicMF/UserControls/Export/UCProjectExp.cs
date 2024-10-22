﻿using EconomicEF.Infraestructure.Repository;
using EconomicMF.AppCore.Processes;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.DataWithList;
using EconomicMF.Domain.Entities.Flows;
using ExportToExcel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconomicMF.UserControls.Export
{
    public partial class UCProjectExp : UserControl
    {
        private IUnitOfWork unitOfWork;
        private int projectId;
        public UCProjectExp(IUnitOfWork unitOfWork, int projectId)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.projectId = projectId;
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

            return project;
        }

        private async void ChargeLbl()
        {
            var project = await ChargeProject();

            lblName.Text = project.Name;
            lblPeriod.Text = project.Period;
        }

        private void UCProjectExp_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(33, 30, 70);
        }

        private void UCProjectExp_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(33, 30, 39);
        }

        private void UCProjectExp_Load(object sender, EventArgs e)
        {
            ChargeLbl();
        }

        private async void btnDowloadReport_Click(object sender, EventArgs e)
        {
            var project = await ChargeProject();
            var calculations = ProjectCalculations.AllFNE(project);

            if (calculations.Rows.Count > 0)
            {
                string path = string.Empty;
                string get = string.Empty;
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    path = folderBrowserDialog.SelectedPath + "\\";
                    get = folderBrowserDialog.SelectedPath + "\\";
                }

                path = $"{path}{project.Name}.xlsx";
                CreateExcelFile.CreateExcelDocument(calculations, path);
                path = String.Empty;
                path = get;
            }
            else
            {
                return;
            }
        }
    }
}
