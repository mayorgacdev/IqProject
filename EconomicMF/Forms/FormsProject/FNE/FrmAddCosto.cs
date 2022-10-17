using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Enums;
using EconomicMF.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsProject.FNE
{
    public partial class FrmAddCosto : Form
    {
        private readonly IUnitOfWork unitOfWork;
        public FrmAddCosto(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
        }

        private void FrmCosto_Load(object sender, EventArgs e)
        {
            ChargeDtg();
            cmbTipodeCrecimiento.Items.AddRange(Enum.GetValues(typeof(TipoCrecimiento)).Cast<object>().ToArray());
        }

        private void cmbTipodeCrecimiento_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipodeCrecimiento.SelectedIndex >= 0)
            {
                cmbTipodeCrecimiento.Visible = true;
                lblCosto.Location = new Point(493, 226);
            }
            else
            {
                cmbTipodeCrecimiento.Visible = false;
                lblCosto.Location = new Point(387, 226);
                txtCrecimiento.Size = new Size(800, 39);
            }

            if ((TipoCrecimiento)cmbTipodeCrecimiento.SelectedItem is TipoCrecimiento.SinCrecimiento)
            {
                lblCrecimiento.Visible = false;
                txtCrecimiento.Visible = false;
            }
            else
            {
                lblCrecimiento.Visible = true;
                txtCrecimiento.Visible = true;
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((TipoCrecimiento)cmbTipodeCrecimiento.SelectedItem is not TipoCrecimiento.SinCrecimiento)
                {
                    ProjectCost projectCost = new ProjectCost()
                    {
                        ProjectId = DataOnMemory.ProjectId,
                        Cost = Math.Round(decimal.Parse(txtCosto.Texts), 2),
                        Growth = Math.Round(decimal.Parse(txtCrecimiento.Texts), 2),
                        TypeGrowth = cmbTipodeCrecimiento.SelectedItem.ToString(),
                        Start = int.Parse(txtStart.Texts),
                        End = int.Parse(txtEnd.Texts),
                        CostType = txtTipoDeCosto.Texts,
                    };

                    await unitOfWork.CostClient.SetCost(projectCost);

                    ChargeDtg();
                }
                else
                {
                    ProjectCost projectCost = new ProjectCost()
                    {
                        ProjectId = DataOnMemory.ProjectId,
                        Cost = Math.Round(decimal.Parse(txtCosto.Texts), 2),
                        Growth = 0,
                        TypeGrowth = "SinCrecimiento",
                        Start = int.Parse(txtStart.Texts),
                        End = int.Parse(txtEnd.Texts),
                        CostType = txtTipoDeCosto.Texts,
                    };

                    await unitOfWork.CostClient.SetCost(projectCost);

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
            dtgFNE.DataSource = await unitOfWork.CostClient.GetAllCost(DataOnMemory.ProjectId);
            dtgFNE.Columns[0].Visible = false;
            dtgFNE.Columns[1].Visible = false;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgFNE.SelectedRows.Count == 1)
            {
                int costId = (int)dtgFNE.CurrentRow.Cells[0].Value;
                await unitOfWork.CostClient.DeleteAsync(costId);
                ChargeDtg();
            }
        }

        private void txtNameProject__TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(String.Empty))
            {
                ChargeDtg();
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var assets = await unitOfWork.CostClient.GetAllCost(DataOnMemory.ProjectId);
            decimal.TryParse((txtSearch.Texts), out decimal get);

            var result = assets.Where(e => e.TypeGrowth.Equals(txtSearch.Texts, StringComparison.OrdinalIgnoreCase)
            || e.Cost >= get || e.Growth >= get);

            dtgFNE.DataSource = null;
            dtgFNE.DataSource = result.ToList();
            dtgFNE.Columns[0].Visible = false;
            dtgFNE.Columns[1].Visible = false;
        }

        private void txtCrecimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyNumbers(e);
        }

        private void txtStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyNumbers(e);
        }

        private void txtEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyNumbers(e);
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyNumbers(e);
        }
    }
}
