using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.SettingForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsProject.FNE
{
    public partial class FormMain : Form
    {
        private readonly IUnitOfWork unitOfWork;

        public FormMain(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
        }
        private void AbrirFormEnPanel(Form formHijo)
        {
            if (this.panelOpen.Controls.Count > 0)
                this.panelOpen.Controls.RemoveAt(0);
            Form fh = formHijo;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelOpen.Controls.Add(fh);
            this.panelOpen.Tag = fh;
            fh.Show();
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmAddEntry(unitOfWork));
        }

        private void btnCosto_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmAddExpense(unitOfWork));
        }

        private void btnInversion_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmAddInversion(unitOfWork));
        }

        private async void btnEvaluar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Asset> assets = await unitOfWork.AssetClient.GetAllAssetAsync(DataOnMemory.ProjectId);
                List<InvesmentArea> invesmentAreas = await unitOfWork.InvesmentArea.GetProjects(DataOnMemory.ProjectId);
                List<ProjectCost> projectCosts = await unitOfWork.CostClient.GetAllCost(DataOnMemory.ProjectId);
                List<ProjectExpense> projectExpenses = await unitOfWork.ProjectExpense.GetAllExpenses(DataOnMemory.ProjectId);
                List<ProjectEntry> projectEntries = await unitOfWork.ProjectEntryClient.GetEntriesAsync(DataOnMemory.ProjectId);

                if (assets.Count <= 0 || invesmentAreas.Count <= 0)
                {
                    MessageBox.Show("Necesitas agregar una inversión a tu proyecto");
                    AbrirFormEnPanel(new FrmAddInversion(unitOfWork));
                    return;
                }

                if (projectEntries.Count <= 0)
                {
                    MessageBox.Show("Quizás olvidaste agregar ingresos a tu proyecto, por favor añade ingresos...", "Error");
                    AbrirFormEnPanel(new FrmAddEntry(unitOfWork));
                    return;
                }

                if (projectCosts.Count <= 0 || projectExpenses.Count <= 0)
                {
                    if (projectCosts.Count <= 0)
                    {
                        MessageBox.Show("Necesitas agregar más costos a tu proyecto", "Error");
                        AbrirFormEnPanel(SingletonFrm.GetForm(FormType.Cost));
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Necesitas agregar más gastos a tu proyecto", "Error");
                        AbrirFormEnPanel(new FrmAddExpense(unitOfWork));
                        return;

                    }
                }

                if (assets.Count >= 0 && invesmentAreas.Count >= 0 && 
                    projectEntries.Count >= 0 && projectCosts.Count >= 0 && projectExpenses.Count >= 0)
                {
                    AbrirFormEnPanel(new FrmChargeData(unitOfWork, DataOnMemory.ProjectId));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SingletonFrm.GetForm(FormType.Main).Show();
            this.Dispose();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmAddInversion(unitOfWork));
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelButtons.Width == 218)
            {
                btnIngresos.Text = String.Empty;
                btnEvaluar.Text = String.Empty;
                btnCosto.Text = String.Empty;
                btnInversion.Text = String.Empty;
                pbProfile.Size = new Size(41, 41);
                pbProfile.Location = new Point(7, 68);
                btnClose.Location = new Point(176, 725);
                panelButtons.Width = 53;
                
            }
            else
            {
                panelButtons.Width = 218;
                btnIngresos.Text = "Ingreso";
                btnEvaluar.Text = "Evaluar";
                btnCosto.Text = "Costo";
                btnInversion.Text = "Inversion";
                pbProfile.Size = new Size(108, 108);
                
                pbProfile.Location = new Point(56, 69);
                btnClose.Location = new Point(103, 725);
            }
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmAddExpense(unitOfWork));
        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmAddAsset(unitOfWork));
        }
    }
}
