using EconomicEF.Common.UserCache;
using EconomicMF.AppCore.Processes;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.DataWithList;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Entities.FlowTool;
using ExportToExcel;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsProject.FNE
{
    public partial class FrmShowAmortización : Form
    {
        private IUnitOfWork unitOfWork;
        List<List<Amortizacion>> Amortizacions = new List<List<Amortizacion>>();
        List<InvesmentEntity> invesmentEntities = new List<InvesmentEntity>();
        private ProjectClient ProjectClient = new ProjectClient();
        private int index = 0;
        private int countM = 0;

        public FrmShowAmortización(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
        }

        private void FrmShowAmortización_Load(object sender, EventArgs e)
        {
            dtgFNE.DataSource = null;
            ValidateButtons();
        }

        private async void ValidateButtons()
        {
            ProjectClient = await unitOfWork.ProjectClient.GetAsync(DataOnMemory.ProjectId);

            invesmentEntities =  await unitOfWork.InvesmentEntityClient.GetByProjectIdAsync(DataOnMemory.ProjectId);
            Project project = new Project()
            {
                Duration = ProjectClient.Duration,
                Assets = await unitOfWork.AssetClient.GetAllAssetAsync(DataOnMemory.ProjectId),
                InvestmentEntities = invesmentEntities,
                InvestmentArea = await unitOfWork.InvesmentArea.GetProjects(DataOnMemory.ProjectId),
            };

            Amortizacions = ProjectCalculations.Amortizaciones(project);

            countM = Amortizacions.Count;
            
            if (countM == 1)
            {
                dtgFNE.DataSource = null;
                btnAnterior.Visible = false;
                btnSiguiente.Visible = false;
                ChargeDtg(index);
                ChargeLabels(invesmentEntities[index], ProjectClient.Duration, ProjectClient.Period);
            }
            else
            {
                dtgFNE.DataSource = null;

                btnAnterior.Visible = true;
                btnSiguiente.Visible = true;
                index = 0;
                ChargeDtg(index);
                ChargeLabels(invesmentEntities[index], ProjectClient.Duration, ProjectClient.Period);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            index++;

            if (index == countM)
            {
                index = 0;
                ChargeDtg(index);
                ChargeLabels(invesmentEntities[index], ProjectClient.Duration, ProjectClient.Period);
            }
            else
            {
                ChargeDtg(index);
                ChargeLabels(invesmentEntities[index], ProjectClient.Duration, ProjectClient.Period);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            index--;

            if (index <= 0)
            {
                index = countM - 1;
                ChargeDtg(index);
                ChargeLabels(invesmentEntities[index], ProjectClient.Duration, ProjectClient.Period);
            }
            else
            {
                ChargeDtg(index);
                ChargeLabels(invesmentEntities[index], ProjectClient.Duration, ProjectClient.Period);
            }
        }

        private void ChargeLabels(InvesmentEntity invesmentEntity, int duration, string period)
        {
            lblContribution.Text = invesmentEntity.Contribution + " %";
            lblDuration.Text = $"{duration} {period}";
            lblNameInvestment.Text = invesmentEntity.Name;
            lblRate.Text = invesmentEntity.Rate + " %";

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChargeDtg(int index)
        {
            if (dtgFNE.Rows.Count > 0)
            {
                if (index > countM || index < 0)
                {
                    return;
                }
                else
                {
                    dtgFNE.DataSource = null;
                    dtgFNE.DataSource = Amortizacions[index];
                }

                dtgFNE.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgFNE.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgFNE.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgFNE.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgFNE.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
                for (int i = 0; i <= dtgFNE.Columns.Count - 1; i++)
                {
                    // Store Auto Sized Widths:
                    int colw = dtgFNE.Columns[i].Width;

                    // Remove AutoSizing:
                    dtgFNE.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                    // Set Width to calculated AutoSize value:
                    dtgFNE.Columns[i].Width = colw;
                }
            }
            else
            {
                dtgFNE.DataSource = Amortizacions[index];
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dtgFNE.Rows.Count > 0)
            {
                Random random = new Random();

                string path = string.Empty;
                string get = string.Empty;
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    path = folderBrowserDialog.SelectedPath + "\\";
                    get = folderBrowserDialog.SelectedPath + "\\";
                }

                path = $"{path}Amortización{random.Next(20, 555)}Amt.xlsx";
                CreateExcelFile.CreateExcelDocument(Amortizacions[index], path);
            }
        }

        private void ExportarDatos(PoisonDataGridView dtgFNE)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
                application.Application.Workbooks.Add(true);
                int indice = 0;
                foreach (DataGridViewColumn i in dtgFNE.Columns)
                {
                    indice++;
                    application.Cells[1, indice] = i.Name;
                }
                int indicefila = 0;
                foreach (DataGridViewRow fila in dtgFNE.Rows)
                {
                    indicefila++;
                    if (indicefila == 1)
                    {
                        //indicefila++;
                    }
                    indice = 0;
                    foreach (DataGridViewColumn columna in dtgFNE.Columns)
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

        private void cmbTipoMetodo_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
