using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
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
                        IsDiferida = false,
                        RecoveryCt = nupRecuperaciónCt.Value,
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
            dtgFNE.DataSource = null;
            dtgFNE.DataSource = (await unitOfWork.InvesmentArea.GetProjects(DataOnMemory.ProjectId));
            dtgFNE.Columns[0].Visible = false;
            dtgFNE.Columns[1].Visible = false;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgFNE.SelectedRows.Count == 1)
            {
                int inversionId = (int)dtgFNE.CurrentRow.Cells[0].Value;
                await unitOfWork.InvesmentArea.DeleteAsync(inversionId);
                ChargeDtg();
            }
        }

        private async void btnFind_Click(object sender, EventArgs e)
        {
            var assets = await unitOfWork.InvesmentArea.GetProjects(DataOnMemory.ProjectId);
            decimal.TryParse((txtSearch.Texts), out decimal get);

            var result = assets.Where(e => e.Name.Equals(txtSearch.Texts, StringComparison.OrdinalIgnoreCase)
            || e.Amount >= get);

            dtgFNE.DataSource = null;
            dtgFNE.DataSource = result.ToList();
            dtgFNE.Columns[0].Visible = false;
            dtgFNE.Columns[1].Visible = false;
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Texts.Equals(string.Empty))
            {
                ChargeDtg();
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyNumbers(e);
        }
    }
}
