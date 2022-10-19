using EconomicMF.AppCore.Processes;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Enums.Others;
using EconomicMF.SettingForms;
using ExportToExcel;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsProject.FNE
{
    public partial class FrmShowDepreciation : Form
    {
        private ProjectClient projectClient;
        private Asset item;

        public FrmShowDepreciation(ProjectClient projectClient, Asset asset)
        {
            InitializeComponent();
            this.projectClient = projectClient;
            item = asset;
        }

        private void FrmShowDepreciation_Load(object sender, EventArgs e)
        {
            ChargeDtg();
        }

        private void ChargeDtg()
        {
            string dep = item.DepreciationRate;
            lblNameProject.Text = projectClient.Name;
            lblNameAsset.Text = item.Name;
            lblMethod.Text = item.DepreciationRate;
            lblDuration.Text = projectClient.Duration+" " + projectClient.Period;
            Charge(dep);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Charge(string dep)
        {
            dtgFNE.DataSource = null;

            if (dep.Equals("DDDS"))
            {
                dtgFNE.DataSource = ProjectCalculations.DDDS(item.Amount, projectClient.Duration, item.AmountResidual, 2);
                ChargeDTGC(true);
            }
            if (dep.Equals("DSDA"))
            {
                dtgFNE.DataSource = ProjectCalculations.DSDA(item.Amount, projectClient.Duration, item.AmountResidual);
                ChargeDTGC(false);
            }
            if (dep.Equals("DLR"))
            {
                dtgFNE.DataSource = ProjectCalculations.DLR(item.Amount, projectClient.Duration, item.AmountResidual);
                ChargeDTGC(true);
            }
        }

        private void ChargeDTGC(bool stonks)
        {
            if (stonks)
            {
                dtgFNE.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgFNE.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgFNE.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgFNE.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                dtgFNE.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgFNE.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgFNE.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgFNE.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgFNE.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dtgFNE.Rows.Count > 0)
            {

                Random random = new Random();

                if (item is null)
                {
                    return;
                }

                string path = string.Empty;
                string get = string.Empty;

                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    path = folderBrowserDialog.SelectedPath + "\\";
                    get = folderBrowserDialog.SelectedPath + "\\";
                }

                if (item.DepreciationRate.Equals("DDDS"))
                {
                    path = $"{path}dep{random.Next(20, 555)}.xlxs";
                    CreateExcelFile.CreateExcelDocument(ProjectCalculations.DDDS(item.Amount, item.Terms, item.AmountResidual, 2), path);
                    path = string.Empty;
                    path = get;
                }
                else if (item.DepreciationRate.Equals("DSDA"))
                {
                    path = $"{path}dep{random.Next(20, 555)}.xlxs";
                    CreateExcelFile.CreateExcelDocument(ProjectCalculations.DSDA(item.Amount, item.Terms, item.AmountResidual), path);
                    path = string.Empty;
                    path = get;
                }
                else
                {
                    path = $"{path}dep{random.Next(20, 555)}.xlxs";
                    CreateExcelFile.CreateExcelDocument(ProjectCalculations.DSDA(item.Amount, item.Terms, item.AmountResidual), path);
                    path = string.Empty;
                    path = get;
                }
            }
        }
    }
}