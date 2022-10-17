using EconomicMF.AppCore.Processes;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Enums.Others;
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
        private Asset assetClient;

        public FrmShowDepreciation(ProjectClient projectClient, Asset asset)
        {
            InitializeComponent();
            this.projectClient = projectClient;
            assetClient = asset;
        }

        private void FrmShowDepreciation_Load(object sender, EventArgs e)
        {
            ChargeDtg();
        }

        private void ChargeDtg()
        {
            string dep = assetClient.DepreciationRate;
            lblNameProject.Text = projectClient.Name;
            lblNameAsset.Text = assetClient.Name;
            lblMethod.Text = assetClient.DepreciationRate;
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
                dtgFNE.DataSource = ProjectCalculations.DDDS(assetClient.Amount, projectClient.Duration, assetClient.AmountResidual, 2);
                ChargeDTGC(true);
            }
            if (dep.Equals("DSDA"))
            {
                dtgFNE.DataSource = ProjectCalculations.DSDA(assetClient.Amount, projectClient.Duration, assetClient.AmountResidual);
                ChargeDTGC(false);
            }
            if (dep.Equals("DLR"))
            {
                dtgFNE.DataSource = ProjectCalculations.DLR(assetClient.Amount, projectClient.Duration, assetClient.AmountResidual);
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
                ExportarDatos(dtgFNE);
            }
        }

        private void ExportarDatos(PoisonDataGridView data)
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
    }
}