using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsProject.FNE
{
    public partial class FrmAddInversion : Form
    {
        private readonly IUnitOfWork unitOfWork;
        public FrmAddInversion(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
        }

        private void FrmInversion_Load(object sender, EventArgs e)
        {
            ChargeDtg();
            tgIsDiferida.Checked = true;
        }

        private async void ChargeData()
        {
            dtgFNE.DataSource = await unitOfWork.InvesmentArea.GetProjects(DataOnMemory.ProjectId);
        }

        private void tgIsDiferida_CheckedChanged(object sender, EventArgs e)
        {
            if (tgIsDiferida.Checked)
            {
                nupRecuperaciónCt.Visible = false;
                lblRecuperacion.Visible = false;
                lblIsDiferida.Visible = true;
                txtMonto.Visible = true;
                lblMonto.Visible = true;
            }
            else
            {
                nupRecuperaciónCt.Visible = true;
                lblRecuperacion.Visible = true;
                lblIsDiferida.Visible = false;
                txtMonto.Visible = false;
                lblMonto.Visible = false;
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tgIsDiferida.Checked)
                {
                    InvesmentArea invesmentArea = new InvesmentArea()
                    {
                        ProjectId = DataOnMemory.ProjectId,
                        Name = txtName.Texts,
                        Start = 0,
                        Amount = Math.Round(decimal.Parse(txtMonto.Texts), 2),
                        IsDiferida = true,
                        RecoveryCt = 0,
                    };

                    await unitOfWork.InvesmentArea.SetInvesmentArea(invesmentArea);
                    ChargeDtg();
                }
                else
                {
                    InvesmentArea invesmentArea = new InvesmentArea()
                    {
                        ProjectId = DataOnMemory.ProjectId,
                        Name = txtName.Texts,
                        Start = 0,
                        Amount = 0,
                        IsDiferida = true,
                        RecoveryCt = Math.Round(decimal.Parse(txtMonto.Texts), 2),
                    };

                    await unitOfWork.InvesmentArea.SetInvesmentArea(invesmentArea);
                    ChargeDtg();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ChargeDtg()
        {
            dtgFNE.DataSource = await unitOfWork.ProjectExpense.GetAllExpenses(DataOnMemory.ProjectId);
        }
    }
}
